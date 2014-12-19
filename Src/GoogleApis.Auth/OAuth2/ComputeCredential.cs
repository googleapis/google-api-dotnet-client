/*
Copyright 2014 Google Inc

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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Google OAuth 2.0 credential for accessing protected resources using an access token. The Google OAuth 2.0 
    /// Authorization Server supports server-to-server interactions such as those between a web application and Google
    /// Cloud Storage. The requesting application has to prove its own identity to gain access to an API, and an 
    /// end-user doesn't have to be involved. 
    /// <para>
    /// More details about Compute Engine authentication is available at:
    /// https://cloud.google.com/compute/docs/authentication.
    /// </para>
    /// </summary>
    public class ComputeCredential : ServiceCredential
    {
        /// <summary>
        /// An initializer class for the Compute credential. It uses <see cref="GoogleAuthConsts.ComputeTokenUrl"/>
        /// as the token server URL.
        /// </summary>
        public class Initializer : ServiceCredential.Initializer
        {
            /// <summary>Constructs a new initializer using the default compute token URL.</summary>
            public Initializer()
                : this(GoogleAuthConsts.ComputeTokenUrl) {}

            /// <summary>Constructs a new initializer using the given token URL.</summary>
            public Initializer(string tokenUrl)
                : base(tokenUrl) {}
        }

        /// <summary>Constructs a new Compute credential instance.</summary>
        public ComputeCredential() : this(new Initializer()) { }

        /// <summary>Constructs a new Compute credential instance.</summary>
        public ComputeCredential(Initializer initializer) : base(initializer) { }

        #region ServiceCredential overrides

        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            // Create and send the HTTP request to compute server token URL.
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, TokenServerUrl);
            httpRequest.Headers.Add("Metadata-Flavor", "Google");
            var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);

            // Read the response.
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                try
                {
                    var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                    // TODO(peleyal): Consider return false here.
                    throw new TokenResponseException(error);
                }
                // Json.NET deserilize object method doesn't include documentation about which exceptions can
                // be thrown, that's why we just catch a general exception here.
                catch (Exception ex)
                {
                    Logger.Error(ex, "Exception was caughted when deserializing TokenErrorResponse. Content is: {0}",
                        content);
                    var error = "Server response does not contain a JSON object. Status code is: "
                        + response.StatusCode;
                    throw new TokenResponseException(new TokenErrorResponse
                        {
                            Error = error
                        });
                }
            }

            // Gets the token and sets its issued time.
            var newToken = NewtonsoftJsonSerializer.Instance.Deserialize<TokenResponse>(content);
            newToken.Issued = Clock.Now;
            Token = newToken;
            return true;
        }

        #endregion
    }
}
