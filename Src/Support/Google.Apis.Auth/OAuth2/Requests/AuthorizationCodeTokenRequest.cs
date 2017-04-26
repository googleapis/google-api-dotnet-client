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
    ///  OAuth 2.0 request for an access token using an authorization code as specified in 
    ///  http://tools.ietf.org/html/rfc6749#section-4.1.3.
    /// </summary>
    public class AuthorizationCodeTokenRequest : TokenRequest
    {
        /// <summary>Gets or sets the authorization code received from the authorization server.</summary>
        [Google.Apis.Util.RequestParameterAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the redirect URI parameter matching the redirect URI parameter in the authorization request.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Constructs a new authorization code token request and sets grant_type to <c>authorization_code</c>.
        /// </summary>
        public AuthorizationCodeTokenRequest()
        {
            GrantType = "authorization_code";
        }
    }
}
