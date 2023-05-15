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
    // FIXME: Write code to create an HttpRequestMessage for this.

    /// <summary>
    /// OAuth 2.0 request for an access token as specified in http://tools.ietf.org/html/rfc6749#section-4.
    /// </summary>
    public class TokenRequest
    {
        /// <summary>
        /// Gets or sets space-separated list of scopes as specified in http://tools.ietf.org/html/rfc6749#section-3.3.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the Grant type. Sets <c>authorization_code</c> or <c>password</c> or <c>client_credentials</c> 
        /// or <c>refresh_token</c> or absolute URI of the extension grant type.
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>Gets or sets the client Identifier.</summary>
        public string ClientId { get; set; }

        /// <summary>Gets or sets the client Secret.</summary>
        public string ClientSecret { get; set; }
    }
}
