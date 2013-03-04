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

namespace Google.Apis.Authentication
{
    /// <summary>
    /// A three legged OAuth authenticator
    /// </summary>
    public class OAuth3LeggedAuthenticator : OAuthAuthenticator
    {
        private readonly string token;
        private readonly string tokenSecret;

        /// <summary>
        ///  a constructor for OpenAuthentication login use cases using 3 legged OAuth
        /// </summary>
        /// <param name="consumerKey">the consumerKey to use</param>
        /// <param name="consumerSecret">the consumerSecret to use</param>
        /// <param name="token">The token to be used</param>
        /// <param name="tokenSecret">The tokenSecret to be used</param>
        public OAuth3LeggedAuthenticator(string consumerKey,
                                         string consumerSecret,
                                         string token,
                                         string tokenSecret) : base(consumerKey, consumerSecret)
        {
            this.token = token;
            this.tokenSecret = tokenSecret;
        }

        /// <summary>
        /// returns the Token for OAuth
        /// </summary>
        /// <returns></returns>
        public string Token
        {
            get { return token; }
        }

        /// <summary>
        /// returns the TokenSecret for OAuth
        /// </summary>
        /// <returns></returns>
        public string TokenSecret
        {
            get { return tokenSecret; }
        }

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its headers according to
        /// the authentication system used.
        /// </summary>
        public override void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            string oauthHeader = OAuthUtil.GenerateAuthorizationHeader(
                request.RequestUri, ConsumerKey, ConsumerSecret, Token, TokenSecret, request.Method);
            request.Headers[HttpRequestHeader.Authorization] = oauthHeader;
        }
    }
}