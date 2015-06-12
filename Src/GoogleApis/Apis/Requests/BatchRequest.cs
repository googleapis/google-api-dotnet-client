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
﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Testing;

namespace Google.Apis.Requests
{
    /// <summary>
    /// A batch request which represents individual requests to Google servers. You should add a single service 
    /// request using the <see cref="Queue"/> method and execute all individual requests using 
    /// <see cref="ExecuteAsync()"/>. More information about the batch protocol is available in 
    /// https://developers.google.com/storage/docs/json_api/v1/how-tos/batch.
    /// <remarks>
    /// Current implementation doesn't retry on unsuccessful individual response and doesn't support requests with 
    /// different access tokens (different users or scopes).
    /// </remarks>
    /// </summary>
    public sealed class BatchRequest
    {
        private const string DefaultBatchUrl = "https://www.googleapis.com/batch";
        private const int QueueLimit = 1000;

        private readonly IList<InnerRequest> allRequests = new List<InnerRequest>();

        private readonly string batchUrl;
        private readonly IClientService service;

        /// <summary>A concrete type callback for an individual response.</summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="content">The content response or <c>null</c> if the request failed.</param>
        /// <param name="error">Error or <c>null</c> if the request succeeded.</param>
        /// <param name="index">The request index.</param>
        /// <param name="message">The HTTP individual response.</param>
        public delegate void OnResponse<in TResponse>
            (TResponse content, RequestError error, int index, HttpResponseMessage message) where TResponse : class;

        #region Inner Request

        /// <summary>This inner class represents an individual inner request.</summary>
        private class InnerRequest
        {
            /// <summary>Gets or sets the client service request.</summary>
            public IClientServiceRequest ClientRequest { get; set; }

            /// <summary>Gets or sets the response class type.</summary>
            public Type ResponseType { get; set; }

            /// <summary>A callback method which will be called after an individual response was parsed.</summary>
            /// <param name="content">The content response or <c>null</c> if the request failed.</param>
            /// <param name="error">Error or <c>null</c> if the request succeeded.</param>
            /// <param name="index">The request index.</param>
            /// <param name="message">The HTTP individual response.</param>
            public virtual void OnResponse(object content, RequestError error, int index, HttpResponseMessage message)
            {
                // Set ETag on the response.
                var eTagValue = message.Headers.ETag != null ? message.Headers.ETag.Tag : null;
                var eTagContainer = content as IDirectResponseSchema;
                if (eTagContainer != null && eTagContainer.ETag == null && eTagValue != null)
                {
                    eTagContainer.ETag = eTagValue;
                }
            }
        }

        /// <summary>
        /// This generic inner class represents an individual inner request with a generic response type.
        /// </summary>
        private class InnerRequest<TResponse> : InnerRequest
            where TResponse : class
        {
            /// <summary>Gets or sets a concrete type callback for an individual response. </summary>
            public OnResponse<TResponse> OnResponseCallback { get; set; }

            public override void OnResponse(object content, RequestError error, int index,
                HttpResponseMessage message)
            {
                base.OnResponse(content, error, index, message);
                if (OnResponseCallback == null)
                    return;

                OnResponseCallback(content as TResponse, error, index, message);
            }
        }

        #endregion

        /// <summary>
        /// Constructs a new batch request using the given service. See 
        /// <see cref="BatchRequest(IClientService, string)"/> for more information.
        /// </summary>
        public BatchRequest(IClientService service)
            : this(service, DefaultBatchUrl) { }

        /// <summary>
        /// Constructs a new batch request using the given service. The service's HTTP client is used to create a 
        /// request to the given server URL and its serializer members are used to serialize the request and 
        /// deserialize the response.
        /// </summary>
        public BatchRequest(IClientService service, string batchUrl)
        {
            this.batchUrl = batchUrl;
            this.service = service;
        }

        /// <summary>Gets the count of all queued requests.</summary>
        public int Count
        {
            get { return allRequests.Count; }
        }

        /// <summary>Queues an individual request.</summary>
        /// <typeparam name="TResponse">The response's type.</typeparam>
        /// <param name="request">The individual request.</param>
        /// <param name="callback">A callback which will be called after a response was parsed.</param>
        public void Queue<TResponse>(IClientServiceRequest request, OnResponse<TResponse> callback)
            where TResponse : class
        {
            if (Count > QueueLimit)
            {
                throw new InvalidOperationException("A batch request cannot contain more than 1000 single requests");
            }

            allRequests.Add(new InnerRequest<TResponse>
                {
                    ClientRequest = request,
                    ResponseType = typeof(TResponse),
                    OnResponseCallback = callback,
                });
        }

        /// <summary>Asynchronously executes the batch request.</summary>
        public Task ExecuteAsync()
        {
            return ExecuteAsync(CancellationToken.None);
        }

        /// <summary>Asynchronously executes the batch request.</summary>
        /// <param name="cancellationToken">Cancellation token to cancel operation.</param>
        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            if (Count < 1)
                return;

            ConfigurableHttpClient httpClient = service.HttpClient;

            var requests = from r in allRequests
                           select r.ClientRequest;
            HttpContent outerContent = await CreateOuterRequestContent(requests).ConfigureAwait(false);
            var result = await httpClient.PostAsync(new Uri(batchUrl), outerContent, cancellationToken)
                .ConfigureAwait(false);

            result.EnsureSuccessStatusCode();

            // Get the boundary separator.
            const string boundaryKey = "boundary=";
            var fullContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var contentType = result.Content.Headers.GetValues("Content-Type").First();
            var boundary = contentType.Substring(contentType.IndexOf(boundaryKey) + boundaryKey.Length);

