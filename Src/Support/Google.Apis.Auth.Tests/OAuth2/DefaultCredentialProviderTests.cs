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
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    /// <summary>A mock for the <see cref="DefaultCredentialProvider"/>.</summary>
    class MockDefaultCredentialProvider : DefaultCredentialProvider
    {
        private static readonly Assembly CurrentAssembly = typeof(MockDefaultCredentialProvider).Assembly;

        private readonly Dictionary<string, string> envVars = new Dictionary<string, string>();
        // Used to map the well known credential location to a file name of the dummy credential to return.
        private readonly Dictionary<string, string> pathToFileName = new Dictionary<string, string>();

        protected override string GetEnvironmentVariable(string variableName) => 
            envVars.TryGetValue(variableName, out string value) ? value : null;

        public void SetEnvironmentVariable(string variableName, string value) => envVars[variableName] = value;

        protected override Stream GetStream(string filePath)
        {
            var resourceName = pathToFileName.TryGetValue(filePath, out var mappedFileName) ? mappedFileName : filePath;
            resourceName = $"Google.Apis.Auth.Tests.OAuth2.FakeCredentialFiles.{resourceName}";

            return CurrentAssembly.GetManifestResourceStream(resourceName) ?? throw new FileNotFoundException();
        }

        public void MapPathToFileName(string path, string fileName) => pathToFileName[path] = fileName;
    }

    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.DefaultCredentialProvider"/>.</summary>
    public class DefaultCredentialProviderTests
    {
        private static readonly string WellKnownCredentialFilePath = Path.Combine(AppDataValue, "gcloud", "application_default_credentials.json");
        private static readonly string WellKnownCredentialFilePathUnix = Path.Combine(HomeValue, ".config", "gcloud", "application_default_credentials.json");

        private const string AppDataValue = "AppDataEnvVarValue";
        private const string HomeValue = "HomeEnvVarValue";
        private const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        private const string InvalidCredentialFileName = "invalid_credential.json";
        private const string UserCredentialFileName = "user_credential.json";
        internal const string ServiceAccountCredentialMinimalFileName = "service_account_credential_minimal.json";
        private const string ServiceAccountCredentialFullFileName = "service_account_credential_full.json";
        private const string BrokenServiceAccountCredentialFileName = "broken_service_account_credential.json";
        private const string NoCredentialSourceExternalAccountCredentialFileName = "no_credential_source_external_account_credential.json";
        private const string UrlSourcedExternalAccountCredentialFileName = "url_sourced_external_account_credential.json";
        private const string FileSourcedExternalAccountCredentialFileName = "file_sourced_external_account_credential.json";
        private const string AwsExternalAccountCredentialFileName = "aws_external_account_credential.json";
        private const string UrlSourcedImpersonatedExternalAccountCredentialFileName = "url_sourced_impersonated_external_account_credential.json";
        private const string FileSourcedImpersonatedExternalAccountCredentialFileName = "file_sourced_impersonated_external_account_credential.json";
        private const string AwsImpersonatedExternalAccountCredentialFileName = "aws_impersonated_external_account_credential.json";
        private const string UrlSourcedWorkforceExternalAccountCredentialFileName = "url_sourced_workforce_external_account_credential.json";
        private const string FileSourcedWorkforceExternalAccountCredentialFileName = "file_sourced_workforce_external_account_credential.json";
        private const string AwsWorkforceExternalAccountCredentialFileName = "aws_workforce_external_account_credential.json";
        private const string ImpersonatedServiceAccountCredentialFileName = "impersonated_service_account_credential.json";
        private const string RecursiveImpersonatedServiceAccountCredentialName = "recursive_impersonated_service_account_credential.json";

        public DefaultCredentialProviderTests()
        {
            credentialProvider = new MockDefaultCredentialProvider();
        }

        private readonly MockDefaultCredentialProvider credentialProvider;

        #region UserCredential

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromEnvironmentVariable()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, UserCredentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Same(credential, credential.CreateScoped(new[] { "SomeScope" }));
        }

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocation()
        {
            credentialProvider.SetEnvironmentVariable("APPDATA", AppDataValue);
            credentialProvider.MapPathToFileName(WellKnownCredentialFilePath, UserCredentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
            Assert.Same(credential, credential.CreateScoped(new[] { "SomeScope" }));
        }

        [Fact]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocationUnix()
        {
            credentialProvider.SetEnvironmentVariable("HOME", HomeValue);
            credentialProvider.MapPathToFileName(WellKnownCredentialFilePathUnix, UserCredentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<UserCredential>(credential.UnderlyingCredential);
            Assert.False(credential.IsCreateScopedRequired);
        }

        #endregion

        #region ServiceAccountCredential

        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_FromEnvironmentVariable()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, ServiceAccountCredentialMinimalFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.True(credential.IsCreateScopedRequired);
        }

        /// <summary>Test that adding scopes to GoogleCredential backed by a ServiceAccountCredential works correctly.</summary>
        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_CreateScoped()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, ServiceAccountCredentialMinimalFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var scopes = new[] { "https://www.googleapis.com/auth/cloud-platform" };
            var scopedCredential = credential.CreateScoped(scopes);
            Assert.NotSame(credential, scopedCredential);
            Assert.False(scopedCredential.IsCreateScopedRequired);
            Assert.Equal(scopes, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);

            scopedCredential = credential.CreateScoped("scope1", "scope2");  // Test the params overload
            Assert.Equal(new[] { "scope1", "scope2" }, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);
        }

        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_Minimal()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, ServiceAccountCredentialMinimalFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var sa = Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.NotNull(sa.Key);
            Assert.Equal("PRIVATE_KEY_ID", sa.KeyId);
            Assert.Equal("CLIENT_EMAIL", sa.Id);
            Assert.Equal(GoogleAuthConsts.OidcTokenUrl, sa.TokenServerUrl);
            Assert.Null(sa.ProjectId);
            Assert.Null(sa.QuotaProject);
        }

        [Fact]
        public async Task GetDefaultCredential_ServiceAccountCredential_Full()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, ServiceAccountCredentialFullFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var sa = Assert.IsType<ServiceAccountCredential>(credential.UnderlyingCredential);
            Assert.NotNull(sa.Key);
            Assert.Equal("PRIVATE_KEY_ID", sa.KeyId);
            Assert.Equal("CLIENT_EMAIL", sa.Id);
            Assert.Equal("TOKEN_URI", sa.TokenServerUrl);
            Assert.Equal("PROJECT_ID", sa.ProjectId);
            Assert.Equal("QUOTA_PROJECT_ID", sa.QuotaProject);
        }

        #endregion

        #region ExternalAccountCredential

        [Fact]
        public async Task GetDefaultCredential_ExternalAccountCredential_NoCredentialSource()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, NoCredentialSourceExternalAccountCredentialFileName);

            await Assert.ThrowsAsync<InvalidOperationException>(() => credentialProvider.GetDefaultCredentialAsync());
        }

        public static TheoryData<string, Type> ExternalAccountCredentialTestData => new TheoryData<string, Type>
        {
            { UrlSourcedExternalAccountCredentialFileName, typeof(UrlSourcedExternalAccountCredential) },
            { FileSourcedExternalAccountCredentialFileName, typeof (FileSourcedExternalAccountCredential) },
            { AwsExternalAccountCredentialFileName, typeof(AwsExternalAccountCredential) },
        };

        [Theory]
        [MemberData(nameof(ExternalAccountCredentialTestData))]
        public async Task GetDefaultCredential_ExternalAccountCredential(string credentialFileName, Type expectedCredentialType)
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);
        }

        public static TheoryData<string, Type> ExternalImpersonatedAccountCredentialTestData => new TheoryData<string, Type>
        {
            { UrlSourcedImpersonatedExternalAccountCredentialFileName, typeof(UrlSourcedExternalAccountCredential) },
            { FileSourcedImpersonatedExternalAccountCredentialFileName, typeof (FileSourcedExternalAccountCredential) },
            { AwsImpersonatedExternalAccountCredentialFileName, typeof (AwsExternalAccountCredential) },
        };

        [Theory]
        [MemberData(nameof(ExternalImpersonatedAccountCredentialTestData))]
        public async Task GetDefaultCredential_UrlSourcedExternalAccountCredential_Impersonated(string credentialFileName, Type expectedCredentialType)
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);

            var impersonatedExternalCredential = (ExternalAccountCredential)credential.UnderlyingCredential;
            Assert.IsType<ImpersonatedCredential>(impersonatedExternalCredential.ImplicitlyImpersonated.Value);
        }

        public static TheoryData<string, Type> ExternalWorkforceAccountCredentialTestData => new TheoryData<string, Type>
        {
            { UrlSourcedWorkforceExternalAccountCredentialFileName, typeof(UrlSourcedExternalAccountCredential) },
            { FileSourcedWorkforceExternalAccountCredentialFileName, typeof (FileSourcedExternalAccountCredential) },
            { AwsWorkforceExternalAccountCredentialFileName, typeof(AwsExternalAccountCredential) } ,
        };

        [Theory]
        [MemberData(nameof(ExternalWorkforceAccountCredentialTestData))]
        public async Task GetDefaultCredential_UrlSourcedExternalAccountCredential_WorkforceIdentity(string credentialFileName, Type expectedCredentialType)
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsType(expectedCredentialType, credential.UnderlyingCredential);

            var workforceCredential = (ExternalAccountCredential)credential.UnderlyingCredential;
            Assert.Equal("user_project", workforceCredential.WorkforcePoolUserProject);
        }

        #endregion

        #region ImpersonatedCredential

        [Fact]
        public async Task GetDefaultCredential_ImpersonatedCredential_FromEnvironmentVariable()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, ImpersonatedServiceAccountCredentialFileName);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var impersonatedCredential = Assert.IsType<ImpersonatedCredential>(credential.UnderlyingCredential);
            Assert.Equal("service-account-email", impersonatedCredential.TargetPrincipal);
            Assert.False(impersonatedCredential.HasCustomTokenUrl);
            Assert.Collection(impersonatedCredential.DelegateAccounts,
                account => Assert.Equal("delegate-email-1", account),
                account => Assert.Equal("delegate-email-2", account));

            var userCredential = Assert.IsType<UserCredential>(impersonatedCredential.SourceCredential.UnderlyingCredential);
            Assert.Equal("REFRESH_TOKEN", userCredential.Token.RefreshToken);
        }

        [Fact]
        public async Task GetDefaultCredential_RecursiveImpersonatedCredential_FromEnvironmentVariable()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, RecursiveImpersonatedServiceAccountCredentialName);

            await Assert.ThrowsAsync<InvalidOperationException>(() => credentialProvider.GetDefaultCredentialAsync());
        }

        #endregion

        #region Invalid Cases

        /// <summary> No credential files or environment variable specified - running on GCP.</summary>
        [SkippableFact]
        public async Task GetDefaultCredential_NoCredentialFiles_OnCompute()
        {
            Skip.IfNot(await ComputeCredential.IsRunningOnComputeEngine(), "Not running on Compute");

            var credential = await credentialProvider.GetDefaultCredentialAsync();
            Assert.IsType<ComputeCredential>(credential.UnderlyingCredential);
        }

        /// <summary> No credential files or environment variable specified - not running on GCP.</summary>
        [Fact]
        public async Task GetDefaultCredential_NoCredentialFiles_NotOnCompute()
        {
            Skip.If(await ComputeCredential.IsRunningOnComputeEngine(), "Running on Compute");
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(()=> credentialProvider.GetDefaultCredentialAsync());
            Assert.Contains("Your default credentials were not found.", exception.Message);
        }

        /// <summary>Environment variable points to a non existant credential file.</summary>
        [Fact]
        public async Task GetDefaultCredential_MissingCredentialFile()
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, @"non/existent/path/credential.json");
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(credentialProvider.GetDefaultCredentialAsync);
            Assert.Contains("Please check the value of the Environment Variable GOOGLE_APPLICATION_CREDENTIALS", exception.Message);
        }

        /// <summary>Credential file has invalid content format.</summary>
        [Theory]
        [InlineData(InvalidCredentialFileName)]
        [InlineData(BrokenServiceAccountCredentialFileName)]
        public async Task GetDefaultCredential_InvalidCredentialFile(string brokenCredentialFileName)
        {
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, brokenCredentialFileName);
            var exception = await Assert.ThrowsAsync<InvalidOperationException>(credentialProvider.GetDefaultCredentialAsync);
            Assert.Contains("Error reading credential file from location", exception.Message);
        }

        #endregion
    }
}