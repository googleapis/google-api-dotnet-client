/* Copyright (c) 2010 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/


using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Net;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Google.Apis.Authentication.OAuth2
{
    public class ThreeLeggedAuthenticator : OAuthAuthenticator
    {
        private string token;

        /// <summary>
        ///  a constructor for OpenAuthentication login use cases using 3 legged OAuth
        /// </summary>
        /// <param name="applicationName">The name of the application</param>
        /// <param name="consumerKey">the consumerKey to use</param>
        /// <param name="consumerSecret">the consumerSecret to use</param>
        /// <param name="token">The token to be used</param>
        /// <returns></returns>
        public ThreeLeggedAuthenticator(string applicationName, string consumerKey, string consumerSecret, string token) : base(applicationName, consumerKey, consumerSecret)
        {
            this.token = token;
        }

        /// <summary>
        /// returns the Token for OAuth
        /// </summary>
        /// <returns></returns>
        public string Token {
            get { return this.token; }
        }

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its headers according to
        /// the authentication system used.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override void ApplyAuthenticationToRequest (HttpWebRequest request)
        {
            base.ApplyAuthenticationToRequest (request);

            string oauthHeader = OAuthUtil.GenerateOAuth2Header(this.Token);
            request.Headers.Add (oauthHeader);
        }
    }
}
