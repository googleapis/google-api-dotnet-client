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
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Download;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Util;
using Xunit;
using Google.Apis.Tests.Mocks;
using Google.Apis.Http;

namespace Google.Apis.Tests.Apis.Download
{
    /// <summary>Tests for the <see cref="Google.Apis.Download.MediaDownloader"/>.</summary>
    public class MediaDownloaderTest : IDisposable
    {
        /// <summary>A content string that will be returned and looked for.</summary>
        private static readonly byte[] MediaContent = Encoding.UTF8.GetBytes("Media content goes here. This is an example of test content.");

        /// <summary>
        /// An error object that will be returned and looked for.
        /// </summary>
        private static readonly RequestError BadRequestError = new RequestError
        {
            Code = 12345,
            Message = "Bad Request!",
            Errors = new[] { new SingleError { Message = "The request was malformed." } }
        };

        /// <summary>
        /// An error string that will be returned and looked for.
        /// </summary>
        private const string NotFoundError = "No resource found by that name.";

        /// <summary>
        /// Get an available port. This is best-effort since the port may immediately be
        /// used by another process.
        /// </summary>
        /// <returns>A port number</returns>
        private static int GetOpenPort()
        {
            var tcpListener = new TcpListener(IPAddress.Loopback, 0);
            try
            {
                tcpListener.Start();
                return ((IPEndPoint)tcpListener.LocalEndpoint).Port;
            }
            finally
            {
                tcpListener.Stop();
            }
        }

        /// <summary>
        /// Prefix on which the test server will listen. {0} is replaced by port.
        /// </summary>
        private const string PrefixFormat = "http://localhost:{0}/download/";

        public MediaDownloaderTest()
        {
            // Start up the test HTTP server.
            _httpPrefix = String.Format(PrefixFormat, GetOpenPort());
            _httpServerTask = RunTestServer(_httpPrefix);
        }

        public void Dispose()
        {
            try
            {
                Task.Run(async () =>
                {
                    // Shut down the test HTTP server.
                    var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
                    await new HttpClient().GetAsync(_httpPrefix + "Quit", cts.Token);
                    await _httpServerTask;
                }).Wait();
            }
            catch { } // Don't care about exceptions here
        }

    /// <summary>
    /// Prefix on which the test server is listening, e.g. "http://localhost:12345/path/".
    /// </summary>
    private string _httpPrefix;

        /// <summary>
        /// The Task running the test server.
        /// </summary>
        private Task _httpServerTask;

