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
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Requests.AuthorizationCodeRequestUrl"/>. 
    /// It tests that the constructor sets the default values and the building URI method.
    /// </summary>
    public class AuthorizationCodeRequestUrlTests
    {
        private readonly Uri AuthorizationCodeUrl = new Uri("http://www.authorization-server.com");

        [Fact]
        public void TestConstructor()
        {
            var request = new AuthorizationCodeRequestUrl(AuthorizationCodeUrl);
            Assert.Equal(AuthorizationCodeUrl, request.AuthorizationServerUrl);
            Assert.Null(request.ClientId);
            Assert.Null(request.RedirectUri);
            Assert.Equal("code", request.ResponseType);
            Assert.Null(request.Scope);
            Assert.Null(request.State);
        }

        [Fact]
        public void TestBuild_DefaultValues()
        {
            var request = new AuthorizationCodeRequestUrl(AuthorizationCodeUrl);
            var uri = request.Build();
            Assert.Equal(new Uri(AuthorizationCodeUrl.ToString() + "?response_type=code"), uri);
        }

        [Fact]
        public void TestBuild()
        {
            var request = new AuthorizationCodeRequestUrl(AuthorizationCodeUrl)
            {
                ClientId = "100",
                RedirectUri = "200",
                Scope = "SCOPE",
                State = "state",
            };
            var uri = request.Build();
            Assert.Equal(new Uri(AuthorizationCodeUrl.ToString() + "?response_type=code&client_id=100&redirect_uri=200&scope=SCOPE&state=state"), uri);
        }

        [Fact]
        public void TestBuild_EscapeValues()
        {
            var request = new AuthorizationCodeRequestUrl(AuthorizationCodeUrl)
            {
                ClientId = "pa$$word",
                RedirectUri = "???",
                Scope = "SC@PE",
                State = "!",
            };
            var uri = request.Build();
            Assert.Equal(new Uri(AuthorizationCodeUrl.ToString() + "?response_type=code&client_id=pa%24%24word&redirect_uri=%3F%3F%3F&scope=SC%40PE&state=%21"), uri);
        }
    }
}
