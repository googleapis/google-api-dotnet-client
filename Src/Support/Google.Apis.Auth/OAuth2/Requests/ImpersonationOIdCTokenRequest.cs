/*
Copyright 2021 Google Inc

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

using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OIDC token request for impersonated credential as specified in https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth.
    /// </summary>
    public class ImpersonationOIdCTokenRequest
    {
        /// <summary>
        /// Gets or sets the audience of the requested OIDC token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets the chained list of delegate service accounts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delegates")]
        public IEnumerable<string> DelegateAccounts { get; set; }

        /// <summary>
        /// Gets or sets whether email address should be included in the requested OIDC token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeEmail")]
        public bool IncludeEmail { get; set; }
    }
}
