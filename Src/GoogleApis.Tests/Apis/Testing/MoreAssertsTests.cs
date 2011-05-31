/*
Copyright 2010 Google Inc

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

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Google.Apis.Testing;

namespace Google.Apis.Tests.Apis.Testing
{
    /// <summary>
    /// Tests the "MoreAsserts"-class
    /// </summary>
    [TestFixture]
    public class MoreAssertsTests
    {
        /// <summary>
        /// Tests that the Assert helper method works correctly (lets assert the asserts!)
        /// </summary>
        [Test]
        public void TestCase()
        {
            var actual = new List<string> { "a", "b", "c", "d" };
            MoreAsserts.ContentsEqualAndInOrder(actual.Select(x => x.ToString()), actual);
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(actual.Select(x => x).Reverse(), actual));
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(new List<string> { "a", "b", "c" }, actual));
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(new List<string> { "b", "c", "d" }, actual));
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(new List<string> { "a", "b", "c", "d", "e" }, actual));
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(new List<string> { "a", "b", "c", "e" }, actual));
            Assert.Throws<AssertionException>(
                () => MoreAsserts.ContentsEqualAndInOrder(new List<string> { "b", "b", "c", "d" }, actual));
        }
    }
}