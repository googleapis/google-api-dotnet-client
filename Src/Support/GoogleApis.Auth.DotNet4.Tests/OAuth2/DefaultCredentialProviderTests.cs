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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Util;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2
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
    [TestFixture]
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

        private MockDefaultCredentialProvider credentialProvider;

        [SetUp]
        public void SetUp()
        {
            credentialProvider = new MockDefaultCredentialProvider();
        }

        #region UserCredential

        [Test]
        public async Task GetDefaultCredential_UserCredential_FromEnvironmentVariable()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsInstanceOf(typeof(UserCredential), credential.UnderlyingCredential);
            Assert.IsFalse(credential.IsCreateScopedRequired);
            Assert.AreSame(credential, credential.CreateScoped(new [] { "SomeScope" }));
        }

        [Test]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocation()
        {
            // Setup fake environment variables and credential file contents.
            credentialProvider.SetEnvironmentVariable("APPDATA", AppDataValue);
            credentialProvider.SetFileContents(WellKnownCredentialFilePath, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();
            
            Assert.IsInstanceOf(typeof(UserCredential), credential.UnderlyingCredential);
            Assert.IsFalse(credential.IsCreateScopedRequired);
            Assert.AreSame(credential, credential.CreateScoped(new [] { "SomeScope" }));
        }

        [Test]
        public async Task GetDefaultCredential_UserCredential_FromWellKnownFileLocationUnix()
        {
            // Setup fake environment variables and credential file contents.
            credentialProvider.SetEnvironmentVariable("HOME", HomeValue);
            credentialProvider.SetFileContents(WellKnownCredentialFilePathUnix, DummyUserCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsInstanceOf(typeof(UserCredential), credential.UnderlyingCredential);
            Assert.IsFalse(credential.IsCreateScopedRequired);
        }

        #endregion

        #region ServiceAccountCredential

        [Test]
        public async Task GetDefaultCredential_ServiceAccountCredential_FromEnvironmentVariable()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyServiceAccountCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            Assert.IsInstanceOf(typeof(ServiceAccountCredential), credential.UnderlyingCredential);
            Assert.IsTrue(credential.IsCreateScopedRequired);
        }

        /// <summary>Test that adding scopes to GoogleCredential backed by a ServiceAccountCredential works correctly.</summary>
        [Test]
        public async Task GetDefaultCredential_ServiceAccountCredential_CreateScoped()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyServiceAccountCredentialFileContents);

            var credential = await credentialProvider.GetDefaultCredentialAsync();

            var scopes = new[] { "https://www.googleapis.com/auth/cloud-platform" };
            var scopedCredential = credential.CreateScoped(scopes);
            Assert.AreNotSame(credential, scopedCredential);
            Assert.IsFalse(scopedCredential.IsCreateScopedRequired);
            CollectionAssert.AreEqual(scopes, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);

            scopedCredential = credential.CreateScoped("scope1", "scope2");  // Test the params overload
            CollectionAssert.AreEqual(new[] { "scope1", "scope2" }, ((ServiceAccountCredential)scopedCredential.UnderlyingCredential).Scopes);
        }

        #endregion

        #region Invalid Cases

        /// <summary> No credential files or environment variable specified - like a fresh developer's machine.</summary>
        [Test]
        public async Task GetDefaultCredential_NoCredentialFiles()
        { 
            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsTrue(e.Message.Contains("The Application Default Credentials are not available"));
            }
        }

        /// <summary>Environment variable points to a non existant credential file.</summary>
        [Test]
        public async Task GetDefaultCredential_MissingCredentialFile()
        {
            // Setup fake environment variable.
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, WellKnownCredentialFilePath);
            
            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsTrue(e.Message.Contains("Please check the value of the Environment Variable GOOGLE_APPLICATION_CREDENTIALS"));
            }
        }

        /// <summary>Credential file has invalid content format.</summary>
        [Test]
        public async Task GetDefaultCredential_InvalidCredentialFile()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, "Invalid Credentials File Contents");

            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsTrue(e.Message.Contains("Error reading credential file from location"));
            }
        }

        /// <summary>Credential file contains invalid PKCS8 key.</summary>
        [Test]
        public async Task GetDefaultCredential_BrokenPkcs8Key()
        {
            // Setup fake environment variables and credential file contents.
            var credentialFilepath = "TempFilePath.json";
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, BrokenPkcs8KeyServiceAccountCredentialFileContents);

            try
            {
                var credential = await credentialProvider.GetDefaultCredentialAsync();
                Assert.Fail();
            }
            catch (InvalidOperationException e)
            {
                Assert.IsTrue(e.Message.Contains("Error reading credential file from location"));
            }
        }

        // TODO(jtattermusch): test compute engine credential.

        #endregion
    }
}
