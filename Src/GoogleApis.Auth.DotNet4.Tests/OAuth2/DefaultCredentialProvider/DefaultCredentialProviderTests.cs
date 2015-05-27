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
using Google.Apis.Tests;
using Google.Apis.Util;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2.DefaultCredentials
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.DefaultCredentialProvider"/>.</summary>
    [TestFixture]
    public class UserCredentialTests
    {
        private string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";
        private string WellKnownCredentialFilePath = Path.Combine(System.Environment.GetEnvironmentVariable("APPDATA"), "gcloud", "application_default_credentials.json");
        private const string DummyUserCredentialFileContents = "{\"client_id\": \"CLIENT_ID\",\"client_secret\": \"CLIENT_SECRET\",\"refresh_token\": \"REFRESH_TOKEN\",\"type\": \"authorized_user\"}";
        private const string DummyServiceAccountCredentialFileContents = "{\"private_key_id\": \"PRIVATE_KEY_ID\",\"private_key\": \"-----BEGIN PRIVATE KEY-----\nMIICdgIBADANBgkqhkiG9w0BAQEFAASCAmAwggJcAgEAAoGBAJJM6HT4s6btOsfe\n2x4zrzrwSUtmtR37XTTi0sPARTDF8uzmXy8UnE5RcVJzEH5T2Ssz/ylX4Sl/CI4L\nno1l8j9GiHJb49LSRjWe4Yx936q0Xj9H0R1HTxvjUPqwAsTwy2fKBTog+q1frqc9\no8s2r6LYivUGDVbhuUzCaMJsf+x3AgMBAAECgYEAi0FTXsu/zRswAUGaViQiHjrL\nuU65BSHXNVjV/2fLNEKnGWGqpli68z1IXY+S2nwbUak7rnGsq9/0F6jtsW+hZbLk\nKXUOuuExpeC5Kd6ngWX/f2jqmhlUabiQijU9cVk7pMq8EHkRtvlosnMTUAEzempu\nQUPwn1PZHhmJkBvZ4lECQQDCErrxl+e3BwUDcS0yVEEmCNSG6xdXs2878b8rzbe7\n3Mmi6SuuOLi3PU92J+j+f/MOdtYrk13mEDdYmd5dhrt5AkEAwPvDEsDT/W4y4h5n\ngv1awGBA5aLFE1JNWM/Gwn4D1cGpEDHKFREaBtxMDCASpHJuw8r7zUywpKhmBZcf\nGS37bwJANdSAKfbafLfjuhqwUJ9yGpykZm/a36aTmerp/bpn1iHdg+RtCzwMcDb/\nTWSwibbvsflgWmHbz657y4WSWhq+8QJAWrpCNN/ZCk2zuGDo80lfUBAwkoVat8G6\nwWU1oZyS+vzIGef+hLb8kHsjeZPej9eIwZ39kcBbT54oELrCkRjwGwJAQ8V2A7lT\nZUp8AsbVqF6rbLiiUfJMo2btGclQu4DEVyS+ymFA65tXDLUuR9EDqJYdqHNZJ5B8\n4Z5p2prkjWTLcA\u003d\u003d\n-----END PRIVATE KEY-----\n\",\"client_email\": \"CLIENT_EMAIL\",\"client_id\": \"CLIENT_ID\",\"type\": \"service_account\"}";

        #region UserCredential

        [Test]
        public void TestGetApplicationDefaultCredentials_UserCredentials_FromEnvironmentVariable()
        {
            string credentialFilepath = "TempFilePath.json";
            TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyUserCredentialFileContents);

            ICredential credential = credentialProvider.GetApplicationDefaultCredential();

            if (!(credential is UserCredential))
            {
                Assert.Fail(string.Format("Expected credential of type UserCredential. Obtained {0} instead.", credential.GetType()));
            }
        }

        [Test]
        public void TestGetApplicationDefaultCredentials_UserCredentials_FromWellKnownFileLocation()
        {
            TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
            credentialProvider.SetFileContents(WellKnownCredentialFilePath, DummyUserCredentialFileContents);

            ICredential credential = credentialProvider.GetApplicationDefaultCredential();

            if (!(credential is UserCredential))
            {
                Assert.Fail(string.Format("Expected credential of type UserCredential. Obtained {0} instead.", credential.GetType()));
            }
        }

        #endregion

        #region ServiceAccountCredential

        [Test]
        public void TestGetApplicationDefaultCredentials_ServiceAccountCredentials_FromEnvironmentVariable()
        {
            string credentialFilepath = "TempFilePath.json";
            TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
            credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
            credentialProvider.SetFileContents(credentialFilepath, DummyServiceAccountCredentialFileContents);

            ICredential credential = credentialProvider.GetApplicationDefaultCredential();

            if (!(credential is ServiceAccountCredential))
            {
                Assert.Fail(string.Format("Expected credential of type ServiceAccountCredential. Obtained {0} instead.", credential.GetType()));
            }
        }

        #endregion

        #region Invalid Cases

        // No credential files or environment variable specified - like a fresh developer's machine. 
        [Test]
        public void TestGetApplicationDefaultCredentials_NoCredentialFiles()
        {
            try
            {
                TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
                ICredential credential = credentialProvider.GetApplicationDefaultCredential();

                Assert.Fail(string.Format("No credential file specified. Test expected to result in exception. Obtained {0} instead.", credential.GetType()));
            }
            catch (IOException e)
            {
                if (!e.Message.Contains("The Application Default Credentials are not available"))
                {
                    Assert.Fail(String.Format("Expected IOException containing message 'The Application Default Credentials are not available'. Obtained {0} instead.", e.ToString()));
                }
            }
        }

        // Environment variable points to a non existant credential file
        [Test]
        public void TestGetApplicationDefaultCredentials_MissingCredentialFile()
        {
            try
            {
                TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
                credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, WellKnownCredentialFilePath);

                ICredential credential = credentialProvider.GetApplicationDefaultCredential();

                Assert.Fail(string.Format("No credential file specified. Test expected to result in exception. Obtained {0} instead.", credential.GetType()));
            }
            catch (IOException e)
            {
                if (!e.Message.Contains("Please check the value of the Environment Variable GOOGLE_APPLICATION_CREDENTIALS"))
                {
                    Assert.Fail(String.Format("Expected IOException containing message 'Please check the value of the Environment Variable GOOGLE_APPLICATION_CREDENTIALS'. Obtained {0} instead.", e.ToString()));
                }
            }
        }

        // Credential file has invalid content format
        [Test]
        public void TestGetApplicationDefaultCredentials_InvalidCredentialFile()
        {
            try
            {
                string credentialFilepath = "TempFilePath.json";
                TestDefaultCredentialProvider credentialProvider = new TestDefaultCredentialProvider();
                credentialProvider.SetEnvironmentVariable(CredentialEnvironmentVariable, credentialFilepath);
                credentialProvider.SetFileContents(credentialFilepath, "Invalid Credentials File Contents");

                ICredential credential = credentialProvider.GetApplicationDefaultCredential();

                Assert.Fail(string.Format("Invalid credential file specified. Test expected to result in exception. Obtained {0} instead.", credential.GetType()));
            }
            catch (IOException e)
            {
                if (!e.Message.Contains("Error reading credential file from location"))
                {
                    Assert.Fail(String.Format("Expected IOException containing message 'Error reading credential file from location'. Obtained {0} instead.", e.ToString()));
                }
            }
        }


        #endregion
    }

    class TestDefaultCredentialProvider : DefaultCredentialProvider
    {
        Dictionary<string, string> envVars = new Dictionary<string, string>();
        Dictionary<string, string> fileContents = new Dictionary<string, string>();

        internal override string GetEnvironmentVariable(string variableName)
        {
            if (!envVars.ContainsKey(variableName))
                return null;

            return envVars[variableName];
        }

        internal void SetEnvironmentVariable(string variableName, string value)
        {
            envVars[variableName] = value;
        }

        internal override Stream GetStream(string filePath)
        {
            if (!fileContents.ContainsKey(filePath))
            {
                throw new System.IO.FileNotFoundException();
            }

            return new MemoryStream(Encoding.UTF8.GetBytes(fileContents[filePath]));
        }

        internal void SetFileContents(string filePath, string contents)
        {
            fileContents[filePath] = contents;
        }
    }
}
