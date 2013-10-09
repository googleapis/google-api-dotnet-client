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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Tests;
using Google.Apis.Util;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.AuthorizationCodeFlow"/>.</summary>
    [TestFixture]
    public class AuthorizationCodeFlowTests
    {
        private const string TokenUrl = "https://token.com";
        private const string AuthorizationCodeUrl = "https://authorization.com";

        #region Constructor

        [Test]
        public void TestConstructor_ArgumentException()
        {
            // ClientSecrets are missing.
            try
            {
                new AuthorizationCodeFlow(new AuthorizationCodeFlow.Initializer(
                    "https://authorization_code.com", "https://token.com"));
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.True(ex.Message.Contains("You MUST set ClientSecret or ClientSecretStream"));
            }
        }

        [Test]
        public void TestConstructor_DefaultValues()
        {
            var flow = CreateFlow();
            Assert.NotNull(flow.AccessMethod);
            Assert.That(flow.AccessMethod, Is.InstanceOf<BearerToken.AuthorizationHeaderAccessMethod>());
            Assert.That(flow.AuthorizationServerUrl, Is.EqualTo("https://authorization.com"));
            Assert.NotNull(flow.ClientSecrets);
            Assert.That(flow.ClientSecrets.ClientId, Is.EqualTo("id"));
            Assert.That(flow.ClientSecrets.ClientSecret, Is.EqualTo("secret"));
            Assert.That(flow.Clock, Is.InstanceOf<SystemClock>());
            Assert.Null(flow.DataStore);
            Assert.NotNull(flow.HttpClient);
            Assert.NotNull(flow.Scopes);
            Assert.That(flow.TokenServerUrl, Is.EqualTo("https://token.com"));

            Assert.That(flow.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Count(), Is.EqualTo(1));
            Assert.That(flow.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.First(),
                Is.InstanceOf<BackOffHandler>());
        }

        #endregion

        #region LoadToken

        [Test]
        public void LoadTokenAsync_NoDataStore()
        {
            var flow = CreateFlow();
            Assert.Null(flow.LoadTokenAsync("user", CancellationToken.None).Result);
        }

        [Test]
        public void LoadTokenAsync_NullResponse()
        {
            TaskCompletionSource<TokenResponse> tcs = new TaskCompletionSource<TokenResponse>();
            tcs.SetResult(null);
            Assert.Null(SubtestLoadTokenAsync(tcs));
        }

        [Test]
        public void LoadTokenAsync_TokenResponse()
        {
            TokenResponse response = new TokenResponse
            {
                AccessToken = "access"
            };

            TaskCompletionSource<TokenResponse> tcs = new TaskCompletionSource<TokenResponse>();
            tcs.SetResult(response);
            var result = SubtestLoadTokenAsync(tcs);
            Assert.That(result, Is.EqualTo(response));
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

        [Test]
        public void TestCreateAuthorizationCodeRequest()
        {
            var request = CreateFlow(scopes: new[] { "a", "b" }).CreateAuthorizationCodeRequest("redirect");
            Assert.That(request.AuthorizationServerUrl, Is.EqualTo(new Uri(AuthorizationCodeUrl)));
            Assert.That(request.ClientId, Is.EqualTo("id"));
            Assert.That(request.RedirectUri, Is.EqualTo("redirect"));
            Assert.That(request.ResponseType, Is.EqualTo("code"));
            Assert.That(request.Scope, Is.EqualTo("a b"));
            Assert.Null(request.State);
        }

        #endregion

        [Test]
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

        [Test]
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
                Assert.That(request.RequestUri, Is.EqualTo(new Uri(TokenUrl)));

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
                                Assert.That(keyValue[1], Is.EqualTo("c0de"));
                                break;
                            case "redirect_uri":
                                Assert.That(keyValue[1], Is.EqualTo("redIrect"));
                                break;
                            case "scope":
                                Assert.That(keyValue[1], Is.EqualTo("a"));
                                break;
                            case "grant_type":
                                Assert.That(keyValue[1], Is.EqualTo("authorization_code"));
                                break;
                            case "client_id":
                                Assert.That(keyValue[1], Is.EqualTo("id"));
                                break;
                            case "client_secret":
                                Assert.That(keyValue[1], Is.EqualTo("secret"));
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
                                Assert.That(keyValue[1], Is.EqualTo("REFRESH"));
                                break;
                            case "scope":
                                Assert.That(keyValue[1], Is.EqualTo("a"));
                                break;
                            case "grant_type":
                                Assert.That(keyValue[1], Is.EqualTo("refresh_token"));
                                break;
                            case "client_id":
                                Assert.That(keyValue[1], Is.EqualTo("id"));
                                break;
                            case "client_secret":
                                Assert.That(keyValue[1], Is.EqualTo("secret"));
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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
                Assert.Fail();
            }
            catch (AggregateException aex)
            {
                var ex = aex.InnerException as TokenResponseException;
                Assert.IsNotNull(ex);
                var result = ex.Error;
                Assert.That(result.Error, Is.EqualTo("error"));
                Assert.That(result.ErrorDescription, Is.EqualTo("desc"));
                Assert.That(result.ErrorUri, Is.EqualTo("uri"));
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
            Assert.That(response.RefreshToken, Is.EqualTo("r"));
            Assert.That(response.ExpiresInSeconds, Is.EqualTo(100));
            Assert.That(response.Scope, Is.EqualTo("b"));
        }
    }
}
