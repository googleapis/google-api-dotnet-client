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
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class AwsExternalAccountCredentialsTests : ExternalAccountCredentialTestsBase
    {
        private const string FakeImdsv2Url = "http://169.254.169.254/fake-imds/";
        private const string ImdsV2TokenTtlHeaderName = "X-aws-ec2-metadata-token-ttl-seconds";
        private const string ImdsV2TokenTtlSeconds = "3600";

        private const string FakeImdsV2Token = "fake_imdsv2_token";
        private const string ImdsV2TokenHeaderName = "X-aws-ec2-metadata-token";

        private const string FakeRegionUrl = "http://169.254.169.254/fake-region/";
        private const string MetadataRegion = "us-central-a1";
        private const string Region = "us-central-a";

        private const string FakeSecurityCredentialsUrl = "http://169.254.169.254/fake-security-credentials/";
        private const string FakeSecurityCredentialsRole = "fake_role";

        private const string FakeSecurityCredentialsAccessKeyId = "fake_credentials_key_id";
        private const string FakeSecurityCredentialsSecretAccessKey = "fake_credentials_secret";
        private const string FakeSecurityCredentialsToken = "fake_credentials_token";

        private const string FakeVerificationUrl = "http://iam.{region}.fakeaws.com/?Action=GetCallerIdentity&Version=2011-06-15";
        private const string FakeRegionalizedVerificationUrl = "http://iam.us-central-a.fakeaws.com/?Action=GetCallerIdentity&Version=2011-06-15";
        private const string FakeRegionalizedVerificationHost = "iam.us-central-a.fakeaws.com";
        private const string ServiceName = "iam";

        private static readonly DateTime MockUtcNow = new DateTime(2022, 9, 29, 5, 47, 56, DateTimeKind.Utc);

        [Fact]
        public async Task UniverseDomain_Default()
        {
            var credential = new AwsExternalAccountCredential(new AwsExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)) as IGoogleCredential;

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task UniverseDomain_Custom()
        {
            var credential = new AwsExternalAccountCredential(new AwsExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)
            {
                UniverseDomain = FakeUniverseDomain
            }) as IGoogleCredential;

            Assert.Equal(FakeUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await credential.GetUniverseDomainAsync(default));
        }

        [Fact]
        public async Task WithUniverseDomain()
        {
            var credential = new AwsExternalAccountCredential(new AwsExternalAccountCredential.Initializer(
                TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)) as IGoogleCredential;

            var newCredential = credential.WithUniverseDomain(FakeUniverseDomain);

            Assert.NotSame(credential, newCredential);
            Assert.IsType<AwsExternalAccountCredential>(newCredential);

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, await credential.GetUniverseDomainAsync(default));

            Assert.Equal(FakeUniverseDomain, newCredential.GetUniverseDomain());
            Assert.Equal(FakeUniverseDomain, await newCredential.GetUniverseDomainAsync(default));
        }

        [Theory]
        [InlineData("https://dummy-host/", FakeRegionUrl, FakeSecurityCredentialsUrl, "IMDS")]
        [InlineData("https://dummy-host/", null, null, "IMDS")]
        [InlineData(FakeImdsv2Url, "https://dummy-host/", FakeSecurityCredentialsUrl, "Region")]
        [InlineData(null, "https://dummy-host/", null, "Region")]
        [InlineData(FakeImdsv2Url, FakeRegionUrl, "https://dummy-host/", "Security Credentials")]
        [InlineData(null, null, "https://dummy-host/", "Security Credentials")]
        public void ValidatesAwsMetadataServerUrls(string imdsV2TokenUrl, string regionUrl, string securityCredentials, string inMessage)
        {
            var exception = Assert.Throws<InvalidOperationException>(() => new AwsExternalAccountCredential(
                new AwsExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)
                {
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject,
                    ImdsV2SessionTokenUrl = imdsV2TokenUrl,
                    RegionUrl = regionUrl,
                    SecurityCredentialsUrl = securityCredentials,
                }));
            Assert.Contains(inMessage, exception.Message);
        }

        [Fact]
        public async Task FetchesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(
                ValidateImdsV2TokenRequest,
                ValidateRegionRequest,
                ValidateRoleRequest,
                ValidateSecurityCredentialsRequest,
                request => ValidateAccessTokenRequest(request, FakeScope, ValidateSubjectToken));

            var credential = new AwsExternalAccountCredential(
                new AwsExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject,
                    ImdsV2SessionTokenUrl = FakeImdsv2Url,
                    SecurityCredentialsUrl = FakeSecurityCredentialsUrl,
                    RegionUrl = FakeRegionUrl,
                    Clock = new MockClock(MockUtcNow)
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task FetchesAccessToken_Impersonated()
        {
            var messageHandler = new DelegatedMessageHandler(
                ValidateImdsV2TokenRequest,
                ValidateRegionRequest,
                ValidateRoleRequest,
                ValidateSecurityCredentialsRequest,
                request => ValidateAccessTokenRequest(request, ImpersonationScope, ValidateSubjectToken),
                ValidateImpersonatedAccessTokenRequest);

            var credential = new AwsExternalAccountCredential(
                new AwsExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject,
                    ImdsV2SessionTokenUrl = FakeImdsv2Url,
                    SecurityCredentialsUrl = FakeSecurityCredentialsUrl,
                    RegionUrl = FakeRegionUrl,
                    Clock = new MockClock(MockUtcNow),
                    ServiceAccountImpersonationUrl = ImpersonationUrl
                });

            var token = await credential.GetAccessTokenWithHeadersForRequestAsync();

            AssertImpersonatedAccessTokenWithHeaders(token);
            messageHandler.AssertAllCallsMade();
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(
                ValidateImdsV2TokenRequest,
                ValidateRegionRequest,
                ValidateRoleRequest,
                ValidateSecurityCredentialsRequest,
                AccessTokenRequest,
                ValidateImdsV2TokenRequest,
                ValidateRegionRequest,
                ValidateRoleRequest,
                ValidateSecurityCredentialsRequest,
                RefreshTokenRequest);
            var clock = new MockClock(MockUtcNow);

            var credential = new AwsExternalAccountCredential(
                new AwsExternalAccountCredential.Initializer(TokenUrl, FakeAudience, FakeSubjectTokenType, FakeVerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = FakeClientId,
                    ClientSecret = FakeClientSecret,
                    Scopes = new string[] { FakeScope },
                    QuotaProject = FakeQuotaProject,
                    ImdsV2SessionTokenUrl = FakeImdsv2Url,
                    SecurityCredentialsUrl = FakeSecurityCredentialsUrl,
                    RegionUrl = FakeRegionUrl,
                    Clock = clock
                });

            Assert.Equal(FakeAccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(FakeRefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        private static Task<HttpResponseMessage> ValidateImdsV2TokenRequest(HttpRequestMessage imdsV2Request)
        {
            Assert.Equal(FakeImdsv2Url, imdsV2Request.RequestUri.ToString());
            Assert.Equal(HttpMethod.Put, imdsV2Request.Method);

            Assert.Contains(imdsV2Request.Headers, header => header.Key == ImdsV2TokenTtlHeaderName && header.Value.Single() == ImdsV2TokenTtlSeconds);

            return BuildStringContentResponse(FakeImdsV2Token);
        }

        private static Task<HttpResponseMessage> ValidateRegionRequest(HttpRequestMessage regionRequest)
        {
            Assert.Equal(FakeRegionUrl, regionRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, regionRequest.Method);

            Assert.Contains(regionRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == FakeImdsV2Token);

            return BuildStringContentResponse(MetadataRegion);
        }

        private static Task<HttpResponseMessage> ValidateRoleRequest(HttpRequestMessage roleRequest)
        {
            Assert.Equal(FakeSecurityCredentialsUrl, roleRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, roleRequest.Method);

            Assert.Contains(roleRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == FakeImdsV2Token);

            return BuildStringContentResponse(FakeSecurityCredentialsRole);
        }

        private static Task<HttpResponseMessage> ValidateSecurityCredentialsRequest(HttpRequestMessage roleRequest)
        {
            Assert.Equal($"{FakeSecurityCredentialsUrl}{FakeSecurityCredentialsRole}", roleRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, roleRequest.Method);

            Assert.Contains(roleRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == FakeImdsV2Token);

            return BuildStringContentResponseFromJson(
                new
                {
                    Code = "Success",
                    AccessKeyId = FakeSecurityCredentialsAccessKeyId,
                    SecretAccessKey = FakeSecurityCredentialsSecretAccessKey,
                    Token = FakeSecurityCredentialsToken
                });
        }

        private static void ValidateSubjectToken(string accessTokenRequestContent)
        {
            int start = accessTokenRequestContent.IndexOf("subject_token=", StringComparison.Ordinal) + 14;
            int end = accessTokenRequestContent.IndexOf("&subject_token_type=", StringComparison.Ordinal);
            string subjectToken = Uri.UnescapeDataString(accessTokenRequestContent.Substring(start, end - start));
            var deserializedSubjectToken = NewtonsoftJsonSerializer.Instance.Deserialize<AwsSignedSubjectToken>(subjectToken);

            Assert.Equal(FakeRegionalizedVerificationUrl, deserializedSubjectToken.Url);
            Assert.Equal("POST", deserializedSubjectToken.HttpMethod);
            Assert.Equal("", deserializedSubjectToken.Body);

            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-goog-cloud-target-resource" && header.Value == FakeAudience);
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-amz-date" && header.Value == "20220929T054756Z");
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "host" && header.Value == FakeRegionalizedVerificationHost);
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-amz-security-token" && header.Value == FakeSecurityCredentialsToken);

            var authorizationHeaderValue = Assert.Single(deserializedSubjectToken.Headers, header => header.Key == "Authorization").Value;
            Assert.Contains("AWS4-HMAC-SHA256", authorizationHeaderValue);
            Assert.Contains("/20220929/", authorizationHeaderValue);
            Assert.Contains($"/{Region}/", authorizationHeaderValue);
            Assert.Contains($"/{ServiceName}/", authorizationHeaderValue);
            Assert.Contains($"/{ServiceName}/", authorizationHeaderValue);
            Assert.Contains($"host;x-amz-date;x-amz-security-token;x-goog-cloud-target-resource", authorizationHeaderValue);
        }

        public class AwsSignedSubjectToken
        {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("method")]
            public string HttpMethod { get; set; }

            [JsonProperty("body")]
            public string Body { get; set; }

            [JsonProperty("headers")]
            public AwsSignedSubjectTokenHeader[] Headers { get; set; }

            public class AwsSignedSubjectTokenHeader
            {
                [JsonProperty("key")]
                public string Key { get; set; }

                [JsonProperty("value")]
                public string Value { get; set; }
            }
        }
    }
}