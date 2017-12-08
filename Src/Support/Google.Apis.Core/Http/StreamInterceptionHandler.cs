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
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>
    /// An HttpMessageHandler that (conditionally) intercepts response streams, allowing inline
    /// stream processing. An interceptor provider function is fetched from each request via the
    /// <see cref="ConfigurableMessageHandler.ResponseStreamInterceptorProviderKey"/> property;
    /// if the property is not present on the request (or is null), the response will definitely not be
    /// intercepted. If the property is present and non-null, the interceptor provider is called for
    /// the response. This may return a null reference, indicating that interception isn't required, and
    /// the response can be returned as-is. Otherwise, we use a <see cref="StreamReplacingHttpContent"/>
    /// with an intercepting stream which passes all data read to the interceptor.
    /// </summary>
    internal sealed class StreamInterceptionHandler : DelegatingHandler
    {
        internal StreamInterceptionHandler(HttpMessageHandler handler) : base(handler)
        {
        }

        /// <summary>
        /// For each request, check whether we 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var responseTask = base.SendAsync(request, cancellationToken);
            var provider = GetInterceptorProvider(request);
            return provider == null ? responseTask : ReplaceAsync(responseTask, provider);
        }

        private async Task<HttpResponseMessage> ReplaceAsync(Task<HttpResponseMessage> responseTask, Func<HttpResponseMessage, StreamInterceptor> interceptorProvider)
        {
            var response = await responseTask.ConfigureAwait(false);
            var interceptor = interceptorProvider(response);
            if (interceptor != null)
            {
                response.Content = new StreamReplacingHttpContent(response.Content, stream => new InterceptingStream(stream, interceptor));
            }
            return response;
        }

        internal static Func<HttpResponseMessage, StreamInterceptor> GetInterceptorProvider(HttpRequestMessage request)
        {
            request.Properties.TryGetValue(ConfigurableMessageHandler.ResponseStreamInterceptorProviderKey, out var property);
            // If anyone adds a property of the wrong type, just ignore it.
            return property as Func<HttpResponseMessage, StreamInterceptor>;
        }

        private sealed class InterceptingStream : Stream
        {
            private readonly Stream _original;
            private readonly StreamInterceptor _interceptor;

            // We're a read-only stream, and we can't seek (as the interceptor will assume the content is read sequentially).
            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;

            // Although we say we can't seek, we can return the length and current position.
            // This may never be used, but is harmless to expose.
            public override long Length => _original.Length;
            public override long Position { get => _original.Position; set => throw new NotSupportedException(); }

            internal InterceptingStream(Stream original, StreamInterceptor interceptor)
            {
                _original = original;
                _interceptor = interceptor;
            }

            // Read methods which need to intercept the content.
            public override int Read(byte[] buffer, int offset, int count)
            {
                // Perform the actual read, and then intercept just the content we read.
                int ret = _original.Read(buffer, offset, count);
                _interceptor(buffer, offset, ret);
                return ret;
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                // Perform the actual read, and then intercept just the content we read.
                var ret = await _original.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                _interceptor(buffer, offset, ret);
                return ret;
            }

            // Delegating methods
            protected override void Dispose(bool disposing) => _original.Dispose();

            // Almost certainly pointless, but harmless.
            public override void Flush() => _original.Flush();

            // Unsupported methods
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }
    }
}
