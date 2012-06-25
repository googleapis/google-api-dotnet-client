#if !SILVERLIGHT
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
using System.Reflection;

namespace Google.Apis.Upload
{
    /// <summary>
    /// Media upload which uses Google's resumable media upload protocol to upload data.
    /// </summary>
    /// <remarks>
    /// See: http://code.google.com/apis/gdata/docs/resumable_upload.html for
    /// information on the protocol.
    /// </remarks>
    /// <typeparam name="TRequest">
    /// The type of the body of this request. Generally this should be the metadata related 
    /// to the content to be uploaded. Must be serializable to/from JSON.
    /// </typeparam>
    public abstract class ResumableUpload<TRequest>
    {
        #region Constants
        /// <summary>
        /// Chunks (except the last chunk) must be a multiple of 256KB to be compatible with
        /// Google upload servers.
        /// </summary>
        private const int MinimumChunkSize = 262144; // 256 KB
        
        /// <summary>
        /// Default chunk size is set to 4 times the <see cref="MinimumChunkSize"/>of 256KB or 1MB 
        /// total.
        /// </summary>
        /// <seealso cref="MinimumChunkSize"/>
        private const int DefaultChunkSize = MinimumChunkSize * 40;
        
        /// <summary>
        /// Buffer size is used to read chunks from the input stream and write to the output stream.
        /// TODO: Improve the read/write scheme to remove the buffer altogether and simply pipe the
        ///       input to the request.
        /// </summary>
        private const int BufferSize = 16384; // 16 KB

        /// <summary>
        /// The mime type for the encoded JSON body.
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
        /// The error key when an error response is received.
        /// </summary>
        private const string ErrorKey = "error";

        /// <summary>
        /// The message portion of the error block if an error response is received.
        /// </summary>
        private const string MessageKey = "message";

        /// <summary>
        /// Specify the type of this upload (this class supports resumable only).
        /// </summary>
        private const string UploadType = "uploadType";

        /// <summary>
        /// The uploadType parameter value for resumable uploads.
        /// </summary>
        private const string Resumable = "resumable";

        /// <summary>
        /// Content-Range header value for the body upload of zero length files.
        /// </summary>
        private const string ZeroByteContentRangeHeader = "bytes */0";

        #endregion // Constants

        #region Construction

        /// <summary>
        /// Create a resumable upload instance with the required parameters.
        /// </summary>
        /// <param name="baseUri">The baseUri of the service.</param>
        /// <param name="path">The path for this media upload method.</param>
        /// <param name="httpMethod">The HTTP method to start this upload.</param>
        /// <param name="contentStream">The stream containing the content to upload.</param>
        /// <param name="contentType">Content type of the content to be uploaded.</param>
        /// <remarks>
        /// The stream <paramref name="contentStream"/> must support the "Length" property.
        /// Caller is responsible for maintaining the <paramref name="contentStream"/> open until the 
        /// upload is completed.
        /// Caller is responsible for closing the <paramref name="contentStream"/>.
        /// </remarks>
        protected ResumableUpload(string baseUri, string path, string httpMethod,
            Stream contentStream, string contentType)
        {
            baseUri.ThrowIfNull("baseUri");
            path.ThrowIfNull("path");
            httpMethod.ThrowIfNullOrEmpty("httpMethod");
            contentStream.ThrowIfNull("stream");
            contentType.ThrowIfNull("contentType");

            this.baseUri = baseUri;
            this.path = path;
            this.httpMethod = httpMethod;

            this.RequestFactory = HttpRequestFactory.Instance;
            this.Authenticator = NullAuthenticator.Instance;
            this.Serializer = Json.NewtonsoftJsonSerializer.Instance;
            this.ChunkSize = DefaultChunkSize;

            this.contentStream = contentStream;
            this.contentType = contentType;
        }

        #endregion // Construction

        #region Fields

        /// <summary>
        /// Base URI of this service.
        /// </summary>
        private string baseUri;

