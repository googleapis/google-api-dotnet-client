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

using Google.Apis.Testing;
using Google.Apis.Upload;
using Google.Apis.Util;

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
        }

        /// <summary> Mimics a stream whose size is unknown. </summary>
        private class UnknownSizeMemoryStream : MemoryStream
        {
            public UnknownSizeMemoryStream(byte[] buffer) : base(buffer) { }
            public override bool CanSeek
            {
                get { return false; }
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

            [Google.Apis.Util.RequestParameter("queryA", RequestParameterType.Query)]
            public string querya { get; set; }

            [Google.Apis.Util.RequestParameter("queryB", RequestParameterType.Query)]
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
                    Assert.That(context.Request.QueryString.Count, Is.EqualTo(1));
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
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
        /// Tests that the upload client accepts 308 responses when uploading chunks on a stream with known size. 
        /// </summary>
        [Test]
        public void TestChunkUploadWith308_KnownSize()
        {
            SubsetTestChunkUpload(true, false);
        }

        /// <summary> 
        /// Tests that the upload client accepts 308 responses when uploading chunks on a stream with unknown size. 
        /// </summary>
        [Test]
        public void TestChunkUploadWith308_UnknownSize()
        {
            SubsetTestChunkUpload(false, false);
        }

        /// <summary> 
        /// Tests that the upload client accepts 308 and 503 responses when uploading chunks on a stream with known 
        /// size. 
        /// </summary>
        [Test]
        public void TestChunkUploadWith308And503_KnownSize()
        {
            SubsetTestChunkUpload(true, true);
        }

        /// <summary> 
        /// Tests that the upload client accepts 308 and 503 responses when uploading chunks on a stream with unknown
        /// size.
        /// </summary>
        [Test]
        public void TestChunkUploadWith308And503_UnknownSize()
        {
            SubsetTestChunkUpload(false, true);
        }

        private void SubsetTestChunkUpload(bool knownSize, bool supports503)
        {
            // If supports503 is true we simulate server 503 error, as following:
            // On the 4th chunk (when server received bytes 300-399), we mimic a server error - 503. 
            // In the next request we expect the client to send the content range header with "bytes */[size]", and 
            // server return that the upload was interrupted after 299 bytes. From that point the server works as 
            // expected, and received the last chunks successfully

            // on the 4th request - server return 503
            const int Return503OnRequestNum = 4;
            // on the 5th request - server return 308 response with "Range" header is "bytes 0-299"
            const int Retrun308WithRangeOnRequestNum = 5;
            const int ServerErrors = 2; // 503 (upload interrupted) + 308 (server report how many bytes it received)

            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                MemoryStream stream = knownSize ? new MemoryStream(payload) : new UnknownSizeMemoryStream(payload);
                const int chunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));

                    // when the size is known the initial request contains the X-Upload-Content-Length header
                    if (knownSize)
                    {
                        Assert.That(context.Request.Headers["X-Upload-Content-Length"],
                            Is.EqualTo(stream.Length.ToString()));
                    }
                    else
                    {
                        Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.Null);
                    }

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int chunkStart = 0;
                int reqNum = 0;

                int serverErrorCounter = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + chunkSize) - 1;
                    var range = String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd,
                        chunkEnd + 1 == len || knownSize ? UploadTestData.Length.ToString() : "*");
                    server.ExpectRequest(context =>
                    {
                        reqNum++;
                        if (supports503 && reqNum == Return503OnRequestNum)
                        {
                            Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                            Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));
                            context.Response.StatusCode = 503;
                        }
                        else if (supports503 && reqNum == Retrun308WithRangeOnRequestNum)
                        {
                            Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                            Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(string.Format(
                                @"bytes */{0}", knownSize ? UploadTestData.Length.ToString() : "*")));
                            context.Response.StatusCode = 308;
                            context.Response.Headers.Add("Range", "bytes 0-299");
                        }
                        else
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

                            if (chunkEnd != len - 1)
                            {
                                context.Response.StatusCode = 308;
                                context.Response.Headers.Add("Range",
                                    String.Format("bytes {0}-{1}", chunkStart, chunkEnd));
                            }
                        }
                    });

                    // on the 4th time request, the server returns a 503 (as explained above) 
                    // No need to increment chunkStart that time, or the request after it.
                    if (supports503 && chunkEnd == 399 && serverErrorCounter < ServerErrors)
                    {
                        ++serverErrorCounter;
                    }
                    else
                    {
                        chunkStart += chunkSize;
                    }
                }

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.ChunkSize = chunkSize;
                upload.Upload();
                Assert.That(payload, Is.EqualTo(dataStream.ToArray()));
            }
        }

        /// <summary> 
        /// Tests that the upload client accepts 308 responses and reads the "Range" header to know from which point to
        /// continue (stream size is known). 
        /// </summary>
        [Test]
        public void TestChunkUpload_ServerRecievedPartOfRequest_KnownSize()
        {
            SubsetTestChunkUpload_ServerRecievedPartOfRequest(true);
        }

        /// <summary> 
        /// Tests that the upload client accepts 308 responses and reads the "Range" header to know from which point to
        /// continue (stream size is unknown). 
        /// </summary>
        [Test]
        public void TestChunkUpload_ServerRecievedPartOfRequest_UnknownSize()
        {
            SubsetTestChunkUpload_ServerRecievedPartOfRequest(false);
        }

        private void SubsetTestChunkUpload_ServerRecievedPartOfRequest(bool knownSize)
        {
            using (var server = new MockResumableUploadServer())
            {
                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                MemoryStream stream = knownSize ? new MemoryStream(payload) : new UnknownSizeMemoryStream(payload);
                const int chunkSize = 400;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));

                    // when the size is known the initial request contains the X-Upload-Content-Length header
                    if (knownSize)
                    {
                        Assert.That(context.Request.Headers["X-Upload-Content-Length"],
                            Is.EqualTo(stream.Length.ToString()));
                    }
                    else
                    {
                        Assert.That(context.Request.Headers["X-Upload-Content-Length"], Is.Null);
                    }

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                int shouldRead = 120;

                server.ExpectRequest(context =>
                    {
                        Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                        var range = String.Format("bytes {0}-{1}/{2}", 0, 399, knownSize ? len.ToString() : "*");

                        Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));

                        context.Response.StatusCode = 308;
                        context.Response.Headers.Add("Range", "bytes 0-" + (shouldRead - 1));

                        var buffer = new byte[400];
                        int read = 0;
                        while (true)
                        {
                            read = context.Request.InputStream.Read(buffer, 0, shouldRead - read);
                            if (read == 0) break;
                            dataStream.Write(buffer, 0, read);
                        }
                    });
                server.ExpectRequest(context =>
                    {
                        Assert.That(context.Request.Url.AbsoluteUri, Is.EqualTo(server.UploadUri.ToString()));
                        Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(
                            string.Format("bytes {0}-{1}/{2}", shouldRead, len - 1, len)));

                        context.Response.StatusCode = 200;

                        var buffer = new byte[400];
                        int read = 0;
                        while (true)
                        {
                            read = context.Request.InputStream.Read(buffer, 0, buffer.Length);
                            if (read == 0) break;
                            dataStream.Write(buffer, 0, read);
                        }
                    });

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.ChunkSize = chunkSize;
                upload.Upload();
                Assert.That(payload, Is.EqualTo(dataStream.ToArray()));
            }
        }

        /// <summary> Tests uploading media which fails in the middle (server returns 5xx responses). </summary>
        [Test]
        public void TestChunkUploadFail()
        {
            using (var server = new MockResumableUploadServer())
            {
                const int FailFromRequestNumber = 3;

                var payload = Encoding.UTF8.GetBytes(UploadTestData);
                MemoryStream stream = new MemoryStream(payload);
                const int chunkSize = 100;

                var len = payload.Length;

                server.ExpectRequest(context =>
                {
                    // Validate the request
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Type"], Is.EqualTo("text/plain"));
                    Assert.That(context.Request.Headers["X-Upload-Content-Length"],
                        Is.EqualTo(stream.Length.ToString()));

                    // Prepare the response.
                    context.Response.Headers.Add(HttpResponseHeader.Location, server.UploadUri.ToString());
                });

                MemoryStream dataStream = new MemoryStream();

                var upload = new MockResumableUpload(server, stream, "text/plain");

                // from request 3 always return 503
                int chunkStart = 0;
                int serverRequest = 0;
                int clientRequest = 0;
                while (chunkStart < len)
                {
                    var chunkEnd = Math.Min(len, chunkStart + chunkSize) - 1;
                    var range = String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd,
                        UploadTestData.Length.ToString());
                    clientRequest++;
                    server.ExpectRequest(context =>
                    {
                        serverRequest++;
                        if (serverRequest >= 3)
                        {
                            context.Response.StatusCode = 503;
                        }
                        else
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

                            if (chunkEnd != len - 1)
                            {
                                context.Response.StatusCode = 308;
                                context.Response.Headers.Add("Range",
                                    String.Format("bytes {0}-{1}", chunkStart, chunkEnd));
                            }
                        }
                    });

                    if (clientRequest >= FailFromRequestNumber)
                    {
                        if (clientRequest == FailFromRequestNumber + upload.MaxRetries)
                        {
                            break;
                        }
                    }
                    else
                    {
                        chunkStart += chunkSize;
                    }
                }

                upload.ChunkSize = chunkSize;
                IUploadProgress progress = null;
                upload.ProgressChanged += (p) =>
                {
                    progress = p;
                };
                upload.Upload();

                Assert.NotNull(progress);
                Assert.NotNull(progress.Exception);
                Assert.That(progress.Status, Is.EqualTo(UploadStatus.Failed));
            }
        }

        /// <summary> Tests that upload function fires progress events as expected. </summary>
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
                        context.Response.StatusCode = 308;
                        context.Response.Headers.Add("Range", "bytes 0-199");
                    });
                server.ExpectRequest(context =>
                    {
                        context.Response.StatusCode = 308;
                        context.Response.Headers.Add("Range", "bytes 200-399");
                    });
                server.ExpectRequest(context =>
                    {
                    });

                var progressEvents = new List<IUploadProgress>();

                var upload = new MockResumableUpload(server, stream, "text/plain");
                upload.ProgressChanged += (progress) =>
                    {
                        progressEvents.Add(progress);
                    };
                upload.ChunkSize = 200;
                upload.Upload();

                // Starting (1) - Uploading (3) - Completed (1)
                Assert.That(progressEvents.Count, Is.EqualTo(4));
                Assert.That(progressEvents[0].Status, Is.EqualTo(UploadStatus.Starting));
                Assert.That(progressEvents[1].Status, Is.EqualTo(UploadStatus.Uploading));
                Assert.That(progressEvents[2].Status, Is.EqualTo(UploadStatus.Uploading));
                Assert.That(progressEvents[3].Status, Is.EqualTo(UploadStatus.Completed));
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
                    // count should be 2 - uploadType, queryA (and not QueryB)
                    Assert.That(context.Request.QueryString.Count, Is.EqualTo(2));
                    Assert.That(context.Request.QueryString["uploadType"], Is.EqualTo("resumable"));
                    Assert.That(context.Request.QueryString["queryA"], Is.EqualTo("a"));
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

                var upload = new MockResumableWithParameters(server, stream, "text/plain")
                    {
                        id = id,
                        querya = "a"
                    };
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

                var upload = new MockResumableWithParameters(server, stream, "text/plain")
                    {
                        id = 123,
                        querya = "QueryValueA",
                        queryb = "QueryValueB",
                    };
                upload.Upload();
            }
        }

        /// <summary> Tests an upload with JSON request and response body. </summary>
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
                    var range = String.Format("bytes 0-{0}/{1}", UploadTestData.Length - 1, UploadTestData.Length);
                    Assert.That(context.Request.Headers["Content-Range"], Is.EqualTo(range));

                    // Send the response-body
                    context.Response.ContentType = "application/json; charset=UTF-8";
                    var testResponse = new TestResponse() { id = 123, Name = "foo", Description = "bar" };
                    serializer.Serialize(testResponse, context.Response.OutputStream);
                });

                TestResponse response = null;
                int eventCount = 0;

                var upload = new MockResumableUploadWithResponse<TestRequest, TestResponse>(
                    server, stream, "text/plain")
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
