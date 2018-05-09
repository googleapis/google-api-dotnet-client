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
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Logging;
using Google.Apis.Media;
using Google.Apis.Services;
using Google.Apis.Util;
using System.Net.Http.Headers;
using Google.Apis.Http;

namespace Google.Apis.Download
{
    /// <summary>
    /// A media downloader implementation which handles media downloads.
    /// </summary>
    public class MediaDownloader : IMediaDownloader
    {
        static MediaDownloader()
        {
            UriPatcher.PatchUriQuirks();
        }

        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<MediaDownloader>();

        /// <summary>The service which this downloader belongs to.</summary>
        private readonly IClientService service;

        private const int MB = 0x100000;

        /// <summary>Maximum chunk size. Default value is 10*MB.</summary>
        public const int MaximumChunkSize = 10 * MB;

        private int chunkSize = MaximumChunkSize;
        /// <summary>
        /// Gets or sets the amount of data that will be downloaded before notifying the caller of
        /// the download's progress.
        /// Must not exceed <see cref="MaximumChunkSize"/>.
        /// Default value is <see cref="MaximumChunkSize"/>.
        /// </summary>
        public int ChunkSize
        {
            get { return chunkSize; }
            set
            {
                if (value > MaximumChunkSize)
                {
                    throw new ArgumentOutOfRangeException("ChunkSize");
                }
                chunkSize = value;
            }
        }

        /// <summary>
        /// The range header for the request, if any. This can be used to download specific parts
        /// of the requested media.
        /// </summary>
        public RangeHeaderValue Range { get; set; }

        /// <summary>
        /// A provider for response stream interceptors. Each time a response is produced, the provider
        /// is called, and can return <c>null</c> if interception is not required, or an interceptor for
        /// that response. The provider itself should not read the response's content stream, but can check headers.
        /// </summary>
        public Func<HttpResponseMessage, StreamInterceptor> ResponseStreamInterceptorProvider { get; set; }

        #region Progress

        /// <summary>
        /// Download progress model, which contains the status of the download, the amount of bytes whose where 
        /// downloaded so far, and an exception in case an error had occurred.
        /// </summary>
        private class DownloadProgress : IDownloadProgress
        {
            /// <summary>Constructs a new progress instance.</summary>
            /// <param name="status">The status of the download.</param>
            /// <param name="bytes">The number of bytes received so far.</param>
            public DownloadProgress(DownloadStatus status, long bytes)
            {
                Status = status;
                BytesDownloaded = bytes;
            }

            /// <summary>Constructs a new progress instance.</summary>
            /// <param name="exception">An exception which occurred during the download.</param>
            /// <param name="bytes">The number of bytes received before the exception occurred.</param>
            public DownloadProgress(Exception exception, long bytes)
            {
                Status = DownloadStatus.Failed;
                BytesDownloaded = bytes;
                Exception = exception;
            }

            /// <summary>Gets or sets the status of the download.</summary>
            public DownloadStatus Status { get; private set; }

            /// <summary>Gets or sets the amount of bytes that have been downloaded so far.</summary>
            public long BytesDownloaded { get; private set; }

            /// <summary>Gets or sets the exception which occurred during the download or <c>null</c>.</summary>
            public Exception Exception { get; private set; }
        }

        /// <summary>
        /// Updates the current progress and call the <see cref="ProgressChanged"/> event to notify listeners.
        /// </summary>
        private void UpdateProgress(IDownloadProgress progress)
        {
            ProgressChanged?.Invoke(progress);
        }

        #endregion

