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
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2.Web
{
    /// <summary>
    /// Thread safe OAuth 2.0 authorization code flow for a web application that persists end-user credentials.
    /// </summary>
    public class AuthorizationCodeWebApp
    {
        /// <summary>
        /// The state key. As part of making the request for authorization code we save the original request to verify 
        /// that this server create the original request.
        /// </summary>
        public const string StateKey = "oauth_";

        /// <summary>The length of the random number which will be added to the end of the state parameter.</summary>
        public const int StateRandomLength = 8;

        /// <summary>
        /// AuthResult which contains the user's credentials if it was loaded successfully from the store. Otherwise
        /// it contains the redirect URI for the authorization server.
        /// </summary>
        public class AuthResult
        {
            /// <summary>
            /// Gets or sets the user's credentials or <c>null</c> in case the end user needs to authorize.
            /// </summary>
            public UserCredential Credential { get; set; }

            /// <summary>
            /// Gets or sets the redirect URI to for the user to authorize against the authorization server or 
            /// <c>null</c> in case the <see cref="Google.Apis.Auth.OAuth2.UserCredential"/> was loaded from the data 
            /// store.
            /// </summary>
            public string RedirectUri { get; set; }
        }

        private readonly IAuthorizationCodeFlow flow;
        private readonly string redirectUri;
        private readonly string state;

        /// <summary>Gets the authorization code flow.</summary>
        public IAuthorizationCodeFlow Flow
        {
            get { return flow; }
        }

        /// <summary>Gets the OAuth2 callback redirect URI.</summary>
        public string RedirectUri
        {
            get { return redirectUri; }
        }

        /// <summary>Gets the state which is used to navigate back to the page that started the OAuth flow.</summary>
        public string State
        {
            get { return state; }
        }

        /// <summary>
        /// Constructs a new authorization code installed application with the given flow and code receiver.
        /// </summary>
        public AuthorizationCodeWebApp(IAuthorizationCodeFlow flow, string redirectUri, string state)
        {
            // TODO(peleyal): Provide a way to disable to random number in the end of the state parameter.
            this.flow = flow;
            this.redirectUri = redirectUri;
            this.state = state;
        }

        /// <summary>Asynchronously authorizes the web application to access user's protected data.</summary>
        /// <param name="userId">User identifier</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation</param>
        /// <returns>
        /// Auth result object which contains the user's credential or redirect URI for the authorization server
        /// </returns>
        public async Task<AuthResult> AuthorizeAsync(string userId, CancellationToken taskCancellationToken)
        {
            // Try to load a token from the data store.
            var token = await Flow.LoadTokenAsync(userId, taskCancellationToken).ConfigureAwait(false);

            // Check if a new authorization code is needed.
            if (ShouldRequestAuthorizationCode(token))
            {
                // Create an authorization code request.
                AuthorizationCodeRequestUrl codeRequest = Flow.CreateAuthorizationCodeRequest(redirectUri);

                // Add a random number to the end of the state so we can indicate the original request was made by this
                // call.
                var oauthState = state;
                if (Flow.DataStore != null)
                {
                    var rndString = new string('9', StateRandomLength);
                    var random = new Random().Next(int.Parse(rndString)).ToString("D" + StateRandomLength);
                    oauthState += random;
                    await Flow.DataStore.StoreAsync(StateKey + userId, oauthState).ConfigureAwait(false);
                }
                codeRequest.State = oauthState;

                return new AuthResult { RedirectUri = codeRequest.Build().ToString() };
            }

            return new AuthResult { Credential = new UserCredential(flow, userId, token) };
        }

        /// <summary>
        /// Determines the need for retrieval of a new authorization code, based on the given token and the 
        /// authorization code flow.
        /// </summary>
        public bool ShouldRequestAuthorizationCode(TokenResponse token)
        {
            // TODO: This code should be shared between this class and AuthorizationCodeInstalledApp.
            // If the flow includes a parameter that requires a new token, if the stored token is null or it doesn't
            // have a refresh token and the access token is expired we need to retrieve a new authorization code.
            return Flow.ShouldForceTokenRetrieval() || token == null || (token.RefreshToken == null
                && token.IsExpired(flow.Clock));
        }
    }
}
