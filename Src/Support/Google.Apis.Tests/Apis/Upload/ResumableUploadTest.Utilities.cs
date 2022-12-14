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

using Google.Apis.Services;
using Google.Apis.Upload;
using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Threading;
using Xunit.Abstractions;

namespace Google.Apis.Tests.Apis.Upload
{
    public partial class ResumableUploadTest
    {
        /// <summary>
        /// Stream that doesn't support seeking.
        /// </summary>
        private class UnknownSizeMemoryStream : MemoryStream
        {
            public UnknownSizeMemoryStream(byte[] buffer) : base(buffer) { }
            public override bool CanSeek => false;
            public override long Seek(long offset, SeekOrigin loc)
            {
                throw new NotSupportedException();
            }
            public override long Position
            {
                get { return base.Position; }
                set { throw new NotSupportedException(); }
            }
        }

        /// <summary>
        /// Resumable upload class that allows chunksize to be set for testing.
        /// </summary>
        private class TestResumableUpload : ResumableUpload<object>
        {
            public TestResumableUpload(IClientService service, string path, string method, Stream stream,
                string contentType, int chunkSize)
                : base(service, path, method, stream, contentType)
            {
                this.chunkSize = chunkSize;
            }
        }

        /// <summary>
        /// Information about each request made to the server.
        /// </summary>
        private class RequestInfo
        {
            public RequestInfo(HttpListenerRequest request)
            {
                Headers = request.Headers;
                Url = request.Url;
            }
            public NameValueCollection Headers { get; }
            public Uri Url { get; }
        }

        /// <summary>
        /// Wrapper around <see cref="ITestOutputHelper"/> which keep an incrementing
        /// counter to allow easy differentiation between separate tests.
        /// </summary>
        private class TestLogger
        {
            private static int _counter;
            private readonly int _id;
            private readonly ITestOutputHelper _outputHelper;

            internal TestLogger(ITestOutputHelper outputHelper)
            {
                _outputHelper = outputHelper;
                _id = Interlocked.Increment(ref _counter);
            }

            internal void WriteLine(string message) =>
                _outputHelper.WriteLine($"Test {_id:0000} at {DateTime.UtcNow:HH:mm:ss.fff}: {message}");
        }
    }
}