        /// <summary>Constructs a new downloader with the given client service.</summary>
        public MediaDownloader(IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets or sets the callback for modifying requests made when downloading.
        /// </summary>
        public Action<HttpRequestMessage> ModifyRequest { get; set; }

        #region IMediaDownloader Overrides

        /// <inheritdoc/>
        public event Action<IDownloadProgress> ProgressChanged;

        #region Download (sync and async)

        /// <inheritdoc/>
        public IDownloadProgress Download(string url, Stream stream)
        {
            return DownloadCoreAsync(url, stream, CancellationToken.None).Result;
        }

        /// <inheritdoc/>
        public async Task<IDownloadProgress> DownloadAsync(string url, Stream stream)
        {
            return await DownloadAsync(url, stream, CancellationToken.None).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IDownloadProgress> DownloadAsync(string url, Stream stream,
            CancellationToken cancellationToken)
        {
            return await DownloadCoreAsync(url, stream, cancellationToken).ConfigureAwait(false);
        }

        #endregion

        #endregion

        /// <summary>
        /// CountedBuffer bundles together a byte buffer and a count of valid bytes.
        /// </summary>
        private class CountedBuffer
        {
            public byte[] Data { get; set; }

            /// <summary>
            /// How many bytes at the beginning of Data are valid.
            /// </summary>
            public int Count { get; private set; }

            public CountedBuffer(int size)
            {
                Data = new byte[size];
                Count = 0;
            }

            /// <summary>
            /// Returns true if the buffer contains no data.
            /// </summary>
            public bool IsEmpty { get { return Count == 0; } }

            /// <summary>
            /// Read data from stream until the stream is empty or the buffer is full.
            /// </summary>
            /// <param name="stream">Stream from which to read.</param>
            /// <param name="cancellationToken">Cancellation token for the operation.</param>
            public async Task Fill(Stream stream, CancellationToken cancellationToken)
            {
                // ReadAsync may return if it has *any* data available, so we loop.
                while (Count < Data.Length)
                {
                    int read = await stream.ReadAsync(Data, Count, Data.Length - Count, cancellationToken).ConfigureAwait(false);
                    if (read == 0) { break; }
                    Count += read;
                }
            }

            /// <summary>
            /// Remove the first n bytes of the buffer. Move any remaining valid bytes to the beginning.
            /// Trying to remove more bytes than the buffer contains just clears the buffer.
            /// </summary>
            /// <param name="n">The number of bytes to remove.</param>
            public void RemoveFromFront(int n)
            {
                if (n >= Count)
                {
                    Count = 0;
                }
                else
                {
                    // Some valid data remains.
                    Array.Copy(Data, n, Data, 0, Count - n);
                    Count -= n;
                }
            }
        }

        /// <summary>
        /// The core download logic. We download the media and write it to an output stream
        /// ChunkSize bytes at a time, raising the ProgressChanged event after each chunk.
        /// 
        /// The chunking behavior is largely a historical artifact: a previous implementation
        /// issued multiple web requests, each for ChunkSize bytes. Now we do everything in
        /// one request, but the API and client-visible behavior are retained for compatibility.
        /// </summary>
        /// <param name="url">The URL of the resource to download.</param>
        /// <param name="stream">The download will download the resource into this stream.</param>
        /// <param name="cancellationToken">A cancellation token to cancel this download in the middle.</param>
        /// <returns>A task with the download progress object. If an exception occurred during the download, its 
        /// <see cref="IDownloadProgress.Exception "/> property will contain the exception.</returns>
        private async Task<IDownloadProgress> DownloadCoreAsync(string url, Stream stream,
            CancellationToken cancellationToken)
        {
            url.ThrowIfNull("url");
            stream.ThrowIfNull("stream");
            if (!stream.CanWrite)
            {
                throw new ArgumentException("stream doesn't support write operations");
            }

            // Add alt=media to the query parameters.
            var uri = new UriBuilder(url);
            if (uri.Query == null || uri.Query.Length <= 1)
            {
                uri.Query = "alt=media";
            }
            else
            {
                // Remove the leading '?'. UriBuilder.Query doesn't round-trip.
                uri.Query = uri.Query.Substring(1) + "&alt=media";
            }

            var request = new HttpRequestMessage(HttpMethod.Get, uri.Uri);
            request.Headers.Range = Range;
            if (ResponseStreamInterceptorProvider != null)
            {
                request.Properties[ConfigurableMessageHandler.ResponseStreamInterceptorProviderKey] = ResponseStreamInterceptorProvider;
            }
            ModifyRequest?.Invoke(request);

            // Number of bytes sent to the caller's stream.
            long bytesReturned = 0;

            try
            {
                // Signal SendAsync to return as soon as the response headers are read.
                // We'll stream the content ourselves as it becomes available.
                var completionOption = HttpCompletionOption.ResponseHeadersRead;

                using (var response = await service.HttpClient.SendAsync(request, completionOption, cancellationToken).ConfigureAwait(false))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw await MediaApiErrorHandling.ExceptionForResponseAsync(service, response).ConfigureAwait(false);
                    }

                    OnResponseReceived(response);

                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        // We send ChunkSize bytes at a time to the caller, but we keep ChunkSize + 1 bytes
                        // buffered. That way we can tell when we've reached the end of the response, even if the
                        // response length is evenly divisible by ChunkSize, and we can avoid sending a Downloading
                        // event followed by a Completed event with no bytes downloaded in between.
                        //
                        // This maintains the client-visible behavior of a previous implementation.
                        var buffer = new CountedBuffer(ChunkSize + 1);

                        while (true)
                        {
                            await buffer.Fill(responseStream, cancellationToken).ConfigureAwait(false);

                            // Send one chunk to the caller's stream.
                            int bytesToReturn = Math.Min(ChunkSize, buffer.Count);
                            OnDataReceived(buffer.Data, bytesToReturn);
                            await stream.WriteAsync(buffer.Data, 0, bytesToReturn, cancellationToken).ConfigureAwait(false);
                            bytesReturned += bytesToReturn;

                            buffer.RemoveFromFront(ChunkSize);
                            if (buffer.IsEmpty)
                            {
                                // We had <= ChunkSize bytes buffered, so we've read and returned the entire response.
                                // Skip sending a Downloading event. We'll send Completed instead.
                                break;
                            }

                            UpdateProgress(new DownloadProgress(DownloadStatus.Downloading, bytesReturned));
                        }
                    }
                    OnDownloadCompleted();

                    var finalProgress = new DownloadProgress(DownloadStatus.Completed, bytesReturned);
                    UpdateProgress(finalProgress);
                    return finalProgress;
                }
            }
            catch (TaskCanceledException ex)
            {
                Logger.Error(ex, "Download media was canceled");
                UpdateProgress(new DownloadProgress(ex, bytesReturned));
                throw;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Exception occurred while downloading media");
                var progress = new DownloadProgress(ex, bytesReturned);
                UpdateProgress(progress);
                return progress;
            }
        }

        /// <summary>
        /// Called when a successful HTTP response is received, allowing subclasses to examine headers.
        /// </summary>
        /// <remarks>
        /// For unsuccessful responses, an appropriate exception is thrown immediately, without this method
        /// being called.
        /// </remarks>
        /// <param name="response">HTTP response received.</param>
        protected virtual void OnResponseReceived(HttpResponseMessage response)
        {
            // No-op
        }

        /// <summary>
        /// Called when an HTTP response is received, allowing subclasses to examine data before it's
        /// written to the client stream.
        /// </summary>
        /// <param name="data">Byte array containing the data downloaded.</param>
        /// <param name="length">Length of data downloaded in this chunk, in bytes.</param>
        protected virtual void OnDataReceived(byte[] data, int length)
        {
            // No-op
        }

        /// <summary>
        /// Called when a download has completed, allowing subclasses to perform any final validation
        /// or transformation.
        /// </summary>
        protected virtual void OnDownloadCompleted()
        {
            // No-op
        }
    }
}
