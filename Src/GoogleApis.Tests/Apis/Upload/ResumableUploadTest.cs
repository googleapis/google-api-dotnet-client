using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;

using Google.Apis.Upload;


using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Upload
{
    [TestFixture]
    class ResumableUploadTest
    {
        private class MockResumableUploadServer : IDisposable
        {
            private HttpListener Listener { get; set; }
            public int Port { get; private set; }
            public string BaseUri { get; private set; }
            public string UploadUri { get; private set; }

            private const int DefaultPort = 22123;

            public MockResumableUploadServer()
            {
                this.Port = DefaultPort;
                this.BaseUri = String.Format("http://localhost:{0}/", this.Port);
                this.UploadUri = String.Format("http://localhost:{0}/upload", this.Port);

                this.Listener = new HttpListener();
                this.Listener.Prefixes.Add(this.BaseUri);
                this.Listener.Start();

                this.Listener.BeginGetContext(OnRequest, null);
            }

            private Queue<Action<HttpListenerContext>> ServerActions
                = new Queue<Action<HttpListenerContext>>();

            private void OnRequest(IAsyncResult asyncResult)
            {
                var context = this.Listener.EndGetContext(asyncResult);
                if (ServerActions.Count > 0)
                {
                    var action = ServerActions.Dequeue();
                    try
                    {
                        action(context);
                    }
                    catch (Exception ex)
                    {
                        context.Response.StatusCode = 500;
                        JsonError(context.Response.OutputStream, ex.Message);
                    }
                }
                else
                {
                    context.Response.StatusCode = 500;
                    JsonError(context.Response.OutputStream, "Server received an unexpected request.");
                }
                context.Response.Close();

                if(ServerActions.Count != 0)
                    this.Listener.BeginGetContext(OnRequest, null);
            }

            private void JsonError(Stream outputStream, string errorMessage)
            {
                var sb = new StringBuilder();
                sb.Append("{ 'error' : { 'message' : '");
                sb.Append(errorMessage); // TODO: JSON encode
                sb.Append("' } }");
                using (StreamWriter sw = new StreamWriter(outputStream))
                {
                    sw.Write(sb.ToString());
                }
            }

            public void ExpectRequest(Action<HttpListenerContext> requestAction)
            {
                ServerActions.Enqueue(requestAction);
            }

            public void ValidateMethodsCompleted()
            {
                Assert.That(ServerActions.Count, Is.EqualTo(0), "Expected server actions were not completed.");
            }

            #region Disposable

            void IDisposable.Dispose()
            {
                Dispose(true);
            }

            ~MockResumableUploadServer()
            {
                Dispose(false);
            }

            private void Dispose(bool disposing)
            {
                if (disposing)
                {
                    this.Listener.Stop();
                }
            }

            #endregion
        }

        private class MockResumableUpload : ResumableUpload<object>
        {
            private MockResumableUploadServer server;

            public MockResumableUpload(Stream stream, string contentType, 
                MockResumableUploadServer server)
                : base(stream, contentType)
            {
                this.server = server;
            }

            protected override Uri InitializeUri { get { return new Uri(server.BaseUri); } }
            protected override string HttpMethod { get { return "PUT"; } }

            /// <summary>
            /// Test helper method to allow overriding the ChunkSize
            /// </summary>
            /// <param name="chunkSize"></param>
            new public int ChunkSize
            {
                get { return base.ChunkSize; }
                set { base.ChunkSize = value; }
            }
        }

        [Test]
        public void NullStreamThrows()
        {
            Assert.Throws<ArgumentNullException>(() => new MockResumableUpload(null, "image/jpeg", null));
        }

        [Test]
        public void NullContentTypeThrows()
        {
            Assert.Throws<ArgumentNullException>(() => new MockResumableUpload(new MemoryStream(), null, null));
        }

        [Test]
        public void EmptyContentTypeThrows()
        {
            Assert.Throws<ArgumentException>(() => new MockResumableUpload(new MemoryStream(), "", null));
        }

        [Test]
        public void TestUploadSingleChunk()
        {
            // Would rather use a "correct" port-finding logic but this class doesn't support it.
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableUpload(stream, "text/plain", server);

                server.ExpectRequest(context =>
                {
                    var reqUrl = new UriBuilder(server.BaseUri);
                    reqUrl.Query = "uploadType=resumable";
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(reqUrl.Uri));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length - 1, UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                upload.Upload();

                server.ValidateMethodsCompleted();
            }
        }

        /// <summary>
        /// Test that the upload client accepts 308 responses when uploading chunks (legacy behavior)
        /// </summary>
        /// <remarks>
        /// Compare to TestUploadMultipleChunk
        /// </remarks>
        [Test]
        public void TestUploadWith308OnChunks()
        {
            // Would rather use a "correct" port-finding logic but this class doesn't support it.
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                var stream = new MemoryStream(payload);
                var upload = new MockResumableUpload(stream, "text/plain", server);
                upload.ChunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    var reqUrl = new UriBuilder(server.BaseUri);
                    reqUrl.Query = "uploadType=resumable";
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(reqUrl.Uri));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int chunkStart = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + upload.ChunkSize) - 1;
                    var range = String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd, UploadTestData.Length);
                    server.ExpectRequest(context =>
                    {
                        var buffer = new byte[100];
                        while (true)
                        {
                            int x = context.Request.InputStream.Read(buffer, 0, buffer.Length);
                            if (x == 0) break;
                            dataStream.Write(buffer, 0, x);
                        }
                        Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                        Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                    });
                    chunkStart += upload.ChunkSize;
                }

                upload.Upload();

                server.ValidateMethodsCompleted();
                Assert.That(payload, Is.EqualTo(dataStream.ToArray()));
            }
        }

        /// <summary>
        /// Test that the upload client functions with multiple chunk uploads and 200 responses
        /// </summary>
        /// <remarks>
        /// Compare to TestUploadWith308OnChunks
        /// </remarks>
        [Test]
        public void TestUploadMultipleChunk()
        {
            // Would rather use a "correct" port-finding logic but this class doesn't support it.
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                var stream = new MemoryStream(payload);
                var upload = new MockResumableUpload(stream, "text/plain", server);
                upload.ChunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    var reqUrl = new UriBuilder(server.BaseUri);
                    reqUrl.Query = "uploadType=resumable";
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(reqUrl.Uri));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int chunkStart = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + upload.ChunkSize) - 1;
                    var range = String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd, UploadTestData.Length);
                    server.ExpectRequest(context =>
                    {
                        var buffer = new byte[100];
                        while(true)
                        {
                            int x = context.Request.InputStream.Read(buffer, 0, buffer.Length);
                            if (x == 0) break;
                            dataStream.Write(buffer, 0, x);
                        }
                        Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                        Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                    });
                    chunkStart += upload.ChunkSize;
                }

                upload.Upload();

                server.ValidateMethodsCompleted();
                Assert.That(payload, Is.EqualTo(dataStream.ToArray()));
            }
        }

        string UploadTestData = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do 
eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud 
exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in 
reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint 
occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
    }
}
