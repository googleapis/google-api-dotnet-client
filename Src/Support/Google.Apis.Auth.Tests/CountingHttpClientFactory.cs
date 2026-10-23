/*
Copyright 2026 Google LLC

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

using Google.Apis.Http;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.Tests
{
    internal class CountingHttpClientFactory : IHttpClientFactory
    {
        private readonly string _responseJson;
        public int Calls { get; private set; }

        public CountingHttpClientFactory(string responseJson) => _responseJson = responseJson;

        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args)
        {
            Calls++;
            var handler = new FakeMessageHandler(_responseJson);
            return new ConfigurableHttpClient(new ConfigurableMessageHandler(handler));
        }

        private class FakeMessageHandler : HttpMessageHandler
        {
            private readonly string _response;
            public FakeMessageHandler(string response) => _response = response;

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(_response, Encoding.UTF8, "application/json")
                };
                return Task.FromResult(response);
            }
        }
    }
}
