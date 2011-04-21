using System;
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;

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
            dict.Add("parameterType", "path");
            dict.Add("required", true);
            dict.Add("description", "A string description");
            dict.Add("type", "string");
            var impl = new ParameterFactory.BaseParameter(new KeyValuePair<string, object>(name, dict));
            
            Assert.AreEqual("TestName", impl.Name);
            Assert.AreEqual("path", impl.ParameterType);
            Assert.AreEqual("A string description", impl.Description);
            Assert.AreEqual("string", impl.ValueType);
        }
    }
}

