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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class UrlSourcedExternalAccountCredentialsTests : ExternalAccountCredentialTestsBase
    {
        private const string FakeSubjectTokenUrl = "https://fake.subject.token.url/";
        private static readonly KeyValuePair<string, string> KeySubjectTokenServiceHeader = new KeyValuePair<string, string>("key1", "value1");

        private static Task<HttpResponseMessage> ValidateSubjectTokenRequest(HttpRequestMessage subjectTokenRequest)
        {
            Assert.Equal(FakeSubjectTokenUrl, subjectTokenRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, subjectTokenRequest.Method);

            Assert.Contains(subjectTokenRequest.Headers, header => header.Key == KeySubjectTokenServiceHeader.Key && header.Value.Single() == KeySubjectTokenServiceHeader.Value);

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(FakeSubjectTokenText)
            });
        }

        private static Task<HttpResponseMessage> SubjectTokenRequest(HttpRequestMessage subjectTokenRequest) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(FakeSubjectTokenText)
            });

        private static Task<HttpResponseMessage> SubjectTokenRequestFailure(HttpRequestMessage subjectTokenRequest) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable));

        [Fact]
        public async Task UniverseDomain_Default()
        {
            var credential = new UrlSourcedExternalAccountCredential(new UrlSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)) as IGoogleCredential;

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task UniverseDomain_Custom()
        {
            var credential = new UrlSourcedExternalAccountCredential(new UrlSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
            {
                UniverseDomain = FakeUniverseDomain
            }) as IGoogleCredential;

            Assert.Equal(FakeUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task WithUniverseDomain()
        {
            var credential = new UrlSourcedExternalAccountCredential(new UrlSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)) as IGoogleCredential;

            var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

            Assert.NotSame(credential, newCredential);
            Assert.IsType<UrlSourcedExternalAccountCredential>(newCredential);

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));

            Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task FetchesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, FakeScope));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { KeySubjectTokenServiceHeader } },
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject
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
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { KeySubjectTokenServiceHeader } },
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject,
                    ServiceAccountImpersonationUrl = ImpersonationUrl
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertImpersonatedAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_Workforce()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, FakeScope, isWorkforce: true));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { KeySubjectTokenServiceHeader } },
                    WorkforcePoolUserProject = FakeWorkforcePoolUserProject,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_ClientIdAndSecret_IgnoresWorkforce()
        {
            var messageHandler = new DelegatedMessageHandler(ValidateSubjectTokenRequest, request => ValidateAccessTokenRequest(request, FakeScope, isWorkforce: false));

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Headers = { { KeySubjectTokenServiceHeader } },
                    WorkforcePoolUserProject = FakeWorkforcePoolUserProject,
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject
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
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    SubjectTokenJsonFieldName = FakeSubjectTokenJsonField
                });

            Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();

            static Task<HttpResponseMessage> SubjectTokenAsJson(HttpRequestMessage subjectTokenRequest)
            {
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(FakeSubjectTokenJson)
                });
            }
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(SubjectTokenRequest, AccessTokenRequest, SubjectTokenRequest, RefreshTokenRequest);
            var clock = new MockClock(DateTime.UtcNow);

            var credential = new UrlSourcedExternalAccountCredential(
                new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Clock = clock
                });

            Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(FakeRefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        public static TheoryData<UrlSourcedExternalAccountCredential, Type> SubjectTokenExceptionData => new TheoryData<UrlSourcedExternalAccountCredential, Type>
        {
            {
                new UrlSourcedExternalAccountCredential(
                    new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
                    {
                        // We retry 3 times so let's fail three times so the error is truly surfaced.
                        HttpClientFactory = new MockHttpClientFactory(new DelegatedMessageHandler(SubjectTokenRequestFailure, SubjectTokenRequestFailure, SubjectTokenRequestFailure))
                    }),
                typeof(HttpRequestException)
            },
            {
                new UrlSourcedExternalAccountCredential(
                    new UrlSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeSubjectTokenUrl)
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
            var exception = await Assert.ThrowsAsync<SubjectTokenException>(() => credential.GetAccessTokenForRequestAsync());
            Assert.IsType(innerExceptionType, exception.InnerException);
        }
    }
}