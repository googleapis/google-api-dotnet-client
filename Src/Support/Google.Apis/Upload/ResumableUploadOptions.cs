// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Http;
using System;
using System.Net.Http;

namespace Google.Apis.Upload
{
    /// <summary>
    /// Options for <see cref="ResumableUpload"/> operations.
    /// </summary>
    public sealed class ResumableUploadOptions
    {
        /// <summary>
        /// Gets or sets the HTTP client to use when starting the upload sessions and uploading data.
        /// </summary>
        public HttpClient HttpClient { get; set; }

        /// <summary>
        /// Gets or sets the callback for modifying the session initiation request.
        /// See https://cloud.google.com/storage/docs/json_api/v1/how-tos/resumable-upload#start-resumable for more information.
        /// </summary>
        /// <remarks>
        /// Note: If these options are used with a <see cref="ResumableUpload"/> created using <see cref="ResumableUpload.CreateFromUploadUri"/>,
        /// this property will be ignored as the session has already been initiated.
        /// </remarks>
        public Action<HttpRequestMessage> ModifySessionInitiationRequest { get; set; }

        /// <summary>
        /// Gets or sets the serializer to use when parsing error responses.
        /// </summary>
        public ISerializer Serializer { get; set; }

        /// <summary>
        /// Gets or sets the name of the service performing the upload.
        /// </summary>
        /// <remarks>
        /// This will be used to set the <see cref="GoogleApiException.ServiceName"/> in the event of an error.
        /// </remarks>
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets the <see cref="HttpClient"/> as a <see cref="Google.Apis.Http.ConfigurableHttpClient"/> if it is an instance of one.
        /// </summary>
        internal ConfigurableHttpClient ConfigurableHttpClient => HttpClient as ConfigurableHttpClient;
    }
}
