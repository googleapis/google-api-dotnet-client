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
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary> Tests for <see cref="Google.Apis.Util.ExponentialBackOff"/>. </summary>
    [TestFixture]
    public class ExponentialBackOffTest
    {
        /// <summary> Tests setting invalid value as <c>currentRetry</c> parameter. </summary>
        [Test]
        public void GetNextBackOff_InvalidValue()
        {
            ExponentialBackOff backOff = new ExponentialBackOff();
            try
            {
                backOff.GetNextBackOff(0);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException) { }

            try
            {
                backOff.GetNextBackOff(-2);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        /// <summary> Tests constructor with invalid time span object (<0 or >1sec). </summary>
        [Test]
        public void Constructor_InvalidValue()
        {
            // invalid delta
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(-1));
            SubtestConstructor_InvalidValue(TimeSpan.FromDays(-1));
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(1001));
            // invalid max
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(500), -1);
            SubtestConstructor_InvalidValue(TimeSpan.FromMilliseconds(500), 21);

        }

        /// <summary> An helper subtest to test invalid value given to the constructor. </summary>
        private void SubtestConstructor_InvalidValue(TimeSpan ts, int max = 10)
        {
            try
            {
                ExponentialBackOff backOff = new ExponentialBackOff(ts, max);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        /// <summary> Tests next back-off time span maximum, minimum and average values for tries 1 to 15. </summary>
        [Test]
        public void GetNextBackOff_Retry1To15()
        {
            foreach (int i in Enumerable.Range(1, 10))
            {
                SubtestGetNextBackOff(i);
                SubtestGetNextBackOff(i, TimeSpan.FromMilliseconds(20));
                SubtestGetNextBackOff(i, TimeSpan.FromMilliseconds(0), 0);
            }
        }

        /// <summary> Test helper for testing retrying using exponential back-off.</summary>
        /// <param name="retry">Index of current retry.</param>
        /// <param name="delta">The delta the exponential back-off uses. 
        /// <seealso cref="ExponentialBack.DeltaBackOff"/> for more details.
        /// </param>
        /// <param name="epsilon">Used for checking the average result of the input retry [In milliseconds].</param>
        private void SubtestGetNextBackOff(int retry, Nullable<TimeSpan> delta = null, int epsilon = 20)
        {
            int expectedMiliis = (int)Math.Pow(2, (retry - 1)) * 1000;
            ExponentialBackOff backOff = delta.HasValue ?
                new ExponentialBackOff(delta.Value) : new ExponentialBackOff();

            TimeSpan min = TimeSpan.FromMilliseconds(expectedMiliis - backOff.DeltaBackOff.TotalMilliseconds);
            TimeSpan max = TimeSpan.FromMilliseconds(expectedMiliis + backOff.DeltaBackOff.TotalMilliseconds);
            long total = 0;
            long repeat = 1000;
            for (int i = 0; i < repeat; ++i)
            {
                var ts = backOff.GetNextBackOff(retry);
                Assert.That(ts, Is.InRange(min, max));
                total += (int)ts.TotalMilliseconds;
            }

            var avarage = (int)(total / repeat);
            Assert.That(avarage, Is.InRange(expectedMiliis - epsilon, expectedMiliis + epsilon));
        }


        /// <summary> Tests next back-off time span with specific maximum of retries. </summary>
        [Test]
        public void GetNextBackOff_MaxNumRetries()
        {
            SubtestGetNextBackOff_MaxNumRetries(1);
            SubtestGetNextBackOff_MaxNumRetries(10);
            SubtestGetNextBackOff_MaxNumRetries(11);
        }

        public void SubtestGetNextBackOff_MaxNumRetries(int max)
        {
            ExponentialBackOff backOff = new ExponentialBackOff(TimeSpan.Zero, max);

            for (int i = 1; i <= 10; ++i)
            {
                if (i <= max)
                {
                    Assert.AreNotEqual(TimeSpan.MinValue, backOff.GetNextBackOff(i));
                }
                else
                {
                    Assert.AreEqual(TimeSpan.MinValue, backOff.GetNextBackOff(i));
                }
            }
        }
    }
}
