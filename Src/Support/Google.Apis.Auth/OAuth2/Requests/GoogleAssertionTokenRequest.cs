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


namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Service account assertion token request as specified in 
    /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#makingrequest.
    /// </summary>
    public class GoogleAssertionTokenRequest : TokenRequest
    {
        /// <summary>Gets or sets the JWT (including signature).</summary>
        [Google.Apis.Util.RequestParameterAttribute("assertion")]
        public string Assertion { get; set; }

        /// <summary>
        /// Constructs a new refresh code token request and sets grant_type to 
        /// <c>urn:ietf:params:oauth:grant-type:jwt-bearer</c>.
        /// </summary>
        public GoogleAssertionTokenRequest()
        {
            GrantType = "urn:ietf:params:oauth:grant-type:jwt-bearer";
        }
    }
}
