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
    /// An instance of this class represents the per-process state used to get and cache 
    /// the credential and allows overriding the state and environment for testing purposes.
    /// </summary>
    internal class DefaultCredentialProvider
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<DefaultCredentialProvider>();

        /// <summary>Well known file which stores the default application credentials.</summary>
        private const string WellKnownCredentialsFile = "application_default_credentials.json";

        /// <summary>Environment variable override which stores the default application credentials file path.</summary>
        private const string CredentialEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";

        /// <summary>Environment variable which contains the Application Data settings.</summary>
        private const string AppdataEnvironmentVariable = "APPDATA";

        /// <summary>GCloud configuration directory in Windows, relative to %APPDATA%.</summary>
        private const string CloudSDKConfigDirectory = "gcloud";

        /// <summary>Help link to the application default credentials feature.</summary>
        private const string HelpPermalink = "https://developers.google.com/accounts/docs/application-default-credentials";

        private object lockObject = new object();

        // These variables should only be accessed inside a synchronized block.
        private ICredential cachedCredential = null;
        private bool checkedComputeEngine = false;

        /// <summary>
        /// <para>Returns the Application Default Credentials which are ambient credentials that identify and authorize 
        /// the whole application.</para>
        /// <para>The ambient credentials are determined as following order:</para>
        /// <list type="number">
        /// <item> 
        /// <description>The environment variable GOOGLE_APPLICATION_CREDENTIALS is checked. If this variable is specified, it 
        /// should point to a file that defines the credentials. The simplest way to get a credential for this purpose is to 
        /// create a service account using the <a href="https://console.developers.google.com">Google Developers Console</a> in 
        /// the section APIs and Auth, in the sub-section Credentials. Create a service account or choose an existing one and 
        /// select Generate new JSON key. Set the environment variable to the path of the JSON file downloaded.</description> 
        /// </item> 
        /// <item> 
        /// <description>If you have installed the Google Cloud SDK on your machine and have run the command 
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>, your identity can be used as 
        /// a proxy to test code calling APIs from that machine.</description> 
        /// </item> 
        /// <item> 
        /// <description>If you are running in Google Compute Engine production, the built-in service account associated with the 
        /// virtual machine instance will be used.</description> 
        /// </item> 
        /// </list>
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

            throw new InvalidOperationException(String.Format("The Application Default Credentials are not available. They are available if running"
                + " in Google Compute Engine. Otherwise, the environment variable {0} must be defined"
                + " pointing to a file defining the credentials. See {1} for more information.",
                CredentialEnvironmentVariable,
                HelpPermalink));
        }

        /// <summary>Unsynchronized helper method to obtain the Application Default Credentials.</summary>
        private ICredential GetDefaultCredentialUnsynchronized()
        {
            string credentialPath = null;
            
            // 1. First try the environment variable.
            try
            {
                credentialPath = GetEnvironmentVariable(CredentialEnvironmentVariable);
                if (!String.IsNullOrWhiteSpace(credentialPath))
                {
                    return LoadCredentialFromFile(credentialPath);
                }
            }
            catch (Exception e)
            {
                // Catching generic exception type because any corrupted file could manifest in different ways including 
                // but not limited to the System, System.IO or from the Newtonsoft.Json namespace.

                throw new InvalidOperationException(String.Format("Error reading credential file from location {0}: {1}"
                                        + "\nPlease check the value of the Environment Variable {2}",
                                        credentialPath,
                                        e.Message,
                                        CredentialEnvironmentVariable));
            }

            // 2. Then try the well known file.
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
                throw new InvalidOperationException(String.Format("Error reading credential file from location {0}: {1}"
                                  + "\nPlease rerun 'gcloud auth login' to regenerate credentials file.",
                                  credentialPath,
                                  e.Message));
            }

            // 3. Then try the compute engine, if not already checked.         
            if (!checkedComputeEngine)
            {
                Logger.Debug("Checking whether the application is running on ComputeEngine.");
                bool isRunningOnComputeEngine = ComputeCredential.IsRunningOnComputeEngine().Result;
                checkedComputeEngine = true;
                if (isRunningOnComputeEngine)
                {
                    Logger.Debug("ComputeEngine check passed. Loading ComputeEngine Credentials.");
                    return new ComputeCredential();
                }
            }

            return null;
        }

        /// <summary>Converts a stream to a credential object.</summary>
        internal static ICredential LoadFromStream(Stream stream)
        {
            ClientCredentialParameters clientCredentialParameters = ClientCredentialParameters.Load(stream);
          
            switch (clientCredentialParameters.GetCredentialType())
            {
                case ClientCredentialType.UserCredential:
                    try
                    {
                        var initializer = new GoogleAuthorizationCodeFlow.Initializer
                        {
                            ClientSecrets = clientCredentialParameters.GetClientSecrets()
                        };

                        var token = new TokenResponse()
                        {
                            RefreshToken = clientCredentialParameters.RefreshToken
                        };

                        var flow = new GoogleAuthorizationCodeFlow(initializer);
                        return new UserCredential(flow, "ApplicationDefaultCredentials", token);
                    }
                    catch (IOException e)
                    {
                        throw new InvalidOperationException("Error parsing stream contents.", e);
                    }

                case ClientCredentialType.ServiceAccountCredential:
                    try
                    {
                        var initializer = new ServiceAccountCredential.Initializer(clientCredentialParameters.ClientEmail);
                        return new ServiceAccountCredential(initializer.FromPrivateKey(clientCredentialParameters.Pkcs8PrivateKey));
                    }
                    catch (IOException e)
                    {
                        throw new InvalidOperationException("Error parsing stream contents.", e);
                    }

                default:
                    throw new InvalidOperationException("Error reading credentials from stream, 'type' field not specified.");
            }
        }

        /// <summary> 
        /// Helper method to return well known credential file path. This file is created by 
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>
        /// </summary>
        private string GetWellKnownCredentialFilePath()
        {
            return Path.Combine(System.Environment.GetEnvironmentVariable(AppdataEnvironmentVariable),
                CloudSDKConfigDirectory,
                WellKnownCredentialsFile);
        }

        /// <summary>Helper method to load file stream.</summary>
        internal ICredential LoadCredentialFromFile(string credentialPath)
        {
            Logger.Debug(String.Format("Loading Credential from file {0}", credentialPath));

            using (Stream stream = GetStream(credentialPath))
            {
                return LoadFromStream(stream);
            }
        }

        /// <summary>Helper method to read the file stream.</summary>
        internal virtual Stream GetStream(string filePath)
        {
            return new FileStream(filePath, FileMode.Open);
        }

        /// <summary>Helper method to get the environment variable.</summary>
        internal virtual string GetEnvironmentVariable(string variableName)
        {
            return System.Environment.GetEnvironmentVariable(CredentialEnvironmentVariable);
        }
    }
}
