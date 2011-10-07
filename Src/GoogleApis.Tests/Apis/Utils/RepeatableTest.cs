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

using System.Linq;
using Google.Apis.Util;
using NUnit.Framework;
using System.Collections.Generic;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>
    /// Test cases for the Repeatable class.
    /// </summary>
    [TestFixture]
    public class RepeatableTest
    {
        /// <summary>
        /// Tests the creation of repeatables.
        /// </summary>
        [Test]
        public void CreateRepeatableTest()
        {
            // Reference type test.
            Assert.IsNotNull((Repeatable<string>) "Test");
            Assert.IsNotNull((Repeatable<string>) new[] { "Test1", "Test2" });
            Assert.IsNull((Repeatable<string>) new string[] { });

            // Value type test.
            Assert.IsNotNull((Repeatable<int>)0);
            Assert.IsNotNull((Repeatable<int>)1);
            Assert.IsNotNull((Repeatable<int>) new[] { 1, 2, 3 });
            Assert.IsNull((Repeatable<int>) new int[] { });

            // Iteration test.
            Repeatable<int> repeatable = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = 0;
            foreach (int value in repeatable)
            {
                Assert.AreEqual(++i, value);
            }
            Assert.AreEqual(9, i);
        }

        /// <summary>
        /// Tests the implicit/explicit type concversion behaviour of the example method 
        /// when calling a method with a repeatable parameter.
        /// </summary>
        [Test]
        public void TestImplicitConversion()
        {
            Assert.AreEqual("Foo", ConcatStrings("Foo", null));
            Assert.AreEqual("Foobar", ConcatStrings("Foo", "bar"));
            Assert.AreEqual("FoobarTest", ConcatStrings("Foo", new[] { "bar", "Test" }));
        }

        /// <summary>
        /// Confirms that repeatables can be accessed multiple times, and not only once.
        /// </summary>
        [Test]
        public void TestRepeatedGet()
        {
            int[] testInput = new[] { 1, 2, 3 };
            Repeatable<int> repeatable = testInput;
            
            // 1. Try
            CollectionAssert.AreEqual(testInput, repeatable);

            // 2. Try
            CollectionAssert.AreEqual(testInput, repeatable);
        }

        /// <summary>
        /// Confirms that repeatables return the same result, even if the source is modified.
        /// </summary>
        [Test]
        public void TestModifiedSource()
        {
            int[] testInput = new[] { 1, 2, 3 };
            var testList = new List<int>(testInput);
            Repeatable<int> repeatable = testList;

            // Normal access.
            CollectionAssert.AreEqual(testInput, repeatable);

            // Modified list.
            testList.RemoveAt(0);
            CollectionAssert.AreEqual(testInput, repeatable);
        }

        private static string ConcatStrings(string normalParameter, Repeatable<string> repeatable)
        {
            if (repeatable == null)
            {
                return normalParameter;
            }

            return repeatable.Aggregate(normalParameter, (current, str) => current + str);
        }
    }
}
