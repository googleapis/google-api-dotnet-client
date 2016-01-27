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
using NUnit.Framework;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.Flows.GoogleAuthorizationCodeFlow"/>.</summary>
    public class GoogleAuthorizationCodeFlowTests
    {
        GoogleAuthorizationCodeFlow.Initializer initializer { get; set; }
        List<KeyValuePair<string, string>> userDefinedParams { get; set; }

        [SetUp]
        public void GoogleAuthorizationCodeFlowTestSetup()
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
                //HttpClientFactory //set this up 
                ClientSecrets = new ClientSecrets() //to avoid throwing error
            };
        }

        [Test]
        public void ConstructorTest()
        {
            var flow = new GoogleAuthorizationCodeFlow(initializer);

            Assert.That(flow.RevokeTokenUrl, Is.EqualTo(initializer.RevokeTokenUrl));
            Assert.That(flow.IncludeGrantedScopes, Is.EqualTo(initializer.IncludeGrantedScopes));
            Assert.That(flow.UserDefinedQueryParams, Is.EqualTo(initializer.UserDefinedQueryParams));
        }
        
        [Test]
        public void CreateAuthorizationCodeRequestTest()
        {
            var flow = new GoogleAuthorizationCodeFlow(initializer);

            var request = flow.CreateAuthorizationCodeRequest("TestRedirectUri") as GoogleAuthorizationCodeRequestUrl;

            Assert.AreEqual(request.AccessType, "offline");
            Assert.AreEqual(request.IncludeGrantedScopes, "true");
            Assert.AreEqual(request.UserDefinedQueryParams, userDefinedParams);
            Assert.AreEqual(request.RedirectUri, "TestRedirectUri");
        }

        [Test]
        public void RevokeTokenAsyncTest()
        {
            var mockDataStore = new Mock<IDataStore>();
            mockDataStore.Setup(ds => ds.DeleteAsync<TokenResponse>("user")).
                Returns(new TaskCompletionSource<TokenResponse>().Task);

            var mockHttpClient = new Mock<ConfigurableHttpClient>();
            mockHttpClient.Setup(mhc => mhc.SendAsync(
                It.IsAny<HttpRequestMessage>(), 
                It.IsAny<CancellationToken>()
                )).Returns(TaskEx.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK)));

            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            mockHttpClientFactory.Setup(mhcf => mhcf.CreateHttpClient(
                It.IsAny<CreateHttpClientArgs>()
                )).Returns(mockHttpClient.Object);

            initializer.HttpClientFactory = mockHttpClientFactory.Object;

            var flow = new GoogleAuthorizationCodeFlow(initializer);

            var result = flow.RevokeTokenAsync("user","token", new CancellationToken(false));
            mockDataStore.Verify(ds => ds.DeleteAsync<TokenResponse>("user"));
        }
    }
}