            int requestIndex = 0;
            // While there is still content to read, parse the current HTTP response.
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var startIndex = fullContent.IndexOf("--" + boundary);
                if (startIndex == -1)
                {
                    break;
                }
                fullContent = fullContent.Substring(startIndex + boundary.Length + 2);
                var endIndex = fullContent.IndexOf("--" + boundary);
                if (endIndex == -1)
                {
                    break;
                }

                HttpResponseMessage responseMessage = ParseAsHttpResponse(fullContent.Substring(0, endIndex));

                if (responseMessage.IsSuccessStatusCode)
                {
                    // Parse the current content object.
                    var responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var content = service.Serializer.Deserialize(responseContent,
                        allRequests[requestIndex].ResponseType);

                    allRequests[requestIndex].OnResponse(content, null, requestIndex, responseMessage);
                }
                else
                {
                    // Parse the error from the current response.
                    var error = await service.DeserializeError(responseMessage).ConfigureAwait(false);
                    allRequests[requestIndex].OnResponse(null, error, requestIndex, responseMessage);
                }

                requestIndex++;
                fullContent = fullContent.Substring(endIndex);
            }
        }

        /// <summary>Parses the given string content to a HTTP response.</summary>
        [VisibleForTestOnly]
        internal static HttpResponseMessage ParseAsHttpResponse(string content)
        {
            var response = new HttpResponseMessage();

            using (var reader = new StringReader(content))
            {
                string line = reader.ReadLine();

                // Extract empty lines.
                while (string.IsNullOrEmpty(line))
                    line = reader.ReadLine();

                // Extract the outer header.
                while (!string.IsNullOrEmpty(line))
                    line = reader.ReadLine();

                // Extract the status code.
                line = reader.ReadLine();
                while (string.IsNullOrEmpty(line))
                    line = reader.ReadLine();
                int code = int.Parse(line.Split(' ')[1]);
                response.StatusCode = (HttpStatusCode)code;

                // Extract the headers.
                IDictionary<string, string> headersDic = new Dictionary<string, string>();
                while (!string.IsNullOrEmpty((line = reader.ReadLine())))
                {
                    var separatorIndex = line.IndexOf(':');
                    headersDic.Add(line.Substring(0, separatorIndex).Trim(),
                        line.Substring(separatorIndex + 1).Trim());
                }

                // Set the content.
                string mediaType = null;
                if (headersDic.ContainsKey("Content-Type"))
                {
                    mediaType = headersDic["Content-Type"].Split(';', ' ')[0];
                    headersDic.Remove("Content-Type");
                }
                response.Content = new StringContent(reader.ReadToEnd(), Encoding.UTF8, mediaType);

                // Add the headers to the response.
                foreach (var keyValue in headersDic)
                {
                    HttpHeaders headers = response.Headers;
                    // Check if we need to add the current header to the content headers.
                    if (typeof(HttpContentHeaders).GetProperty(keyValue.Key.Replace("-", "")) != null)
                    {
                        headers = response.Content.Headers;
                    }
                    headers.Add(keyValue.Key, keyValue.Value);
                }

                // TODO(peleyal): ContentLength header is x while the "real" content that we read from the stream is 
                // Content.ReadStringAsAsync().Length is x+2
            }

            return response;
        }

        /// <summary>
        /// Creates the batch outer request content which includes all the individual requests to Google servers.
        /// </summary>
        [VisibleForTestOnly]
        internal async static Task<HttpContent> CreateOuterRequestContent(IEnumerable<IClientServiceRequest> requests)
        {
            var mixedContent = new MultipartContent("mixed");
            foreach (var request in requests)
            {
                mixedContent.Add(await CreateIndividualRequest(request).ConfigureAwait(false));
            }

            // Batch request currently doesn't support GZip. Uncomment when the issue will be resolved.
            // https://code.google.com/p/google-api-dotnet-client/issues/detail?id=409
            /*if (service.GZipEnabled)
            {
                var content = HttpServiceExtenstions.CreateZipContent(await mixedContent.ReadAsStringAsync()
                    .ConfigureAwait(false));
                content.Headers.ContentType = mixedContent.Headers.ContentType;
                return content;
            }*/
            return mixedContent;

        }

        /// <summary>Creates the individual server request.</summary>
        [VisibleForTestOnly]
        internal static async Task<HttpContent> CreateIndividualRequest(IClientServiceRequest request)
        {
            HttpRequestMessage requestMessage = request.CreateRequest(false);
            string requestContent = await CreateRequestContentString(requestMessage).ConfigureAwait(false);

            var content = new StringContent(requestContent);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/http");
            return content;
        }

        /// <summary>
        /// Creates a string representation that includes the request's headers and content based on the input HTTP 
        /// request message.
        /// </summary>
        [VisibleForTestOnly]
        internal static async Task<string> CreateRequestContentString(HttpRequestMessage requestMessage)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", requestMessage.Method, requestMessage.RequestUri.AbsoluteUri);

            // Add Headers.
            foreach (var otherHeader in requestMessage.Headers)
            {
                sb.Append(Environment.NewLine)
                    .AppendFormat(("{0}: {1}"), otherHeader.Key, String.Join(", ", otherHeader.Value.ToArray()));
            }

            // Add content headers.
            if (requestMessage.Content != null)
            {
                foreach (var contentHeader in requestMessage.Content.Headers)
                {
                    sb.Append(Environment.NewLine)
                        .AppendFormat("{0}: {1}", contentHeader.Key, String.Join(", ", contentHeader.Value.ToArray()));
                }
            }

            // Content.
            if (requestMessage.Content != null)
            {
                sb.Append(Environment.NewLine);
                var content = await requestMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                sb.Append("Content-Length:  ").Append(content.Length);

                sb.Append(Environment.NewLine).Append(Environment.NewLine).Append(content);
            }

            return sb.Append(Environment.NewLine).ToString();
        }
    }
}