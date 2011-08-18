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
using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Authentication.OAuth2
{
    /// <summary>
    /// Implements an OAuth2 authenticator using the DotNetOpenAuth library.
    /// </summary>
    public class OAuth2Authenticator<TClient> : Authenticator, IErrorResponseHandler where TClient : ClientBase
    {
        private readonly Func<TClient, IAuthorizationState> authProvider;
        private readonly TClient tokenProvider;
        private bool noCaching;

        /// <summary>
        /// Creates a new OAuth2 authenticator.
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
        }

        /// <summary>
        /// The current state of this authenticator
        /// </summary>
        public IAuthorizationState State { get; private set; }

        /// <summary>
        /// If this option is set to true, the authorization state will only last for a single request, and
        /// authorization will be re-requested for every additional request.
        /// </summary>
        /// <remarks>
        /// Will clear the current state if set to true. Can be used by Webserver-Applications
        /// to allow multiple AuthorizationStates/users.
        /// </remarks>
        public bool NoCaching
        {
            get { return noCaching; }
            set
            {
                noCaching = value;
                if (noCaching)
                {
                    State = null;
                }
            }
        }

        #region IErrorResponseHandler Members

        public bool CanHandleErrorResponse(WebException exception, RequestError error)
        {
            exception.ThrowIfNull("exception");

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

        public void HandleErrorResponse(WebException exception, RequestError error, WebRequest request)
        {
            request.ThrowIfNull("request");
            if (!(request is HttpWebRequest))
            {
                throw new InvalidCastException(
                    "Expected a HttpWebRequest, but got a " + request.GetType() + " instead.");
            }

            // Refresh our access token:
            tokenProvider.RefreshToken(State, null);

            // Overwrite the current auth header:
            ApplyAuthenticationToRequest((HttpWebRequest)request);
        }

        #endregion

        /// <summary>
        /// Checks if an access token has been set. If this is not the case, this method will use the specified
        /// State provider to generate a new AuthorizationState.
        /// </summary>
        public void LoadAccessToken()
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

            // Populate the AuthorizationState with an access token.
            LoadAccessToken();
            try
            {
                if (State != null && !string.IsNullOrEmpty(State.AccessToken))
                {
                    // Apply authorization to the current request
                    tokenProvider.AuthorizeRequest(request, State); 
                }
            }
            finally
            {
                if (NoCaching)
                {
                    State = null;
                }
            }
        }
    }
}