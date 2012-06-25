/*
Copyright 2012 Google Inc

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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Google.Apis.Upload;
using Google.Apis.Util;
using NUnit.Framework;

using Google.Apis.Tests.Utility;

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

        private class MockResumableUploadServer : MockServer { }

        private class MockResumableUpload : ResumableUpload<object>
        {
            private MockResumableUploadServer server;

            public MockResumableUpload(MockResumableUploadServer server,
                Stream stream, string contentType)
                : this(server, "", stream, contentType)
            {
                this.server = server;
            }

            protected MockResumableUpload(MockResumableUploadServer server, string path,
                Stream stream, string contentType)
                : base(server.BaseUri, path, "PUT", stream, contentType)
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

            public MockResumableUploadWithResponse(MockResumableUploadServer server,
                Stream stream, string contentType)
                : this(server, "", stream, contentType)
            {
                this.server = server;
            }

            protected MockResumableUploadWithResponse(MockResumableUploadServer server, string path,
                Stream stream, string contentType)
                : base(server.BaseUri, path, "PUT", stream, contentType)
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
            public MockResumableWithParameters(MockResumableUploadServer server,
                Stream stream, string contentType)
                : base(server, "testPath/{id}", stream, contentType)
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

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length - 1, 
                        UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.Upload();
            }
        }

        [Test]
        public void TestUploadEmptyFile()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(new byte[0]);

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo("0"));

                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes */0");
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.Upload();
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
                const int chunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int chunkStart = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + chunkSize) - 1;
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
                    chunkStart += chunkSize;
                }

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.ChunkSize = chunkSize;
                upload.Upload();
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
                const int chunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int chunkStart = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + chunkSize) - 1;
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
                    chunkStart += chunkSize;
                }

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.ChunkSize = chunkSize;
                upload.Upload();
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

                var upload = new MockResumableUpload(server, stream, "text/plain");

                upload.ProgressChanged += (progress) => {
                    progressEvents.Enqueue(progress);
                };

                upload.Upload();
            }
        }

        [Test]
        public void TestUploadSingleChunkWithParameters()
        {
            const int id = 123;
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Url.AbsolutePath,
                        Is.EqualTo(String.Format("/testPath/{0}", id)));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length - 1,
                        UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                var upload = new MockResumableWithParameters(server, stream, "text/plain") { id = id };
                upload.Upload();
            }
        }

        [Test]
        public void TestUploadSingleChunkWithQueryParameters()
        {
            using (var server = new MockResumableUploadServer())
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));

                server.ExpectRequest(context =>
                {
                    Assert.That(context.Request.Url.AbsolutePath, Is.EqualTo("/testPath/123"));
                    Assert.That(context.Request.QueryString.Count, Is.EqualTo(4));
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
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length-1, UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                });

                var upload = new MockResumableWithParameters(server, stream, "text/plain")
                {
                    id = 123,
                    querya = "QueryValueA",
                    queryb = "QueryValueB",
                };
                upload.Upload();
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
             
                var serializer = new Google.Apis.Json.NewtonsoftJsonSerializer();

                var body = new TestRequest()
                {
                    Name = "test object",
                    Description = "the description",
                };

                server.ExpectRequest(context =>
                {
                    // Verify the initialization request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["alt"], Is.EqualTo("json"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.EqualTo(stream.Length.ToString()));

                    // Verify the request body
                    Assert.That(context.Request.HasEntityBody);
                    TestRequest req = serializer.Deserialize<TestRequest>(context.Request.InputStream);
                    Assert.That(req, Is.Not.Null);
                    Assert.That(req.Name, Is.EqualTo(body.Name));
                    Assert.That(req.Description, Is.EqualTo(body.Description));

                    // Give the location for the next chunk
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                server.ExpectRequest(context =>
                {
                    // Verify the chunk-request
                    Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length-1, UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));

                    // Send the response-body
                    context.Response.ContentType = "application/json";
                    var testResponse = new TestResponse() { id = 123, Name = "foo", Description = "bar" };
                    serializer.Serialize(testResponse, context.Response.OutputStream);
                });

                TestResponse response = null;
                int eventCount = 0;

                var upload = new MockResumableUploadWithResponse<TestRequest, TestResponse>(server, stream, "text/plain")
                {
                    Body = body,
                };

                upload.ResponseReceived += (r) => { response = r; eventCount++; };
                upload.Upload();

                Assert.That(upload.ResponseBody, Is.Not.Null);
                Assert.That(upload.ResponseBody.id, Is.EqualTo(123));
                Assert.That(upload.ResponseBody.Name, Is.EqualTo("foo"));
                Assert.That(upload.ResponseBody.Description, Is.EqualTo("bar"));

                Assert.That(response, Is.SameAs(upload.ResponseBody));
                Assert.That(eventCount, Is.EqualTo(1));
            }
        }
    }
}
