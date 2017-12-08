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

using Google.Apis.Http;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Http
{
    public class GzipDeflateHandlerTest
    {
        [Fact]
        public async Task PlainTextContentLeftAlone()
        {
            var request = new HttpRequestMessage();
            var response = new HttpResponseMessage
            {
                Content = new StringContent("Text")
            };
            await RunRequestAsync(request, response);
            Assert.Equal("Text", await response.Content.ReadAsStringAsync());
            AssertAcceptEncodingHeaders(request);
        }

        [Fact]
        public async Task DeflateContentDecompressed()
        {
            var request = new HttpRequestMessage();
            var response = new HttpResponseMessage
            {
                Content = CreateContent("Text", stream => new DeflateStream(stream, CompressionMode.Compress, true), "deflate"),
            };
            await RunRequestAsync(request, response);
            Assert.Equal("Text", await response.Content.ReadAsStringAsync());
            AssertAcceptEncodingHeaders(request);
            AssertContentEncodings(response);
        }

        [Fact]
        public async Task GzipContentDecompressed()
        {
            var request = new HttpRequestMessage();
            var response = new HttpResponseMessage
            {
                Content = CreateContent("Text", stream => new GZipStream(stream, CompressionMode.Compress, true), "gzip"),
            };
            await RunRequestAsync(request, response);
            Assert.Equal("Text", await response.Content.ReadAsStringAsync());
            AssertAcceptEncodingHeaders(request);
            AssertContentEncodings(response);
        }

        [Fact]
        public async Task OnlyLastContentEncodingRelevant()
        {
            var request = new HttpRequestMessage();
            var response = new HttpResponseMessage
            {
                Content = new StringContent("Text") { Headers = { ContentEncoding = { "gzip", "identity" } } }
            };
            await RunRequestAsync(request, response);
            Assert.Equal("Text", await response.Content.ReadAsStringAsync());
            AssertAcceptEncodingHeaders(request);
            AssertContentEncodings(response, "gzip", "identity");
        }

        [Fact]
        public async Task LastContentEncodingRemoved()
        {
            var request = new HttpRequestMessage();
            var response = new HttpResponseMessage
            {
                Content = CreateContent("Text", stream => new GZipStream(stream, CompressionMode.Compress, true), "foo", "bar", "gzip"),
            };
            await RunRequestAsync(request, response);
            Assert.Equal("Text", await response.Content.ReadAsStringAsync());
            AssertAcceptEncodingHeaders(request);
            AssertContentEncodings(response, "foo", "bar");
        }

        private StreamContent CreateContent(string text, Func<Stream, Stream> streamProvider, params string[] contentEncodings)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var compressor = streamProvider(memoryStream))
            {
                compressor.Write(data, 0, data.Length);
            }
            memoryStream.Position = 0;
            var content = new StreamContent(memoryStream);
            foreach (var contentEncoding in contentEncodings)
            {
                content.Headers.ContentEncoding.Add(contentEncoding);
            }
            return content;
        }

        private void AssertAcceptEncodingHeaders(HttpRequestMessage request)
        {
            var acceptEncodings = request.Headers.AcceptEncoding.Select(h => h.Value);
            Assert.Contains("gzip", acceptEncodings);
            Assert.Contains("deflate", acceptEncodings);
        }

        private void AssertContentEncodings(HttpResponseMessage response, params string[] expectedEncodings)
        {
            var contentEncodings = response.Content.Headers.ContentEncoding;
            Assert.Equal(expectedEncodings, contentEncodings);
        }

        private Task RunRequestAsync(HttpRequestMessage request, HttpResponseMessage response)
        {
            var handler = new GzipDeflateHandler(HandlerTestHelper.CreateHandler(response));
            return HandlerTestHelper.ProcessRequestAsync(handler, request);
        }        
    }
}
