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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Thread-safe OAuth 2.0 authorization code flow for an installed application that persists end-user credentials.
    /// </summary>
    /// <remarks>
    /// Incremental authorization (https://developers.google.com/+/web/api/rest/oauth) is currently not supported
    /// for Installed Apps.
    /// </remarks>
    public class AuthorizationCodeInstalledApp : IAuthorizationCodeInstalledApp
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<AuthorizationCodeInstalledApp>();

        /// <summary>
        /// Constructs a new authorization code installed application with the given flow and code receiver.
        /// </summary>
        public AuthorizationCodeInstalledApp(IAuthorizationCodeFlow flow, ICodeReceiver codeReceiver)
        {
            Flow = flow;
            CodeReceiver = codeReceiver;
        }

        #region IAuthorizationCodeInstalledApp Members

        /// <summary>Gets the authorization code flow.</summary>
        public IAuthorizationCodeFlow Flow { get; private set; }

        /// <summary>Gets the code receiver which is responsible for receiving the authorization code.</summary>
        public ICodeReceiver CodeReceiver { get; private set; }

        /// <inheritdoc/>
        public async Task<UserCredential> AuthorizeAsync(string userId, CancellationToken taskCancellationToken)
        {
            // Try to load a token from the data store.
            var token = await Flow.LoadTokenAsync(userId, taskCancellationToken).ConfigureAwait(false);

            // Check if a new authorization code is needed.
            if (ShouldRequestAuthorizationCode(token))
            {
                // Create an authorization code request.
                var redirectUri = CodeReceiver.RedirectUri;
                AuthorizationCodeRequestUrl codeRequest = Flow.CreateAuthorizationCodeRequest(redirectUri);

                // Receive the code.
                var response = await CodeReceiver.ReceiveCodeAsync(codeRequest, taskCancellationToken)
                    .ConfigureAwait(false);

                if (string.IsNullOrEmpty(response.Code))
                {
                    var errorResponse = new TokenErrorResponse(response);
                    Logger.Info("Received an error. The response is: {0}", errorResponse);
                    throw new TokenResponseException(errorResponse);
                }

                Logger.Debug("Received \"{0}\" code", response.Code);

                // If include granted scopes is specified, then pass the current scopes
                // to ExchangeCodeForTokenAsync.
                string[] grantedScopes = null;
                if (Flow.IncludeGrantedScopes.HasValue && Flow.IncludeGrantedScopes.Value)
                {
                    grantedScopes = token.Scope?.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                }

                // Get the token based on the code.
                token = await Flow.ExchangeCodeForTokenAsync(userId, response.Code, grantedScopes, redirectUri,
                    taskCancellationToken).ConfigureAwait(false);
            }

            return new UserCredential(Flow, userId, token);
        }

        /// <summary>
        /// Determines the need for retrieval of a new authorization code, based on the given token and the 
        /// authorization code flow.
        /// </summary>
        public bool ShouldRequestAuthorizationCode(TokenResponse token)
        {
            // TODO: This code should be shared between this class and AuthorizationCodeWebApp.

            // If the token or access-token is null, need to retrieve a new authorization code.
            if (token?.AccessToken == null)
            {
                return true;
            }

            // Is the token is expired, and we don't have a refresh token, need to retrieve a new auth code.
            if (token.IsExpired(Flow.Clock) && token.RefreshToken == null)
            {
                return true;
            }

            // If the current token.Scope does not include the requested scopes, then
            // an authorization code is required.
            var tokenScopes = new HashSet<string>(token.Scope.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            if (Flow.Scopes.All(x => tokenScopes.Contains(x)))
            {
                // All requested scopes have already been authorized.
                return false;
            }

            // GoogleAuthorizationCodeFlow always returns true if IncludeGrantedScopes is true.
            return Flow.ShouldForceTokenRetrieval();
        }

        #endregion
    }
}