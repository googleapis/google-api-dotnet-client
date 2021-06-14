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
using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Access token request for impersonated credential as specified in https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth.
    /// </summary>
    internal class ImpersonationAccessTokenRequest : ImpersonationRequest
    {
        /// <summary>
        /// Gets or sets the scopes to request during the authorization grant.
        /// </summary>
        [JsonProperty("scope")]
        public IEnumerable<string> Scopes { get; set; }

        /// <summary>
        /// Gets or sets how long the delegated credential should be valid. Its format is the number of
        /// seconds followed by a letter "s", for example "300s".
        /// </summary>
        [JsonProperty("lifetime")]
        public string Lifetime { get; set; }
    }
}
