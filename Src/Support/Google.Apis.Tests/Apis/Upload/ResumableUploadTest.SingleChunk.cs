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

using Google.Apis.Tests.Mocks;
using Google.Apis.Upload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Upload
{
    public partial class ResumableUploadTest
    {
        /// <summary>
        /// Server that only handles an upload completing in a single chunk.
        /// </summary>
        private class SingleChunkServer : TestServer.Handler
        {
            public SingleChunkServer(TestServer server) : base(server) { }

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case "SingleChunk?uploadType=resumable":
                        response.Headers[HttpResponseHeader.Location] = $"{HttpPrefix}{UploadPath}";
                        break;
                    case UploadPath:
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                return Task.FromResult<IEnumerable<byte>>(null);
            }
        }

        /// <summary>
        /// Upload completes in a single chunk.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInSingleChunk(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues("", "text/plain")] string contentType,
            [CombinatorialValues(0, 10)] int chunkSizeDelta)
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(
                    service, "SingleChunk", "POST", content, contentType, UploadLength + chunkSizeDelta);
                var progress = uploader.Upload();
                Assert.Equal(2, server.Requests.Count);
                var r0 = server.Requests[0];
                Assert.Equal(contentType, r0.Headers["X-Upload-Content-Type"]);
                Assert.Equal(knownSize ? UploadTestBytes.Length.ToString() : null, r0.Headers["X-Upload-Content-Length"]);
                var r1 = server.Requests[1];
                Assert.Equal(UploadPath, server.RemovePrefix(r1.Url.AbsolutePath));
                Assert.Equal($"bytes 0-{UploadLength - 1}/{UploadLength}", r1.Headers["Content-Range"]);
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(UploadTestBytes.Length, progress.BytesSent);
            }
        }

        /// <summary>
        /// An upload using a pre-established session.
        /// </summary>
        [Theory, CombinatorialData]
        public async Task TestInitiatedResumableUpload(
            [CombinatorialValues("", "text/plain")] string contentType)
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new MemoryStream(UploadTestBytes);
                var tmpUploader = new TestResumableUpload(
                    service, "SingleChunk", "POST", content, contentType, UploadLength);
                var uploadUri = await tmpUploader.InitiateSessionAsync();

                var uploader = ResumableUpload.CreateFromUploadUri(uploadUri, content);
                var progress = uploader.Upload();

                Assert.Equal(2, server.Requests.Count);
                var r0 = server.Requests[0];
                Assert.Equal(contentType, r0.Headers["X-Upload-Content-Type"]);
                Assert.Equal(UploadTestBytes.Length.ToString(), r0.Headers["X-Upload-Content-Length"]);
                var r1 = server.Requests[1];
                Assert.Equal(UploadPath, server.RemovePrefix(r1.Url.AbsolutePath));
                Assert.Equal($"bytes 0-{UploadLength - 1}/{UploadLength}", r1.Headers["Content-Range"]);
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(UploadTestBytes.Length, progress.BytesSent);
            }
        }

        /// <summary>
        /// Upload of an empty file.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadEmptyFile(
            [CombinatorialValues(true, false)] bool knownSize)
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(new byte[0]) : new UnknownSizeMemoryStream(new byte[0]);
                var uploader = new TestResumableUpload(service, "SingleChunk", "POST", content, "text/plain", 100);
                var progress = uploader.Upload();
                Assert.Equal(2, server.Requests.Count);
                var r0 = server.Requests[0];
                Assert.Equal(knownSize ? "0" : null, r0.Headers["X-Upload-Content-Length"]);
                var r1 = server.Requests[1];
                Assert.Equal(UploadPath, server.RemovePrefix(r1.Url.AbsolutePath));
                Assert.Equal("bytes *" + "/0", r1.Headers["Content-Range"]);
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(0, progress.BytesSent);
            }
        }

        [Fact]
        public void TestUploadStreamDisposedBeforeConstruction()
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new MemoryStream(new byte[10]);
                content.Dispose();
                var uploader = new TestResumableUpload(service, "SingleChunk", "POST", content, "text/plain", 100);
                var progress = uploader.Upload();
                Assert.IsType<ObjectDisposedException>(progress.Exception);
            }
        }

        [Fact]
        public void TestUploadStreamDisposedBetweenConstructionAndUpload()
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new MemoryStream(new byte[10]);
                var uploader = new TestResumableUpload(service, "SingleChunk", "POST", content, "text/plain", 100);
                content.Dispose();
                var progress = uploader.Upload();
                Assert.IsType<ObjectDisposedException>(progress.Exception);
            }
        }
    }
}
