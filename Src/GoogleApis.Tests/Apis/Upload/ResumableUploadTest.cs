using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using Google.Apis.Util;

using Google.Apis.Upload;
using Moq;


using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Upload
{
    [TestFixture]
    class ResumableUploadTest
    {
        string UploadTestData = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do 
eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud 
exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in 
reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint 
occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        private class MockResumableUploadServer : IDisposable
        {
            private HttpListener Listener { get; set; }
            public int Port { get; private set; }
            public string BaseUri { get; private set; }
            public string UploadUri { get; private set; }

            // Would rather use a "correct" port-finding logic but the HttpListener
            // class doesn't support it.
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

            public MockResumableUpload(MockResumableUploadServer server)
                : this(server, "")
            {
                this.server = server;
            }

            protected MockResumableUpload(MockResumableUploadServer server, string path)
                : base(server.BaseUri, path, "PUT")
            {
                this.server = server;
            }

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

        public class TestRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class TestResponse
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        private class MockResumableUploadWithResponse<TRequest, TResponse> : ResumableUpload<TRequest, TResponse>
        {
            private MockResumableUploadServer server;

            public MockResumableUploadWithResponse(MockResumableUploadServer server)
                : this(server, "")
            {
                this.server = server;
            }

            protected MockResumableUploadWithResponse(MockResumableUploadServer server, string path)
                : base(server.BaseUri, path, "PUT")
            {
                this.server = server;
            }

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

        private class MockResumableWithParameters : MockResumableUpload
        {
            public MockResumableWithParameters(MockResumableUploadServer server)
                : base(server, "testPath/{id}")
            {
            }

            [Google.Apis.Util.RequestParameter("id", RequestParameterType.Path)]
            public int id { get; set; }

            [Google.Apis.Util.RequestParameter("querya", RequestParameterType.Query)]
            public string querya { get; set; }

            [Google.Apis.Util.RequestParameter("queryb", RequestParameterType.Query)]
            public string queryb { get; set; }
        }

        [Test]
        public void TestUploadSingleChunk()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableUpload(server);

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

                upload.Upload(stream, "text/plain");

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
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                var stream = new MemoryStream(payload);
                var upload = new MockResumableUpload(server);
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

                upload.Upload(stream, "text/plain");

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
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                var stream = new MemoryStream(payload);
                var upload = new MockResumableUpload(server);
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

                upload.Upload(stream, "text/plain");

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
        public void TestUploadProgress()
        {
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                var stream = new MemoryStream(payload);
                var upload = new MockResumableUpload(server);
                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                });

                var progressEvents = new Queue<IUploadProgress>();

                upload.ProgressChanged += (progress) => {
                    progressEvents.Enqueue(progress);
                };

                upload.Upload(stream, "text/plain");
            }
        }

        [Test]
        public void TestUploadSingleChunkWithParameters()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableWithParameters(server) { id = 123 };

                server.ExpectRequest(context =>
                {
                    var reqUrl = new UriBuilder(server.BaseUri);
                    reqUrl.Path = String.Format("testPath/{0}", upload.id);
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

                upload.Upload(stream, "text/plain");

                server.ValidateMethodsCompleted();
            }
        }

        [Test]
        public void TestUploadSingleChunkWithQueryParameters()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableWithParameters(server)
                {
                    id = 123,
                    querya = "QueryValueA",
                    queryb = "QueryValueB",
                };

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsolutePath, Is.EqualTo("/testPath/123"));
                    Assert.That(context.Request.QueryString.Count, Is.EqualTo(3));
                    Assert.That(context.Request.QueryString["querya"], Is.EqualTo("QueryValueA"));
                    Assert.That(context.Request.QueryString["queryb"], Is.EqualTo("QueryValueB"));
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));

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

                upload.Upload(stream, "text/plain");

                server.ValidateMethodsCompleted();
            }
        }

        /// <summary>
        /// Test an upload with json request and respone body.
        /// </summary>
        [Test]
        public void TestUploadWithRequestAndResponseBody()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new MockResumableUploadWithResponse<TestRequest, TestResponse>(server);

                
                var serializer = new Google.Apis.Json.NewtonsoftJsonSerializer();

                upload.Body = new TestRequest()
                {
                    Name = "test object",
                    Description = "the description",
                };

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));

                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    Assert.That(context.Request.HasEntityBody);
                    TestRequest req = serializer.Deserialize<TestRequest>(context.Request.InputStream);
                    Assert.That(req, Is.Not.Null);
                    Assert.That(req.Name, Is.EqualTo(upload.Body.Name));
                    Assert.That(req.Description, Is.EqualTo(upload.Body.Description));

                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                    context.Response.ContentType = "application/json";

                    var testResponse = new TestResponse() { id = 123, Name = "foo", Description = "bar" };

                    serializer.Serialize(testResponse, context.Response.OutputStream);
                });

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length - 1, UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                TestResponse response = null;
                int eventCount = 0;

                upload.ResponseReceived += (r) => { response = r; eventCount++; };
                upload.Upload(stream, "text/plain");

                Assert.That(upload.ResponseBody, Is.Not.Null);
                Assert.That(upload.ResponseBody.id, Is.EqualTo(123));
                Assert.That(upload.ResponseBody.Name, Is.EqualTo("foo"));
                Assert.That(upload.ResponseBody.Description, Is.EqualTo("bar"));

                Assert.That(response, Is.SameAs(upload.ResponseBody));
                Assert.That(eventCount, Is.EqualTo(1));

                server.ValidateMethodsCompleted();
            }
        }
    }
}
