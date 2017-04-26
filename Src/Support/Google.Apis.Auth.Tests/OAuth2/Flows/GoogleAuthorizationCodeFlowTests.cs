/*
Copyright 2016 Google Inc

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
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Moq;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Flows
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.Flows.GoogleAuthorizationCodeFlow"/>.</summary>
    public class GoogleAuthorizationCodeFlowTests
    {
        GoogleAuthorizationCodeFlow.Initializer initializer { get; set; }
        List<KeyValuePair<string, string>> userDefinedParams { get; set; }

        public GoogleAuthorizationCodeFlowTests()
        {
            string revokeTokenUrl = "Revoke Token Url";
            bool? includeGrantedScopes = true;
            userDefinedParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string,string>("customParam1","customVal1"),
                new KeyValuePair<string,string>("customParam2","customVal2")
            };

            initializer = new GoogleAuthorizationCodeFlow.Initializer()
            {
                RevokeTokenUrl = revokeTokenUrl,
                IncludeGrantedScopes = includeGrantedScopes,
                UserDefinedQueryParams = userDefinedParams,
                ClientSecrets = new ClientSecrets()
            };
        }

        [Fact]
        public void ConstructorTest()
        {
            var flow = new GoogleAuthorizationCodeFlow(initializer);

            Assert.Equal(initializer.RevokeTokenUrl, flow.RevokeTokenUrl);
            Assert.Equal(initializer.IncludeGrantedScopes, flow.IncludeGrantedScopes);
            Assert.Equal(initializer.UserDefinedQueryParams, flow.UserDefinedQueryParams);
        }
        
        [Fact]
        public void CreateAuthorizationCodeRequestTest()
        {
            var flow = new GoogleAuthorizationCodeFlow(initializer);

            var request = flow.CreateAuthorizationCodeRequest("TestRedirectUri") as GoogleAuthorizationCodeRequestUrl;

            Assert.Equal("offline", request.AccessType);
            Assert.Equal("true", request.IncludeGrantedScopes);
            Assert.Equal(userDefinedParams, request.UserDefinedQueryParams);
            Assert.Equal("TestRedirectUri", request.RedirectUri);
        }

        //TODO(squid808): Add tests for RevokeToken.
    }
}
