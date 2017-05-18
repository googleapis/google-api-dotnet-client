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

        private readonly TimeSpan deltaBackOff;
        /// <summary>
        /// Gets the delta time span used to generate a random milliseconds to add to the next back-off.
        /// If the value is <see cref="System.TimeSpan.Zero"/> then the generated back-off will be exactly 1, 2, 4,
        /// 8, 16, etc. seconds. A valid value is between zero and one second. The default value is 250ms, which means
        /// that the generated back-off will be [0.75-1.25]sec, [1.75-2.25]sec, [3.75-4.25]sec, and so on.
        /// </summary>
        public TimeSpan DeltaBackOff
        {
            get { return deltaBackOff; }
        }

        private readonly int maxNumOfRetries;
        /// <summary>Gets the maximum number of retries. Default value is <c>10</c>.</summary>
        public int MaxNumOfRetries
        {
            get { return maxNumOfRetries; }
        }

        /// <summary>The random instance which generates a random number to add the to next back-off.</summary>
        private Random random = new Random();

        /// <summary>Constructs a new exponential back-off with default values.</summary>
        public ExponentialBackOff()
            : this(TimeSpan.FromMilliseconds(250))
        {
        }

        /// <summary>Constructs a new exponential back-off with the given delta and maximum retries.</summary>
        public ExponentialBackOff(TimeSpan deltaBackOff, int maximumNumOfRetries = 10)
        {
            if (deltaBackOff < TimeSpan.Zero || deltaBackOff > TimeSpan.FromSeconds(1))
            {
                throw new ArgumentOutOfRangeException("deltaBackOff");
            }
            if (maximumNumOfRetries < 0 || maximumNumOfRetries > MaxAllowedNumRetries)
            {
                throw new ArgumentOutOfRangeException("deltaBackOff");
            }

            this.deltaBackOff = deltaBackOff;
            this.maxNumOfRetries = maximumNumOfRetries;
        }

        #region IBackOff Members

        public TimeSpan GetNextBackOff(int currentRetry)
        {
            if (currentRetry <= 0)
            {
                throw new ArgumentOutOfRangeException("currentRetry");
            }
            if (currentRetry > MaxNumOfRetries)
            {
                return TimeSpan.MinValue;
            }

            // Generate a random number of milliseconds and add it to the current exponential number.
            var randomMilli = (double)random.Next(
                (int)(DeltaBackOff.TotalMilliseconds * -1),
                (int)(DeltaBackOff.TotalMilliseconds * 1));
            int backOffMilli = (int)(Math.Pow(2.0, (double)currentRetry - 1) * 1000 + randomMilli);
            return TimeSpan.FromMilliseconds(backOffMilli);
        }

        #endregion
    }
}
