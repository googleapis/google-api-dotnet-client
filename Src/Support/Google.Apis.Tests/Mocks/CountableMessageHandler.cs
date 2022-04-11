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

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace Google.Apis.Tests.Mocks
{
    /// <summary>Base mock message handler which counts the number of calls.</summary>
    public abstract class CountableMessageHandler : HttpMessageHandler
    {
        private int _calls;
        private readonly ConcurrentQueue<HttpRequestMessage> _requests = new ConcurrentQueue<HttpRequestMessage>();

        /// <summary>Gets or sets the calls counter.</summary>
        public int Calls
        {
            get { return _calls; }
        }

        public IEnumerable<HttpRequestMessage> Requests => _requests;

        sealed protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage
            request, CancellationToken cancellationToken)
        {
            Interlocked.Increment(ref _calls);
            _requests.Enqueue(request);
            return SendAsyncCore(request, cancellationToken);
        }

        /// <summary>The core implementation of send async that a derived class must implement.</summary>
        protected abstract System.Threading.Tasks.Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage
            request, CancellationToken cancellationToken);
    }
}