        /// <summary>
        /// Run a simple HTTP server that listens for a few test URIs.
        /// The server exits when a client requests "/Quit".
        /// </summary>
        /// <param name="prefix">Prefix at which the server should listen</param>
        private async Task RunTestServer(string prefix)
        {
            using (var httpListener = new HttpListener())
            {
                httpListener.Prefixes.Add(prefix);
                httpListener.Start();

                while (httpListener.IsListening)
                {
                    var context = await httpListener.GetContextAsync().ConfigureAwait(false);

                    var requestUri = context.Request.Url;
                    var response = context.Response;

                    if (requestUri.AbsolutePath.EndsWith("/Quit"))
                    {
                        // Shut down the HTTP server.
                        response.Close();
                        httpListener.Stop();
                        continue;
                    }

                    // All downloader requests should include ?alt=media.
                    Assert.Equal("media", context.Request.QueryString["alt"]);

                    response.ContentType = "text/plain";
                    response.SendChunked = true;  // Avoid having to set Content-Length.

                    Stream outStream = new MemoryStream();

                    if (requestUri.AbsolutePath.EndsWith("/EchoUrl"))
                    {
                        // Return the URL that we saw.
                        byte[] uriBytes = Encoding.UTF8.GetBytes(requestUri.AbsoluteUri);
                        outStream.Write(uriBytes, 0, uriBytes.Length);
                    }
                    else if (requestUri.AbsolutePath.EndsWith("/BadRequestJson"))
                    {
                        // Return 400 with a JSON-encoded error.
                        var apiResponse = new StandardResponse<object> { Error = BadRequestError };
                        var apiResponseText = new NewtonsoftJsonSerializer().Serialize(apiResponse);
                        byte[] apiResponseBytes = Encoding.UTF8.GetBytes(apiResponseText);

                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        outStream.Write(apiResponseBytes, 0, apiResponseBytes.Length);
                    }
                    else if (requestUri.AbsolutePath.EndsWith("/NotFoundPlainText"))
                    {
                        // Return 404 with a plaintext error.
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        byte[] errorBytes = Encoding.UTF8.GetBytes(NotFoundError);
                        outStream.Write(errorBytes, 0, errorBytes.Length);
                    }
                    else if (requestUri.AbsolutePath.EndsWith("/GzipContent"))
                    {
                        // Return gzip-compressed content.
                        using (var gzipStream = new GZipStream(outStream, CompressionMode.Compress, true))
                        {
                            gzipStream.Write(MediaContent, 0, MediaContent.Length);
                        }
                        response.AddHeader("Content-Encoding", "gzip");
                    }
                    else if (requestUri.AbsolutePath.EndsWith("/NoContent"))
                    {
                        // Return 206 and no content.
                        response.StatusCode = (int)HttpStatusCode.NoContent;
                    }
                    else
                    {
                        // Return plaintext content.
                        outStream.Write(MediaContent, 0, MediaContent.Length);
                    }

                    outStream.Position = 0;

                    // Provide rudimentary, non-robust support for Range.
                    string rangeHeader = context.Request.Headers["Range"];
                    if (rangeHeader != null && response.StatusCode == (int)HttpStatusCode.OK)
                    {
                        var range = RangeHeaderValue.Parse(rangeHeader);
                        var firstRange = range.Ranges.First();

                        long from = firstRange.From ?? 0;
                        long to = Math.Min(outStream.Length - 1, firstRange.To ?? long.MaxValue);

                        var contentRangeHeader = new ContentRangeHeaderValue(from, to, outStream.Length);
                        response.AddHeader("Content-Range", contentRangeHeader.ToString());

                        outStream.Position = from;
                        outStream.SetLength(to + 1);
                    }

                    await outStream.CopyToAsync(response.OutputStream).ConfigureAwait(false);

                    response.Close();
                }
            }
        }

        /// <summary>Tests that download works in case the server returns multiple chunks to the client.</summary>
        [Fact]
        public void Download_MultipleChunks()
        {
            Subtest_Download_Chunks(2);
            Subtest_Download_Chunks(MediaContent.Length - 1);
        }

        /// <summary>Tests that download works in case the data is retrieved in multiple chunks and is gzipped.</summary>
        [Fact]
        public void Download_MultipleChunksGzipped()
        {
            Subtest_Download_Chunks(2, true, 0, "GzipContent");
        }

        /// <summary>Tests that download works in case the server returns a single chunk to the client.</summary>
        [Fact]
        public void Download_SingleChunk()
        {
            Subtest_Download_Chunks(MediaContent.Length);
            Subtest_Download_Chunks(MediaContent.Length + 1);
            Subtest_Download_Chunks(100);
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Fact]
        public void Download_SingleChunk_UriContainsQueryParameters()
        {
            string url = _httpPrefix + "EchoUrl?a=1&b=2";
            Assert.Equal(SimpleDownload(url), url + "&alt=media");
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Fact]
        public void Download_SingleChunk_UriContainsEncodedQueryParameters()
        {
            string url = _httpPrefix + "EchoUrl?a=foo%2Fbar";
            Assert.Equal(SimpleDownload(url), url + "&alt=media");
        }

        /// <summary>Tests that download works in case the URI download contains query parameters.</summary>
        [Fact]
        public void Download_SingleChunk_UriContainsValuelessQueryParameters()
        {
            string url = _httpPrefix + "EchoUrl?a&b=1";
            Assert.Equal(SimpleDownload(url), url + "&alt=media");
        }

        /// <summary>
        /// Tests that download asynchronously works in case the server returns multiple chunks to the client.
        /// </summary>
        [Fact]
        public void DownloadAsync_MultipleChunks()
        {
            Subtest_Download_Chunks(2, false);
            Subtest_Download_Chunks(MediaContent.Length - 1, false);
        }

        /// <summary>
        /// Tests that download asynchronously works in case the server returns a single chunk to the client.
        /// </summary>
        [Fact]
        public void DownloadAsync_SingleChunk()
        {
            Subtest_Download_Chunks(MediaContent.Length, false);
            Subtest_Download_Chunks(MediaContent.Length + 1, false);
            Subtest_Download_Chunks(100, false);
        }

