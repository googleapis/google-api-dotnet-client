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
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>
    /// An HttpMessageHandler that performs decompression for Deflate and Gzip content.
    /// </summary>
    internal sealed class GzipDeflateHandler : DelegatingHandler
    {
        private const string GzipEncoding = "gzip";
        private const string DeflateEncoding = "deflate";

        private static readonly StringWithQualityHeaderValue s_gzipAcceptHeader =
            new StringWithQualityHeaderValue(GzipEncoding);
        private static readonly StringWithQualityHeaderValue s_deflateAcceptHeader =
            new StringWithQualityHeaderValue(DeflateEncoding);
        
        private static readonly Func<Stream, Stream> s_gzipReplacement =
            original => new GZipStream(original, CompressionMode.Decompress);

        private static readonly Func<Stream, Stream> s_deflateReplacement =
            original => new DeflateStream(original, CompressionMode.Decompress);
        
        internal GzipDeflateHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.AcceptEncoding.Add(s_gzipAcceptHeader);
            request.Headers.AcceptEncoding.Add(s_deflateAcceptHeader);

            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            var originalContent = response.Content;
            var lastContentEncoding = originalContent.Headers.ContentEncoding.LastOrDefault();

            Func<Stream, Stream> replacement =
                lastContentEncoding == GzipEncoding ? s_gzipReplacement
                : lastContentEncoding == DeflateEncoding ? s_deflateReplacement
                : null;

            if (replacement != null)
            {
                response.Content = new StreamReplacingHttpContent(originalContent, replacement);
                var headers = response.Content.Headers;
                // We don't know what the content length will be any more.
                headers.ContentLength = null;
                // Remove the last encoding (because we're handling it).
                // This is slightly ugly due to the API offered by ICollection<T>.
                headers.ContentEncoding.Clear();
                string previous = null;
                foreach (var encoding in originalContent.Headers.ContentEncoding)
                {
                    if (previous != null)
                    {
                        headers.ContentEncoding.Add(previous);
                    }
                    previous = encoding;
                }
            }
            return response;
        }
    }
}
