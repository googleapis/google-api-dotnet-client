/*
Copyright 2013 Google Inc

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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

using Google.Apis.Download;
using Google.Apis.Services;

namespace Google.Apis.Tests.Apis.Download
{
    /// <summary>Tests for the <see cref="Google.Apis.Download.MediaDownloader"/>.</summary>
    [TestFixture]
    class MediaDownloaderTest
    {
        /// <summary>The content the "server" uses to send to the client.</summary>
        static string MediaContent = @"Media content goes here. This is an example of test content.";

        /// <summary>The stream the "server" uses to send to the client.</summary>
        static Stream StreamContent;

        [TestFixtureSetUp]
        public static void AllTestsSetUp()
        {
            StreamContent = new MemoryStream(Encoding.UTF8.GetBytes(MediaContent));
        }

        [TestFixtureTearDown]
        public static void AllTestsTearDown()
        {
            StreamContent.Dispose();
        }

        /// <summary> An handler which demonstrate a client download which contains multiple chunks. </summary>
        private class MultipleChunksMessageHandler : CountableMessageHandler
        {
            /// <summary>Gets or sets the chunk size to send.</summary>
            public int ChunkSize { get; set; }

            /// <summary>Sets the status code to return for simulating errors.</summary>
            public HttpStatusCode StatusCode { get; set; }

            /// <summary>Gets or sets the cancellation token used to cancel a request in the middle.</summary>
            public CancellationTokenSource CancellationTokenSource { get; set; }

            /// <summary>Gets or sets the request index we are going to cancel.</summary>
            public int CancelRequestNum { get; set; }

            /// <summary>Gets or sets the download Uri.</summary>
            public Uri DownloadUri { get; set; }

            /// <summary>The number of bytes this "server" has sent so far.</summary>
            private long bytesRead;

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();

                if (Calls == CancelRequestNum && CancellationTokenSource != null)
                {
                    CancellationTokenSource.Cancel();
                }

                // validate the request
                Assert.That(request.RequestUri, Is.EqualTo(DownloadUri));
                Assert.That(request.Headers.Range, Is.EqualTo(new RangeHeaderValue(bytesRead,
                    bytesRead + ChunkSize - 1)));

                // prepare the response to send back
                var response = new HttpResponseMessage();
                response.StatusCode = StatusCode;
                if (StatusCode == HttpStatusCode.OK)
                {
                    // read the current data from the stream
                    var contentLength = StreamContent.Length;
                    byte[] buffer = new byte[ChunkSize];
                    int currentRead = StreamContent.Read(buffer, 0, ChunkSize);
                    var readStream = new MemoryStream(buffer, 0, currentRead);

                    response.Content = new StreamContent(readStream);
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                    response.Content.Headers.ContentLength = currentRead;
                    response.Content.Headers.ContentRange = new ContentRangeHeaderValue(bytesRead,
                        bytesRead + currentRead - 1, contentLength);

                    bytesRead += currentRead;
                }
                tcs.SetResult(response);
                return tcs.Task;
            }
        }

        /// <summary>Tests that download works in case the server returns multiple chunks to the client.</summary>
        [Test]
        public void Download_MultipleChunks()
        {
            Subtest_Download_Chunks(2);
            Subtest_Download_Chunks((int)StreamContent.Length - 1);
        }

        /// <summary>Tests that download works in case the server returns a single chunk to the client.</summary>
        [Test]
        public void Download_SingleChunk()
        {
            Subtest_Download_Chunks((int)StreamContent.Length);
            Subtest_Download_Chunks((int)StreamContent.Length + 1);
            Subtest_Download_Chunks(100);
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Test]
        public void Download_SingleChunk_UriContainsQueryParameters()
        {
            Subtest_Download_Chunks((int)StreamContent.Length, true, 0, "https://www.sample.com?a=1&b=2");
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Test]
        public void Download_SingleChunk_UriContainsEncodedQueryParameters()
        {
            Subtest_Download_Chunks((int)StreamContent.Length, true, 0, "https://www.sample.com?a=foo%2Fbar");
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Test]
        public void Download_SingleChunk_UriContainsValuelessQueryParameters()
        {
            Subtest_Download_Chunks((int)StreamContent.Length, true, 0, "https://www.sample.com?a&b=1");
        }

        /// <summary>
        /// Tests that download asynchronously works in case the server returns multiple chunks to the client.
        /// </summary>
        [Test]
        public void DownloadAsync_MultipleChunks()
        {
            Subtest_Download_Chunks(2, false);
            Subtest_Download_Chunks((int)StreamContent.Length - 1, false);
        }

        /// <summary>
        /// Tests that download asynchronously works in case the server returns a single chunk to the client.
        /// </summary>
        [Test]
        public void DownloadAsync_SingleChunk()
        {
            Subtest_Download_Chunks((int)StreamContent.Length, false);
            Subtest_Download_Chunks((int)StreamContent.Length + 1, false);
            Subtest_Download_Chunks(100, false);
        }

        /// <summary>
        /// Tests that download asynchronously doesn't succeeded in case a download was cancelled "in the middle".
        /// </summary>
        [Test]
        public void DownloadAsync_Cancel()
        {
            Subtest_Download_Chunks(2, false, 3);
            Subtest_Download_Chunks((int)StreamContent.Length - 1, false, 1);
        }

        /// <summary>A helper test to test sync and async downloads.</summary>
        /// <param name="chunkSize">The chunk size for each part.</param>
        /// <param name="sync">Indicates if this download should be synchronously or asynchronously.</param>
        /// <param name="cancelRequest">Defines the request index to cancel the download request.</param>
        /// <param name="downloadUri">The URI which contains the media to download.</param>
        private void Subtest_Download_Chunks(int chunkSize, bool sync = true, int cancelRequest = 0,
            string downloadUri = "http://www.sample.com")
        {
            // reset the steam
            StreamContent.Position = 0;

            var handler = new MultipleChunksMessageHandler();
            handler.StatusCode = HttpStatusCode.OK;
            handler.ChunkSize = chunkSize;
            handler.DownloadUri = new Uri(downloadUri +
                (downloadUri.Contains("?") ? "&" : "?") + "alt=media");

            // support cancellation
            if (cancelRequest > 0)
            {
                handler.CancelRequestNum = cancelRequest;
            }
            handler.CancellationTokenSource = new CancellationTokenSource();

            int expectedCalls = (int)Math.Ceiling((double)StreamContent.Length / chunkSize);
            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(handler)
                }))
            {
                var downloader = new MediaDownloader(service);
                downloader.ChunkSize = chunkSize;
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                {
                    progressList.Add(p);
                };

                var outputStream = new MemoryStream();
                if (sync)
                {
                    downloader.Download(downloadUri, outputStream);
                }
                else
                {
                    try
                    {
                        var result = downloader.DownloadAsync(downloadUri, outputStream,
                                         handler.CancellationTokenSource.Token).Result;
                        Assert.AreEqual(0, handler.CancelRequestNum);
                    }
                    catch (AggregateException ex)
                    {
                        Assert.IsInstanceOf<TaskCanceledException>(ex.InnerException);
                    }
                }

                var lastProgress = progressList.LastOrDefault();
                if (cancelRequest > 0)
                {
                    // the download was interrupted in the middle
                    Assert.That(handler.Calls, Is.EqualTo(cancelRequest));
                    // last request should fail
                    Assert.NotNull(lastProgress);
                    Assert.NotNull(lastProgress.Exception);
                    Assert.That(lastProgress.Status, Is.EqualTo(DownloadStatus.Failed));
                    Assert.That(lastProgress.BytesDownloaded, Is.EqualTo(chunkSize * cancelRequest));
                }
                else
                {
                    // the download succeeded
                    Assert.That(handler.Calls, Is.EqualTo(expectedCalls));
                    Assert.NotNull(lastProgress);
                    Assert.Null(lastProgress.Exception);
                    Assert.That(lastProgress.Status, Is.EqualTo(DownloadStatus.Completed));
                    Assert.That(lastProgress.BytesDownloaded, Is.EqualTo(StreamContent.Length));

                    byte[] read = new byte[1000];
                    outputStream.Position = 0;
                    int length = outputStream.Read(read, 0, 1000);
                    Assert.That(Encoding.UTF8.GetString(read, 0, length), Is.EqualTo(MediaContent));
                }
            }
        }

        /// <summary>Tests that download reports errors.</summary>
        [Test]
        public void Download_Error()
        {
            var downloadUri = "http://www.sample.com?alt=media";
            var chunkSize = 100;
            // reset the steam
            StreamContent.Position = 0;

            var handler = new MultipleChunksMessageHandler();
            handler.StatusCode = HttpStatusCode.BadRequest;
            handler.ChunkSize = chunkSize;
            handler.DownloadUri = new Uri(downloadUri);

            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(handler)
                }))
            {
                var downloader = new MediaDownloader(service);
                downloader.ChunkSize = chunkSize;
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                    {
                        progressList.Add(p);
                    };

                var outputStream = new MemoryStream();
                downloader.Download(downloadUri, outputStream);

                var lastProgress = progressList.LastOrDefault();
                Assert.That(lastProgress.Status, Is.EqualTo(DownloadStatus.Failed));
            }
        }
    }
}