        /// <summary>
        /// Path of the method (combined with <see cref="baseUri"/> to produce the absolute URI.
        /// </summary>
        private string path;

        /// <summary>
        /// HTTP Method of this upload (used to initialize the upload).
        /// </summary>
        private string httpMethod;

        /// <summary>
        /// Stream of data to upload.
        /// </summary>
        private Stream contentStream;

        /// <summary>
        /// Content-Type of data to upload.
        /// </summary>
        private string contentType;

        #endregion

        #region Properties

        /// <summary>
        /// The body of this request.
        /// </summary>
        public TRequest Body { get; set; }

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
        public int ChunkSize { get; set; }

        /// <summary>
        /// Serializer used to serialize <see cref="Body"/> of the request.
        /// </summary>
        public ISerializer Serializer { get; set; }

        #endregion // Properties

        #region Events

        /// <summary>
        /// Event called whenever the progress of the upload changes.
        /// </summary>
        public event Action<IUploadProgress> ProgressChanged;

        #endregion //Events

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

        /// <summary>
        /// Current state of progress of the upload.
        /// </summary>
        /// <seealso cref="ProgressChanged"/>
        private ResumableUploadProgress Progress { get; set; }

        /// <summary>
        /// Update the current progress and call the <see cref="ProgressChanged"/> event to
        /// notify listeners.
        /// </summary>
        private void UpdateProgress(UploadStatus status, long byteCount)
        {
            var p = new ResumableUploadProgress(status, byteCount);
            this.Progress = p;
            if(ProgressChanged != null)
                ProgressChanged(p);
        }

        /// <summary>
        /// Get the current progress state.
        /// </summary>
        /// <returns>An IUploadProgress describing the current progress of the upload.</returns>
        /// <seealso cref="ProgressChanged"/>
        public IUploadProgress GetProgress()
        {
            return this.Progress;
        }

        #endregion

