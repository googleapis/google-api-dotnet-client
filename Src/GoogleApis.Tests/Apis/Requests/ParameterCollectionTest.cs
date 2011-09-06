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

using System.Collections.Generic;
using Google.Apis.Requests;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests for the ParameterCollection class.
    /// </summary>
    [TestFixture]
    public class ParameterCollectionTest
    {
        /// <summary>
        /// Tests the constructors.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ParameterCollection());
        }

        /// <summary>
        /// Confirm that different counts of items can be added to the collection.
        /// </summary>
        [Test]
        public void MultipleAddTest()
        {
            var col = new ParameterCollection();

            // 1. Empty case.
            Assert.That(col.Count, Is.EqualTo(0));
            CollectionAssert.AreEqual(new string[0], col.GetAllMatches("test"));

            // 2. One element.
            col.Add("black", "hole");
            Assert.That(col.Count, Is.EqualTo(1));
            CollectionAssert.AreEqual(new[] { "hole" }, col.GetAllMatches("black"));

            // 3. Another element.
            col.Add("white", "dwarf");
            Assert.That(col.Count, Is.EqualTo(2));
            CollectionAssert.AreEqual(new[] { "hole" }, col.GetAllMatches("black"));
            CollectionAssert.AreEqual(new[] { "dwarf" }, col.GetAllMatches("white"));
        }

        /// <summary>
        /// Checks that duplicates are supported.
        /// </summary>
        [Test]
        public void DuplicateTest()
        {
            var col = new ParameterCollection();
            col.Add("chocolate", "cookie");
            col.Add("chocolate", "bar");
            col.Add("chocolate", "pudding");
            Assert.That(col.Count, Is.EqualTo(3));
            CollectionAssert.AreEqual(new[] { "cookie", "bar", "pudding" }, col.GetAllMatches("chocolate"));
        }

        /// <summary>
        /// Tests the FromQueryString method and confirms that duplicates are possible.
        /// </summary>
        [Test]
        public void FromQueryStringTest()
        {
            const string query = "q=foo&q=bar&chocolate=bar";
            var collection = ParameterCollection.FromQueryString(query);
            Assert.That(collection.Count, Is.EqualTo(3));
            CollectionAssert.AreEqual(new[] { "foo", "bar" }, collection.GetAllMatches("q"));
            CollectionAssert.AreEqual(new[] { "bar" }, collection.GetAllMatches("chocolate"));
        }

        /// <summary>
        /// Tests the FromQueryString method.
        /// </summary>
        [Test]
        public void FromDictionaryTest()
        {
            Dictionary<string,object> dictionary = new Dictionary<string,object>();
            dictionary.Add("q", new string[] { "foo", "bar" });
            dictionary.Add("q2", new object[] { "foo", "bar" });
            dictionary.Add("q3", (Repeatable<string>)(new [] { "foo", "bar" }));
            dictionary.Add("chocolate", "bar");
            dictionary.Add("test", null);

            // Test the created dictionary.
            var collection = ParameterCollection.FromDictionary(dictionary);
            CollectionAssert.AreEqual(new[] { "foo", "bar" }, collection.GetAllMatches("q"));
            CollectionAssert.AreEqual(new[] { "foo", "bar" }, collection.GetAllMatches("q2"));
            CollectionAssert.AreEqual(new[] { "foo", "bar" }, collection.GetAllMatches("q3"));
            CollectionAssert.AreEqual(new[] { "bar" }, collection.GetAllMatches("chocolate"));
            CollectionAssert.AreEqual(new string[] { null }, collection.GetAllMatches("test"));
            Assert.That(collection.Count, Is.EqualTo(8));
        }
    }
}
