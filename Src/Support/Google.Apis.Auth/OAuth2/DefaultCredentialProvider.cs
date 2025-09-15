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
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Logging;

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
            "https://cloud.google.com/docs/authentication/external/set-up-adc";

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
        public Task<GoogleCredential> GetDefaultCredentialAsync() => cachedCredentialTask.Value;

        /// <summary>Creates a new default credential.</summary>
        private async Task<GoogleCredential> CreateDefaultCredentialAsync()
        {
            GoogleCredential credential =
                // 1. First try the environment variable.
                await GetAdcFromEnvironmentVariableAsync().ConfigureAwait(false)
                // 2. Then try the well known file.
                ?? await GetAdcFromWellKnownFileAsync().ConfigureAwait(false)
                // 3. Then try the compute engine.
                ?? await GetAdcFromComputeAsync().ConfigureAwait(false)
            // If everything we tried has failed, throw an exception.
                ?? throw new InvalidOperationException($"Your default credentials were not found. To set up Application Default Credentials, see {HelpPermalink}.");

            return credential.CreateWithEnvironmentQuotaProject();

            async Task<GoogleCredential> GetAdcFromEnvironmentVariableAsync()
            {
                string credentialPath = GetEnvironmentVariable(CredentialEnvironmentVariable);
                if (!string.IsNullOrWhiteSpace(credentialPath))
                {
                    try
                    {
                        return await CreateDefaultCredentialFromFileAsync(credentialPath, default).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        // Catching generic exception type because any corrupted file could manifest in different ways
                        // including but not limited to the System, System.IO or from the Newtonsoft.Json namespace.
                        throw new InvalidOperationException(
                            $"Error reading credential file from location {credentialPath}: {e.Message}{Environment.NewLine}" +
                            $"Please check the value of the Environment Variable {CredentialEnvironmentVariable}.", e);
                    }
                }
                return null;
            }

            async Task<GoogleCredential> GetAdcFromWellKnownFileAsync()
            {
                string credentialPath = GetWellKnownCredentialFilePath();
                if (!string.IsNullOrWhiteSpace(credentialPath))
                {
                    try
                    {
                        return await CreateDefaultCredentialFromFileAsync(credentialPath, default).ConfigureAwait(false);
                    }
                    catch (Exception e) when (e is FileNotFoundException || e is DirectoryNotFoundException)
                    {
                        // File is not present, eat the exception and move on to the next check.
                        Logger.Debug($"Well-known credential file {credentialPath} not found.");
                    }
                    catch (Exception e)
                    {
                        throw new InvalidOperationException(
                            $"Error reading credential file from location {credentialPath}: {e.Message}{Environment.NewLine}" +
                            "Please rerun 'gcloud auth login' to regenerate credentials file.", e);
                    }
                }
                return null;
            }

            async Task<GoogleCredential> GetAdcFromComputeAsync()
            {
                Logger.Debug("Checking whether the application is running on ComputeEngine.");
                if (await ComputeCredential.IsRunningOnComputeEngine().ConfigureAwait(false))
                {
                    Logger.Debug("ComputeEngine check passed. Using ComputeEngine Credentials.");
                    return new GoogleCredential(new ComputeCredential());
                }
                return null;
            }
        }

        private async Task<GoogleCredential> CreateDefaultCredentialFromFileAsync(string credentialPath, CancellationToken cancellationToken)
        {
            Logger.Debug("Loading Credential from file {0}", credentialPath);

            // We use the overridable GetStream method instead of the CredentialFactory.FromFile methods to be able to test ADC.
            using Stream stream = GetStream(credentialPath);
            var credential = await CredentialFactory.FromStreamAsync<IGoogleCredential>(stream, cancellationToken).ConfigureAwait(false);
            return credential.ToGoogleCredential();
        }

        /// <summary> 
        /// Returns platform-specific well known credential file path. This file is created by 
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">gcloud auth login</a>
        /// </summary>
        private string GetWellKnownCredentialFilePath()
        {
            var appData = GetEnvironmentVariable(AppdataEnvironmentVariable);
            if (appData != null)
            {
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
