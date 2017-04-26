/*
Copyright 2015 Google Inc

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
using System.Net.Http;
using System.Text;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Method of presenting the access token to the resource server as specified in 
    /// http://tools.ietf.org/html/rfc6749#section-7
    /// </summary>
    public interface IAccessMethod
    {
        /// <summary>
        /// Intercepts a HTTP request right before the HTTP request executes by providing the access token.
        /// </summary>
        void Intercept(HttpRequestMessage request, string accessToken);

        /// <summary>
        /// Retrieves the original access token in the HTTP request, as provided in the <see cref=" Intercept"/>
        /// method.
        /// </summary>
        string GetAccessToken(HttpRequestMessage request);
    }
}
