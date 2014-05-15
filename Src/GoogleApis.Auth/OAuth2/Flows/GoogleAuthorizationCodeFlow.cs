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

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Google specific authorization code flow which inherits from <see cref="AuthorizationCodeFlow"/>.
    /// </summary>
    public class GoogleAuthorizationCodeFlow : AuthorizationCodeFlow
    {
        private readonly string revokeTokenUrl;

        /// <summary>Gets the token revocation URL.</summary>
        public string RevokeTokenUrl { get { return revokeTokenUrl; } }

        /// <summary>Constructs a new Google authorization code flow.</summary>
        public GoogleAuthorizationCodeFlow(Initializer initializer)
            : base(initializer)
        {
            revokeTokenUrl = initializer.RevokeTokenUrl;
        }

        public override AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
        {
            return new GoogleAuthorizationCodeRequestUrl(new Uri(AuthorizationServerUrl))
            {
                ClientId = ClientSecrets.ClientId,
                Scope = string.Join(" ", Scopes),
                RedirectUri = redirectUri
            };
        }

        public override async Task RevokeTokenAsync(string userId, string token,
            CancellationToken taskCancellationToken)
        {
            GoogleRevokeTokenRequest request = new GoogleRevokeTokenRequest(new Uri(RevokeTokenUrl))
            {
                Token = token
            };
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, request.Build());

            var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                throw new TokenResponseException(error);
            }

            await DeleteTokenAsync(userId, taskCancellationToken);
        }

        /// <summary>An initializer class for Google authorization code flow. </summary>
        public new class Initializer : AuthorizationCodeFlow.Initializer
        {
            /// <summary>Gets or sets the token revocation URL.</summary>
            public string RevokeTokenUrl { get; set; }

            /// <summary>
            /// Constructs a new initializer. Sets Authorization server URL to 
            /// <see cref="Google.Apis.Auth.OAuth2.GoogleAuthConsts.AuthorizationUrl"/>, and Token server URL to 
            /// <see cref="Google.Apis.Auth.OAuth2.GoogleAuthConsts.TokenUrl"/>.
            /// </summary>
            public Initializer()
                : base(GoogleAuthConsts.AuthorizationUrl, GoogleAuthConsts.TokenUrl)
            {
                RevokeTokenUrl = GoogleAuthConsts.RevokeTokenUrl;
            }
        }
    }
}
