/*
Copyright 2023 Google LLC

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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Requests.Parameters;
using Google.Apis.Util;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Requests
{
    internal static class RequestExtensions
    {
        /// <summary>
        /// Serializes <paramref name="request"/> to JSON and posts it to <paramref name="url"/>.
        /// </summary>
        internal static async Task<HttpResponseMessage> PostJsonAsync(
            this object request, HttpClient httpClient, string url, CancellationToken cancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(NewtonsoftJsonSerializer.Instance.Serialize(request), Encoding.UTF8, "application/json")
            };

            return await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Serializes <paramref name="request"/> to JSON and posts it to <paramref name="url"/>.
        /// Deserializes the JSON response into <typeparamref name="TResponse"/>.
        /// </summary>
        internal static async Task<TResponse> PostJsonAsync<TResponse>(
            this object request, HttpClient httpClient, string url, CancellationToken cancellationToken)
        {
            var response = await request.PostJsonAsync(httpClient, url, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await NewtonsoftJsonSerializer.Instance.DeserializeAsync<TResponse>(
                await response.Content.ReadAsStreamAsync().ConfigureAwait(false), cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Serializes <paramref name="request"/> to JSON and posts it to <paramref name="url"/>.
        /// Builds a <see cref="TokenResponse"/> instance from the HTTP response.
        /// <see cref="TokenResponse.FromHttpResponseAsync(HttpResponseMessage, IClock, ILogger)"/>
        /// for more information.
        /// </summary>
        internal static async Task<TokenResponse> PostJsonAsync(
            this object request, HttpClient httpClient, string url,
            IClock clock, ILogger logger, CancellationToken cancellationToken)
        {
            var response = await request.PostJsonAsync(httpClient, url, cancellationToken).ConfigureAwait(false);
            return await TokenResponse.FromHttpResponseAsync(response, clock, logger).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates and HTTP form from <paramref name="request"/> and posts it to <paramref name="url"/>.
        /// If <paramref name="authenticationHeaderValue"/> is not null, its value is included as the
        /// Authorization header of the request.
        /// Builds a <see cref="TokenResponse"/> instance from the HTTP response.
        /// <see cref="TokenResponse.FromHttpResponseAsync(HttpResponseMessage, IClock, ILogger)"/>
        /// for more information.
        /// </summary>
        internal static async Task<TokenResponse> PostFormAsync(this object request, HttpClient httpClient,
            string url, AuthenticationHeaderValue authenticationHeaderValue,
            IClock clock, ILogger logger, CancellationToken taskCancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = ParameterUtils.CreateFormUrlEncodedContent(request)
            };
            if (authenticationHeaderValue is not null)
            {
                httpRequest.Headers.Authorization = authenticationHeaderValue;
            }

            var response = await httpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            return await TokenResponse.FromHttpResponseAsync(response, clock, logger).ConfigureAwait(false);
        }
    }
}
