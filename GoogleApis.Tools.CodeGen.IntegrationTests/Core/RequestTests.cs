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

using System.Collections.Generic;
using System.Net;
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Tests.Apis.Requests;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.IntegrationTests.Core
{
    /// <summary>
    /// Integration-Tests for the Request class
    /// </summary>
    [TestFixture]
    public class RequestTests
    {
        private class MockErrorHandlingAuthenticator : Authenticator, IErrorResponseHandler
        {
            private int callOrder = 0;
            public bool Called { get; set; }

            public bool CanHandleErrorResponse(WebException exception, RequestError error)
            {
                if (callOrder != 0 && callOrder != 3)
                {
                    Assert.Fail("IErrorResponseHandler methods called in wrong order.");
                }

                // This handler will only handle the first retry, and will fail every additional request.
                callOrder++;
                return !Called;
            }

            public void PrepareHandleErrorResponse(WebException exception, RequestError error)
            {
                Assert.AreEqual(1, callOrder++, "IErrorResponseHandler methods called in wrong order.");
                Assert.IsFalse(Called);
            }

            public void HandleErrorResponse(WebException exception, RequestError error, WebRequest request)
            {
                Assert.AreEqual(2, callOrder++, "IErrorResponseHandler methods called in wrong order.");
                Assert.IsFalse(Called);
                Called = true;
            }
        }
        
        /// <summary>
        /// Tests that the requests will retry execution if a WebException is received and 
        /// that the request will fail after a retry.
        /// </summary>
        [Test]
        public void TestRetrySystem()
        {
            var request =
                (Request)
                Request.CreateRequest(
                    new MockService(),
                    new MockMethod
                    {
                        HttpMethod = "GET",
                        Name = "TestMethod",
                        // Define an invalid URI which will cause a WebException to be thrown.
                        RestPath = "https://localhost:12345/",
                        Parameters = new Dictionary<string, IParameter>()
                    });

            var auth = new MockErrorHandlingAuthenticator();
            Assert.IsFalse(auth.Called);
            request.WithAuthentication(auth);
            request.WithParameters(new Dictionary<string, string>());

            // Execute the request. This will fail because we have defined an invalid rest URI.
            // The IErrorResponseHandler should kick in and try to resend the request. As this 
            // will also fail we will receive a GoogleApiException over here.
            Assert.Throws<GoogleApiException>(() => request.ExecuteRequest());

            // Confirm that the IErrorResponseHandler has run and tried to resend/modify the request.
            Assert.IsTrue(auth.Called);
        }
    }
}
