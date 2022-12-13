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
using Google.Apis.Tests.Mocks;
using Google.Apis.Upload;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Google.Apis.Tests.Apis.Upload
{
    /// <summary>
    /// Tests of resumable upload, that uses a real HTTP server.
    /// </summary>
    public class ResumableUploadTest : IDisposable
    {
        #region Tests

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
            [CombinatorialValues(new[] { 0 }, new[] { 100 }, new[] { 410 }, new[] { 0, 411 })] int[] dodgyBytes,
            [CombinatorialValues(100, 400, 1000)] int chunkSize,
            [CombinatorialValues(4096, 51, 100)] int bufferSize)
        {
            _testLogger.WriteLine($"TestUploadInBadServer_NeedsResume: {knownSize}, {dodgyBytes.Last()}, {chunkSize}, {bufferSize}");
            var expectedCallCount = 1 + (uploadLength + chunkSize - 1) / chunkSize
                + dodgyBytes.Length * 2;
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize, _testLogger);
                uploader.BufferSize = bufferSize;
                var progress = uploader.Upload();
                int sanity = 0;
                while (progress.Status == UploadStatus.Failed && sanity++ < 10)
                {
                    progress = uploader.Resume();
                }
                Assert.Equal(UploadStatus.Completed, progress.Status);
                Assert.Equal(expectedCallCount, server.Requests.Count);
                Assert.Equal(uploadTestBytes, server.Bytes);
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
            _testLogger.WriteLine($"TestUploadCancelled: {knownSize}, {cancelOnCall}");
            int chunkSize = 100;
            using (var server = new MultiChunkCancellableServer(_server, cancelOnCall))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new TestResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize, _testLogger);
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

#endregion

