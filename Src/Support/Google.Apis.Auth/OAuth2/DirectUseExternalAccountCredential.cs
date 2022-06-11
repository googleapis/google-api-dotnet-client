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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Base class for external account credentials used directly, i.e. without impersonation.
    /// </summary>
    internal abstract class DirectUseExternalAccountCredential : ServiceCredential, IExternalAccountCredential, IGoogleCredential
    {
        /// <summary>
        /// Initializer for <see cref="DirectUseExternalAccountCredential"/>.
        /// </summary>
        new public class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// The STS audience which contains the resource name for the
            /// workload identity pool or the workforce pool
            /// and the provider identifier in that pool.
            /// </summary>
            public string Audience { get; }

            /// <summary>
            /// The STS subject token type based on the OAuth 2.0 token exchange spec.
            /// </summary>
            public string SubjectTokenType { get; }

            /// <summary>
            /// The endpoint used to retrieve the account related information (eg. email, username, uid, etc).
            /// This is needed for gCloud session account identification.
            /// </summary>
            public string TokenInfoUrl { get; set; }

            /// <summary>
            /// The Client ID.
            /// </summary>
            /// <remarks>
            /// Client ID and client secret are currently only required if the token info endpoint
            /// needs to be called with the generated GCP access token.
            /// When provided, STS will be called with additional basic authentication using
            /// ClientId as username and ClientSecret as password.
            /// </remarks>
            public string ClientId { get; set; }

            /// <summary>
            /// The client secret.
            /// </summary>
            /// <remarks>
            /// Client ID and client secret are currently only required if the token info endpoint
            /// needs to be called with the generated GCP access token.
            /// When provided, STS will be called with additional basic authentication using
            /// ClientId as username and ClientSecret as password.
            /// </remarks>
            public string ClientSecret { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType) : base(tokenUrl)
            {
                Audience = audience;
                SubjectTokenType = subjectTokenType;
            }

            internal Initializer(Initializer other) : base(other)
            {
                Audience = other.Audience;
                SubjectTokenType = other.SubjectTokenType;
                TokenInfoUrl = other.TokenInfoUrl;
                ClientId = other.ClientId;
                ClientSecret = other.ClientSecret;
            }

            internal Initializer(DirectUseExternalAccountCredential other) : base(other)
            {
                Audience = other.Configuration.Audience;
                SubjectTokenType = other.Configuration.SubjectTokenType;
                TokenInfoUrl = other.Configuration.TokenInfoUrl;
                ClientId = other.Configuration.ClientId;
                ClientSecret = other.Configuration.ClientSecret;
            }
        }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        public bool SupportsExplicitScopes => true;

        /// <inheritdoc/>
        public ExternalAccountConfiguration Configuration { get; } 

        internal DirectUseExternalAccountCredential(Initializer initializer) : base(initializer) =>

            Configuration = new DirectUseExternalCredentialConfiguration(
                this, initializer.Audience, initializer.SubjectTokenType, initializer.TokenInfoUrl, initializer.ClientId, initializer.ClientSecret);

        /// <summary>
        /// Gets the subject token to be exchanged for the access token.
        /// </summary>
        protected abstract Task<string> GetSubjectTokenAsync(CancellationToken taskCancellationToken);

        /// <inheritdoc/>
        public async override Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            GoogleWifStsTokenRequest request = new GoogleWifStsTokenRequest
            {
                Audience = Configuration.Audience,
                Scope = HasExplicitScopes ? string.Join(" ", Scopes) : null,
                SubjectToken = await GetSubjectTokenAsync(taskCancellationToken).ConfigureAwait(false),
                SubjectTokenType = Configuration.SubjectTokenType,
                ClientId = Configuration.ClientId,
                ClientSecret = Configuration.ClientSecret,
            };

            var newToken = await request
                .ExecuteAsync(HttpClient, TokenServerUrl, Clock, Logger, taskCancellationToken)
                .ConfigureAwait(false);
            Token = newToken;
            return true;
        }

        /// <inheritdoc/>
        public abstract IGoogleCredential WithQuotaProject(string quotaProject);

        /// <inheritdoc/>
        public abstract IGoogleCredential MaybeWithScopes(IEnumerable<string> scopes);

        /// <inheritdoc/>
        public IGoogleCredential WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(IExternalAccountCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        public abstract IGoogleCredential WithHttpClientFactory(IHttpClientFactory httpClientFactory);

        private class DirectUseExternalCredentialConfiguration : ExternalAccountConfiguration
        {
            DirectUseExternalAccountCredential _credential;

            internal DirectUseExternalCredentialConfiguration(
                DirectUseExternalAccountCredential credential, string audience, string subjectTokenType, string tokenInfoUrl, string clientId, string clientSecret)
            {
                _credential = credential;
                Audience = audience;
                SubjectTokenType = subjectTokenType;
                TokenInfoUrl = tokenInfoUrl;
                ClientId = clientId;
                ClientSecret = clientSecret;
            }

            /// <inheritdoc/>
            public override string Audience { get; }

            /// <inheritdoc/>
            public override string SubjectTokenType { get; }

            /// <inheritdoc/>
            public override string TokenUrl => _credential.TokenServerUrl;

            /// <inheritdoc/>
            public override string ServiceAccountImpersonationUrl => null;

            /// <inheritdoc/>
            public override string TokenInfoUrl { get; }

            /// <inheritdoc/>
            public override string QuotaProject => _credential.QuotaProject;

            /// <inheritdoc/>
            public override string ClientId { get; }

            /// <inheritdoc/>
            public override string ClientSecret { get; }
        }
    }
}
