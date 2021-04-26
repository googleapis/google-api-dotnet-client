/*
Copyright 2021 Google Inc

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
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// ImpersonatedCredentials allowing credentials issued to a user or service account to impersonate 
    /// another. The source project using ImpersonatedCredentials must enable the "IAMCredentials" API.
    /// Also, the target service account must grant the originating principal the "Service Account Token
    /// Creator" IAM role. 
    /// <para>
    /// Take a look in https://cloud.google.com/iam/credentials/reference/rest/ for more details.
    /// </para>
    /// </summary>
    public class ImpersonatedCredential : ServiceCredential, IOidcTokenProvider, IGoogleCredential
    {
        /// <summary>An initializer class for the impersonated credential. </summary>
        new internal class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// Gets or sets the source credential used as to acquire the impersonated credentials.
            /// </summary>
            public GoogleCredential SourceCredential { get; set; }

            /// <summary>
            /// Gets or sets the service account to impersonate.
            /// </summary>
            public string TargetPrincipal { get; set; }

            /// <summary>
            /// Gets or sets the chained list of delegate service accounts.
            /// </summary>
            public IEnumerable<string> DelegateAccounts { get; set; }

            /// <summary>
            /// Gets or sets the scopes to request during the authorization grant.
            /// </summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets the how long the delegated credential should be valid.
            /// </summary>
            public TimeSpan Lifetime { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="sourceCredential">The source credential used as to acquire the impersonated credentials.</param>
            /// <param name="targetPrincipal">The service account to impersonate.</param>
            /// <param name="lifetime">
            /// The life time of the delegated credential should be valid.
            /// By default this value should be at most 3600 seconds. However, you can follow
            /// https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth
            /// to set up the service account and extend the maximum lifetime to 43200 seconds or 12 hours).
            /// If lifetime is not given, 3600 seconds will be used by default.
            /// </param>
            /// <param name="delegateAccounts">The chained list of delegate service accounts.</param>
            /// <param name="scopes">The scopes to request during the authorization grant.</param>
            public Initializer(GoogleCredential sourceCredential, string targetPrincipal, TimeSpan? lifetime,
                IEnumerable<string> delegateAccounts, IEnumerable<string> scopes)
                : base(String.Format(GoogleAuthConsts.IamAccessTokenEndpointFormatString, targetPrincipal))
            { 
                SourceCredential = sourceCredential;
                TargetPrincipal = targetPrincipal;
                DelegateAccounts = delegateAccounts;
                Scopes = scopes;
                Lifetime = lifetime.HasValue ? lifetime.Value : new TimeSpan(1, 0, 0);
                if (Lifetime > new TimeSpan(12, 0, 0))
                {
                    throw new ArgumentOutOfRangeException("lifetime", "Lifetime must be less than or equal to 43200 seconds or 12 hours.");
                }
            }

            internal Initializer(ImpersonatedCredential other) : base(other.TokenServerUrl)
            {
                SourceCredential = other.SourceCredential;
                TargetPrincipal = other.TargetPrincipal;
                DelegateAccounts = other.DelegateAccounts;
                Scopes = other.Scopes;
                Lifetime = other.Lifetime;
            }
        }

        /// <summary>
        /// Gets the source credential used as to acquire the impersonated credentials.
        /// </summary>
        public GoogleCredential SourceCredential { get; }

        /// <summary>
        /// Gets the service account to impersonate.
        /// </summary>
        public string TargetPrincipal { get; }

        /// <summary>
        /// Gets the chained list of delegate service accounts.
        /// </summary>
        public IEnumerable<string> DelegateAccounts { get; }

        /// <summary>
        /// Gets the scopes to request during the authorization grant.
        /// </summary>
        public IEnumerable<string> Scopes { get; }

        /// <summary>
        /// Gets how long the delegated credential should be valid.
        /// </summary>
        public TimeSpan Lifetime { get; }

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
            
            TargetPrincipal = initializer.TargetPrincipal.ThrowIfNullOrEmpty("initializer.TargetPrincipal");
            DelegateAccounts = initializer.DelegateAccounts;
            Scopes = initializer.Scopes;
            Lifetime = initializer.Lifetime;
        }

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new ImpersonatedCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var bodyJson = new
            {
                delegates = DelegateAccounts,
                scope = Scopes,
                lifetime = ((int)Lifetime.TotalSeconds).ToString() + "s"
            };
            var body = NewtonsoftJsonSerializer.Instance.Serialize(bodyJson);
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

        private async Task<bool> RefreshOidcTokenAsync(TokenRefreshManager caller, OidcTokenOptions options, CancellationToken cancellationToken)
        {
            var bodyJson = new
            {
                delegates = DelegateAccounts,
                audience = options.TargetAudience,
                includeEmail = true
            };
            var body = NewtonsoftJsonSerializer.Instance.Serialize(bodyJson);
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            
            var oidcTokenUrl = String.Format(GoogleAuthConsts.IamIdTokenEndpointFormatString, TargetPrincipal);
            var response = await HttpClient.PostAsync(oidcTokenUrl, content, cancellationToken).ConfigureAwait(false);
            caller.Token = await TokenResponse.FromHttpResponseAsync(response, Clock, Logger).ConfigureAwait(false);
            return true;
        }

        /// <summary>
        /// Signs the provided bytes using the private key associated with the impersonated service account.
        /// </summary>
        /// <param name="bytesToSign">The bytes to sign.</param>
        /// <param name="cancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>The signed bytes.</returns>
        /// <exception cref="SignBlobResponseException">When signing request fails.</exception>
        public async Task<byte[]> SignBytes(byte[] bytesToSign, CancellationToken cancellationToken = default) {
            var bodyJson = new
            {
                delegates = DelegateAccounts,
                payload = bytesToSign
            };
            var body = new StringContent(NewtonsoftJsonSerializer.Instance.Serialize(bodyJson), Encoding.UTF8, "application/json");
            
            var signBlobUrl = String.Format(GoogleAuthConsts.IamSignEndpointFormatString, TargetPrincipal);
            
            var response = await HttpClient.PostAsync(signBlobUrl, body, cancellationToken).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new SignBlobResponseException(content, response.StatusCode);
            }
            try
            {
                var signBlobResponse = NewtonsoftJsonSerializer.Instance.Deserialize<SignBlobResponse>(content);
                return Convert.FromBase64String(signBlobResponse.SignedBlob);
            }
            catch (Newtonsoft.Json.JsonException)
            {
                throw new SignBlobResponseException("Server response does not contain a JSON object.", response.StatusCode);
            }
        }

        /// <summary>
        /// IAM signblob endpoint response exception.
        /// </summary>
        public class SignBlobResponseException : Exception
        {
            /// <summary>The error information.</summary>
            public string Error { get; }

            /// <summary>HTTP status code of error.</summary>
            public HttpStatusCode StatusCode { get; }

            /// <summary>Constructs a new exception instance from the given error and HTTP status code.</summary>
            public SignBlobResponseException(string error, HttpStatusCode statusCode)
                : base(error)
            {
                Error = error;
                StatusCode = statusCode;
            }
        }

        internal class SignBlobResponse
        {
            /// <summary>Gets or sets the signed blob.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("signedBlob")]
            public string SignedBlob { get; set; }
        }
    }
}
