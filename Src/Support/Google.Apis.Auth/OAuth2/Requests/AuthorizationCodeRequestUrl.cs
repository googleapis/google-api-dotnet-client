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
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Google.Apis.Requests;
using Google.Apis.Requests.Parameters;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OAuth 2.0 request URL for an authorization web page to allow the end user to authorize the application to 
    /// access their protected resources and that returns an authorization code, as specified in 
    /// http://tools.ietf.org/html/rfc6749#section-4.1.
    /// </summary>
    public class AuthorizationCodeRequestUrl : AuthorizationRequestUrl
    {
        /// <summary>
        /// Constructs a new authorization code request with the specified URI and sets response_type to <c>code</c>.
        /// </summary>
        public AuthorizationCodeRequestUrl(Uri authorizationServerUrl)
            : base(authorizationServerUrl)
        {
            ResponseType = "code";
        }

        /// <summary>Creates a <see cref="System.Uri"/> which is used to request the authorization code.</summary>
        public Uri Build()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = AuthorizationServerUrl
                };
            ParameterUtils.InitParameters(builder, this);
            return builder.BuildUri();
        }
    }
}
