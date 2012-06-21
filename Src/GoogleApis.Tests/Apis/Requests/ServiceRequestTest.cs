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
using System.Threading;
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
            public bool CreateSuspendedRequests { get; set; }
            public MockRequest LastRequest { get; private set; }
            public string BaseUri { get; set; }
            public Google.Apis.Authentication.IAuthenticator Authenticator { get; set; }

            public virtual IRequest CreateRequest(string resource, string method)
            {
                Assert.AreEqual("Resource", resource);
                Assert.AreEqual("Method", method);
                LastRequest = new MockRequest
                                  {
                                      StreamToReturn = new MemoryStream(), 
                                      SuspendAsyncRequest = CreateSuspendedRequests
                                  };
                return LastRequest;

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

            protected override string ResourcePath
            {
                get { return "Resource"; }
            }

            protected override string MethodName
            {
                get { return "Method"; }
            }

            [RequestParameter("testparametera", RequestParameterType.Path)]
            public int TestParameterA { get; set; }

            [RequestParameter("B", RequestParameterType.Path)]
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
            var wait = new AutoResetEvent(false);
            request.FetchAsyncAsStream();
            request.FetchAsyncAsStream((response) =>
                                           { 
                                               Assert.IsNotNull(response.GetResult());
                                               wait.Set();
                                           });
            if (!wait.WaitOne(5000))
            {
                Assert.Fail("Async-task was not finished.");
            }
        }

        /// <summary>
        /// Tests the FetchAsync() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchAsyncTest()
        {
            var request = new MockServiceRequest<string>(new MockRequestProvider());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            var wait = new AutoResetEvent(false);
            request.FetchAsync();
            request.FetchAsync((response) =>
                                   {
                                       Assert.AreEqual("FooBar", response.GetResult());
                                       wait.Set();
                                   });
            if (!wait.WaitOne(5000))
            {
                Assert.Fail("Async-task was not finished.");
            }
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

        #region Asynchronous Operation Tests

        /// <summary>
        /// Tests the BeginFetchInternal() and EndFetchInternal() methods of a ServiceRequest.
        /// </summary>
        [Test]
        public void BeginEndFetchInternalTest()
        {
            var requestProvider = new MockRequestProvider { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(requestProvider);
            
            // Request validation is done in the MockSchemaAwareRequestExecutor.
            string result = null;
            IAsyncResult async = request.BeginFetchInternal(
                cb => result = request.EndFetch(cb), null, res => request.FetchObject(res.GetResponse()));

            // Test that the operation is not yet completed.
            Assert.IsFalse(async.IsCompleted);
            Assert.IsFalse(async.CompletedSynchronously);
            Assert.IsNotNull(async.AsyncWaitHandle);
            Assert.IsNull(async.AsyncState);

            // Let the async operation continue.
            requestProvider.LastRequest.SuspendAsyncRequest = false;
            if (!async.AsyncWaitHandle.WaitOne(5000))
            {
                Assert.Fail("Async Operation seems to be stuck.");
            }

            // Check the result.
            Assert.IsTrue(async.IsCompleted);
            Assert.AreEqual("FooBar", result);
            Assert.IsFalse(async.CompletedSynchronously);
        }

        /// <summary>
        /// Tests the BeginFetchInternal() and EndFetchInternal() methods of a ServiceRequest when trying to
        /// synchronously complete the operation.
        /// </summary>
        [Test]
        public void BeginEndFetchInternalSynchronousTest()
        {
            var requestProvider = new MockRequestProvider { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(requestProvider);

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            IAsyncResult async = request.BeginFetchInternal(null, null, r => request.FetchObject(r.GetResponse()));

            // Test that the operation is not yet completed.
            Assert.IsFalse(async.IsCompleted);
            Assert.IsFalse(async.CompletedSynchronously);
            Assert.IsNotNull(async.AsyncWaitHandle);
            Assert.IsNull(async.AsyncState);

            // Let the async operation continue.
            requestProvider.LastRequest.SuspendAsyncRequest = false;
            Assert.AreEqual("FooBar", request.EndFetchInternal(async));

            // Check the result.
            Assert.IsTrue(async.IsCompleted);
            Assert.IsTrue(async.CompletedSynchronously);
        }

        /// <summary>
        /// Tests the BeginFetch() and EndFetch() methods.
        /// </summary>
        [Test]
        public void BeginEndFetchTest()
        {
            var requestProvider = new MockRequestProvider { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(requestProvider);

            string result = null;
            IAsyncResult async = request.BeginFetch(cb => result = request.EndFetch(cb), null);

            // Check the result.
            Assert.IsFalse(async.AsyncWaitHandle.WaitOne(30));
            Assert.IsFalse(async.IsCompleted);
            requestProvider.LastRequest.SuspendAsyncRequest = false;
            if (!async.AsyncWaitHandle.WaitOne(5000))
            {
                Assert.Fail("Asynchronous Fetch operation seems to be stuck.");
            }
            Assert.AreEqual("FooBar", result);
        }

        /// <summary>
        /// Tests the BeginFetchAsStream() and EndFetchAsStream() methods.
        /// </summary>
        [Test]
        public void BeginEndFetchAsStreamTest()
        {
            var requestProvider = new MockRequestProvider { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(requestProvider);

            Stream result = null;
            IAsyncResult async = request.BeginFetchAsStream(cb => result = request.EndFetchAsStream(cb), null);

            // Check the result.
            Assert.IsFalse(async.AsyncWaitHandle.WaitOne(30));
            Assert.IsFalse(async.IsCompleted);
            requestProvider.LastRequest.SuspendAsyncRequest = false;
            if (!async.AsyncWaitHandle.WaitOne(5000))
            {
                Assert.Fail("Asynchronous Fetch operation seems to be stuck.");
            }
            Assert.IsInstanceOf<MemoryStream>(result);
        }

        #endregion
    }
}