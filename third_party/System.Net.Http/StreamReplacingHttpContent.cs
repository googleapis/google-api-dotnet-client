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
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>
    /// An HttpContent based on an existing one, but allowing the stream to be replaced.
    /// This is similar to StreamContent, but it defers the stream creation until it's requested by the client.
    /// (An alternative would be to use StreamContent with a custom stream that only retrieved the stream when
    /// first used.) Headers are copied from the original content.
    /// </summary>
    internal sealed class StreamReplacingHttpContent : HttpContent
    {
        private readonly HttpContent _originalContent;
        private readonly Func<Stream, Stream> _replacement;
        private bool _streamCreated = false;

        internal StreamReplacingHttpContent(HttpContent originalContent, Func<Stream, Stream> replacement)
        {
            _originalContent = originalContent;
            _replacement = replacement;

            foreach (var header in originalContent.Headers)
            {
                Headers.Add(header.Key, header.Value);
            }
        }

        // Unfortunately we can't delegate this to the original content even if we know the length hasn't changed,
        // as TryComputeLength is protected.
        protected override bool TryComputeLength(out long length)
        {
            length = 0;
            return false;
        }

        protected override async Task<Stream> CreateContentReadStreamAsync()
        {
            if (_streamCreated)
            {
                throw new InvalidOperationException("Cannot read content stream more than once");
            }
            _streamCreated = true;
            var originalStream = await _originalContent.ReadAsStreamAsync().ConfigureAwait(false);
            return _replacement(originalStream);
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            using (Stream contentStream = await CreateContentReadStreamAsync().ConfigureAwait(false))
            {
                await contentStream.CopyToAsync(stream).ConfigureAwait(false);
            }
        }
    }
}
