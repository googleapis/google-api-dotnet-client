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
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // ClientSecrets are missing.
            try
            {
                new AuthorizationCodeFlow(new AuthorizationCodeFlow.Initializer(
                    "https://authorization_code.com", "https://token.com"));
                Assert.True(false, "Exception expected");
            }
            catch (ArgumentException ex)
            {
                Assert.True(ex.Message.Contains("You MUST set ClientSecret or ClientSecretStream"));
            }
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
            Assert.NotNull(flow.Scopes);
            Assert.Equal("https://token.com", flow.TokenServerUrl);

            // Disable "<member> is obsolete" warning for these uses.
            // MessageHandler no longer provides a supported way for clients to query the list of handlers,
            // but we rely on the obsolete property as an implementation detail here.
            #pragma warning disable 618
            Assert.Equal(1, flow.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Count());
            Assert.IsType<BackOffHandler>(flow.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.First());
            #pragma warning restore 618
        }

        #endregion

        #region LoadToken

        [Fact]
        public void LoadTokenAsync_NoDataStore()
        {
            var flow = CreateFlow();
            Assert.Null(flow.LoadTokenAsync("user", CancellationToken.None).Result);
        }

        [Fact]
        public void LoadTokenAsync_NullResponse()
        {
            TaskCompletionSource<TokenResponse> tcs = new TaskCompletionSource<TokenResponse>();
            tcs.SetResult(null);
            Assert.Null(SubtestLoadTokenAsync(tcs));
        }

        [Fact]
        public void LoadTokenAsync_TokenResponse()
        {
            TokenResponse response = new TokenResponse
            {
                AccessToken = "access"
            };

            TaskCompletionSource<TokenResponse> tcs = new TaskCompletionSource<TokenResponse>();
            tcs.SetResult(response);
            var result = SubtestLoadTokenAsync(tcs);
            Assert.Equal(response, result);
        }

        private TokenResponse SubtestLoadTokenAsync(TaskCompletionSource<TokenResponse> tcs)
        {
            var mock = new Mock<IDataStore>();
            mock.Setup(ds => ds.GetAsync<TokenResponse>("user")).Returns(tcs.Task);
            var flow = CreateFlow(dataStore: mock.Object);
            var result = flow.LoadTokenAsync("user", CancellationToken.None).Result;
            mock.Verify(ds => ds.GetAsync<TokenResponse>("user"));
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

        #endregion

        [Fact]
        public void TestExchangeCodeForTokenAsync()
        {
            var mock = new Mock<IDataStore>();
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
            {
                Code = "c0de",
                RedirectUri = "redIrect",
                Scope = "a"
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);

            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            tcs.SetResult(null);
            mock.Setup(ds => ds.StoreAsync("uSer", It.IsAny<TokenResponse>())).Returns(tcs.Task);

            var flow = CreateFlow(httpClientFactory: mockFactory, scopes: new[] { "a" }, dataStore: mock.Object);
            var response = flow.ExchangeCodeForTokenAsync("uSer", "c0de", "redIrect", CancellationToken.None).Result;
            SubtestTokenResponse(response);

            mock.Verify(ds => ds.StoreAsync("uSer", It.IsAny<TokenResponse>()));
        }

        [Fact]
        public void TestRefreshTokenAsync()
        {
            var mock = new Mock<IDataStore>();
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
            {
                RefreshToken = "REFRESH",
                Scope = "a"
            };
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);

            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            tcs.SetResult(null);
            mock.Setup(ds => ds.StoreAsync("uSer", It.IsAny<TokenResponse>())).Returns(tcs.Task);

            var flow = CreateFlow(httpClientFactory: mockFactory, scopes: new[] { "a" }, dataStore: mock.Object);
            var response = flow.RefreshTokenAsync("uSer", "REFRESH", CancellationToken.None).Result;
            SubtestTokenResponse(response);


            mock.Verify(ds => ds.StoreAsync("uSer", It.IsAny<TokenResponse>()));
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
        public void TestFetchTokenAsync_AuthorizationCodeRequest()
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
            var response = flow.FetchTokenAsync("user", handler.AuthorizationCodeTokenRequest,
                CancellationToken.None).Result;
            SubtestTokenResponse(response);
        }

        [Fact]
        public void TestFetchTokenAsync_RefreshTokenRequest()
        {
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
                {
                    RefreshToken = "REFRESH",
                    Scope = "a"
                };

            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);

            var flow = CreateFlow(httpClientFactory: mockFactory);
            var response = flow.FetchTokenAsync("user", handler.RefreshTokenRequest, CancellationToken.None).Result;
            SubtestTokenResponse(response);
        }

        [Fact]
        public void TestFetchTokenAsync_AuthorizationCodeRequest_Error()
        {
            var handler = new FetchTokenMessageHandler();
            handler.AuthorizationCodeTokenRequest = new AuthorizationCodeTokenRequest()
                {
                    Code = "c0de",
                    RedirectUri = "redIrect",
                    Scope = "a"
                };
            handler.Error = true;
            SubtestFetchTokenAsync_Error(handler);
        }

        [Fact]
        public void TestFetchTokenAsync_RefreshTokenRequest_Error()
        {
            var handler = new FetchTokenMessageHandler();
            handler.RefreshTokenRequest = new RefreshTokenRequest()
                {
                    RefreshToken = "REFRESH",
                    Scope = "a"
                };
            handler.Error = true;
            SubtestFetchTokenAsync_Error(handler);
        }

        /// <summary>Subtest for receiving an error token response.</summary>
        /// <param name="handler">The message handler.</param>
        private void SubtestFetchTokenAsync_Error(FetchTokenMessageHandler handler)
        {
            MockHttpClientFactory mockFactory = new MockHttpClientFactory(handler);
            var flow = CreateFlow(httpClientFactory: mockFactory);
            try
            {
                var request =
                    (TokenRequest)handler.AuthorizationCodeTokenRequest ?? (TokenRequest)handler.RefreshTokenRequest;
                var result = flow.FetchTokenAsync("user", request, CancellationToken.None).Result;
                Assert.True(false, "Exception expected");
            }
            catch (AggregateException aex)
            {
                var ex = aex.InnerException as TokenResponseException;
                Assert.NotNull(ex);
                var result = ex.Error;
                Assert.Equal("error", result.Error);
                Assert.Equal("desc", result.ErrorDescription);
                Assert.Equal("uri", result.ErrorUri);
            }
        }

        #endregion

        /// <summary>Creates an authorization code flow with the given parameters.</summary>
        /// <param name="dataStore">The data store.</param>
        /// <param name="scopes">The Scopes.</param>
        /// <param name="httpClientFactory">The HTTP client factory. If not set the default will be used.</param>
        /// <returns>Authorization code flow</returns>
        private AuthorizationCodeFlow CreateFlow(IDataStore dataStore = null, IEnumerable<string> scopes = null,
            IHttpClientFactory httpClientFactory = null)
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
            if (scopes != null)
            {
                initializer.Scopes = scopes;
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
    }
}
