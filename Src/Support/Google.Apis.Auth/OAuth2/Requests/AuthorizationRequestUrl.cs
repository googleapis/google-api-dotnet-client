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

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OAuth 2.0 request URL for an authorization web page to allow the end user to authorize the application to 
    /// access their protected resources, as specified in http://tools.ietf.org/html/rfc6749#section-3.1.
    /// </summary>
    public class AuthorizationRequestUrl
    {
        /// <summary>
        /// Gets or sets the response type which must be <c>code</c> for requesting an authorization code or 
        /// <c>token</c> for requesting an access token (implicit grant), or space separated registered extension 
        /// values. See http://tools.ietf.org/html/rfc6749#section-3.1.1 for more details
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("response_type", Google.Apis.Util.RequestParameterType.Query)]
        public string ResponseType { get; set; }

        /// <summary>Gets or sets the client identifier.</summary>
        [Google.Apis.Util.RequestParameterAttribute("client_id", Google.Apis.Util.RequestParameterType.Query)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the URI that the authorization server directs the resource owner's user-agent back to the 
        /// client after a successful authorization grant, as specified in 
        /// http://tools.ietf.org/html/rfc6749#section-3.1.2 or <c>null</c> for none.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("redirect_uri", Google.Apis.Util.RequestParameterType.Query)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets space-separated list of scopes, as specified in http://tools.ietf.org/html/rfc6749#section-3.3
        /// or <c>null</c> for none.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("scope", Google.Apis.Util.RequestParameterType.Query)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the state (an opaque value used by the client to maintain state between the request and 
        /// callback, as mentioned in http://tools.ietf.org/html/rfc6749#section-3.1.2.2 or <c>null</c> for none.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("state", Google.Apis.Util.RequestParameterType.Query)]
        public string State { get; set; }

        private readonly Uri authorizationServerUrl;
        /// <summary>Gets the authorization server URI.</summary>
        public Uri AuthorizationServerUrl
        {
            get { return authorizationServerUrl; }
        }

        /// <summary>Constructs a new authorization request with the specified URI.</summary>
        /// <param name="authorizationServerUrl">Authorization server URI</param>
        public AuthorizationRequestUrl(Uri authorizationServerUrl)
        {
            this.authorizationServerUrl = authorizationServerUrl;
        }
    }
}