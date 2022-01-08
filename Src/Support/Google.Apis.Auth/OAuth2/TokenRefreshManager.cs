/*
Copyright 2018 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Encapsulation of token refresh behaviour. This isn't entirely how we'd design the code now (in terms of the
    /// callback in particular) but it fits in with the exposed API surface of ServiceCredential and UserCredential.
    /// </summary>
    internal sealed class TokenRefreshManager
    {
        // Immutable state
        private readonly object _lock = new object();
        private readonly IClock _clock;
        private readonly ILogger _logger;
        private readonly Func<CancellationToken, Task<bool>> _refreshAction;

        // Mutable state, guarded with _lock.
        private TokenResponse _token;
        private Task<TokenResponse> _refreshTask;

        /// <summary>
        /// Creates a manager which executes the given refresh action when required.
        /// </summary>
        /// <param name="refreshAction">The refresh action which will populate the Token property when successful.</param>
        /// <param name="clock">The clock to consult for timeouts.</param>
        /// <param name="logger">The logger to use to record refreshes.</param>
        internal TokenRefreshManager(Func<CancellationToken, Task<bool>> refreshAction, IClock clock, ILogger logger)
        {
            _refreshAction = refreshAction;
            _clock = clock;
            _logger = logger;
        }

        internal TokenResponse Token
        {
            get
            {
                lock (_lock)
                {
                    return _token;
                }
            }
            // The token may be set due to operations other than GetAccessTokenForRequestAsync, but we don't need to
            // null out _refreshTask if so.
            set
            {
                lock (_lock)
                {
                    _token = value;
                }
            }
        }

        internal async Task<string> GetAccessTokenForRequestAsync(CancellationToken cancellationToken)
        {
            Task<TokenResponse> refreshTask;
            lock (_lock)
            {
                // If current token is not soft-expired, then return it.
                if (_token != null && !_token.IsExpired(_clock))
                {
                    return _token.AccessToken;
                }
                // Token refresh required, so start a task if not already started
                if (_refreshTask == null)
                {
                    // Task.Run is required if the refresh completes synchronously,
                    // otherwise _refreshTask is updated in an incorrect order.
                    // And Task.Run also means it can be run here in the lock.
                    _refreshTask = Task.Run(RefreshTokenAsync);

                    // Let's make sure that exceptions in _refreshTask are always observed.
                    // Note that we don't keep a reference to this new task as we don't really
                    // care about the errors, and we want calling code explicitly awaiting on _refreshTask
                    // to actually fail if there's an error. We just schedule it to run and that's enough for
                    // avoiding exception observavility issues.
                    _refreshTask.ContinueWith(LogException, TaskContinuationOptions.OnlyOnFaulted);
                }
                // If current token is not hard-expired, then return it.
                if (_token != null && !_token.IsEffectivelyExpired(_clock))
                {
                    return _token.AccessToken;
                }
                refreshTask = _refreshTask;

                async Task LogException(Task task)
                {
                    try
                    {
                        await task.ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        _logger.Debug($"An error occured on a background token refresh task.{Environment.NewLine}{ex}");
                    }
                }
            }
            // Otherwise block on refresh task.
            if (cancellationToken.CanBeCanceled)
            {
                // Reasonably simple way of creating a task that can be cancelled, based on another task.
                // (It would be nice if this were simpler.)
                refreshTask = refreshTask.ContinueWith(
                    task => ResultWithUnwrappedExceptions(task),
                    cancellationToken,
                    TaskContinuationOptions.None,
                    TaskScheduler.Default);
            }
            return (await refreshTask.ConfigureAwait(false)).AccessToken;
        }

        internal static readonly TimeSpan[] RefreshTimeouts = new[] { TimeSpan.FromSeconds(12), TimeSpan.FromMinutes(1), TimeSpan.FromMinutes(5) };
        private async Task<TokenResponse> RefreshTokenAsync()
        {
            _logger.Debug("Token has expired, trying to get a new one.");
            try
            {
                List<string> errors = null;
                foreach (var timeout in RefreshTimeouts)
                {
                    var token = new CancellationTokenSource(timeout).Token;
                    try
                    {
                        var success = await _refreshAction(token).ConfigureAwait(false);
                        if (success)
                        {
                            _logger.Info("New access token was received successfully");
                            return Token;
                        }
                        else
                        {
                            // If unsuccessful, but didn't timeout, then retry if all retries haven't been exhausted.
                            (errors = errors ?? new List<string>()).Add("refresh error");
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        // Do nothing, attempt another refresh if all retries haven't been exhausted.
                        _logger.Debug("Token refresh time-out after {0} seconds", (int)timeout.TotalSeconds);
                        (errors = errors ?? new List<string>()).Add("timeout");
                    }
                }
                throw new InvalidOperationException($"The access token has expired and could not be refreshed. Errors: {string.Join(", ", errors)}");
            }
            finally
            {
                // If the task completed successfully, Token will have been set.
                // Otherwise, we'll want to start a new refresh task next time we're asked for a token.
                lock (_lock)
                {
                    _refreshTask = null;
                }
            }
        }

        // Helper method used in the continuation when trying to create a cancellable task.
        private static T ResultWithUnwrappedExceptions<T>(Task<T> task)
        {
            try
            {
                task.Wait();
            }
            catch (AggregateException e)
            {
                // Unwrap the first exception, a bit like await would.
                // It's very unlikely that we'd ever see an AggregateException without an inner exceptions,
                // but let's handle it relatively gracefully.
                // Using ExceptionDispatchInfo to keep the original exception stack trace.
                ExceptionDispatchInfo.Capture(e.InnerExceptions.FirstOrDefault() ?? e).Throw();
            }
            return task.Result;
        }
    }
}
