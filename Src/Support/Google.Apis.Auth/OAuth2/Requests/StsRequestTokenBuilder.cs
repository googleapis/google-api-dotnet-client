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

using Google.Apis.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Builder for <see cref="StsTokenRequest"/>.
    /// </summary>
    internal class StsTokenRequestBuilder
    {
        /// <summary>
        /// Gets the grant type for this request.
        /// Only <code>urn:ietf:params:oauth:grant-type:token-exchange</code> is currently supported.
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// The audience for which the requested token is intended. For instance:
        /// "//iam.googleapis.com/projects/my-project-id/locations/global/workloadIdentityPools/my-pool-id/providers/my-provider-id"
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// The list of desired scopes for the requested token.
        /// </summary>
        public IEnumerable<string> Scopes { get; set; }

        /// <summary>
        /// The type of the requested security token.
        /// Only <code>urn:ietf:params:oauth:token-type:access_token</code> is currently supported.
        /// </summary>
        public string RequestedTokenType { get; set; }

        /// <summary>
        /// In terms of Google 3PI support, this is the 3PI credential.
        /// </summary>
        public string SubjectToken { get; set; }

        /// <summary>
        /// The subject token type.
        /// </summary>
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

        /// <summary>
        /// The GCP project number to be used for Workforce Pools
        /// external credentials. To be included in the request as part of options.
        /// </summary>
        public string WorkforcePoolUserProject { get; set; }

        public StsTokenRequest Build()
        {
            var authenticationHeader = (ClientId is string && ClientSecret is string)
                ? new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")))
                : null;

            var options = (authenticationHeader is null && WorkforcePoolUserProject is string)
                ? NewtonsoftJsonSerializer.Instance.Serialize(new { userProject = WorkforcePoolUserProject })
                : null;

            var scope = Scopes?.Any() == true ? string.Join(" ", Scopes) : null;

            return new StsTokenRequest(GrantType, Audience, scope, RequestedTokenType, SubjectToken, SubjectTokenType, options, authenticationHeader);
        }
    }
}
