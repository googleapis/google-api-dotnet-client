﻿/*
Copyright 2015 Google Inc

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
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.JsonWebSignature;
using static Google.Apis.Auth.OAuth2.BearerToken;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.GoogleCredential"/>.</summary>
    public class GoogleCredentialTests
    {
        private const string QuotaProjectHeaderKey = "x-goog-user-project";
        private const string FakeAuthUri = "https://www.googleapis.com/google.some_google_api";
        private const string FakeImpersonatedCredentialFileContents = @"{
""service_account_impersonation_url"": ""https://example.com"",
""type"": ""impersonated_service_account"",
""scopes"": [""SCOPE""],
""source_credentials"": {
""client_id"": ""CLIENT_ID"",
""client_secret"": ""CLIENT_SECRET"",
""refresh_token"": ""REFRESH_TOKEN"",
""type"": ""authorized_user""
}}";
        private const string FakeUserCredentialFileContents = @"{
""client_id"": ""CLIENT_ID"",
""client_secret"": ""CLIENT_SECRET"",
""refresh_token"": ""REFRESH_TOKEN"",
""project_id"": ""PROJECT_ID"",
""quota_project_id"": ""QUOTA_PROJECT"",
""type"": ""authorized_user""}";
        private const string FakeServiceAccountCredentialFileContents = @"{
""private_key_id"": ""PRIVATE_KEY_ID"",
""private_key"": ""-----BEGIN PRIVATE KEY-----
MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
2x4zrzrwSUtmtR37XTTi0sPARTDF8uzmXy8UnE5RcVJzEH5T2Ssz/ylX4Sl/CI4L
no1l8j9GiHJb49LSRjWe4Yx936q0Xj9H0R1HTxvjUPqwAsTwy2fKBTog+q1frqc9
o8s2r6LYivUGDVbhuUzCaMJsf+x3AgMBAAECgYEAi0FTXsu/zRswAUGaViQiHjrL
uU65BSHXNVjV/2fLNEKnGWGqpli68z1IXY+S2nwbUak7rnGsq9/0F6jtsW+hZbLk
KXUOuuExpeC5Kd6ngWX/f2jqmhlUabiQijU9cVk7pMq8EHkRtvlosnMTUAEzempu
QUPwn1PZHhmJkBvZ4lECQQDCErrxl+e3BwUDcS0yVEEmCNSG6xdXs2878b8rzbe7
3Mmi6SuuOLi3PU92J+j+f/MOdtYrk13mEDdYmd5dhrt5AkEAwPvDEsDT/W4y4h5n
gv1awGBA5aLFE1JNWM/Gwn4D1cGpEDHKFREaBtxMDCASpHJuw8r7zUywpKhmBZcf
GS37bwJANdSAKfbafLfjuhqwUJ9yGpykZm/a36aTmerp/bpn1iHdg+RtCzwMcDb/
TWSwibbvsflgWmHbz657y4WSWhq+8QJAWrpCNN/ZCk2zuGDo80lfUBAwkoVat8G6
wWU1oZyS+vzIGef+hLb8kHsjeZPej9eIwZ39kcBbT54oELrCkRjwGwJAQ8V2A7lT
ZUp8AsbVqF6rbLiiUfJMo2btGclQu4DEVyS+ymFA65tXDLUuR9EDqJYdqHNZJ5B8
4Z5p2prkjWTLcA\u003d\u003d
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""CLIENT_ID"",
""project_id"": ""PROJECT_ID"",
""type"": ""service_account""}";

        private const string FakeUserCredentialConfigContents = @"{ ""GoogleCredential"": {
""ClientId"": ""CLIENT_ID"",
""ClientSecret"": ""CLIENT_SECRET"",
""RefreshToken"": ""REFRESH_TOKEN"",
""ProjectId"": ""PROJECT_ID"",
""QuotaProject"": ""QUOTA_PROJECT"",
""Type"": ""authorized_user""}}";
        private const string FakeServiceAccountCredentialConfigContents = @"{ ""GoogleCredential"": {
""PrivateKeyId"": ""PRIVATE_KEY_ID"",
""PrivateKey"": ""-----BEGIN PRIVATE KEY-----
MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
2x4zrzrwSUtmtR37XTTi0sPARTDF8uzmXy8UnE5RcVJzEH5T2Ssz/ylX4Sl/CI4L
no1l8j9GiHJb49LSRjWe4Yx936q0Xj9H0R1HTxvjUPqwAsTwy2fKBTog+q1frqc9
o8s2r6LYivUGDVbhuUzCaMJsf+x3AgMBAAECgYEAi0FTXsu/zRswAUGaViQiHjrL
uU65BSHXNVjV/2fLNEKnGWGqpli68z1IXY+S2nwbUak7rnGsq9/0F6jtsW+hZbLk
KXUOuuExpeC5Kd6ngWX/f2jqmhlUabiQijU9cVk7pMq8EHkRtvlosnMTUAEzempu
QUPwn1PZHhmJkBvZ4lECQQDCErrxl+e3BwUDcS0yVEEmCNSG6xdXs2878b8rzbe7
3Mmi6SuuOLi3PU92J+j+f/MOdtYrk13mEDdYmd5dhrt5AkEAwPvDEsDT/W4y4h5n
gv1awGBA5aLFE1JNWM/Gwn4D1cGpEDHKFREaBtxMDCASpHJuw8r7zUywpKhmBZcf
GS37bwJANdSAKfbafLfjuhqwUJ9yGpykZm/a36aTmerp/bpn1iHdg+RtCzwMcDb/
TWSwibbvsflgWmHbz657y4WSWhq+8QJAWrpCNN/ZCk2zuGDo80lfUBAwkoVat8G6
wWU1oZyS+vzIGef+hLb8kHsjeZPej9eIwZ39kcBbT54oELrCkRjwGwJAQ8V2A7lT
ZUp8AsbVqF6rbLiiUfJMo2btGclQu4DEVyS+ymFA65tXDLUuR9EDqJYdqHNZJ5B8
4Z5p2prkjWTLcA\u003d\u003d
-----END PRIVATE KEY-----"",
""ClientEmail"": ""CLIENT_EMAIL"",
""ClientId"": ""CLIENT_ID"",
""ProjectId"": ""PROJECT_ID"",
""Type"": ""service_account""}}";
        private const string UntypedCredentialConfigContents = @"{ ""GoogleCredential"": {
""ClientId"": ""CLIENT_ID"",
""ClientSecret"": ""CLIENT_SECRET"",
""RefreshToken"": ""REFRESH_TOKEN"",
""ProjectId"": ""PROJECT_ID"",
""QuotaProject"": ""QUOTA_PROJECT""}}";
        private const string IncompleteUserCredentialConfigContents = @"{ ""GoogleCredential"": {
""ClientId"": ""CLIENT_ID"",
""RefreshToken"": ""REFRESH_TOKEN"",
""ProjectId"": ""PROJECT_ID"",
""QuotaProject"": ""QUOTA_PROJECT"",
""Type"": ""authorized_user""}}";
        private const string WrongTypesUserCredentialConfigContents = @"{ ""GoogleCredential"": {
""ClientId"": 1,
""ClientSecret"": 2,
""RefreshToken"": true,
""ProjectId"": false,
""QuotaProject"": ""QUOTA_PROJECT"",
""Type"": ""authorized_user""}}";
        private const string UnusedPropertiesUserCredentialConfigContents = @"{ ""GoogleCredential"": {
""ClientId"": ""CLIENT_ID"",
""ClientSecret"": ""CLIENT_SECRET"",
""RefreshToken"": ""REFRESH_TOKEN"",
""ProjectId"": ""PROJECT_ID"",
""QuotaProject"": ""QUOTA_PROJECT"",
""Type"": ""authorized_user"",
""Unused"": ""unused_value""}}";


        private IConfiguration BuildConfigurationForCredential(string json) =>
            // We parse the string and call ToString after because within the key
            // there's a character that needs escaping. Json.Net seems to handle this
            // by default, whereas System.Text.Json, which is what Microsoft.Extensions.Configuration
            // depends on, does not.
            // Note that this has no direct effect on Google.Apis.Auth, as, at most, this affects
            // the step of writing the service account key to configuration, which is external to
            // this library.
            new ConfigurationBuilder().AddJsonStream(new MemoryStream(Encoding.UTF8.GetBytes(JToken.Parse(json).ToString()))).Build();

        [Fact]
        public void FromProgrammaticExternalAccountCredential()
        {
            var credential = new ProgrammaticExternalAccountCredential(new ProgrammaticExternalAccountCredential.Initializer(
                "STS_TOKEN_URL", "AUDIENCE", "SUBJECT_TOKEN_TYPE", new ProgrammaticExternalAccountCredentialTest.FakeSubjectTokenProvider()));

            var gCredential = GoogleCredential.FromProgrammaticExternalAccountCredential(credential);

            var pCred = Assert.IsType<ProgrammaticExternalAccountCredential>(gCredential.UnderlyingCredential);
            Assert.Same(credential, pCred);
        }

        [Fact]
        public void FromConfig_UserCredential()
        {
            IConfiguration config = BuildConfigurationForCredential(FakeUserCredentialConfigContents);
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            GoogleCredential credential = CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters).ToGoogleCredential();

            var userCred = Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Equal("REFRESH_TOKEN", userCred.Token.RefreshToken);
            var flow = (GoogleAuthorizationCodeFlow)userCred.Flow;
            Assert.Equal("CLIENT_ID", flow.ClientSecrets.ClientId);
            Assert.Equal("CLIENT_SECRET", flow.ClientSecrets.ClientSecret);
            Assert.Equal("PROJECT_ID", flow.ProjectId);
            Assert.Equal("QUOTA_PROJECT", userCred.QuotaProject);
        }

        [Fact]
        public void FromConfig_ServiceAccountCredential()
        {
            IConfiguration config = BuildConfigurationForCredential(FakeServiceAccountCredentialConfigContents);
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            var credential = CredentialFactory.FromJsonParameters<ServiceAccountCredential>(credentialParameters).ToGoogleCredential();

            var serviceCred = Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
            Assert.Equal("CLIENT_EMAIL", serviceCred.Id);
            Assert.Equal("PROJECT_ID", serviceCred.ProjectId);
        }

        [Fact]
        public void FromConfig_Untyped()
        {
            IConfiguration config = BuildConfigurationForCredential(UntypedCredentialConfigContents);
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters));
            Assert.Contains("Unrecognized credential type", ex.Message);
        }

        [Fact]
        public void FromConfig_IncompleteUserCredential()
        {
            IConfiguration config = BuildConfigurationForCredential(IncompleteUserCredentialConfigContents);
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters));
            Assert.Contains("does not represent a valid user credential", ex.Message);
        }

        [Fact]
        public void FromConfig_WrongTypesUserCredential()
        {
            IConfiguration config = BuildConfigurationForCredential(WrongTypesUserCredentialConfigContents);
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();

            // These are parsed as string. Nothing we can do our side.
            Assert.Equal("1", credentialParameters.ClientId);
            Assert.Equal("2", credentialParameters.ClientSecret);
            Assert.Equal("True", credentialParameters.RefreshToken);
            Assert.Equal("False", credentialParameters.ProjectId);

            var credential = CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters).ToGoogleCredential();

            var userCred = Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Equal("True", userCred.Token.RefreshToken);
            var flow = (GoogleAuthorizationCodeFlow)userCred.Flow;
            Assert.Equal("1", flow.ClientSecrets.ClientId);
            Assert.Equal("2", flow.ClientSecrets.ClientSecret);
            Assert.Equal("False", flow.ProjectId);
            Assert.Equal("QUOTA_PROJECT", userCred.QuotaProject);
        }

        [Fact]
        public void FromConfig_UnusedPropertiesUserCredential()
        {
            IConfiguration config = BuildConfigurationForCredential(UnusedPropertiesUserCredentialConfigContents);
            // Properties not in JsonCredentialParameters are ignored.
            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            var credential = CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters).ToGoogleCredential();

            var userCred = Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Equal("REFRESH_TOKEN", userCred.Token.RefreshToken);
            var flow = (GoogleAuthorizationCodeFlow)userCred.Flow;
            Assert.Equal("CLIENT_ID", flow.ClientSecrets.ClientId);
            Assert.Equal("CLIENT_SECRET", flow.ClientSecrets.ClientSecret);
            Assert.Equal("PROJECT_ID", flow.ProjectId);
            Assert.Equal("QUOTA_PROJECT", userCred.QuotaProject);
        }

        [Fact]
        public void FromConfig_NotAJson()
        {
            IConfiguration config = new ConfigurationBuilder().AddInMemoryCollection(new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("GoogleCredential", "NotAJson")
            }).Build();

            JsonCredentialParameters credentialParameters = config.GetSection("GoogleCredential").Get<JsonCredentialParameters>();
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => CredentialFactory.FromJsonParameters<UserCredential>(credentialParameters));
            Assert.Equal("credentialParameters", ex.ParamName);
        }

        [Fact]
        public void FromStream_UserCredential()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeUserCredentialFileContents));
            var credential = CredentialFactory.FromStream<UserCredential>(stream).ToGoogleCredential();
            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            var userCred = (UserCredential)credential.UnderlyingCredential;
            Assert.Equal("REFRESH_TOKEN", userCred.Token.RefreshToken);
            var flow = (GoogleAuthorizationCodeFlow)userCred.Flow;
            Assert.Equal("CLIENT_ID", flow.ClientSecrets.ClientId);
            Assert.Equal("CLIENT_SECRET", flow.ClientSecrets.ClientSecret);
            Assert.Equal("PROJECT_ID", flow.ProjectId);
            Assert.Equal("QUOTA_PROJECT", userCred.QuotaProject);
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, (userCred as IGoogleCredential).GetUniverseDomain());
        }

        [Fact]
        public void CreateWithUniverseDomain_UserCredential_Fails()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeUserCredentialFileContents));
            var credential = CredentialFactory.FromStream<UserCredential>(stream).ToGoogleCredential();

            Assert.Throws<InvalidOperationException>(() => credential.CreateWithUniverseDomain("fake.universe.domain.com"));
        }

        [Fact]
        public void FromStream_ServiceAccountCredential()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeServiceAccountCredentialFileContents));
            var credential = CredentialFactory.FromStream<ServiceAccountCredential>(stream).ToGoogleCredential();
            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
            var serviceCred = (ServiceAccountCredential)credential.UnderlyingCredential;
            Assert.Equal("CLIENT_EMAIL", serviceCred.Id);
            Assert.Equal("PROJECT_ID", serviceCred.ProjectId);
            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
        }

        [Fact]
        public void CreateWithUniverseDomain_ServiceAccountCredential()
        {
            var universeDomain = "fake.universe.domain.com";
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeServiceAccountCredentialFileContents));
            var credential = GoogleCredential.FromServiceAccountCredential(
                ServiceAccountCredential.FromServiceAccountData(stream).WithUseJwtAccessWithScopes(true));

            var newCredential = credential.CreateWithUniverseDomain(universeDomain);

            Assert.NotSame(credential, newCredential);
            Assert.IsType<ServiceAccountCredential>(newCredential.UnderlyingCredential);

            Assert.Equal(GoogleAuthConsts.DefaultUniverseDomain, credential.GetUniverseDomain());
            Assert.Equal(universeDomain, newCredential.GetUniverseDomain());
        }

        [Fact]
        public async Task FromStreamAsync_ServiceAccountCredential()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeServiceAccountCredentialFileContents));
            var credential = (await CredentialFactory.FromStreamAsync<ServiceAccountCredential>(stream, CancellationToken.None)).ToGoogleCredential();
            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
            var serviceCred = (ServiceAccountCredential) credential.UnderlyingCredential;
            Assert.Equal("CLIENT_EMAIL", serviceCred.Id);
            Assert.Equal("PROJECT_ID", serviceCred.ProjectId);
        }

        [Fact]
        public void FromFile_ServiceAccountCredential()
        {
            var tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, FakeServiceAccountCredentialFileContents);
                var credential = CredentialFactory.FromFile<ServiceAccountCredential>(tempFile).ToGoogleCredential();
                Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
                Assert.True(credential.IsCreateScopedRequired);
                var serviceCred = (ServiceAccountCredential)credential.UnderlyingCredential;
                Assert.Equal("CLIENT_EMAIL", serviceCred.Id);
                Assert.Equal("PROJECT_ID", serviceCred.ProjectId);
            }
            finally
            {
                try
                {
                    File.Delete(tempFile);
                }
                catch { }
            }
        }

        [Fact]
        public async Task FromFileAsync_ServiceAccountCredential()
        {
            var tempFile = Path.GetTempFileName();
            try
            {
                File.WriteAllText(tempFile, FakeServiceAccountCredentialFileContents);
                var credential = (await CredentialFactory.FromFileAsync<ServiceAccountCredential>(tempFile, CancellationToken.None)).ToGoogleCredential();
                Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
                Assert.True(credential.IsCreateScopedRequired);
                var serviceCred = (ServiceAccountCredential)credential.UnderlyingCredential;
                Assert.Equal("CLIENT_EMAIL", serviceCred.Id);
                Assert.Equal("PROJECT_ID", serviceCred.ProjectId);
            }
            finally
            {
                try
                {
                    File.Delete(tempFile);
                }
                catch { }
            }
        }

        [Fact]
        public void FromJson_UserCredential()
        {
            var credential = CredentialFactory.FromJson<UserCredential>(FakeUserCredentialFileContents).ToGoogleCredential();
            Assert.False(credential.IsCreateScopedRequired);
        }

        [Fact]
        public void FromJson_ServiceAccountCredential()
        {
            var credential = CredentialFactory.FromJson<ServiceAccountCredential>(FakeServiceAccountCredentialFileContents).ToGoogleCredential();
            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
        }

        [Fact]
        public void FromJson_ShortDValue()
        {
            // This private key hits a rare edge case where the D value of the RSA private key only
            // requires 255 bytes to encode, but we still need to left pad it to 256 so
            // RSACryptoServiceProvider.ImportParameters does not throw CryptographicException with
            // a "Bad Data" message.
            var credential = CredentialFactory.FromJson<ServiceAccountCredential>(@"{
""private_key_id"": ""PRIVATE_KEY_ID"",
""private_key"": ""-----BEGIN PRIVATE KEY-----
MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC5KC4i9y2QMw5S
JrwW1Qgbxpen/PUnumAQfWUY3ZTOsXvr7vmLeDTx5a9VQ4YJFDqEEQEFPLLzSuBN
lItMJAb10AMvwBxcxs/WFAMpxoF0Aiu2U16uqLH3vf5dUJpgg+/lsmHnJk5b8jzr
CqfuEtDv7xq/HXTZtqFd144rW7mWKQyMzzlzBPgbEw5tE9Winjo9OErPrYusZ1WC
FgiuKds0CzOqQEEW6RzA0Bj4B25Q2Y1BuKPh1zd9AkoHyiyEOeOwqvd7IDn3uAuM
OfEkeL3zfs9UVq+DuGJ1bQl0N4L9JNtEdNOzWWYYBMk9pjJqNwCGUmtw9xWn2Tzp
kAnGNKntAgMBAAECggEAAM1nxccEb4eJHFoGnqK1skkeByBVf6KTH/8rHPx41Jx4
SQF0G2Kd+B5isB/myMtJpaDdPESTEfLVHgDyyZWuYgpQuTg/5zcFV4wmp1uw2+vW
fKfH1UHt44DzRTxALwLjWz92pSXJWSSnlu0o5SM3vJJwrztVckwUTu/MMevn1fq9
qqLja559YjKHoL99bB7FAGq6fqYuJv0KEDk0yzOyWX8PqSJhFE6pG3vFQ0pHg/b3
pEyUrXX/aRfgzRq8aSHzNWkDKdN5AY2a12TmouKmMy+4V9j49WXZ5DF9ZPGFrE61
Eb2UaGw8/Kzce6CY/L5pMnslwra1QxOEDLQuwuu8AQKBgQDrfdvMqgHTSX/ab0RM
8JtOXGok5s3+Or0dTfki7fOIM9eDtD6YTYFqGyKdBFovHYLzKkYdSzP3gFrvIy7d
+Pw6rRfBDHAHdsoHcc8djzjZ41fvymbiHcCCe6PdWgD3mfC5Gq/+bZrdW6erWdMX
P2QGR04ysFVNIIotAO3g2gsmLQKBgQDJSCQMx0paSKOV/psZRatf/eTDUNQDYF2N
mbqg4DiIAokt+2EEHJGwtuobckldoN/4f89kTB0OU9SFRmBAPWUDu0NfJDMNhcma
o6nlzcftObBPtAS1oLs4Rg/alcgEVHAwLpeg/QyWVb1sxgFs40EAp0TnwDWi3SSV
HoIw8R+qwQKBgCXgZ3MCwSpnvv22OckaRhCTgqsOyIEkl3hYK0M3/Jyiof5YBl1e
0frsBGQ25/5+A6ry2LYre19KsNWX1hjzzDXv00tEodxBefs6jfKWL7G0BFfYOTYT
TPxvwIqAyHkKtJJBPZ9xp6AE9vHzj6VEl+T+oRA8FmxCWJcmeBxbVcG9AoGAe8st
uNo9RYfVbKQZ2hI6U6CAuQuWSblT8Iny+YzN2ADPRAOOaIv1otzs4RKKQtZ1yY06
DXKukChI1esxuXDJFuFujy5hY9i75KryDE9ivek0IeES4G5Jl1On3oUublNMaKXP
Rgk8W53CEgs5xzGBwhgeTfauRkuCe2A3LEiwdEECgYAO80SVYrprJT6C2KcX5Hgw
M+5ST4oIu9EOOv/hBSmEs1gkASH3XEHU0iV4vg94H61Wq3RmdLZ9P2uKNq7Tjl+a
TOgrHXgWf1cxYf5cB8DfC3NoaYZ4D3Wh9Qjn3cl36CXfSKEnPK49DkrGZz1avAjV
55tKWHy105Btnc5jJT1EXg==
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""CLIENT_ID"",
""type"": ""service_account""}").ToGoogleCredential();
            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
        }

        /// <summary>
        /// Creates service account credential from stream, obtains a JWT token
        /// from the credential and checks the access token is well-formed.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task FromStream_ServiceAccountCredential_GetJwtAccessToken()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeServiceAccountCredentialFileContents));
            var credential = CredentialFactory.FromStream<ServiceAccountCredential>(stream).ToGoogleCredential();

            // Without adding scopes, the credential should be generating JWT scopes.
            string accessToken = await (credential as ITokenAccess).GetAccessTokenForRequestAsync(FakeAuthUri);
            var parts = accessToken.Split(new[] {'.'});
            Assert.Equal(3, parts.Length);

            var header = NewtonsoftJsonSerializer.Instance.Deserialize<JsonWebSignature.Header>(TokenEncodingHelpers.Base64UrlToString(parts[0]));
            Assert.Equal("JWT", header.Type);
            Assert.Equal("RS256", header.Algorithm);

            var payload = NewtonsoftJsonSerializer.Instance.Deserialize<JsonWebSignature.Payload>(TokenEncodingHelpers.Base64UrlToString(parts[1]));

            Assert.Equal("CLIENT_EMAIL", payload.Issuer);
            Assert.Equal("CLIENT_EMAIL", payload.Subject);
            Assert.Equal(FakeAuthUri, payload.Audience);
            Assert.Equal(3600, payload.ExpirationTimeSeconds - payload.IssuedAtTimeSeconds);
        }

        [Fact]
        public async Task FromUserCredential_OidcTokenFails()
        {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(FakeUserCredentialFileContents));
            var credential = CredentialFactory.FromStream<UserCredential>(stream).ToGoogleCredential();
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("audience")));
        }

        [Fact]
        public async Task FromAccessToken_OidcTokenFails()
        {
            var credential = GoogleCredential.FromAccessToken("fake_access_token");
            await Assert.ThrowsAsync<InvalidOperationException>(
                () => credential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("audience")));
        }

        [Fact]
        public async Task FromServiceAccountCredential_FetchesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcTokenResponseSuccessMessageHandler();
            var initializer = new ServiceAccountCredential.Initializer("MyId", "http://will.be.ignored")
            {
                Clock = clock,
                ProjectId = "a_project_id",
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var serviceAccountCredential = new ServiceAccountCredential(initializer.FromPrivateKey(ServiceAccountCredentialTests.PrivateKey));
            var googleCredential = GoogleCredential.FromServiceAccountCredential(serviceAccountCredential);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await googleCredential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
        }

        [Fact]
        public async Task FromComputeCredential_FetchesOidcToken()
        {
            // A little bit after the tokens returned from OidcTokenFakes were issued.
            var clock = new MockClock(new DateTime(2020, 5, 21, 9, 20, 0, 0, DateTimeKind.Utc));
            var messageHandler = new OidcComputeSuccessMessageHandler();
            var initializer = new ComputeCredential.Initializer("http://will.be.ignored", "http://will.be.ignored")
            {
                Clock = clock,
                HttpClientFactory = new MockHttpClientFactory(messageHandler)
            };
            var computeCredential = new ComputeCredential(initializer);
            var googleCredential = GoogleCredential.FromComputeCredential(computeCredential);

            // The fake Oidc server returns valid tokens (expired in the real world for safty)
            // but with a set audience that lets us know if the token was refreshed or not.
            var oidcToken = await googleCredential.GetOidcTokenAsync(OidcTokenOptions.FromTargetAudience("will.be.ignored"));

            var signedToken = SignedToken<Header, Payload>.FromSignedToken(await oidcToken.GetAccessTokenAsync());
            Assert.Equal("https://first_call.test", signedToken.Payload.Audience);
        }

        private class FakeHandler : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                RequestHeaders = request.Headers;
                return Task.FromResult(new HttpResponseMessage());
            }
            public HttpRequestHeaders RequestHeaders { get; set; }
        }

        [Fact]
        public async Task AccessTokenCredential()
        {
            const string fakeAccessToken = "FakeAccessToken";
            // Create an access-token credential, and check the access token is correct.
            ICredential cred = GoogleCredential.FromAccessToken(fakeAccessToken);
            Assert.Equal(fakeAccessToken, await cred.GetAccessTokenForRequestAsync());
            // Check the auth header is added correctly to an HTTP request.
            var httpHandler = new FakeHandler();
            var httpClient = new Http.ConfigurableHttpClient(new Http.ConfigurableMessageHandler(httpHandler));
            cred.Initialize(httpClient);
            await httpClient.GetAsync("http://localhost/TestRequest");
            Assert.Equal("Bearer", httpHandler.RequestHeaders.Authorization.Scheme);
            Assert.Equal(fakeAccessToken, httpHandler.RequestHeaders.Authorization.Parameter);
        }

        public static IEnumerable<object[]> CredentialsForTesting
        {
            get
            {
                var clock = new MockClock(DateTime.UtcNow);
                var httpClientFactory = new MockHttpClientFactory(new FetchesTokenMessageHandler());

                var cInitializer = new ComputeCredential.Initializer
                {
                    Clock = clock,
                    HttpClientFactory = httpClientFactory
                };
                yield return new object[] { GoogleCredential.FromComputeCredential(new ComputeCredential(cInitializer)) };

                var saInitiliazer = new ServiceAccountCredential.Initializer("my.service.account.id")
                {
                    Clock = clock,
                    HttpClientFactory = httpClientFactory
                }.FromPrivateKey(ServiceAccountCredentialTests.PrivateKey);
                yield return new object[] { GoogleCredential.FromServiceAccountCredential(new ServiceAccountCredential(saInitiliazer)) };

                var tokenResponse = new TokenResponse
                {
                    AccessToken = "ACCESS_TOKEN",
                    ExpiresInSeconds = 60 * 10,
                    IssuedUtc = clock.UtcNow,
                    RefreshToken = "REFRESH_TOKEN",
                };
                var flow = new FakeFlow(clock);
                yield return new object[] { new UserCredential(flow, "my.user.id", tokenResponse).ToGoogleCredential() };

                yield return new object[] { GoogleCredential.FromAccessToken("my.access.token") };
            }
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public async Task Intercepts_WithQuotaProject(GoogleCredential credential)
        {
            credential = credential.CreateWithQuotaProject("my-billing-project");

            HttpRequestHeaders headers;
            using (var interceptor = new FakeHandler())
            using (var httpClient = new ConfigurableHttpClient( new ConfigurableMessageHandler(interceptor)))
            {
                ((IConfigurableHttpClientInitializer)credential).Initialize(httpClient);
                await httpClient.GetAsync("http://will.be.ignored");
                headers = interceptor.RequestHeaders;
            }

            AssertContainsQuotaProject(headers, "my-billing-project");
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public async Task AccessToken_WithQuotaProjectHeader(GoogleCredential credential)
        {
            credential = credential.CreateWithQuotaProject("my-billing-project");
            var accessToken = await ((ITokenAccessWithHeaders)credential.UnderlyingCredential).GetAccessTokenWithHeadersForRequestAsync("https://api.googleapis.com/");

            AssertContainsQuotaProject(
                accessToken.Headers.Select(pair => new KeyValuePair<string, IEnumerable<string>>(pair.Key, pair.Value)),
                "my-billing-project");
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public async Task Intercepts_NoQuotaProject(GoogleCredential credential)
        {
            HttpRequestHeaders headers;
            using (var interceptor = new FakeHandler())
            using (var httpClient = new ConfigurableHttpClient( new ConfigurableMessageHandler(interceptor)))
            {
                ((IConfigurableHttpClientInitializer)credential).Initialize(httpClient);
                await httpClient.GetAsync("http://will.be.ignored");
                headers = interceptor.RequestHeaders;
            }

            Assert.DoesNotContain(headers, h => h.Key == QuotaProjectHeaderKey);
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public async Task AccessToken_NoQuotaProjectHeader(GoogleCredential credential)
        {
            var accessToken = await ((ITokenAccessWithHeaders)credential.UnderlyingCredential).GetAccessTokenWithHeadersForRequestAsync("https://api.googleapis.com/");

            Assert.DoesNotContain(accessToken.Headers, h => h.Key == QuotaProjectHeaderKey);
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public void CreateWithQuotaProject(GoogleCredential credential)
        {
            var newCredetial = credential.CreateWithQuotaProject("my-quota-project");

            Assert.Equal("my-quota-project", newCredetial.QuotaProject);
        }

        [Theory]
        [MemberData(nameof(CredentialsForTesting))]
        public void CreateWithQuotaProject_NotSame(GoogleCredential credential)
        {
            var newCredetial = credential.CreateWithQuotaProject("my-quota-project");

            Assert.NotSame(credential, newCredetial);
        }

        private void AssertContainsQuotaProject(IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers, string expectedValue)
        {
            KeyValuePair<string, IEnumerable<string>> headerValues = Assert.Single(headers, h => h.Key == QuotaProjectHeaderKey);
            string quotaProject = Assert.Single(headerValues.Value);
            Assert.Equal(expectedValue, quotaProject);
        }

        [Fact]
        public void Impersonate()
        {
            var sourceCredential = CredentialFactory.FromJson<ServiceAccountCredential>(FakeServiceAccountCredentialFileContents).ToGoogleCredential();

            var credential = sourceCredential.Impersonate(new ImpersonatedCredential.Initializer("principal")
            {
                DelegateAccounts = new string[] { "delegate" },
                Scopes = new string[] { "scope" },
                Lifetime = TimeSpan.FromHours(2)
            });

            var impersonatedCredential = Assert.IsType<ImpersonatedCredential>(credential.UnderlyingCredential);
            Assert.Collection(impersonatedCredential.DelegateAccounts, del => Assert.Equal("delegate", del));
            Assert.Collection(impersonatedCredential.Scopes, scope => Assert.Equal("scope", scope));
            Assert.Equal("principal", impersonatedCredential.TargetPrincipal);
            Assert.Equal(TimeSpan.FromHours(2), impersonatedCredential.Lifetime);
        }

        [Fact]
        public void CreateScoped_Impersonated()
        {
            var sourceCredential = CredentialFactory.FromJson<ServiceAccountCredential>(FakeServiceAccountCredentialFileContents).ToGoogleCredential();
            var unscopedCredential = sourceCredential.Impersonate(new ImpersonatedCredential.Initializer("principal"));

            var scopedCredential = unscopedCredential.CreateScoped("new_scope");

            Assert.NotSame(unscopedCredential, scopedCredential);
            Assert.NotSame(unscopedCredential.UnderlyingCredential, scopedCredential.UnderlyingCredential);
            var impersonatedCredential = Assert.IsType<ImpersonatedCredential>(scopedCredential.UnderlyingCredential);
            Assert.Collection(impersonatedCredential.Scopes, scope => Assert.Equal("new_scope", scope));
        }

        [Fact]
        public void CreateScoped_Impersonated_FromJson()
        {
            var impersonatedCredential = CredentialFactory.FromJson<ImpersonatedCredential>(FakeImpersonatedCredentialFileContents);

            // The scopes passed in through the credential json should be the scopes set on the impersonated credential
            Assert.Equal(["SCOPE"], impersonatedCredential.Scopes);
        }

        [Fact]
        public void CreateScoped_Impersonated_FromJsonScopesOverwritten()
        {
            var manuallySetScopes = new[] { "manuallySetScope" };

            var credentialFromJson = CredentialFactory.FromJson<ImpersonatedCredential>(FakeImpersonatedCredentialFileContents).ToGoogleCredential();
            var manuallyScopedCredential = credentialFromJson.CreateScoped(manuallySetScopes);
            var originalImpersonatedCredential = Assert.IsType<ImpersonatedCredential>(credentialFromJson.UnderlyingCredential);
            var newImpersonatedCredential = Assert.IsType<ImpersonatedCredential>(manuallyScopedCredential.UnderlyingCredential);

            // If scopes are explicitly set in code, these should override the scopes passed through the credential json
            Assert.Equal(manuallySetScopes, newImpersonatedCredential.Scopes);
            // The original credential's scopes should remain unchanged
            Assert.Equal(["SCOPE"], originalImpersonatedCredential.Scopes);
        }

        [Fact]
        public void CreateWithQuotaProject_Impersonated()
        {
            var sourceCredential = CredentialFactory.FromJson<ServiceAccountCredential>(FakeServiceAccountCredentialFileContents).ToGoogleCredential();

            var credential = sourceCredential.Impersonate(new ImpersonatedCredential.Initializer("principal"));
            var credentialWithQuotaProject = credential.CreateWithQuotaProject("new_project");

            Assert.NotSame(credential, credentialWithQuotaProject);
            Assert.NotSame(credential.UnderlyingCredential, credentialWithQuotaProject.UnderlyingCredential);
            Assert.Equal("new_project", credentialWithQuotaProject.QuotaProject);
        }

        [Fact]
        public async Task SignBlobAsync()
        {
            var credential = CredentialFactory.FromJson<ServiceAccountCredential>(FakeServiceAccountCredentialFileContents).ToGoogleCredential();
            var signature = await credential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign"));
            Assert.Equal("VvQqmCec5sESTXmt3ojPodmqZhV30MffzuyCvz6DatyW4uO9IMLWbUmynPYNNnn6w0EIVV0CyrARd56VLxgL+DVdsX726W3dfY13nNJo7i8PyV8R2i8yRLimqqraa1fDb29V2n+FsS0OzBPibDscViQHVlu0PBRApsVsjGG+eB4=", signature);
        }

        [Fact]
        public async Task SignBlobAsync_UnsupportedCredential()
        {
            var googleCredential = GoogleCredential.FromAccessToken("fake_token");
            await Assert.ThrowsAsync<InvalidOperationException>(() => googleCredential.SignBlobAsync(Encoding.ASCII.GetBytes("toSign")));
        }

        [Fact]
        public async Task UniverseDomain_RequestAndCredentialSame()
        {
            string universeDomain = "custom.domain";

            HttpRequestMessage request = new HttpRequestMessage();
            request.SetOption(GoogleAuthConsts.UniverseDomainKey, universeDomain);

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token")
                .CreateWithUniverseDomain(universeDomain);

            await credential.InterceptAsync(request, default);

            Assert.Equal("fake_token", request.Headers.Authorization.Parameter);
        }

        [Fact]
        public async Task UniverseDomain_NoneInRequestDefaultInCredential()
        {
            HttpRequestMessage request = new HttpRequestMessage();

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token");

            await credential.InterceptAsync(request, default);

            Assert.Equal("fake_token", request.Headers.Authorization.Parameter);
        }

        [Fact]
        public async Task UniverseDomain_NoneInRequestCustomInCredential()
        {
            HttpRequestMessage request = new HttpRequestMessage();

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token")
                .CreateWithUniverseDomain("custom.domain");

            await credential.InterceptAsync(request, default);

            // If the request has no universe domain information we don't validate,
            // even if the credential has a custom domain. The request is not defaulted to googleapis.com,
            // defaulting should happen at request origin. Basically, the credential can make a decision
            // on defaults for itself but not for any and all requests.
            Assert.Equal("fake_token", request.Headers.Authorization.Parameter);
        }

        [Fact]
        public async Task UniverseDomain_DefaultInRequestNoneInCredential()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetOption(GoogleAuthConsts.UniverseDomainKey, "googleapis.com");

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token");

            await credential.InterceptAsync(request, default);

            // The credential defaults to googleapis.com.
            Assert.Equal("fake_token", request.Headers.Authorization.Parameter);
        }

        [Fact]
        public async Task UniverseDomain_CustomInRequestNoneInCredential()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetOption(GoogleAuthConsts.UniverseDomainKey, "custom.domain");

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token");

            // The credential defaults to googleapis.com which is not the same as the custom domain
            // specified in the credential.
            await Assert.ThrowsAsync<InvalidOperationException>(() => credential.InterceptAsync(request, default));
            Assert.Null(request.Headers.Authorization?.Parameter);
        }

        [Fact]
        public async Task UniverseDomain_DifferentCustomInRequestAndCredential()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.SetOption(GoogleAuthConsts.UniverseDomainKey, "custom1.domain");

            IHttpExecuteInterceptor credential = GoogleCredential.FromAccessToken("fake_token")
                .CreateWithUniverseDomain("custom2.domain");

            await Assert.ThrowsAsync<InvalidOperationException>(() => credential.InterceptAsync(request, default));
            Assert.Null(request.Headers.Authorization?.Parameter);
        }

        /// <summary>
        /// Fake implementation of <see cref="IAuthorizationCodeFlow"/> which only supports fetching the
        /// clock and the access method.
        /// </summary>
        private class FakeFlow : IAuthorizationCodeFlow
        {
            public IAccessMethod AccessMethod => new AuthorizationHeaderAccessMethod();
            public IClock Clock { get; }

            internal FakeFlow(IClock clock) => Clock = clock;

            public IDataStore DataStore => throw new NotImplementedException();

            public AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri) =>
                throw new NotImplementedException();

            public Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken) =>
                throw new NotImplementedException();

            public void Dispose() => throw new NotImplementedException();

            public Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri, CancellationToken taskCancellationToken) =>
                throw new NotImplementedException();

            public Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken) =>
                throw new NotImplementedException();

            public Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken, CancellationToken taskCancellationToken) =>
                throw new NotImplementedException();

            public Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken) =>
                throw new NotImplementedException();

            public bool ShouldForceTokenRetrieval() => throw new NotImplementedException();
        }
    }
}
