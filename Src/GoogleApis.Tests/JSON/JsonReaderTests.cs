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
using Google.Apis.Json;
using NUnit.Framework;
using System.Collections;

namespace Google.Apis.Tests.Json
{
    /// <summary>
    /// This is a test class for TokenStream_JSONReaderTest and is intended
    /// to contain all TokenStream_JSONReaderTest Unit Tests
    ///</summary>
    [TestFixture]
    public class JsonReaderTest
    {
        /// <summary>
        /// Tests if JsonReader is able to parse a empty json document
        /// </summary>
        [Test]
        public void ParseEmptyObjectTest()
        {
            string jsonAsText = "{}";
            object o = JsonReader.Parse(jsonAsText);
            Assert.IsInstanceOf(typeof(JsonDictionary), o);
            JsonDictionary dict = o as JsonDictionary;
            Assert.AreEqual(0, dict.Count);

            jsonAsText = "{'simpleProp':1, 'emptyObject':{}}";
            o = JsonReader.Parse(jsonAsText);
            Assert.IsInstanceOf(typeof(JsonDictionary), o);
            dict = o as JsonDictionary;
            Assert.AreEqual(2, dict.Count);
            Assert.AreEqual(1, dict["simpleProp"]);
            Assert.That(dict.ContainsKey("emptyObject"), "Parsed object did not contian emptyObject");
            JsonDictionary empty = dict["emptyObject"] as JsonDictionary;
            Assert.IsNotNull(empty);
            Assert.AreEqual(0, empty.Count);
        }

        /// <summary>
        /// Checks if the JsonReader is able to parse nested expressions
        /// </summary>
        [Test]
        public void ParseNestedTest()
        {
            // Create and parse the JSON
            const string jsonAsText =
                @"{
                                     ""basePath"": ""/moderator/v1/"",
                                     ""auth"": {
                                      ""oauth2"": {
                                       ""scopes"": {
                                        ""https://www.googleapis.com/auth/moderator"": {
                                         ""description"": ""Manage your activity in Google Moderator""
                                        }
                                       }
                                      }
                                     },
                                     ""features"": [
                                      ""dataWrapper""
                                     ] }";
            object obj = JsonReader.Parse(jsonAsText);

            // Convert to JSON dictionary
            Assert.IsInstanceOf<JsonDictionary>(obj);
            var dict = (JsonDictionary) obj;

            // Validate output
            Assert.That(dict.Count, Is.EqualTo(3));
            Assert.That(dict["basePath"], Is.EqualTo("/moderator/v1/"));
            Assert.That(dict["auth"], Is.InstanceOf<JsonDictionary>());
            Assert.That(((JsonDictionary) dict["auth"])["oauth2"], Is.InstanceOf<JsonDictionary>());
            Assert.That(dict["features"], Is.InstanceOf<List<object>>());
            Assert.That(((List<object>) dict["features"])[0], Is.EqualTo("dataWrapper"));
        }

        /// <summary>
        /// Checks if the JsonReader is able to correctly parse sequential expressions.
        /// </summary>
        [Test]
        public void ParseSequential()
        {
            const string JSON = @"{
                                        ""testField"": 1,
                                        ""emptyClass"": { },
                                        ""anotherField"": 2,
                                        ""andAgain"": 3
                                  }";

            object obj = JsonReader.Parse(JSON);

            // Convert to JSON dictionary.
            Assert.IsInstanceOf<JsonDictionary>(obj);
            var dict = (JsonDictionary)obj;

            // Validate the output.
            Assert.AreEqual(1, dict["testField"]);
            Assert.IsInstanceOf<JsonDictionary>(dict["emptyClass"]);
            CollectionAssert.IsEmpty(((JsonDictionary)dict["emptyClass"]).Keys);
            Assert.AreEqual(2, dict["anotherField"]);
            Assert.AreEqual(3, dict["andAgain"]);
            Assert.AreEqual(4, dict.Count);
        }

        /// <summary>
        /// A test for Parse
        ///</summary>
        [Test]
        public void ParseTest()
        {
            string jsonAsText = "[ true, \"Value2\", false, null ]";
            object o = JsonReader.Parse(jsonAsText);
            Assert.IsInstanceOf(typeof(List<object>), o);
            List<object> a = o as List<object>;
            Assert.AreEqual(4, a.Count);
            Assert.AreEqual(false, a[2]);

            jsonAsText = "{ \"Name\" : true }";
            o = JsonReader.Parse(jsonAsText);
            Assert.IsTrue(o is JsonDictionary);

            jsonAsText = "{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }";
            o = JsonReader.Parse(jsonAsText);
            Assert.IsTrue(o is JsonDictionary);
            JsonDictionary j = o as JsonDictionary;
            a = j["name"] as List<object>;
            Assert.IsNotNull(a);
        }

        /// <summary>
        /// Checks whether JSON documents containing urls as keys can be parsed
        /// </summary>
        [Test]
        public void ParseUrlsTest()
        {
            // Create and parse the JSON
            const string jsonAsText =
                "{ \"one\": true, \"https://www.googleapis.com/auth/moderator\": \"two\", \"three\": true }";
            object obj = JsonReader.Parse(jsonAsText);

            // Convert to JSON dictionary
            Assert.IsInstanceOf<JsonDictionary>(obj);
            var dict = (JsonDictionary) obj;

            // Validate output
            Assert.That(dict.Count, Is.EqualTo(3));
            Assert.That(dict["one"], Is.True);
            Assert.That(dict["https://www.googleapis.com/auth/moderator"], Is.EqualTo("two"));
            Assert.That(dict["three"], Is.True);
        }
    }
}