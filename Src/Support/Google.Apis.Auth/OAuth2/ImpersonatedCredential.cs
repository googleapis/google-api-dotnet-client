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
using Google.Apis.Json;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    internal class ImpersonatedCredential : ServiceCredential, IOidcTokenProvider, IGoogleCredential, IBlobSigner
    {
        /// <summary>An initializer class for the impersonated credential. </summary>
        new internal class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// Gets or sets the source credential used to acquire the impersonated credentials.
            /// </summary>
            public GoogleCredential SourceCredential { get; set; }

            /// <summary>
            /// Gets or sets the impersonation options.
            /// </summary>
            public ImpersonationOptions Options { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="sourceCredential">The source credential used to acquire the impersonated credentials.</param>
            /// <param name="options">The impersonation options.</param>
            public Initializer(GoogleCredential sourceCredential, ImpersonationOptions options)
                : base(string.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, options.TargetPrincipal))
            { 
                SourceCredential = sourceCredential;
                Options = options;
            }

            internal Initializer(ImpersonatedCredential other) : base(other.TokenServerUrl)
            {
                SourceCredential = other.SourceCredential;
                Options = other.Options;
            }
        }

        /// <summary>
        /// Gets the source credential used to acquire the impersonated credentials.
        /// </summary>
        public GoogleCredential SourceCredential { get; }

        /// <summary>
        /// Gets the impersonation options.
        /// </summary>
        public ImpersonationOptions Options { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => Options?.Scopes?.Any() == true;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => true;

        /// <summary>Constructs a new impersonated credential using the given initializer.</summary>
        internal ImpersonatedCredential(Initializer initializer) : base(initializer)
        {
            SourceCredential = initializer.SourceCredential.ThrowIfNull("initializer.SourceCredential");
            if (!(SourceCredential.UnderlyingCredential is UserCredential || SourceCredential.UnderlyingCredential is ServiceAccountCredential))
            {
                throw new InvalidOperationException("The underlying credential of source credential must be UserCredential or ServiceAccountCredential.");
            }
            SourceCredential = SourceCredential.CreateScoped(new string[] {GoogleAuthConsts.IamScope});
            HttpClient.MessageHandler.Credential = SourceCredential.UnderlyingCredential as Http.IHttpExecuteInterceptor;
            Options = initializer.Options;
        }

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new ImpersonatedCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new ImpersonatedCredential(new Initializer(this)
            {
                Options = Options.WithScopes(scopes)
            });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(ImpersonatedCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var request = new ImpersonationAccessTokenRequest
            {
                DelegateAccounts = Options.DelegateAccounts,
                Scopes = Options.Scopes,
                Lifetime = ((int)Options.Lifetime.TotalSeconds).ToString() + "s"
            };
            var body = NewtonsoftJsonSerializer.Instance.Serialize(request);
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            
            var response = await HttpClient.PostAsync(TokenServerUrl, content, taskCancellationToken).ConfigureAwait(false);
            var newToken = await TokenResponse.FromHttpResponseAsync(response, Clock, Logger).ConfigureAwait(false);
            Token = newToken;
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
                DelegateAccounts = Options.DelegateAccounts,
                Audience = oidcTokenOptions.TargetAudience,
                IncludeEmail = true
            };
            var body = NewtonsoftJsonSerializer.Instance.Serialize(request);
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            
            var oidcTokenUrl = String.Format(GoogleAuthConsts.IamIdTokenEndpointFormatString, Options.TargetPrincipal);
            var response = await HttpClient.PostAsync(oidcTokenUrl, content, cancellationToken).ConfigureAwait(false);
            caller.Token = await TokenResponse.FromHttpResponseAsync(response, Clock, Logger).ConfigureAwait(false);
            return true;
        }

        /// <summary>
        /// Signs the provided blob using the private key associated with the impersonated service account.
        /// </summary>
        /// <param name="blob">The blob to sign.</param>
        /// <param name="cancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>The base64 encoded signature.</returns>
        /// <exception cref="HttpRequestException">When signing request fails.</exception>
        /// <exception cref="Newtonsoft.Json.JsonException">When signing response is not a valid JSON.</exception>
        public async Task<string> SignBlobAsync(byte[] blob, CancellationToken cancellationToken = default)
        {
            var request = new
            {
                delegates = Options.DelegateAccounts,
                payload = blob
            };
            var body = new StringContent(NewtonsoftJsonSerializer.Instance.Serialize(request), Encoding.UTF8, "application/json");
            
            var signBlobUrl = String.Format(GoogleAuthConsts.IamSignEndpointFormatString, Options.TargetPrincipal);
            
            var response = await HttpClient.PostAsync(signBlobUrl, body, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var signBlobResponse = NewtonsoftJsonSerializer.Instance.Deserialize<SignBlobResponse>(content);
            return signBlobResponse.SignedBlob;
        }

        internal class SignBlobResponse
        {
            /// <summary>Gets or sets the signed blob.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("signedBlob")]
            public string SignedBlob { get; set; }
        }
    }
}
