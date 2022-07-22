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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Requests.Parameters;
using Google.Apis.Util;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Requests
{
    internal static class GoogleWifStsTokenRequestExtensions
    {
        internal static async Task<TokenResponse> ExecuteAsync(this GoogleWifStsTokenRequest request, HttpClient httpClient,
            string tokenServerUrl, IClock clock, ILogger logger, CancellationToken taskCancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, tokenServerUrl)
            {
                Content = ParameterUtils.CreateFormUrlEncodedContent(request)
            };
            httpRequest.Headers.Authorization = request.GetAuthenticationHeader();

            var response = await httpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            return await TokenResponse.FromHttpResponseAsync(response, clock, logger).ConfigureAwait(false);
        }

        /// <summary>
        /// If present, Client ID and Client Secret should be used to perform basic authentication
        /// with Client ID being the username and Client Secret the password.
        /// </summary>
        private static AuthenticationHeaderValue GetAuthenticationHeader(this GoogleWifStsTokenRequest request) =>
            (request.ClientId is string && request.ClientSecret is string)
            ? new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{request.ClientId}:{request.ClientSecret}")))
            : null;
    }
}