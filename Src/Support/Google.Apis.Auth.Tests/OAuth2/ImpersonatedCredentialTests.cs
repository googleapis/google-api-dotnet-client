/*
Copyright 2021 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class ImpersonatedCredentialTests
    {
        private IClock clock = new MockClock(new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc));

        private string errorResponseContent = "{\"error\": {\"code\": 404, \"message\": \"...\", \"status\": \"NOT_FOUND\"}}";

        internal class MockHttpMessageHandler : HttpMessageHandler
        {
            private string content;
            private HttpStatusCode statusCode;

            public MockHttpMessageHandler(HttpStatusCode statusCode, string content) {
                this.content = content;
                this.statusCode = statusCode;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                HttpResponseMessage response = new HttpResponseMessage(this.statusCode)
                {
                    Content = new StringContent(this.content),
                    RequestMessage = request
                };
                return Task.FromResult(response);
            }
        }

        private GoogleCredential CreateSourceCredential()
        {
            var tokenResponse = new TokenResponse
                {
                    AccessToken = "ACCESS_TOKEN",
                    ExpiresInSeconds = 60 * 10,
                    IssuedUtc = clock.UtcNow,
                    RefreshToken = "REFRESH_TOKEN",
                };
            var flowMock = new Mock<IAuthorizationCodeFlow>(MockBehavior.Strict);
            flowMock
                .Setup(flow => flow.Clock)
                .Returns(clock);
            flowMock
                .Setup(flow => flow.AccessMethod)
                .Returns(new BearerToken.AuthorizationHeaderAccessMethod());
            return new GoogleCredential(new UserCredential(flowMock.Object, "my.user.id", tokenResponse));
        }

        private ImpersonatedCredential CreateImpersonatedCredentialWithIdTokenResponse()
        {
            var sourceCredential = CreateSourceCredential();
            var body = new { token = OidcComputeSuccessMessageHandler.FirstCallToken };
            var content = NewtonsoftJsonSerializer.Instance.Serialize(body);
            var messageHandler = new MockHttpMessageHandler(HttpStatusCode.OK, content);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "foo", new string[] {"scope"})
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            return new ImpersonatedCredential(initializer);
        }

        private ImpersonatedCredential CreateImpersonatedCredentialWithAccessTokenResponse()
        {
            var sourceCredential = CreateSourceCredential();
            var body = new {
                accessToken = "access_token",
                expireTime = "2020-05-13T16:00:00.045123456Z"
            };
            var content = NewtonsoftJsonSerializer.Instance.Serialize(body);
            var messageHandler = new MockHttpMessageHandler(HttpStatusCode.OK, content);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "foo", new string[] {"scope"})
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            return new ImpersonatedCredential(initializer);
        }

        private ImpersonatedCredential CreateImpersonatedCredentialWithSignBlobResponse()
        {
            var sourceCredential = CreateSourceCredential();
            // Use signedBlob = base64("foo") = "Zm9v"
            var body = new { keyId = "1", signedBlob = "Zm9v" };
            var content = NewtonsoftJsonSerializer.Instance.Serialize(body);
            var messageHandler = new MockHttpMessageHandler(HttpStatusCode.OK, content);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "foo", new string[] {"scope"})
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            return new ImpersonatedCredential(initializer);
        }

        private ImpersonatedCredential CreateImpersonatedCredentialWithErrorResponse()
        {
            var sourceCredential = CreateSourceCredential();
            var content = errorResponseContent;
            var messageHandler = new MockHttpMessageHandler(HttpStatusCode.NotFound, content);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "foo", new string[] {"scope"})
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            return new ImpersonatedCredential(initializer);
        }

        [Fact]
        public void TestConstructorInvalidSourceCredential()
        {
            var sourceCredential = GoogleCredential.FromComputeCredential();
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "foo");
            var ex = Assert.Throws<InvalidOperationException>(() => new ImpersonatedCredential(initializer));
            Assert.Equal("The underlying credential of source credential must be UserCredential or ServiceAccountCredential.", ex.Message);
        }

        [Fact]
        public void TestConstructorMissingTargetPrincipal()
        {
            var initializer = new ImpersonatedCredential.Initializer(CreateSourceCredential(), "");
            Assert.Throws<ArgumentException>(() => new ImpersonatedCredential(initializer));
        }

        [Fact]
        public void TestConstructorInvalidLifetime()
        {
            var initializer = new ImpersonatedCredential.Initializer(CreateSourceCredential(), "foo", null, null, 50000);
            var ex = Assert.Throws<InvalidOperationException>(() => new ImpersonatedCredential(initializer));
            Assert.Equal("Lifetime must be less than or equal to 43200.", ex.Message);
        }

        [Fact]
        public void TestConstructor()
        {
            var delegates = new string[] {"delegate"};
            var scopes = new string[] {"scope"};
            var initializer = new ImpersonatedCredential.Initializer(CreateSourceCredential(), "foo", delegates, scopes);
            var credential = new ImpersonatedCredential(initializer);
            Assert.Equal(3600, credential.LifetimeInSeconds);
            Assert.Equal(delegates, credential.Delegates);
            Assert.Equal(scopes, credential.Scopes);
            Assert.Equal("foo", credential.TargetPrincipal);
        }

        [Fact]
        public async Task TestFetchesOidcToken()
        {
            var credential = CreateImpersonatedCredentialWithIdTokenResponse();
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));
            var token = await oidcToken.GetAccessTokenAsync();
            Assert.Equal(674146, oidcToken.TokenResponse.ExpiresInSeconds);
            Assert.Equal(OidcComputeSuccessMessageHandler.FirstCallToken, token);
        }

        [Fact]
        public async Task TestFetchesOidcTokenFailure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));
            var ex = await Assert.ThrowsAsync<TokenResponseException>(async () =>{var result = await oidcToken.GetAccessTokenAsync();});
            Assert.Equal(errorResponseContent, ex.Error.Error);
        }

        [Fact]
        public async Task TestFetchesAccessToken()
        {
            var credential = CreateImpersonatedCredentialWithAccessTokenResponse();
            var success = await credential.RequestAccessTokenAsync(CancellationToken.None).ConfigureAwait(false);
            Assert.True(success);
            Assert.Equal(3600, credential.Token.ExpiresInSeconds);
            Assert.Equal("access_token", credential.Token.AccessToken);
        }

        [Fact]
        public async Task TestFetchesAccessTokenFailure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<TokenResponseException>(async () =>{await credential.RequestAccessTokenAsync(CancellationToken.None).ConfigureAwait(false);});
            Assert.Equal(errorResponseContent, ex.Error.Error);
        }

        [Fact]
        public async Task TestSignBlob()
        {
            var credential = CreateImpersonatedCredentialWithSignBlobResponse();
            var bytes = await credential.SignBytes(Encoding.ASCII.GetBytes("toSign")).ConfigureAwait(false);
            // Signature is "foo" whose byte array is {102, 111, 111}.
            Assert.Equal(new byte[] {102, 111, 111}, bytes);
        }

        [Fact]
        public async Task TestSignBlobFailure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<ImpersonatedCredential.SignBlobResponseException>(async () =>{await credential.SignBytes(Encoding.ASCII.GetBytes("toSign")).ConfigureAwait(false);});
            Assert.Equal(errorResponseContent, ex.Error);
        }
    }
}
