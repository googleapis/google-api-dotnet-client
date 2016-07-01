/*
Copyright 2016 Google Inc

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

namespace Google.Apis.Upload
{
    /// <summary>
    /// Interface IUploadSessionData: Provides UploadUri for client to persist. Allows resuming an upload after a program restart for seekable ContentStreams.
    /// </summary>
    /// <remarks>
    /// Defines the data passed from the ResumeableUpload class upon initiation of an upload.
    /// When the client application adds an event handler for the UploadSessionData event, the data
    /// defined in this interface (currently the UploadURI) is passed as a parameter to the event handler procedure.
    /// An event handler for the UploadSessionData event is only required if the application will support resuming the
    /// upload after a program restart.
    /// </remarks>
    public interface IUploadSessionData
    {
        /// <summary>
        /// The resumable session URI (UploadUri)
        /// </summary>
        System.Uri UploadUri { get; }
    }

}
