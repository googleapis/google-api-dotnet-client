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

using System;

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

        /// <summary>The Compute Engine authorization token server URL</summary>
        /// <remarks>IP address instead of name to avoid DNS resolution</remarks>
        public const string ComputeTokenUrl = DefaultMetadataServerUrl + ComputeTokenUrlSuffix;

        /// <summary>The path to the Google revocation endpoint.</summary>
        public const string RevokeTokenUrl = "https://oauth2.googleapis.com/revoke";

        /// <summary>The OpenID Connect Json Web Key Set (jwks) URL.</summary>
        public const string JsonWebKeySetUrl = "https://www.googleapis.com/oauth2/v3/certs";

        /// <summary>The IAP Json Web Key Set (jwks) URL.</summary>
        public const string IapKeySetUrl = "https://www.gstatic.com/iap/verify/public_key-jwk";

        /// <summary>Installed application redirect URI.</summary>
        public const string InstalledAppRedirectUri = "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>Installed application localhost redirect URI.</summary>
        public const string LocalhostRedirectUri = "http://localhost";

        /// <summary>IAM access token endpoint for service account.</summary>
        internal const string IamServiceAccountEndpointCommonPrefix = "https://iamcredentials.googleapis.com/v1/projects/-/serviceAccounts/";

        /// <summary>IAM access token endpoint format string. To use it insert the service account email.</summary>
        internal const string IamAccessTokenEndpointFormatString = IamServiceAccountEndpointCommonPrefix + "{0}:generateAccessToken";

        /// <summary>IAM signBlob endpoint format string. To use it insert the service account email.</summary>
        internal const string IamSignEndpointFormatString = IamServiceAccountEndpointCommonPrefix + "{0}:signBlob";

        /// <summary>IAM ID token endpoint format string. To use it insert the service account email.</summary>
        internal const string IamIdTokenEndpointFormatString = IamServiceAccountEndpointCommonPrefix + "{0}:generateIdToken";

        /// <summary>Scope needed for source credential in impersonated credential.</summary>
        internal const string IamScope = "https://www.googleapis.com/auth/iam";

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
        /// The effective Compute Engine metadata token server URL (with no path).
        /// This takes account of the GCE_METADATA_HOST environment variable.
        /// </summary>
        internal static string EffectiveMetadataServerUrl => GetEffectiveMetadataUrl(null, DefaultMetadataServerUrl);

        private static string GetEffectiveMetadataUrl(string suffix, string defaultValue)
        {
            string env = Environment.GetEnvironmentVariable("GCE_METADATA_HOST");
            return string.IsNullOrEmpty(env) ? defaultValue : "http://" + env + suffix;
        }
    }
}