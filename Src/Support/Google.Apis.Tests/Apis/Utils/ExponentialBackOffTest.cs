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
        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void GetNextBackOff_InvalidValue(int value)
        {
            ExponentialBackOff backOff = new ExponentialBackOff();
            Assert.Throws<ArgumentOutOfRangeException>(() => backOff.GetNextBackOff(value));
        }

        /// <summary>Tests constructor with invalid maximum number of retries (less than 0 or greater than 20).</summary>
        [Theory]
        [InlineData(-1)]
        [InlineData(21)]
        public void Constructor_InvalidMaxRetries(int max) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new ExponentialBackOff(TimeSpan.FromMilliseconds(500), max));

        /// <summary>Tests constructor with invalid time span object (less than 0 or greater than 1sec).</summary>
        [Theory]
        [InlineData(-1)]
        [InlineData(-1 * TimeSpan.TicksPerDay / TimeSpan.TicksPerMillisecond)]
        [InlineData(1001)]
        public void Constructor_InvalidTimespanJitter(int deltaBackoffMs)
        {
            var deltaBackoff = TimeSpan.FromMilliseconds(deltaBackoffMs);
            Assert.Throws<ArgumentOutOfRangeException>(() => new ExponentialBackOff(deltaBackoff));
        }

        /// <summary>Tests constructor with invalid percent jitter (less than 0 or greater than 100).</summary>
        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void Constructor_InvalidValue(short percentJitter)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ExponentialBackOff.FromDeltaBackOffPercent(percentJitter));
        }

        [Fact]
        public void GetNextBackOff_TimestampBoundJitter()
        {
            foreach (int i in Enumerable.Range(1, 10))
            {
                SubtestGetNextBackOff_TimestampBoundJitter(i);
                SubtestGetNextBackOff_TimestampBoundJitter(i, TimeSpan.FromMilliseconds(20));
                SubtestGetNextBackOff_TimestampBoundJitter(i, TimeSpan.Zero);
            }
        }

        /// <summary>Test helper for testing retrying using exponential back-off.</summary>
        /// <param name="retry">Index of current retry.</param>
        /// <param name="delta">The delta the exponential back-off uses. 
        /// <seealso cref="ExponentialBackOff.DeltaBackOff"/> for more details.
        /// </param>
        private void SubtestGetNextBackOff_TimestampBoundJitter(int retry, TimeSpan? delta = null)
        {
            int expectedMillis = (int)Math.Pow(2, (retry - 1)) * 1000;
            ExponentialBackOff backOff = delta.HasValue ? new ExponentialBackOff(delta.Value) : new ExponentialBackOff();

            TimeSpan min = TimeSpan.FromMilliseconds(expectedMillis - backOff.DeltaBackOff.TotalMilliseconds);
            TimeSpan max = TimeSpan.FromMilliseconds(expectedMillis + backOff.DeltaBackOff.TotalMilliseconds);

            for (int i = 0; i < 1000; ++i)
            {
                var ts = backOff.GetNextBackOff(retry);
                Assert.InRange(ts, min, max);
            }
        }

        [Fact]
        public void GetNextBackOff_PercentBoundJitter()
        {
            foreach (int i in Enumerable.Range(1, 10))
            {
                SubtestGetNextBackOff_PercentBoundJitter(i, 10);
                SubtestGetNextBackOff_PercentBoundJitter(i, 100);
                SubtestGetNextBackOff_PercentBoundJitter(i, 0);
            }
        }

        /// <summary>Test helper for testing retrying using exponential back-off.</summary>
        /// <param name="retry">Index of current retry.</param>
        /// <param name="delta">The delta the exponential back-off uses. 
        /// <seealso cref="ExponentialBackOff.DeltaBackOff"/> for more details.
        /// </param>
        private void SubtestGetNextBackOff_PercentBoundJitter(int retry, short percent)
        {
            int expectedMillis = (int)Math.Pow(2, (retry - 1)) * 1000;
            ExponentialBackOff backOff = ExponentialBackOff.FromDeltaBackOffPercent(percent);

            int jitterBound = percent * expectedMillis / 100;
            TimeSpan min = TimeSpan.FromMilliseconds(expectedMillis - jitterBound);
            TimeSpan max = TimeSpan.FromMilliseconds(expectedMillis + jitterBound);

            for (int i = 0; i < 1000; ++i)
            {
                var ts = backOff.GetNextBackOff(retry);
                Assert.InRange(ts, min, max);
            }
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