        /// <summary>
        /// Tests that download asynchronously doesn't succeeded in case a download was cancelled "in the middle".
        /// </summary>
        [Fact]
        public void DownloadAsync_Cancel()
        {
            Subtest_Download_Chunks(2, false, 3);
            Subtest_Download_Chunks(MediaContent.Length - 1, false, 1);
        }

        [Fact]
        public void DownloadRange()
        {
            using (var service = new MockClientService())
            {
                int startInclusive = 5;
                int endInclusive = 13;
                var downloader = new MediaDownloader(service);
                downloader.Range = new RangeHeaderValue(startInclusive, endInclusive);
                var outputStream = new MemoryStream();
                var result = downloader.Download(_httpPrefix + "content", outputStream);

                Assert.Equal(DownloadStatus.Completed, result.Status);
                Assert.Null(result.Exception);
                Assert.Equal(result.BytesDownloaded, outputStream.Position);

                byte[] bytes = outputStream.ToArray();
                Assert.Equal(endInclusive - startInclusive + 1, bytes.Length);
                byte[] expectedBytes = MediaContent.Skip(startInclusive).Take(bytes.Length).ToArray();
                Assert.Equal(expectedBytes, bytes);
            }
        }

        /// <summary>
        /// Uses MediaDownloader to download the contents of a URI.
        /// Asserts that the download succeeded and returns the resulting content as a string.
        /// </summary>
        /// <param name="uri">Uri to download</param>
        /// <returns></returns>
        private string SimpleDownload(string uri)
        {
            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service);
                var outputStream = new MemoryStream();
                var result = downloader.Download(uri, outputStream);

                Assert.Equal(DownloadStatus.Completed, result.Status);
                Assert.Null(result.Exception);
                Assert.Equal(result.BytesDownloaded, outputStream.Position);

