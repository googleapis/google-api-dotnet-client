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

namespace Google.Apis.Download
{
    /// <summary>Enum which represents the status of the current download.</summary>
    public enum DownloadStatus
    {
        /// <summary>The download has not started.</summary>
        NotStarted,

        /// <summary>Data is being downloaded.</summary>
        Downloading,

        /// <summary>The download was completed successfully.</summary>
        Completed,

        /// <summary>The download failed.</summary>
        Failed
    };

    /// <summary>Reports download progress.</summary>
    public interface IDownloadProgress
    {
        /// <summary>Gets the current status of the upload.</summary>
        DownloadStatus Status { get; }

        /// <summary>Gets the number of bytes received from the server.</summary>
        long BytesDownloaded { get; }

        /// <summary>Gets an exception if one occurred.</summary>
        Exception Exception { get; }
    }
}
