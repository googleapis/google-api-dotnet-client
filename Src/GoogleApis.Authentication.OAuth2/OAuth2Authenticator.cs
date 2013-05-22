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
using System.Net.Http;

using DotNetOpenAuth.OAuth2;

using Google.Apis.Http;
using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Authentication.OAuth2
{
    /// <summary> Implements an OAuth2 authenticator using the DotNetOpenAuth library. </summary>
    public class OAuth2Authenticator<TClient> : IAuthenticator, IHttpUnsuccessfulResponseHandler
        where TClient : ClientBase
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

        public void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            // Turn off Expect100Continue behavior. For web method calls it is not used
            // and many servers reject the request if this is present on PUT or POST 
            // requests with a body present. If used, Expect100Continue prevents the client
            // from sending the request body unless the server approves the request by sending
            // Expect100Continue.
            request.ServicePoint.Expect100Continue = false;

            // Populate the AuthorizationState with an access token.
            LoadAccessToken();
            try
            {
                if (State != null && !string.IsNullOrEmpty(State.AccessToken))
                {
                    // Apply authorization to the current request
                    if (string.IsNullOrEmpty(State.RefreshToken))
                    {
                        ClientBase.AuthorizeRequest(request, State.AccessToken);
                    }
                    else
                    {
                        // This only works if State has a refresh token
                        tokenProvider.AuthorizeRequest(request, State);
                    }
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

        /// <summary> 
        /// Override handle response to refresh the token when Unauthorized status code is received. 
        /// </summary>
        public bool HandleResponse(HttpRequestMessage request, HttpResponseMessage response, bool supportsRetry)
        {
            return response.StatusCode == HttpStatusCode.Unauthorized && tokenProvider.RefreshToken(State, null);
        }
    }
}