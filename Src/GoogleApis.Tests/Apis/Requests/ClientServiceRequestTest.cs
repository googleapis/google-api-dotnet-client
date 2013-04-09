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

using Moq;
using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Testing;
using Google.Apis.Util;


namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests for the ClientServiceRequest class.
    /// </summary>
    [TestFixture]
    public class ClientServiceRequestTest
    {
        /// <summary>
        /// Mock implementation of a BaseClientService.
        /// </summary>
        private class MockClientService : BaseClientService
        {
            public MockClientService()
                : base(new Initializer())
            {
            }

            public bool CreateSuspendedRequests { get; set; }
            public MockRequest LastRequest { get; private set; }
            public override string BaseUri { get { return "BaseUri"; } }
            public override string BasePath { get { return "BasePath"; } }

            public override IList<string> Features
            {
                get { throw new NotImplementedException(); }
            }

            public override string Name
            {
                get { return "Test MockClientService"; }
            }

            public override IDictionary<string, IParameter> ServiceParameters
            {
                get { throw new NotImplementedException(); }
            }

            public override IRequest CreateRequest(IClientServiceRequest request)
            {
                LastRequest = new MockRequest
                                  {
                                      StreamToReturn = new MemoryStream(),
                                      SuspendAsyncRequest = CreateSuspendedRequests
                                  };
                return LastRequest;

            }

            public override string SerializeObject(object data)
            {
                // Return a random string. The result won't matter/won't be checked, but we don't want the
                // code to throw an exception here.
                return "Not implemented";
            }

            public override T DeserializeResponse<T>(IResponse response)
            {
                return (T)Convert.ChangeType("FooBar", typeof(T));
            }

            public override RequestError DeserializeError(IResponse input)
            {
                throw new NotImplementedException();
            }
        }

        private class MockServiceRequest<T> : ClientServiceRequest<T>
        {
            public MockServiceRequest(IClientService service) : base(service) { }

            public override string ResourcePath
            {
                get { return "Resource"; }
            }

            public override string MethodName
            {
                get { return "Method"; }
            }

            public override string HttpMethod
            {
                get { return "HttpMethod"; }
            }

            public override string RestPath
            {
                get { return "RestPath"; }
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
            Assert.DoesNotThrow(() => new MockServiceRequest<string>(new MockClientService()));
        }

        /// <summary>
        /// Tests the CreateParameterDictionary method.
        /// </summary>
        [Test]
        public void CreateParameterDictionaryTest()
        {
            var request = new MockServiceRequest<string>(new MockClientService());
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
            var request = new MockServiceRequest<string>(new MockClientService());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.IsNotNull(request.FetchAsStream());
        }

        /// <summary>
        /// Tests the FetchAsyncAsStream() method of a ServiceRequest.
        /// </summary>
        [Test]
        public void FetchAsyncAsStreamTest()
        {
            var request = new MockServiceRequest<string>(new MockClientService());

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
            var request = new MockServiceRequest<string>(new MockClientService());

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
            var request = new MockServiceRequest<string>(new MockClientService());

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            Assert.AreEqual("FooBar", request.Fetch());
        }

        /// <summary>
        /// Tests the ETag behavior of the BuildRequest method of a ServiceRequest.
        /// </summary>
        [Test]
        public void ETagTest()
        {
            var request = new MockServiceRequest<string>(new MockClientService());
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

            var request = new MockServiceRequest<IDirectResponseSchema>(new MockClientService());
            request.ETagAction = ETagAction.IfMatch;
            request.Body = mockBody.Object;

            // Confirm that the E-tag and the behavior is passed along.
            MockRequest result = (MockRequest)request.BuildRequest();
            Assert.AreEqual("FooBar", result.ETag);
            Assert.AreEqual(ETagAction.IfMatch, result.ETagAction);
            mockBody.Verify();
        }

        #region Asynchronous Operation Tests

        /// <summary>
        /// Tests the BeginFetchInternal() and EndFetchInternal() methods of a ServiceRequest.
        /// </summary>
        [Test]
        public void BeginEndFetchInternalTest()
        {
            var clientService = new MockClientService { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(clientService);

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
            clientService.LastRequest.SuspendAsyncRequest = false;
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
            var clientService = new MockClientService { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(clientService);

            // Request validation is done in the MockSchemaAwareRequestExecutor.
            IAsyncResult async = request.BeginFetchInternal(null, null, r => request.FetchObject(r.GetResponse()));

            // Test that the operation is not yet completed.
            Assert.IsFalse(async.IsCompleted);
            Assert.IsFalse(async.CompletedSynchronously);
            Assert.IsNotNull(async.AsyncWaitHandle);
            Assert.IsNull(async.AsyncState);

            // Let the async operation continue.
            clientService.LastRequest.SuspendAsyncRequest = false;
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
            var clientService = new MockClientService { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(clientService);

            string result = null;
            IAsyncResult async = request.BeginFetch(cb => result = request.EndFetch(cb), null);

            // Check the result.
            Assert.IsFalse(async.AsyncWaitHandle.WaitOne(30));
            Assert.IsFalse(async.IsCompleted);
            clientService.LastRequest.SuspendAsyncRequest = false;
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
            var clientService = new MockClientService { CreateSuspendedRequests = true };
            var request = new MockServiceRequest<string>(clientService);

            Stream result = null;
            IAsyncResult async = request.BeginFetchAsStream(cb => result = request.EndFetchAsStream(cb), null);

            // Check the result.
            Assert.IsFalse(async.AsyncWaitHandle.WaitOne(30));
            Assert.IsFalse(async.IsCompleted);
            clientService.LastRequest.SuspendAsyncRequest = false;
            if (!async.AsyncWaitHandle.WaitOne(5000))
            {
                Assert.Fail("Asynchronous Fetch operation seems to be stuck.");
            }
            Assert.IsInstanceOf<MemoryStream>(result);
        }

        #endregion
    }
}