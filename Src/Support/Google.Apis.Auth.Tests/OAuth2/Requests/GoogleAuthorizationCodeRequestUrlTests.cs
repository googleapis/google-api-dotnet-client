/*
Copyright 2013 Google Inc

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

using Google.Apis.Auth.OAuth2.Requests;
using System;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Requests
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Requests.GoogleAuthorizationCodeRequestUrl"/>.
    /// </summary>
    public class GoogleAuthorizationCodeRequestUrlTests
    {
        private readonly Uri AuthorizationCodeUrl = new Uri("http://www.authorization-server.com");

        [Fact]
        public void TestConstructor()
        {
            var request = new GoogleAuthorizationCodeRequestUrl(AuthorizationCodeUrl);
            Assert.Equal(AuthorizationCodeUrl, request.AuthorizationServerUrl);
            Assert.Null(request.ClientId);
            Assert.Null(request.RedirectUri);
            Assert.Equal("code", request.ResponseType);
            Assert.Null(request.Scope);
            Assert.Null(request.State);
            Assert.Equal("offline", request.AccessType);
            Assert.Null(request.ApprovalPrompt);
            Assert.Null(request.LoginHint);
        }
    }
}
