/*
Copyright 2017 Google Inc

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

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>
    /// Helper for tests for HttpHandlers.
    /// </summary>
    internal static class HandlerTestHelper
    {
        /// <summary>
        /// Processes the given request in the given handler. This basically
        /// works around the annoyance that SendAsync is protected.
        /// </summary>
        internal static Task<HttpResponseMessage> ProcessRequestAsync(
            HttpMessageHandler handler, HttpRequestMessage request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var trampoline = new TestHandler(handler);
            return trampoline.ExposedSendAync(request, cancellationToken);
        }

        /// <summary>
        /// Creates a handler that will return the given response message.
        /// </summary>
        internal static HttpMessageHandler CreateHandler(HttpResponseMessage response) =>
            new SingleResponseHandler(response);

        private class TestHandler : DelegatingHandler
        {
            internal TestHandler(HttpMessageHandler handler) : base(handler)
            {
            }

            internal Task<HttpResponseMessage> ExposedSendAync(
                HttpRequestMessage request, CancellationToken cancellationToken) =>
                base.SendAsync(request, cancellationToken);
        }

        private class SingleResponseHandler : HttpMessageHandler
        {
            private readonly HttpResponseMessage _response;

            internal SingleResponseHandler(HttpResponseMessage response)
            {
                _response = response;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
                => Task.FromResult(_response);
        }
    }
}
