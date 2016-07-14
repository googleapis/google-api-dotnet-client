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
using System.IO;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2
{
    // TODO(jtattermusch): look into getting rid of DefaultCredentialProvider and moving
    // the logic into GoogleCredential.

    /// <summary>
    /// Provides the Application Default Credential from the environment. 
    /// An instance of this class represents the per-process state used to get and cache 
    /// the credential and allows overriding the state and environment for testing purposes.
    /// </summary>
    internal class DefaultCredentialProvider
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<DefaultCredentialProvider>();

        /// <summary>
        /// Environment variable override which stores the default application credentials file path.
        /// </summary>
        public const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>Well known file which stores the default application credentials.</summary>
        private const string WellKnownCredentialsFile = "application_default_credentials.json";

        /// <summary>Environment variable which contains the Application Data settings.</summary>
        private const string AppdataEnvironmentVariable = "APPDATA";

        /// <summary>Environment variable which contains the location of home directory on UNIX systems.</summary>
        private const string HomeEnvironmentVariable = "HOME";

        /// <summary>GCloud configuration directory in Windows, relative to %APPDATA%.</summary>
        private const string CloudSDKConfigDirectoryWindows = "gcloud";

        /// <summary>Help link to the application default credentials feature.</summary>
        private const string HelpPermalink = 
            "https://developers.google.com/accounts/docs/application-default-credentials";

        /// <summary>GCloud configuration directory on Linux/Mac, relative to $HOME.</summary>
        private static readonly string CloudSDKConfigDirectoryUnix = Path.Combine(".config", "gcloud");

        /// <summary>Caches result from first call to <c>GetApplicationDefaultCredentialAsync</c> </summary>
        private readonly Lazy<Task<GoogleCredential>> cachedCredentialTask;

        /// <summary>Constructs a new default credential provider.</summary>
        public DefaultCredentialProvider()
        {
            cachedCredentialTask = new Lazy<Task<GoogleCredential>>(CreateDefaultCredentialAsync);
        }

        /// <summary>
        /// Returns the Application Default Credentials. Subsequent invocations return cached value from
        /// first invocation.
        /// See <see cref="M:Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefaultAsync"/> for details.
        /// </summary>
        public Task<GoogleCredential> GetDefaultCredentialAsync()
        {
            return cachedCredentialTask.Value;
        }

        /// <summary>Creates a new default credential.</summary>
        private async Task<GoogleCredential> CreateDefaultCredentialAsync()
        {
            // 1. First try the environment variable.
            string credentialPath = GetEnvironmentVariable(CredentialEnvironmentVariable);
            if (!String.IsNullOrWhiteSpace(credentialPath))
            {
                try
                {
                    return CreateDefaultCredentialFromFile(credentialPath);
                }
                catch (Exception e)
                {
                    // Catching generic exception type because any corrupted file could manifest in different ways
                    // including but not limited to the System, System.IO or from the Newtonsoft.Json namespace.
                    throw new InvalidOperationException(
                        String.Format("Error reading credential file from location {0}: {1}"
                            + "\nPlease check the value of the Environment Variable {2}",
                            credentialPath,
                            e.Message,
                            CredentialEnvironmentVariable));
                }
            }
            
            // 2. Then try the well known file.
            credentialPath = GetWellKnownCredentialFilePath();
            if (!String.IsNullOrWhiteSpace(credentialPath))
            {
                try
                {
                    return CreateDefaultCredentialFromFile(credentialPath);
                }
                catch (FileNotFoundException)
                {
                    // File is not present, eat the exception and move on to the next check.
                    Logger.Debug("Well-known credential file {0} not found.", credentialPath);
                }
                catch (DirectoryNotFoundException)
                {
                    // Directory not present, eat the exception and move on to the next check.
                    Logger.Debug("Well-known credential file {0} not found.", credentialPath);
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException(
                        String.Format("Error reading credential file from location {0}: {1}"
                            + "\nPlease rerun 'gcloud auth login' to regenerate credentials file.",
                            credentialPath,
                            e.Message));
                }
            }

            // 3. Then try the compute engine.     
            Logger.Debug("Checking whether the application is running on ComputeEngine.");
            if (await ComputeCredential.IsRunningOnComputeEngine().ConfigureAwait(false))
            {
                Logger.Debug("ComputeEngine check passed. Using ComputeEngine Credentials.");
                return new GoogleCredential(new ComputeCredential());
            }

            // If everything we tried has failed, throw an exception.
            throw new InvalidOperationException(
                String.Format("The Application Default Credentials are not available. They are available if running"
                    + " in Google Compute Engine. Otherwise, the environment variable {0} must be defined"
                    + " pointing to a file defining the credentials. See {1} for more information.",
                    CredentialEnvironmentVariable,
                    HelpPermalink));
        }

        /// <summary>Creates a default credential from a JSON file.</summary>
        private GoogleCredential CreateDefaultCredentialFromFile(string credentialPath)
        {
            Logger.Debug("Loading Credential from file {0}", credentialPath);

            using (Stream stream = GetStream(credentialPath))
            {
                return CreateDefaultCredentialFromStream(stream);
            }
        }

        /// <summary>Creates a default credential from a stream that contains JSON credential data.</summary>
        internal GoogleCredential CreateDefaultCredentialFromStream(Stream stream)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(stream);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromJson(credentialParameters);
        }

        /// <summary>Creates a default credential from JSON data.</summary>
        private static GoogleCredential CreateDefaultCredentialFromJson(JsonCredentialParameters credentialParameters)
        {
            switch (credentialParameters.Type)
            {
                case JsonCredentialParameters.AuthorizedUserCredentialType:
                    return new GoogleCredential(CreateUserCredentialFromJson(credentialParameters));

                case JsonCredentialParameters.ServiceAccountCredentialType:
                    return GoogleCredential.FromCredential(
                        CreateServiceAccountCredentialFromJson(credentialParameters));
                
                default:
                    throw new InvalidOperationException(
                        String.Format("Error creating credential from JSON. Unrecognized credential type {0}.", 
                            credentialParameters.Type));
            }
        }

        /// <summary>Creates a user credential from JSON data.</summary>
        private static UserCredential CreateUserCredentialFromJson(JsonCredentialParameters credentialParameters)
        {
            if (credentialParameters.Type != JsonCredentialParameters.AuthorizedUserCredentialType ||
                string.IsNullOrEmpty(credentialParameters.ClientId) ||
                string.IsNullOrEmpty(credentialParameters.ClientSecret))
            {
                throw new InvalidOperationException("JSON data does not represent a valid user credential.");
            }

            var token = new TokenResponse
            {
                RefreshToken = credentialParameters.RefreshToken
            };

            var initializer = new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = credentialParameters.ClientId,
                    ClientSecret = credentialParameters.ClientSecret
                }
            };
            var flow = new GoogleAuthorizationCodeFlow(initializer);
            return new UserCredential(flow, "ApplicationDefaultCredentials", token);
        }

        /// <summary>Creates a <see cref="ServiceAccountCredential"/> from JSON data.</summary>
        private static ServiceAccountCredential CreateServiceAccountCredentialFromJson(
            JsonCredentialParameters credentialParameters)
        {
            if (credentialParameters.Type != JsonCredentialParameters.ServiceAccountCredentialType ||
                string.IsNullOrEmpty(credentialParameters.ClientEmail) ||
                string.IsNullOrEmpty(credentialParameters.PrivateKey))
            {
                throw new InvalidOperationException("JSON data does not represent a valid service account credential.");
            }
            var initializer = new ServiceAccountCredential.Initializer(credentialParameters.ClientEmail);
            return new ServiceAccountCredential(initializer.FromPrivateKey(credentialParameters.PrivateKey));
        }

        /// <summary> 
        /// Returns platform-specific well known credential file path. This file is created by 
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>
        /// </summary>
        private string GetWellKnownCredentialFilePath()
        {
            var appData = GetEnvironmentVariable(AppdataEnvironmentVariable);
            if (appData != null) {
                return Path.Combine(appData, CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
            }
            var unixHome = GetEnvironmentVariable(HomeEnvironmentVariable);
            if (unixHome != null)
            {
                return Path.Combine(unixHome, CloudSDKConfigDirectoryUnix, WellKnownCredentialsFile);
            }
            return Path.Combine(CloudSDKConfigDirectoryWindows, WellKnownCredentialsFile);
        }

        /// <summary>
        /// Gets the environment variable. 
        /// This method is protected so it could be overriden for testing purposes only.
        /// </summary>
        protected virtual string GetEnvironmentVariable(string variableName)
        {
            return Environment.GetEnvironmentVariable(variableName);
        }

        /// <summary>
        /// Opens file as a stream.
        /// This method is protected so it could be overriden for testing purposes only.
        /// </summary>
        protected virtual Stream GetStream(string filePath)
        {
            return new FileStream(filePath, FileMode.Open, FileAccess.Read);
        }
    }
}
