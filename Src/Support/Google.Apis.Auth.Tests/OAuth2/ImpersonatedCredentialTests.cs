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
            private string _content;
            private HttpStatusCode _statusCode;
            private Action<HttpRequestMessage> _requestValidator;

            public FakeHttpMessageHandler(HttpStatusCode statusCode, string content, Action<HttpRequestMessage> requestValidator)
            {
                _content = content;
                _statusCode = statusCode;
                _requestValidator = requestValidator;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                _requestValidator?.Invoke(request);

                HttpResponseMessage response = new HttpResponseMessage(_statusCode)
                {
                    Content = new StringContent(_content),
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

        private static ImpersonatedCredential CreateImpersonatedCredentialForBody(object body, bool serializeBody = true, HttpStatusCode status = HttpStatusCode.OK, Action<HttpRequestMessage> requestValidator = null)
        {
            var sourceCredential = CreateSourceCredential();
            var messageHandler = new FakeHttpMessageHandler(
                status,
                serializeBody ? NewtonsoftJsonSerializer.Instance.Serialize(body) : body.ToString(),
                requestValidator);

            return ImpersonatedCredential.Create(
                sourceCredential,
                new ImpersonatedCredential.Initializer("principal")
                {
                    Scopes = new string[] { "scope" },
                    Clock = _clock,
                    HttpClientFactory = new MockHttpClientFactory(messageHandler)
                });
        }

        private static ImpersonatedCredential CreateImpersonatedCredentialWithIdTokenResponse() =>
            CreateImpersonatedCredentialForBody(new { token = OidcComputeSuccessMessageHandler.FirstCallToken });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithAccessTokenResponse(Action<HttpRequestMessage> requestValidator = null) =>
            CreateImpersonatedCredentialForBody(
                new { accessToken = "access_token", expireTime = "2020-05-13T16:00:00.045123456Z" },
                requestValidator: requestValidator);

        // Use signedBlob = base64("principal") = "Zm9v"
        private static ImpersonatedCredential CreateImpersonatedCredentialWithSignBlobResponse() =>
            CreateImpersonatedCredentialForBody(new { keyId = "1", signedBlob = "Zm9v" });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithErrorResponse() =>
            CreateImpersonatedCredentialForBody(ErrorResponseContent, false, HttpStatusCode.NotFound);

        [Fact]
        public void Create_InvalidSourceCredential() =>
            Assert.Throws<InvalidOperationException>(() => ImpersonatedCredential.Create(
                GoogleCredential.FromComputeCredential(),
                new ImpersonatedCredential.Initializer("principal")));

        [Fact]
        public void WithHttpClientFactory()
        {
            var credential = ImpersonatedCredential.Create(CreateSourceCredential(), new ImpersonatedCredential.Initializer("principal"));
            var factory = new HttpClientFactory();
            var credentialWithFactory = Assert.IsType<ImpersonatedCredential>(((IGoogleCredential)credential).WithHttpClientFactory(factory));

            Assert.NotSame(credential, credentialWithFactory);
            Assert.NotSame(credential.HttpClient, credentialWithFactory.HttpClient);
            Assert.NotSame(credential.HttpClientFactory, credentialWithFactory.HttpClientFactory);
            Assert.Same(factory, credentialWithFactory.HttpClientFactory);
        }

        [Fact]
        public async Task InterceptsRequestsWithSourceCredentialAccessToken()
        {
            int calls = 0;
            var credential = CreateImpersonatedCredentialWithAccessTokenResponse(request =>
            {
                calls++;
                Assert.Equal("bearer", request.Headers.Authorization.Scheme, ignoreCase: true);
                Assert.Equal("ACCESS_TOKEN", request.Headers.Authorization.Parameter);
            });

            await credential.GetAccessTokenForRequestAsync();

            Assert.Equal(1, calls);
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
