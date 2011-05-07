using System;
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Testing;

namespace Google.Apis.Tests.Apis.Discovery
{
    [TestFixture()]
    public class BaseParameterTest
    {
        [Test()]
        public void TestPropertiesCase ()
        {
            JsonDictionary dict = new JsonDictionary();
            string name = "TestName";
            dict.Add("location", "path");
            dict.Add("required", true);
            dict.Add("description", "A string description");
            dict.Add("default", "A default value");
            dict.Add("type", "string");
            dict.Add("repeated", true);
            dict.Add("enum", new List<string>() {"atom", "json"});
            dict.Add("enumDescriptions", new List<string>() {"atom are small particals", "json is my friend"});
            dict.Add("minimum", "43");
            dict.Add("maximum", "53");
            dict.Add("pattern", "[1-9][0-9]*");
            var impl = new ParameterFactory.BaseParameter(new KeyValuePair<string, object>(name, dict));
            
            Assert.AreEqual("TestName", impl.Name);
            Assert.AreEqual("path", impl.ParameterType);
            Assert.AreEqual("A string description", impl.Description);
            Assert.AreEqual("string", impl.ValueType);
            Assert.AreEqual(true, impl.Required);
            Assert.AreEqual(true, impl.Repeated);
            Assert.AreEqual("A default value", impl.DefaultValue);
            MoreAsserts.ContentsEqualAndInOrder(new List<string>() {"atom", "json"}, impl.Enum);
            MoreAsserts.ContentsEqualAndInOrder(new List<string>() {"atom are small particals", "json is my friend"}, impl.EnumDescription);
            Assert.AreEqual("53", impl.Maximum);
            Assert.AreEqual("43", impl.Minimum);
            Assert.AreEqual("[1-9][0-9]*",impl.Pattern);
        }
    }
}

