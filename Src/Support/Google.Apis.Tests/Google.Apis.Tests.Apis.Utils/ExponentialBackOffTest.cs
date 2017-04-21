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

using Google.Apis.Util;
using System;
using System.Linq;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>Tests for <see cref="Google.Apis.Util.ExponentialBackOff"/>.</summary>
    public class ExponentialBackOffTest
    {
        /// <summary>Tests setting invalid value as <c>currentRetry</c> parameter.</summary>
        [Fact]
        public void GetNextBackOff_InvalidValue()
        {
            ExponentialBackOff backOff = new ExponentialBackOff();
            try
            {
                backOff.GetNextBackOff(0);
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException) { }

            try
            {
                backOff.GetNextBackOff(-2);
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException) { }
        }

        /// <summary>Tests constructor with invalid time span object (less then 0 or greater than 1sec).</summary>
        [Fact]
        public void Constructor_InvalidValue()
        {
            // Invalid delta.
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(-1));
            SubtestConstructor_InvalidValue(TimeSpan.FromDays(-1));
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(1001));
            // Invalid max.
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(500), -1);
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(500), 21);

        }

        /// <summary>A helper subtest to test invalid value given to the constructor.</summary>
        private void SubtestConstructor_InvalidValue(TimeSpan ts, int max = 10)
        {
            try
            {
                ExponentialBackOff backOff = new ExponentialBackOff(ts, max);
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentOutOfRangeException) { }
        }

        /// <summary>Tests next back-off time span maximum, minimum and average values for tries 1 to 15.</summary>
        [Fact]
        public void GetNextBackOff_Retry1To15()
        {
            foreach (int i in Enumerable.Range(1, 10))
            {
                SubtestGetNextBackOff(i);
                SubtestGetNextBackOff(i, TimeSpan.FromMilliseconds(20));
                SubtestGetNextBackOff(i, TimeSpan.FromMilliseconds(0), 0);
            }
        }

        /// <summary>Test helper for testing retrying using exponential back-off.</summary>
        /// <param name="retry">Index of current retry.</param>
        /// <param name="delta">The delta the exponential back-off uses. 
        /// <seealso cref="ExponentialBackOff.DeltaBackOff"/> for more details.
        /// </param>
        /// <param name="epsilon">Used for checking the average result of the input retry [In milliseconds].</param>
        private void SubtestGetNextBackOff(int retry, Nullable<TimeSpan> delta = null, int epsilon = 20)
        {
            int expectedMillis = (int)Math.Pow(2, (retry - 1)) * 1000;
            ExponentialBackOff backOff = delta.HasValue ?
                new ExponentialBackOff(delta.Value) : new ExponentialBackOff();

            TimeSpan min = TimeSpan.FromMilliseconds(expectedMillis - backOff.DeltaBackOff.TotalMilliseconds);
            TimeSpan max = TimeSpan.FromMilliseconds(expectedMillis + backOff.DeltaBackOff.TotalMilliseconds);
            long total = 0;
            long repeat = 1000;
            for (int i = 0; i < repeat; ++i)
            {
                var ts = backOff.GetNextBackOff(retry);
                Assert.InRange(ts, min, max);
                total += (int)ts.TotalMilliseconds;
            }

            var average = (int)(total / repeat);
            Assert.InRange(average, expectedMillis - epsilon, expectedMillis + epsilon);
        }

        /// <summary>Tests next back-off time span with specific maximum of retries.</summary>
        [Fact]
        public void GetNextBackOff_MaxNumRetries()
        {
            SubtestGetNextBackOff_MaxNumRetries(1);
            SubtestGetNextBackOff_MaxNumRetries(10);
            SubtestGetNextBackOff_MaxNumRetries(11);
        }

        /// <summary>A helper test for testing the <c>GetNextBackOff</c> logic.</summary>
        private void SubtestGetNextBackOff_MaxNumRetries(int max)
        {
            ExponentialBackOff backOff = new ExponentialBackOff(TimeSpan.Zero, max);

            for (int i = 1; i <= 10; ++i)
            {
                if (i <= max)
                {
                    Assert.NotEqual(TimeSpan.MinValue, backOff.GetNextBackOff(i));
                }
                else
                {
                    Assert.Equal(TimeSpan.MinValue, backOff.GetNextBackOff(i));
                }
            }
        }
    }
}