        #region Upload Implementation
        /// <summary>
        /// Upload the content to the server. This method is synchronous
        /// and will block until the upload is completed.
        /// </summary>
        public void Upload()
        {
            long bytesSent = 0;
            try
            {
                UpdateProgress(UploadStatus.Starting, 0);
                Uri url = InitializeUpload(contentStream.Length, contentType);
                UpdateProgress(UploadStatus.Uploading, 0);
                do
                {
                    bytesSent += SendChunk(contentStream, url, bytesSent);
                    UpdateProgress(UploadStatus.Uploading, bytesSent);
                } while (bytesSent < contentStream.Length);
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
                    var y = x[ErrorKey] as Json.JsonDictionary;
                    if (y.ContainsKey(MessageKey))
                    {
                        throw new Exception(y[MessageKey] as string);
                    }
                }
                // Attempt to update the progress to show failure,
                // swallow any exceptions that occured and re-throw the original
                // exception.
                try
                {
                    UpdateProgress(UploadStatus.Failed, bytesSent);
                }
                catch (Exception) { }
                throw;
            }
            catch (Exception)
            {
                // Attempt to update the progress to show failure,
                // swallow any exceptions that occured and re-throw the original
                // exception.
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
        /// <param name="contentLength">Length of the content to be uploaded (in bytes).</param>
        /// <param name="contentType">Content type of the content to be uploaded.</param>
        /// <returns>
        /// The unique upload location for this upload, returned in the Location header
        /// </returns>
        private Uri InitializeUpload(long contentLength, string contentType)
        {
            HttpWebRequest request = CreateInitializeRequest(contentLength, contentType);
            WebResponse response = request.GetResponse();

            string location = response.Headers["Location"];

            return new Uri(location);
        }

        /// <summary>
        /// Process a response from the final upload chunk call.
        /// </summary>
        /// <param name="webResponse">The web response body from the final uploaded chunk.</param>
        protected virtual void ProcessResponse(WebResponse webResponse)
        {
        }

        /// <summary>
        /// Upload a chunk of the data to the server.
        /// </summary>
        /// <param name="stream">The stream of content to be uploaded.</param>
        /// <param name="uri">The upload location (specifically generated for this upload).</param>
        /// <param name="position">The current position in the payload.</param>
        protected virtual long SendChunk(Stream stream, Uri uri, long position)
        {
            long chunkSize = Math.Min(stream.Length - position, ChunkSize);
            byte[] buffer = new byte[Math.Min(chunkSize, BufferSize)];
            var req = this.RequestFactory.Create(uri, Request.PUT);
            req.ContentLength = chunkSize;
            req.Headers.Add(HttpRequestHeader.ContentRange,
                GetContentRangeHeader(position, chunkSize, stream.Length));

            try
            {
                Stream requestStream = req.GetRequestStream();

                int dataWritten = 0;
                while (dataWritten < chunkSize)
                {
                    int len = stream.Read(buffer, 0, buffer.Length);
                    requestStream.Write(buffer, 0, len);
                    dataWritten += len;
                }

                // req.GetResponse() will throw an exception when this request 
                // completes successfully because the server returns an HTTP 308
                // on successful upload of a chunk. On the last chunk, server
                // returns 200 OK or 201 Created
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();

                // Only the final chunk will reach here in the code. That final chunk
                // response body has the content for the status code.
                if (response.StatusCode == HttpStatusCode.OK ||
                    response.StatusCode == HttpStatusCode.Created)
                {
                    ProcessResponse(response);
                }
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
        /// <item>T is the total number of bytes in the range.</item>
        /// or in the case of a full block, of the form: "bytes */T" where:
        /// </list>
        /// </summary>
        /// <remarks>
        /// See: RFC2616 HTTP/1.1, Section 14.16 Header Field Definitions, Content-Range
        /// http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.16
        /// </remarks>
        /// <param name="chunkStart">Start of the chunk.</param>
        /// <param name="chunkSize">Size of the chunk being sent.</param>
        /// <param name="totalSize">Total number of bytes in the entire file.</param>
        /// <returns>The content range header value.</returns>
        private string GetContentRangeHeader(long chunkStart, long chunkSize, long totalSize)
        {
            // If a file of length 0 is sent, one chunk needs to be sent with 0 size.
            // This chunk cannot be specified with the standard (inclusive) range header.
            // In this case, use * to indicate no bytes sent in the Content-Range header.
            if (chunkStart == 0 && chunkSize == 0 && totalSize == 0)
            {
                return ZeroByteContentRangeHeader;
            }
            else
            {
                long chunkEnd = chunkStart + chunkSize - 1;
                return String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd, totalSize);
            }
        }

        /// <summary>
        /// Create a request to initialize a request.
        /// </summary>
        /// <returns>
        /// An HttpWebRequest configured to initialize a request.
        /// </returns>
        /// <param name="contentLength">Length of the content to be uploaded (in bytes).</param>
        /// <param name="contentType">Content type of the content to be uploaded.</param>
        private HttpWebRequest CreateInitializeRequest(long contentLength, string contentType)
        {
            HttpWebRequestBuilder builder = new HttpWebRequestBuilder()
            {
                BaseUri = new Uri(this.baseUri),
                Method = this.httpMethod,
                Path = this.path,
                HttpRequestFactory = this.RequestFactory,
            };

            builder.AddParameter(RequestParameterType.Query, "uploadType", "resumable");
            builder.AddParameter(RequestParameterType.Query, "alt", "json");

            SetAllPropertyValues(builder);

            var request = builder.GetWebRequest();
            request.Headers.Add(PayloadContentTypeHeader, contentType);
            request.Headers.Add(PayloadContentLengthHeader, contentLength.ToString());

            if (this.Authenticator != null)
                Authenticator.ApplyAuthenticationToRequest(request);

            string bodyText = this.Serializer.Serialize(this.Body);
            byte[] body = Encoding.UTF8.GetBytes(bodyText);
            request.ContentType = JsonMimeType;
            request.ContentLength = body.Length;

            var requestBodyStream = request.GetRequestStream();
            requestBodyStream.Write(body, 0, body.Length);
            return request;
        }

        /// <summary>
        /// Reflectively enumerate the properties of this object looking for all properties containing
        /// the RequestParameterAttribute and copy their values into the HttpWebRequestBuilder.
        /// </summary>
        /// <param name="requestBuilder">The builder used to assemble the web request to initialize this upload.</param>
        private void SetAllPropertyValues(HttpWebRequestBuilder requestBuilder)
        {
            Type myType = this.GetType();
            var properties = myType.GetProperties();

            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<Google.Apis.Util.RequestParameterAttribute>();

                if (attribute != null)
                {
                    string name = attribute.Name ?? property.Name.ToLower();
                    object valueObject = property.GetValue(this, new object[] {} );
                    string value = String.Empty;
                    if (valueObject != null)
                    {
                        value = valueObject.ToString();
                    }

                    requestBuilder.AddParameter(attribute.Type, name, value);
                }
            }
        }

        #endregion Upload Implementation
    }

