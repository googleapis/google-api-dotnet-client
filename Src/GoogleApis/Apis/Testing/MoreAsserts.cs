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

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Google.Apis.Testing
{
    /// <summary>
    /// Assertion helper methods
    /// </summary>
    public class MoreAsserts
    {
        /// <summary>
        /// Asserts whether both enumerables have the equal content, and whether it is in the same order
        /// </summary>
        public static void ContentsEqualAndInOrder(IEnumerable expected, IEnumerable actual)
        {
            var expectedEnum = expected.GetEnumerator();
            var actualEnum = actual.GetEnumerator();
            int index = 0;
            while (expectedEnum.MoveNext())
            {
                if (actualEnum.MoveNext() == false)
                {
                    Assert.Fail("Actual has less items then Expected at index " + index);
                }
                Assert.AreEqual(expectedEnum.Current, actualEnum.Current, "Found different elements at index " + index);
                index++;
            }
            if (actualEnum.MoveNext())
            {
                Assert.Fail("Actual has more items then Expected at index " + index);
            }
        }

        /// <summary>
        /// Asserts that the list is empty
        /// </summary>
        public static void IsEmpty<T>(IList<T> list)
        {
            if (list == null)
            {
                Assert.Fail("List Was null");
            }
            if (list.Count > 0)
            {
                Assert.Fail("List had a count of " + list.Count + " and was expected to be empty.");
            }
        }

        /// <summary>
        /// Asserts that the enumerable is empty
        /// </summary>
        public static void IsEmpty<T>(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                Assert.Fail("Collection was null");
            }

            Assert.False(collection.GetEnumerator().MoveNext(), "Collection had an element as was expected to be empty");
        }
    }
}