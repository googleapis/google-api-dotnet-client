/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Net;
using DotNetOpenAuth.OAuth2;
using Google.Apis.Util;
using Google.Apis.Requests;

namespace Google.Apis.Authentication.OAuth2
{
    /// <summary>
    /// Implements an OAuth2 authenticator using the DotNetOpenAuth library.
    /// </summary>
    public class OAuth2Authenticator<TClient> : Authenticator, IErrorResponseHandler where TClient : ClientBase
    {
        private readonly Func<TClient, IAuthorizationState> authProvider;
        private readonly TClient tokenProvider;

        /// <summary>
        /// The current state of this authenticator
        /// </summary>
        public IAuthorizationState State { get; private set; }

        /// <summary>
        /// Creates a new OAuth2 authenticator
        /// </summary>
        /// <param name="tokenProvider">The client which is used for requesting access and refresh tokens.</param>
        /// <param name="authProvider">The method which provides the initial authorization for the provider.</param>
        public OAuth2Authenticator(TClient tokenProvider,
                                   Func<TClient, IAuthorizationState> authProvider)
        {
            tokenProvider.ThrowIfNull("applicationName");
            authProvider.ThrowIfNull("authProvider");
            
            this.tokenProvider = tokenProvider;
            this.authProvider = authProvider;

            // Request initial authorization.
            CheckForValidAccessToken();
        }

        /// <summary>
        /// Checks if the current access token is valid. Will request a new token if it is invalid.
        /// </summary>
        public void CheckForValidAccessToken()
        {
            // Check if we have an access token, otherwise request one.
            if (State == null || string.IsNullOrEmpty(State.AccessToken))
            {
                State = authProvider(tokenProvider);
            }
        }
        
        public override void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            base.ApplyAuthenticationToRequest(request);

            // Get the access token.
            CheckForValidAccessToken();

            if (State != null && !string.IsNullOrEmpty(State.AccessToken))
            {
                string accessToken = State.AccessToken;

                // Apply authorization to the current request
                // Note: OAuth2 draft16 is not yet supported by the server.
                //       tokenProvider.AuthorizeRequest(request, State); 
                request.Headers.Add(GenerateOAuth2Header(accessToken));
            }
        }

        private static string GenerateOAuth2Header(String token)
        {
            if (token.IsNotNullOrEmpty())
            {
                return "Authorization: OAuth " + token;
            }
            return string.Empty;
        }

        public bool CanHandleErrorResponse(WebException exception, RequestError error)
        {
            // If we have an access token, and the response was 401, then the access token
            // probably expired. We can try to handle this error.
            if (State == null)
            {
                return false;
            }

            var response = exception.Response as HttpWebResponse;

            if (response == null)
            {
                return false;
            }

            return response.StatusCode == HttpStatusCode.Unauthorized;
        }

        public void PrepareHandleErrorResponse(WebException exception, RequestError error)
        {
            // Refresh our access token
            tokenProvider.RefreshToken(State, null);
        }

        public void HandleErrorResponse(WebException exception, RequestError error, WebRequest request)
        {
            // Authentication is applied automatically when creating a new request.
        }
    }
}