    /// <summary>
    /// Media upload which uses Google's resumable media upload protocol to upload data.
    /// The version with two types contains both a request object and a response object.
    /// </summary>
    /// <remarks>
    /// See: http://code.google.com/apis/gdata/docs/resumable_upload.html for
    /// information on the protocol.
    /// </remarks>
    /// <typeparam name="TRequest">
    /// The type of the body of this request. Generally this should be the metadata related 
    /// to the content to be uploaded. Must be serializable to/from JSON.
    /// </typeparam>
    /// <typeparam name="TResponse">
    /// The type of the response body.
    /// </typeparam>
    public class ResumableUpload<TRequest, TResponse> : ResumableUpload<TRequest>
    {
        #region Construction

        /// <summary>
        /// Create a resumable upload instance with the required parameters.
        /// </summary>
        /// <param name="baseUri">The baseUri of the service.</param>
        /// <param name="path">The path for this media upload method.</param>
        /// <param name="httpMethod">The HTTP method to start this upload.</param>
        /// <param name="contentStream">The stream containing the content to upload.</param>
        /// <param name="contentType">Content type of the content to be uploaded.</param>
        /// <remarks>
        /// The stream <paramref name="contentStream"/> must support the "Length" property.
        /// Caller is responsible for maintaining the <paramref name="contentStream"/> open until the 
        /// upload is completed.
        /// Caller is responsible for closing the <paramref name="contentStream"/>.
        /// </remarks>
        protected ResumableUpload(string baseUri, string path, string httpMethod,
            Stream contentStream, string contentType)
            : base(baseUri, path, httpMethod, contentStream, contentType) { }

        #endregion //Construction

        #region Properties

        /// <summary>
        /// The response body.
        /// </summary>
        /// <remarks>
        /// This property will be set during upload. The <see cref="ResponseReceived"/> event
        /// is triggered when this has been set.
        /// </remarks>
        public TResponse ResponseBody { get; private set; }

        #endregion // Properties

        #region Events

        /// <summary>
        /// Event called when the response metadata is processed.
        /// </summary>
        public event Action<TResponse> ResponseReceived;

        #endregion // Events

        #region Overrides

        /// <summary>
        /// Process the response body and generate a 
        /// </summary>
        /// <param name="webResponse"></param>
        protected override void ProcessResponse(WebResponse webResponse)
        {
            base.ProcessResponse(webResponse);

            Stream responseStream = webResponse.GetResponseStream();

            ResponseBody = this.Serializer.Deserialize<TResponse>(responseStream);

            if(ResponseReceived != null)
                ResponseReceived(ResponseBody);
        }

        #endregion // Overrides
    }
}
#endif // !SILVERLIGHT