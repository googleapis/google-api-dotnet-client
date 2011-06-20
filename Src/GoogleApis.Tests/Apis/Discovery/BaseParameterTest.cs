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
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Testing;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary>
    /// Tests the "BaseParameter" class
    /// </summary>
    [TestFixture]
    public class BaseParameterTest
    {
        /// <summary>
        /// Tests if the json properties are handled correctly
        /// </summary>
        [Test]
        public void TestPropertiesCase()
        {
            JsonDictionary dict = new JsonDictionary();
            string name = "TestName";
            dict.Add("location", "path");
            dict.Add("required", true);
            dict.Add("description", "A string description");
            dict.Add("default", "A default value");
            dict.Add("type", "string");
            dict.Add("repeated", true);
            dict.Add("enum", new List<string> { "atom", "json" });
            dict.Add("enumDescriptions", new List<string> { "atom are small particals", "json is my friend" });
            dict.Add("minimum", "43");
            dict.Add("maximum", "53");
            dict.Add("pattern", "[1-9][0-9]*");
            var impl = new ParameterFactory.BaseParameter(new KeyValuePair<string, object>(name, dict));

            Assert.AreEqual("TestName", impl.Name);
            Assert.AreEqual("path", impl.ParameterType);
            Assert.AreEqual("A string description", impl.Description);
            Assert.AreEqual("string", impl.ValueType);
            Assert.AreEqual(true, impl.IsRequired);
            Assert.AreEqual(true, impl.IsRepeatable);
            Assert.AreEqual("A default value", impl.DefaultValue);
            MoreAsserts.ContentsEqualAndInOrder(new List<string> { "atom", "json" }, impl.EnumValues);
            MoreAsserts.ContentsEqualAndInOrder(
                new List<string> { "atom are small particals", "json is my friend" }, impl.EnumValueDescriptions);
            Assert.AreEqual("53", impl.Maximum);
            Assert.AreEqual("43", impl.Minimum);
            Assert.AreEqual("[1-9][0-9]*", impl.Pattern);
        }
    }
}