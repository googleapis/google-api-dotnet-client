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

using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests for the ServiceRequest class.
    /// </summary>
    [TestFixture]
    public class ServiceRequestTest
    {
        /// <summary>
        /// Mock implementation of a ISchemaAwareRequestExecutor.
        /// </summary>
        private class MockSchemaAwareRequestExecutor : ISchemaAwareRequestExecutor
        {
            #region ISchemaAwareRequestExecutor Members

            public Stream ExecuteRequest(string resource,
                                         string method,
                                         string body,
                                         IDictionary<string, object> parameters)
            {
                Assert.AreEqual("Resource", resource);
                Assert.AreEqual("Method", method);
                Assert.IsNull(body);
                Assert.AreEqual(2, parameters.Count);

                return new MemoryStream();
            }

            public string ObjectToJson(object obj)
            {
                throw new NotImplementedException();
            }

            public TOutput JsonToObject<TOutput>(Stream stream)
            {
                return (TOutput) Convert.ChangeType("FooBar", typeof(TOutput));
            }

            #endregion
        }

        private class MockServiceRequest : ServiceRequest<string>
        {
            public MockServiceRequest(ISchemaAwareRequestExecutor service) : base(service) {}

            protected override string ResourceName
            {
                get { return "Resource"; }
            }

            protected override string MethodName
            {
                get { return "Method"; }
            }

            [RequestParameter]
            public int TestParameterA { get; set; }

            [RequestParameter("B")]
            public int TestParameterB { get; set; }

            public int TestParameterC { get; set; }
        }

        /// <summary>
        /// Tests the constructor of a ServiceRequest.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new MockServiceRequest(new MockSchemaAwareRequestExecutor()));
        }

        /// <summary>
        /// Tests the CreateParameterDictionary method.
        /// </summary>
        [Test]
        public void CreateParameterDictionaryTest()
        {
            var request = new MockServiceRequest(new MockSchemaAwareRequestExecutor());
            request.TestParameterA = 42;
            request.TestParameterB = 43;
            request.TestParameterC = 44;

            IDictionary<string, object> parameters = request.CreateParameterDictionary();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual(42, parameters["testparametera"]);
            Assert.AreEqual(43, parameters["B"]);
        }

        /// <summary>
        /// Tests the Execute method of a ServiceRequest.
        /// </summary>
        [Test]
        public void ExecuteToStreamTest()
        {
            var request = new MockServiceRequest(new MockSchemaAwareRequestExecutor());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.IsNotNull(request.FetchAsStream());
        }

        /// <summary>
        /// Tests the Execute method of a ServiceRequest.
        /// </summary>
        [Test]
        public void ExecuteTest()
        {
            var request = new MockServiceRequest(new MockSchemaAwareRequestExecutor());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.AreEqual("FooBar", request.Fetch());
        }
    }
}