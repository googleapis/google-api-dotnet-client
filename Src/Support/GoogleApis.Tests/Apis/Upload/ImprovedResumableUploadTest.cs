using Google.Apis.Json;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util;
using NUnit.Framework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Apis.Upload
{
    // These tests are flakey on Travis, probably due to the mono runtime.
    // So all but one of these tests are not run on travis.
    // The only test run is TestUploadInBadServer_UploaderRestart, because
    // that functionality is not tested elsewhere.
    // When these tests de-flake on travis, replace ResumableUploadTest with this class.
    /// <summary>
    /// Tests of resumable upload, that uses a real HTTP server.
    /// </summary>
    [TestFixture]
    class ImprovedResumableUploadTest
    {
        public const string IgnoreOnTravis = "IgnoreOnTravis";
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

        private void LogTest(TestServer.Handler handler, object values, [CallerMemberName] string caller = null)
        {
            var now = DateTime.UtcNow;
            File.AppendAllText($"/home/travis/build/google/google-api-dotnet-client/serverlog-tests",
                $"{now:HH:mm:ss.ffffff}: Handler={handler.Id} {caller}: {values}\n");
        }

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
        private class MockResumableUpload : ResumableUpload<object>
        {
            public MockResumableUpload(IClientService service, string path, string method, Stream stream,
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
        /// URL used for the resumable upload.
        /// </summary>
        private const string uploadPath = "resume";

        /// <summary>
        /// HTTP server which listens on localhost:&lt;random port&gt; for testing.
        /// </summary>
        private class TestServer : IDisposable
        {
            public TestServer()
            {
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
                        _httpListener.Start();
                    }
                    // Catch errors that mean the port is already in use
                    catch (HttpListenerException e) when (e.ErrorCode == 183 || e.ErrorCode == 32)
                    {
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
                while (_httpListener.IsListening)
                {
                    var context = await _httpListener.GetContextAsync();
                    var response = context.Response;
                    if (context.Request.Url.AbsolutePath.EndsWith("/[Quit]"))
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
                            body = await HandleCall(context.Request, response);
                            var bodyBytes = body?.ToArray() ?? new byte[0];
                            await response.OutputStream.WriteAsync(bodyBytes, 0, bodyBytes.Length);
                            response.Close();
                        }
                        catch (HttpListenerException)
                        {
                            try
                            {
                                response.Close();
                            }
                            catch (Exception)
                            { }
                        }
                    }
                }
            }

            public abstract class Handler : IDisposable
            {
                private static int handlerId = 0;

                private TestServer _server;

                public Handler(TestServer server, string caller)
                {
                    _server = server;
                    Id = Interlocked.Increment(ref handlerId).ToString("000");
                    _server.RegisterHandler(this);
                    Log($"Started handler for {caller}");
                }

                public string Id { get; }
                public string HttpPrefix => $"{_server.HttpPrefix}{Id}/";

                private void Log(params string[] lines)
                {
                    var now = DateTime.UtcNow;
                    File.AppendAllLines($"/home/travis/build/google/google-api-dotnet-client/serverlog-{Id}", lines.Select(x => $"{now:HH:mm:ss.ffffff}: {x}"));
                }

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

                public Task<IEnumerable<byte>> HandleCall0(
                    HttpListenerRequest request, HttpListenerResponse response)
                {
                    Requests.Add(new RequestInfo(request));
                    var ret = HandleCall(request, response);
                    Log($"Request to {request.Url}; response code {response.StatusCode}");
                    return ret;
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
                    await new HttpClient().GetAsync(HttpPrefix + "[Quit]", timeout.Token);
                    _httpListener.Stop();
                });
                _httpTask.Wait();
            }
        }

        /// <summary>
        /// Server that only handles an upload completing in a single chunk.
        /// </summary>
        private class SingleChunkServer : TestServer.Handler
        {
            public SingleChunkServer(TestServer server, [CallerMemberName] string caller = null) : base(server, caller) { }

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case "SingleChunk?uploadType=resumable":
                        response.Headers.Add(HttpResponseHeader.Location, $"{HttpPrefix}{uploadPath}");
                        break;
                    case uploadPath:
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                return Task.FromResult<IEnumerable<byte>>(null);
            }
        }

        private TestServer _server;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _server = new TestServer();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _server.Dispose();
            _server = null;
        }

        /// <summary>
        /// Upload completes in a single chunk.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInSingleChunk(
            [Values(true, false)] bool knownSize,
            [Values("", "text/plain")] string contentType,
            [Values(0, 10)] int chunkSizeDelta)
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, contentType, chunkSizeDelta });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(
                    service, "SingleChunk", "POST", content, contentType, uploadLength + chunkSizeDelta);
                var progress = uploader.Upload();
                Assert.That(server.Requests.Count, Is.EqualTo(2));
                var r0 = server.Requests[0];
                Assert.That(r0.Headers["X-Upload-Content-Type"], Is.EqualTo(contentType));
                Assert.That(r0.Headers["X-Upload-Content-Length"], Is.EqualTo(knownSize ? uploadTestBytes.Length.ToString() : null));
                var r1 = server.Requests[1];
                Assert.That(server.RemovePrefix(r1.Url.AbsolutePath), Is.EqualTo(uploadPath));
                Assert.That(r1.Headers["Content-Range"], Is.EqualTo($"bytes 0-{uploadLength - 1}/{uploadLength}"));
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(progress.BytesSent, Is.EqualTo(uploadTestBytes.Length));
            }
        }

        /// <summary>
        /// Upload of an empty file.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadEmptyFile(
            [Values(true, false)] bool knownSize)
        {
            using (var server = new SingleChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize });
                var content = knownSize ? new MemoryStream(new byte[0]) : new UnknownSizeMemoryStream(new byte[0]);
                var uploader = new MockResumableUpload(service, "SingleChunk", "POST", content, "text/plain", 100);
                var progress = uploader.Upload();
                Assert.That(server.Requests.Count, Is.EqualTo(2));
                var r0 = server.Requests[0];
                Assert.That(r0.Headers["X-Upload-Content-Length"], Is.EqualTo(knownSize ? "0" : null));
                var r1 = server.Requests[1];
                Assert.That(server.RemovePrefix(r1.Url.AbsolutePath), Is.EqualTo(uploadPath));
                Assert.That(r1.Headers["Content-Range"], Is.EqualTo("bytes *" + "/0"));
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(progress.BytesSent, Is.EqualTo(0));
            }
        }

        /// <summary>
        /// Server that support multiple-chunk uploads.
        /// </summary>
        private class MultiChunkServer : TestServer.Handler
        {
            public MultiChunkServer(TestServer server, [CallerMemberName] string caller = null) : base(server, caller) { }

            public List<byte> Bytes { get; } = new List<byte>();
            private int? _length;

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
                        response.AddHeader("Range", $"bytes 0-{Bytes.Count - 1}");
                    }
                }
            }

            protected override async Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case "MultiChunk?uploadType=resumable":
                        response.Headers.Add(HttpResponseHeader.Location, $"{HttpPrefix}{uploadPath}");
                        return null;
                    case uploadPath:
                        var bytesStream = new MemoryStream();
                        await request.InputStream.CopyToAsync(bytesStream);
                        Bytes.AddRange(bytesStream.ToArray());
                        HandleHeaders(request, response);
                        return null;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// An upload in multiple chunks, with no server errors.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInMultipleChunks(
            [Values(true, false)] bool knownSize,
            [Values(100, 400, 1000)] int chunkSize)
        {
            var expectedCallCount = 1 + (uploadLength + chunkSize - 1) / chunkSize;
            using (var server = new MultiChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, chunkSize });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.That(server.Requests.Count, Is.EqualTo(expectedCallCount));
                Assert.That(server.Bytes, Is.EqualTo(uploadTestBytes));
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
            }
        }

        /// <summary>
        /// Check the upload progress is correct during upload.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadProgress(
            [Values(true, false)] bool knownSize)
        {
            int chunkSize = 200;
            using (var server = new MultiChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = new List<IUploadProgress>();
                uploader.ProgressChanged += p => progress.Add(p);
                uploader.Upload();
                Assert.That(progress.Count, Is.EqualTo(4));
                Assert.That(progress[0].Status, Is.EqualTo(UploadStatus.Starting));
                Assert.That(progress[0].BytesSent, Is.EqualTo(0));
                Assert.That(progress[1].Status, Is.EqualTo(UploadStatus.Uploading));
                Assert.That(progress[1].BytesSent, Is.EqualTo(chunkSize));
                Assert.That(progress[2].Status, Is.EqualTo(UploadStatus.Uploading));
                Assert.That(progress[2].BytesSent, Is.EqualTo(chunkSize * 2));
                Assert.That(progress[3].Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(progress[3].BytesSent, Is.EqualTo(uploadLength));
            }
        }

        /// <summary>
        /// A multi-chunk server that simulates errors at the specified byte offsets during upload.
        /// </summary>
        private class MultiChunkBadServer : MultiChunkServer
        {
            public MultiChunkBadServer(TestServer server,
                int[] failAtBytes, HttpStatusCode errorCode, string errorMsg = null, [CallerMemberName] string caller = null)
                : base(server, caller)
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
        /// Server 404s, with a JSON body.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInBadServer_NotFound_JsonError(
            [Values(true, false)] bool knownSize,
            [Values(new[] { 410 })] int[] dodgyBytes)
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
                LogTest(server, new { knownSize, dodgyBytesLength = dodgyBytes.Length });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", 100);
                IUploadProgress lastProgress = null;
                uploader.ProgressChanged += p => lastProgress = p;
                uploader.Upload();
                Assert.That(lastProgress, Is.Not.Null);
                Assert.That(lastProgress.Status, Is.EqualTo(UploadStatus.Failed));
                var exception = (GoogleApiException)lastProgress.Exception;
                Assert.That(exception.Message, Contains.Substring(
                    "Message[Login Required] Location[Authorization - header] Reason[required] Domain[global]"),
                    "Error message is invalid");
                Assert.That(exception.Error.Message, Is.EqualTo("Login Required"), "Parsed error incorrect");
            }
        }

        /// <summary>
        /// Server 404s, with a plain-text (non-JSON) body.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInBadServer_NotFound_PlainTextError(
            [Values(true, false)] bool knownSize,
            [Values(new[] { 410 })] int[] dodgyBytes)
        {
            string plainTextError = "Not Found";
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound, plainTextError))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, dodgyBytesLength = dodgyBytes.Length });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", 100);
                IUploadProgress lastProgress = null;
                uploader.ProgressChanged += p => lastProgress = p;
                uploader.Upload();
                Assert.That(lastProgress, Is.Not.Null);
                Assert.That(lastProgress.Status, Is.EqualTo(UploadStatus.Failed));
                var exception = (GoogleApiException)lastProgress.Exception;
                Assert.That(exception.Message, Is.EqualTo(plainTextError));
                Assert.That(exception.Error, Is.Null);
            }
        }

        /// <summary>
        /// Server fails with occasional 500s, which the uploader transparently copes with.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInBadServer_ServerUnavailable(
            [Values(true, false)] bool knownSize,
            [Values(new[] { 0, 100 })] int[] dodgyBytes,
            [Values(100, 400, 1000)] int chunkSize)
        {
            var expectedCallCount = 1 + (uploadLength + chunkSize - 1) / chunkSize;
            expectedCallCount += dodgyBytes.Length * 2;
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.ServiceUnavailable))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, dodgyBytesLength = dodgyBytes.Length, chunkSize });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.That(server.Requests.Count, Is.EqualTo(expectedCallCount));
                Assert.That(server.Bytes, Is.EqualTo(uploadTestBytes));
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
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
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInBadServer_NeedsResume(
            [Values(true, false)] bool knownSize,
            [Values(new[] { 0, 410 })] int[] dodgyBytes,
            [Values(100, 400, 1000)] int chunkSize,
            [Values(4096, 51, 100)] int bufferSize)
        {
            var expectedCallCount = 1 + (uploadLength + chunkSize - 1) / chunkSize
                + dodgyBytes.Length * 2;
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, dodgyBytesLength = dodgyBytes.Length, chunkSize, bufferSize });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                uploader.BufferSize = bufferSize;
                var progress = uploader.Upload();
                int sanity = 0;
                while (progress.Status == UploadStatus.Failed && sanity++ < 10)
                {
                    progress = uploader.Resume();
                }
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(server.Requests.Count, Is.EqualTo(expectedCallCount));
                Assert.That(server.Bytes, Is.EqualTo(uploadTestBytes));
            }
        }

        /// <summary>
        /// Server fails with 400s, so resume calls are required.
        /// Resume is done as if the entire client program has restarted (ie with a fresh uploader).
        /// </summary>
        [Test, Combinatorial]
        // This is the only test currently run on travis.
        public void TestUploadInBadServer_UploaderRestart(
            [Values(new[] { 0, 410 })] int[] dodgyBytes,
            [Values(100, 400, 1000)] int chunkSize)
        {
            using (var server = new MultiChunkBadServer(_server, dodgyBytes, HttpStatusCode.NotFound))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { dodgyBytesLength = dodgyBytes.Length, chunkSize });
                var content = new MemoryStream(uploadTestBytes);
                Uri uploadUri = null;
                IUploadProgress progress;
                {
                    var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                    uploader.UploadSessionData += s => uploadUri = s.UploadUri;
                    progress = uploader.Upload();
                }
                Assert.That(uploadUri, Is.Not.Null);
                int sanity = 0;
                while (progress.Status == UploadStatus.Failed && sanity++ < 10)
                {
                    var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                    progress = uploader.Resume(uploadUri);
                }
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(server.Bytes, Is.EqualTo(uploadTestBytes));
            }
        }

        /// <summary>
        /// Resuming on program restart with a non-seekable stream is not supported.
        /// </summary>
        [Test]
        [Category(IgnoreOnTravis)]
        public void TestUploadWithUploaderRestart_UnknownSize()
        {
            // Unknown stream size not supported, exception always thrown
            using (var server = new MultiChunkServer(_server))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, null);
                var content = new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "whatever", "PUT", content, "", 100);
                var url = new Uri("http://what.ever/");
                Assert.That(async () => await uploader.ResumeAsync(url), Throws.InstanceOf<NotImplementedException>());
            }
        }

        /// <summary>
        /// Server that causes cancellation after a specified number of calls.
        /// </summary>
        private class MultiChunkCancellableServer : MultiChunkServer
        {
            public MultiChunkCancellableServer(TestServer server, int cancelOnCall, [CallerMemberName] string caller = null)
                : base(server, caller)
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
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadCancelled(
            [Values(true, false)] bool knownSize,
            [Values(1, 2, 3, 4, 5)] int cancelOnCall)
        {
            int chunkSize = 100;
            using (var server = new MultiChunkCancellableServer(_server, cancelOnCall))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, cancelOnCall });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                if (cancelOnCall == 1)
                {
                    var progress = uploader.UploadAsync(server.CancellationToken).Result;
                    Assert.That(progress.Status, Is.EqualTo(UploadStatus.Failed));
                    Assert.That(progress.Exception, Is.InstanceOf<OperationCanceledException>());
                }
                else
                {
                    Assert.ThrowsAsync<TaskCanceledException>(
                        () => uploader.UploadAsync(server.CancellationToken));
                }
                Assert.That(server.Requests.Count, Is.EqualTo(cancelOnCall));
            }
        }

        /// <summary>
        /// Server that only accepts part of each uploaded chunk.
        /// </summary>
        private class MultiChunkPartialServer : MultiChunkServer
        {
            public MultiChunkPartialServer(TestServer server, int partialSize, [CallerMemberName] string caller = null)
                : base(server, caller)
            {
                _partialSize = partialSize;
            }

            private readonly int _partialSize;

            protected override async Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                switch (RemovePrefix(request.Url.PathAndQuery))
                {
                    case uploadPath:
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
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadInPartialServer(
            [Values(true, false)] bool knownSize,
            [Values(80, 150)] int partialSize,
            [Values(100, 200)] int chunkSize)
        {
            var actualChunkSize = Math.Min(partialSize, chunkSize);
            var expectedCallCount = (uploadLength + actualChunkSize - 1) / actualChunkSize + 1;
            using (var server = new MultiChunkPartialServer(_server, partialSize))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, new { knownSize, partialSize, chunkSize });
                var content = knownSize ? new MemoryStream(uploadTestBytes) : new UnknownSizeMemoryStream(uploadTestBytes);
                var uploader = new MockResumableUpload(service, "MultiChunk", "POST", content, "text/plain", chunkSize);
                var progress = uploader.Upload();
                Assert.That(server.Requests.Count, Is.EqualTo(expectedCallCount));
                Assert.That(server.Bytes, Is.EqualTo(uploadTestBytes));
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
            }
        }

        /// <summary>
        /// Server that expects an initial call with path and query parameters.
        /// </summary>
        private class MultiChunkQueriedServer : MultiChunkServer
        {
            public MultiChunkQueriedServer(TestServer server, string initialPathAndQuery, [CallerMemberName] string caller = null)
                : base(server, caller)
            {
                _initialPathAndQuery = initialPathAndQuery;
            }

            private string _initialPathAndQuery;

            protected override Task<IEnumerable<byte>> HandleCall(HttpListenerRequest request, HttpListenerResponse response)
            {
                if (RemovePrefix(request.Url.PathAndQuery) == _initialPathAndQuery)
                {
                    response.Headers.Add(HttpResponseHeader.Location, $"{HttpPrefix}{uploadPath}");
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
        private class MockResumableUploadWithParameters : MockResumableUpload
        {
            public MockResumableUploadWithParameters(IClientService service, string path, string method, Stream stream,
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
        [Test]
        [Category(IgnoreOnTravis)]
        public void TestUploadWithQueryAndPathParameters()
        {
            var id = 123;
            var queryA = "valuea";
            var queryB = "VALUEB";
            var pathAndQuery = $"testPath/{id}?uploadType=resumable&queryA={queryA}&queryB={queryB}&time=2002-02-25T12%3A57%3A32.777Z";
            using (var server = new MultiChunkQueriedServer(_server, pathAndQuery))
            using (var service = new MockClientService(server.HttpPrefix))
            {
                LogTest(server, null);
                var content = new MemoryStream(uploadTestBytes);
                var uploader = new MockResumableUploadWithParameters(service, "testPath/{id}", "POST", content, "text/plain", 100)
                {
                    Id = id,
                    QueryA = "valuea",
                    QueryB = "VALUEB",
                    MinTime = new DateTime(2002, 2, 25, 12, 57, 32, 777, DateTimeKind.Utc),
                };
                var progress = uploader.Upload();
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(server.Requests.Count, Is.EqualTo(6));
            }
        }

        /// <summary>A mock request object.</summary>
        public class TestRequest : IEquatable<TestRequest>
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public bool Equals(TestRequest other)
            {
                if (other == null)
                    return false;

                return Name == null ? other.Name == null : Name.Equals(other.Name) &&
                    Description == null ? other.Description == null : Description.Equals(other.Description);
            }
        }

        /// <summary>A mock response object.</summary>
        public class TestResponse : IEquatable<TestResponse>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

            public bool Equals(TestResponse other)
            {
                if (other == null)
                    return false;

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
            public MultiChunkRequestResponseServer(TestServer server, TResponse expectedResponse, [CallerMemberName] string caller = null)
                : base(server, caller)
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
        private class MockResumableUploadWithResponse<TRequest, TResponse> : ResumableUpload<TRequest, TResponse>
        {
            public MockResumableUploadWithResponse(IClientService service, string path, string method, Stream stream,
                string contentType, int chunkSize)
                : base(service, path, method, stream, contentType) {
                this.chunkSize = chunkSize;
            }
        }

        /// <summary>
        /// Uploader correctly processes request and response bodies.
        /// </summary>
        [Test, Combinatorial]
        [Category(IgnoreOnTravis)]
        public void TestUploadWithRequestAndResponseBody(
            [Values(false)] bool gzipEnabled) // TODO: Also with zip
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
                LogTest(server, new { gzipEnabled });
                var content = new MemoryStream(uploadTestBytes);
                var uploader = new MockResumableUploadWithResponse<TestRequest, TestResponse>(
                    service, "MultiChunk", "POST", content, "text/plain", 100)
                {
                    Body = body,
                };
                TestResponse response = null;
                int reponseReceivedCount = 0;
                uploader.ResponseReceived += (r) => { response = r; reponseReceivedCount++; };
                var progress = uploader.Upload();
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Completed));
                Assert.That(server.Request, Is.EqualTo(body));
                Assert.That(response, Is.EqualTo(expectedResponse));
                Assert.That(uploader.ResponseBody, Is.EqualTo(expectedResponse));
                Assert.That(reponseReceivedCount, Is.EqualTo(1));
            }
        }

        /// <summary>
        /// Client validates chunk-size correctly.
        /// </summary>
        [Test]
        [Category(IgnoreOnTravis)]
        public void TestChunkSize()
        {
            using (var service = new MockClientService(new BaseClientService.Initializer()))
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableUpload(service, "whatever", "POST", stream, "text/plain", 100);

                // Negative chunk size.
                Assert.That(() => upload.ChunkSize = -1,
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                // Less than the minimum.
                Assert.That(() => upload.ChunkSize = MockResumableUpload.MinimumChunkSize - 1,
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                // Valid chunk size.
                upload.ChunkSize = MockResumableUpload.MinimumChunkSize;
                upload.ChunkSize = MockResumableUpload.MinimumChunkSize * 2;
            }
        }

    }
}
