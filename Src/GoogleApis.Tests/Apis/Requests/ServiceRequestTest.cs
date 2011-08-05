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
using Google.Apis.Testing;
using Google.Apis.Util;
using Moq;
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
        /// Mock implementation of a IRequestProvider.
        /// </summary>
        private class MockRequestProvider : IRequestProvider
        {
            public IRequest CreateRequest(string resource, string method)
            {
                Assert.AreEqual("Resource", resource);
                Assert.AreEqual("Method", method);
                return new MockRequest() { StreamToReturn = new MemoryStream() };
            }

            public string SerializeObject(object data)
            {
                // Return a random string. The result won't matter/won't be checked, but we don't want the
                // code to throw an exception here.
                return "Not implemented";
            }

            public T DeserializeResponse<T>(IResponse response)
            {
                return (T)Convert.ChangeType("FooBar", typeof(T));
            }
        }

        private class MockServiceRequest<T> : ServiceRequest<T>
        {
            public MockServiceRequest(IRequestProvider service) : base(service) {}

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

            /// <summary>
            /// The body of this Mock request.
            /// </summary>
            public object Body { get; set; }

            protected override object GetBody()
            {
                return Body;
            }
        }

        /// <summary>
        /// Tests the constructor of a ServiceRequest.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new MockServiceRequest<string>(new MockRequestProvider()));
        }

        /// <summary>
        /// Tests the CreateParameterDictionary method.
        /// </summary>
        [Test]
        public void CreateParameterDictionaryTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());
            request.TestParameterA = 42;
            request.TestParameterB = 43;
            request.TestParameterC = 44;

            IDictionary<string, object> parameters = request.CreateParameterDictionary();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual(42, parameters["testparametera"]);
            Assert.AreEqual(43, parameters["B"]);
        }

        /// <summary>
        /// Tests the FetchAsStream() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchAsStreamTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.IsNotNull(request.FetchAsStream());
        }

        /// <summary>
        /// Tests the FetchAsyncAsStream() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchAsyncAsStreamTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            request.FetchAsyncAsStream();
            request.FetchAsyncAsStream(Assert.IsNotNull);
        }

        /// <summary>
        /// Tests the FetchAsync() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchAsyncTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            request.FetchAsync();
            request.FetchAsync((response) => Assert.AreEqual("FooBar", response));
        }

        /// <summary>
        /// Tests the Fetch() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.AreEqual("FooBar", request.Fetch());
        }

        /// <summary>
        /// Tests the ETag behavior of the BuildRequest method of a ServiceRequest.
        /// </summary>
        [Test]
        public void ETagTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());
            request.ETag = "FooBar";
            request.ETagAction = ETagAction.IfMatch;
            
            // Confirm that the E-tag and the behavior is passed along.
            MockRequest result = (MockRequest)request.BuildRequest();
            Assert.AreEqual("FooBar", result.ETag);
            Assert.AreEqual(ETagAction.IfMatch, result.ETagAction);
        }

        /// <summary>
        /// Tests the ETag behavior of the BuildRequest method of a ServiceRequest when using a typed body.
        /// </summary>
        [Test]
        public void ETagTypedBodyTest()
        {
            var mockBody = new Mock<IDirectResponseSchema>();
            mockBody.Setup(b => b.ETag).Returns("FooBar");

            var request = new MockServiceRequest<IDirectResponseSchema>(new MockRequestProvider());
            request.ETagAction = ETagAction.IfMatch;
            request.Body = mockBody.Object;

            // Confirm that the E-tag and the behavior is passed along.
            MockRequest result = (MockRequest)request.BuildRequest();
            Assert.AreEqual("FooBar", result.ETag);
            Assert.AreEqual(ETagAction.IfMatch, result.ETagAction);
            mockBody.Verify();
        }

        /// <summary>
        /// Tests the that the FieldsMask will be set on the resulting request.
        /// </summary>
        [Test]
        public void FieldsMaskTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());
            request.FieldsMask = "FooBar";

            // Confirm that the E-tag and the behavior is passed along.
            MockRequest result = (MockRequest)request.BuildRequest();
            Assert.AreEqual("FooBar", result.Fields);
        }

        /// <summary>
        /// Tests the that the UserIp will be set on the resulting request.
        /// </summary>
        [Test]
        public void UserIpTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());
            request.UserIp = "FooBar";

            // Confirm that the E-tag and the behavior is passed along.
            MockRequest result = (MockRequest)request.BuildRequest();
            Assert.AreEqual("FooBar", result.UserIp);
        }
    }
}