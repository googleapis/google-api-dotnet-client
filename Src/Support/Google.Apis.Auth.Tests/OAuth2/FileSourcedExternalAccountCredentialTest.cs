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
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class FileSourcedExternalAccountCredentialsTests : ExternalAccountCredentialTestsBase
    {
        private static string WriteSubjectTokenToTempFile(string subjectToken)
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, subjectToken);
            return path;
        }

        [Fact]
        public async Task UniverseDomain_Default()
        {
            var credential = new FileSourcedExternalAccountCredential(new FileSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, "subjectTokenPath")) as IGoogleCredential;

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task UniverseDomain_Custom()
        {
            var credential = new FileSourcedExternalAccountCredential(new FileSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, "subjectTokenPath")
            {
                UniverseDomain = FakeUniverseDomain
            }) as IGoogleCredential;

            Assert.Equal(FakeUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task WithUniverseDomain()
        {
            var credential = new FileSourcedExternalAccountCredential(new FileSourcedExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, "subjectTokenPath")) as IGoogleCredential;

            var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

            Assert.NotSame(credential, newCredential);
            Assert.IsType<FileSourcedExternalAccountCredential>(newCredential);

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));

            Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task FetchesAccessToken()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, FakeScope));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(
                request => ValidateAccessTokenRequest(request, ImpersonationScope),
                ValidateImpersonatedAccessTokenRequest);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, FakeScope, isWorkforce: true));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    WorkforcePoolUserProject = FakeWorkforcePoolUserProject,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            Assert.Equal(1, messageHandler.Calls);
        }

        [Fact]
        public async Task FetchesAccessToken_ClientIdAndSecret_IgnoresWorkforce()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, FakeScope, isWorkforce: false));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenJson);
            var messageHandler = new DelegatedMessageHandler(ValidateAccessTokenFromJsonSubjectTokenRequest);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    SubjectTokenJsonFieldName = FakeSubjectTokenJsonField
                });

            Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(AccessTokenRequest, RefreshTokenRequest);
            var clock = new MockClock(DateTime.UtcNow);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Clock = clock
                });

            Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(FakeRefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        public static TheoryData<FileSourcedExternalAccountCredential, Type> SubjectTokenExceptionData
        {
            get
            {
                var subjectTokenPath = WriteSubjectTokenToTempFile(FakeSubjectTokenText);

                var data = new TheoryData<FileSourcedExternalAccountCredential, Type>
                {
                    {
                        new FileSourcedExternalAccountCredential(
                            new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, "unknownPath")),
                        typeof(FileNotFoundException)
                    },
                    {
                        new FileSourcedExternalAccountCredential(
                            new FileSourcedExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, subjectTokenPath)
                            {
                                SubjectTokenJsonFieldName = "unknownField"
                            }),
                        typeof(JsonReaderException)
                    }
                };

                return data;
            }
        }

        [Theory]
        [MemberData(nameof(SubjectTokenExceptionData))]
        public async Task SubjectTokenException(FileSourcedExternalAccountCredential credential, Type innerExceptionType)
        {
            var exception = await Assert.ThrowsAsync<SubjectTokenException>(() => credential.GetAccessTokenForRequestAsync());
            Assert.IsType(innerExceptionType, exception.InnerException);
        }
    }
}