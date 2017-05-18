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

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OAuth 2.0 request to refresh an access token using a refresh token as specified in 
    /// http://tools.ietf.org/html/rfc6749#section-6.
    /// </summary>
    public class RefreshTokenRequest : TokenRequest
    {
        /// <summary>Gets or sets the Refresh token issued to the client.</summary>
        [Google.Apis.Util.RequestParameterAttribute("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Constructs a new refresh code token request and sets grant_type to <c>refresh_token</c>.
        /// </summary>
        public RefreshTokenRequest()
        {
            GrantType = "refresh_token";
        }
    }
}
