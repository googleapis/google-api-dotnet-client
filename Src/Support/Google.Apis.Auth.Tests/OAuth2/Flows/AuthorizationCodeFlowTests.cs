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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Flows
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.AuthorizationCodeFlow"/>.</summary>
    public class AuthorizationCodeFlowTests
    {
        private const string TokenUrl = "https://token.com";
        private const string AuthorizationCodeUrl = "https://authorization.com";

        #region Constructor

        [Fact]
        public void TestConstructor_ArgumentException()
        {
            var initializer = new AuthorizationCodeFlow.Initializer("https://authorization_code.com", "https://token.com");
            // ClientSecrets are missing.
            var exception = Assert.Throws<ArgumentException>(() => new AuthorizationCodeFlow(initializer));
            Assert.Contains("You MUST set ClientSecret or ClientSecretStream", exception.Message);
        }

        [Fact]
        public void TestConstructor_DefaultValues()
        {
            var flow = CreateFlow();
            Assert.NotNull(flow.AccessMethod);
            Assert.IsType<BearerToken.AuthorizationHeaderAccessMethod>(flow.AccessMethod);
            Assert.Equal("https://authorization.com", flow.AuthorizationServerUrl);
            Assert.NotNull(flow.ClientSecrets);
            Assert.Equal("id", flow.ClientSecrets.ClientId);
            Assert.Equal("secret", flow.ClientSecrets.ClientSecret);
            Assert.IsType<SystemClock>(flow.Clock);
            Assert.Null(flow.DataStore);
            Assert.NotNull(flow.HttpClient);
            Assert.Null(flow.Scopes);
            Assert.Equal("https://token.com", flow.TokenServerUrl);

            // Disable "<member> is obsolete" warning for these uses.
            // MessageHandler no longer provides a supported way for clients to query the list of handlers,
            // but we rely on the obsolete property as an implementation detail here.
#pragma warning disable 618
            IHttpUnsuccessfulResponseHandler badResponseHandler = Assert.Single(flow.HttpClient.MessageHandler.UnsuccessfulResponseHandlers);
            IHttpExceptionHandler exceptionHandler = Assert.Single(flow.HttpClient.MessageHandler.ExceptionHandlers);
#pragma warning restore 618

            BackOffHandler backOffBadResponseHandler = Assert.IsType<BackOffHandler>(badResponseHandler);
            BackOffHandler backOffExceptionHandler = Assert.IsType<BackOffHandler>(exceptionHandler);
            Assert.Same(backOffBadResponseHandler, backOffExceptionHandler);
        }

        #endregion

        [Fact]
        public void WithHttpClientFactory()
        {
            var flow = CreateFlow();
            var factory = new HttpClientFactory();
            var flowWithFactory = Assert.IsType<AuthorizationCodeFlow>(
                ((IHttpAuthorizationFlow)flow).WithHttpClientFactory(factory));

            Assert.NotSame(flow, flowWithFactory);
            Assert.NotSame(flow.HttpClient, flowWithFactory.HttpClient);
            Assert.NotSame(flow.HttpClientFactory, flowWithFactory.HttpClientFactory);
            Assert.Same(factory, flowWithFactory.HttpClientFactory);
        }

        [Fact]
        public void Deafault_RecommendedRetryPolicy()
        {
            var mockFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());
            var flow = CreateFlow(httpClientFactory: mockFactory);

            var args = Assert.Single(mockFactory.AllCreateHttpClientArgs);

            var retryInitializer = Assert.Single(args.Initializers);
            Assert.Same(GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry, retryInitializer);
        }

        [Fact]
        public void BadResponse503AndRecommended_RecommendedRetryPolicy()
        {
            var mockFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());
            var flow = CreateFlow(
                httpClientFactory: mockFactory,
                exponentialBackOffPolicy: ExponentialBackOffPolicy.UnsuccessfulResponse503 | ExponentialBackOffPolicy.RecommendedOrDefault);

            var args = Assert.Single(mockFactory.AllCreateHttpClientArgs);

            var retryInitializer = Assert.Single(args.Initializers);
            Assert.Same(GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry, retryInitializer);
        }

        [Fact]
        public void ExceptionAndRecommended_RecommendedAndOtherRetryPolicy()
        {
            var mockFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());
            var flow = CreateFlow(
                httpClientFactory: mockFactory,
                exponentialBackOffPolicy: ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.RecommendedOrDefault);

            var args = Assert.Single(mockFactory.AllCreateHttpClientArgs);

            Assert.Equal(2, args.Initializers.Count);
            Assert.Contains(GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry, args.Initializers);
            Assert.Contains(args.Initializers, initializer => initializer != GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry);
        }

        [Fact]
        public void NoRetryPolicy()
        {
            var mockFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());
            var flow = CreateFlow(httpClientFactory: mockFactory, exponentialBackOffPolicy: ExponentialBackOffPolicy.None);

            var args = Assert.Single(mockFactory.AllCreateHttpClientArgs);

            Assert.Empty(args.Initializers);
        }

        [Theory]
        [InlineData(ExponentialBackOffPolicy.Exception)]
        [InlineData(ExponentialBackOffPolicy.UnsuccessfulResponse503)]
        [InlineData(ExponentialBackOffPolicy.Exception | ExponentialBackOffPolicy.UnsuccessfulResponse503)]
        public void OtherThanRecommendedRetryPolicy(ExponentialBackOffPolicy policy)
        {
            var mockFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());
            var flow = CreateFlow(httpClientFactory: mockFactory, exponentialBackOffPolicy: policy);

            var args = Assert.Single(mockFactory.AllCreateHttpClientArgs);

            var retryInitializer = Assert.Single(args.Initializers);
            Assert.NotSame(GoogleAuthConsts.OAuth2TokenEndpointRecommendedRetry, retryInitializer);
        }

        #region LoadToken

        [Fact]
        public async Task LoadTokenAsync_NoDataStore()
        {
            var flow = CreateFlow();
            Assert.Null(await flow.LoadTokenAsync("user", default));
        }

        [Fact]
        public async Task LoadTokenAsync_NullResponse()
        {
            Assert.Null(await SubtestLoadTokenAsync(null));
        }

        [Fact]
        public async Task LoadTokenAsync_TokenResponse()
        {
            TokenResponse response = new TokenResponse
            {
                AccessToken = "access"
            };

            var result = await SubtestLoadTokenAsync(response);
            Assert.Equal(response, result);
        }

        private async Task<TokenResponse> SubtestLoadTokenAsync(TokenResponse response)
        {
            var store = new FakeDataStore { TokenResponse = response };
            var flow = CreateFlow(dataStore: store);
            var result = await flow.LoadTokenAsync("user", default);
            Assert.Equal("user", store.FetchedKey);
            return result;
        }

        #endregion

        #region CreateAuthorizationCodeRequest

        [Fact]
        public void TestCreateAuthorizationCodeRequest()
        {
            var request = CreateFlow(scopes: new[] { "a", "b" }).CreateAuthorizationCodeRequest("redirect");
            Assert.Equal(new Uri(AuthorizationCodeUrl), request.AuthorizationServerUrl);
            Assert.Equal("id", request.ClientId);
            Assert.Equal("redirect", request.RedirectUri);
            Assert.Equal("code", request.ResponseType);
            Assert.Equal("a b", request.Scope);
            Assert.Null(request.State);
        }

        [Fact]
        public void TestCreateAuthorizationCodeRequest_DefaultValues()
        {
            var request = CreateFlow().CreateAuthorizationCodeRequest("redirect");
            Assert.Equal(new Uri(AuthorizationCodeUrl), request.AuthorizationServerUrl);
            Assert.Equal("id", request.ClientId);
            Assert.Equal("redirect", request.RedirectUri);
            Assert.Equal("code", request.ResponseType);
            Assert.Null(request.Scope);
            Assert.Null(request.State);
        }

        #endregion

        [Fact]
        public async Task TestExchangeCodeForTokenAsync()
        {
            var store = new FakeDataStore();
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
            {
                Code = "c0de",
                RedirectUri = "redIrect",
                Scope = "a"
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);
            var flow = CreateFlow(httpClientFactory: mockFactory, scopes: new[] { "a" }, dataStore: store);
            var response = await flow.ExchangeCodeForTokenAsync("uSer", "c0de", "redIrect", default);
            SubtestTokenResponse(response);

            Assert.Equal("uSer", store.StoredKey);
        }

        [Fact]
        public async Task TestExchangeCodeForTokenAsync_NullScopes()
        {
            var store = new FakeDataStore();
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
            {
                Code = "c0de",
                RedirectUri = "redIrect",
                Scope = null
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);
            var flow = CreateFlow(httpClientFactory: mockFactory, scopes: null, dataStore: store);
            var response = await flow.ExchangeCodeForTokenAsync("uSer", "c0de", "redIrect", default);
            SubtestTokenResponse(response);

            Assert.Equal("uSer", store.StoredKey);
        }

        [Fact]
        public async Task TestRefreshTokenAsync()
        {
            var store = new FakeDataStore();
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
            {
                RefreshToken = "REFRESH",
                Scope = "a"
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);
            var flow = CreateFlow(httpClientFactory: mockFactory, scopes: new[] { "a" }, dataStore: store);
            var response = await flow.RefreshTokenAsync("uSer", "REFRESH", default);
            SubtestTokenResponse(response);

            Assert.Equal("uSer", store.StoredKey);
        }

        #region FetchToken

        /// <summary>
        /// Fetch token message handler, which expects an authorization code token request or a refresh token request.
        /// It verifies all the query parameters are valid and return an error response in case <see cref="Error"/> 
        /// is <c>true</c>.
        /// </summary>
        public class FetchTokenMessageHandler : CountableMessageHandler
        {
            internal AuthorizationCodeTokenRequest AuthorizationCodeTokenRequest { get; set; }
            internal RefreshTokenRequest RefreshTokenRequest { get; set; }
            internal bool Error { get; set; }

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken taskCancellationToken)
            {
                Assert.Equal(new Uri(TokenUrl), request.RequestUri);

                if (AuthorizationCodeTokenRequest != null)
                {
                    // Verify right parameters.
                    var content = await request.Content.ReadAsStringAsync();
                    foreach (var parameter in content.Split('&'))
                    {
                        var keyValue = parameter.Split('=');
                        switch (keyValue[0])
                        {
                            case "code":
                                Assert.Equal("c0de", keyValue[1]);
                                break;
                            case "redirect_uri":
                                Assert.Equal("redIrect", keyValue[1]);
                                break;
                            case "scope":
                                Assert.Equal("a", keyValue[1]);
                                break;
                            case "grant_type":
                                Assert.Equal("authorization_code", keyValue[1]);
                                break;
                            case "client_id":
                                Assert.Equal("id", keyValue[1]);
                                break;
                            case "client_secret":
                                Assert.Equal("secret", keyValue[1]);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Invalid parameter!");
                        }
                    }
                }
                else
                {
                    // Verify right parameters.
                    var content = await request.Content.ReadAsStringAsync();
                    foreach (var parameter in content.Split('&'))
                    {
                        var keyValue = parameter.Split('=');
                        switch (keyValue[0])
                        {
                            case "refresh_token":
                                Assert.Equal("REFRESH", keyValue[1]);
                                break;
                            case "scope":
                                Assert.Equal("a", keyValue[1]);
                                break;
                            case "grant_type":
                                Assert.Equal("refresh_token", keyValue[1]);
                                break;
                            case "client_id":
                                Assert.Equal("id", keyValue[1]);
                                break;
                            case "client_secret":
                                Assert.Equal("secret", keyValue[1]);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Invalid parameter!");
                        }
                    }
                }

                var response = new HttpResponseMessage();
                if (Error)
                {
                    response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    var serializedObject = NewtonsoftJsonSerializer.Instance.Serialize(new TokenErrorResponse
                    {
                        Error = "error",
                        ErrorDescription = "desc",
                        ErrorUri = "uri"
                    });
                    response.Content = new StringContent(serializedObject, Encoding.UTF8);
                }
                else
                {
                    var serializedObject = NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                    {
                        AccessToken = "a",
                        RefreshToken = "r",
                        ExpiresInSeconds = 100,
                        Scope = "b",
                    });
                    response.Content = new StringContent(serializedObject, Encoding.UTF8);
                }

                return response;
            }
        }

        [Fact]
        public async Task TestFetchTokenAsync_AuthorizationCodeRequest()
        {
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
            {
                Code = "c0de",
                RedirectUri = "redIrect",
                Scope = "a"
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);

            var flow = CreateFlow(httpClientFactory: mockFactory);
            var response = await flow.FetchTokenAsync("user", handler.AuthorizationCodeTokenRequest, default);
            SubtestTokenResponse(response);
        }

        [Fact]
        public async Task TestFetchTokenAsync_RefreshTokenRequest()
        {
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
            {
                RefreshToken = "REFRESH",
                Scope = "a"
            };

            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);

            var flow = CreateFlow(httpClientFactory: mockFactory);
            var response = await flow.FetchTokenAsync("user", handler.RefreshTokenRequest, default);
            SubtestTokenResponse(response);
        }

        [Fact]
        public async Task TestFetchTokenAsync_AuthorizationCodeRequest_Error()
        {
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
            {
                Code = "c0de",
                RedirectUri = "redIrect",
                Scope = "a"
            };
            handler.Error = true;
            await SubtestFetchTokenAsync_Error(handler);
        }

        [Fact]
        public async Task TestFetchTokenAsync_RefreshTokenRequest_Error()
        {
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
                {
                    RefreshToken = "REFRESH",
                    Scope = "a"
                };
            handler.Error = true;
            await SubtestFetchTokenAsync_Error(handler);
        }

        // TODO: Potentially rewrite these as a Theory with TheoryData. (Hard to do inline.)
        /// <summary>Subtest for receiving an error token response.</summary>
        /// <param name="handler">The message handler.</param>
        private async Task SubtestFetchTokenAsync_Error(FetchTokenMessageHandler handler)
        {
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);
            var flow = CreateFlow(httpClientFactory: mockFactory);
            var request = (TokenRequest) handler.AuthorizationCodeTokenRequest ?? handler.RefreshTokenRequest;
            var exception = await Assert.ThrowsAsync<TokenResponseException>(() => flow.FetchTokenAsync("user", request, default));

            var error = exception.Error;
            Assert.Equal("error", error.Error);
            Assert.Equal("desc", error.ErrorDescription);
            Assert.Equal("uri", error.ErrorUri);
        }

        #endregion

        /// <summary>Creates an authorization code flow with the given parameters.</summary>
        /// <param name="dataStore">The data store.</param>
        /// <param name="scopes">The Scopes.</param>
        /// <param name="httpClientFactory">The HTTP client factory. If not set the default will be used.</param>
        /// <returns>Authorization code flow</returns>
        private AuthorizationCodeFlow CreateFlow(
            IDataStore dataStore = null,
            IEnumerable<string> scopes = null,
            IHttpClientFactory httpClientFactory = null,
            ExponentialBackOffPolicy? exponentialBackOffPolicy = null)
        {
            var secrets = new ClientSecrets() { ClientId = "id", ClientSecret = "secret" };
            var initializer = new AuthorizationCodeFlow.Initializer(AuthorizationCodeUrl, TokenUrl)
            {
                ClientSecrets = secrets,
                HttpClientFactory = httpClientFactory
            };

            if (dataStore != null)
            {
                initializer.DataStore = dataStore;
            }
            initializer.Scopes = scopes;
            if (exponentialBackOffPolicy.HasValue)
            {
                initializer.DefaultExponentialBackOffPolicy = exponentialBackOffPolicy.Value;
            }
            return new AuthorizationCodeFlow(initializer);
        }

        /// <summary>Verifies that the token response contains the expected data.</summary>
        /// <param name="response">The token response</param>
        private void SubtestTokenResponse(TokenResponse response)
        {
            Assert.Equal("r", response.RefreshToken);
            Assert.Equal(100, response.ExpiresInSeconds);
            Assert.Equal("b", response.Scope);
        }

        private class FakeDataStore : IDataStore
        {
            public string StoredKey { get; private set; }
            public string FetchedKey { get; private set; }
            public TokenResponse TokenResponse { get; set; }

            public Task ClearAsync() => throw new NotImplementedException();

            public Task DeleteAsync<T>(string key) => throw new NotImplementedException();

            public Task<T> GetAsync<T>(string key)
            {
                FetchedKey = key;
                return Task.FromResult((T) (object) TokenResponse);
            }

            public Task StoreAsync<T>(string key, T value)
            {
                StoredKey = key;
                // Task.CompletedTask doesn't exist in older frameworks.
                return Task.FromResult<object>(null);
            }
        }
    }
}
