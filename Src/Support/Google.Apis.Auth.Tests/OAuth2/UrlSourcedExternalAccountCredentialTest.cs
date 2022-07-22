/*
Copyright 2022 Google LLC

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
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class UrlSourcedExternalAccountCredentialsTests
    {
        private const string SubjectTokenUrl = "https://dummy.subject.token.url/";
        private static readonly KeyValuePair<string, string> SubjectTokenServiceHeader = new KeyValuePair<string, string>("key1", "value1");

        private const string SubjectTokenText = "dummy_subject_token";
        private const string SubjectTokenJsonField = "subject_token_field";
        private static readonly string SubjectTokenJson = $@"{{""{SubjectTokenJsonField}"": ""{SubjectTokenText}""}}";

        private const string TokenUrl = "https://dummy.token.url/";
        private const string GrantTypeClaim = "grant_type=urn:ietf:params:oauth:grant-type:token-exchange";
        private const string RequestedTokenTypeClaim = "requested_token_type=urn:ietf:params:oauth:token-type:access_token";
        private const string Audience = "dummy_audience";
        private const string SubjectTokenType = "dummy_token_type";
        private const string Scope = "dummy_scope";
        private const string ImpersonationScope = "https://www.googleapis.com/auth/iam";
        private const string ClientId = "dummy_client_ID";
        private const string ClientSecret = "dummy_client_secret";

        private const string AccessToken = "dummy_access_token";
        private const string RefreshedAccessToken = "dummy_refreshed_access_token";
        private const string ImpersonatedAccessToken = "dummy_impersonated_access_token";
        private const string QuotaProject = "dummy_project_id";
        private const string QuotaProjectHeaderName = "x-goog-user-project";

        private static Task<HttpResponseMessage> ValidateSubjectTokenRequest(HttpRequestMessage subjectTokenRequest)
        {
            Assert.Equal(SubjectTokenUrl, subjectTokenRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, subjectTokenRequest.Method);

            Assert.Contains(subjectTokenRequest.Headers, header => header.Key == SubjectTokenServiceHeader.Key && header.Value.Single() == SubjectTokenServiceHeader.Value);

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(SubjectTokenText)
            });
        }

        private static async Task<HttpResponseMessage> ValidateAccessTokenRequest(HttpRequestMessage accessTokenRequest, string scope)
        {
            Assert.Equal(TokenUrl, accessTokenRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Post, accessTokenRequest.Method);

            Assert.Equal("Basic", accessTokenRequest.Headers.Authorization.Scheme);
            Assert.Equal(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")), accessTokenRequest.Headers.Authorization.Parameter);

            string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

            Assert.Contains(GrantTypeClaim, contentText);
            Assert.Contains(RequestedTokenTypeClaim, contentText);
            Assert.Contains($"audience={Audience}", contentText);
            Assert.Contains($"subject_token_type={SubjectTokenType}", contentText);
            Assert.Contains($"subject_token={SubjectTokenText}", contentText);
            Assert.Contains($"scope={scope}", contentText);

            return new HttpResponseMessage
            {
                Content = new StringContent(
                    NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                    {
                        AccessToken = AccessToken,
                        ExpiresInSeconds = 24 * 60 * 60,
                    }), Encoding.UTF8)
            };
        }

        [Fact]
        public async Task FetchesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, Scope));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { SubjectTokenServiceHeader } },
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            Assert.Equal(AccessToken, token.AccessToken);
            var header = Assert.Single(token.Headers);
            Assert.Equal(QuotaProjectHeaderName, header.Key);
            var headerValue = Assert.Single(header.Value);
            Assert.Equal(QuotaProject, headerValue);
            Assert.Equal(2, messageHandler.Calls);
        }

        [Fact]
        public async Task FetchesAccessToken_Impersonated()
        {
            const string impersonationUrl = "https://dummy.impersonation.url/";

            var messageHandler = new DelegatedMessageHandler(
                ValidateSubjectTokenRequest,
                request => ValidateAccessTokenRequest(request, ImpersonationScope),
                ValidateImpersonatedAccessTokenRequest);

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { SubjectTokenServiceHeader } },
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject,
                    ServiceAccountImpersonationUrl = impersonationUrl
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            Assert.Equal(ImpersonatedAccessToken, token.AccessToken);
            var header = Assert.Single(token.Headers);
            Assert.Equal(QuotaProjectHeaderName, header.Key);
            var headerValue = Assert.Single(header.Value);
            Assert.Equal(QuotaProject, headerValue);

            Assert.Equal(3, messageHandler.Calls);

            static async Task<HttpResponseMessage> ValidateImpersonatedAccessTokenRequest(HttpRequestMessage accessTokenRequest)
            {
                Assert.Equal(impersonationUrl, accessTokenRequest.RequestUri.ToString());
                Assert.Equal(HttpMethod.Post, accessTokenRequest.Method);

                Assert.Contains(accessTokenRequest.Headers, header => header.Key == QuotaProjectHeaderName && header.Value.Single() == QuotaProject);

                Assert.Equal("Bearer", accessTokenRequest.Headers.Authorization.Scheme);
                Assert.Equal(AccessToken, accessTokenRequest.Headers.Authorization.Parameter);

                string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

                Assert.Contains(Scope, contentText);

                return new HttpResponseMessage()
                { 
                    Content = new StringContent(
                        NewtonsoftJsonSerializer.Instance.Serialize(new
                        { 
                            accessToken = ImpersonatedAccessToken,
                            expireTime = "2020-05-13T16:00:00.045123456Z"
                        }))
                };
            }
        }

        [Fact]
        public async Task FetchesAccessToken_JsonSubjectToken()
        {
            var messageHandler = new DelegatedMessageHandler(SubjectTokenAsJson, ValidateAccessTokenFromJsonSubjectTokenRequest);

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    SubjectTokenJsonFieldName = SubjectTokenJsonField
                });

            Assert.Equal(AccessToken, await credential.GetAccessTokenForRequestAsync());

            Assert.Equal(2, messageHandler.Calls);

            static Task<HttpResponseMessage> SubjectTokenAsJson(HttpRequestMessage subjectTokenRequest)
            {
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(SubjectTokenJson)
                });
            }

            static async Task<HttpResponseMessage> ValidateAccessTokenFromJsonSubjectTokenRequest(HttpRequestMessage accessTokenRequest)
            {
                string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

                // Even if the subject token was returned as a JSON, the access token request should receive the token value only.
                Assert.Contains($"subject_token={SubjectTokenText}", contentText);

                return new HttpResponseMessage()
                {
                    Content = new StringContent(
                        NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                        {
                            AccessToken = AccessToken,
                            ExpiresInSeconds = 24 * 60 * 60,
                        }), Encoding.UTF8)
                };
            }
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(SubjectTokenRequest, AccessTokenRequest, SubjectTokenRequest, RefreshTokenRequest);
            var clock = new MockClock(DateTime.UtcNow);

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Clock = clock
                });

            Assert.Equal(AccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(RefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            Assert.Equal(4, messageHandler.Calls);

            static Task<HttpResponseMessage> SubjectTokenRequest(HttpRequestMessage subjectTokenRequest) =>
                Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(SubjectTokenText)
                });

            static Task<HttpResponseMessage> AccessTokenRequest(HttpRequestMessage accessTokenRequest) =>
                Task.FromResult(new HttpResponseMessage()
                {
                    Content = new StringContent(
                        NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                        {
                            AccessToken = AccessToken,
                            ExpiresInSeconds = 24 * 60 * 60,
                        }), Encoding.UTF8)
                });

            static Task<HttpResponseMessage> RefreshTokenRequest(HttpRequestMessage accessTokenRequest) =>
                Task.FromResult(new HttpResponseMessage()
                {
                    Content = new StringContent(
                        NewtonsoftJsonSerializer.Instance.Serialize(new TokenResponse
                        {
                            AccessToken = RefreshedAccessToken,
                            ExpiresInSeconds = 24 * 60 * 60,
                        }), Encoding.UTF8)
                });
        }
    }
}