#region The rest
        /// <summary>
        /// Mock string to upload to the media server. It contains 454 bytes, and in most cases we will use a chunk 
        /// size of 100. There are 3 spaces on the end of each line because the original carriage return line endings
        /// caused differences between Windows and Linux test results.
        /// </summary>
        static readonly string UploadTestData =
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod   " +
            "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris   " +
            "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore   " +
            "eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit   " +
            "anim id est laborum.";
        static readonly byte[] uploadTestBytes = Encoding.UTF8.GetBytes(UploadTestData);
        static readonly int uploadLength = uploadTestBytes.Length;

        /// <summary>
        /// URL used for the resumable upload.
        /// </summary>
        private const string uploadPath = "resume";

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
        /// resumable upload class that allows chunksize to be set for testing.
        /// </summary>
        private class TestResumableUpload : ResumableUpload<object>
        {
            private readonly TestLogger _testLogger;

            public TestResumableUpload(IClientService service, string path, string method, Stream stream,
                string contentType, int chunkSize, TestLogger testOutputHelper)
                : base(service, path, method, stream, contentType)
            {
                this.chunkSize = chunkSize;
                _testLogger = testOutputHelper;
                ProgressChanged += ProgressOutput;
            }

            private void ProgressOutput(IUploadProgress progress)
            {
                _testLogger.WriteLine($"Status {progress.Status}");
                _testLogger.WriteLine($"BytesSent {progress.BytesSent}");
                _testLogger.WriteLine($"Exception {progress.Exception?.ToString() ?? "None"}");
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

            public override string ToString()
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Url: {Url}");
                foreach(var key in Headers.AllKeys)
                {
                    foreach(var value in Headers.GetValues(key))
                    {
                        builder.AppendLine($"{key}: {value}");
                    }
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// HTTP server which listens on localhost:&lt;random port&gt; for testing.
        /// </summary>
        /// <remarks>
        /// <para>A single server is started for all tests, and is shutdown when all tests
        /// have run.</para>
        /// <para>Each test registers its own <see cref="Handler"/> with a unique
        /// URL path prefix, with the handler designed to fake a server with the
        /// required behaviour for the specific test. The test handler is unregistered
        /// when the test ends.</para>
        /// </remarks>
        private class TestServer : IDisposable
        {
            private readonly TestLogger _testLogger;

            public TestServer(TestLogger testLogger)
            {
                _testLogger = testLogger;
                var rnd = new Random();
                // Find an available port and start an HttpListener.
                do
                {
                    _httpListener = new HttpListener();
                    _httpListener.IgnoreWriteExceptions = true;
                    HttpPrefix = $"http://localhost:{rnd.Next(49152, 65535)}/";
                    _httpListener.Prefixes.Add(HttpPrefix);
                    try
                    {
                        testLogger.WriteLine("Starting server");
                        _httpListener.Start();
                        testLogger.WriteLine("Server started");
                    }
                    // Catch errors that mean the port is already in use
                    catch (HttpListenerException e) when (e.ErrorCode == 183 || e.ErrorCode == 32 || e.Message.Contains("already in use"))
                    {
                        testLogger.WriteLine("Address in use (1); retrying");
                        _httpListener.Close();
                        _httpListener = null;
                    }
                    catch (SocketException e) when (e.SocketErrorCode == SocketError.AddressAlreadyInUse)
                    {
                        testLogger.WriteLine("Address in use (2); retrying");
                        _httpListener.Close();
                        _httpListener = null;
                    }
                } while (_httpListener == null);
                _httpTask = RunServer();
            }

            private readonly HttpListener _httpListener;
            private readonly Task _httpTask;

            public string HttpPrefix { get; }

            private async Task RunServer()
            {
                int requestCount = 0;
                while (_httpListener.IsListening)
                {
                    var context = await _httpListener.GetContextAsync();
                    int requestId = Interlocked.Increment(ref requestCount);
                    _testLogger.WriteLine($"Received request {requestId}");
                    var response = context.Response;
                    if (context.Request.Url.AbsolutePath.EndsWith("/Quit"))
                    {
                        response.Close();
                        _httpListener.Stop();
                    }
                    else
                    {
                        response.ContentType = "text/plain";
                        IEnumerable<byte> body;
                        try
                        {
                            _testLogger.WriteLine($"Handling request {requestId}");
                            body = await HandleCall(context.Request, response);
                            _testLogger.WriteLine($"Handled request {requestId}; response status: {response.StatusCode}");
                            var bodyBytes = body?.ToArray() ?? new byte[0];
                            await response.OutputStream.WriteAsync(bodyBytes, 0, bodyBytes.Length);
                        }
                        catch (HttpListenerException ex)
                        {
                            _testLogger.WriteLine($"Request {requestId}: Test Server Exception {ex}");
                        }
                        finally
                        {
                            try
                            {
                                response.Close();
                            }
                            catch (Exception ex)
                            {
                                _testLogger.WriteLine($"Request {requestId}: Test Server exception when closing response {ex}");
                            }
                        }
                    }
                }
            }

            public abstract class Handler : IDisposable
            {
                private static int handlerId = 0;

                private TestServer _server;
                protected TestLogger Logger => _server._testLogger;

                public Handler(TestServer server)
                {
                    _server = server;
                    Id = Interlocked.Increment(ref handlerId).ToString();
                    _server.RegisterHandler(this);
                }

                public string Id { get; }
                public string HttpPrefix => $"{_server.HttpPrefix}{Id}/";

                public string RemovePrefix(string s)
                {
                    var prefix = $"/{Id}/";
                    if (s.StartsWith(prefix))
                    {
                        return s.Substring(prefix.Length);
                    }
                    throw new InvalidOperationException("Doesn't start with prefix");
                }

                public List<RequestInfo> Requests { get; } = new List<RequestInfo>();

                public async Task<IEnumerable<byte>> HandleCall0(
                    HttpListenerRequest request, HttpListenerResponse response)
                {
                    var requestInfo = new RequestInfo(request);
                    Requests.Add(requestInfo);
                    _server._testLogger.WriteLine($"Request: {requestInfo}");
                    var result = await HandleCall(request, response).ConfigureAwait(false);
                    _server._testLogger.WriteLine($"Response status / content type: {response.StatusCode}/{response.ContentType}");
                    return result;
                }

                protected abstract Task<IEnumerable<byte>> HandleCall(
                    HttpListenerRequest request, HttpListenerResponse response);

                public void Dispose()
                {
                    _server.UnregisterHandler(Id);
                }
            }

            private ConcurrentDictionary<string, Handler> _handlers =
                new ConcurrentDictionary<string, Handler>();

            private Task<IEnumerable<byte>> HandleCall(
                HttpListenerRequest request, HttpListenerResponse response)
            {
                var id = request.Url.Segments[1].TrimEnd('/');
                var handler = _handlers[id];
                return handler.HandleCall0(request, response);
            }

            private void RegisterHandler(Handler handler)
            {
                _handlers.TryAdd(handler.Id, handler);
            }

            private void UnregisterHandler(string id)
            {
                Handler handler;
                _handlers.TryRemove(id, out handler);
            }

            public void Dispose()
            {
                var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(5));
                _httpTask.ContinueWith(task => timeout.Cancel());
                Task.Run(async () =>
                {
                    await new HttpClient().GetAsync(HttpPrefix + "Quit", timeout.Token);
                    _httpListener.Stop();
                });
                _httpTask.Wait();
            }
        }

        public ResumableUploadTest(ITestOutputHelper outputHelper)
        {
            _testLogger = new TestLogger(outputHelper);
            _server = new TestServer(_testLogger);
            _testLogger.WriteLine("End of constructor");
        }

        public void Dispose()
        {
            _testLogger?.WriteLine("Disposing");
            _server.Dispose();
            _testLogger?.WriteLine("Dispose completed");
        }

        private TestServer _server;
        private readonly TestLogger _testLogger;

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
                string lastPart = RemovePrefix(request.Url.PathAndQuery);
                switch (lastPart)
                {
                    case "MultiChunk?uploadType=resumable":
                        response.Headers[HttpResponseHeader.Location] = $"{HttpPrefix}{uploadPath}";
                        return null;
                    case uploadPath:
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
                        Logger.WriteLine($"Unexpected last part of URL: {lastPart}");
                        throw new InvalidOperationException();
                }
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

                if (RemovePrefix(request.Url.PathAndQuery) == uploadPath &&
                    _failAtBytes.Any() &&
                    _failAtBytes[0] >= Bytes.Count && _failAtBytes[0] < Bytes.Count + request.ContentLength64)
                {
                    _failAtBytes.RemoveAt(0);
                    response.StatusCode = (int)_errorCode;
                    return Task.FromResult(_errorMsg);
                }
                else
                {
                    return base.HandleCall(request, response);
                }
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

        #endregion

        private class TestLogger
        {
            private static int _instanceCount;
            private int _id;
            private readonly ITestOutputHelper _outputHelper;

            public TestLogger(ITestOutputHelper outputHelper)
            {
                _id = Interlocked.Increment(ref _instanceCount);
                _outputHelper = outputHelper;
            }

            public void WriteLine(string message, [CallerMemberName] string caller = null)
            {
                string fullMessage = $"{DateTime.UtcNow:HH:mm:ss.FFFFFF}: {_id} - {caller}: {message}";
                _outputHelper.WriteLine(fullMessage);
            }
        }
    }
}
