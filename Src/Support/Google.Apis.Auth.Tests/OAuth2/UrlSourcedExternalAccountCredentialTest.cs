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
using Google.Apis.Tests.Mocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class UrlSourcedExternalAccountCredentialsTests : ExternalAccountCredentialTestsBase
    {
        private const string SubjectTokenUrl = "https://dummy.subject.token.url/";
        private static readonly KeyValuePair<string, string> SubjectTokenServiceHeader = new KeyValuePair<string, string>("key1", "value1");

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

        private static Task<HttpResponseMessage> SubjectTokenRequest(HttpRequestMessage subjectTokenRequest) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(SubjectTokenText)
            });

        private static Task<HttpResponseMessage> SubjectTokenRequestFailure(HttpRequestMessage subjectTokenRequest) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable));

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

            AssertAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_Impersonated()
        {
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
                    ServiceAccountImpersonationUrl = ImpersonationUrl
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertImpersonatedAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_Workforce()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, Scope, isWorkforce: true));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { SubjectTokenServiceHeader } },
                    WorkforcePoolUserProject = WorkforcePoolUserProject,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_ClientIdAndSecret_IgnoresWorkforce()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, Scope, isWorkforce: false));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { SubjectTokenServiceHeader } },
                    WorkforcePoolUserProject = WorkforcePoolUserProject,
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
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

            messageHandler.AssertAllCallsMade();

            static Task<HttpResponseMessage> SubjectTokenAsJson(HttpRequestMessage subjectTokenRequest)
            {
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(SubjectTokenJson)
                });
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

            messageHandler.AssertAllCallsMade();
        }

        public static TheoryData<UrlSourcedExternalAccountCredential, Type> SubjectTokenExceptionData => new TheoryData<UrlSourcedExternalAccountCredential, Type>
        {
            {
                new UrlSourcedExternalAccountCredential(
                    new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                    {
                        // We retry 3 times so let's fail three times so the error is truly surfaced.
                        HttpClientFactory = new MockHttpClientFactory(new DelegatedMessageHandler(SubjectTokenRequestFailure, SubjectTokenRequestFailure, SubjectTokenRequestFailure))
                    }),
                typeof(HttpRequestException)
            },
            {
                new UrlSourcedExternalAccountCredential(
                    new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, SubjectTokenUrl)
                    {
                        HttpClientFactory = new MockHttpClientFactory(new DelegatedMessageHandler(SubjectTokenRequest)),
                        SubjectTokenJsonFieldName = "unknownField"
                    }),
                typeof(JsonReaderException)
            }
        };

        [Theory]
        [MemberData(nameof(SubjectTokenExceptionData))]
        public async Task SubjectTokenException(UrlSourcedExternalAccountCredential credential, Type innerExceptionType)
        {
            var exception = await Assert.ThrowsAsync<SubjectTokenException>(async () => await credential.GetAccessTokenForRequestAsync());
            Assert.IsType(innerExceptionType, exception.InnerException);
        }
    }
}