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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Download
{
    /// <summary>Media download which uses download file part by part, by <see cref="ChunkSize"/>.</summary>
    public interface IMediaDownloader
    {
        /// <summary>An event which notifies when the download status has been changed.</summary>
        event Action<IDownloadProgress> ProgressChanged;

        /// <summary>Gets or sets the chunk size to download, it defines the size of each part.</summary>
        int ChunkSize { get; set; }

        /// <summary>Downloads synchronously the given URL to the given stream.</summary>
        IDownloadProgress Download(string url, Stream stream);

        /// <summary>Downloads asynchronously the given URL to the given stream.</summary>
        Task<IDownloadProgress> DownloadAsync(string url, Stream stream);

        /// <summary>
        /// Downloads asynchronously the given URL to the given stream. This download method supports a cancellation 
        /// token to cancel a request before it was completed.
        /// </summary>
        /// <remarks>
        /// In case the download fails <see cref="IDownloadProgress.Exception "/> will contain the exception that
        /// cause the failure. The only exception which will be thrown is 
        /// <see cref="System.Threading.Tasks.TaskCanceledException"/> which indicates that the task was canceled.
        /// </remarks>
        Task<IDownloadProgress> DownloadAsync(string url, Stream stream, CancellationToken cancellationToken);
    }
}
