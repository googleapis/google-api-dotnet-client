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

using Google.Apis.Util;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>
    /// Test cases for the Repeatable class.
    /// </summary>
    public class RepeatableTest
    {
        /// <summary>
        /// Tests the creation of repeatables.
        /// </summary>
        [Fact]
        public void CreateRepeatableTest()
        {
            // Reference type test.
            Assert.NotNull((Repeatable<string>) "Test");
            Assert.NotNull((Repeatable<string>) new[] { "Test1", "Test2" });
            Assert.Null((Repeatable<string>) new string[] { });

            // Value type test.
            Assert.NotNull((Repeatable<int>)0);
            Assert.NotNull((Repeatable<int>)1);
            Assert.NotNull((Repeatable<int>) new[] { 1, 2, 3 });
            Assert.Null((Repeatable<int>) new int[] { });

            // Iteration test.
            Repeatable<int> repeatable = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int i = 0;
            foreach (int value in repeatable)
            {
                Assert.Equal(++i, value);
            }
            Assert.Equal(9, i);
        }

        /// <summary>
        /// Tests the implicit/explicit type concversion behaviour of the example method 
        /// when calling a method with a repeatable parameter.
        /// </summary>
        [Fact]
        public void TestImplicitConversion()
        {
            Assert.Equal("Foo", ConcatStrings("Foo", null));
            Assert.Equal("Foobar", ConcatStrings("Foo", "bar"));
            Assert.Equal("FoobarTest", ConcatStrings("Foo", new[] { "bar", "Test" }));
        }

        /// <summary>
        /// Confirms that repeatables can be accessed multiple times, and not only once.
        /// </summary>
        [Fact]
        public void TestRepeatedGet()
        {
            int[] testInput = new[] { 1, 2, 3 };
            Repeatable<int> repeatable = testInput;
            
            // 1. Try
            Assert.Equal(testInput, repeatable);

            // 2. Try
            Assert.Equal(testInput, repeatable);
        }

        /// <summary>
        /// Confirms that repeatables return the same result, even if the source is modified.
        /// </summary>
        [Fact]
        public void TestModifiedSource()
        {
            int[] testInput = new[] { 1, 2, 3 };
            var testList = new List<int>(testInput);
            Repeatable<int> repeatable = testList;

            // Normal access.
            Assert.Equal(testInput, repeatable);

            // Modified list.
            testList.RemoveAt(0);
            Assert.Equal(testInput, repeatable);
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
