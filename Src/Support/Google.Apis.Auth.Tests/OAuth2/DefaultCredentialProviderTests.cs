/*
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>A mock for the <see cref="Google.Apis.Auth.OAuth2.DefaultCredentialProvider"/>.</summary>
    class MockDefaultCredentialProvider : DefaultCredentialProvider
    {
        Dictionary<string, string> envVars = new Dictionary<string, string>();
        Dictionary<string, string> fileContents = new Dictionary<string, string>();

        protected override string GetEnvironmentVariable(string variableName)
        {
            if (!envVars.ContainsKey(variableName))
                return null;

            return envVars[variableName];
        }

        public void SetEnvironmentVariable(string variableName, string value)
        {
            envVars[variableName] = value;
        }

        protected override Stream GetStream(string filePath)
        {
            if (!fileContents.ContainsKey(filePath))
            {
                throw new System.IO.FileNotFoundException();
            }

            return new MemoryStream(Encoding.UTF8.GetBytes(fileContents[filePath]));
        }

        public void SetFileContents(string filePath, string contents)
        {
            fileContents[filePath] = contents;
        }
    }

    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.DefaultCredentialProvider"/>.</summary>
    public class DefaultCredentialProviderTests
    {
        private static readonly string WellKnownCredentialFilePath = Path.Combine(AppDataValue, "gcloud", "application_default_credentials.json");
        private static readonly string WellKnownCredentialFilePathUnix = Path.Combine(HomeValue, ".config", "gcloud", "application_default_credentials.json");

        private const string AppDataValue = "AppDataEnvVarValue";
        private const string HomeValue = "HomeEnvVarValue";
        private const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";
        private const string DummyUserCredentialFileContents = @"{
""client_id"": ""CLIENT_ID"",
""client_secret"": ""CLIENT_SECRET"",
""refresh_token"": ""REFRESH_TOKEN"",
""type"": ""authorized_user""}";
        private const string DummyServiceAccountCredentialFileContents = @"{
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
""type"": ""service_account""}";
        private const string BrokenPkcs8KeyServiceAccountCredentialFileContents = @"{
""private_key_id"": ""PRIVATE_KEY_ID"",
""private_key"": ""-----BEGIN PRIVATE KEY-----
MIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe
-----END PRIVATE KEY-----"",
""client_email"": ""CLIENT_EMAIL"",
""client_id"": ""CLIENT_ID"",
""type"": ""service_account""}";
        private const string NoCredentialSourceExternalAccountCredentialFileContents = @"{
""type"": ""external_account"",
""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
""subject_token_type"": ""urn:ietf:params:oauth:token-type:jwt"",
""token_url"": ""https://sts.googleapis.com/v1/token""}";
        private const string DummyUrlSourcedExternalAccountCredentialFileContents = @"{
""type"": ""external_account"",
""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
""subject_token_type"": ""urn:ietf:params:oauth:token-type:jwt"",
""token_url"": ""https://sts.googleapis.com/v1/token"",
""credential_source"": {
  ""headers"": {
    ""Metadata"": ""True""
  },
  ""url"": ""http://169.254.169.254/metadata/identity/oauth2/token?api-version=2018-02-01&resource=https://iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""format"": {
    ""type"": ""json"",
    ""subject_token_field_name"": ""access_token""}}}";
        private const string DummyFileSourcedExternalAccountCredentialFileContents = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:oauth:token-type:saml2"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""credential_source"": {
    ""file"": ""/var/run/saml/assertion/token""
  }}";
        private const string DummyAwsExternalAccountCredentialFile = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:aws:token-type:aws4_request"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""credential_source"": {
    ""environment_id"": ""aws1"",
    ""region_url"": ""http://169.254.169.254/latest/meta-data/placement/availability-zone"",
    ""url"": ""http://169.254.169.254/latest/meta-data/iam/security-credentials"",
    ""regional_cred_verification_url"": ""https://sts.{region}.amazonaws.com?Action=GetCallerIdentity&Version=2011-06-15"",
    ""imdsv2_session_token_url"": ""http://169.254.169.254/latest/api/token""
  }}";
        private const string DummyUrlSourcedImpersonatedExternalAccountCredentialFileContents = @"{
""type"": ""external_account"",
""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
""subject_token_type"": ""urn:ietf:params:oauth:token-type:jwt"",
""service_account_impersonation_url"": ""https://iamcredentials.googleapis.com/v1/projects/-/serviceAccounts/$EMAIL:generateAccessToken"",
""token_url"": ""https://sts.googleapis.com/v1/token"",
""credential_source"": {
  ""headers"": {
    ""Metadata"": ""True""
  },
  ""url"": ""http://169.254.169.254/metadata/identity/oauth2/token?api-version=2018-02-01&resource=https://iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""format"": {
    ""type"": ""json"",
    ""subject_token_field_name"": ""access_token""}}}";
        private const string DummyFileSourcedImpersonatedExternalAccountCredentialFileContents = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:oauth:token-type:saml2"",
  ""service_account_impersonation_url"": ""https://iamcredentials.googleapis.com/v1/projects/-/serviceAccounts/$EMAIL:generateAccessToken"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""credential_source"": {
    ""file"": ""/var/run/saml/assertion/token""
  }}";
        private const string DummyAwsImpersonatedExternalAccountCredentialFile = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:aws:token-type:aws4_request"",
  ""service_account_impersonation_url"": ""https://iamcredentials.googleapis.com/v1/projects/-/serviceAccounts/$EMAIL:generateAccessToken"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""credential_source"": {
    ""environment_id"": ""aws1"",
    ""region_url"": ""http://169.254.169.254/latest/meta-data/placement/availability-zone"",
    ""url"": ""http://169.254.169.254/latest/meta-data/iam/security-credentials"",
    ""regional_cred_verification_url"": ""https://sts.{region}.amazonaws.com?Action=GetCallerIdentity&Version=2011-06-15"",
    ""imdsv2_session_token_url"": ""http://169.254.169.254/latest/api/token""
  }}";
        private const string DummyUrlSourcedWorkforceExternalAccountCredentialFileContents = @"{
""type"":""external_account"",
""audience"":""//iam.googleapis.com/locations/global/workforcePools/pool/providers/oidc-google"",
""subject_token_type"":""urn:ietf:params:oauth:token-type:id_token"",
""token_url"":""https://sts.googleapis.com/v1/token"",
""workforce_pool_user_project"": ""user_project"",
""credential_source"": {
  ""headers"": {
    ""Metadata"": ""True""
  },
  ""url"": ""http://169.254.169.254/metadata/identity/oauth2/token?api-version=2018-02-01&resource=https://iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""format"": {
    ""type"": ""json"",
    ""subject_token_field_name"": ""access_token""}}}";
        private const string DummyFileSourcedWorkforceExternalAccountCredentialFileContents = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:oauth:token-type:saml2"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""workforce_pool_user_project"": ""user_project"",
  ""credential_source"": {
    ""file"": ""/var/run/saml/assertion/token""
  }}";
        private const string DummyAwsWorkforceExternalAccountCredentialFileContents = @"{
  ""type"": ""external_account"",
  ""audience"": ""//iam.googleapis.com/projects/$PROJECT_NUMBER/locations/global/workloadIdentityPools/$POOL_ID/providers/$PROVIDER_ID"",
  ""subject_token_type"": ""urn:ietf:params:aws:token-type:aws4_request"",
  ""token_url"": ""https://sts.googleapis.com/v1/token"",
  ""workforce_pool_user_project"": ""user_project"",
  ""credential_source"": {
    ""environment_id"": ""aws1"",
    ""region_url"": ""http://169.254.169.254/latest/meta-data/placement/availability-zone"",
    ""url"": ""http://169.254.169.254/latest/meta-data/iam/security-credentials"",
    ""regional_cred_verification_url"": ""https://sts.{region}.amazonaws.com?Action=GetCallerIdentity&Version=2011-06-15"",
    ""imdsv2_session_token_url"": ""http://169.254.169.254/latest/api/token""
  }}";

        public DefaultCredentialProviderTests()
        {
            credentialProvider = new MockDefaultCredentialProvider();
        }

        private MockDefaultCredentialProvider credentialProvider;

        #region UserCredential

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromEnvironmentVariable()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Same(credential, credential.CreateScoped(new[] { "SomeScope" }));
        }

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocation()
        {
            // Setup fake environment variables and credential file contents.
            credentialProvider.SetEnvironmentVariable("APPDATA", AppDataValue);
            credentialProvider.SetFileContents(WellKnownCredentialFilePath, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Same(credential, credential.CreateScoped(new[] { "SomeScope" }));
        }

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocationUnix()
        {
            // Setup fake environment variables and credential file contents.
            credentialProvider.SetEnvironmentVariable("HOME", HomeValue);
            credentialProvider.SetFileContents(WellKnownCredentialFilePathUnix, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
        }

        #endregion

        #region ServiceAccountCredential

        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_FromEnvironmentVariable()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyServiceAccountCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
        }

        /// <summary>Test that adding scopes to GoogleCredential backed by a ServiceAccountCredential works correctly.</summary>
        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_CreateScoped()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyServiceAccountCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var scopes = new[] { "https://www.googleapis.com/auth/cloud-platform" };
            var scopedCredential = credential.CreateScoped(scopes);
            Assert.NotSame(credential, scopedCredential);
            Assert.False(scopedCredential.IsCreateScopedRequired);
            Assert.Equal(scopes, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);

            scopedCredential = credential.CreateScoped("scope1", "scope2");  // Test the params overload
            Assert.Equal(new[] { "scope1", "scope2" }, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);
        }

        #endregion

        #region ExternalAccountCredential

        [Fact]
        public async Task GetDefaultCredential_ExternalAccountCredential_NoCredentialSource()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, NoCredentialSourceExternalAccountCredentialFileContents);

            await Assert.ThrowsAsync<InvalidOperationException>(() => credentialProvider.GetDefaultCredentialAsync());
        }

        public static TheoryData<string, Type> ExternalAccountCredentialTestData => new TheoryData<string, Type>
        {
            { DummyUrlSourcedExternalAccountCredentialFileContents, typeof(UrlSourcedExternalAccountCredential) },
            { DummyFileSourcedExternalAccountCredentialFileContents, typeof (FileSourcedExternalAccountCredential) },
            { DummyAwsExternalAccountCredentialFile, typeof(AwsExternalAccountCredential) },
        };

        [Theory]
        [MemberData(nameof(ExternalAccountCredentialTestData))]
        public async Task GetDefaultCredential_ExternalAccountCredential(string credentialFileContent, Type expectedCredentialType)
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, credentialFileContent);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);
        }

        public static TheoryData<string, Type> ExternalImpersonatedAccountCredentialTestData => new TheoryData<string, Type>
        {
            { DummyUrlSourcedImpersonatedExternalAccountCredentialFileContents, typeof(UrlSourcedExternalAccountCredential) },
            { DummyFileSourcedImpersonatedExternalAccountCredentialFileContents, typeof (FileSourcedExternalAccountCredential) },
            { DummyAwsImpersonatedExternalAccountCredentialFile, typeof (AwsExternalAccountCredential) },
        };

        [Theory]
        [MemberData(nameof(ExternalImpersonatedAccountCredentialTestData))]
        public async Task GetDefaultCredential_UrlSourcedExternalAccountCredential_Impersonated(string credentialFileContent, Type expectedCredentialType)
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, credentialFileContent);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);

            var impersonatedExternalCredential = (ExternalAccountCredential)credential.UnderlyingCredential;
            Assert.IsType<ImpersonatedCredential>(impersonatedExternalCredential.ImplicitlyImpersonated.Value);
        }

        public static TheoryData<string, Type> ExternalWorkforceAccountCredentialTestData => new TheoryData<string, Type>
        {
            { DummyUrlSourcedWorkforceExternalAccountCredentialFileContents, typeof(UrlSourcedExternalAccountCredential) },
            { DummyFileSourcedWorkforceExternalAccountCredentialFileContents, typeof (FileSourcedExternalAccountCredential) },
            { DummyAwsWorkforceExternalAccountCredentialFileContents, typeof(AwsExternalAccountCredential) } ,
        };

        [Theory]
        [MemberData(nameof(ExternalWorkforceAccountCredentialTestData))]
        public async Task GetDefaultCredential_UrlSourcedExternalAccountCredential_WorkforceIdentity(string credentialFileContent, Type expectedCredentialType)
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, credentialFileContent);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);

            var workforceCredential = (ExternalAccountCredential)credential.UnderlyingCredential;
            Assert.Equal("user_project", workforceCredential.WorkforcePoolUserProject);
        }

        #endregion

        #region Invalid Cases

        /// <summary> No credential files or environment variable specified - like a fresh developer's machine.</summary>
        [Fact]
        public async Task GetDefaultCredential_NoCredentialFiles()
        {
            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                // When running on GCE expect to get a ComputeCredential
                if (!(credential.UnderlyingCredential is ComputeCredential))
                {
                    // If not running on GCE getting to this point is a fail
                    Assert.True(false, "Unexpected compute credential");
                }
            }
            catch (InvalidOperationException e)
            {
                Assert.Contains("The Application Default Credentials are not available", e.Message);
            }
        }

        /// <summary>Environment variable points to a non existant credential file.</summary>
        [Fact]
        public async Task GetDefaultCredential_MissingCredentialFile()
        {
            // Setup fake environment variable.
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, WellKnownCredentialFilePath);

            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.True(false, "Exception expected");
            }
            catch (InvalidOperationException e)
            {
                Assert.Contains("Please check the value of the Environment Variable GOOGLE_APPLICATION_CREDENTIALS", e.Message);
            }
        }

        /// <summary>Credential file has invalid content format.</summary>
        [Fact]
        public async Task GetDefaultCredential_InvalidCredentialFile()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, "Invalid Credentials File Contents");

            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.True(false, "Exception expected");
            }
            catch (InvalidOperationException e)
            {
                Assert.Contains("Error reading credential file from location", e.Message);
            }
        }

        /// <summary>Credential file contains invalid PKCS8 key.</summary>
        [Fact]
        public async Task GetDefaultCredential_BrokenPkcs8Key()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, BrokenPkcs8KeyServiceAccountCredentialFileContents);

            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.True(false, "Exception expected");
            }
            catch (InvalidOperationException e)
            {
                Assert.Contains("Error reading credential file from location", e.Message);
            }
        }

        // TODO(jtattermusch): test compute engine credential.

        #endregion
    }
}