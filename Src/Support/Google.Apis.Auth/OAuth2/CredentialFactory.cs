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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2;

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
    public static async Task<T> FromFileAsync<T>(string credentialPath, CancellationToken cancellationToken)
    {
        using FileStream fileStream = File.OpenRead(credentialPath);
        return await FromStreamAsync<T>(fileStream, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a credential of the specified type from a file that contains JSON credential data.
    /// </summary>
    /// <param name="credentialPath">The path to the credential file.</param>
    /// <param name="credentialType">The type of credential to be loaded. Valid strings can be found in <see cref="JsonCredentialParameters"/>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that will be completed with the created credential.</returns>
    public static async Task<GoogleCredential> FromFileAsync(string credentialPath, string credentialType, CancellationToken cancellationToken)
    {
        using FileStream fileStream = File.OpenRead(credentialPath);
        return await FromStreamAsync(fileStream, credentialType, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a credential of the specified type from a file that contains JSON credential data.
    /// </summary>
    /// <typeparam name="T">The type of the credential to create.</typeparam>
    /// <param name="credentialPath">The path to the credential file.</param>
    /// <returns>The created credential.</returns>
    public static T FromFile<T>(string credentialPath)
    {
        using FileStream fileStream = File.OpenRead(credentialPath);
        return FromStream<T>(fileStream);
    }

    /// <summary>
    /// Creates a credential of the specified type from a file that contains JSON credential data.
    /// </summary>
    /// <param name="credentialPath">The path to the credential file.</param>
    /// <param name="credentialType">The type of credential to be loaded. Valid strings can be found in <see cref="JsonCredentialParameters"/>.</param>
    /// <returns>The created credential.</returns>
    public static GoogleCredential FromFile(string credentialPath, string credentialType)
    {
        using FileStream fileStream = File.OpenRead(credentialPath);
        return FromStream(fileStream, credentialType);
    }

    /// <summary>
    /// Creates a credential of the specified type from a stream that contains JSON credential data.
    /// </summary>
    /// <typeparam name="T">The type of the credential to create.</typeparam>
    /// <param name="stream">The stream that contains the JSON credential data.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that will be completed with the created credential.</returns>
    public static async Task<T> FromStreamAsync<T>(Stream stream, CancellationToken cancellationToken) =>
        FromJsonParameters<T>(await HandleDeserializationErrorsAsync(() =>
            NewtonsoftJsonSerializer.Instance.DeserializeAsync<JsonCredentialParameters>(stream, cancellationToken)).ConfigureAwait(false));

    /// <summary>
    /// Creates a credential of the specified type from a stream that contains JSON credential data.
    /// </summary>
    /// <param name="stream">The stream that contains the JSON credential data.</param>
    /// <param name="credentialType">The type of credential to be loaded. Valid strings can be found in <see cref="JsonCredentialParameters"/>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
    /// <returns>A task that will be completed with the created credential.</returns>
    public static async Task<GoogleCredential> FromStreamAsync(Stream stream, string credentialType, CancellationToken cancellationToken) =>
        FromJsonParameters(await HandleDeserializationErrorsAsync(() =>
            NewtonsoftJsonSerializer.Instance.DeserializeAsync<JsonCredentialParameters>(stream, cancellationToken)).ConfigureAwait(false), credentialType);

    /// <summary>
    /// Creates a credential of the specified type from a stream that contains JSON credential data.
    /// </summary>
    /// <typeparam name="T">The type of the credential to create.</typeparam>
    /// <param name="stream">The stream that contains the JSON credential data.</param>
    /// <returns>The created credential.</returns>
    public static T FromStream<T>(Stream stream) =>
        FromJsonParameters<T>(HandleDeserializationErrors(() =>
            NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(stream)));

    /// <summary>
    /// Creates a credential of the specified type from a stream that contains JSON credential data.
    /// </summary>
    /// <param name="stream">The stream that contains the JSON credential data.</param>
    /// <param name="credentialType">The type of credential to be loaded. Valid strings can be found in <see cref="JsonCredentialParameters"/>.</param>
    /// <returns>The created credential.</returns>
    public static GoogleCredential FromStream(Stream stream, string credentialType) =>
        FromJsonParameters(HandleDeserializationErrors(() =>
            NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(stream)), credentialType);

    /// <summary>
    /// Creates a credential of the specified type from a string that contains JSON credential data.
    /// </summary>
    /// <typeparam name="T">The type of the credential to create.</typeparam>
    /// <param name="json">The string that contains the JSON credential data.</param>
    /// <returns>The created credential.</returns>
    public static T FromJson<T>(string json) =>
        FromJsonParameters<T>(HandleDeserializationErrors(() =>
            NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(json)));

    /// <summary>
    /// Creates a credential of the specified type from a string that contains JSON credential data.
    /// </summary>
    /// <param name="json">The string that contains the JSON credential data.</param>
    /// <param name="credentialType">The type of credential to be loaded.</param>
    /// <returns>The created credential.</returns>
    public static GoogleCredential FromJson(string json, string credentialType) =>
        FromJsonParameters(HandleDeserializationErrors(() =>
            NewtonsoftJsonSerializer.Instance.Deserialize<JsonCredentialParameters>(json)), credentialType);

    /// <summary>
    /// Creates a credential of the specified type from JSON credential parameters.
    /// </summary>
    /// <typeparam name="T">The type of the credential to create.</typeparam>
    /// <param name="credentialParameters">The JSON credential parameters.</param>
    /// <returns>The created credential.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the credential `type` in <paramref name="credentialParameters"/> is unrecognized,
    /// if the credential data is incompatible with the requested type <typeparamref name="T"/>,
    /// or in the rare event of an internal logic error indicating a bug.
    /// </exception>
    internal static T FromJsonParameters<T>(JsonCredentialParameters credentialParameters)
    {
        if (CreateCredentialFromParameters(credentialParameters, typeof(T)) is T credentialAsT)
        {
            return credentialAsT;
        }

        throw new InvalidOperationException(
            $"Found incompatible credential types, '{credentialParameters.Type}' and '{typeof(T).FullName}, even though a check" 
          + " should have already taken place. We should never reach here, there's a bug in the code.");
    }

    /// <summary>
    /// Creates a credential of the specified type from JSON credential parameters.
    /// </summary>
    /// <param name="credentialParameters">The JSON credential parameters.</param>
    /// <param name="credentialType">The expected type of the credential.</param>
    /// <returns>The created credential.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown if the <paramref name="credentialType"/> is unrecognized,
    /// or if the credential data is incompatible with the requested type.
    /// </exception>
    internal static GoogleCredential FromJsonParameters(JsonCredentialParameters credentialParameters, string credentialType)
    {
        if (credentialParameters.Type != credentialType)
        {
            throw new InvalidOperationException($"Json data has type = '{credentialParameters.Type}', but type = '{credentialType}' was expected.");
        }

        // Type checking has already occurred so target type may be set to the generic IGoogleCredential which all credentials implement.
        Type targetType = typeof(IGoogleCredential);
        var rawCredentialType = CreateCredentialFromParameters(credentialParameters, targetType);

        return rawCredentialType.ToGoogleCredential();
    }

    private static IGoogleCredential CreateCredentialFromParameters(JsonCredentialParameters credentialParameters, Type targetCredentialType) =>
        credentialParameters.ThrowIfNull(nameof(credentialParameters)).Type switch
        {
            JsonCredentialParameters.AuthorizedUserCredentialType => CreateUserCredentialFromParameters(credentialParameters, targetCredentialType),
            JsonCredentialParameters.ServiceAccountCredentialType => CreateServiceAccountCredentialFromParameters(credentialParameters, targetCredentialType),
            JsonCredentialParameters.ExternalAccountCredentialType => CreateExternalCredentialFromParameters(credentialParameters, targetCredentialType),
            JsonCredentialParameters.ImpersonatedServiceAccountCredentialType => CreateImpersonatedServiceAccountCredentialFromParameters(credentialParameters, targetCredentialType),
            JsonCredentialParameters.ExternalAccountAuthorizedUserCredentialType => CreateExternalAccountAuthorizedUserCredentialFromParameters(credentialParameters, targetCredentialType),
            _ => throw new InvalidOperationException($"Error creating credential from JSON or JSON parameters. Unrecognized credential type {credentialParameters.Type}.")
        };

    private static T HandleDeserializationErrors<T>(Func<T> deserializationFunc)
    {
        try
        {
            return deserializationFunc();
        }
        catch (Exception e) when (e is Newtonsoft.Json.JsonException || e is IOException)
        {
            throw new InvalidOperationException("Error deserializing JSON credential data.", e);
        }
    }

    private static async Task<T> HandleDeserializationErrorsAsync<T>(Func<Task<T>> deserializationFuncAsync)
    {
        try
        {
            return await deserializationFuncAsync().ConfigureAwait(false);
        }
        catch (Exception e) when (e is Newtonsoft.Json.JsonException || e is IOException)
        {
            throw new InvalidOperationException("Error deserializing JSON credential data.", e);
        }
    }

    /// <summary>
    /// Validates actual type can be cast to target type.
    /// </summary>
    /// <param name="targetType"> The type to which we validate actualType can be cast to.</param>
    /// <param name="actualType"> The type to validate can be cast to the targetType.</param>
    /// <exception cref="InvalidOperationException">Thrown when targetType is not assignable from actual type.</exception>
    static void CheckCompatibility(Type targetType, Type actualType)
    {
        if(!targetType.IsAssignableFrom(actualType))
        {
            throw new InvalidOperationException($"The credential type {actualType.FullName} is not compatible with the requested type {targetType.FullName}");
        }
    }

    /// <summary>
    /// Creates a user credential from JSON data.
    /// </summary>
    /// <param name="credentialParameters">The JSON credential data.</param>
    /// <param name="targetType">The requested credential type.</param>
    /// <returns>The created credential.</returns>
    private static UserCredential CreateUserCredentialFromParameters(JsonCredentialParameters credentialParameters, Type targetType)
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
        CheckCompatibility(targetType, typeof(UserCredential));
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
    /// <param name="targetType">The requested credential type.</param>
    /// <returns>The created credential.</returns>
    private static ServiceAccountCredential CreateServiceAccountCredentialFromParameters(
        JsonCredentialParameters credentialParameters, Type targetType)
    {
        if (credentialParameters.Type != JsonCredentialParameters.ServiceAccountCredentialType ||
            string.IsNullOrEmpty(credentialParameters.ClientEmail) ||
            string.IsNullOrEmpty(credentialParameters.PrivateKey))
        {
            throw new InvalidOperationException("JSON data does not represent a valid service account credential.");
        }
        CheckCompatibility(targetType, typeof(ServiceAccountCredential));
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
    /// <param name="targetType">The requested credential type.</param>
    /// <returns>The created credential.</returns>
    private static IGoogleCredential CreateExternalCredentialFromParameters(JsonCredentialParameters parameters, Type targetType)
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
            CheckCompatibility(targetType, typeof(AwsExternalAccountCredential));

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
            CheckCompatibility(targetType, typeof(FileSourcedExternalAccountCredential));
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
            CheckCompatibility(targetType, typeof(UrlSourcedExternalAccountCredential));
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
    /// <param name="targetType">The requested credential type.</param>
    /// <returns>The created credential.</returns>
    private static ImpersonatedCredential CreateImpersonatedServiceAccountCredentialFromParameters(JsonCredentialParameters parameters, Type targetType)
    {
        if (parameters.Type != JsonCredentialParameters.ImpersonatedServiceAccountCredentialType
            || parameters.SourceCredential is null
            || string.IsNullOrEmpty(parameters.ServiceAccountImpersonationUrl))
        {
            throw new InvalidOperationException("JSON data does not represent a valid impersonated service account credential.");
        }
        CheckCompatibility(targetType, typeof(ImpersonatedCredential));

        // If source credential is of a credential type that does not support impersonation, attemting to create the
        // impersonated credential will fail a few lines later.
        var sourceCredential = FromJsonParameters<IGoogleCredential>(parameters.SourceCredential);
        var maybeTargetPrincipal = ImpersonatedCredential.ExtractTargetPrincipal(parameters.ServiceAccountImpersonationUrl);
        var initializer = new ImpersonatedCredential.Initializer(parameters.ServiceAccountImpersonationUrl, maybeTargetPrincipal)
        {
            DelegateAccounts = parameters.Delegates?.Length > 0 ? parameters.Delegates : null,
            QuotaProject = parameters.QuotaProject,
            Scopes = parameters.Scopes?.Length > 0 ? parameters.Scopes : null,
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
    /// <param name="targetType">The requested credential type.</param>
    /// <returns>The created credential.</returns>
    private static ExternalAccountAuthorizedUserCredential CreateExternalAccountAuthorizedUserCredentialFromParameters(JsonCredentialParameters parameters, Type targetType)
    {
        if (parameters.Type != JsonCredentialParameters.ExternalAccountAuthorizedUserCredentialType
            || string.IsNullOrEmpty(parameters.TokenUrl)
            || string.IsNullOrEmpty(parameters.RefreshToken)
            || string.IsNullOrEmpty(parameters.ClientId)
            || string.IsNullOrEmpty(parameters.ClientSecret))
        {
            throw new InvalidOperationException("JSON data does not represent a valid external account authorized user credential.");
        }
        CheckCompatibility(targetType, typeof(ExternalAccountAuthorizedUserCredential));

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
}
