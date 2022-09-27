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
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class AwsExternalAccountCredentialsTests : ExternalAccountCredentialTestsBase
    {
        private const string Imdsv2Url = "http://dummy.imdsv2.url/";
        private const string ImdsV2TokenTtlHeaderName = "X-aws-ec2-metadata-token-ttl-seconds";
        private const string ImdsV2TokenTtlSeconds = "3600";

        private const string ImdsV2Token = "dummy_imdsv2_token";
        private const string ImdsV2TokenHeaderName = "X-aws-ec2-metadata-token";

        private const string RegionUrl = "http://dummy.region.url/";
        private const string MetadateRegion = "us-central-a1";
        private const string Region = "us-central-a";

        private const string SecurityCredentialsUrl = "http://dummy.security.credentials.url/";
        private const string SecurityCredentialsRole = "dummy_role";

        private const string SecurityCredentialsAccessKeyId = "dummy_credentials_key_id";
        private const string SecurityCredentialsSecretAccessKey = "dummy_credentials_secret";
        private const string SecurityCredentialsToken = "dummy_credentials_token";

        private const string VerificationUrl = "http://iam.{region}.dummyaws.com/?Action=GetCallerIdentity&Version=2011-06-15";
        private const string RegionalizedVerificationUrl = "http://iam.us-central-a.dummyaws.com/?Action=GetCallerIdentity&Version=2011-06-15";
        private const string RegionalizedVerificationHost = "iam.us-central-a.dummyaws.com";
        private const string ServiceName = "iam";

        private static readonly DateTime MockUtcNow = new DateTime(2022, 9, 29, 5, 47, 56, DateTimeKind.Utc);

        [Fact]
        public async Task FetchesAccessToken()
        {
            var messageHandler = new DelegatedMessageHandler(
                ValidateImdsV2TokenRequest,
                ValidateRegionRequest,
                ValidateRoleRequest,
                ValidateSecurityCredentialsRequest,
                request => ValidateAccessTokenRequest(request, Scope, ValidateSubjectToken));

            var credential = new AwsExternalAccountCredential(
                new AwsExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, VerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject,
                    ImdsV2SessionTokenUrl = Imdsv2Url,
                    SecurityCredentialsUrl = SecurityCredentialsUrl,
                    RegionUrl = RegionUrl,
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
                new AwsExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, VerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject,
                    ImdsV2SessionTokenUrl = Imdsv2Url,
                    SecurityCredentialsUrl = SecurityCredentialsUrl,
                    RegionUrl = RegionUrl,
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
                new AwsExternalAccountCredential.Initializer(TokenUrl, Audience, SubjectTokenType, VerificationUrl)
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler),
                    ClientId = ClientId,
                    ClientSecret = ClientSecret,
                    Scopes = new string[] { Scope },
                    QuotaProject = QuotaProject,
                    ImdsV2SessionTokenUrl = Imdsv2Url,
                    SecurityCredentialsUrl = SecurityCredentialsUrl,
                    RegionUrl = RegionUrl,
                    Clock = clock
                });

            Assert.Equal(AccessToken, await credential.GetAccessTokenForRequestAsync());

            clock.UtcNow = clock.UtcNow.AddDays(2);

            Assert.Equal(RefreshedAccessToken, await credential.GetAccessTokenForRequestAsync());

            messageHandler.AssertAllCallsMade();
        }

        private static Task<HttpResponseMessage> ValidateImdsV2TokenRequest(HttpRequestMessage imdsV2Request)
        {
            Assert.Equal(Imdsv2Url, imdsV2Request.RequestUri.ToString());
            Assert.Equal(HttpMethod.Put, imdsV2Request.Method);

            Assert.Contains(imdsV2Request.Headers, header => header.Key == ImdsV2TokenTtlHeaderName && header.Value.Single() == ImdsV2TokenTtlSeconds);

            return BuildStringContentResponse(ImdsV2Token);
        }

        private static Task<HttpResponseMessage> ValidateRegionRequest(HttpRequestMessage regionRequest)
        {
            Assert.Equal(RegionUrl, regionRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, regionRequest.Method);

            Assert.Contains(regionRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == ImdsV2Token);

            return BuildStringContentResponse(MetadateRegion);
        }

        private static Task<HttpResponseMessage> ValidateRoleRequest(HttpRequestMessage roleRequest)
        {
            Assert.Equal(SecurityCredentialsUrl, roleRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, roleRequest.Method);

            Assert.Contains(roleRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == ImdsV2Token);

            return BuildStringContentResponse(SecurityCredentialsRole);
        }

        private static Task<HttpResponseMessage> ValidateSecurityCredentialsRequest(HttpRequestMessage roleRequest)
        {
            Assert.Equal($"{SecurityCredentialsUrl}{SecurityCredentialsRole}", roleRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Get, roleRequest.Method);

            Assert.Contains(roleRequest.Headers, header => header.Key == ImdsV2TokenHeaderName && header.Value.Single() == ImdsV2Token);

            return BuildStringContentResponseFromJson(
                new
                {
                    Code = "Success",
                    AccessKeyId = SecurityCredentialsAccessKeyId,
                    SecretAccessKey = SecurityCredentialsSecretAccessKey,
                    Token = SecurityCredentialsToken
                });
        }

        private static void ValidateSubjectToken(string accessTokenRequestContent)
        {
            int start = accessTokenRequestContent.IndexOf("subject_token=") + 14;
            int end = accessTokenRequestContent.IndexOf("&subject_token_type=");
            string subjectToken = Uri.UnescapeDataString(accessTokenRequestContent.Substring(start, end - start));
            var deserializedSubjectToken = NewtonsoftJsonSerializer.Instance.Deserialize<AwsSignedSubjectToken>(subjectToken);

            Assert.Equal(RegionalizedVerificationUrl, deserializedSubjectToken.Url);
            Assert.Equal("POST", deserializedSubjectToken.HttpMethod);
            Assert.Equal("", deserializedSubjectToken.Body);

            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-goog-cloud-target-resource" && header.Value == Audience);
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-amz-date" && header.Value == "20220929T054756Z");
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "host" && header.Value == RegionalizedVerificationHost);
            Assert.Contains(deserializedSubjectToken.Headers, header => header.Key == "x-amz-security-token" && header.Value == SecurityCredentialsToken);

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