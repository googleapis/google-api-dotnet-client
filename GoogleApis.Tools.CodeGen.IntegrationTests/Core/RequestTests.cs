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
            public bool Called { get; set; }

            public bool CanHandleErrorResponse(WebException exception, RequestError error)
            {
                return !Called;
            }

            public void PrepareHandleErrorResponse(WebException exception, RequestError error)
            {

            }

            public void HandleErrorResponse(WebException exception, RequestError error, WebRequest request)
            {
                Called = true;
            }
        }
        
        /// <summary>
        /// Tests the results of the GetErrorResponseHandlers method.
        /// </summary>
        [Test]
        public void TestErrorResponseHandler()
        {
            var request =
                (Request)
                Request.CreateRequest(
                    new MockService(),
                    new MockMethod
                    {
                        HttpMethod = "GET",
                        Name = "TestMethod",
                        RestPath = "https://localhost:12345/",
                        Parameters = new Dictionary<string, IParameter>()
                    });

            // Confirm that an error handling response handler will change the enumeration
            var auth = new MockErrorHandlingAuthenticator();
            Assert.IsFalse(auth.Called);
            request.WithAuthentication(auth);
            request.WithParameters(new Dictionary<string, string>());
            Assert.Throws<GoogleApiException>(() => request.ExecuteRequest());
            Assert.IsTrue(auth.Called);
        }
    }
}
