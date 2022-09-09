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
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public abstract class ExternalAccountCredentialTestsBase
    {
        protected const string SubjectTokenText = "dummy_subject_token";
        protected const string SubjectTokenJsonField = "subject_token_field";
        protected static readonly string SubjectTokenJson = $@"{{""{SubjectTokenJsonField}"": ""{SubjectTokenText}""}}";

        protected const string TokenUrl = "https://dummy.token.url/";
        protected const string GrantTypeClaim = "grant_type=urn:ietf:params:oauth:grant-type:token-exchange";
        protected const string RequestedTokenTypeClaim = "requested_token_type=urn:ietf:params:oauth:token-type:access_token";
        protected const string Audience = "dummy_audience";
        protected const string SubjectTokenType = "dummy_token_type";
        protected const string Scope = "dummy_scope";
        protected const string ImpersonationScope = "https://www.googleapis.com/auth/iam";
        protected const string ClientId = "dummy_client_ID";
        protected const string ClientSecret = "dummy_client_secret";
        protected const string WorkforcePoolUserProject = "dummy_workforce_project";
        protected const string ImpersonationUrl = "https://dummy.impersonation.url/";

        protected const string AccessToken = "dummy_access_token";
        protected const string RefreshedAccessToken = "dummy_refreshed_access_token";
        protected const string ImpersonatedAccessToken = "dummy_impersonated_access_token";
        protected const string QuotaProject = "dummy_project_id";
        protected const string QuotaProjectHeaderName = "x-goog-user-project";

        protected static async Task<HttpResponseMessage> ValidateAccessTokenRequest(HttpRequestMessage accessTokenRequest, string scope, bool isWorkforce = false)
        {
            Assert.Equal(TokenUrl, accessTokenRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Post, accessTokenRequest.Method);

            string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

            if (isWorkforce)
            {
                Assert.Null(accessTokenRequest.Headers.Authorization);
                Assert.Contains($"options={{\"userProject\":\"{WorkforcePoolUserProject}\"}}", contentText);
            }
            else
            {
                Assert.Equal("Basic", accessTokenRequest.Headers.Authorization.Scheme);
                Assert.Equal(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")), accessTokenRequest.Headers.Authorization.Parameter);
                Assert.DoesNotContain("options=", contentText);
            }

            Assert.Contains(GrantTypeClaim, contentText);
            Assert.Contains(RequestedTokenTypeClaim, contentText);
            Assert.Contains($"audience={Audience}", contentText);
            Assert.Contains($"subject_token_type={SubjectTokenType}", contentText);
            Assert.Contains($"subject_token={SubjectTokenText}", contentText);
            Assert.Contains($"scope={scope}", contentText);

            return await BuildAccessTokenResponse(AccessToken);
        }

        protected static async Task<HttpResponseMessage> ValidateImpersonatedAccessTokenRequest(HttpRequestMessage accessTokenRequest)
        {
            Assert.Equal(ImpersonationUrl, accessTokenRequest.RequestUri.ToString());
            Assert.Equal(HttpMethod.Post, accessTokenRequest.Method);

            Assert.Contains(accessTokenRequest.Headers, header => header.Key == QuotaProjectHeaderName && header.Value.Single() == QuotaProject);

            Assert.Equal("Bearer", accessTokenRequest.Headers.Authorization.Scheme);
            Assert.Equal(AccessToken, accessTokenRequest.Headers.Authorization.Parameter);

            string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

            Assert.Contains(Scope, contentText);

            return await BuildAccessTokenResponse(new
            {
                accessToken = ImpersonatedAccessToken,
                expireTime = "2020-05-13T16:00:00.045123456Z"
            });
        }

        protected static async Task<HttpResponseMessage> ValidateAccessTokenFromJsonSubjectTokenRequest(HttpRequestMessage accessTokenRequest)
        {
            string contentText = WebUtility.UrlDecode(await accessTokenRequest.Content.ReadAsStringAsync());

            // Even if the subject token was returned as a JSON, the access token request should receive the token value only.
            Assert.Contains($"subject_token={SubjectTokenText}", contentText);

            return await BuildAccessTokenResponse(AccessToken);
        }

        protected static Task<HttpResponseMessage> AccessTokenRequest(HttpRequestMessage accessTokenRequest) =>
            BuildAccessTokenResponse(AccessToken);

        protected static Task<HttpResponseMessage> RefreshTokenRequest(HttpRequestMessage accessTokenRequest) =>
            BuildAccessTokenResponse(RefreshedAccessToken);

        protected static Task<HttpResponseMessage> BuildAccessTokenResponse(string accessToken) =>
            BuildAccessTokenResponse(new TokenResponse
            {
                AccessToken = accessToken,
                ExpiresInSeconds = 24 * 60 * 60
            });

        protected static Task<HttpResponseMessage> BuildAccessTokenResponse(object accessToken)
        {
            string content = NewtonsoftJsonSerializer.Instance.Serialize(accessToken);
            return Task.FromResult(new HttpResponseMessage
            {
                Content = new StringContent(content, Encoding.UTF8)
            });
        }

        protected static void AssertAccessTokenWithHeaders(AccessTokenWithHeaders token)
        {
            Assert.Equal(AccessToken, token.AccessToken);
            var header = Assert.Single(token.Headers);
            Assert.Equal(QuotaProjectHeaderName, header.Key);
            var headerValue = Assert.Single(header.Value);
            Assert.Equal(QuotaProject, headerValue);
        }

        protected static void AssertImpersonatedAccessTokenWithHeaders(AccessTokenWithHeaders token)
        {
            Assert.Equal(ImpersonatedAccessToken, token.AccessToken);
            var header = Assert.Single(token.Headers);
            Assert.Equal(QuotaProjectHeaderName, header.Key);
            var headerValue = Assert.Single(header.Value);
            Assert.Equal(QuotaProject, headerValue);
        }
    }
}
