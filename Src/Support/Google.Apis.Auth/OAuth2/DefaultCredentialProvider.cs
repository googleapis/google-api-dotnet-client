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

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util;

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

            using Stream stream = GetStream(credentialPath);
            return await CreateDefaultCredentialFromStreamAsync(stream, cancellationToken).ConfigureAwait(false);
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
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }

        /// <summary>Creates a default credential from a stream that contains JSON credential data.</summary>
        internal async Task<GoogleCredential> CreateDefaultCredentialFromStreamAsync(Stream stream, CancellationToken cancellationToken)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = await NewtonsoftJsonSerializer.Instance
                    .DeserializeAsync<JsonCredentialParameters>(stream, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }

        /// <summary>Creates a default credential from a string that contains JSON credential data.</summary>
        internal GoogleCredential CreateDefaultCredentialFromJson(string json)
        {
            JsonCredentialParameters credentialParameters;
            try
            {
                credentialParameters = NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(json);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
            return CreateDefaultCredentialFromParameters(credentialParameters);
        }


        /// <summary>Creates a default credential from JSON data.</summary>
        internal GoogleCredential CreateDefaultCredentialFromParameters(JsonCredentialParameters credentialParameters) =>
            credentialParameters.ThrowIfNull(nameof(credentialParameters)).Type switch
            {
                JsonCredentialParameters.AuthorizedUserCredentialType => new GoogleCredential(CreateUserCredentialFromParameters(credentialParameters)),
                JsonCredentialParameters.ServiceAccountCredentialType => GoogleCredential.FromServiceAccountCredential(CreateServiceAccountCredentialFromParameters(credentialParameters)),
                JsonCredentialParameters.ExternalAccountCredentialType => new GoogleCredential(CreateExternalCredentialFromParameters(credentialParameters)),
                JsonCredentialParameters.ImpersonatedServiceAccountCredentialType => new GoogleCredential(CreateImpersonatedServiceAccountCredentialFromParameters(credentialParameters)),
                JsonCredentialParameters.ExternalAccountAuthorizedUserCredentialType => new GoogleCredential(CreateExternalAccountAuthorizedUserCredentialFromParemeters(credentialParameters)),
                _ => throw new InvalidOperationException($"Error creating credential from JSON or JSON parameters. Unrecognized credential type {credentialParameters.Type}."),
            };

        /// <summary>Creates a user credential from JSON data.</summary>
        private static UserCredential CreateUserCredentialFromParameters(JsonCredentialParameters credentialParameters)
        {
            if (credentialParameters.Type != JsonCredentialParameters.AuthorizedUserCredentialType ||
                string.IsNullOrEmpty(credentialParameters.ClientId) ||
                string.IsNullOrEmpty(credentialParameters.ClientSecret))
            {
                throw new InvalidOperationException("JSON data does not represent a valid user credential.");
            }
            if (credentialParameters.UniverseDomain is not null && credentialParameters.UniverseDomain != GoogleAuthConsts.DefaultUniverseDomain)
            {
                throw new InvalidOperationException($"{nameof(UserCredential)} is not supported in universe domains other than {GoogleAuthConsts.DefaultUniverseDomain}");
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
                },
                ProjectId = credentialParameters.ProjectId
            };
            var flow = new GoogleAuthorizationCodeFlow(initializer);
            return new UserCredential(flow, "ApplicationDefaultCredentials", token, credentialParameters.QuotaProject);
        }

        /// <summary>Creates a <see cref="ServiceAccountCredential"/> from JSON data.</summary>
        private static ServiceAccountCredential CreateServiceAccountCredentialFromParameters(
            JsonCredentialParameters credentialParameters)
        {
            if (credentialParameters.Type != JsonCredentialParameters.ServiceAccountCredentialType ||
                string.IsNullOrEmpty(credentialParameters.ClientEmail) ||
                string.IsNullOrEmpty(credentialParameters.PrivateKey))
            {
                throw new InvalidOperationException("JSON data does not represent a valid service account credential.");
            }
            var initializer = new ServiceAccountCredential.Initializer(
                credentialParameters.ClientEmail, credentialParameters.TokenUri)
            {
                ProjectId = credentialParameters.ProjectId,
                QuotaProject = credentialParameters.QuotaProject,
                KeyId = credentialParameters.PrivateKeyId,
                UniverseDomain = credentialParameters.UniverseDomain,
                UseJwtAccessWithScopes = credentialParameters.UniverseDomain is not null && credentialParameters.UniverseDomain != GoogleAuthConsts.DefaultUniverseDomain
            };
            return new ServiceAccountCredential(initializer.FromPrivateKey(credentialParameters.PrivateKey));
        }

        /// <summary>
        /// Creates an external account credential from JSON data.
        /// </summary>
        private static IGoogleCredential CreateExternalCredentialFromParameters(JsonCredentialParameters parameters)
        {
            if (parameters.Type != JsonCredentialParameters.ExternalAccountCredentialType || parameters.CredentialSourceConfig is null)
            {
                throw new InvalidOperationException("JSON data does not represent a valid external account credential.");
            }

            // Build the external credential of the correct type.
            // The order in which these checks are performed is relevant, see https://google.aip.dev/auth/4117.
            if (!string.IsNullOrEmpty(parameters.CredentialSourceConfig.EnvironmentId))
            {
                if (!parameters.CredentialSourceConfig.EnvironmentId.Equals(AwsExternalAccountCredential.SupportedVersion, StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException(
                        $"Only {AwsExternalAccountCredential.SupportedVersion} version of AWS external account credentials is supported by this library.");
                }

                return new AwsExternalAccountCredential(new AwsExternalAccountCredential.Initializer(
                    parameters.TokenUrl, parameters.Audience, parameters.SubjectTokenType,
                    parameters.CredentialSourceConfig.RegionalCredentialVerificationUrl)
                {
                    QuotaProject = parameters.QuotaProject,
                    ServiceAccountImpersonationUrl = parameters.ServiceAccountImpersonationUrl,
                    WorkforcePoolUserProject = parameters.WorkforcePoolUserProject,
                    ClientId = parameters.ClientId,
                    ClientSecret = parameters.ClientSecret,
                    RegionUrl = parameters.CredentialSourceConfig.RegionUrl,
                    SecurityCredentialsUrl = parameters.CredentialSourceConfig.Url,
                    ImdsV2SessionTokenUrl = parameters.CredentialSourceConfig.ImdsV2SessionTokenUrl,
                    UniverseDomain = parameters.UniverseDomain,
                });
            }
            else if (!string.IsNullOrEmpty(parameters.CredentialSourceConfig.File))
            {
                return new FileSourcedExternalAccountCredential(new FileSourcedExternalAccountCredential.Initializer(
                    parameters.TokenUrl, parameters.Audience, parameters.SubjectTokenType, parameters.CredentialSourceConfig.File)
                {
                    QuotaProject = parameters.QuotaProject,
                    ServiceAccountImpersonationUrl = parameters.ServiceAccountImpersonationUrl,
                    WorkforcePoolUserProject = parameters.WorkforcePoolUserProject,
                    ClientId = parameters.ClientId,
                    ClientSecret = parameters.ClientSecret,
                    SubjectTokenJsonFieldName = parameters.ExtractSubjectTokenFieldName(),
                    UniverseDomain = parameters.UniverseDomain,
                });
            }
            else if (!string.IsNullOrEmpty(parameters.CredentialSourceConfig.Url))
            {
                var initializer = new UrlSourcedExternalAccountCredential.Initializer(
                    parameters.TokenUrl, parameters.Audience, parameters.SubjectTokenType, parameters.CredentialSourceConfig.Url)
                {
                    QuotaProject = parameters.QuotaProject,
                    ServiceAccountImpersonationUrl = parameters.ServiceAccountImpersonationUrl,
                    WorkforcePoolUserProject = parameters.WorkforcePoolUserProject,
                    ClientId = parameters.ClientId,
                    ClientSecret = parameters.ClientSecret,
                    SubjectTokenJsonFieldName = parameters.ExtractSubjectTokenFieldName(),
                    UniverseDomain = parameters.UniverseDomain,
                };
                if (parameters.CredentialSourceConfig.Headers is object)
                {
                    foreach (var header in parameters.CredentialSourceConfig.Headers)
                    {
                        initializer.Headers.Add(header);
                    }
                }

                return new UrlSourcedExternalAccountCredential(initializer);
            }
            else
            {
                throw new InvalidOperationException("Unrecognized external credential configuration");
            }
        }

        private ImpersonatedCredential CreateImpersonatedServiceAccountCredentialFromParameters(JsonCredentialParameters parameters)
        {
            if (parameters.Type != JsonCredentialParameters.ImpersonatedServiceAccountCredentialType
                || parameters.SourceCredential is null
                || string.IsNullOrEmpty(parameters.ServiceAccountImpersonationUrl))
            {
                throw new InvalidOperationException("JSON data does not represent a valid impersonated service account credential.");
            }

            // If source credential is of a credential type that does not support impersonation, attemting to create the
            // impersonated credential will fail a few lines later.
            var sourceCredential = CreateDefaultCredentialFromParameters(parameters.SourceCredential);
            var maybeTargetPrincipal = ImpersonatedCredential.ExtractTargetPrincipal(parameters.ServiceAccountImpersonationUrl);
            var initializer = new ImpersonatedCredential.Initializer(parameters.ServiceAccountImpersonationUrl, maybeTargetPrincipal)
            {
                DelegateAccounts = parameters.Delegates?.Length > 0 ? parameters.Delegates.ToList() : null,
                QuotaProject = parameters.QuotaProject,
            };

            var impersonatedCredential = ImpersonatedCredential.Create(sourceCredential, initializer);
            if (parameters.UniverseDomain != parameters.SourceCredential.UniverseDomain)
            {
                return (impersonatedCredential as IGoogleCredential).WithUniverseDomain(parameters.UniverseDomain) as ImpersonatedCredential;
            }
            return impersonatedCredential;
        }

        private ExternalAccountAuthorizedUserCredential CreateExternalAccountAuthorizedUserCredentialFromParemeters(JsonCredentialParameters parameters)
        {
            if (parameters.Type != JsonCredentialParameters.ExternalAccountAuthorizedUserCredentialType
                || string.IsNullOrEmpty(parameters.TokenUrl)
                || string.IsNullOrEmpty(parameters.RefreshToken)
                || string.IsNullOrEmpty(parameters.ClientId)
                || string.IsNullOrEmpty(parameters.ClientSecret))
            {
                throw new InvalidOperationException("JSON data does not represent a valid external account authorized user credential.");
            }

            var initializer = new ExternalAccountAuthorizedUserCredential.Initializer(
                parameters.TokenUrl, parameters.RefreshToken, parameters.ClientId, parameters.ClientSecret)
            {
                Audience = parameters.Audience,
                QuotaProject = parameters.QuotaProject,
                TokenInfoUrl = parameters.TokenInfoUrl,
                UniverseDomain = parameters.UniverseDomain,
            };

            return new ExternalAccountAuthorizedUserCredential(initializer);
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
