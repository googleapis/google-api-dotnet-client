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
        public async Task FetchesAccessToken()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, Scope));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(
                request => ValidateAccessTokenRequest(request, ImpersonationScope),
                ValidateImpersonatedAccessTokenRequest);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, Scope, isWorkforce: true));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    WorkforcePoolUserProject = WorkforcePoolUserProject,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            Assert.Equal(1, messageHandler.Calls);
        }

        [Fact]
        public async Task FetchesAccessToken_ClientIdAndSecret_IgnoresWorkforce()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(request => ValidateAccessTokenRequest(request, Scope, isWorkforce: false));

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
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
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenJson);
            var messageHandler = new DelegatedMessageHandler(ValidateAccessTokenFromJsonSubjectTokenRequest);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    SubjectTokenJsonFieldName = SubjectTokenJsonField
                });

            Assert.Equal(AccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);
            var messageHandler = new DelegatedMessageHandler(AccessTokenRequest, RefreshTokenRequest);
            var clock = new MockClock(DateTime.UtcNow);

            var credential = new FileSourcedExternalAccountCredential(
                new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    Clock = clock
                });

            Assert.Equal(AccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(RefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        public static TheoryData<FileSourcedExternalAccountCredential, Type> SubjectTokenExceptionData
        {
            get
            {
                var subjectTokenPath = WriteSubjectTokenToTempFile(SubjectTokenText);

                var data = new TheoryData<FileSourcedExternalAccountCredential, Type>
                {
                    {
                        new FileSourcedExternalAccountCredential(
                            new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, "unknownPath")),
                        typeof(FileNotFoundException)
                    },
                    {
                        new FileSourcedExternalAccountCredential(
                            new FileSourcedExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, subjectTokenPath)
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
            var exception = await Assert.ThrowsAsync<SubjectTokenException>(async () => await credential.GetAccessTokenForRequestAsync());
            Assert.IsType(innerExceptionType, exception.InnerException);
        }
    }
}