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
    public sealed class ImpersonatedCredential : ServiceCredential, IOidcTokenProvider, IGoogleCredential, IBlobSigner
    {
        /// <summary>An initializer class for the impersonated credential. </summary>
        new public sealed class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// Gets the service account to impersonate.
            /// </summary>
            public string TargetPrincipal { get; }

            /// <summary>
            /// Gets the chained list of delegate service accounts. May be null or empty.
            /// </summary>
            public IEnumerable<string> DelegateAccounts { get; set; }

            /// <summary>
            /// Gets the scopes to request during the authorization grant. May be null or empty.
            /// </summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets for how long the delegated credential should be valid.
            /// Defaults to 1 hour or 3600 seconds.
            /// </summary>
            public TimeSpan Lifetime { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="targetPrincipal">The principal that will be impersonated. Must not be null.</param>
            public Initializer(string targetPrincipal)
                : base(string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, targetPrincipal.ThrowIfNull(nameof(targetPrincipal))))
            {
                TargetPrincipal = targetPrincipal;
                Lifetime = TimeSpan.FromHours(1);
            }

            internal Initializer(ImpersonatedCredential other) : base(other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts;
                Scopes = other.Scopes;
                Lifetime = other.Lifetime;
            }

            internal Initializer(Initializer other) : base (other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts?.ToList().AsReadOnly() ?? Enumerable.Empty<string>();
                Scopes = other.Scopes?.ToList().AsReadOnly() ?? Enumerable.Empty<string>();
                Lifetime = other.Lifetime;
            }
        }

        /// <summary>
        /// Gets the source credential used to acquire the impersonated credentials.
        /// </summary>
        public GoogleCredential SourceCredential => HttpClientInitializers.OfType<GoogleCredential>().Single();

        /// <summary>
        /// Gets the service account to impersonate.
        /// </summary>
        public string TargetPrincipal { get; }

        /// <summary>
        /// Gets the chained list of delegate service accounts. May be empty.
        /// </summary>
        public IEnumerable<string> DelegateAccounts { get; }

        /// <summary>
        /// Gets the scopes to request during the authorization grant. May be empty.
        /// </summary>
        public IEnumerable<string> Scopes { get; }

        /// <summary>
        /// Gets the lifetime of the delegated credential.
        /// This is how long the delegated credential should be valid from the time
        /// of the first request made with this credential.
        /// </summary>
        public TimeSpan Lifetime { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => Scopes?.Any() == true;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => true;

        internal static ImpersonatedCredential Create(GoogleCredential sourceCredential, Initializer initializer)
        {
            initializer.ThrowIfNull(nameof(initializer));
            sourceCredential.ThrowIfNull(nameof(sourceCredential));
            if (initializer.Lifetime < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(initializer.Lifetime), $"Must be greater or equal to {nameof(TimeSpan.Zero)}");
            }
            if (!(sourceCredential.UnderlyingCredential is ServiceAccountCredential || sourceCredential.UnderlyingCredential is UserCredential))
            {
                throw new InvalidOperationException($"Only {nameof(ServiceAccountCredential)} and {nameof(UserCredential)} support impersonation.");
            }

            // We ourselves modify the client supplied initializer, so let's make a copy first.
            initializer = new Initializer(initializer);

            initializer.HttpClientInitializers.Add(sourceCredential.CreateScoped(new string[] { GoogleAuthConsts.IamScope }));
            return new ImpersonatedCredential(initializer);
        }

        /// <summary>Constructs a new impersonated credential using the given initializer.</summary>
        private ImpersonatedCredential(Initializer initializer) : base(initializer)
        {
            TargetPrincipal = initializer.TargetPrincipal;
            // We just copied tha initializer on the Create method so we know this
            // to be our own local copy. We can avoid copying these collections here.
            DelegateAccounts = initializer.DelegateAccounts;
            Scopes = initializer.Scopes;
            Lifetime = initializer.Lifetime;
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

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var request = new ImpersonationAccessTokenRequest
            {
                DelegateAccounts = DelegateAccounts,
                Scopes = Scopes,
                Lifetime = $"{(int)Lifetime.TotalSeconds}s"
            };

            Token = await request.ExecuteAsync(HttpClient, TokenServerUrl, Clock, Logger, taskCancellationToken)
                .ConfigureAwait(false);

            return true;
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
