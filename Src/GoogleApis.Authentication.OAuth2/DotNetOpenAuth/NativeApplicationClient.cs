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
using System.Collections.Generic;
using DotNetOpenAuth.OAuth2;

namespace Google.Apis.Authentication.OAuth2.DotNetOpenAuth
{
    /// <summary>
    /// The OAuth2 client for use by native applications. This is a partial implementation which 
    /// should be used until the feature has been fully implemented in DotNetOpenAuth.
    /// </summary>
    public class NativeApplicationClient : UserAgentClient
    {
        /// <summary>
        /// Represents a callback URL which points to a special out of band page used for native OAuth2 authorization.
        /// This URL will cause the authorization code to appear in the title of the window.
        /// </summary>
        /// <remarks>See http://code.google.com/apis/accounts/docs/OAuth2.html for more information.</remarks>
        public const string OutOfBandCallbackUrl = "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentClient"/> class.
        /// </summary>
        /// <param name="authorizationServer">The token issuer.</param>
        /// <param name="clientIdentifier">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        public NativeApplicationClient(AuthorizationServerDescription authorizationServer,
                                       string clientIdentifier,
                                       string clientSecret)
            : base(authorizationServer, clientIdentifier, clientSecret) {}
        
        // <summary>
        /// Initializes a new instance of the <see cref="UserAgentClient"/> class.
        /// </summary>
        /// <param name="authorizationServer">The token issuer.</param>
        public NativeApplicationClient(AuthorizationServerDescription authorizationServer)
            : this(authorizationServer, null, null) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgentClient"/> class.
        /// </summary>
        /// <param name="authorizationEndpoint">The authorization endpoint.</param>
        public NativeApplicationClient(Uri authorizationEndpoint)
            : base(new AuthorizationServerDescription { AuthorizationEndpoint = authorizationEndpoint }) {}

        /// <summary>
        /// Creates the URL which should be used by the user to request the initial authorization.
        /// Uses the default Out-of-band-URI as a callback.
        /// </summary>
        /// <param name="scope">Set of requested scopes</param>
        /// <returns>URI pointing to the authorization server</returns>
        public new Uri RequestUserAuthorization(IEnumerable<string> scope)
        {
            var state = new AuthorizationState(scope);
            state.Callback = new Uri(OutOfBandCallbackUrl);
            return RequestUserAuthorization(state);
        }
        
        /// <summary>
        /// Creates the URL which should be used by the user to request the initial authorization.
        /// Uses the default Out-of-band-URI as a callback.
        /// </summary>
        /// <returns>URI pointing to the authorization server</returns>
        public new Uri RequestUserAuthorization()
        {
            return RequestUserAuthorization((IEnumerable<string>)null);
        }

        /// <summary>
        /// Uses the provided authorization code to create an authorization state.
        /// </summary>
        /// <param name="authCode">The authorization code for getting an access token.</param>
        /// <param name="authorizationState">The authorization.  Optional.</param>
        /// <returns>The granted authorization, or <c>null</c> if the authorization was null or rejected.</returns>
        public IAuthorizationState ProcessUserAuthorization(string authCode, IAuthorizationState authorizationState)
        {
            if (authorizationState == null)
            {
                authorizationState = new AuthorizationState();
                authorizationState.Callback = new Uri(OutOfBandCallbackUrl);
            }

            // Build a generic URL containing the auth code.
            // This is done here as we cannot modify the DotNetOpenAuth library and the underlying method
            // only allows parsing an URL as a method of retrieving the AuthorizationState.
            string url = "http://example.com/?code=" + authCode;
            return ProcessUserAuthorization(new Uri(url), authorizationState);
        }
        
        /// <summary>
        /// Uses the provided authorization code to create an authorization state.
        /// </summary>
        /// <param name="authCode">The authorization code for getting an access token.</param>
        /// <returns>The granted authorization, or <c>null</c> if the authorization was null or rejected.</returns>
        public IAuthorizationState ProcessUserAuthorization(string authCode)
        {
            return ProcessUserAuthorization(authCode, null);
        }
    }
}