/*
Copyright 2013 Google Inc

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

using Google.Apis.Http;
using Google.Apis.Util;
using System;
using System.Net;
using System.Net.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Google OAuth2 constants.
    /// Canonical source for these URLs is: https://accounts.google.com/.well-known/openid-configuration
    /// </summary>
    public static class GoogleAuthConsts
    {
        /// <summary>The authorization code server URL.</summary>
        public const string AuthorizationUrl = "https://accounts.google.com/o/oauth2/auth";

        /// <summary>The OpenID Connect authorization code server URL.</summary>
        /// <remarks>
        /// Use of this <see cref="OidcAuthorizationUrl"/> is not 100% compatible with using
        /// <see cref="AuthorizationUrl"/>, so they are two distinct URLs.
        /// Internally within this library only this more up-to-date <see cref="OidcAuthorizationUrl"/> is used.
        /// </remarks>
        public const string OidcAuthorizationUrl = "https://accounts.google.com/o/oauth2/v2/auth";

        /// <summary>The approval URL (used in the Windows solution as a callback).</summary>
        public const string ApprovalUrl = "https://accounts.google.com/o/oauth2/approval";

        /// <summary>The authorization token server URL.</summary>
        public const string TokenUrl = "https://accounts.google.com/o/oauth2/token";

        /// <summary>The OpenID Connect authorization token server URL.</summary>
        /// <remarks>
        /// Use of this <see cref="OidcTokenUrl"/> is not 100% compatible with using
        /// <see cref="TokenUrl"/>, so they are two distinct URLs.
        /// Internally within this library only this more up-to-date <see cref="OidcTokenUrl"/> is used.
        /// </remarks>
        public const string OidcTokenUrl = "https://oauth2.googleapis.com/token";

        // Constant strings to avoid duplication below.
        // IP address instead of name to avoid DNS resolution
        private const string DefaultMetadataAddress = "169.254.169.254";
        internal const string DefaultMetadataServerUrl = "http://" + DefaultMetadataAddress;
        private const string ComputeTokenUrlSuffix = "/computeMetadata/v1/instance/service-accounts/default/token";
        private const string ComputeOidcTokenUrlSuffix = "/computeMetadata/v1/instance/service-accounts/default/identity";
        private const string ComputeDefaultServiceAccountEmailSuffix = "/computeMetadata/v1/instance/service-accounts/default/email";
        private const string ComputeUniverseDomainUrlSuffix = "/computeMetadata/v1/universe/universe-domain";

        /// <summary>The Compute Engine authorization token server URL</summary>
        /// <remarks>IP address instead of name to avoid DNS resolution</remarks>
        public const string ComputeTokenUrl = DefaultMetadataServerUrl + ComputeTokenUrlSuffix;

        /// <summary>The path to the Google revocation endpoint.</summary>
        public const string RevokeTokenUrl = "https://oauth2.googleapis.com/revoke";

        /// <summary>The OpenID Connect Json Web Key Set (jwks) URL.</summary>
        public const string JsonWebKeySetUrl = "https://www.googleapis.com/oauth2/v3/certs";

        /// <summary>The IAP Json Web Key Set (jwks) URL.</summary>
        public const string IapKeySetUrl = "https://www.gstatic.com/iap/verify/public_key-jwk";

        /// <summary>Installed application localhost redirect URI.</summary>
        public const string LocalhostRedirectUri = "http://localhost";

        internal const string IamServiceHostPrefix = "https://iamcredentials.";

        /// <summary>IAM access token endpoint for service account.</summary>
        internal const string IamServiceAccountEndpointCommonPrefixFormat = $"{IamServiceHostPrefix}{{0}}/v1/projects/-/serviceAccounts/";

        /// <summary>IAM access token verb.</summary>
        internal const string IamAccessTokenVerb = "generateAccessToken";

        /// <summary>IAM access token endpoint format string. To use it insert the service account email.</summary>
        internal const string IamAccessTokenEndpointFormatString = $"{IamServiceAccountEndpointCommonPrefixFormat}{{1}}:{IamAccessTokenVerb}";

        /// <summary>IAM signBlob endpoint format string. To use it insert the service account email.</summary>
        internal const string IamSignEndpointFormatString = $"{IamServiceAccountEndpointCommonPrefixFormat}{{1}}:signBlob";

        /// <summary>IAM ID token endpoint format string. To use it insert the service account email.</summary>
        internal const string IamIdTokenEndpointFormatString = $"{IamServiceAccountEndpointCommonPrefixFormat}{{1}}:generateIdToken";

        /// <summary>Scope needed for source credential in impersonated credential.</summary>
        internal const string IamScope = "https://www.googleapis.com/auth/iam";

        /// <summary>
        /// Name of the environment variable that will be checked for an ambient quota project ID.
        /// If set, this value will be applied to Application Default Credentials.
        /// </summary>
        public const string QuotaProjectEnvironmentVariable = "GOOGLE_CLOUD_QUOTA_PROJECT";

        /// <summary>
        /// The default universe domain.
        /// </summary>
        internal const string DefaultUniverseDomain = "googleapis.com";

        /// <summary>
        /// Key for a universe domain in a <see cref="HttpRequestMessage"/> options.
        /// </summary>
        internal const string UniverseDomainKey = "__UniverseDomainKey";

        /// <summary>
        /// The non empty value set on <see cref="QuotaProjectEnvironmentVariable"/>, if any;
        /// null otherwise.
        /// </summary>
        internal static string EnvironmentQuotaProject =>
            Environment.GetEnvironmentVariable(QuotaProjectEnvironmentVariable) is string environmentQuotaProject && environmentQuotaProject != ""
            ? environmentQuotaProject
            : null;

        /// <summary>
        /// The effective Compute Engine authorization token server URL.
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveComputeTokenUrl => GetEffectiveMetadataUrl(ComputeTokenUrlSuffix, ComputeTokenUrl);

        /// <summary>
        /// The effective Compute Engine authorization token server URL for OIDC. This requires an audience parameter to be added.
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveComputeOidcTokenUrl => GetEffectiveMetadataUrl(ComputeOidcTokenUrlSuffix, DefaultMetadataServerUrl + ComputeOidcTokenUrlSuffix);

        /// <summary>
        /// The effective Compute Engine default service account email URL.
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveComputeDefaultServiceAccountEmailUrl =>
            GetEffectiveMetadataUrl(ComputeDefaultServiceAccountEmailSuffix, DefaultMetadataServerUrl + ComputeDefaultServiceAccountEmailSuffix);

        /// <summary>
        /// The effective Compute Engine universe domain URL.
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveComputeUniverDomainUrl =>
            GetEffectiveMetadataUrl(ComputeUniverseDomainUrlSuffix, DefaultMetadataServerUrl + ComputeUniverseDomainUrlSuffix);

        /// <summary>
        /// The effective Compute Engine metadata token server URL (with no path).
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveMetadataServerUrl => GetEffectiveMetadataUrl(null, DefaultMetadataServerUrl);

        /// <summary>
        /// Retry strategy recommended for the OAuth2 token endpoints.
        /// </summary>
        internal static ExponentialBackOffInitializer OAuth2TokenEndpointRecommendedRetry { get; } = new ExponentialBackOffInitializer(
            ExponentialBackOffPolicy.RecommendedOrDefault,
            () => new BackOffHandler(new BackOffHandler.Initializer(ExponentialBackOff.FromDeltaBackOffPercent(deltaBackOffPercent: 10, maximumNumOfRetries: 3))
            {
                // Give the back-off strategy control over how much to wait for.
                MaxTimeSpan = TimeSpan.MaxValue,
                HandleExceptionFunc = ex => false,
                HandleUnsuccessfulResponseFunc = response =>
                    response.StatusCode == HttpStatusCode.RequestTimeout || // 408
                    (int) response.StatusCode == 429 || // 429 Enum value not available in .NET Standard 2.0 or .NET Framework 4.6.2. This is "Too many requests".
                    response.StatusCode == HttpStatusCode.InternalServerError || // 500
                    response.StatusCode == HttpStatusCode.ServiceUnavailable, // 503
            }));

        /// <summary>
        /// If <paramref name="originalPolicy"/> has the <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> flag, the returned value
        /// will be identical to <paramref name="originalPolicy"/> except it won't have the <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> or
        /// <see cref="ExponentialBackOffPolicy.UnsuccessfulResponse503"/> flags. Otherwise, the returned value will be <paramref name="originalPolicy"/>.
        /// This method facilitate honoring any custom policies that may have been set. Calling code is resposible for honoring the recommended policies.
        /// </summary>
        internal static ExponentialBackOffPolicy StripOAuth2TokenEndpointRecommendedPolicy(ExponentialBackOffPolicy originalPolicy) =>
            originalPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault) ?
            // We remove 503 also because the recommended policy retries 503.
            originalPolicy & ~ExponentialBackOffPolicy.RecommendedOrDefault & ~ExponentialBackOffPolicy.UnsuccessfulResponse503 :
            originalPolicy;

        /// <summary>
        /// Retry strategy recommended for the OAuth2 token endpoints.
        /// </summary>
        internal static ExponentialBackOffInitializer IamSignBlobEndpointRecommendedRetry { get; } = new ExponentialBackOffInitializer(
            ExponentialBackOffPolicy.RecommendedOrDefault,
            () => new BackOffHandler(new BackOffHandler.Initializer(ExponentialBackOff.FromDeltaBackOffPercent(deltaBackOffPercent: 10, maximumNumOfRetries: 3))
            {
                // Give the back-off strategy control over how much to wait for.
                MaxTimeSpan = TimeSpan.MaxValue,
                HandleExceptionFunc = ex => false,
                HandleUnsuccessfulResponseFunc = response =>
                    response.StatusCode == HttpStatusCode.InternalServerError || // 500
                    response.StatusCode == HttpStatusCode.BadGateway || // 502
                    response.StatusCode == HttpStatusCode.ServiceUnavailable || // 503
                    response.StatusCode == HttpStatusCode.GatewayTimeout, // 504
            }));

        /// <summary>
        /// If <paramref name="originalPolicy"/> has the <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> flag, the returned value
        /// will be identical to <paramref name="originalPolicy"/> except it won't have the <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> or
        /// <see cref="ExponentialBackOffPolicy.UnsuccessfulResponse503"/> flags. Otherwise, the returned value will be <paramref name="originalPolicy"/>.
        /// This method facilitate honoring any custom policies that may have been set. Calling code is resposible for honoring the recommended policies.
        /// </summary>
        internal static ExponentialBackOffPolicy StripIamSignBlobEndpointRecommendedPolicy(ExponentialBackOffPolicy originalPolicy) =>
            originalPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault) ?
            // We remove 503 also because the recommended policy retries 503.
            originalPolicy & ~ExponentialBackOffPolicy.RecommendedOrDefault & ~ExponentialBackOffPolicy.UnsuccessfulResponse503 :
            originalPolicy;

        private static string GetEffectiveMetadataUrl(string suffix, string defaultValue)
        {
            string env = Environment.GetEnvironmentVariable("GCE_METADATA_HOST");
            return string.IsNullOrEmpty(env) ? defaultValue : "http://" + env + suffix;
        }

        /// <summary>
        /// Throws <see cref="InvalidOperationException"/> with <paramref name="message"/>
        /// if <paramref name="universeDomain"/> is not the default universe domain.
        /// </summary>
        internal static void CheckIsDefaultUniverseDomain(string universeDomain, string message)
        {
            if (universeDomain != DefaultUniverseDomain)
            {
                throw new InvalidOperationException(message);
            }
        }

        /// <summary>
        /// Throws <see cref="InvalidOperationException"/> with <paramref name="message"/>
        /// if <paramref name="universeDomain"/> is not the default universe domain and
        /// <paramref name="condition"/> is true.
        /// </summary>
        internal static void CheckIsDefaultUniverseDomain(string universeDomain, bool condition, string message)
        {
            if (universeDomain != DefaultUniverseDomain && condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}