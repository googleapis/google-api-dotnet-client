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
using System.IO;
using System.Net;
using System.Text;

using Google.Apis.Authentication;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Upload
{
    /// <summary>
    /// Media upload which uses Google's resumable media upload protocol to upload data.
    /// </summary>
    /// <remarks>
    /// See: https://developers.google.com/drive/manage-uploads#resumable for more information on the protocol.
    /// </remarks>
    /// <typeparam name="TRequest">
    /// The type of the body of this request. Generally this should be the metadata related to the content to be 
    /// uploaded. Must be serializable to/from JSON.
    /// </typeparam>
    public class ResumableUpload<TRequest>
    {
        #region Constants

        /// <summary> The class logger. </summary>
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ResumableUpload<TRequest>>();

        private const int KB = 0x400;
        private const int MB = 0x100000;

        /// <summary> Minimum chunk size (except the last one). Default value is 256*KB. </summary>
        public const int MinimumChunkSize = 256 * KB;

        /// <summary> Default chunk size. Default value is 10*MB. </summary>
        public const int DefaultChunkSize = 10 * MB;

        /// <summary>
        /// Defines how many bytes are read from the input stream in each stream read action. 
        /// The read will continue until we read <see cref="MinimumChunkSize"/> or we reached the end of the stream.
        /// </summary>
        internal int BufferSize = 4 * KB;

        /// <summary> Indicates the stream's size is unknown. </summary>
        private const int UnknownSize = -1;

        /// <summary> The mime type for the encoded JSON body. </summary>
        private const string JsonMimeType = "application/json; charset=UTF-8";

        /// <summary> Payload description headers, describing the content itself. </summary>
        private const string PayloadContentTypeHeader = "X-Upload-Content-Type";

        /// <summary> Payload description headers, describing the content itself. </summary>
        private const string PayloadContentLengthHeader = "X-Upload-Content-Length";

        /// <summary> The error key when an error response is received. </summary>
        private const string ErrorKey = "error";

        /// <summary> The message portion of the error block if an error response is received. </summary>
        private const string MessageKey = "message";

        /// <summary> Specify the type of this upload (this class supports resumable only). </summary>
        private const string UploadType = "uploadType";

        /// <summary> The uploadType parameter value for resumable uploads. </summary>
        private const string Resumable = "resumable";

        /// <summary> Content-Range header value for the body upload of zero length files. </summary>
        private const string ZeroByteContentRangeHeader = "bytes */0";

        /// <summary> The default amount of retries when receiving a server error. </summary>
        private const int DefaultMaxRetries = 10;

        /// <summary> The max amount of retries allowed when receiving a server error. </summary>
        private const int MaxAllowableRetries = 10;

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
        /// Caller is responsible for maintaining the <paramref name="contentStream"/> open until the upload is 
        /// completed.
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

            this.BaseUri = baseUri;
            this.Path = path;
            this.HttpMethod = httpMethod;
            this.ContentStream = contentStream;
            this.ContentType = contentType;

            RequestFactory = HttpRequestFactory.Instance;
            Authenticator = NullAuthenticator.Instance;
            Serializer = Json.NewtonsoftJsonSerializer.Instance;
            ChunkSize = DefaultChunkSize;
        }

        #endregion // Construction

        #region Properties

        /// <summary> The base URI of this service. </summary>
        public string BaseUri { get; private set; }

        /// <summary> The path of the method (combined with <see cref="BaseUri"/>) to produce absolute URI. </summary>
        public string Path { get; private set; }

        /// <summary> The HTTP Method of this upload (used to initialize the upload). </summary>
        public string HttpMethod { get; private set; }

        /// <summary> The stream to upload. </summary>
        public Stream ContentStream { get; private set; }

        /// <summary> The stream's Content-Type. </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// The length of the steam. Will be <c>UnknownSize</c> if the media content length is unknown. 
        /// </summary>
        private long StreamLength { get; set; }

        /// <summary>
        /// The content of the last buffer request or <c>null</c> for none. It is used when the media content length is 
        /// unknown, for resending it in case of server error.
        /// </summary>
        private byte[] LastMediaRequest { get; set; }

        /// <summary> Cached byte indicates if end of stream has been reached. </summary>
        private byte[] CachedByte { get; set; }

        /// <summary>
        /// The last request start index or <c>0</c> for none. It is used when the media content length is unknown.
        /// </summary>
        private long LastMediaStartIndex { get; set; }

        /// <summary> The last request length. </summary>
        private int LastMediaLength { get; set; }

        /// <summary> 
        /// The resumable session URI. 
        /// See https://developers.google.com/drive/manage-uploads#save-session-uri" for more details.
        /// </summary>
        private Uri UploadURI { get; set; }

        /// <summary> The amount of bytes sent so far. </summary>
        private long BytesSent { get; set; }

        /// <summary> Defines the number of retries left for current request. </summary>
        private int RemainingRetries { get; set; }

        /// <summary> The body of this request. </summary>
        public TRequest Body { get; set; }

        /// <summary> Authenticator which modifies requests for authentication. </summary>
        public IAuthenticator Authenticator { get; set; }

        /// <summary> ICreateHttpRequest instance used to create HTTP requests. </summary>
        public ICreateHttpRequest RequestFactory { get; set; }

        /// <summary> 
        /// The size of each chunk sent to the server.
        /// Chunks (except the last chunk) must be a multiple of <see cref="MinimumChunkSize"/> to be compatible with 
        /// Google upload servers.
        /// </summary>
        public int ChunkSize { get; set; }

        private int maxRetries = DefaultMaxRetries;

        /// <summary> Maximum retries when getting a server error. </summary>
        public int MaxRetries
        {
            get { return maxRetries; }
            set
            {
                if (value > MaxAllowableRetries || value < 0)
                {
                    throw new ArgumentOutOfRangeException("MaxRetries");
                }
                maxRetries = value;
            }
        }

        /// <summary> Serializer used to serialize <see cref="Body"/> of the request. </summary>
        public ISerializer Serializer { get; set; }

        #endregion // Properties

        #region Events

        /// <summary> Event called whenever the progress of the upload changes. </summary>
        public event Action<IUploadProgress> ProgressChanged;

        #endregion //Events

        #region Progress Monitoring

        /// <summary> Class that communicates the progress of resumable uploads to a container. </summary>
        private class ResumableUploadProgress : IUploadProgress
        {
            /// <summary>
            /// Create a ResumableUploadProgress instance.
            /// </summary>
            /// <param name="status">The status of the upload.</param>
            /// <param name="bytesSent">The number of bytes sent so far.</param>
            public ResumableUploadProgress(UploadStatus status, long bytesSent)
            {
                Status = status;
                BytesSent = bytesSent;
            }

            /// <summary>
            /// Create a ResumableUploadProgress instance.
            /// </summary>
            /// <param name="exception">An exception that occurred during the upload.</param>
            /// <param name="bytesSent">The number of bytes sent before this exception occurred.</param>
            public ResumableUploadProgress(Exception exception, long bytesSent)
            {
                Status = UploadStatus.Failed;
                BytesSent = bytesSent;
                Exception = exception;
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
        /// Updates the current progress and call the <see cref="ProgressChanged"/> event to notify listeners.
        /// </summary>
        private void UpdateProgress(ResumableUploadProgress progress)
        {
            Progress = progress;
            if (ProgressChanged != null)
                ProgressChanged(progress);
        }

        /// <summary>
        /// Get the current progress state.
        /// </summary>
        /// <returns>An IUploadProgress describing the current progress of the upload.</returns>
        /// <seealso cref="ProgressChanged"/>
        public IUploadProgress GetProgress()
        {
            return Progress;
        }

        #endregion

        #region Upload Implementation

        /// <summary>
        /// Upload the content to the server. This method is synchronous and will block until the upload is completed.
        /// </summary>
        public IUploadProgress Upload()
        {
            try
            {
                BytesSent = 0;
                UpdateProgress(new ResumableUploadProgress(UploadStatus.Starting, 0));
                // check if the stream length is known
                StreamLength = ContentStream.CanSeek ? ContentStream.Length : UnknownSize;
                UploadURI = InitializeUpload();
                logger.Debug("Start uploading media to \"{0}\"", UploadURI);
                while (!SendNextChunk(ContentStream))
                {
                    UpdateProgress(new ResumableUploadProgress(UploadStatus.Uploading, BytesSent));
                }
                UpdateProgress(new ResumableUploadProgress(UploadStatus.Completed, BytesSent));
            }
            catch (WebException we)
            {
                Exception e = GetErrorMessageIfPresent(we);
                UpdateProgress(new ResumableUploadProgress(e ?? we, BytesSent));
            }

            return Progress;
        }

        /// <summary>
        /// If the given WebException contains a Json response with an error message node return an exception that 
        /// wraps that text. Otherwise return <c>null</c>.
        /// </summary>
        private Exception GetErrorMessageIfPresent(WebException webException)
        {
            if (webException.Response == null)
            {
                return null;
            }

            var responseStream = webException.Response.GetResponseStream();
            if (responseStream == null)
            {
                return null;
            }

            string response = null;
            using (StreamReader reader = new StreamReader(responseStream))
            {
                response = reader.ReadToEnd();
            }
            if (response.IsNullOrEmpty())
            {
                return null;
            }

            Json.JsonDictionary responseDictionary = null;
            try
            {
                responseDictionary = Json.JsonReader.Parse(response) as Json.JsonDictionary;
            }
            // If the response is not Json parsable just carry on to rethrow original exception.
            catch (ArgumentException) { }

            if (responseDictionary == null || !responseDictionary.ContainsKey(ErrorKey))
            {
                return null;
            }

            var error = responseDictionary[ErrorKey] as Json.JsonDictionary;
            if (error != null && error.ContainsKey(MessageKey) && error[MessageKey] is string)
            {
                return new Exception(error[MessageKey] as string, webException);
            }

            return null;
        }

        /// <summary>
        /// Initializes the resumable upload by calling the resumable rest interface to get a unique upload location.
        /// See https://developers.google.com/drive/manage-uploads#start-resumable for more details.
        /// </summary>
        /// <returns>
        /// The unique upload location for this upload, returned in the Location header
        /// </returns>
        private Uri InitializeUpload()
        {
            HttpWebRequest request = CreateInitializeRequest();
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
        /// Uploads the next chunk of data to the server.
        /// </summary>
        /// <returns> 
        /// <c>True</c> if the entire media has been completely uploaded.
        /// </returns>
        protected virtual bool SendNextChunk(Stream stream)
        {
            var req = RequestFactory.Create(UploadURI, Request.PUT);

            // init remaining retries counter
            RemainingRetries = MaxRetries;

            // apply authorization to the request
            if (Authenticator != null)
            {
                Authenticator.ApplyAuthenticationToRequest(req);
            }

            try
            {
                // prepare next chunk to send
                if (StreamLength != UnknownSize)
                {
                    PrepareNextChunkKnownSize(req, stream);
                }
                else
                {
                    PrepareNextChunkUnknownSize(req, stream);
                }

                // req.GetResponse() will throw an exception when this request doesn't complete successfully because 
                // the server returns an HTTP 308, on successful upload of a chunk. 
                // On the last chunk, server returns 200 OK or 201 Created
                HttpWebResponse response = (HttpWebResponse)req.GetResponse();

                // Only the final chunk will reach here in the code. That final chunk
                // response body has the content for the status code.
                if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                {
                    MediaCompleted(response);
                    return true;
                }
            }
            catch (WebException we)
            {
                var response = we.Response as HttpWebResponse;
                if (response == null || (int)response.StatusCode / 100 == 5)
                {
                    // server error - try to resume the interrupted upload 
                    // https://developers.google.com/drive/manage-uploads#resume-upload

                    // TODO(peleyal): should be moved to UnsuccessfulResponseHandler when implementing TransportLayer.
                    return OnServerError();
                }
                else if (response.StatusCode == (HttpStatusCode)308)
                {
                    // catch and release on HTTP response code 308. The upload protocol uses 308 to indicate that there 
                    // is more data expected from the server.
                    BytesSent = GetNextByte(response.Headers["Range"]);
                    logger.Debug("{0} Bytes were sent successfully", BytesSent);
                }
                else
                {
                    throw;
                }
            }
            catch (IOException)
            {
                return OnServerError();
            }

            return false;
        }

        /// <summary> A callback when the media was uploaded successfully. </summary>
        private void MediaCompleted(HttpWebResponse response)
        {
            logger.Debug("media was uploaded successfully");
            ProcessResponse(response);
            BytesSent += LastMediaLength;

            // clear the last request byte array
            LastMediaRequest = null;
        }

        /// <summary> Prepares the given request with the next chunk in case the steam length is unknown. </summary>
        private void PrepareNextChunkUnknownSize(HttpWebRequest req, Stream stream)
        {
            // We save the current request, so we would be able to resend those bytes in case of a server error
            if (LastMediaRequest == null)
            {
                LastMediaRequest = new byte[ChunkSize];
            }

            // if the number of bytes received by the sever isn't equal to the sum of saved start index plus 
            // length, it means that we need to resend bytes from the last request
            if (BytesSent != LastMediaStartIndex + LastMediaLength)
            {
                int delta = (int)(BytesSent - LastMediaStartIndex);
                Buffer.BlockCopy(LastMediaRequest, delta, LastMediaRequest, 0, ChunkSize - delta);
                LastMediaLength = ChunkSize - delta;
            }
            else
            {
                LastMediaStartIndex = BytesSent;
                LastMediaLength = 0;
            }

            bool shouldRead = true;
            if (CachedByte == null)
            {
                // create a new cached byte which will be used to verify if we reached the end of stream
                CachedByte = new byte[1];
            }
            else if (LastMediaLength != ChunkSize)
            {
                // read the last cached byte, and add it to the current request
                LastMediaRequest[LastMediaLength] = CachedByte[0];
                LastMediaLength++;
            }
            else
            {
                // the whole bytes from last request should be resent, no need to read data from stream in this request
                // and no need to update the cached byte
                shouldRead = false;
            }

            if (shouldRead)
            {
                int len = 0;
                // read bytes form the stream to lastMediaRequest byte array
                while (true)
                {
                    len = stream.Read(LastMediaRequest, LastMediaLength,
                        (int)Math.Min(BufferSize, ChunkSize - LastMediaLength));
                    LastMediaLength += len;
                    if (len == 0) break;
                }

                // check if there is still data to read from stream, and cache the first byte in catchedByte
                if (0 == stream.Read(CachedByte, 0, 1))
                {
                    // EOF - now we know the stream's length
                    StreamLength = LastMediaLength + BytesSent;
                    CachedByte = null;
                }
            }

            // set Content-Length and Content-Range
            req.Headers.Add(HttpRequestHeader.ContentRange, GetContentRangeHeader(BytesSent,
                LastMediaLength));
            req.ContentLength = LastMediaLength;
            using (Stream requestStream = req.GetRequestStream())
            {
                requestStream.Write(LastMediaRequest, 0, LastMediaLength);
            }
        }

        /// <summary> Prepares the given request with the next chunk in case the steam length is known. </summary>
        private void PrepareNextChunkKnownSize(HttpWebRequest req, Stream stream)
        {
            int chunkSize = (int)Math.Min(StreamLength - BytesSent, (long)ChunkSize);

            // stream length is known and it supports seek and position operations.
            // We can change the stream position and read bytes from the last point
            req.Headers.Add(HttpRequestHeader.ContentRange, GetContentRangeHeader(BytesSent, chunkSize));
            req.ContentLength = chunkSize;
            using (Stream requestStream = req.GetRequestStream())
            {
                byte[] buffer = new byte[Math.Min(chunkSize, BufferSize)];
                stream.Position = BytesSent;

                int bytesRead = 0;
                while (true)
                {
                    // read from input stream and write to output stream
                    // TODO(peleyal): when upgrading to .NET 4 use Stream.CopyTo method
                    int len = stream.Read(buffer, 0, (int)Math.Min(buffer.Length, chunkSize - bytesRead));
                    if (len == 0) break;
                    requestStream.Write(buffer, 0, len);
                    bytesRead += len;
                }
            }

            LastMediaLength = chunkSize;
        }

        /// <summary>
        /// Call back method that will be invoked on a server error (5xx) or an I/O exception.
        /// This method will query the current status of the upload to find how many bytes were successfully uploaded
        /// before the error occurred.
        /// See https://developers.google.com/drive/manage-uploads#resume-upload for more details.
        /// </summary>
        /// <returns>
        /// <c>True</c> if the media was uploaded successfully.
        /// </returns>
        private bool OnServerError()
        {
            Exception lastException = null;
            while (RemainingRetries > 0)
            {
                // TODO(peleyal): back-off policy (after adding transport layer)
                logger.Debug("Server error occurred while uploading media");

                RemainingRetries--;

                var req = RequestFactory.Create(UploadURI, Request.PUT);

                // apply authorization to the request
                if (Authenticator != null)
                {
                    Authenticator.ApplyAuthenticationToRequest(req);
                }

                // set Content-Range and Content-Length headers
                var range = String.Format("bytes */{0}", StreamLength < 0 ? "*" : StreamLength.ToString());
                req.Headers.Add(HttpRequestHeader.ContentRange, range);
                req.ContentLength = 0;
                try
                {
                    HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                    if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
                    {
                        MediaCompleted(response);
                        return true;
                    }
                }
                catch (WebException we)
                {
                    lastException = we;
                    var response = we.Response as HttpWebResponse;
                    if (response != null && response.StatusCode == (HttpStatusCode)308)
                    {
                        BytesSent = GetNextByte(response.Headers["Range"]);
                        return false;
                    }
                    else if (response != null && (int)response.StatusCode / 100 != 5)
                    {
                        throw;
                    }
                }
                catch (IOException ioe)
                {
                    lastException = ioe;
                }
            }

            if (lastException != null)
            {
                throw lastException;
            }
            return false;
        }

        /// <summary> Returns the next byte index need to be sent. </summary>
        private long GetNextByte(string range)
        {
            return long.Parse(range.Substring(range.IndexOf('-') + 1)) + 1;
        }

        /// <summary>
        /// Build a content range header of the form: "bytes X-Y/T" where:
        /// <list type="">
        /// <item>X is the first byte being sent.</item>
        /// <item>Y is the last byte in the range being sent (inclusive).</item>
        /// <item>T is the total number of bytes in the range or * for unknown size.</item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// See: RFC2616 HTTP/1.1, Section 14.16 Header Field Definitions, Content-Range
        /// http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.16
        /// </remarks>
        /// <param name="chunkStart">Start of the chunk.</param>
        /// <param name="chunkSize">Size of the chunk being sent.</param>
        /// <returns>The content range header value.</returns>
        private string GetContentRangeHeader(long chunkStart, long chunkSize)
        {
            string strLength = StreamLength < 0 ? "*" : StreamLength.ToString();

            // If a file of length 0 is sent, one chunk needs to be sent with 0 size.
            // This chunk cannot be specified with the standard (inclusive) range header.
            // In this case, use * to indicate no bytes sent in the Content-Range header.
            if (chunkStart == 0 && chunkSize == 0 && StreamLength == 0)
            {
                return ZeroByteContentRangeHeader;
            }
            else
            {
                long chunkEnd = chunkStart + chunkSize - 1;
                return String.Format("bytes {0}-{1}/{2}", chunkStart, chunkEnd, strLength);
            }
        }

        /// <summary>
        /// Creates a request to initialize a request.
        /// </summary>
        /// <returns>
        /// An HttpWebRequest configured to initialize a request.
        /// </returns>
        private HttpWebRequest CreateInitializeRequest()
        {
            HttpWebRequestBuilder builder = new HttpWebRequestBuilder()
            {
                BaseUri = new Uri(BaseUri),
                Method = HttpMethod,
                Path = Path,
                HttpRequestFactory = RequestFactory,
            };

            builder.AddParameter(RequestParameterType.Query, "uploadType", "resumable");
            SetAllPropertyValues(builder);

            var request = builder.GetWebRequest();
            request.Headers.Add(PayloadContentTypeHeader, ContentType);

            // if the length is unknown at the time of this request, omit "X-Upload-Content-Length" header
            if (StreamLength != UnknownSize)
            {
                request.Headers.Add(PayloadContentLengthHeader, StreamLength.ToString());
            }

            if (Authenticator != null)
            {
                Authenticator.ApplyAuthenticationToRequest(request);
            }

            string bodyText = Serializer.Serialize(Body);
            byte[] body = Encoding.UTF8.GetBytes(bodyText);
            request.ContentType = JsonMimeType;
            request.ContentLength = body.Length;

            using (var requestBodyStream = request.GetRequestStream())
            {
                requestBodyStream.Write(body, 0, body.Length);
            }
            return request;
        }

        /// <summary>
        /// Reflectively enumerate the properties of this object looking for all properties containing the 
        /// RequestParameterAttribute and copy their values into the HttpWebRequestBuilder.
        /// </summary>
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
                    object value = property.GetValue(this, new object[] { });
                    if (value != null)
                    {
                        requestBuilder.AddParameter(attribute.Type, name, value.ToString());
                    }
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

        #endregion // Construction

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

        /// <summary> Event which is called when the response metadata is processed. </summary>
        public event Action<TResponse> ResponseReceived;

        #endregion // Events

        #region Overrides

        /// <summary> Process the response body </summary>
        protected override void ProcessResponse(WebResponse webResponse)
        {
            base.ProcessResponse(webResponse);

            Stream responseStream = webResponse.GetResponseStream();
            ResponseBody = Serializer.Deserialize<TResponse>(responseStream);

            if (ResponseReceived != null)
                ResponseReceived(ResponseBody);
        }

        #endregion // Overrides
    }
}
#endif // !SILVERLIGHT