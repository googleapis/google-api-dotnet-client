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
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
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
        private static readonly IClock _clock = new MockClock(new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc));

        private const string ErrorResponseContent = "{\"error\": {\"code\": 404, \"message\": \"...\", \"status\": \"NOT_FOUND\"}}";

        internal class FakeHttpMessageHandler : HttpMessageHandler
        {
            private string content;
            private HttpStatusCode statusCode;

            public FakeHttpMessageHandler(HttpStatusCode statusCode, string content)
            {
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
                IssuedUtc = _clock.UtcNow,
                RefreshToken = "REFRESH_TOKEN",
            };
            var initializer = new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = "CLIENT_ID",
                    ClientSecret = "CLIENT_SECRET"
                },
                ProjectId = "PROJECT_ID",
                Clock = _clock
            };
            var flow = new GoogleAuthorizationCodeFlow(initializer);
            return new GoogleCredential(new UserCredential(flow, "my.user.id", tokenResponse));
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
            var options = new ImpersonationOptions("principal", null, null, new[] {"scope"});
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, options)
            {
                Clock = _clock,
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
            var options = new ImpersonationOptions("principal", null, null, null);
            var initializer = new ImpersonatedCredential.Initializer(sourceCredential, options);
            var ex = Assert.Throws<InvalidOperationException>(() => new ImpersonatedCredential(initializer));
            Assert.Equal("The underlying credential of source credential must be UserCredential or ServiceAccountCredential.", ex.Message);
        }

        [Fact]
        public void WithHttpClientFactory()
        {
            var sourceCredential = CreateSourceCredential();
            var credential = new ImpersonatedCredential(
                new ImpersonatedCredential.Initializer(sourceCredential, new ImpersonationOptions("principal", null, null, null)));
            var factory = new HttpClientFactory();
            var credentialWithFactory = Assert.IsType<ImpersonatedCredential>(((IGoogleCredential)credential).WithHttpClientFactory(factory));

            Assert.NotSame(credential, credentialWithFactory);
            Assert.NotSame(credential.HttpClient, credentialWithFactory.HttpClient);
            Assert.NotSame(credential.HttpClientFactory, credentialWithFactory.HttpClientFactory);
            Assert.Same(factory, credentialWithFactory.HttpClientFactory);
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
        public async Task SignBlobAsync()
        {
            var credential = CreateImpersonatedCredentialWithSignBlobResponse();
            var signature = await credential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign")).ConfigureAwait(false);
            Assert.Equal("Zm9v", signature);
        }

        [Fact]
        public async Task SignBlobAsync_Failure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<HttpRequestException>(() => credential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign")));
            Assert.Equal("Response status code does not indicate success: 404 (Not Found).", ex.Message);
        }
    }
}
