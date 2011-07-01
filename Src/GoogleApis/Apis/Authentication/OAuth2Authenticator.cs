/*
Copyright 2010 Google Inc

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

using System.Net;
using Google.Apis.Util;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// Authenticator class based on OAuth2, for both 2-legged and 3-legged use cases.
    /// </summary>
    public class OAuth2Authenticator : OAuthAuthenticator
    {
        private readonly string token;

        /// <summary>
        /// instantiated a new instance of OAuth2Authenticator.
        /// </summary>
        /// <param name="applicationName">The name of the application</param>
        /// <param name="consumerKey">the consumerKey to use</param>
        /// <param name="consumerSecret">the consumerSecret to use</param>
        /// <param name="token">The token to be used</param>
        /// <returns></returns>
        public OAuth2Authenticator(string applicationName, string consumerKey, string consumerSecret, string token)
            : base(applicationName, consumerKey, consumerSecret)
        {
            token.ThrowIfNull("token");
            this.token = token;
        }

        /// <summary>
        /// returns the Token for OAuth
        /// </summary>
        public string Token
        {
            get { return token; }
        }

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its headers according to
        /// the authentication system used.
        /// </summary>
        public override void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            base.ApplyAuthenticationToRequest(request);

            string oauthHeader = OAuthUtil.GenerateOAuth2Header(Token);
            request.Headers.Add(oauthHeader);
        }
    }
}