/*
Copyright 2022 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OAuth 2.0 subject token exchange request as defined in
    /// https://datatracker.ietf.org/doc/html/rfc8693#section-2.1.
    /// This is a partial definition of the spec as required to support Google WIF
    /// which may be expanded and renamed if support for other than WIF is needed.
    /// </summary>
    internal class GoogleWifStsTokenRequest
    {
        /// <summary>
        /// Gets the grant type for this request.
        /// Only <code>urn:ietf:params:oauth:grant-type:token-exchange</code> is currently supported.
        /// </summary>
        [RequestParameter("grant_type")]
        public string GrantType { get; } = "urn:ietf:params:oauth:grant-type:token-exchange";

        /// <summary>
        /// The audience for which the requested token is intended. For instance:
        /// "//iam.googleapis.com/projects/my-project-id/locations/global/workloadIdentityPools/my-pool-id/providers/my-provider-id"
        /// </summary>
        [RequestParameter("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// The space-delimited list of desired scopes for the requested token as defined in
        /// http://tools.ietf.org/html/rfc6749#section-3.3. 
        /// </summary>
        [RequestParameter("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// The type of the requested security token.
        /// Only <code>urn:ietf:params:oauth:token-type:access_token</code> is currently supported.
        /// </summary>
        [RequestParameter("requested_token_type")]
        public string RequestedTokenType { get; } = "urn:ietf:params:oauth:token-type:access_token";

        /// <summary>
        /// In terms of Google 3PI support, this is the 3PI credential.
        /// </summary>
        [RequestParameter("subject_token")]
        public string SubjectToken { get; set; }

        /// <summary>
        /// The subject token type.
        /// </summary>
        [RequestParameter("subject_token_type")]
        public string SubjectTokenType { get; set; }

        /// <summary>
        /// Client ID and client secret are not part of STS token exchange spec.
        /// But in the context of Google 3PI they are used to perform basic authorization
        /// for token exchange.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Client ID and client secret are not part of STS token exchange spec.
        /// But in the context of Google 3PI they are used to perform basic authorization
        /// for token exchange.
        /// </summary>
        public string ClientSecret { get; set; }
    }
}
