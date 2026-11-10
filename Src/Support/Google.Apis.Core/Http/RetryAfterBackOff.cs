/*
Copyright 2026 Google LLC

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

using System;
using System.Net.Http;

using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Http;

/// <summary>
/// Default implementation of <see cref="IRetryAfterBackOff"/> that parses standard HTTP <c>Retry-After</c> headers.
/// </summary>
internal class RetryAfterBackOff : IRetryAfterBackOff
{
    private static readonly ILogger Logger = ApplicationContext.Logger.ForType<RetryAfterBackOff>();

    /// <summary>
    /// Gets the clock used to calculate delays for date-based Retry-After headers.
    /// </summary>
    public IClock Clock { get; }

    /// <summary>
    /// Constructs a new <see cref="RetryAfterBackOff"/> instance.
    /// </summary>
    /// <param name="clock">The clock used for calculating date-based delays.</param>
    public RetryAfterBackOff(IClock clock)
    {
        Clock = clock.ThrowIfNull(nameof(clock));
    }

    /// <inheritdoc/>
    public TimeSpan? GetRetryAfterDelay(HttpResponseMessage response)
    {
        try
        {
            var retryAfter = response?.Headers?.RetryAfter;
            if (retryAfter == null)
            {
                return null;
            }

            if (retryAfter.Delta.HasValue)
            {
                TimeSpan delta = retryAfter.Delta.Value < TimeSpan.Zero ? TimeSpan.Zero : retryAfter.Delta.Value;
                Logger.Debug("Retry-After header specified delay of {0}ms.", delta.TotalMilliseconds);
                return delta;
            }

            if (retryAfter.Date.HasValue)
            {
                // To mitigate clock skew between client and server, prefer the server's Date header if available per RFC 9110 §10.2.3.
                DateTimeOffset referenceTime = response.Headers.Date ?? new DateTimeOffset(Clock.UtcNow, TimeSpan.Zero);
                TimeSpan delay = retryAfter.Date.Value - referenceTime;
                // If the Retry-After value is negative or already in the past, clamp to zero.
                delay = delay < TimeSpan.Zero ? TimeSpan.Zero : delay;
                Logger.Debug("Retry-After header specified delay of {0}ms.", delay.TotalMilliseconds);
                return delay;
            }
        }
        catch (FormatException ex)
        {
            Logger.Warning("Failed to parse Retry-After header: {0}.", ex.Message);
        }

        return null;
    }
}
