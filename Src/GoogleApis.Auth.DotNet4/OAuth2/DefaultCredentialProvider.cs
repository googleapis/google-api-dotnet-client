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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Json;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Provides the Application Default Credential from the environment. 
    /// An instance represents the per-process state used to get and cache the credential and
    /// allows overriding the state and environment for testing purposes.
    /// </summary>
    internal class DefaultCredentialProvider
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<DefaultCredentialProvider>();

        /// <summary>Well known file which stores the default application credentials.</summary>
        private const string WELL_KNOWN_CREDENTIALS_FILE = "application_default_credentials.json";

        /// <summary>Environment variable override which stores the default application credentials file path.</summary>
        private const string CREDENTIAL_ENV_VAR = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>Environment variable which contains the Application Data settings.</summary>
        private const string APPDATA_ENV_VAR = "APPDATA";

        /// <summary>GCloud configuration directory in Windows, relative to %APPDATA%.</summary>
        private const string CLOUDSDK_CONFIG_DIRECTORY = "gcloud";

        /// <summary>Type name value of credentials file - user credentials.</summary>
        private const string USER_FILE_TYPE = "authorized_user";

        /// <summary>Type name value of credentials file - service account.</summary>
        private const string SERVICE_ACCOUNT_FILE_TYPE = "service_account";

        /// <summary>Help link to the application default credentials feature.</summary>
        private const string HELP_PERMALINK = "https://developers.google.com/accounts/docs/application-default-credentials";

        private object lockObject = new object();

        // These variables should only be accessed inside a synchronized block.
        private ICredential cachedCredential = null;
        private bool checkedComputeEngine = false;

        /// <summary>
        /// Returns the Application Default Credentials which are credentials that identify and
        /// authorize the whole application. This is the built-in service account if running on Google
        /// Compute Engine or credentials specified by an environment variable or a file in a well-known location.
        /// </summary>
        internal ICredential GetApplicationDefaultCredential()
        {
            if (cachedCredential == null)
            {
                lock (lockObject)
                {
                    if (cachedCredential == null)
                    {
                        cachedCredential = GetDefaultCredentialUnsynchronized();
                    }
                }
            }
            if (cachedCredential != null)
            {
                return cachedCredential;
            }

            throw new IOException(String.Format("The Application Default Credentials are not available. They are available if running"
                + " in Google Compute Engine. Otherwise, the environment variable {0} must be defined"
                + " pointing to a file defining the credentials. See {1} for more information.",
                CREDENTIAL_ENV_VAR,
                HELP_PERMALINK));
        }

        /// <summary>
        /// Unsynchronized helper method to obtain the Application Default Credentials.
        /// </summary>
        private ICredential GetDefaultCredentialUnsynchronized()
        {
            string credentialPath = null;
            
            // 1. First try the environment variable
            try
            {
                credentialPath = GetEnvironmentVariable(CREDENTIAL_ENV_VAR);
                if (!String.IsNullOrWhiteSpace(credentialPath))
                {
                    return LoadCredentialFromFile(credentialPath);
                }
            }
            catch (Exception e)
            {
                // Catching generic exception type because any corrupted file could manifest in different ways including 
                // but not limited to the System.IO or from the Newtonsoft.Json namespace

                throw new IOException(String.Format("Error reading credential file from location {0}: {1}"
                                        + "\nPlease check the value of the Environment Variable {2}",
                                        credentialPath,
                                        e.Message,
                                        CREDENTIAL_ENV_VAR));
            }

            // 2. Then try the well known file
            try
            {
                credentialPath = GetWellKnownCredentialFilePath();
                if (!String.IsNullOrWhiteSpace(credentialPath))
                {
                    return LoadCredentialFromFile(credentialPath);
                }
            }
            catch (FileNotFoundException)
            {
                // File is not present, eat the exception and move on to the next check.
            }
            catch (IOException e)
            {
                // Catching generic exception type because any corrupted file could manifest in different ways including 
                // but not limited to the System.IO or from the Newtonsoft.Json namespace

                throw new IOException(String.Format("Error reading credential file from location {0}: {1}"
                                        + "\nPlease rerun 'gcloud auth login' to regenerate credentials file.",
                                        credentialPath,
                                        e.Message));
            }

            // 3. Then try the compute engine, if not already checked         
            if (!checkedComputeEngine)
            {
                Logger.Info("Checking whether the application is running on ComputeEngine.");
                bool isRunningOnComputeEngine = ComputeCredential.IsRunningOnComputeEngine().Result;
                checkedComputeEngine = true;
                if (isRunningOnComputeEngine)
                {
                    Logger.Info("ComputeEngine check passed. Loading ComputeEngine Credentials.");
                    return new ComputeCredential();
                }
            }

            return null;
        }

        /// <summary>
        /// Converts a stream to a credential object.
        /// </summary>
        internal static ICredential LoadFromStream(Stream stream)
        {
            JObject jsonObject = NewtonsoftJsonSerializer.Instance.Deserialize<JObject>(stream);
            string fileType = null;

            try
            {
                fileType = ReadJsonValue(jsonObject, "type");
            }
            catch (IOException e)
            {
                throw new IOException("Error parsing stream contents.", e);
            }

            switch (fileType)
            {
                case USER_FILE_TYPE:
                    try
                    {
                        ClientSecrets clientSecrets = new ClientSecrets()
                        {
                            ClientId = ReadJsonValue(jsonObject, "client_id"),
                            ClientSecret = ReadJsonValue(jsonObject, "client_secret")
                        };

                        var initializer = new GoogleAuthorizationCodeFlow.Initializer
                        {
                            ClientSecrets = clientSecrets
                        };

                        TokenResponse token = new TokenResponse()
                        {
                            RefreshToken = ReadJsonValue(jsonObject, "refresh_token")
                        };

                        var flow = new GoogleAuthorizationCodeFlow(initializer);
                        return new UserCredential(flow, "ApplicationDefaultCredentials", token);
                    }
                    catch (IOException e)
                    {
                        throw new IOException("Error parsing stream contents.", e);
                    }

                case SERVICE_ACCOUNT_FILE_TYPE:
                    try
                    {
                        var initializer = new ServiceAccountCredential.Initializer(ReadJsonValue(jsonObject, "client_email"));

                        var base64PrivateKey = ReadJsonValue(jsonObject, "private_key");
                        base64PrivateKey = base64PrivateKey.Replace("-----BEGIN PRIVATE KEY-----", "").Replace("\n", "").Replace("-----END PRIVATE KEY-----", "");
                        return new ServiceAccountCredential(initializer.FromPrivateKey(base64PrivateKey));
                    }
                    catch (IOException e)
                    {
                        throw new IOException("Error parsing stream contents.", e);
                    }

                default:
                    throw new IOException("Error reading credentials from stream, 'type' field not specified.");
            }
        }

        /// <summary> 
        /// Helper method to return well known credential file path. This file is created by 'gcloud auth login'.
        /// </summary>
        private string GetWellKnownCredentialFilePath()
        {
            return Path.Combine(System.Environment.GetEnvironmentVariable(APPDATA_ENV_VAR),
                CLOUDSDK_CONFIG_DIRECTORY,
                WELL_KNOWN_CREDENTIALS_FILE);
        }

        /// <summary>
        /// Helper method to load file stream.
        /// </summary>
        internal ICredential LoadCredentialFromFile(string credentialPath)
        {
            Logger.Info(String.Format("Loading Credential from file {0}", credentialPath));

            using (Stream fs = GetStream(credentialPath))
            {
                return LoadFromStream(fs);
            }
        }

        /// <summary>
        /// Helper method to get a json field.
        /// </summary>
        private static string ReadJsonValue(JObject jsonObject, string key)
        {
            var value = jsonObject[key];
            if (value != null)
                return value.ToString();

            throw new IOException(String.Format("Could not find property {0}.", key));
        }

        /// <summary>
        /// Helper method to read the file stream.
        /// </summary>
        internal virtual Stream GetStream(string filePath)
        {
            return new FileStream(filePath, FileMode.Open);
        }

        /// <summary>
        /// Helper method to get the environment variable.
        /// </summary>
        internal virtual string GetEnvironmentVariable(string variableName)
        {
            return System.Environment.GetEnvironmentVariable(CREDENTIAL_ENV_VAR);
        }
    }
}
