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
            private static readonly TimeSpan DefaultLifetime = TimeSpan.FromHours(1);

            /// <summary>
            /// Gets the service account to impersonate.
            /// </summary>
            public string TargetPrincipal { get; }

            /// <summary>
            /// Gets the chained list of delegate service accounts. May be null or empty.
            /// </summary>
            public IEnumerable<string> DelegateAccounts { get; set; }

            /// <summary>
            /// Gets or sets for how long the delegated credential should be valid.
            /// Defaults to 1 hour or 3600 seconds.
            /// </summary>
            public TimeSpan Lifetime { get; set; } = DefaultLifetime;

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="targetPrincipal">The principal that will be impersonated. Must not be null, as it will be used
            /// to build the URL to obtaing the impersonated access token from.</param>
            public Initializer(string targetPrincipal)
                // We cannot build the token URL just yet, we need the universe domain and that comes from the source credential.
                // In this case, we'll defer creating the token URL to the first access token request.
                : base(tokenServerUrl: null) =>
                TargetPrincipal = targetPrincipal.ThrowIfNull(nameof(targetPrincipal));

            /// <summary>
            /// Constructus a new initializer.
            /// </summary>
            /// <param name="customTokenUrl">The URL to obtain the impersonated access token from.</param>
            /// <param name="maybeTargetPrincipal">The target principal, if known, that will be impersonated. May be null.</param>
            /// <remarks>Because the <paramref name="customTokenUrl"/> is all that is needed for obtaining the impersonated
            /// access token, <paramref name="maybeTargetPrincipal"/> is just informational when the
            /// <see cref="Initializer(string, string)"/> constructor overload is used.</remarks>
            internal Initializer(string customTokenUrl, string maybeTargetPrincipal)
                : base(customTokenUrl.ThrowIfNullOrEmpty(nameof(customTokenUrl))) =>
                TargetPrincipal = maybeTargetPrincipal;

            internal Initializer(ImpersonatedCredential other) : base(other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts;
                Lifetime = other.Lifetime;
            }

            internal Initializer(Initializer other) : base (other)
            {
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts?.ToList().AsReadOnly() ?? Enumerable.Empty<string>();
                Lifetime = other.Lifetime;
            }
        }

        /// <summary>
        /// The id token URL.
        /// If this credential does not have a custom access token URL, the id token is supported through the IAM API.
        /// The id token URL is built using the universe domain and the target principal.
        /// </summary>
        private readonly Lazy<Task<string>> _oidcTokenUrlCache;

        /// <summary>
        /// The blob signing URL.
        /// If this credential does not have a custom access token URL, blob signing is supported through the IAM API.
        /// The blob signing URL is built using the universe domain and the target principal.
        /// </summary>
        private readonly Lazy<Task<string>> _signBlobUrlCache;

        /// <summary>
        /// HttpClient used to call the IAM sign blob endpoint, authenticated as this credential.
        /// </summary>
        /// <remarks>Lazy to build one HtppClient only if it is needed.</remarks>
        private readonly Lazy<ConfigurableHttpClient> _signBlobHttpClient;

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
        /// Gets the lifetime of the delegated credential.
        /// This is how long the delegated credential should be valid from the time
        /// of the first request made with this credential.
        /// </summary>
        public TimeSpan Lifetime { get; }

        /// <summary>
        /// Whether the effective access token URL is custom or not.
        /// If the impersonated credential has a custom access token URL we don't know how the OIDC URL and blob signing
        /// URL may look like, so we cannot support those operations.
        /// </summary>
        internal Lazy<Task<bool>> HasCustomTokenUrlCache { get; }

        /// <summary>
        /// The effective token URL to be used by this credential, which may be a custom token URL
        /// or the IAM API access token endpoint URL which is built using the universe domain and the
        /// target principal of this credential.
        /// </summary>
        internal Lazy<Task<string>> EffectiveTokenUrlCache { get; }

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
            if (!(sourceCredential.UnderlyingCredential is ServiceAccountCredential 
                || sourceCredential.UnderlyingCredential is UserCredential
                || sourceCredential.UnderlyingCredential is ExternalAccountCredential
                || sourceCredential.UnderlyingCredential is ComputeCredential))
            {
                throw new InvalidOperationException(
                    $"Only {nameof(ServiceAccountCredential)}," +
                    $"{nameof(UserCredential)}, " +
                    $"{nameof(ExternalAccountCredential)} " +
                    $"and {nameof(ComputeCredential)} support impersonation.");
            }
            if (sourceCredential.UnderlyingCredential is ExternalAccountCredential externalCred && externalCred.ServiceAccountImpersonationUrl is string)
            {
                throw new InvalidOperationException($"Only {nameof(ExternalAccountCredential)}s that have no impersonation configured via service_account_impersonation_url support explicit impersonation.");
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
            Lifetime = initializer.Lifetime;

            EffectiveTokenUrlCache = new Lazy<Task<string>>(GetEffectiveTokenUrlUncachedAsync);
            HasCustomTokenUrlCache = new Lazy<Task<bool>>(HasCustomTokenUrlUncachedAsync);
            _oidcTokenUrlCache = new Lazy<Task<string>>(GetIdTokenUrlUncachedAsync);
            _signBlobUrlCache = new Lazy<Task<string>>(GetSignBlobUrlUncachedAsync);
            _signBlobHttpClient = new Lazy<ConfigurableHttpClient>(BuildSignBlobHttpClientUncached);
        }

        /// <inheritdoc/>
        Task<string> IGoogleCredential.GetUniverseDomainAsync(CancellationToken cancellationToken) =>
            SourceCredential.GetUniverseDomainAsync(cancellationToken);

        /// <inheritdoc/>
        string IGoogleCredential.GetUniverseDomain() => SourceCredential.GetUniverseDomain();

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
        IGoogleCredential IGoogleCredential.WithUniverseDomain(string universeDomain)
        {
            var newCredential = SourceCredential.CreateWithUniverseDomain(universeDomain);
            var newInitializer = new Initializer(this);

            // Now we detach the new initializer from this instance's source credential by removing it from HTTP client initializers.
            newInitializer.HttpClientInitializers.Remove(SourceCredential);

            return Create(newCredential, newInitializer);
        }

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var request = new IamAccessTokenRequest
            {
                DelegateAccounts = DelegateAccounts,
                Scopes = Scopes,
                Lifetime = $"{(int)Lifetime.TotalSeconds}s"
            };

            string effectiveTokenUrl = await EffectiveTokenUrlCache.Value.WithCancellationToken(taskCancellationToken).ConfigureAwait(false);

            Token = await request.PostJsonAsync(HttpClient, effectiveTokenUrl, Clock, Logger, taskCancellationToken)
                .ConfigureAwait(false);

            return true;
        }

        /// <inheritdoc/>
        public async Task<OidcToken> GetOidcTokenAsync(OidcTokenOptions options, CancellationToken cancellationToken = default)
        {
            await ThrowIfCustomTokenUrlAsync(cancellationToken).ConfigureAwait(false);

            options.ThrowIfNull(nameof(options));
            // If at some point some properties are added to OidcToken that depend on the token having been fetched
            // then initialize the token here.
            TokenRefreshManager tokenRefreshManager = null;
            tokenRefreshManager = new TokenRefreshManager(ct => RefreshOidcTokenAsync(tokenRefreshManager, options, ct), Clock, Logger);
            return new OidcToken(tokenRefreshManager);
        }

        private async Task<bool> RefreshOidcTokenAsync(TokenRefreshManager caller, OidcTokenOptions oidcTokenOptions, CancellationToken cancellationToken)
        {
            await ThrowIfCustomTokenUrlAsync(cancellationToken).ConfigureAwait(false);

            var request = new IamOIdCTokenRequest
            {
                DelegateAccounts = DelegateAccounts,
                Audience = oidcTokenOptions.TargetAudience,
                IncludeEmail = true
            };
            var oidcTokenUrl = await _oidcTokenUrlCache.Value.WithCancellationToken(cancellationToken).ConfigureAwait(false);

            caller.Token = await request.PostJsonAsync(HttpClient, oidcTokenUrl, Clock, Logger, cancellationToken)
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
            await ThrowIfCustomTokenUrlAsync(cancellationToken).ConfigureAwait(false);

            var request = new IamSignBlobRequest
            {
                DelegateAccounts = DelegateAccounts,
                Payload = blob
            };
            var signBlobUrl = await _signBlobUrlCache.Value.WithCancellationToken(cancellationToken).ConfigureAwait(false);

            var response = await request.PostJsonAsync<IamSignBlobResponse>(_signBlobHttpClient.Value, signBlobUrl, cancellationToken)
                .ConfigureAwait(false);

            return response.SignedBlob;
        }

        /// <summary>
        /// Returns the token URL to be used by this credential, which may be a custom token URL
        /// or the IAM API access token endpoint URL which is built using the universe domain and the
        /// target principal of this credential.
        /// A custom access token URL could be present in external credentials configuration.
        /// </summary>
        private async Task<string> GetEffectiveTokenUrlUncachedAsync()
        {
            if (TokenServerUrl is not null)
            {
                // This is either a custom token URL or a default token URL for a credential other than ComputeCredential,
                // i.e. we could calculate the endpoint synchronusly on credential creation.
                return TokenServerUrl;
            }
            string universeDomain = await (this as IGoogleCredential).GetUniverseDomainAsync(cancellationToken: default).ConfigureAwait(false);
            return GetDefaultTokenUrl(universeDomain, TargetPrincipal);
        }

        /// <summary>
        /// Determines whether the effective access token URL is custom or not.
        /// If the impersonated credential has a custom access token URL we don't know how the OIDC URL and blob signing
        /// URL may look like, so we cannot support those operations.
        /// </summary>
        private async Task<bool> HasCustomTokenUrlUncachedAsync()
        {
            string effectiveTokenUrl = await EffectiveTokenUrlCache.Value.ConfigureAwait(false);
            string universeDomain = await (this as IGoogleCredential).GetUniverseDomainAsync(cancellationToken: default).ConfigureAwait(false);

            return effectiveTokenUrl != GetDefaultTokenUrl(universeDomain, TargetPrincipal);
        }

        /// <summary>
        /// Gets the id token URL if this credential supports id token emission.
        /// Throws <see cref="InvalidOperationException"/> otherwise.
        /// </summary>
        private async Task<string> GetIdTokenUrlUncachedAsync()
        {
            await ThrowIfCustomTokenUrlAsync(cancellationToken: default).ConfigureAwait(false);

            string universeDomain = await (this as IGoogleCredential).GetUniverseDomainAsync(cancellationToken: default).ConfigureAwait(false);
            return string.Format(GoogleAuthConsts.IamIdTokenEndpointFormatString, universeDomain, TargetPrincipal);
        }

        /// <summary>
        /// Get's the blob signing URL if this credential supports blob signing.
        /// Throws <see cref="InvalidOperationException"/> otherwise.
        /// </summary>
        private async Task<string> GetSignBlobUrlUncachedAsync()
        {
            await ThrowIfCustomTokenUrlAsync(cancellationToken: default).ConfigureAwait(false);

            string universeDomain = await (this as IGoogleCredential).GetUniverseDomainAsync(cancellationToken: default).ConfigureAwait(false);
            return string.Format(GoogleAuthConsts.IamSignEndpointFormatString, universeDomain, TargetPrincipal);
        }

        private ConfigurableHttpClient BuildSignBlobHttpClientUncached()
        {
            var httpClientArgs = BuildCreateHttpClientArgsWithNoRetries();
            AddIamSignBlobRetryConfiguration(httpClientArgs);
            return HttpClientFactory.CreateHttpClient(httpClientArgs);
        }

        /// <summary>
        /// If the impersonated credential has a custom access token URL we don't know how the OIDC URL and blob signing
        /// URL may look like, so we cannot support those operations.
        /// A custom access token URL could be present in external credentials configuration.
        /// </summary>
        private async Task ThrowIfCustomTokenUrlAsync(CancellationToken cancellationToken)
        {
            bool hasCustomTokenUrl = await HasCustomTokenUrlCache.Value.WithCancellationToken(cancellationToken).ConfigureAwait(false);

            if (hasCustomTokenUrl)
            {
                // If the impersonated credential has a custom access token URL we don't know how the OIDC URL and blob signing
                // URL may look like, so we cannot support those operations.
                throw new InvalidOperationException("Operation not supported when a custom access token URL has been specified.");
            }
        }

        private static string GetDefaultTokenUrl(string universeDomain, string targetPrincipal) =>
            string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, universeDomain, targetPrincipal);

        /// <summary>
        /// Attempts to extract the target principal ID from the impersonation URL which is possible if the URL looks like
        /// https://host/segment-1/.../segment-n/target-principal-ID:generateAccessToken.
        /// It's OK if we can't though as for fetching the impersonated access token we have the impersonation URL as a whole.
        /// It's just a nice to have, as the user may be able to execute extra operations with the impersonated credential, like
        /// signing a blob of fetching its OIDC token.
        /// </summary>
        internal static string ExtractTargetPrincipal(string url)
        {
            int start = url.LastIndexOf('/') + 1;
            if (start == 0 || start >= url.Length)
            {
                return null;
            }
            int afterEnd = url.IndexOf($":{GoogleAuthConsts.IamAccessTokenVerb}", StringComparison.Ordinal);
            if (afterEnd == -1 || afterEnd <= start)
            {
                return null;
            }
            return url.Substring(start, afterEnd - start);
        }
    }
}
