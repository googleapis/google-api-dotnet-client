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
using System.Linq;
using System.Text;

namespace Google.Apis.Upload
{
    /// <summary>
    /// Enum to communicate the status of an upload for progress reporting.
    /// </summary>
    public enum UploadStatus
    {
        /// <summary>
        /// The upload has not started.
        /// </summary>
        NotStarted,

        /// <summary>
        /// The upload is initializing.
        /// </summary>
        Starting,

        /// <summary>
        /// Data is being uploaded.
        /// </summary>
        Uploading,

        /// <summary>
        /// The upload completed successfully.
        /// </summary>
        Completed,

        /// <summary>
        /// The upload failed.
        /// </summary>
        Failed
    };

    /// <summary>
    /// Interface reporting upload progress.
    /// </summary>
    public interface IUploadProgress
    {
        /// <summary>
        /// Gets the current status of the upload
        /// </summary>
        UploadStatus Status { get; }
        
        /// <summary>
        /// Gets the approximate number of bytes sent to the server.
        /// </summary>
        long BytesSent { get; }

        /// <summary>
        /// Gets an exception if one occurred.
        /// </summary>
        Exception Exception { get; }
    }
}
