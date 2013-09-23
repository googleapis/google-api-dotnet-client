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
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Util;

namespace Google.Apis.Download
{
    /// <summary>
    /// A media downloader implementation which handles media downloads. It supports downloading a media content in 
    /// chunks, when each chunk size is defined by <see cref="ChunkSize"/>.
    /// </summary>
    public class MediaDownloader : IMediaDownloader
    {
        /// <summary>The service which this downloader belongs to.</summary>
        private readonly IClientService service;

        private const int MB = 0x100000;

        /// <summary>Maximum chunk size. Default value is 10*MB.</summary>
        public const int MaximumChunkSize = 10 * MB;

        private int chunkSize = MaximumChunkSize;
        /// <summary> 
        /// Gets or sets the size of each chunk to download from the server.
        /// Chunks can't be set to be a value bigger than <see cref="MaximumChunkSize"/>. Default value is 
        /// <see cref="MaximumChunkSize"/>.
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

        /// <summary
        /// Updates the current progress and call the <see cref="ProgressChanged"/> event to notify listeners.
        /// </summary>
        private void UpdateProgress(IDownloadProgress progress)
        {
            var changed = ProgressChanged;
            if (changed != null)
            {
                changed(progress);
            }
        }

        #endregion

        /// <summary>Constructs a new downloader with the given client service.</summary>
        public MediaDownloader(IClientService service)
        {
            this.service = service;
        }

        #region IMediaDownloader Overrides

        public event Action<IDownloadProgress> ProgressChanged;

        #region Download (sync and async)

        public IDownloadProgress Download(string url, Stream stream)
        {
            return DownloadCore(url, stream, CancellationToken.None).Result;
        }

        public async Task<IDownloadProgress> DownloadAsync(string url, Stream stream)
        {
            return await DownloadAsync(url, stream, CancellationToken.None);
        }

        public async Task<IDownloadProgress> DownloadAsync(string url, Stream stream,
            CancellationToken cancellationToken)
        {
            return await DownloadAsyncCore(url, stream, cancellationToken);
        }

        #endregion

        #endregion

        private Task<IDownloadProgress> DownloadAsyncCore(string url, Stream stream,
            CancellationToken cancellationToken)
        {
            TaskCompletionSource<IDownloadProgress> tcs = new TaskCompletionSource<IDownloadProgress>();
            Task.Factory.StartNew(async () =>
            {
                try
                {
                    var progress = await DownloadCore(url, stream, cancellationToken).ConfigureAwait(false);
                    if (progress.Exception != null)
                    {
                        tcs.SetException(progress.Exception);
                    }
                    else
                    {
                        tcs.SetResult(progress);
                    }
                }
                catch (Exception ex)
                {
                    // exception was thrown - it must be set on the task completion source
                    tcs.SetException(ex);
                }
            }).ConfigureAwait(false);
            return tcs.Task;
        }

        /// <summary>
        /// The core download logic. It downloads the media in parts, where each part's size is defined by 
        /// <see cref="ChunkSize"/> (in bytes).
        /// </summary>
        /// <param name="url">The URL of the resource to download.</param>
        /// <param name="stream">The download will download the resource into this stream.</param>
        /// <param name="cancellationToken">A cancellation token to cancel this download in the middle.</param>
        /// <returns>A task with the download progress object. If an exception occurred during the download, its 
        /// <seealso cref="IDownloadProgress.Exception "/> property will contain the exception.</returns>
        private async Task<IDownloadProgress> DownloadCore(string url, Stream stream,
            CancellationToken cancellationToken)
        {
            // validate the parameters
            url.ThrowIfNull("url");
            stream.ThrowIfNull("stream");
            if (!stream.CanWrite)
            {
                throw new ArgumentException("stream doesn't support write operations");
            }

            var builder = new RequestBuilder() { BaseUri = new Uri(url) };
            builder.AddParameter(RequestParameterType.Query, "alt", "media");

            long currentRequestFirstBytePos = 0;

            try
            {
                // this "infinite" loop stops when the "to" byte position in the "Content-Range" header is the last
                // byte of the media ("length"-1 in the "Content-Range" header).
                // e.g. "Content-Range: 200-299/300" - "to"(299) = "length"(300) - 1.
                while (true)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var currentRequestLastBytePos = currentRequestFirstBytePos + ChunkSize - 1;

                    // create the request and set the Range header
                    var request = builder.CreateRequest();
                    request.Headers.Range = new RangeHeaderValue(currentRequestFirstBytePos,
                        currentRequestLastBytePos);

                    using (var response = await service.HttpClient.SendAsync(request, cancellationToken).
                        ConfigureAwait(false))
                    {
                        // read the content and copy to the parameter's stream
                        var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                        responseStream.CopyTo(stream);

                        // read the headers and check if all the media content was already downloaded
                        var contentRange = response.Content.Headers.ContentRange;
                        currentRequestFirstBytePos = contentRange.To.Value + 1;
                        long mediaContentLength = contentRange.Length.Value;

                        if (currentRequestFirstBytePos == mediaContentLength)
                        {
                            var progress = new DownloadProgress(DownloadStatus.Completed, mediaContentLength);
                            UpdateProgress(progress);
                            return progress;
                        }
                    }

                    UpdateProgress(new DownloadProgress(DownloadStatus.Downloading, currentRequestFirstBytePos));
                }
            }
            catch (Exception ex)
            {
                var progress = new DownloadProgress(ex, currentRequestFirstBytePos);
                UpdateProgress(progress);
                return progress;
            }
        }
    }
}
