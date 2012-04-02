/* Copyright (c) 2006 Google Inc.
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
 * 
 * Author: Andrew Smith <andy@snae.net> 22/11/08
 * 
*/

using System;

namespace Google.Apis
{
    /// <summary>
    /// An implementation of Uri that will create an uri with an 
    /// xoauth_requestor_id query string.
    /// </summary>
    [Obsolete("this is going to be removed in the future and replaced with OAuthAuthenticator")]
    public class OAuthUri : Uri
    {
        public static string OAuthParameter = "xoauth_requestor_id"; 
        /// <summary>
        /// Creates a Uri with a xoauth_requestor_id query string.
        /// </summary>
        /// <param name="uriString">The base Uri</param>
        /// <param name="userName">The username for the xoauth_requestor_id</param>
        /// <param name="domain">The domain for the xoauth_requestor_id</param>
        public OAuthUri(String uriString, String userName, String domain)
            : base(uriString + "?"+OAuthParameter+"=" + userName + "%40" + domain)
        {
        }
    }
}

