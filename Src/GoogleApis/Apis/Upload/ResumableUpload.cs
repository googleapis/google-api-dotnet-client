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
using System.Linq;
using System.Net;
using System.Text;
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Upload
{
    /// <summary>
    /// Media upload which uses Google's resumable media upload protocol to upload data.
    /// </summary>
    /// <remarks>
    /// See: http://code.google.com/apis/gdata/docs/resumable_upload.html for
    /// information on the protocol.
    /// </remarks>
    public abstract class ResumableUpload<T>
    {
        #region Constants
        /// <summary>
        /// Chunks (except the last chunk) must be a multiple of 256KB to be compatible with
        /// Google upload servers.
        /// </summary>
        private const int MinimumChunkSize = 262144; // 256 KB
        
        /// <summary>
        /// Default chunk size is set to 4 times the <see cref="MinumumChunkSize"/>of 256KB or 1MB 
        /// total.
        /// </summary>
        /// <seealso cref="MinumumChunkSize"/>
        private const int DefaultChunkSize = MinimumChunkSize * 4;
        
        /// <summary>
        /// Buffer size is used to read chunks from the input stream and write to the output stream.
        /// TODO: Improve the read/write scheme to remove the buffer altogether and simply pipe the
        ///       input to the request.
        /// <summary>
        private const int BufferSize = 16384; // 16 KB
        
        /// <summary>
        /// Constants for HTTP headers related to the resumable upload protocol.
        /// </summary>
        private const string JsonMimeType = "application/json";
        
        /// <summary>
        /// Payload description headers, describing the content itself.
        /// </summary>
        private const string PayloadContentTypeHeader = "X-Upload-Content-Type";

        /// <summary>
        /// Payload description headers, describing the content itself.
        /// </summary>
        private const string PayloadContentLengthHeader = "X-Upload-Content-Length";

        /// <summary>
        /// 
        /// </summary>
        private const string ErrorKey = "error";

        #endregion // Constants

        #region Construction

        /// <summary>
        /// Create a resumable upload instance with the required parameters.
        /// </summary>
        /// <param name="stream">The payload stream to be uploaded.</param>
        /// <param name="contentType">The content-type of the data to be uploaded.</param>
        protected ResumableUpload(Stream stream, string contentType)
        {
            stream.ThrowIfNull("stream");
            contentType.ThrowIfNullOrEmpty("contentType");

            this.RequestFactory = HttpRequestFactory.Instance;
            this.Authenticator = NullAuthenticator.Instance;
            this.ChunkSize = DefaultChunkSize;
            this.Stream = stream;
            this.ContentType = contentType;
        }

        #endregion // Construction

        #region Properties

        /// <summary>
        /// Payload stream to be uploaded.
        /// </summary>
        public Stream Stream { get; set; }

        /// <summary>
        /// Content-Type to be uploaded (required).
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// The body of this request.
        /// </summary>
        public T Body { get; set;  }

        /// <summary>
        /// Authenticator which modifies requests for authentication.
        /// </summary>
        public IAuthenticator Authenticator { get; set; }

        /// <summary>
        /// ICreateHttpRequest instance used to create HTTP requests.
        /// </summary>
        public ICreateHttpRequest RequestFactory { get; set; }


        /// <summary>
        /// The size of each chunk sent to the servers.
        /// </summary>
        /// <remarks>
        /// This property is currently private, though it might be made public in the future if needed.
        /// Currently, google's resumable upload implementation requires sequential chunks in multiples
        /// of the <see cref="MinimumChunkSize"/> specified 
        /// </remarks>
        protected int ChunkSize { get; set; }

        #endregion // Properties

        #region Progress Monitoring

        /// <summary>
        /// Class that communicates the progress of resumable uploads to a container.
        /// </summary>
        private class ResumableUploadProgress : IUploadProgress
        {
            /// <summary>
            /// Create a ResumableUploadProgress instance.
            /// </summary>
            /// <param name="status">The status of the upload.</param>
            /// <param name="bytesSent">The number of bytes sent so far.</param>
            public ResumableUploadProgress(UploadStatus status, long bytesSent)
            {
                this.Status = status;
                this.BytesSent = bytesSent;
            }

            /// <summary>
            /// Create a ResumableUploadProgress instance.
            /// </summary>
            /// <param name="exception">An exception that occurred during the upload.</param>
            /// <param name="bytesSent">The number of bytes sent before this exception occurred.</param>
            public ResumableUploadProgress(Exception exception, long bytesSent)
            {
                this.Status = UploadStatus.Failed;
                this.BytesSent = bytesSent;
                this.Exception = exception;
            }

            public UploadStatus Status { get; private set; }
            public long BytesSent { get; private set; }
            public Exception Exception { get; private set; }
        }

        private ResumableUploadProgress Progress { get; set; }

        public event Action<IUploadProgress> ProgressChanged;

        private void UpdateProgress(UploadStatus status, long byteCount)
        {
            var p = new ResumableUploadProgress(status, byteCount);
            this.Progress = p;
            if(ProgressChanged != null)
                ProgressChanged(p);
        }

        public IUploadProgress GetProgress()
        {
            return this.Progress;
        }

        #endregion

        #region Upload Implementation
        /// <summary>
        /// Perform the upload.
        /// </summary>
        public void Upload()
        {
            long bytesSent = 0;
            try
            {
                UpdateProgress(UploadStatus.Starting, 0);
                Uri url = InitializeUpload();
                UpdateProgress(UploadStatus.Uploading, 0);
                while (bytesSent < this.Stream.Length)
                {
                    bytesSent += SendChunk(url, bytesSent);
                    UpdateProgress(UploadStatus.Uploading, bytesSent);
                }
                UpdateProgress(UploadStatus.Completed, bytesSent);
            }
            catch (WebException we)
            {
                var responseStream = we.Response.GetResponseStream();
                if (responseStream == null)
                    throw;
                string r = (new StreamReader(responseStream)).ReadToEnd();
                var x = Json.JsonReader.Parse(r) as Json.JsonDictionary;
                if (x.ContainsKey(ErrorKey))
                {
                    var y = x["error"] as Json.JsonDictionary;
                    if (y.ContainsKey("message"))
                    {
                        throw new Exception(y["message"] as string);
                    }
                }
            }
            catch (Exception)
            {
                /// Attempt to update the progress to show failure,
                /// swallow any exceptions that occured and re-throw the original
                /// exception.
                try
                {
                    UpdateProgress(UploadStatus.Failed, bytesSent);
                }
                catch (Exception) { }
                throw;
            }
        }

        /// <summary>
        /// Initializes the resumable upload by calling the resumable rest interface to get
        /// a unique upload Location
        /// </summary>
        /// <returns>
        /// The unique upload location for this upload, returned in the Location header
        /// </returns>
        private Uri InitializeUpload()
        {
            HttpWebRequest request = CreateInitializeRequest();
            WebResponse response = request.GetResponse();
            return new Uri(response.Headers["Location"]);
        }

        /// <summary>
        /// Upload a chunk of the data to the server.
        /// </summary>
        /// <param name="uri">The upload location (specifically generated for this upload).</param>
        /// <param name="position">The current position in the payload.</param>
        protected virtual long SendChunk(Uri uri, long position)
        {
            long chunkSize = Math.Min(this.Stream.Length - position, ChunkSize);
            byte[] buffer = new byte[Math.Min(chunkSize, BufferSize)];
            var req = this.RequestFactory.Create(uri, Request.PUT);
            req.ContentLength = chunkSize;
            req.Headers.Add(HttpRequestHeader.ContentRange,
                GetContentRangeHeader(position, chunkSize, this.Stream.Length));

            try
            {
                Stream requestStream = req.GetRequestStream();

                int dataWritten = 0;
                while (dataWritten < chunkSize)
                {
                    int len = this.Stream.Read(buffer, 0, buffer.Length);
                    requestStream.Write(buffer, 0, len);
                    dataWritten += len;
                }

                // req.GetResponse() will throw an exception when this request 
                // completes successfully because the server returns an HTTP 308
                // on success.
                var response = req.GetResponse();
            }
            catch (WebException we)
            {
                // Catch and release on HTTP response code 308. The upload protocol
                // uses 308 to indicate that there is more data expected from the server.
                var response = we.Response as HttpWebResponse;
                if(response == null || response.StatusCode != (HttpStatusCode)308)
                    throw;
            }

            return chunkSize;
        }

        /// <summary>
        /// Build a content range header of the form: "bytes X-Y/T" where:
        /// <list type="">
        /// <item>X is the first byte being sent.</item>
        /// <item>Y is the last byte in the range being sent (inclusive).</item>
        /// <item>Y is the total number of bytes in the range.</item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The specified range is 0 based inclusive, so uploading a 100 byte file in one chunk
        /// would be specified as bytes 0-99/100.
        /// </remarks>
        /// <param name="chunkStart">Start of the chunk.</param>
        /// <param name="chunkSize">Size of the chunk being sent.</param>
        /// <param name="totalSize">Total number of bytes in the entire file.</param>
        /// <returns></returns>
        private string GetContentRangeHeader(long chunkStart, long chunkSize, long totalSize)
        {
            long chunkEnd = chunkStart + chunkSize - 1;
            return String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd, totalSize);
        }

        /// <summary>
        /// Create a request to initialize a request.
        /// </summary>
        /// <returns>
        /// An HttpWebRequest configured to initialize a request.
        /// </returns>
        private HttpWebRequest CreateInitializeRequest()
        {
            var baseUri = new UriBuilder(this.InitializeUri);
            baseUri.Query = String.Join("&", GetQueryParameters()
                .Select(x => String.Format("{0}={1}", x.Key, x.Value))
                .ToArray());

            var request = this.RequestFactory.Create(baseUri.Uri, this.HttpMethod);
            request.Headers.Add(PayloadContentTypeHeader, this.ContentType);
            request.Headers.Add(PayloadContentLengthHeader, this.Stream.Length.ToString());

            if (this.Authenticator != null)
                Authenticator.ApplyAuthenticationToRequest(request);

            var json = new Json.NewtonsoftJsonSerializer();
            string bodyText = json.Serialize(this.Body);
            byte[] body = Encoding.UTF8.GetBytes(bodyText);
            request.ContentType = "application/json";
            request.ContentLength = body.Length;

            var requestBodyStream = request.GetRequestStream();
            requestBodyStream.Write(body, 0, body.Length);
            return request;
        }

        #endregion Upload Implementation

        #region Abstract Methods

        /// <summary>
        /// The HttpMethod of the upload initialization request.
        /// </summary>
        protected abstract string HttpMethod { get; }

        /// <summary>
        /// The BaseUri of the upload initialization request.
        /// </summary>
        protected abstract Uri InitializeUri { get; }

        /// <summary>
        /// The BaseUri of the upload initialization request.
        /// </summary>
        /// protected abstract Uri Path { get; }

        /// <summary>
        /// Gets a dictionary 
        /// </summary>
        /// <returns>A dictionary of the query parameters applied to this request.</returns>
        protected virtual IDictionary<string, string> GetQueryParameters()
        {
            return new Dictionary<string, string>() { { "uploadType", "resumable" } };
        }

        #endregion // Abstract Methods
    }
}
