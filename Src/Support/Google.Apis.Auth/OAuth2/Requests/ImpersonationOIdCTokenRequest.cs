/*
Copyright 2021 Google LLC

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

using Newtonsoft.Json;

// FIXME: Write code to create an HttpRequestMessage for this.

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// OIDC token request for impersonated credential as specified in https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth.
    /// </summary>
    internal class ImpersonationOIdCTokenRequest : ImpersonationRequest
    {
        /// <summary>
        /// Gets or sets the audience of the requested OIDC token.
        /// </summary>
        [JsonProperty("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets whether email address should be included in the requested OIDC token.
        /// </summary>
        [JsonProperty("includeEmail")]
        public bool IncludeEmail { get; set; }
    }
}
