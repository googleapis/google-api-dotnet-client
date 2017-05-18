/*
Copyright 2014 Google Inc

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

using Google.Apis.Requests;
using Google.Apis.Requests.Parameters;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Google OAuth 2.0 request to revoke an access token as specified in 
    /// https://developers.google.com/accounts/docs/OAuth2WebServer#tokenrevoke.
    /// </summary>
    class GoogleRevokeTokenRequest
    {
        private readonly Uri revokeTokenUrl;
        /// <summary>Gets the URI for token revocation.</summary>
        public Uri RevokeTokenUrl
        {
            get { return revokeTokenUrl; }
        }

        /// <summary>Gets or sets the token to revoke.</summary>
        [Google.Apis.Util.RequestParameterAttribute("token")]
        public string Token { get; set; }

        public GoogleRevokeTokenRequest(Uri revokeTokenUrl)
        {
            this.revokeTokenUrl = revokeTokenUrl;
        }

        /// <summary>Creates a <see cref="System.Uri"/> which is used to request the authorization code.</summary>
        public Uri Build()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = revokeTokenUrl
            };
            ParameterUtils.InitParameters(builder, this);
            return builder.BuildUri();
        }
    }
}
