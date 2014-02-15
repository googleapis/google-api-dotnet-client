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
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Testing;
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

        /// <summary>The class logger.</summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ResumableUpload<TRequest>>();

        private const int KB = 0x400;
        private const int MB = 0x100000;

        /// <summary>Minimum chunk size (except the last one). Default value is 256*KB.</summary>
        public const int MinimumChunkSize = 256 * KB;

        /// <summary>Default chunk size. Default value is 10*MB.</summary>
        public const int DefaultChunkSize = 10 * MB;

        /// <summary>
        /// Defines how many bytes are read from the input stream in each stream read action. 
        /// The read will continue until we read <see cref="MinimumChunkSize"/> or we reached the end of the stream.
        /// </summary>
        internal int BufferSize = 4 * KB;

        /// <summary>Indicates the stream's size is unknown.</summary>
        private const int UnknownSize = -1;

        /// <summary>The mime type for the encoded JSON body.</summary>
        private const string JsonMimeType = "application/json; charset=UTF-8";

        /// <summary>Payload description headers, describing the content itself.</summary>
        private const string PayloadContentTypeHeader = "X-Upload-Content-Type";

        /// <summary>Payload description headers, describing the content itself.</summary>
        private const string PayloadContentLengthHeader = "X-Upload-Content-Length";

        /// <summary>Specify the type of this upload (this class supports resumable only).</summary>
        private const string UploadType = "uploadType";

        /// <summary>The uploadType parameter value for resumable uploads.</summary>
        private const string Resumable = "resumable";

        /// <summary>Content-Range header value for the body upload of zero length files.</summary>
        private const string ZeroByteContentRangeHeader = "bytes */0";

        #endregion // Constants

        #region Construction

        /// <summary>
        /// Create a resumable upload instance with the required parameters.
        /// </summary>
        /// <param name="service">The client service.</param>
        /// <param name="path">The path for this media upload method.</param>
        /// <param name="httpMethod">The HTTP method to start this upload.</param>
        /// <param name="contentStream">The stream containing the content to upload.</param>
        /// <param name="contentType">Content type of the content to be uploaded.</param>
        /// <remarks>
        /// Caller is responsible for maintaining the <paramref name="contentStream"/> open until the upload is 
        /// completed.
        /// Caller is responsible for closing the <paramref name="contentStream"/>.
        /// </remarks>
        protected ResumableUpload(IClientService service, string path, string httpMethod, Stream contentStream,
            string contentType)
        {
            service.ThrowIfNull("service");
            path.ThrowIfNull("path");
            httpMethod.ThrowIfNullOrEmpty("httpMethod");
            contentStream.ThrowIfNull("stream");
            contentType.ThrowIfNull("contentType");

            this.Service = service;
            this.Path = path;
            this.HttpMethod = httpMethod;
            this.ContentStream = contentStream;
            this.ContentType = contentType;
        }

        #endregion // Construction

        #region Properties

        /// <summary>Gets or sets the service.</summary>
        public IClientService Service { get; private set; }

        /// <summary>
        /// Gets or sets the path of the method (combined with
        /// <see cref="Google.Apis.Services.IClientService.BaseUri"/>) to produce 
        /// absolute Uri. 
        /// </summary>
        public string Path { get; private set; }

        /// <summary>Gets or sets the HTTP method of this upload (used to initialize the upload).</summary>
        public string HttpMethod { get; private set; }

        /// <summary>Gets or sets the stream to upload.</summary>
        public Stream ContentStream { get; private set; }

        /// <summary>Gets or sets the stream's Content-Type.</summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// Gets or sets the length of the steam. Will be <see cref="UnknownSize" /> if the media content length is 
        /// unknown. 
        /// </summary>
        private long StreamLength { get; set; }

        /// <summary>
        /// Gets or sets the content of the last buffer request to the server or <c>null</c>. It is used when the media
        /// content length is unknown, for resending it in case of server error.
        /// </summary>
        private byte[] LastMediaRequest { get; set; }

        /// <summary>Gets or sets cached byte which indicates whether the end of stream has been reached.</summary>
        private byte[] CachedByte { get; set; }

        /// <summary>Gets or sets the last request length.</summary>
        private int LastMediaLength { get; set; }

        /// <summary>
        /// Gets or sets the resumable session Uri. 
        /// See https://developers.google.com/drive/manage-uploads#save-session-uri" for more details.
        /// </summary>
        private Uri UploadUri { get; set; }

        /// <summary>Gets or sets the amount of bytes the server had received so far.</summary>
        private long BytesServerReceived { get; set; }

        /// <summary>Gets or sets the amount of bytes the client had sent so far.</summary>
        private long BytesClientSent { get; set; }

        /// <summary>Gets or sets the body of this request.</summary>
        public TRequest Body { get; set; }

        [VisibleForTestOnly]
        internal int chunkSize = DefaultChunkSize;

        /// <summary>
        /// Gets or sets the size of each chunk sent to the server.
        /// Chunks (except the last chunk) must be a multiple of <see cref="MinimumChunkSize"/> to be compatible with 
        /// Google upload servers.
        /// </summary>
        public int ChunkSize
        {
            get { return chunkSize; }
            set
            {
                if (value < MinimumChunkSize)
                {
                    throw new ArgumentOutOfRangeException("ChunkSize");
                }
                chunkSize = value;
            }
        }

        #endregion // Properties

        #region Events

        /// <summary>Event called whenever the progress of the upload changes.</summary>
        public event Action<IUploadProgress> ProgressChanged;

        #endregion //Events

        #region Error handling (Exception and 5xx)

        /// <summary>
        /// Callback class that is invoked on abnormal response or an exception.
        /// This class changes the request to query the current status of the upload in order to find how many bytes  
        /// were successfully uploaded before the error occurred.
        /// See https://developers.google.com/drive/manage-uploads#resume-upload for more details.
        /// </summary>
        class ServerErrorCallback : IHttpUnsuccessfulResponseHandler, IHttpExceptionHandler, IDisposable
        {
            private ResumableUpload<TRequest> Owner { get; set; }

            /// <summary>
            /// Constructs a new callback and register it as unsuccessful response handler and exception handler on the 
            /// configurable message handler.
            /// </summary>
            public ServerErrorCallback(ResumableUpload<TRequest> resumable)
            {
                this.Owner = resumable;
                Owner.Service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Add(this);
                Owner.Service.HttpClient.MessageHandler.ExceptionHandlers.Add(this);
            }

            public Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
            {
                var result = false;
                var statusCode = (int)args.Response.StatusCode;
                // Handle the error if and only if all the following conditions occur:
                // - there is going to be an actual retry
                // - the message request is for media upload with the current Uri (remember that the message handler
                //   can be invoked from other threads \ messages, so we should call server error callback only if the
                //   request is in the current context).
                // - we got a 5xx server error.
                if (args.SupportsRetry && args.Request.RequestUri.Equals(Owner.UploadUri) && statusCode / 100 == 5)
                {
                    result = OnServerError(args.Request);
                }

                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                tcs.SetResult(result);
                return tcs.Task;
            }

            public Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
            {
                var result = args.SupportsRetry && !args.CancellationToken.IsCancellationRequested &&
                    args.Request.RequestUri.Equals(Owner.UploadUri) ? OnServerError(args.Request) : false;

                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                tcs.SetResult(result);
                return tcs.Task;
            }

            /// <summary>Changes the request in order to resume the interrupted upload.</summary>
            private bool OnServerError(HttpRequestMessage request)
            {
                // Clear all headers and set Content-Range and Content-Length headers.
                var range = String.Format("bytes */{0}", Owner.StreamLength < 0 ? "*" : Owner.StreamLength.ToString());
                request.Headers.Clear();
                request.Method = System.Net.Http.HttpMethod.Put;
                request.SetEmptyContent().Headers.Add("Content-Range", range);
                return true;
            }

            public void Dispose()
            {
                Owner.Service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Remove(this);
                Owner.Service.HttpClient.MessageHandler.ExceptionHandlers.Remove(this);
            }
        }

        #endregion

        #region Progress Monitoring

        /// <summary>Class that communicates the progress of resumable uploads to a container.</summary>
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
        /// Uploads the content to the server. This method is synchronous and will block until the upload is completed.
        /// </summary>
        /// <remarks>
        /// In case the upload fails the <see cref="IUploadProgress.Exception"/> will contain the exception that
        /// cause the failure.
        /// </remarks>
        public IUploadProgress Upload()
        {
            return UploadAsync(CancellationToken.None).Result;
        }

        /// <summary>Uploads the content asynchronously to the server.</summary>
        public Task<IUploadProgress> UploadAsync()
        {
            return UploadAsync(CancellationToken.None);
        }

        /// <summary>Uploads the content to the server using the given cancellation token.</summary>
        /// <remarks>
        /// In case the upload fails <see cref="IUploadProgress.Exception"/> will contain the exception that
        /// cause the failure. The only exception which will be thrown is 
        /// <see cref="System.Threading.Tasks.TaskCanceledException"/> which indicates that the task was canceled.
        /// </remarks>
        /// <param name="cancellationToken">A cancellation token to cancel operation.</param>
        public async Task<IUploadProgress> UploadAsync(CancellationToken cancellationToken)
        {
            BytesServerReceived = 0;
            UpdateProgress(new ResumableUploadProgress(UploadStatus.Starting, 0));
            // Check if the stream length is known.
            StreamLength = ContentStream.CanSeek ? ContentStream.Length : UnknownSize;

            try
            {
                UploadUri = await InitializeUpload(cancellationToken).ConfigureAwait(false);
                Logger.Debug("MediaUpload[{0}] - Start uploading...", UploadUri);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "MediaUpload - Exception occurred while initializing the upload");
                UpdateProgress(new ResumableUploadProgress(ex, BytesServerReceived));
            }

            return await UploadCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Resumes the upload form the last point it was interrupted.</summary>
        public IUploadProgress Resume()
        {
            return ResumeAsync(CancellationToken.None).Result;
        }

        /// <summary>Asynchronously resumes the upload form the last point it was interrupted.</summary>
        public Task<IUploadProgress> ResumeAsync()
        {
            return ResumeAsync(CancellationToken.None);
        }

        /// <summary>Asynchronously resumes the upload form the last point it was interrupted.</summary>
        /// <param name="cancellationToken">A cancellation token to cancel operation.</param>
        public async Task<IUploadProgress> ResumeAsync(CancellationToken cancellationToken)
        {
            if (UploadUri == null)
            {
                Logger.Info("There isn't any upload in progress, so starting to upload again");
                return await UploadAsync(cancellationToken).ConfigureAwait(false);
            }
            // The first "resuming" request is to query the server in which point the upload was interrupted.
            var range = String.Format("bytes */{0}", StreamLength < 0 ? "*" : StreamLength.ToString());
            HttpRequestMessage request = new RequestBuilder()
            {
                BaseUri = UploadUri,
                Method = HttpConsts.Put
            }.CreateRequest();
            request.SetEmptyContent().Headers.Add("Content-Range", range);

            try
            {
                HttpResponseMessage response;
                using (var callback = new ServerErrorCallback(this))
                {
                    response = await Service.HttpClient.SendAsync(request, cancellationToken)
                      .ConfigureAwait(false);
                }

                if (await HandleResponse(response).ConfigureAwait(false))
                {
                    // All the media was successfully upload.
                    UpdateProgress(new ResumableUploadProgress(UploadStatus.Completed, BytesServerReceived));
                    return Progress;
                }
            }
            catch (TaskCanceledException ex)
            {
                Logger.Error(ex, "MediaUpload[{0}] - Task was canceled", UploadUri);
                UpdateProgress(new ResumableUploadProgress(ex, BytesServerReceived));
                throw ex;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "MediaUpload[{0}] - Exception occurred while resuming uploading media", UploadUri);
                UpdateProgress(new ResumableUploadProgress(ex, BytesServerReceived));
                return Progress;
            }

            // Continue to upload the media stream.
            return await UploadCoreAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>The core logic for uploading a stream. It is used by the upload and resume methods.</summary>
        private async Task<IUploadProgress> UploadCoreAsync(CancellationToken cancellationToken)
        {
            try
            {
                using (var callback = new ServerErrorCallback(this))
                {
                    while (!await SendNextChunkAsync(ContentStream, cancellationToken).ConfigureAwait(false))
                    {
                        UpdateProgress(new ResumableUploadProgress(UploadStatus.Uploading, BytesServerReceived));
                    }
                    UpdateProgress(new ResumableUploadProgress(UploadStatus.Completed, BytesServerReceived));
                }
            }
            catch (TaskCanceledException ex)
            {
                Logger.Error(ex, "MediaUpload[{0}] - Task was canceled", UploadUri);
                UpdateProgress(new ResumableUploadProgress(ex, BytesServerReceived));
                throw ex;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "MediaUpload[{0}] - Exception occurred while uploading media", UploadUri);
                UpdateProgress(new ResumableUploadProgress(ex, BytesServerReceived));
            }

            return Progress;
        }

        /// <summary>
        /// Initializes the resumable upload by calling the resumable rest interface to get a unique upload location.
        /// See https://developers.google.com/drive/manage-uploads#start-resumable for more details.
        /// </summary>
        /// <returns>
        /// The unique upload location for this upload, returned in the Location header
        /// </returns>
        private async Task<Uri> InitializeUpload(CancellationToken cancellationToken)
        {
            HttpRequestMessage request = CreateInitializeRequest();
            var response = await Service.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            return response.EnsureSuccessStatusCode().Headers.Location;
        }

        /// <summary>
        /// Process a response from the final upload chunk call.
        /// </summary>
        /// <param name="httpResponse">The response body from the final uploaded chunk.</param>
        protected virtual void ProcessResponse(HttpResponseMessage httpResponse)
        {
        }

        /// <summary>Uploads the next chunk of data to the server.</summary>
        /// <returns><c>True</c> if the entire media has been completely uploaded.</returns>
        protected async Task<bool> SendNextChunkAsync(Stream stream, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            HttpRequestMessage request = new RequestBuilder()
                {
                    BaseUri = UploadUri,
                    Method = HttpConsts.Put
                }.CreateRequest();

            // Prepare next chunk to send.
            if (StreamLength != UnknownSize)
            {
                PrepareNextChunkKnownSize(request, stream, cancellationToken);
            }
            else
            {
                PrepareNextChunkUnknownSize(request, stream, cancellationToken);
            }
            BytesClientSent = BytesServerReceived + LastMediaLength;

            Logger.Debug("MediaUpload[{0}] - Sending bytes={1}-{2}", UploadUri, BytesServerReceived,
                BytesClientSent - 1);

            HttpResponseMessage response = await Service.HttpClient.SendAsync(request, cancellationToken)
                .ConfigureAwait(false);
            return await HandleResponse(response).ConfigureAwait(false);
        }

        /// <summary>Handles a media upload HTTP response.</summary>
        /// <returns><c>True</c> if the entire media has been completely uploaded.</returns>
        private async Task<bool> HandleResponse(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                MediaCompleted(response);
                return true;
            }
            else if (response.StatusCode == (HttpStatusCode)308)
            {
                // The upload protocol uses 308 to indicate that there is more data expected from the server.
                BytesServerReceived = GetNextByte(response.Headers.GetValues("Range").First());
                Logger.Debug("MediaUpload[{0}] - {1} Bytes were sent successfully", UploadUri, BytesServerReceived);
                return false;
            }

            var error = await Service.DeserializeError(response).ConfigureAwait(false);
            throw new GoogleApiException(Service.Name, error.ToString())
            {
                HttpStatusCode = response.StatusCode
            };
        }

        /// <summary>A callback when the media was uploaded successfully.</summary>
        private void MediaCompleted(HttpResponseMessage response)
        {
            Logger.Debug("MediaUpload[{0}] - media was uploaded successfully", UploadUri);
            ProcessResponse(response);
            BytesServerReceived = StreamLength;

            // Clear the last request byte array.
            LastMediaRequest = null;
        }

        /// <summary>Prepares the given request with the next chunk in case the steam length is unknown.</summary>
        private void PrepareNextChunkUnknownSize(HttpRequestMessage request, Stream stream,
            CancellationToken cancellationToken)
        {
            // We save the current request, so we would be able to resend those bytes in case of a server error.
            if (LastMediaRequest == null)
            {
                LastMediaRequest = new byte[ChunkSize];
            }

            LastMediaLength = 0;

            // If the number of bytes received by the server isn't equal to the amount of bytes the client sent, copy
            // the required bytes from the last request and resend them to the server.
            if (BytesClientSent != BytesServerReceived)
            {
                int copyBytes = (int)(BytesClientSent - BytesServerReceived);
                Buffer.BlockCopy(LastMediaRequest, ChunkSize - copyBytes, LastMediaRequest, 0, copyBytes);
                LastMediaLength = copyBytes;
            }

            bool shouldRead = true;
            if (CachedByte == null)
            {
                // Create a new cached byte which will be used to verify if we reached the end of stream.
                CachedByte = new byte[1];
            }
            else if (LastMediaLength != ChunkSize)
            {
                // Read the last cached byte, and add it to the current request.
                LastMediaRequest[LastMediaLength++] = CachedByte[0];
            }
            else
            {
                // The whole bytes from last request should be resent, no need to read data from stream in this request
                // and no need to update the cached byte.
                shouldRead = false;
            }

            if (shouldRead)
            {
                int len = 0;
                // Read bytes form the stream to lastMediaRequest byte array.
                while (true)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    len = stream.Read(LastMediaRequest, LastMediaLength,
                        (int)Math.Min(BufferSize, ChunkSize - LastMediaLength));
                    if (len == 0) break;
                    LastMediaLength += len;
                }

                // Check if there is still data to read from stream, and cache the first byte in catchedByte.
                if (0 == stream.Read(CachedByte, 0, 1))
                {
                    // EOF - now we know the stream's length.
                    StreamLength = LastMediaLength + BytesServerReceived;
                    CachedByte = null;
                }
            }

            // Set Content-Length and Content-Range.
            var byteArrayContent = new ByteArrayContent(LastMediaRequest, 0, LastMediaLength);
            byteArrayContent.Headers.Add("Content-Range", GetContentRangeHeader(BytesServerReceived, LastMediaLength));
            request.Content = byteArrayContent;
        }

        /// <summary>Prepares the given request with the next chunk in case the steam length is known.</summary>
        private void PrepareNextChunkKnownSize(HttpRequestMessage request, Stream stream,
            CancellationToken cancellationToken)
        {
            int chunkSize = (int)Math.Min(StreamLength - BytesServerReceived, (long)ChunkSize);

            // Stream length is known and it supports seek and position operations.
            // We can change the stream position and read bytes from the last point.
            byte[] buffer = new byte[Math.Min(chunkSize, BufferSize)];

            // If the number of bytes received by the server isn't equal to the amount of bytes the client sent, we 
            // need to change the position of the input stream, otherwise we can continue from the current position.
            if (BytesClientSent != BytesServerReceived)
            {
                stream.Position = BytesServerReceived;
            }

            MemoryStream ms = new MemoryStream(chunkSize);
            int bytesRead = 0;
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                // Read from input stream and write to output stream.
                // TODO(peleyal): write a utility similar to (.NET 4 Stream.CopyTo method).
                int len = stream.Read(buffer, 0, (int)Math.Min(buffer.Length, chunkSize - bytesRead));
                if (len == 0) break;
                ms.Write(buffer, 0, len);
                bytesRead += len;
            }

            // Set the stream position to beginning and wrap it with stream content.
            ms.Position = 0;
            request.Content = new StreamContent(ms);
            request.Content.Headers.Add("Content-Range", GetContentRangeHeader(BytesServerReceived, chunkSize));

            LastMediaLength = chunkSize;
        }

        /// <summary>Returns the next byte index need to be sent.</summary>
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

        /// <summary>Creates a request to initialize a request.</summary>
        private HttpRequestMessage CreateInitializeRequest()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri(Service.BaseUri),
                Path = Path,
                Method = HttpMethod,
            };

            // init parameters
            builder.AddParameter(RequestParameterType.Query, "key", Service.ApiKey);
            builder.AddParameter(RequestParameterType.Query, "uploadType", "resumable");
            SetAllPropertyValues(builder);

            HttpRequestMessage request = builder.CreateRequest();
            request.Headers.Add(PayloadContentTypeHeader, ContentType);

            // if the length is unknown at the time of this request, omit "X-Upload-Content-Length" header
            if (StreamLength != UnknownSize)
            {
                request.Headers.Add(PayloadContentLengthHeader, StreamLength.ToString());
            }

            Service.SetRequestSerailizedContent(request, Body);
            return request;
        }

        /// <summary>
        /// Reflectively enumerate the properties of this object looking for all properties containing the 
        /// RequestParameterAttribute and copy their values into the request builder.
        /// </summary>
        private void SetAllPropertyValues(RequestBuilder requestBuilder)
        {
            Type myType = this.GetType();
            var properties = myType.GetProperties();

            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<RequestParameterAttribute>();

                if (attribute != null)
                {
                    string name = attribute.Name ?? property.Name.ToLower();
                    object value = property.GetValue(this, null);
                    if (value != null)
                    {
                        var valueAsEnumerable = value as IEnumerable;
                        if (!(value is string) && valueAsEnumerable != null)
                        {
                            foreach (var elem in valueAsEnumerable)
                            {
                                requestBuilder.AddParameter(attribute.Type, name, Utilities.ConvertToString(elem));
                            }
                        }
                        else
                        {
                            // Otherwise just convert it to a string.
                            requestBuilder.AddParameter(attribute.Type, name, Utilities.ConvertToString(value));
                        }
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
        /// <param name="service">The client service.</param>
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
        protected ResumableUpload(IClientService service, string path, string httpMethod,
            Stream contentStream, string contentType)
            : base(service, path, httpMethod, contentStream, contentType) { }

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

        /// <summary>Event which is called when the response metadata is processed.</summary>
        public event Action<TResponse> ResponseReceived;

        #endregion // Events

        #region Overrides

        /// <summary>Process the response body </summary>
        protected override void ProcessResponse(HttpResponseMessage response)
        {
            base.ProcessResponse(response);
            ResponseBody = Service.DeserializeResponse<TResponse>(response).Result;

            if (ResponseReceived != null)
                ResponseReceived(ResponseBody);
        }

        #endregion // Overrides
    }
}
