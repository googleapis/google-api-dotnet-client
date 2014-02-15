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

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Requests.Parameters;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>Extension methods to <see cref="TokenRequest"/>.</summary>
    internal static class TokenRequestExtenstions
    {
        /// <summary>
        /// Executes the token request in order to receive a 
        /// <see cref="Google.Apis.Auth.OAuth2.Responses.TokenResponse"/>. In case the token server returns an 
        /// error, a <see cref="Google.Apis.Auth.OAuth2.Responses.TokenResponseException"/> is thrown.
        /// </summary>
        /// <param name="request">The token request.</param>
        /// <param name="httpClient">The HTTP client used to create an HTTP request.</param>
        /// <param name="tokenServerUrl">The token server URL.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <param name="clock">
        /// The clock which is used to set the
        /// <see cref="Google.Apis.Auth.OAuth2.Responses.TokenResponse.Issued"/> property.
        /// </param>
        /// <returns>Token response with the new access token.</returns>
        public static async Task<TokenResponse> ExecuteAsync(this TokenRequest request, HttpClient httpClient,
            string tokenServerUrl, CancellationToken taskCancellationToken, IClock clock)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, tokenServerUrl);
            httpRequest.Content = ParameterUtils.CreateFormUrlEncodedContent(request);

            var response = await httpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                var error = NewtonsoftJsonSerializer.Instance.Deserialize<TokenErrorResponse>(content);
                throw new TokenResponseException(error);
            }

            // Gets the token and sets its issued time.
            var newToken = NewtonsoftJsonSerializer.Instance.Deserialize<TokenResponse>(content);
            newToken.Issued = clock.Now;
            return newToken;
        }
    }
}
