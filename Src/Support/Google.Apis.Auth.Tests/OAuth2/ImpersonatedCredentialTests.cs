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

        private static ImpersonatedCredential CreateImpersonatedCredentialForBody(
            object body, bool serializeBody = true, HttpStatusCode status = HttpStatusCode.OK, Action<HttpRequestMessage> requestValidator = null, string principal = "principal", string customTokenUrl = null)
        {
            var sourceCredential = CreateSourceCredential();
            var messageHandler = new FakeHttpMessageHandler(
                status,
                serializeBody ? NewtonsoftJsonSerializer.Instance.Serialize(body) : body.ToString(),
                requestValidator);

            var initializer = customTokenUrl is null
                ? new ImpersonatedCredential.Initializer(principal)
                : new ImpersonatedCredential.Initializer(customTokenUrl, principal);
            initializer.Scopes = new string[] { "scope" };
            initializer.Clock = _clock;
            initializer.HttpClientFactory = new MockHttpClientFactory(messageHandler);

            return ImpersonatedCredential.Create(sourceCredential, initializer);
        }

        private static ImpersonatedCredential CreateImpersonatedCredentialWithIdTokenResponse() =>
            CreateImpersonatedCredentialForBody(new { token = OidcComputeSuccessMessageHandler.FirstCallToken });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithAccessTokenResponse(Action<HttpRequestMessage> requestValidator = null, string principal = "principal", string customTokenUrl = null) =>
            CreateImpersonatedCredentialForBody(
                new { accessToken = "access_token", expireTime = "2020-05-13T16:00:00.045123456Z" },
                requestValidator: requestValidator,
                principal: principal,
                customTokenUrl: customTokenUrl);

        // Use signedBlob = base64("principal") = "Zm9v"
        private static ImpersonatedCredential CreateImpersonatedCredentialWithSignBlobResponse() =>
            CreateImpersonatedCredentialForBody(new { keyId = "1", signedBlob = "Zm9v" });

        private static ImpersonatedCredential CreateImpersonatedCredentialWithErrorResponse() =>
            CreateImpersonatedCredentialForBody(ErrorResponseContent, false, HttpStatusCode.NotFound);

        [Fact]
        public void Create_InvalidSourceCredential() =>
            Assert.Throws<InvalidOperationException>(() => ImpersonatedCredential.Create(
                GoogleCredential.FromAccessToken("fake_access_token"),
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
            var success = await credential.RequestAccessTokenAsync(CancellationToken.None);
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
            var signature = await credential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign"));
            Assert.Equal("Zm9v", signature);
        }

        [Fact]
        public async Task SignBlobAsync_Failure()
        {
            var credential = CreateImpersonatedCredentialWithErrorResponse();
            var ex = await Assert.ThrowsAsync<GoogleApiException>(() => credential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign")));
            Assert.Equal(HttpStatusCode.NotFound, ex.HttpStatusCode);
        }

        [Fact]
        public async Task CreateWithCustomTokenUrl()
        {
            string customTokenUrl = "https://custom.token.url";
            var impersonatedCredential = CreateImpersonatedCredentialWithAccessTokenResponse(customTokenUrl: customTokenUrl);

            Assert.Equal(customTokenUrl, impersonatedCredential.TokenServerUrl);
            Assert.Equal("principal", impersonatedCredential.TargetPrincipal);
            Assert.True(await impersonatedCredential.HasCustomTokenUrlCache.Value);

            var success = await impersonatedCredential.RequestAccessTokenAsync(default);
            Assert.True(success);
            Assert.Equal(3600, impersonatedCredential.Token.ExpiresInSeconds);
            Assert.Equal("access_token", impersonatedCredential.Token.AccessToken);

            await Assert.ThrowsAsync<InvalidOperationException>(() => impersonatedCredential.SignBlobAsync(new byte[] { }));
            await Assert.ThrowsAsync<InvalidOperationException>(() => impersonatedCredential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("audience")));
        }

        [Fact]
        public async Task CreateWithCustomTokenUrl_NullPrincipal()
        {
            string customTokenUrl = "https://custom.token.url";
            var impersonatedCredential = CreateImpersonatedCredentialWithAccessTokenResponse(customTokenUrl: customTokenUrl, principal: null);

            Assert.Equal(customTokenUrl, impersonatedCredential.TokenServerUrl);
            Assert.Null(impersonatedCredential.TargetPrincipal);
            Assert.True(await impersonatedCredential.HasCustomTokenUrlCache.Value);

            var success = await impersonatedCredential.RequestAccessTokenAsync(default);
            Assert.True(success);
            Assert.Equal(3600, impersonatedCredential.Token.ExpiresInSeconds);
            Assert.Equal("access_token", impersonatedCredential.Token.AccessToken);

            await Assert.ThrowsAsync<InvalidOperationException>(() => impersonatedCredential.SignBlobAsync(new byte[] { }));
            await Assert.ThrowsAsync<InvalidOperationException>(() => impersonatedCredential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("audience")));
        }

        [Fact]
        public async Task CreateWithCustomTokenUrl_SameAsDefaultUrl()
        {
            string principal = "principal";
            string customTokenUrl = string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, GoogleAuthConsts.DefaultUniverseDomain, principal);
            var impersonatedCredential = CreateImpersonatedCredentialWithAccessTokenResponse(customTokenUrl: customTokenUrl);

            Assert.Equal(customTokenUrl, impersonatedCredential.TokenServerUrl);
            Assert.Equal(principal, impersonatedCredential.TargetPrincipal);
            Assert.False(await impersonatedCredential.HasCustomTokenUrlCache.Value);

            var success = await impersonatedCredential.RequestAccessTokenAsync(default);
            Assert.True(success);
            Assert.Equal(3600, impersonatedCredential.Token.ExpiresInSeconds);
            Assert.Equal("access_token", impersonatedCredential.Token.AccessToken);
        }

        [Fact]
        public async Task UniverseDomain_FromSourceCredential_Default()
        {
            string principal = "principal";

            var credential = ImpersonatedCredential.Create(
                CreateSourceCredential(),
                new ImpersonatedCredential.Initializer(principal));
            var googleCredential = credential as IGoogleCredential;

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await googleCredential.GetUniverseDomainAsync(default));
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, googleCredential.GetUniverseDomain());

            string expectedTokenUrl = string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, GoogleAuthConsts.DefaultUniverseDomain, principal);

            Assert.Null(credential.TokenServerUrl);
            Assert.False(await credential.HasCustomTokenUrlCache.Value);
            Assert.Equal(expectedTokenUrl, await credential.EffectiveTokenUrlCache.Value);
        }

        [Fact]
        public async Task UniverseDomain_FromSourceCredential_Custom()
        {
            string principal = "principal";
            string universeDomain = "universe.domain.com";

            var sourceCredential = GoogleCredential.FromComputeCredential(new ComputeCredential(new ComputeCredential.Initializer()
            {
                UniverseDomain = universeDomain
            }));

            var credential = ImpersonatedCredential.Create(
                sourceCredential,
                new ImpersonatedCredential.Initializer(principal));
            var googleCredential = credential as IGoogleCredential;

            Assert.Equal(universeDomain, await googleCredential.GetUniverseDomainAsync(default));
            Assert.Equal(universeDomain, googleCredential.GetUniverseDomain());

            string expectedTokenUrl = string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, universeDomain, principal);

            Assert.Null(credential.TokenServerUrl);
            Assert.False(await credential.HasCustomTokenUrlCache.Value);
            Assert.Equal(expectedTokenUrl, await credential.EffectiveTokenUrlCache.Value);
        }

        [Fact]
        public async Task WithUniverseDomain()
        {
            string principal = "principal";
            
            // We start off with a Compute
            string universeDomain1 = "universe1.domain.com";
            string universeDomain2 = "universe2.domain.com";

            // The impersonated credentials gets its universe domain from the source credential.
            // That is to say that impersonated and impersonator are assumed to be from the same universe domain.

            // Our impersonator is a ComputeCredential from universeDomain1.
            // (We specify the universe explicitly to avoid the HTTP call to the metadata server.)
            var sourceCredential = GoogleCredential.FromComputeCredential(new ComputeCredential(new ComputeCredential.Initializer()
            {
                UniverseDomain = universeDomain1
            }));

            // We use our impersonator to impersonate principal.
            var credential = ImpersonatedCredential.Create(
                sourceCredential,
                new ImpersonatedCredential.Initializer(principal));
            var googleCredential = credential as IGoogleCredential;
            // And now we change the universe domain of the impersonated credential.
            var newGoogleCredential = googleCredential.WithUniverseDomain(universeDomain2) ;

            // The new impersonated credential is a different instance.
            var newCredential = Assert.IsType<ImpersonatedCredential>(newGoogleCredential);
            Assert.NotSame(credential, newCredential);

            // The impersonator credentials are also different intances.
            Assert.NotSame(credential.SourceCredential, newCredential.SourceCredential);
            var newSourceCredential = Assert.IsType<GoogleCredential>(newCredential.SourceCredential);
            Assert.IsType<ComputeCredential>(newSourceCredential.UnderlyingCredential);

            // Both the original impersonator and impersonated are from universeDomain1.
            // Both the new impersonator and impersonated are from universeDomain2.
            Assert.Equal(universeDomain1, await credential.SourceCredential.GetUniverseDomainAsync(default));
            Assert.Equal(universeDomain2, await newCredential.SourceCredential.GetUniverseDomainAsync(default));

            Assert.Equal(universeDomain1, await googleCredential.GetUniverseDomainAsync(default));
            Assert.Equal(universeDomain1, googleCredential.GetUniverseDomain());

            Assert.Equal(universeDomain2, await newGoogleCredential.GetUniverseDomainAsync(default));
            Assert.Equal(universeDomain2, newGoogleCredential.GetUniverseDomain());

            // Token endpoints for the original and new credential include each the correct universe domain.
            string expectedTokenUrl = string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, universeDomain1, principal);

            Assert.Null(credential.TokenServerUrl);
            Assert.False(await credential.HasCustomTokenUrlCache.Value);
            Assert.Equal(expectedTokenUrl, await credential.EffectiveTokenUrlCache.Value);

            string newExpectedTokenUrl = string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, universeDomain2, principal);

            Assert.Null(newCredential.TokenServerUrl);
            Assert.False(await newCredential.HasCustomTokenUrlCache.Value);
            Assert.Equal(newExpectedTokenUrl, await newCredential.EffectiveTokenUrlCache.Value);
        }
    }
}
