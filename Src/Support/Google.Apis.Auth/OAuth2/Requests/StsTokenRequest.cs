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

using System.Net.Http.Headers;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OAuth 2.0 subject token exchange request as defined in
    /// https://datatracker.ietf.org/doc/html/rfc8693#section-2.1.
    /// This is only a partial definition of the spec as required to support Google WIF.
    /// </summary>
    internal class StsTokenRequest
    {
        internal StsTokenRequest(
            string grantType, string audience, string scope, string requestedTokenType,
            string subjectToken, string subjectTokenType,
            string googleOptions, AuthenticationHeaderValue authenticationHeader)
        {
            GrantType = grantType;
            Audience = audience;
            Scope = scope;
            RequestedTokenType = requestedTokenType;
            SubjectToken = subjectToken;
            SubjectTokenType = subjectTokenType;
            GoogleOptions = googleOptions;
            AuthenticationHeader = authenticationHeader;
        }

        /// <summary>
        /// Gets the grant type for this request.
        /// Only <code>urn:ietf:params:oauth:grant-type:token-exchange</code> is currently supported.
        /// </summary>
        public string GrantType { get; }

        /// <summary>
        /// The audience for which the requested token is intended. For instance:
        /// "//iam.googleapis.com/projects/my-project-id/locations/global/workloadIdentityPools/my-pool-id/providers/my-provider-id"
        /// </summary>
        public string Audience { get; }

        /// <summary>
        /// The space-delimited list of desired scopes for the requested token as defined in
        /// http://tools.ietf.org/html/rfc6749#section-3.3. 
        /// </summary>
        public string Scope { get; }

        /// <summary>
        /// The type of the requested security token.
        /// Only <code>urn:ietf:params:oauth:token-type:access_token</code> is currently supported.
        /// </summary>
        public string RequestedTokenType { get; }

        /// <summary>
        /// In terms of Google 3PI support, this is the 3PI credential.
        /// </summary>
        public string SubjectToken { get; }

        /// <summary>
        /// The subject token type.
        /// </summary>
        public string SubjectTokenType { get; }

        /// <summary>
        /// Google specific STS token request options.
        /// May be null.
        /// </summary>
        public string GoogleOptions { get; }

        /// <summary>
        /// Authentication header to be included in the request.
        /// May be null.
        /// </summary>
        public AuthenticationHeaderValue AuthenticationHeader { get; }

        // FIXME: Probably hand-write code to create an appropriate HttpRequestMessage.
    }
}
