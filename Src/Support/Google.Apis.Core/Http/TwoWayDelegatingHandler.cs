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

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>
    /// An HttpMessageHandler that delegates to one of two inner handlers based on a condition
    /// checked on each request.
    /// </summary>
    internal sealed class TwoWayDelegatingHandler : DelegatingHandler
    {
        private readonly AccessibleDelegatingHandler _alternativeHandler;
        private readonly Func<HttpRequestMessage, bool> _useAlternative;
        private bool disposed = false;

        internal TwoWayDelegatingHandler(HttpMessageHandler normalHandler, HttpMessageHandler alternativeHandler, Func<HttpRequestMessage, bool> useAlternative)
            : base(normalHandler)
        {
            _alternativeHandler = new AccessibleDelegatingHandler(alternativeHandler);
            _useAlternative = useAlternative;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            _useAlternative(request) ? _alternativeHandler.InternalSendAsync(request, cancellationToken) : base.SendAsync(request, cancellationToken);

        protected override void Dispose(bool disposing)
        {
            if (disposing && !disposed)
            {
                disposed = true;
                try
                {
                    base.Dispose();
                }
                finally
                {
                    _alternativeHandler.Dispose();
                }
            }
        }

        /// <summary>
        /// Handler to wrap another, just so that we can effectively expose its SendAsync method.
        /// </summary>
        private sealed class AccessibleDelegatingHandler : DelegatingHandler
        {
            internal AccessibleDelegatingHandler(HttpMessageHandler innerHandler) : base(innerHandler)
            {
            }

            internal Task<HttpResponseMessage> InternalSendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
                SendAsync(request, cancellationToken);
        }
    }
}
