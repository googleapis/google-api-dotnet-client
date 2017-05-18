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

using Google.Apis.Requests.Parameters;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests.Parameters
{
    /// <summary>Tests for the ParameterCollection class.</summary>
    public class ParameterCollectionTest
    {
        /// <summary>Tests the constructors.</summary>
        [Fact]
        public void ConstructTest()
        {
            new ParameterCollection(); // Assert does not throw
        }

        /// <summary>Confirm that different count of items can be added to the collection.</summary>
        [Fact]
        public void MultipleAddTest()
        {
            var col = new ParameterCollection();

            // 1. Empty case.
            Assert.Equal(0, col.Count);
            Assert.Equal(new string[0], col.GetAllMatches("test"));

            // 2. One element.
            col.Add("black", "hole");
            Assert.Equal(1, col.Count);
            Assert.Equal(new[] { "hole" }, col.GetAllMatches("black"));

            // 3. Another element.
            col.Add("white", "dwarf");
            Assert.Equal(2, col.Count);
            Assert.Equal(new[] { "hole" }, col.GetAllMatches("black"));
            Assert.Equal(new[] { "dwarf" }, col.GetAllMatches("white"));
        }

        /// <summary>Checks that duplicates are supported.</summary>
        [Fact]
        public void DuplicateTest()
        {
            var col = new ParameterCollection();
            col.Add("chocolate", "cookie");
            col.Add("chocolate", "bar");
            col.Add("chocolate", "pudding");
            Assert.Equal(3, col.Count);
            Assert.Equal(new[] { "cookie", "bar", "pudding" }, col.GetAllMatches("chocolate"));
        }

        /// <summary>Tests the FromQueryString method and confirms that duplicates are possible.</summary>
        [Fact]
        public void FromQueryStringTest()
        {
            const string query = "q=foo1&q=bar&q=foo2&chocolate=bar";
            var collection = ParameterCollection.FromQueryString(query);
            Assert.Equal(4, collection.Count);
            Assert.Equal(new[] { "foo1", "bar", "foo2" }, collection.GetAllMatches("q"));
            Assert.Equal(new[] { "bar" }, collection.GetAllMatches("chocolate"));
        }

        /// <summary>Tests the FromQueryString method throws exception on invalid input.</summary>
        [Fact]
        public void FromQueryStringTest_Invalid()
        {
            const string query = "q=foo1&q=bar&q=foo2=invalid&chocolate=bar";
            Assert.Throws<ArgumentException>(() => ParameterCollection.FromQueryString(query));
        }

        /// <summary>Tests the FromQueryString method.</summary>
        [Fact]
        public void FromDictionaryTest()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("q", new string[] { "foo", "bar" });
            dictionary.Add("q2", new object[] { "foo", "bar" });
            dictionary.Add("q3", (Repeatable<string>)(new[] { "foo", "bar" }));
            dictionary.Add("chocolate", "bar");
            dictionary.Add("test", null);

            // Test the created dictionary.
            var collection = ParameterCollection.FromDictionary(dictionary);
            Assert.Equal(new[] { "foo", "bar" }, collection.GetAllMatches("q"));
            Assert.Equal(new[] { "foo", "bar" }, collection.GetAllMatches("q2"));
            Assert.Equal(new[] { "foo", "bar" }, collection.GetAllMatches("q3"));
            Assert.Equal(new[] { "bar" }, collection.GetAllMatches("chocolate"));
            Assert.Equal(new string[] { null }, collection.GetAllMatches("test"));
            Assert.Equal(8, collection.Count);
        }
    }
}
