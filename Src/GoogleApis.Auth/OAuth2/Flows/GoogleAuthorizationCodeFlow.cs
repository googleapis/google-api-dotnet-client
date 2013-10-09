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

using Google.Apis.Auth.OAuth2.Requests;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Google specific authorization code flow which inherits from <seealso cref="AuthorizationCodeFlow"/>.
    /// </summary>
    public class GoogleAuthorizationCodeFlow : AuthorizationCodeFlow
    {
        /// <summary>Constructs a new Google authorization code flow.</summary>
        public GoogleAuthorizationCodeFlow(AuthorizationCodeFlow.Initializer initializer)
            : base(initializer)
        {
        }

        public override AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
        {
            return new GoogleAuthorizationCodeRequestUrl(new Uri(AuthorizationServerUrl))
            {
                ClientId = ClientSecrets.ClientId,
                Scope = string.Join(" ", Scopes),
                RedirectUri = redirectUri
            };
        }

        /// <summary>An initializer class for Google authorization code flow. </summary>
        public new class Initializer : AuthorizationCodeFlow.Initializer
        {
            /// <summary>
            /// Constructs a new initializer. Sets Authorization server URL to 
            /// <seealso cref="GoogleAuthConsts.AuthorizationUrl"/>, and Token server URL to 
            /// <seealso cref="GoogleAuthConsts.TokenUrl"/>.
            /// </summary>
            public Initializer()
                : base(GoogleAuthConsts.AuthorizationUrl, GoogleAuthConsts.TokenUrl)
            {
            }
        }
    }
}
