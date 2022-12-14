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

using Google.Apis.Json;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Upload;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Upload
{
    public partial class ResumableUploadTest
    {

        /// <summary>
        /// Server that support multiple-chunk uploads.
        /// </summary>
        private class MultiChunkServer : TestServer.Handler
        {
            public MultiChunkServer(TestServer server, bool lowerRange = false, bool ignoreFirstUploadCall = false) : base(server)
            {
                _lowerRange = lowerRange;
                _ignoreFirstUploadCall = ignoreFirstUploadCall;
            }

            public List<byte> Bytes { get; } = new List<byte>();

            /// <summary>
            /// Whether the Range header should be returned as "range" (true) or "Range" (false).
            /// </summary>
            public readonly bool _lowerRange;
            /// <summary>
            /// If this is true, the first upload call is effectively ignored, as if the server couldn't
            /// read the data. This forces us to send it again.
            /// </summary>
            public readonly bool _ignoreFirstUploadCall;
            private int? _length;
            private bool _firstUploadCall = true;

            protected void HandleHeaders(HttpListenerRequest request, HttpListenerResponse response)
            {
                if (_length == null)
                {
                    int length;
                    if (int.TryParse(request.Headers["Content-Range"].Split('/').Last(), out length))
                    {
                        _length = length;
                    }
                }
                if (_length == null || Bytes.Count < _length.Value)
                {
                    response.StatusCode = 308;
                    // If no bytes have been uploaded, no "Range" header is returned.
                    if (Bytes.Count > 0)
                    {
                        response.AddHeader(_lowerRange ? "range" : "Range", $"bytes 0-{Bytes.Count - 1}");
                    }
                }
            }

            protected override async Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case "MultiChunk?uploadType=resumable":
                        response.Headers[HttpResponseHeader.Location] = $"{HttpPrefix}{UploadPath}";
                        return null;
                    case UploadPath:
                        var bytesStream = new MemoryStream();
                        await request.InputStream.CopyToAsync(bytesStream);
                        bool ignoreData = _ignoreFirstUploadCall && _firstUploadCall;
                        if (!ignoreData)
                        {
                            Bytes.AddRange(bytesStream.ToArray());
                        }
                        HandleHeaders(request, response);
                        _firstUploadCall = false;
                        return null;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// An upload in multiple chunks, with no server errors.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInMultipleChunks(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(100, 400, 1000)] int chunkSize,
            [CombinatorialValues(false, true)] bool lowerRange)
        {
            var expectedCallCount = 1 + (UploadLength + chunkSize - 1) / chunkSize;
            using (var server = new MultiChunkServer(_server, lowerRange))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.Equal(expectedCallCount, server.Requests.Count);
                Assert.Equal(UploadTestBytes, server.Bytes);
                Assert.Equal(UploadStatus.Completed, progress.Status);
            }
        }

        // As TestUploadInMultipleChunks, but testing stream interception
        [Theory, CombinatorialData]
        public void TestUploadInMultipleChunks_Interception(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(100, 400, 1000)] int chunkSize,
            [CombinatorialValues(true, false)] bool ignoreFirstUploadCall)
        {
            // One fewer interception call than server calls, as there's no initialization call.
            var expectedInterceptionCount = (UploadLength + chunkSize - 1) / chunkSize;
            using (var server = new MultiChunkServer(_server, ignoreFirstUploadCall: ignoreFirstUploadCall))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                int interceptionCount = 0;
                MemoryStream interceptedBytes = new MemoryStream();
                uploader.UploadStreamInterceptor = (buffer, offset, count) =>
                {
                    interceptedBytes.Write(buffer, offset, count);
                    interceptionCount++;
                };
                var progress = uploader.Upload();
                Assert.Equal(expectedInterceptionCount, interceptionCount);
                Assert.Equal(UploadTestBytes, interceptedBytes.ToArray());
            }
        }

        /// <summary>
        /// Check the upload progress is correct during upload.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadProgress(
            [CombinatorialValues(true, false)] bool knownSize)
        {
            int chunkSize = 200;
            using (var server = new MultiChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = new List<IUploadProgress>();
                uploader.ProgressChanged += p => progress.Add(p);
                uploader.Upload();
                Assert.Equal(4, progress.Count);
                Assert.Equal(UploadStatus.Starting, progress[0].Status);
                Assert.Equal(0, progress[0].BytesSent);
                Assert.Equal(UploadStatus.Uploading, progress[1].Status);
                Assert.Equal(chunkSize, progress[1].BytesSent);
                Assert.Equal(UploadStatus.Uploading, progress[2].Status);
                Assert.Equal(chunkSize * 2, progress[2].BytesSent);
                Assert.Equal(UploadStatus.Completed, progress[3].Status);
                Assert.Equal(UploadLength, progress[3].BytesSent);
            }
        }

        /// <summary>
        /// A multi-chunk server that simulates errors at the specified byte offsets during upload.
        /// </summary>
        private class MultiChunkBadServer : MultiChunkServer
        {
            public MultiChunkBadServer(TestServer server,
                int[] failAtBytes, HttpStatusCode errorCode, string errorMsg = null)
                : base(server)
            {
                _failAtBytes = new List<int>(failAtBytes);
                _errorCode = errorCode;
                _errorMsg = errorMsg == null ? null : Encoding.UTF8.GetBytes(errorMsg);
            }

            private readonly List<int> _failAtBytes;
            private readonly HttpStatusCode _errorCode;
            private readonly IEnumerable<byte> _errorMsg;

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {

                if (RemovePrefix(request.Url.PathAndQuery) == UploadPath &&
                    _failAtBytes.Any() &&
                    _failAtBytes[0] >= Bytes.Count && _failAtBytes[0] < Bytes.Count + request.ContentLength64)
                {
                    _failAtBytes.RemoveAt(0);
                    response.StatusCode = (int) _errorCode;
                    return Task.FromResult(_errorMsg);
                }
                else
                {
                    return base.HandleCall(request, response);
                }
            }
        }

        /// <summary>
        /// Server 404s, with a JSON body.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInBadServer_NotFound_JsonError(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 })] int[] dodgyBytes)
        {
            string jsonError =
                @"{ ""error"": {
                    ""errors"": [
                        {
                            ""domain"": ""global"",
                            ""reason"": ""required"",
                            ""message"": ""Login Required"",
                            ""locationType"": ""header"",
                            ""location"": ""Authorization""
                        }
                    ],
                    ""code"": 401,
                    ""message"": ""Login Required""
                  }}";
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound, jsonError))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", 100);
                IUploadProgress lastProgress = null;
                uploader.ProgressChanged += p => lastProgress = p;
                uploader.Upload();
                Assert.NotNull(lastProgress);
                Assert.Equal(UploadStatus.Failed, lastProgress.Status);
                var exception = Assert.IsType<GoogleApiException>(lastProgress.Exception);
                Assert.Equal("The service TestService has thrown an exception. HttpStatusCode is NotFound. Login Required", exception.Message);
                Assert.Contains("Message[Login Required] Location[Authorization - header] Reason[required] Domain[global]", exception.ToString());
                Assert.Equal("Login Required", exception.Error.Message);
            }
        }

        /// <summary>
        /// Server 404s, with a plain-text (non-JSON) body.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInBadServer_NotFound_PlainTextError(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 })] int[] dodgyBytes)
        {
            string plainTextError = "Not Found";
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound, plainTextError))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", 100);
                IUploadProgress lastProgress = null;
                uploader.ProgressChanged += p => lastProgress = p;
                uploader.Upload();
                Assert.NotNull(lastProgress);
                Assert.Equal(UploadStatus.Failed, lastProgress.Status);
                var exception = Assert.IsType<GoogleApiException>(lastProgress.Exception);
                Assert.Equal("The service TestService has thrown an exception. HttpStatusCode is NotFound. No error message was specified.", exception.Message);
                Assert.Contains(
                    $"The service TestService has thrown an exception.{Environment.NewLine}" +
                    $"HttpStatusCode is NotFound.{Environment.NewLine}" +
                    $"No JSON error details were specified.{Environment.NewLine}" +
                    $"Raw error details are: {plainTextError}", exception.ToString());
                Assert.True(exception.Error.IsOnlyRawContent);
            }
        }

        /// <summary>
        /// Server fails with occasional 500s, which the uploader transparently copes with.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInBadServer_ServerUnavailable(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 }, new[] { 0, 100 })] int[] dodgyBytes,
            [CombinatorialValues(100, 400, 1000)] int chunkSize)
        {
            var expectedCallCount = 1 + (UploadLength + chunkSize - 1) / chunkSize;
            expectedCallCount += dodgyBytes.Length * 2;
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.ServiceUnavailable))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.Equal(expectedCallCount, server.Requests.Count);
                Assert.Equal(UploadTestBytes, server.Bytes);
                Assert.Equal(UploadStatus.Completed, progress.Status);
            }
        }

        /// <summary>
        /// Server fails with 400s, so Resume() calls are required.
        /// </summary>
        /// <remarks>
        /// The test parameters are chosen such that:
        /// Everything is tested with a seekable stream and a non-seekable stream
        /// Server fails on 1st, middle, and last chunk
        /// Chunked in many chunks, 2 chunks and 1 chunk
        /// Buffersize is both larger, smaller, the same, and a divisor of chunkSize
        /// </remarks>
        [Theory, CombinatorialData]
        public void TestUploadInBadServer_NeedsResume(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 }, new[] { 0, 410 })] int[] dodgyBytes,
            [CombinatorialValues(100, 400, 1000)] int chunkSize,
            [CombinatorialValues(4096, 51, 100)] int bufferSize)
        {
            var expectedCallCount = 1 + (UploadLength + chunkSize - 1) / chunkSize
                + dodgyBytes.Length * 2;
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                uploader.BufferSize = bufferSize;
                var progress = uploader.Upload();
                int sanity = 0;
                while (progress.Status == UploadStatus.Failed && sanity++ < 10)
                {
                    progress = uploader.Resume();
                }
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(expectedCallCount, server.Requests.Count);
                Assert.Equal(UploadTestBytes, server.Bytes);
            }
        }

        /// <summary>
        /// Server fails with 400s, so resume calls are required.
        /// Resume is done as if the entire client program has restarted (ie with a fresh uploader).
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInBadServer_UploaderRestart(
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 }, new[] { 0, 410 })] int[] dodgyBytes,
            [CombinatorialValues(100, 400, 1000)] int chunkSize)
        {
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new MemoryStream(UploadTestBytes);
                Uri uploadUri = null;
                IUploadProgress progress;
                {
                    var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                    uploader.UploadSessionData += s => uploadUri = s.UploadUri;
                    progress = uploader.Upload();
                }
                Assert.NotNull(uploadUri);
                int sanity = 0;
                while (progress.Status == UploadStatus.Failed && sanity++ < 10)
                {
                    var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                    progress = uploader.Resume(uploadUri);
                }
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(UploadTestBytes, server.Bytes);
            }
        }

        /// <summary>
        /// Resuming on program restart with a non-seekable stream is not supported.
        /// </summary>
        [Fact]
        public void TestUploadWithUploaderRestart_UnknownSize()
        {
            // Unknown stream size not supported, exception always thrown
            using (var server = new MultiChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "whatever", "PUT", content, "", 100);
                var url = new Uri("http://what.ever/");
                Assert.ThrowsAsync<NotImplementedException>(async () => await uploader.ResumeAsync(url));
            }
        }

        /// <summary>
        /// Server that causes cancellation after a specified number of calls.
        /// </summary>
        private class MultiChunkCancellableServer : MultiChunkServer
        {
            public MultiChunkCancellableServer(TestServer server, int cancelOnCall)
                : base(server)
            {
                _cancelOnCall = cancelOnCall;
                _cancellationSource = new CancellationTokenSource();
            }

            private int _cancelOnCall;
            private CancellationTokenSource _cancellationSource;
            public CancellationToken CancellationToken => _cancellationSource.Token;

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                if (Requests.Count == _cancelOnCall)
                {
                    _cancellationSource.Cancel();
                }
                return base.HandleCall(request, response);
            }
        }

        /// <summary>
        /// Async uploads can be cancelled at any time.
        /// </summary>
        [Theory, CombinatorialData]
        public async Task TestUploadCancelled(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(1, 2, 3, 4, 5)] int cancelOnCall)
        {
            int chunkSize = 100;
            using (var server = new MultiChunkCancellableServer(_server, cancelOnCall))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                if (cancelOnCall == 1)
                {
                    var progress = uploader.UploadAsync(server.CancellationToken).Result;
                    Assert.Equal(UploadStatus.Failed, progress.Status);
                    Assert.IsAssignableFrom<OperationCanceledException>(progress.Exception);
                }
                else
                {
                    await Assert.ThrowsAsync<TaskCanceledException>(
                        () => uploader.UploadAsync(server.CancellationToken));
                }
                Assert.Equal(cancelOnCall, server.Requests.Count);
            }
        }

        /// <summary>
        /// Server that only accepts part of each uploaded chunk.
        /// </summary>
        private class MultiChunkPartialServer : MultiChunkServer
        {
            public MultiChunkPartialServer(TestServer server, int partialSize)
                : base(server)
            {
                _partialSize = partialSize;
            }

            private readonly int _partialSize;

            protected override async Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case UploadPath:
                        var bytesStream = new MemoryStream();
                        await request.InputStream.CopyToAsync(bytesStream);
                        var bytes = bytesStream.ToArray();
                        Bytes.AddRange(bytesStream.ToArray().Take(_partialSize));
                        HandleHeaders(request, response);
                        return null;
                    default:
                        return await base.HandleCall(request, response);
                }
            }
        }

        /// <summary>
        /// Upload correctly handles server accepting only partial uploaded chunks.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadInPartialServer(
            [CombinatorialValues(true, false)] bool knownSize,
            [CombinatorialValues(80, 150)] int partialSize,
            [CombinatorialValues(100, 200)] int chunkSize)
        {
            var actualChunkSize = Math.Min(partialSize, chunkSize);
            var expectedCallCount = (UploadLength + actualChunkSize - 1) / actualChunkSize + 1;
            using (var server = new MultiChunkPartialServer(_server, partialSize))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(UploadTestBytes) : new UnknownSizeMemoryStream(UploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.Equal(expectedCallCount, server.Requests.Count);
                Assert.Equal(UploadTestBytes, server.Bytes);
                Assert.Equal(UploadStatus.Completed, progress.Status);
            }
        }

        /// <summary>
        /// Server that expects an initial call with path and query parameters.
        /// </summary>
        private class MultiChunkQueriedServer : MultiChunkServer
        {
            public MultiChunkQueriedServer(TestServer server, string initialPathAndQuery)
                : base(server)
            {
                _initialPathAndQuery = initialPathAndQuery;
            }

            private string _initialPathAndQuery;

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                if (RemovePrefix(request.Url.PathAndQuery) == _initialPathAndQuery)
                {
                    response.Headers[HttpResponseHeader.Location] = $"{HttpPrefix}{UploadPath}";
                    return Task.FromResult<IEnumerable<byte>>(null);
                }
                else
                {
                    return base.HandleCall(request, response);
                }
            }
        }

        /// <summary>
        /// Uploader with path and query parameters.
        /// </summary>
        private class TestResumableUploadWithParameters : TestResumableUpload
        {
            public TestResumableUploadWithParameters(IClientService service, string path, string method, Stream stream,
                string contentType, int chunkSize)
                : base(service, path, method, stream, contentType, chunkSize) { }

            [RequestParameter("id", RequestParameterType.Path)]
            public int Id { get; set; }

            [RequestParameter("queryA", RequestParameterType.Query)]
            public string QueryA { get; set; }

            [RequestParameter("queryB", RequestParameterType.Query)]
            public string QueryB { get; set; }

            [RequestParameter("time", RequestParameterType.Query)]
            public DateTime? MinTime { get; set; }
        }

        /// <summary>
        /// Uploader correctly adds path and query parameters to initial server call.
        /// </summary>
        [Fact]
        public void TestUploadWithQueryAndPathParameters()
        {
            var id = 123;
            var queryA = "valuea";
            var queryB = "VALUEB";
            var pathAndQuery = $"testPath/{id}?uploadType=resumable&queryA={queryA}&queryB={queryB}&time=2002-02-25T12%3A57%3A32.777Z";
            using (var server = new MultiChunkQueriedServer(_server, pathAndQuery))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = new MemoryStream(UploadTestBytes);
                var uploader = new TestResumableUploadWithParameters(service, "testPath/{id}", "POST", content, "text/plain", 100)
                {
                    Id = id,
                    QueryA = "valuea",
                    QueryB = "VALUEB",
                    MinTime = new DateTime(2002, 2, 25, 12, 57, 32, 777, DateTimeKind.Utc),
                };
                var progress = uploader.Upload();
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(6, server.Requests.Count);
            }
        }

        /// <summary>A mock request object.</summary>
        private class TestRequest : IEquatable<TestRequest>
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public bool Equals(TestRequest other)
            {
                if (other == null)
                {
                    return false;
                }

                return Name == null ? other.Name == null : Name.Equals(other.Name) &&
                    Description == null ? other.Description == null : Description.Equals(other.Description);
            }
        }

        /// <summary>A mock response object.</summary>
        private class TestResponse : IEquatable<TestResponse>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public bool Equals(TestResponse other)
            {
                if (other == null)
                {
                    return false;
                }

                return Id.Equals(other.Id) &&
                    Name == null ? other.Name == null : Name.Equals(other.Name) &&
                    Description == null ? other.Description == null : Description.Equals(other.Description);
            }
        }

        /// <summary>
        /// Server that processes request body and response body.
        /// </summary>
        private class MultiChunkRequestResponseServer<TRequest, TResponse> : MultiChunkServer
        {
            public MultiChunkRequestResponseServer(TestServer server, TResponse expectedResponse)
                : base(server)
            {
                _expectedResponse = expectedResponse;
            }

            private TResponse _expectedResponse;
            public TRequest Request { get; private set; } = default(TRequest);

            protected override async Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                var ret = await base.HandleCall(request, response);
                var serializer = new NewtonsoftJsonSerializer();
                if (Requests.Count == 1)
                {
                    Request = serializer.Deserialize<TRequest>(request.InputStream);
                }
                var responseBody = new MemoryStream();
                serializer.Serialize(_expectedResponse, responseBody);
                return responseBody.ToArray();
            }
        }

        /// <summary>
        /// Uploader with request and response bodies.
        /// </summary>
        private class TestResumableUploadWithResponse<TRequest, TResponse> : ResumableUpload<TRequest, TResponse>
        {
            public TestResumableUploadWithResponse(IClientService service, string path, string method, Stream stream,
                string contentType, int chunkSize)
                : base(service, path, method, stream, contentType)
            {
                this.chunkSize = chunkSize;
            }
        }

        /// <summary>
        /// Uploader correctly processes request and response bodies.
        /// </summary>
        [Theory, CombinatorialData]
        public void TestUploadWithRequestAndResponseBody(
            [CombinatorialValues(false)] bool gzipEnabled) // TODO: Also with zip
        {
            var body = new TestRequest
            {
                Name = "test object",
                Description = "the description",
            };
            var expectedResponse = new TestResponse
            {
                Name = "foo",
                Id = 100,
                Description = "bar",
            };
            using (var server = new MultiChunkRequestResponseServer<TestRequest, TestResponse>(_server, expectedResponse))
            using (var service = new MockClientService(new BaseClientService.Initializer
            {
                GZipEnabled = gzipEnabled
            }, server.HttpPrefix))
            {
                var content = new MemoryStream(UploadTestBytes);
                var uploader = new TestResumableUploadWithResponse<TestRequest, TestResponse>(
                    service, "MultiChunk", "POST", content, "text/plain", 100)
                {
                    Body = body,
                };
                TestResponse response = null;
                int reponseReceivedCount = 0;
                uploader.ResponseReceived += (r) => { response = r; reponseReceivedCount++; };
                var progress = uploader.Upload();
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(body, server.Request);
                Assert.Equal(expectedResponse, response);
                Assert.Equal(expectedResponse, uploader.ResponseBody);
                Assert.Equal(1, reponseReceivedCount);
            }
        }
    }
}
