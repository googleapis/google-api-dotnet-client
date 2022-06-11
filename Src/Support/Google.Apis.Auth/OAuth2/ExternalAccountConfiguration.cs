/*
Copyright 2022 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Holds the configuration for an external account credential.
    /// </summary>
    public abstract class ExternalAccountConfiguration
    {
        private protected ExternalAccountConfiguration() { }

        /// <summary>
        /// The STS audience which contains the resource name for the
        /// workload identity pool or the workforce pool
        /// and the provider identifier in that pool.
        /// </summary>
        public abstract string Audience { get; }

        /// <summary>
        /// The STS subject token type based on the OAuth 2.0 token exchange spec.
        /// </summary>
        public abstract string SubjectTokenType { get; }

        /// <summary>
        /// The STS token exchange endpoint.
        /// </summary>
        public abstract string TokenUrl { get; }

        /// <summary>
        /// This is the URL for the service account impersonation request.
        /// If this is not available, the STS-returned access token
        /// should be directly used without impersonation.
        /// </summary>
        public abstract string ServiceAccountImpersonationUrl { get; }

        /// <summary>
        /// The endpoint used to retrieve the account related information (eg. email, username, uid, etc).
        /// This is needed for gCloud session account identification.
        /// </summary>
        public abstract string TokenInfoUrl { get; }

        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        public abstract string QuotaProject { get; }

        /// <summary>
        /// The Client ID.
        /// </summary>
        /// <remarks>
        /// Client ID and Client secret are currently only required if the token info endpoint
        /// needs to be called with the generated GCP access token.
        /// When provided, STS will be called with additional basic authentication using
        /// ClientId as username and ClientSecret as password.
        /// </remarks>
        public abstract string ClientId { get; }

        /// <summary>
        /// The client secret.
        /// </summary>
        /// <remarks>
        /// Client ID and Client secret are currently only required if the token info endpoint
        /// needs to be called with the generated GCP access token.
        /// When provided, STS will be called with additional basic authentication using
        /// ClientId as username and ClientSecret as password.
        /// </remarks>
        public abstract string ClientSecret { get; }
    }
}
