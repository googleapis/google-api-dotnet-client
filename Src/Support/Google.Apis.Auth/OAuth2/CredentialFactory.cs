/*
Copyright 2025 Google Inc

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
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// A Google credential factory. 
    /// </summary>
    public static class CredentialFactory
    {
        /// <summary>
        /// Creates a credential of the specified type from a file that contains JSON credential data.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="credentialPath">The path to the credential file.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task that will be completed with the created credential.</returns>
        public static async Task<T> FromFileAsync<T>(string credentialPath, CancellationToken cancellationToken) =>
            await FromStreamAsync<T>(File.OpenRead(credentialPath), cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a credential of the specified type from a file that contains JSON credential data.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="credentialPath">The path to the credential file.</param>
        /// <returns>The created credential.</returns>
        public static T FromFile<T>(string credentialPath) => FromStream<T>(File.OpenRead(credentialPath));

        /// <summary>
        /// Creates a credential of the specified type from a stream that contains JSON credential data.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="stream">The stream that contains the JSON credential data.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task that will be completed with the created credential.</returns>
        public static async Task<T> FromStreamAsync<T>(Stream stream, CancellationToken cancellationToken) =>
            FromJsonParameters<T>(await WrapDeserializationAsync(() =>
                NewtonsoftJsonSerializer.Instance.DeserializeAsync<JsonCredentialParameters>(stream, cancellationToken)).ConfigureAwait(false));

        /// <summary>
        /// Creates a credential of the specified type from a stream that contains JSON credential data.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="stream">The stream that contains the JSON credential data.</param>
        /// <returns>The created credential.</returns>
        public static T FromStream<T>(Stream stream) =>
            FromJsonParameters<T>(WrapDeserialization(() =>
                NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(stream)));

        /// <summary>
        /// Creates a credential of the specified type from a string that contains JSON credential data.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="json">The string that contains the JSON credential data.</param>
        /// <returns>The created credential.</returns>
        public static T FromJson<T>(string json) =>
            FromJsonParameters<T>(WrapDeserialization(() =>
                NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(json)));

        /// <summary>
        /// Creates a credential of the specified type from JSON credential parameters.
        /// </summary>
        /// <typeparam name="T">The type of the credential to create.</typeparam>
        /// <param name="credentialParameters">The JSON credential parameters.</param>
        /// <returns>The created credential.</returns>
        internal static T FromJsonParameters<T>(JsonCredentialParameters credentialParameters) =>
            MaybeAs<T>(credentialParameters.ThrowIfNull(nameof(credentialParameters)).Type switch
            {
                JsonCredentialParameters.AuthorizedUserCredentialType => CreateUserCredentialFromParameters(credentialParameters),
                JsonCredentialParameters.ServiceAccountCredentialType => CreateServiceAccountCredentialFromParameters(credentialParameters),
                JsonCredentialParameters.ExternalAccountCredentialType => CreateExternalCredentialFromParameters(credentialParameters),
                JsonCredentialParameters.ImpersonatedServiceAccountCredentialType => CreateImpersonatedServiceAccountCredentialFromParameters(credentialParameters),
                JsonCredentialParameters.ExternalAccountAuthorizedUserCredentialType => CreateExternalAccountAuthorizedUserCredentialFromParemeters(credentialParameters),
                _ => throw new InvalidOperationException($"Error creating credential from JSON or JSON parameters. Unrecognized credential type {credentialParameters.Type}."),
            });

        /// <summary>
        /// Wraps a synchronous deserialization function with common error handling.
        /// </summary>
        /// <typeparam name="TResult">The type of the result returned by the deserializer.</typeparam>
        /// <param name="deserializer">The synchronous function that performs the deserialization.</param>
        /// <returns>The deserialized object.</returns>
        private static TResult WrapDeserialization<TResult>(Func<TResult> deserializer)
        {
            try
            {
                return deserializer();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
        }

        /// <summary>
        /// Wraps an asynchronous deserialization function with common error handling.
        /// </summary>
        /// <typeparam name="TResult">The type of the result returned by the deserializer.</typeparam>
        /// <param name="deserializer">The asynchronous function that performs the deserialization.</param>
        /// <returns>A task that will be completed with the deserialized object.</returns>
        private static async Task<TResult> WrapDeserializationAsync<TResult>(Func<Task<TResult>> deserializer)
        {
            try
            {
                return await deserializer().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error deserializing JSON credential data.", e);
            }
        }

        /// <summary>
        /// Creates a user credential from JSON data.
        /// </summary>
        /// <param name="credentialParameters">The JSON credential data.</param>
        /// <returns>The created credential.</returns>
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

        /// <summary>
        /// Creates a <see cref="ServiceAccountCredential"/> from JSON data.
        /// </summary>
        /// <param name="credentialParameters">The JSON credential data.</param>
        /// <returns>The created credential.</returns>
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
        /// <param name="parameters">The JSON credential data.</param>
        /// <returns>The created credential.</returns>
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

        /// <summary>
        /// Creates an impersonated credential from JSON data.
        /// </summary>
        /// <param name="parameters">The JSON credential data.</param>
        /// <returns>The created credential.</returns>
        private static ImpersonatedCredential CreateImpersonatedServiceAccountCredentialFromParameters(JsonCredentialParameters parameters)
        {
            if (parameters.Type != JsonCredentialParameters.ImpersonatedServiceAccountCredentialType
                || parameters.SourceCredential is null
                || string.IsNullOrEmpty(parameters.ServiceAccountImpersonationUrl))
            {
                throw new InvalidOperationException("JSON data does not represent a valid impersonated service account credential.");
            }

            // If source credential is of a credential type that does not support impersonation, attemting to create the
            // impersonated credential will fail a few lines later.
            var sourceCredential = FromJsonParameters<IGoogleCredential>(parameters.SourceCredential);
            var maybeTargetPrincipal = ImpersonatedCredential.ExtractTargetPrincipal(parameters.ServiceAccountImpersonationUrl);
            var initializer = new ImpersonatedCredential.Initializer(parameters.ServiceAccountImpersonationUrl, maybeTargetPrincipal)
            {
                DelegateAccounts = parameters.Delegates?.Length > 0 ? parameters.Delegates.ToList() : null,
                QuotaProject = parameters.QuotaProject,
            };

            var impersonatedCredential = ImpersonatedCredential.Create(sourceCredential.ToGoogleCredential(), initializer);
            if (parameters.UniverseDomain != parameters.SourceCredential.UniverseDomain)
            {
                return (impersonatedCredential as IGoogleCredential).WithUniverseDomain(parameters.UniverseDomain) as ImpersonatedCredential;
            }
            return impersonatedCredential;
        }

        /// <summary>
        /// Creates an external account authorized user credential from JSON data.
        /// </summary>
        /// <param name="parameters">The JSON credential data.</param>
        /// <returns>The created credential.</returns>
        private static ExternalAccountAuthorizedUserCredential CreateExternalAccountAuthorizedUserCredentialFromParemeters(JsonCredentialParameters parameters)
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
        /// Casts to the specified credential type from a <see cref="IGoogleCredential"/>.
        /// </summary>
        /// <typeparam name="T">The type of the underlying credential to return.</typeparam>
        /// <param name="credential">The <see cref="IGoogleCredential"/> that will be cast to the specified credential type.</param>
        /// <returns>The credential.</returns>
        private static T MaybeAs<T>(IGoogleCredential credential) =>
            credential is T credentialAsT
                ? credentialAsT
                : throw new InvalidOperationException(
                    $"The credential data represents a '{credential.GetType().Name}' " +
                    $"which cannot be converted to the requested credential type '{typeof(T).Name}'.");
    }
}
