/*
Copyright 2021 Google LLC

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
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Allows a service account or user credential to impersonate a service account.
    /// See https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials
    /// and https://cloud.google.com/iam/docs/impersonating-service-accounts
    /// for more information.
    /// </summary>
    public sealed class ImpersonatedCredential : ImpersonatedCredentialBase, IGoogleCredential, IOidcTokenProvider, IBlobSigner
    {
        /// <summary>An initializer class for the impersonated credential. </summary>
        new public sealed class Initializer : ImpersonatedCredentialBase.Initializer
        {
            /// <summary>
            /// Gets or sets the source credential used to acquire the impersonated credentials.
            /// </summary>
            internal new GoogleCredential SourceCredential => base.SourceCredential as GoogleCredential;

            /// <summary>
            /// Gets the service account to impersonate.
            /// </summary>
            public string TargetPrincipal { get; }

            /// <summary>
            /// Gets the chained list of delegate service accounts. May be null or empty.
            /// </summary>
            public IEnumerable<string> DelegateAccounts { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="targetPrincipal">The principal that will be impersonated. Must not be null.</param>
            public Initializer(string targetPrincipal)
                : base(string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, targetPrincipal.ThrowIfNull(nameof(targetPrincipal)))) =>
                TargetPrincipal = targetPrincipal;

            internal Initializer(ImpersonatedCredential other) : base(other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts;
            }

            internal Initializer(Initializer other) : base (other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts?.ToList().AsReadOnly() ?? Enumerable.Empty<string>();
            }

            /// <inheritdoc/>
            private protected override ICredential ValidateAndScopeForImpersonation(ICredential credential) => credential switch
            {
                null => null,
                GoogleCredential googleCred
                    when googleCred.UnderlyingCredential is ServiceAccountCredential || googleCred.UnderlyingCredential is UserCredential =>
                    googleCred.CreateScoped(ImpersonationScopes),
                ServiceAccountCredential saCred =>
                    new GoogleCredential((saCred as IGoogleCredential).MaybeWithScopes(ImpersonationScopes)),
                UserCredential userCred =>
                    new GoogleCredential((userCred as IGoogleCredential).MaybeWithScopes(ImpersonationScopes)),
                _ => throw new InvalidOperationException($"Only {nameof(ServiceAccountCredential)} and {nameof(UserCredential)} support impersonation.")
            };
        }

        /// <summary>
        /// Gets the source credential used to acquire the impersonated credentials.
        /// </summary>
        public new GoogleCredential SourceCredential => base.SourceCredential as GoogleCredential;

        /// <summary>
        /// Gets the service account to impersonate.
        /// </summary>
        public string TargetPrincipal { get; }

        /// <summary>
        /// Gets the chained list of delegate service accounts. May be empty.
        /// </summary>
        public IEnumerable<string> DelegateAccounts { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => true;

        /// <summary>Constructs a new impersonated credential using the given initializer.</summary>
        internal ImpersonatedCredential(Initializer initializer) : base(initializer)
        {
            TargetPrincipal = initializer.TargetPrincipal;
            DelegateAccounts = initializer.DelegateAccounts?.ToList().AsReadOnly() ?? Enumerable.Empty<string>();
        }

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new ImpersonatedCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new ImpersonatedCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(ImpersonatedCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new ImpersonatedCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

        internal override ImpersonationAccessTokenRequest CreateImpersonationAccessTokenRequest()
        {
            var request = base.CreateImpersonationAccessTokenRequest();
            request.DelegateAccounts = DelegateAccounts;
            return request;
        }

        /// <inheritdoc/>
        public Task<OidcToken> GetOidcTokenAsync(OidcTokenOptions options, CancellationToken cancellationToken = default)
        {
            options.ThrowIfNull(nameof(options));
            // If at some point some properties are added to OidcToken that depend on the token having been fetched
            // then initialize the token here.
            TokenRefreshManager tokenRefreshManager = null;
            tokenRefreshManager = new TokenRefreshManager(ct => RefreshOidcTokenAsync(tokenRefreshManager, options, ct), Clock, Logger);
            return Task.FromResult(new OidcToken(tokenRefreshManager));
        }

        private async Task<bool> RefreshOidcTokenAsync(TokenRefreshManager caller, OidcTokenOptions oidcTokenOptions, CancellationToken cancellationToken)
        {
            var request = new ImpersonationOIdCTokenRequest
            {
                DelegateAccounts = DelegateAccounts,
                Audience = oidcTokenOptions.TargetAudience,
                IncludeEmail = true
            };
            var oidcTokenUrl = string.Format(GoogleAuthConsts.IamIdTokenEndpointFormatString, TargetPrincipal);

            caller.Token = await request.ExecuteAsync(HttpClient, oidcTokenUrl, Clock, Logger, cancellationToken)
                .ConfigureAwait(false);

            return true;
        }

        /// <summary>
        /// Signs the provided blob using the private key associated with the impersonated service account.
        /// </summary>
        /// <param name="blob">The blob to sign.</param>
        /// <param name="cancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>The base64 encoded signature.</returns>
        /// <exception cref="HttpRequestException">When signing request fails.</exception>
        /// <exception cref="JsonException">When signing response is not a valid JSON.</exception>
        public async Task<string> SignBlobAsync(byte[] blob, CancellationToken cancellationToken = default)
        {
            var request = new ImpersonationSignBlobRequest
            {
                DelegateAccounts = DelegateAccounts,
                Payload = blob
            };
            var signBlobUrl = string.Format(GoogleAuthConsts.IamSignEndpointFormatString, TargetPrincipal);

            var response = await request.ExecuteAsync<ImpersonationSignBlobResponse>(HttpClient, signBlobUrl, cancellationToken)
                .ConfigureAwait(false);

            return response.SignedBlob;
        }
    }
}
