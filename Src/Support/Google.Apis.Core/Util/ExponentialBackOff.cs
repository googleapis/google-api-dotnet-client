/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;

namespace Google.Apis.Util
{
    /// <summary>
    /// Implementation of <see cref="IBackOff"/> that increases the back-off period for each retry attempt using a 
    /// randomization function that grows exponentially. In addition, it also adds a randomize number of milliseconds 
    /// for each attempt.
    /// </summary>
    public class ExponentialBackOff : IBackOff
    {
        /// <summary>The maximum allowed number of retries.</summary>
        private const int MaxAllowedNumRetries = 20;

        /// <summary>The random instance which generates a random number to add the to next back-off.</summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// Time span used to bound the back-off jitter.
        /// If the value is <see cref="TimeSpan.Zero"/> then the generated back-off will be exactly 1, 2, 4,
        /// 8, 16, etc. seconds. A valid value is between zero and one second. The default value is 250ms, which means
        /// that the generated back-off will be between 0.75sec and 1.25sec, 1.75sec and 2.25sec, 3.75sec and 4.25sec, and so on.
        /// Only one of <see cref="DeltaBackOff"/> and <see cref="DeltaBackOffPercent"/> may be specified. Both may be zero,
        /// in which case no jitter will be applied.
        /// </summary>
        public TimeSpan DeltaBackOff { get; }

        /// <summary>
        /// Percent of the current unjittered back-off used to bound the jitter.
        /// If the value is set to 10, and the current back-off is 1000ms, then the jitter will be generated
        /// from -100ms to 100ms and the jittered back-off will be from 900ms to 1100ms.
        /// Only one of <see cref="DeltaBackOff"/> and <see cref="DeltaBackOffPercent"/> may be specified. Both may be zero,
        /// in which case no jitter will be applied.
        /// </summary>
        public short DeltaBackOffPercent { get; }

        /// <summary>The maximum number of retries. Default value is <c>10</c>.</summary>
        public int MaxNumOfRetries { get; }

        /// <summary>
        /// Constructs a new exponential back-off with <see cref="DeltaBackOff"/> set to 250ms
        /// and <see cref="MaxNumOfRetries"/> set to 10.
        /// </summary>
        public ExponentialBackOff() : this(TimeSpan.FromMilliseconds(250))
        {
        }

        /// <summary>
        /// Constructs a new exponential back-off with the given delta and maximum retries.
        /// If unspecified, <paramref name="maximumNumOfRetries"/> is set to 10.
        /// </summary>
        public ExponentialBackOff(TimeSpan deltaBackOff, int maximumNumOfRetries = 10)
        {
            if (deltaBackOff < TimeSpan.Zero || deltaBackOff > TimeSpan.FromSeconds(1))
            {
                throw new ArgumentOutOfRangeException(nameof(deltaBackOff));
            }
            if (maximumNumOfRetries < 0 || maximumNumOfRetries > MaxAllowedNumRetries)
            {
                throw new ArgumentOutOfRangeException(nameof(maximumNumOfRetries));
            }

            DeltaBackOff = deltaBackOff;
            MaxNumOfRetries = maximumNumOfRetries;
        }

        private ExponentialBackOff(TimeSpan deltaBackOff, short deltaBackOffPercent, int maxNumOfRetries)
        {
            DeltaBackOff = deltaBackOff;
            DeltaBackOffPercent = deltaBackOffPercent;
            MaxNumOfRetries = maxNumOfRetries;
        }

        /// <summary>
        /// Constructs a new exponential back-off with the given delta percent and maximum retries.
        /// If unspecified, <paramref name="maximumNumOfRetries"/> is set to 10.
        /// </summary>
        public static ExponentialBackOff FromDeltaBackOffPercent(short deltaBackOffPercent, int maximumNumOfRetries = 10)
        {
            if (deltaBackOffPercent < 0 || deltaBackOffPercent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(deltaBackOffPercent));
            }
            if (maximumNumOfRetries < 0 || maximumNumOfRetries > MaxAllowedNumRetries)
            {
                throw new ArgumentOutOfRangeException(nameof(maximumNumOfRetries));
            }

            return new ExponentialBackOff(TimeSpan.Zero, deltaBackOffPercent, maximumNumOfRetries);
        }

        #region IBackOff Members

        /// <inheritdoc/>
        public TimeSpan GetNextBackOff(int currentRetry)
        {
            if (currentRetry <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRetry));
            }
            if (currentRetry > MaxNumOfRetries)
            {
                return TimeSpan.MinValue;
            }

            double rawBackOffMs = Math.Pow(2.0, currentRetry - 1) * 1000;

            // We know at most only one of these will be applied.
            double jitteredBackOffMs = rawBackOffMs + GetTimeSpanBoundedJitter() + GetPercentBoundedJitter(rawBackOffMs);

            return TimeSpan.FromMilliseconds(jitteredBackOffMs);
        }

        private int GetTimeSpanBoundedJitter() =>
            DeltaBackOff == TimeSpan.Zero ?
            0 :
            GetRandomBoundedValue((int)DeltaBackOff.TotalMilliseconds);

        private int GetPercentBoundedJitter(double rawBackOffMs) =>
            DeltaBackOffPercent == 0 ?
            0 :
            GetRandomBoundedValue((int)(DeltaBackOffPercent * rawBackOffMs) / 100);

        private static int GetRandomBoundedValue(int upperBound) =>
            Random.Next(-1 * upperBound, upperBound + 1);

        #endregion
    }
}
