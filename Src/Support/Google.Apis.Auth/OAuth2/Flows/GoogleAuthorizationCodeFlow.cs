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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Google specific authorization code flow which inherits from <see cref="AuthorizationCodeFlow"/>.
    /// </summary>
    public class GoogleAuthorizationCodeFlow : AuthorizationCodeFlow, IHttpAuthorizationFlow
    {
        /// <summary>
        /// The project ID associated with the credential using this flow.
        /// </summary>
        public string ProjectId { get; private set; }

        private readonly string revokeTokenUrl;

        /// <summary>Gets the token revocation URL.</summary>
        public string RevokeTokenUrl { get { return revokeTokenUrl; } }

        /// <summary>Gets the include granted scopes indicator.
        /// Do not use, use <see cref="IncludeGrantedScopes"/> instead.</summary>
        public readonly bool? includeGrantedScopes;

        /// <summary>Gets the include granted scopes indicator.</summary>
        public bool? IncludeGrantedScopes { get { return includeGrantedScopes; } }

        /// <summary>Gets the login_hint.</summary>
        public string LoginHint { get; private set; }

        /// <summary>
        /// Gets the prompt for consent behaviour.
        /// Value can be <c>null</c>, <c>"none"</c>, <c>"consent"</c>, or <c>"select_account"</c>.
        /// See <a href="https://developers.google.com/identity/protocols/OpenIDConnect#prompt">OpenIDConnect documentation</a>
        /// for details.
        /// </summary>
        public string Prompt { get; private set; }

        /// <summary>Gets the nonce.</summary>
        public string Nonce { get; private set; }

        private readonly IEnumerable<KeyValuePair<string, string>> userDefinedQueryParams;

        /// <summary>Gets the user defined query parameters.</summary>
        public IEnumerable<KeyValuePair<string, string>> UserDefinedQueryParams
        { 
            get { return userDefinedQueryParams; } 
        }

        /// <summary>Constructs a new Google authorization code flow.</summary>
        public GoogleAuthorizationCodeFlow(Initializer initializer)
            : base(initializer)
        {
            ProjectId = initializer.ProjectId;
            revokeTokenUrl = initializer.RevokeTokenUrl;
            includeGrantedScopes = initializer.IncludeGrantedScopes;
            LoginHint = initializer.LoginHint;
            Prompt = initializer.Prompt;
            Nonce = initializer.Nonce;
            userDefinedQueryParams = initializer.UserDefinedQueryParams;
        }

        /// <inheritdoc/>
        // Note: we reimplement here to make sure we return a GoogleAuthorizationCodeFlow.
        IHttpAuthorizationFlow IHttpAuthorizationFlow.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new GoogleAuthorizationCodeFlow(new Initializer(this) { HttpClientFactory = httpClientFactory, });

        /// <inheritdoc/>
        public override AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
        {
            return new GoogleAuthorizationCodeRequestUrl(new Uri(AuthorizationServerUrl))
            {
                ClientId = ClientSecrets.ClientId,
                Scope = string.Join(" ", Scopes),
                RedirectUri = redirectUri,
                IncludeGrantedScopes = IncludeGrantedScopes.HasValue
                    ? IncludeGrantedScopes.Value.ToString().ToLower() : null,
                LoginHint = LoginHint,
                Prompt = Prompt,
                Nonce = Nonce,
                UserDefinedQueryParams = UserDefinedQueryParams
            };
        }

        /// <inheritdoc/>
        public override async Task RevokeTokenAsync(string userId, string token,
            CancellationToken taskCancellationToken)
        {
            GoogleRevokeTokenRequest request = new GoogleRevokeTokenRequest(new Uri(RevokeTokenUrl))
            {
                Token = token
            };
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, request.Build());

            var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                throw new TokenResponseException(error, response.StatusCode);
            }

            await DeleteTokenAsync(userId, taskCancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override bool ShouldForceTokenRetrieval() 
        {
            return IncludeGrantedScopes.HasValue && IncludeGrantedScopes.Value;
        }

        /// <summary>An initializer class for Google authorization code flow. </summary>
        public new class Initializer : AuthorizationCodeFlow.Initializer
        {
            /// <summary>
            /// The project ID associated with the credential using this flow.
            /// </summary>
            public string ProjectId { get; set; }

            /// <summary>Gets or sets the token revocation URL.</summary>
            public string RevokeTokenUrl { get; set; }

            /// <summary>
            /// Gets or sets the optional indicator for including granted scopes for incremental authorization.
            /// </summary>
            public bool? IncludeGrantedScopes { get; set; }

            /// <summary>Gets or sets the login_hint.</summary>
            public string LoginHint { get; set; }

            /// <summary>
            /// Gets or sets the prompt for consent behaviour.
            /// Value can be <c>null</c>, <c>"none"</c>, <c>"consent"</c>, or <c>"select_account"</c>.
            /// See <a href="https://developers.google.com/identity/protocols/OpenIDConnect#prompt">OpenIDConnect documentation</a>
            /// for details.
            /// </summary>
            public string Prompt { get; set; }

            /// <summary>Gets or sets the nonce.</summary>
            public string Nonce { get; set; }

            /// <summary>Gets or sets the optional user defined query parameters.</summary>
            public IEnumerable<KeyValuePair<string, string>> UserDefinedQueryParams { get; set; }

            /// <summary>
            /// Constructs a new initializer. Sets Authorization server URL to 
            /// <see cref="GoogleAuthConsts.OidcAuthorizationUrl"/>, and Token server URL to 
            /// <see cref="GoogleAuthConsts.OidcTokenUrl"/>.
            /// </summary>
            public Initializer()
                : this(GoogleAuthConsts.OidcAuthorizationUrl, GoogleAuthConsts.OidcTokenUrl, GoogleAuthConsts.RevokeTokenUrl)
            {
            }

            /// <summary>
            /// Constructs a new initializer from the given <see cref="GoogleAuthorizationCodeFlow"/>.
            /// </summary>
            internal Initializer(GoogleAuthorizationCodeFlow flow)
                : base(flow)
            {
                ProjectId = flow.ProjectId;
                RevokeTokenUrl = flow.revokeTokenUrl;
                IncludeGrantedScopes = flow.IncludeGrantedScopes;
                LoginHint = flow.LoginHint;
                Prompt = flow.Prompt;
                Nonce = flow.Nonce;
                UserDefinedQueryParams = flow.UserDefinedQueryParams;
            }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="authorizationServerUrl">Authorization server URL</param>
            /// <param name="tokenServerUrl">Token server URL</param>
            /// <param name="revokeTokenUrl">Revocation server URL</param>
            /// <remarks>
            /// This is mainly for internal testing at Google, where we occasionally need
            /// to use alternative oauth endpoints. This is not for general use.
            /// </remarks>
            protected Initializer(string authorizationServerUrl, string tokenServerUrl, string revokeTokenUrl)
                : base(authorizationServerUrl, tokenServerUrl)
            {
                RevokeTokenUrl = revokeTokenUrl;
            }
        }
    }
}
