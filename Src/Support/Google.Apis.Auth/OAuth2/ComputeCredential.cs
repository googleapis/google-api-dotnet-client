/*
Copyright 2014 Google Inc

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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Google OAuth 2.0 credential for accessing protected resources using an access token. The Google OAuth 2.0 
    /// Authorization Server supports server-to-server interactions such as those between a web application and Google
    /// Cloud Storage. The requesting application has to prove its own identity to gain access to an API, and an 
    /// end-user doesn't have to be involved. 
    /// <para>
    /// More details about Compute Engine authentication is available at:
    /// https://cloud.google.com/compute/docs/authentication.
    /// </para>
    /// </summary>
    public class ComputeCredential : ServiceCredential, IOidcTokenProvider, IGoogleCredential, IBlobSigner
    {
        /// <summary>The metadata server url. This can be overridden (for the purposes of Compute environment detection and
        /// auth token retrieval) using the GCE_METADATA_HOST environment variable.</summary>
        public const string MetadataServerUrl = GoogleAuthConsts.DefaultMetadataServerUrl;

        /// <summary>Caches result from first call to <c>IsRunningOnComputeEngine</c> </summary>
        private readonly static Lazy<Task<bool>> isRunningOnComputeEngineCached = new Lazy<Task<bool>>(
            () => IsRunningOnComputeEngineNoCache());

        /// <summary>
        /// Originally 1000ms was used without a retry. This proved inadequate; even 2000ms without
        /// a retry occasionally failed. We have observed that after a timeout, the next attempt
        /// succeeds very quickly (sub-50ms) which suggests that this should be fine.
        /// </summary>
        private const int MetadataServerPingTimeoutInMilliseconds = 500;

        private const int MetadataServerPingAttempts = 3;

        /// <summary>The Metadata flavor header name.</summary>
        internal const string MetadataFlavor = "Metadata-Flavor";

        /// <summary>The Metadata header response indicating Google.</summary>
        internal const string GoogleMetadataHeader = "Google";

        /// <summary>
        /// Caches the task that fetches the default service account email from the metadata server.
        /// The default service account email can be cached because changing the service
        /// account associated to a Compute instance requires a machine shutdown.
        /// </summary>
        private readonly Lazy<Task<string>> _defaultServiceAccountEmailCache;

        /// <summary>
        /// HttpClient used to call APIs internally authenticated as this ComputeCredential.
        /// For instance, to perform IAM API calls for signing blobs of data.
        /// </summary>
        /// <remarks>Lazy to build one HtppClient only if it is needed.</remarks>
        private readonly Lazy<ConfigurableHttpClient> _authenticatedHttpClient;

        /// <summary>
        /// Gets the OIDC Token URL.
        /// </summary>
        public string OidcTokenUrl { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => true;

        internal string EffectiveTokenServerUrl { get; }

        /// <summary>
        /// An initializer class for the Compute credential. It uses <see cref="GoogleAuthConsts.ComputeTokenUrl"/>
        /// as the token server URL (optionally overriding the host using the GCE_METADATA_HOST environment variable).
        /// </summary>
        new public class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// Gets the OIDC Token URL.
            /// </summary>
            public string OidcTokenUrl { get; }

            /// <summary>Constructs a new initializer using the default compute token URL
            /// and the default OIDC token URL.</summary>
            public Initializer()
                : this(GoogleAuthConsts.EffectiveComputeTokenUrl) {}

            /// <summary>Constructs a new initializer using the given token URL
            /// and the default OIDC token URL.</summary>
            public Initializer(string tokenUrl)
                : this(tokenUrl, GoogleAuthConsts.EffectiveComputeOidcTokenUrl) {}

            /// <summary>Constructs a new initializer using the given token URL
            /// and OIDC token URL (optionally overriding the host using the GCE_METADATA_HOST environment variable).</summary>
            public Initializer(string tokenUrl, string oidcTokenUrl)
                : base(tokenUrl) => OidcTokenUrl = oidcTokenUrl;

            internal Initializer(ComputeCredential other)
                : base(other) => OidcTokenUrl = other.OidcTokenUrl;
        }

        /// <summary>Constructs a new Compute credential instance.</summary>
        public ComputeCredential() : this(new Initializer()) { }

        /// <summary>Constructs a new Compute credential instance.</summary>
        public ComputeCredential(Initializer initializer) : base(initializer)
        {
            OidcTokenUrl = initializer.OidcTokenUrl;
            if (HasExplicitScopes)
            {
                var uriBuilder = new UriBuilder(TokenServerUrl);
                string scopesQuery = $"scopes={string.Join(",", Scopes)}";

                // As per https://docs.microsoft.com/en-us/dotnet/api/system.uribuilder.query?view=net-6.0#examples
                if (uriBuilder.Query is null || uriBuilder.Query.Length <= 1)
                {
                    uriBuilder.Query = scopesQuery;
                }
                else
                {
                    uriBuilder.Query = $"{uriBuilder.Query.Substring(1)}&{scopesQuery}";
                }
                EffectiveTokenServerUrl = uriBuilder.Uri.AbsoluteUri;
            }
            else
            {
                EffectiveTokenServerUrl = TokenServerUrl;
            }
            _defaultServiceAccountEmailCache = new Lazy<Task<string>>(FetchDefaultServiceAccountEmailAsync, LazyThreadSafetyMode.ExecutionAndPublication);
            _authenticatedHttpClient = new Lazy<ConfigurableHttpClient>(BuildAuthenticatedHttpClient, LazyThreadSafetyMode.ExecutionAndPublication);
        }

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new ComputeCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new ComputeCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(ComputeCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new ComputeCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

        /// <summary>
        /// Returns a task whose result, when completed, is the default service account email associated to
        /// this Compute credential.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This value is cached, because for changing the default service account associated to a
        /// Compute VM, the machine needs to be turned off. This means that the operation is only
        /// asynchronous when calling for the first time.
        /// </para>
        /// <para>
        /// Note that if, when fetching this value, an exception is thrown, the exception is cached and
        /// will be rethrown by the task returned by any future call to this method.
        /// You can create a new <see cref="ComputeCredential"/> instance if that happens so fetching
        /// the service account default email is re-attempted.
        /// </para>
        /// </remarks>
        public Task<string> GetDefaultServiceAccountEmailAsync(CancellationToken cancellationToken = default) =>
            Task.Run(() => _defaultServiceAccountEmailCache.Value, cancellationToken);

        #region ServiceCredential overrides

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            // Create and send the HTTP request to compute server token URL.
            using var httpRequest = new HttpRequestMessage(HttpMethod.Get, EffectiveTokenServerUrl);
            httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);
            using var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            Token = await TokenResponse.FromHttpResponseAsync(response, Clock, Logger).ConfigureAwait(false);
            return true;
        }

        #endregion

        /// <inheritdoc/>
        public Task<OidcToken> GetOidcTokenAsync(OidcTokenOptions options, CancellationToken cancellationToken = default)
        {
            options.ThrowIfNull(nameof(options));
            // If at some point some properties are added to OidcToken that depend on the token having been fetched
            // then initialize the token here.
            TokenRefreshManager tokenRefreshManager = null;
            tokenRefreshManager = new TokenRefreshManager(
                ct => RefreshOidcTokenAsync(tokenRefreshManager, options, ct), Clock, Logger);
            return Task.FromResult(new OidcToken(tokenRefreshManager));
        }

        private async Task<bool> RefreshOidcTokenAsync(TokenRefreshManager caller, OidcTokenOptions options, CancellationToken cancellationToken)
        {
            string uri = $"{OidcTokenUrl}?audience={options.TargetAudience}";
            if (options.TokenFormat == OidcTokenFormat.Full || options.TokenFormat == OidcTokenFormat.FullWithLicences)
            {
                uri = $"{uri}&format=full";
                if (options.TokenFormat == OidcTokenFormat.FullWithLicences)
                {
                    uri = $"{uri}&licenses=true";
                }
            }

            using var httpRequest = new HttpRequestMessage(HttpMethod.Get, uri);
            httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);

            using var response = await HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            var token = await TokenResponse.FromHttpResponseAsync(response, Clock, Logger).ConfigureAwait(false);
            caller.Token = token;
            return true;
        }

        /// <summary>
        /// Signs the provided blob using the private key associated with the service account
        /// this ComputeCredential represents.
        /// </summary>
        /// <param name="blob">The blob to sign.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>The base64 encoded signature.</returns>
        /// <exception cref="HttpRequestException">When the signing request fails.</exception>
        /// <exception cref="JsonException">When the signing response is not valid JSON.</exception>
        /// <remarks>
        /// The private key associated with the Compute service account is not known locally
        /// by a ComputeCredential. Signing happens by executing a request to the IAM Credentials API
        /// which increases latency and counts towards IAM Credentials API quotas. Aditionally, the first
        /// time a ComputeCredential is used to sign data, a request to the metadata server is made to
        /// to obtain the email of the default Compute service account.
        /// </remarks>
        public async Task<string> SignBlobAsync(byte[] blob, CancellationToken cancellationToken = default)
        {
            var request = new IamSignBlobRequest { Payload = blob };
            var serviceAccountEmail = await GetDefaultServiceAccountEmailAsync(cancellationToken).ConfigureAwait(false);
            var signBlobUrl = string.Format(GoogleAuthConsts.IamSignEndpointFormatString, serviceAccountEmail);

            var response = await request.PostJsonAsync<IamSignBlobResponse>(_authenticatedHttpClient.Value, signBlobUrl, cancellationToken)
                .ConfigureAwait(false);

            return response.SignedBlob;
        }

        private async Task<string> FetchDefaultServiceAccountEmailAsync()
        {
            using var httpRequest = new HttpRequestMessage(HttpMethod.Get, GoogleAuthConsts.EffectiveComputeDefaultServiceAccountEmailUrl);
            httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);

            using var response = await HttpClient.SendAsync(httpRequest).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        private ConfigurableHttpClient BuildAuthenticatedHttpClient()
        {
            var httpClientArgs = BuildCreateHttpClientArgs();
            // We scope the credential because, although normal ComputeCredentials are scoped on origin,
            // GKE Workload Identity credentials accept scopes.
            // We know that the HttpClient is only used for IAM requests, so we scope it only for IAM.
            var scopedCredential = ((IGoogleCredential)this).MaybeWithScopes(new string[] { GoogleAuthConsts.IamScope });
            httpClientArgs.Initializers.Add(scopedCredential);
            return HttpClientFactory.CreateHttpClient(httpClientArgs);
        }

        /// <summary>
        /// Detects if application is running on Google Compute Engine. This is achieved by attempting to contact
        /// GCE metadata server, that is only available on GCE. The check is only performed the first time you
        /// call this method, subsequent invocations used cached result of the first call.
        /// </summary>
        public static Task<bool> IsRunningOnComputeEngine()
        {
            return isRunningOnComputeEngineCached.Value;
        }

        private static async Task<bool> IsRunningOnComputeEngineNoCache()
        {
            Logger.Info("Checking connectivity to ComputeEngine metadata server.");

            // Using the built-in HttpClient, as we want bare bones functionality - we'll control retries.
            // Use the same one across all attempts, which may contribute to speedier retries.
            using (var httpClient = new HttpClient())
            {
                for (int i = 0; i < MetadataServerPingAttempts; i++)
                {
                    var cts = new CancellationTokenSource();
                    cts.CancelAfter(MetadataServerPingTimeoutInMilliseconds);
                    try
                    {
                        using var httpRequest = new HttpRequestMessage(HttpMethod.Get, GoogleAuthConsts.EffectiveMetadataServerUrl);
                        httpRequest.Headers.Add(MetadataFlavor, GoogleMetadataHeader);
                        using var response = await httpClient.SendAsync(httpRequest, cts.Token).ConfigureAwait(false);
                        if (response.Headers.TryGetValues(MetadataFlavor, out var headerValues)
                            && headerValues.Contains(GoogleMetadataHeader))
                        {
                            return true;
                        }

                        // Response came from another source, possibly a proxy server in the caller's network.
                        Logger.Info("Response came from a source other than the Google Compute Engine metadata server.");
                        return false;
                    }
                    catch (Exception e) when (e is HttpRequestException || e is WebException || e is OperationCanceledException)
                    {
                        // We'll retry, but let's log the exception.
                        // We may eventually want to handle the different exception types in different ways,
                        // e.g. returning false rather than retrying for some exception types. However,
                        // for now it's safe just to retry.
                        Logger.Debug(
                            "An exception ocurred while attempting to reach Google's metadata service on attempt {0}. " +
                            "A total of {1} attempts will be made. " +
                            "The exception was: {2}.",
                            i + 1, MetadataServerPingAttempts, e);
                    }
                }
            }
            // Only log after all attempts have failed.
            Logger.Debug("Could not reach the Google Compute Engine metadata service. That is expected if this application is not running on GCE.");
            return false;
        }
    }
}
