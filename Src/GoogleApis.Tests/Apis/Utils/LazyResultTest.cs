/*
Copyright 2011 Google Inc

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
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>
    /// Tests for the LazyResult class.
    /// </summary>
    [TestFixture]
    public class LazyResultTest
    {
        /// <summary>
        /// Validates the constructor of this class.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new LazyResult<int>(() => 42));
            Assert.DoesNotThrow(() => new LazyResult<object>(() => "something"));
            Assert.Throws<ArgumentNullException>(() => new LazyResult<int>(null));
        }

        /// <summary>
        /// Tests whether the fetch function is evaluated lazily.
        /// </summary>
        [Test]
        public void IsLazyTest()
        {
            bool hasBeenFetched = false;
            Func<bool> fetchFunction = () => (hasBeenFetched = true);

            // Try fetching the result.
            var result = new LazyResult<bool>(fetchFunction);
            Assert.IsFalse(hasBeenFetched);
            Assert.IsTrue(result.GetResult());
            Assert.IsTrue(hasBeenFetched);
            
            // Try a second fetch. Confirm that a cached result will be used.
            hasBeenFetched = false;
            Assert.IsTrue(result.GetResult());
            Assert.IsFalse(hasBeenFetched);
        }
    }
}
