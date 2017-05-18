/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Net.Http;
using System.Net.Http.Headers;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 helper for accessing protected resources using the Bearer token as specified in
    /// http://tools.ietf.org/html/rfc6750.
    /// </summary>
    public class BearerToken
    {
        /// <summary>
        /// Thread-safe OAuth 2.0 method for accessing protected resources using the Authorization header as specified 
        /// in http://tools.ietf.org/html/rfc6750#section-2.1.
        /// </summary>
        public class AuthorizationHeaderAccessMethod : IAccessMethod
        {
            const string Schema = "Bearer";

            public void Intercept(HttpRequestMessage request, string accessToken)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(Schema, accessToken);
            }

            public string GetAccessToken(HttpRequestMessage request)
            {
                if (request.Headers.Authorization != null && request.Headers.Authorization.Scheme == Schema)
                {
                    return request.Headers.Authorization.Parameter;
                }
                return null;
            }
        }

        /// <summary>
        /// Thread-safe OAuth 2.0 method for accessing protected resources using an <c>access_token</c> query parameter
        /// as specified in http://tools.ietf.org/html/rfc6750#section-2.3.
        /// </summary>
        public class QueryParameterAccessMethod : IAccessMethod
        {
            const string AccessTokenKey = "access_token";

            public void Intercept(HttpRequestMessage request, string accessToken)
            {
                var uri = request.RequestUri;
                request.RequestUri = new Uri(string.Format("{0}{1}{2}={3}",
                    uri.ToString(), string.IsNullOrEmpty(uri.Query) ? "?" : "&", AccessTokenKey,
                    Uri.EscapeDataString(accessToken)));
            }

            public string GetAccessToken(HttpRequestMessage request)
            {
                var query = request.RequestUri.Query;
                if (string.IsNullOrEmpty(query))
                {
                    return null;
                }

                // Remove the '?'.
                query = query.Substring(1);
                foreach (var parameter in query.Split('&'))
                {
                    var keyValue = parameter.Split('=');
                    if (keyValue[0].Equals(AccessTokenKey))
                    {
                        return keyValue[1];
                    }
                }
                return null;
            }
        }
    }
}