                return Encoding.UTF8.GetString(outputStream.ToArray(), 0, (int)outputStream.Position);
            }
        }

        /// <summary>A helper test to test sync and async downloads.</summary>
        /// <param name="chunkSize">The chunk size for each part.</param>
        /// <param name="sync">Indicates if this download should be synchronously or asynchronously.</param>
        /// <param name="cancelChunk">Defines the chunk at which to cancel the download request.</param>
        /// <param name="target">Last component of the Uri to download</param>
        private void Subtest_Download_Chunks(int chunkSize, bool sync = true, int cancelChunk = 0, string target = "content")
        {
            string downloadUri = _httpPrefix + target;
            var cts = new CancellationTokenSource();

            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service);
                downloader.ChunkSize = chunkSize;
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                int progressUpdates = 0;
                long lastBytesDownloaded = 0;
                downloader.ProgressChanged += (p) =>
                {
                    if (p.Status != DownloadStatus.Failed)
                    {
                        // We shouldn't receive duplicate notifications for the same range.
                        Assert.True(p.BytesDownloaded > lastBytesDownloaded);
                    }
                    lastBytesDownloaded = p.BytesDownloaded;

                    progressList.Add(p);
                    if (++progressUpdates == cancelChunk)
                    {
                        cts.Cancel();
                    }
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
                        var result = downloader.DownloadAsync(downloadUri, outputStream, cts.Token).Result;
                        if (result.Exception == null)
                        {
                            Assert.Equal(0, cancelChunk);
                        }
                        else
                        {
                            Assert.IsType<OperationCanceledException>(result.Exception);
                        }
                    }
                    catch (AggregateException ex)
                    {
                        Assert.IsType<TaskCanceledException>(ex.InnerException);
                    }
                }

                var lastProgress = progressList.LastOrDefault();
                if (cancelChunk > 0)
                {
                    // last request should fail
                    Assert.NotNull(lastProgress);
                    Assert.NotNull(lastProgress.Exception);
                    Assert.Equal(DownloadStatus.Failed, lastProgress.Status);
                    Assert.Equal(chunkSize * cancelChunk, lastProgress.BytesDownloaded);
                }
                else
                {
                    Assert.NotNull(lastProgress);
                    Assert.Null(lastProgress.Exception);
                    Assert.Equal(DownloadStatus.Completed, lastProgress.Status);
                    Assert.Equal(MediaContent.Length, lastProgress.BytesDownloaded);

                    byte[] actual = outputStream.ToArray();
                    Assert.Equal(MediaContent, actual);
                }
            }
        }

        /// <summary>
        /// Tests that MediaDownloader properly handles an empty reply (206 No Content).
        /// </summary>
        [Fact]
        public void Download_NoContent()
        {
            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service);
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                {
                    progressList.Add(p);
                };

                var outputStream = new MemoryStream();
                downloader.Download(_httpPrefix + "NoContent", outputStream);

                // We expect only one event -- "completed".
                Assert.Equal(1, progressList.Count);

                var progress = progressList[0];

                Assert.Equal(DownloadStatus.Completed, progress.Status);
                Assert.Equal(0, progress.BytesDownloaded);
                Assert.Equal(0, outputStream.Length);
            }
        }

        /// <summary>Tests that download reports errors, deserializing a JSON response correctly.</summary>
        [Fact]
        public void Download_Error_JsonResponse()
        {
            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service);
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                    {
                        progressList.Add(p);
                    };

                var outputStream = new MemoryStream();
                downloader.Download(_httpPrefix + "BadRequestJson", outputStream);

                var lastProgress = progressList.LastOrDefault();
                Assert.Equal(DownloadStatus.Failed, lastProgress.Status);
                GoogleApiException exception = (GoogleApiException) lastProgress.Exception;
                Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
                // Just a smattering of checks - if these two pass, it's surely okay.
                Assert.Equal(BadRequestError.Code, exception.Error.Code);
                Assert.Equal(BadRequestError.Errors[0].Message, exception.Error.Errors[0].Message);
            }
        }

        [Fact]
        public void Download_Error_PlaintextResponse()
        {
            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service);
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                {
                    progressList.Add(p);
                };

                var outputStream = new MemoryStream();
                downloader.Download(_httpPrefix + "NotFoundPlainText", outputStream);

                var lastProgress = progressList.LastOrDefault();
                Assert.Equal(DownloadStatus.Failed, lastProgress.Status);
                GoogleApiException exception = (GoogleApiException) lastProgress.Exception;
                Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
                Assert.Equal(NotFoundError, exception.Message);
                Assert.Null(exception.Error);
            }
        }

        [Fact]
        public void InterceptPlain()
        {
            var interceptedData = new MemoryStream();
            StreamInterceptor interceptor = interceptedData.Write;
            int interceptorProviderCount = 0;

            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service)
                {
                    ChunkSize = 10,
                    ResponseStreamInterceptorProvider = _ =>
                    {
                        interceptorProviderCount++;
                        return interceptor;
                    }
                };

                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                {
                    progressList.Add(p);
                };

                var outputStream = new MemoryStream();
                downloader.Download(_httpPrefix + "PlainText", outputStream);

                // We only had one HTTP response, even though we read it in multiple chunks.
                Assert.Equal(1, interceptorProviderCount);

                // The end result is plain text content.
                Assert.Equal(MediaContent, outputStream.ToArray());

                // We intercepted the plain text content too.
                Assert.Equal(MediaContent, interceptedData.ToArray());
            }
        }

        [Fact]
        public void InterceptGzip()
        {
            var compressedData = new MemoryStream();
            using (var gzipStream = new GZipStream(compressedData, CompressionMode.Compress, true))
            {
                gzipStream.Write(MediaContent, 0, MediaContent.Length);
            }

            var interceptedData = new MemoryStream();
            StreamInterceptor interceptor = interceptedData.Write;
            int interceptorProviderCount = 0;

            using (var service = new MockClientService())
            {
                var downloader = new MediaDownloader(service)
                {
                    ChunkSize = 10,
                    ResponseStreamInterceptorProvider = _ =>
                    {
                        interceptorProviderCount++;
                        return interceptor;
                    }
                };
                
                IList<IDownloadProgress> progressList = new List<IDownloadProgress>();
                downloader.ProgressChanged += (p) =>
                {
                    progressList.Add(p);
                };

                var outputStream = new MemoryStream();
                downloader.Download(_httpPrefix + "GzipContent", outputStream);

                // We only had one HTTP response, even though we read it in multiple chunks.
                Assert.Equal(1, interceptorProviderCount);

                // The end result is decompressed content.
                Assert.Equal(MediaContent, outputStream.ToArray());

                // We intercepted the compressed content.
                Assert.Equal(compressedData.ToArray(), interceptedData.ToArray());
            }
        }
    }
}
