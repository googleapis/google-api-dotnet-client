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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Requests
{
    internal static class ImpersonationTokenRequestExtensions
    {
        internal static async Task<HttpResponseMessage> ExecuteAsync(
            this ImpersonationRequest request, HttpClient httpClient, string url, CancellationToken cancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(NewtonsoftJsonSerializer.Instance.Serialize(request), Encoding.UTF8, "application/json")
            };

            return await httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        }

        internal static async Task<TResponse> ExecuteAsync<TResponse>(
            this ImpersonationRequest request, HttpClient httpClient, string url, CancellationToken cancellationToken)
        {
            var response = await request.ExecuteAsync(httpClient, url, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await NewtonsoftJsonSerializer.Instance.DeserializeAsync<TResponse>(
                await response.Content.ReadAsStreamAsync().ConfigureAwait(false), cancellationToken).ConfigureAwait(false);
        }

        internal static async Task<TokenResponse> ExecuteAsync(
            this ImpersonationRequest request, HttpClient httpClient, string url,
            IClock clock, ILogger logger, CancellationToken cancellationToken)
        {
            var response = await request.ExecuteAsync(httpClient, url, cancellationToken).ConfigureAwait(false);
            return await TokenResponse.FromHttpResponseAsync(response, clock, logger).ConfigureAwait(false);
        }
    }
}
