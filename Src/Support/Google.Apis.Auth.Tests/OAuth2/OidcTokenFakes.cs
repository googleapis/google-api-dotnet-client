/*
Copyright 2020 Google Inc

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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.Tests.OAuth2
{
    internal class OidcTokenSuccessMessageHandler : CountableMessageHandler
    {
        private readonly IClock _clock;

        public HttpRequestMessage LatestRequest { get; private set; }
        public string LatestRequestContent { get; private set; }

        public OidcTokenSuccessMessageHandler(IClock clock) => _clock = clock;

        protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            LatestRequest = request;
            // We need this because by the time we are back on test code this stream is closed.
            if (request.Content != null)
            {
                LatestRequestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            TokenResponse token = new TokenResponse
            {
                AccessToken = $"very_fake_access_token_{Calls}",
                ExpiresInSeconds = (long)TimeSpan.FromHours(1).TotalSeconds,
                IssuedUtc = _clock.UtcNow
            };
            var serializedToken = NewtonsoftJsonSerializer.Instance.Serialize(token);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(serializedToken),
                RequestMessage = request
            };
            return response;
        }
    }
}
