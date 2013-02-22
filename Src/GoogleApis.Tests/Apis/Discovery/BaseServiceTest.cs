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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Newtonsoft.Json;
using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary> Test for the "BaseService" class. </summary>
    [TestFixture]
    public class BaseServiceTest
    {
        private class ConcreteClass : BaseService
        {
            public ConcreteClass(JsonDictionary js)
                : base(ServiceFactory.Default, js, new ConcreteFactoryParameters()) { }

            public new string ServerUrl
            {
                get { return base.ServerUrl; }
                set { base.ServerUrl = value; }
            }
            public new string BasePath
            {
                get { return base.BasePath; }
                set { base.BasePath = value; }
            }

            #region Nested type: ConcreteFactoryParameters

            private class ConcreteFactoryParameters : FactoryParameters
            {
                public ConcreteFactoryParameters() : base("http://test/", "testService/") { }
            }

            #endregion
        }

        #region Test Helper methods

        private IService CreateService(DiscoveryVersion version)
        {
            return version == DiscoveryVersion.Version_0_3 ? CreateLegacyV03Service() : CreateV1Service();
        }

        private IService CreateV1Service()
        {
            var dict = new JsonDictionary();
            dict.Add("name", "TestName");
            dict.Add("version", "v1");
            return new ConcreteClass(dict);
        }

        private IService CreateLegacyV03Service()
        {
            var dict = new JsonDictionary();
            dict.Add("name", "TestName");
            dict.Add("version", "v1");
            dict.Add("features", new[] { Features.LegacyDataResponse.GetStringValue() });
            return new ConcreteClass(dict);
        }

        #endregion

        /// <summary>
        /// This test confirms that the BaseService will not crash on non-existent, optional fields
        /// within the JSON document.
        /// </summary>
        [Test]
        public void TestNoThrowOnFieldsMissing()
        {
            IService impl = CreateV1Service();

            Assert.AreEqual("v1", impl.Version);
            Assert.IsNull(impl.Id);
            Assert.IsNotNull(impl.Labels);
            MoreAsserts.IsEmpty(impl.Labels);
            Assert.AreEqual("TestName", impl.Name);
            Assert.IsNull(impl.Protocol);
            Assert.IsNull(impl.Title);
        }

        /// <summary>
        /// The test targets the more basic properties of the BaseService.
        /// It should ensure that all properties return the values assigned to them within the JSON document.
        /// </summary>
        [Test]
        public void TestSimpleGetters()
        {
            var dict = new JsonDictionary();
            dict.Add("name", "TestName");
            dict.Add("version", "v1");
            dict.Add("description", "Test Description");
            dict.Add("documentationLink", "https://www.google.com/");
            dict.Add("features", new List<object> { "feature1", "feature2" });
            dict.Add("labels", new List<object> { "label1", "label2" });
            dict.Add("id", "TestId");
            dict.Add("title", "Test API");

            IService impl = new ConcreteClass(dict);
            Assert.AreEqual("Test Description", impl.Description);
            Assert.AreEqual("https://www.google.com/", impl.DocumentationLink);
            MoreAsserts.ContentsEqualAndInOrder(new List<string> { "feature1", "feature2" }, impl.Features);
            MoreAsserts.ContentsEqualAndInOrder(new List<string> { "label1", "label2" }, impl.Labels);
            Assert.AreEqual("TestId", impl.Id);
            Assert.AreEqual("Test API", impl.Title);
        }

        /// <summary>
        /// Confirms that OAuth2 scopes can be parsed correctly.
        /// </summary>
        [Test]
        public void TestOAuth2Scopes()
        {
            var scopes = new JsonDictionary();
            scopes.Add("https://www.example.com/auth/one", new Scope() { ID = "https://www.example.com/auth/one" });
            scopes.Add("https://www.example.com/auth/two", new Scope() { ID = "https://www.example.com/auth/two" });
            var oauth2 = new JsonDictionary() { { "scopes", scopes } };
            var auth = new JsonDictionary() { { "oauth2", oauth2 } };
            var dict = new JsonDictionary() { { "auth", auth }, { "name", "TestName" }, { "version", "v1" } };

            IService impl = new ConcreteClass(dict);
            Assert.IsNotNull(impl.Scopes);
            Assert.AreEqual(2, impl.Scopes.Count);
            Assert.IsTrue(impl.Scopes.ContainsKey("https://www.example.com/auth/one"));
            Assert.IsTrue(impl.Scopes.ContainsKey("https://www.example.com/auth/two"));
        }

        /// <summary>
        /// Test that the Parameters property is initialized.
        /// </summary>
        [Test]
        public void TestCommonParameters()
        {
            const string testJson =
            @"{
            'fields': {
                'type': 'string',
                'description': 'Selector specifying which fields to include in a partial response.',
                'location': 'query'
            },
            'prettyPrint': {
                'type': 'boolean',
                'description': 'Returns response with indentations and line breaks.',
                'default': 'true',
                'location': 'query'
            },
            }";
            var paramDict = Google.Apis.Json.JsonReader.Parse(testJson.Replace('\'', '\"')) as JsonDictionary;
            var dict = new JsonDictionary() { 
                { "parameters", paramDict}, 
                { "name", "TestName" },
                { "version", "v1" } };
            var impl = new ConcreteClass(dict);
            Assert.That(impl.Parameters.Count, Is.EqualTo(2));
            Assert.That(impl.Parameters.Keys,
                Is.EquivalentTo(new string[] { "fields", "prettyPrint" }));
            var prettyPrint = impl.Parameters["prettyPrint"];
            Assert.That(prettyPrint.Description,
                Is.EqualTo("Returns response with indentations and line breaks."));
            Assert.That(prettyPrint.ValueType, Is.EqualTo("boolean"));
        }

        /// <summary>
        /// Test a service with empty parameters.
        /// </summary>
        [Test]
        public void TestCommonParametersEmpty()
        {
            var paramDict = new JsonDictionary();
            var dict = new JsonDictionary() { 
                { "parameters", paramDict }, 
                { "name", "TestName" }, 
                { "version", "v1" } };
            var impl = new ConcreteClass(dict);

            Assert.That(impl.Parameters, Is.Not.Null);
            Assert.That(impl.Parameters.Count, Is.EqualTo(0));
        }

        /// <summary>
        /// Test a service with no parameters
        /// </summary>
        [Test]
        public void TestCommonParametersMissing()
        {
            var paramDict = new JsonDictionary();
            var dict = new JsonDictionary() { { "name", "TestName" }, { "version", "v1" } };
            var impl = new ConcreteClass(dict);

            Assert.That(impl.Parameters, Is.Not.Null);
            Assert.That(impl.Parameters.Count, Is.EqualTo(0));
        }

        /// <summary>
        /// Confirms that methods, which are directly on the service, are supported
        /// </summary>
        [Test]
        public void TestMethodsOnService()
        {
            var testMethod = new JsonDictionary();
            testMethod.Add("id", "service.testMethod");
            testMethod.Add("path", "service/testMethod");
            testMethod.Add("httpMethod", "GET");
            var methods = new JsonDictionary() { { "testMethod", testMethod } };
            var dict = new JsonDictionary() { { "methods", methods }, { "name", "TestName" }, { "version", "v1" } };

            IService impl = new ConcreteClass(dict);
            Assert.IsNotNull(impl.Methods);
            Assert.AreEqual(1, impl.Methods.Count);
            Assert.AreEqual("testMethod", impl.Methods["testMethod"].Name);
        }

        [Test]
        public void TestBaseUri()
        {
            ConcreteClass instance = (ConcreteClass)CreateV1Service();
            instance.BasePath = "/test/";
            instance.ServerUrl = "https://www.test.value/";
            Assert.AreEqual("https://www.test.value/test/", instance.BaseUri.ToString());

            instance.BasePath = "test/";
            instance.ServerUrl = "https://www.test.value/";
            Assert.AreEqual("https://www.test.value/test/", instance.BaseUri.ToString());

            instance.BasePath = "/test/";
            instance.ServerUrl = "https://www.test.value";
            Assert.AreEqual("https://www.test.value/test/", instance.BaseUri.ToString());

            instance.BasePath = "test/";
            instance.ServerUrl = "https://www.test.value";
            Assert.AreEqual("https://www.test.value/test/", instance.BaseUri.ToString());

            // Mono's Uri class strips double forward slashes so this test will not work.
            // Only run for MS.Net
            if (Google.Apis.Util.Utilities.IsMonoRuntime() == false)
            {
                instance.BasePath = "//test/";
                instance.ServerUrl = "https://www.test.value";
                Assert.AreEqual("https://www.test.value//test/", instance.BaseUri.ToString());

                instance.BasePath = "//test/";
                instance.ServerUrl = "https://www.test.value/";
                Assert.AreEqual("https://www.test.value//test/", instance.BaseUri.ToString());

                instance.BasePath = "test/";
                instance.ServerUrl = "https://www.test.value//";
                Assert.AreEqual("https://www.test.value//test/", instance.BaseUri.ToString());

                instance.BasePath = "/test//";
                instance.ServerUrl = "https://www.test.value/";
                Assert.AreEqual("https://www.test.value/test//", instance.BaseUri.ToString());
            }
        }


        [Test]
        public void RemoveAnnotations()
        {
            string json = @"
{
 'schemas': {
  'Event': {
   'id': 'Event',
   'type': 'object',
   'properties': {
    'description': {
     'type': 'string',
     'description': 'Description of the event. Optional.'
    },
    'end': {
     '$ref': 'EventDateTime',
     'description': 'The (exclusive) end time of the event. For a recurring event, this is the end time of the first instance.',
     'annotations': {
      'required': [
       'calendar.events.import',
       'calendar.events.insert',
       'calendar.events.update'
      ]
     }
    },
   }
  }
 }
}";

            JsonDictionary js = Google.Apis.Json.JsonReader.Parse(json) as JsonDictionary;
            var end = AssertNode(js, "schemas", "Event", "properties", "end");
            Assert.That(end.Count, Is.EqualTo(3));
            Assert.That(end.ContainsKey("annotations"), Is.True);
            BaseService.RemoveAnnotations(js, 0);
            Assert.That(end.Count, Is.EqualTo(2));
            Assert.That(end.ContainsKey("annotations"), Is.False);
        }

        private JsonDictionary AssertNode(JsonDictionary dict, params string[] nodes)
        {
            JsonDictionary cur = dict;
            for (int i = 0; i < nodes.Length; i++)
            {
                Assert.That(cur.ContainsKey(nodes[i]));
                Assert.That(cur[nodes[i]], Is.TypeOf(typeof(JsonDictionary)));
                cur = cur[nodes[i]] as JsonDictionary;
            }
            return cur;
        }
    }
}
