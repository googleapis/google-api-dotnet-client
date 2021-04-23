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
        private static readonly IClock clock = new MockClock(new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc));

        private const string ErrorResponseContent = "{\"error\": {\"code\": 404, \"message\": \"...\", \"status\": \"NOT_FOUND\"}}";

        internal class FakeHttpMessageHandler : HttpMessageHandler
        {
            private string content;
            private HttpStatusCode statusCode;

            public FakeHttpMessageHandler(HttpStatusCode statusCode, string content) {
                this.content = content;
                this.statusCode = statusCode;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                HttpResponseMessage response = new HttpResponseMessage(statusCode)
                {
                    Content = new StringContent(content),
                    RequestMessage = request
                };
                return Task.FromResult(response);
            }
        }

        private static GoogleCredential CreateSourceCredential()
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

        private static ImpersonatedCredential CreateImpersonatedCredentialForBody(object body, bool serializeBody = true, HttpStatusCode status = HttpStatusCode.OK)
        {
            var sourceCredential = CreateSourceCredential();
            var content = "";
            if (serializeBody)
            {
                content = NewtonsoftJsonSerializer.Instance.Serialize(body);
            }
            else
            {
                content = (string)body;
            }
            var messageHandler = new FakeHttpMessageHandler(status, content);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "principal", null, null, new[] {"scope"})
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            return new ImpersonatedCredential(initializer);
        }

        private static ImpersonatedCredential CreateImpersonatedCredentialWithIdTokenResponse() =>
            CreateImpersonatedCredentialForBody(new { token = OidcComputeSuccessMessageHandler.FirstCallToken });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithAccessTokenResponse() =>
            CreateImpersonatedCredentialForBody(new { accessToken = "access_token", expireTime = "2020-05-13T16:00:00.045123456Z" });

        // Use signedBlob = base64("principal") = "Zm9v"
        private static ImpersonatedCredential CreateImpersonatedCredentialWithSignBlobResponse() =>
            CreateImpersonatedCredentialForBody(new { keyId = "1", signedBlob = "Zm9v" });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithErrorResponse() =>
            CreateImpersonatedCredentialForBody(ErrorResponseContent, false, HttpStatusCode.NotFound);

        [Fact]
        public void Constructor_InvalidSourceCredential()
        {
            var sourceCredential = GoogleCredential.FromComputeCredential();
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, "principal", null, null, null);
            var ex = Assert.Throws<InvalidOperationException>(() => new ImpersonatedCredential(initializer));
            Assert.Equal("The underlying credential of source credential must be UserCredential or ServiceAccountCredential.", ex.Message);
        }

        [Fact]
        public void Constructor_MissingTargetPrincipal()
        {
            var initializer = new ImpersonatedCredential.Initializer(CreateSourceCredential(), "", null, null, null);
            Assert.Throws<ArgumentException>(() => new ImpersonatedCredential(initializer));
        }

        [Fact]
        public void Constructor_InvalidLifetime()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new ImpersonatedCredential.Initializer(CreateSourceCredential(), "principal", new TimeSpan(20, 0, 0), null, null));
            Assert.True(ex.Message.StartsWith("Lifetime must be less than or equal to"));
        }

        [Fact]
        public void Constructor()
        {
            var delegates = new[] {"delegate"};
            var scopes = new[] {"scope"};
            var initializer = new ImpersonatedCredential.Initializer(CreateSourceCredential(), "principal", null, delegates, scopes);
            var credential = new ImpersonatedCredential(initializer);
            Assert.Equal(new TimeSpan(1, 0, 0), credential.Lifetime);
            Assert.Equal(delegates, credential.DelegateAccounts);
            Assert.Equal(scopes, credential.Scopes);
            Assert.Equal("principal", credential.TargetPrincipal);
        }

        [Fact]
        public async Task GetOidcTokenAsync()
        {
            var credential = CreateImpersonatedCredentialWithIdTokenResponse();
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));
            var token = await oidcToken.GetAccessTokenAsync();
            Assert.Equal(674146, oidcToken.TokenResponse.ExpiresInSeconds);
            Assert.Equal(OidcComputeSuccessMessageHandler.FirstCallToken, token);
        }

        [Fact]
        public async Task GetOidcTokenAsync_Failure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var oidcToken = await credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));
            var ex = await Assert.ThrowsAsync<TokenResponseException>(() => oidcToken.GetAccessTokenAsync());
            Assert.Equal(ErrorResponseContent, ex.Error.Error);
        }

        [Fact]
        public async Task RequestAccessTokenAsync()
        {
            var credential = CreateImpersonatedCredentialWithAccessTokenResponse();
            var success = await credential.RequestAccessTokenAsync(CancellationToken.None).ConfigureAwait(false);
            Assert.True(success);
            Assert.Equal(3600, credential.Token.ExpiresInSeconds);
            Assert.Equal("access_token", credential.Token.AccessToken);
        }

        [Fact]
        public async Task RequestAccessTokenAsync_Failure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<TokenResponseException>(() => credential.RequestAccessTokenAsync(CancellationToken.None));
            Assert.Equal(ErrorResponseContent, ex.Error.Error);
        }

        [Fact]
        public async Task SignBytes()
        {
            var credential = CreateImpersonatedCredentialWithSignBlobResponse();
            var bytes = await credential.SignBytes(Encoding.ASCII.GetBytes("toSign")).ConfigureAwait(false);
            // Signature is "principal" whose byte array is {102, 111, 111}.
            Assert.Equal(new byte[] {102, 111, 111}, bytes);
        }

        [Fact]
        public async Task SignBytes_Failure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<ImpersonatedCredential.SignBlobResponseException>(() => credential.SignBytes(Encoding.ASCII.GetBytes("toSign")));
            Assert.Equal(ErrorResponseContent, ex.Error);
        }
    }
}
