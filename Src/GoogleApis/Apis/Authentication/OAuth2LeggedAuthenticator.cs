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

using System;
using System.Net;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// A two legged OAuth authenticator
    /// </summary>
    public class OAuth2LeggedAuthenticator : OAuthAuthenticator
    {
        public static string OAuthParameter = "xoauth_requestor_id";

        /// <summary>
        ///  a constructor for OpenAuthentication login use cases
        /// </summary>
        /// <param name="consumerKey">the consumerKey to use</param>
        /// <param name="consumerSecret">the consumerSecret to use</param>
        /// <param name="user">the username to use</param>
        /// <param name="domain">the domain to use</param>
        /// <returns></returns>
        public OAuth2LeggedAuthenticator(string consumerKey,
                                         string consumerSecret,
                                         string user,
                                         string domain) : base(consumerKey, consumerSecret)
        {
            OAuthUser = user;
            OAuthDomain = domain;
        }

        public string OAuthUser { get; private set; }
        public string OAuthDomain { get; private set; }

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its headers according to
        /// the authentication system used.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public override void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            base.ApplyAuthenticationToRequest(request);

            string oauthHeader = OAuthUtil.GenerateAuthorizationHeader(
                request.RequestUri, ConsumerKey, ConsumerSecret, null, null, request.Method);
            request.Headers[HttpRequestHeader.Authorization] = oauthHeader;
        }

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its uri according to 
        /// the authentication system used. Only overridden in 2leggedoauth case
        /// Here we need to add the xoauthrequestor parameter
        /// </summary>
        /// <param name="source">the original uri</param>
        /// <returns></returns>
        public override Uri ApplyAuthenticationToUri(Uri source)
        {
            UriBuilder builder = new UriBuilder(source);
            string queryToAppend = OAuthParameter + "=" + OAuthUser + "%40" + OAuthDomain;

            if (builder.Query.Length > 1)
            {
                builder.Query = builder.Query + "&" + queryToAppend;
            }
            else
            {
                builder.Query = queryToAppend;
            }
            return builder.Uri;
        }
    }
}