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
            // null out _refreshTask if so; it will be 
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
            TokenResponse currentToken;
            Task<TokenResponse> currentRefreshTask;
            lock (_lock)
            {
                currentToken = _token;
                currentRefreshTask = _refreshTask;
            }
            // Note: IsExpired is really "should be refreshed".
            if (currentToken == null || currentToken.IsExpired(_clock))
            {
                // Start a refresh if nothing else is already refreshing the token.
                // It's possible to end up with multiple requests here (if another thread started a task while
                // we were checking for expiry) but that's a small window, and harmless so long as there aren't *too*
                // many requests.
                if (currentRefreshTask == null)
                {
                    currentRefreshTask = RefreshTokenAsync();
                    lock (_lock)
                    {
                        _refreshTask = currentRefreshTask;
                    }
                }
                // If the current token is still valid for a while, we can use it anyway. Otherwise,
                // we need to wait for our refresh task to complete.
                if (currentToken == null || currentToken.IsEffectivelyExpired(_clock))
                {
                    Task<TokenResponse> taskToAwait = currentRefreshTask;
                    if (cancellationToken.CanBeCanceled)
                    {
                        // Reasonably simple way of creating a task that can be cancelled, based on another task.
                        // (It would be nice if this were simpler.)
                        taskToAwait = taskToAwait.ContinueWith(
                            task => ResultWithUnwrappedExceptions(task),
                            cancellationToken,
                            TaskContinuationOptions.None,
                            TaskScheduler.Default);
                    }
                    currentToken = await taskToAwait.ConfigureAwait(false);
                }
            }
            return currentToken.AccessToken;
        }


        private async Task<TokenResponse> RefreshTokenAsync()
        {
            _logger.Debug("Token has expired, trying to get a new one.");
            try
            {
                // TODO: Is using a cancellation task of "none" definitely appropriate? If this hangs forever,
                // all tasks waiting for it will also hang forever, unless they have cancellation tokens.
                var successTask = await _refreshAction(CancellationToken.None).ConfigureAwait(false);
                if (successTask)
                {
                    _logger.Info("New access token was received successfully");
                    return Token;
                }
                else
                {
                    throw new InvalidOperationException("The access token has expired could not be refreshed");
                }
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
