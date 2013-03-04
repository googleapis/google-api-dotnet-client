/*
Copyright 2010 Google Inc

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
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Util;

#if !SILVERLIGHT
using System.IO.Compression;
#endif

namespace Google.Apis.Requests
{
    /// <summary>
    /// Request to a service.
    /// </summary>
    /// <remarks>
    /// Features which are not (yet) supported on SilverLight:
    /// - The UserAgent header.
    /// - GZip Compression
    /// </remarks>
    public class Request : IRequest
    {
        // [ApplicatioName] google-api-dotnet-client/[ApiVersion] [Os]/[OsVersion] [ClrVersion]
        private const string UserAgent = "{0} google-api-dotnet-client/{1} {2}/{3} {4}";
        private const string GZipUserAgentSuffix = " (gzip)";
        private const string GZipEncoding = "gzip";

        /// <summary>
        /// The charset used for content encoding.
        /// </summary>
        public static readonly Encoding ContentCharset = Encoding.UTF8;

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<Request>();

        public const string DELETE = "DELETE";
        public const string GET = "GET";
        public const string PATCH = "PATCH";
        public const string POST = "POST";
        public const string PUT = "PUT";

        /// <summary>
        /// Defines the maximum number of retries which should be made if a request fails.
        /// </summary>
        public int MaximumRetries { get; set; }

        /// <summary>
        /// Defines the factor by which the waiting time is multiplied between retry attempts.
        /// </summary>
        public double RetryWaitTimeIncreaseFactor { get; set; }

        /// <summary>
        /// Defines the initial waiting time, which is used once the first retry has failed.
        /// </summary>
        public int RetryInitialWaitTime { get; set; }

        private static readonly String ApiVersion = Utilities.GetLibraryVersion();

        public static readonly ReadOnlyCollection<string> SupportedHttpMethods =
            new List<string> { POST, PUT, DELETE, GET, PATCH }.AsReadOnly();

        private string applicationName;

        public Request()
        {
            applicationName = Utilities.GetAssemblyTitle() ?? "Unknown_Application";
            Authenticator = new NullAuthenticator();
            WebRequestFactory = new HttpRequestFactory();
            Parameters = new ParameterCollection();

            MaximumRetries = 3;
            RetryWaitTimeIncreaseFactor = 2.0;
            RetryInitialWaitTime = 1000;
        }

        /// <summary>
        /// The authenticator used for this request.
        /// </summary>
        internal IAuthenticator Authenticator { get; private set; }

        /// <summary>
        /// The developer API Key sent along with the request.
        /// </summary>
        internal String DeveloperKey { get; private set; }

        /// <summary>
        /// Set of method parameters.
        /// </summary>
        [VisibleForTestOnly]
        internal ParameterCollection Parameters { get; set; }

        /// <summary>
        /// The application name used within the user agent string.
        /// </summary>
        [VisibleForTestOnly]
        internal string ApplicationName
        {
            get { return applicationName; }
        }

        private IClientService Service { get; set; }
        private IClientServiceRequest ServiceRequest { get; set; }

        private Uri BaseURI { get; set; }
        private string RPCName { get; set; } // note: this property is apparently never used
        private string Body { get; set; }
        private ETagAction ETagAction { get; set; }
        private string ETag { get; set; }

        /// <summary>
        /// Defines whether this request can be sent multiple times.
        /// </summary>
        public bool SupportsRetry
        {
            get { return true; }
        }

        #region IRequest Members

        /// <summary>
        /// The method to call
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest On(string rpcName)
        {
            RPCName = rpcName;

            return this;
        }

        /// <summary>
        /// Adds the parameters to the request.
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest WithParameters(IDictionary<string, object> parameters)
        {
            Parameters = ParameterCollection.FromDictionary(parameters);
            return this;
        }

        /// <summary>
        /// Adds the parameters to the request.
        /// </summary>
        /// <returns>
        /// A <see cref="Request"/>
        /// </returns>
        public IRequest WithParameters(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            Parameters = new ParameterCollection(parameters);
            return this;
        }

        /// <summary>
        /// Parses the specified querystring and adds these parameters to the request
        /// </summary>
        public IRequest WithParameters(string parameters)
        {
            Parameters = ParameterCollection.FromQueryString(parameters);
            return this;
        }

        /// <summary>
        /// Uses the string provied as the body of the request.
        /// </summary>
        public IRequest WithBody(string body)
        {
            Body = body;
            return this;
        }

        /// <summary>
        /// Uses the provided authenticator to add authentication information to this request.
        /// </summary>
        public IRequest WithAuthentication(IAuthenticator authenticator)
        {
            authenticator.ThrowIfNull("Authenticator");
            Authenticator = authenticator;
            return this;
        }

        /// <summary>
        /// Adds the developer key to this request.
        /// </summary>
        public IRequest WithKey(string key)
        {
            DeveloperKey = key;
            return this;
        }

        /// <summary>
        /// Sets the ETag-behavior of this request.
        /// </summary>
        public IRequest WithETagAction(ETagAction action)
        {
            ETagAction = action;
            return this;
        }

        /// <summary>
        /// Adds an ETag to this request.
        /// </summary>
        public IRequest WithETag(string etag)
        {
            ETag = etag;
            return this;
        }

        /// <summary>
        /// Container struct for the asynchronous execution of a request.
        /// </summary>
        private struct AsyncExecutionState
        {
            /// <summary>
            /// The current try we are in. 1 based.
            /// </summary>
            public int Try;

            /// <summary>
            /// The time we will wait between the current and the next request if the current one fails.
            /// </summary>
            public double WaitTime;

            /// <summary>
            /// The method which will be called once the request has been completed.
            /// </summary>
            public Action<IAsyncRequestResult> ResponseHandler;

            /// <summary>
            /// The request which is currently being executed.
            /// </summary>
            public WebRequest CurrentRequest;
        }

        /// <summary>
        /// Represents the result of an asynchronous Request.
        /// </summary>
        private class AsyncRequestResult : IAsyncRequestResult
        {
            private readonly IResponse response;
            private readonly GoogleApiRequestException exception;

            public AsyncRequestResult(IResponse response)
            {
                this.response = response;
            }

            public AsyncRequestResult(GoogleApiRequestException exception)
            {
                this.exception = exception;
            }

            public IResponse GetResponse()
            {
                if (exception != null) // Request failed.
                {
                    throw exception;
                }

                return response; // Request succeeded.
            }
        }

        /// <summary>
        /// Begins executing a request based upon the current execution state.
        /// </summary>
        /// <remarks>Does not check preconditions.</remarks>
        private void InternalBeginExecuteRequest(AsyncExecutionState state)
        {
            state.CurrentRequest.BeginGetResponse(InternalEndExecuteRequest, state);
        }

        /// <summary>
        /// Ends executing an asynchronous request.
        /// </summary>
        private void InternalEndExecuteRequest(IAsyncResult asyncResult)
        {
            AsyncExecutionState state = (AsyncExecutionState)asyncResult.AsyncState;
            AsyncRequestResult asyncRequestResult = null;
            bool retried = false;
            try
            {
                asyncRequestResult = new AsyncRequestResult(new Response(
                    state.CurrentRequest.EndGetResponse(asyncResult)));
            }
            catch (WebException ex)
            {
                // Returns null if the attempt was retried.
                retried = HandleFailedRequest(state, ex, out asyncRequestResult);
            }
            catch (Exception ex) // Unknown exception.
            {
                asyncRequestResult = new AsyncRequestResult(
                    new GoogleApiRequestException(Service.Name, this, null, ex));
            }
            finally
            {
                // If the async result is null, this indicates that the request was retried.
                // Another handler will be executed to respond to that attempt, so do not
                // call the handler yet.
                if (!retried)
                    state.ResponseHandler(asyncRequestResult);
            }
        }

        /// <summary>
        /// Handles a failed request, and tries to fix it if possible.
        /// </summary>
        /// <remarks>
        /// Can not throw an exception.
        /// </remarks>
        /// <returns>
        /// Returns true if the request was handled and is being retried.
        /// Returns false if the request could not be retried.
        /// </returns>
        private bool HandleFailedRequest(AsyncExecutionState state,
            WebException exception, out AsyncRequestResult asyncRequestResult)
        {
            try
            {
                RequestError error = null;
                // Try to get an error response object.
                if (exception.Response != null)
                {
                    IResponse errorResponse = new Response(exception.Response);
                    error = Service.DeserializeError(errorResponse);
                }

                // Try to handle the response somehow.
                if (SupportsRetry && state.Try < MaximumRetries)
                {
                    // Wait some time before sending another request.
                    Thread.Sleep((int)state.WaitTime);
                    state.WaitTime *= RetryWaitTimeIncreaseFactor;
                    state.Try++;

                    foreach (IErrorResponseHandler handler in GetErrorResponseHandlers())
                    {
                        if (handler.CanHandleErrorResponse(exception, error))
                        {
                            // The provided handler was able to handle this error. Retry sending the request.
                            handler.HandleErrorResponse(exception, error, state.CurrentRequest);
                            logger.Warning("Retrying request [{0}]", this);

                            // Begin a new request and when it is completed being assembled, execute it 
                            // asynchronously.
                            state.CurrentRequest = CreateWebRequest((request) =>
                            {
                                InternalBeginExecuteRequest(state);
                            });
                            // Signal that this begin/end request pair has no result because it has been retried.
                            asyncRequestResult = null;
                            return true;
                        }
                    }
                }

                // Retrieve additional information about the http response (if applicable).
                HttpStatusCode status = 0;
                HttpWebResponse httpResponse = exception.Response as HttpWebResponse;
                if (httpResponse != null)
                {
                    status = httpResponse.StatusCode;
                }

                // We were unable to handle the exception. Throw it wrapped in a GoogleApiRequestException.
                asyncRequestResult = new AsyncRequestResult(
                    new GoogleApiRequestException(Service.Name, this, error, exception) { HttpStatusCode = status });
            }
            catch (Exception)
            {
                asyncRequestResult = new AsyncRequestResult(
                    new GoogleApiRequestException(Service.Name, this, null, exception));
            }
            return false;
        }

        /// <summary>
        /// Executes the request asynchronously, and calls the specified delegate once done.
        /// </summary>
        /// <param name="responseHandler">The method to call once a response has been received.</param>
        public void ExecuteRequestAsync(Action<IAsyncRequestResult> responseHandler)
        {
            // Validate the input.
            var validator = new MethodValidator(ServiceRequest, Parameters);
            if (validator.ValidateAllParameters() == false)
            {
                throw new InvalidOperationException("Request parameter validation failed for [" + this + "]");
            }

            // Begin a new request and when it is completed being assembled, execute it asynchronously.
            CreateWebRequest((request) =>
            {
                // When the request is completed constructing, execute it.
                var state = new AsyncExecutionState()
                {
                    ResponseHandler = responseHandler,
                    Try = 1,
                    WaitTime = RetryInitialWaitTime,
                    CurrentRequest = request
                };
                InternalBeginExecuteRequest(state);
            });
        }

        /// <summary>
        /// Executes a request given the configuration options supplied.
        /// </summary>
        /// <returns>
        /// A <see cref="Stream"/>
        /// </returns>
        public IResponse ExecuteRequest()
        {
            AutoResetEvent waitHandle = new AutoResetEvent(false);
            IAsyncRequestResult result = null;
            ExecuteRequestAsync(r =>
                                    {
                                        result = r;
                                        waitHandle.Set();
                                    });
            waitHandle.WaitOne();
            return result.GetResponse();
        }

        #endregion

        /// <summary>
        /// Returns all error response handlers associated with this request.
        /// </summary>
        [VisibleForTestOnly]
        internal IEnumerable<IErrorResponseHandler> GetErrorResponseHandlers()
        {
            // Check if the current authenticator can handle error responses.
            IErrorResponseHandler authenticator = Authenticator as IErrorResponseHandler;
            if (authenticator != null)
            {
                yield return authenticator;
            }
        }

        /// <summary>
        /// Given an API method, create the appropriate Request for it.
        /// </summary>
        public static IRequest CreateRequest(IClientService service, IClientServiceRequest request)
        {
            switch (request.HttpMethod)
            {
                case GET:
                case PUT:
                case POST:
                case DELETE:
                case PATCH:
                    return new Request { Service = service, ServiceRequest = request, BaseURI = new Uri(service.BaseUri) };
                default:
                    throw new NotSupportedException(
                        string.Format(
                            "The HttpMethod[{0}] of Method[{1}] in Service[{2}] was not supported", request.HttpMethod,
                            request.MethodName, service.Name));
            }
        }

        /// <summary>
        /// Sets the Application name on the UserAgent String.
        /// </summary>
        /// <param name="name">
        /// A <see cref="System.String"/>
        /// </param>
        public IRequest WithAppName(string name)
        {
            applicationName = name;
            return this;
        }

        /// <summary>
        /// Builds the resulting Url for the whole request.
        /// </summary>
        [VisibleForTestOnly]
        internal HttpWebRequest BuildRequest()
        {
            var requestBuilder = new HttpWebRequestBuilder()
            {
                BaseUri = new Uri(Service.BaseUri),
                Path = ServiceRequest.RestPath,
                Method = ServiceRequest.HttpMethod,
            };

            requestBuilder.AddParameter(RequestParameterType.Query, "key", DeveloperKey);

            // Replace the substitution parameters.
            foreach (var parameter in Parameters)
            {
                IParameter parameterDefinition;// = Method.Parameters[parameter.Key];

                if (!(ServiceRequest.RequestParameters.TryGetValue(parameter.Key, out parameterDefinition)
                    || Service.ServiceParameters.TryGetValue(parameter.Key, out parameterDefinition)
                    ))
                {
                    throw new GoogleApiException(Service.Name,
                        String.Format("Invalid parameter \"{0}\" specified.", parameter.Key));
                }

                string value = parameter.Value;
                if (value == null) // If the parameter is null, use the default value.
                {
                    value = parameterDefinition.DefaultValue;
                }
                switch (parameterDefinition.ParameterType)
                {
                    case "path":
                        requestBuilder.AddParameter(RequestParameterType.Path, parameter.Key, value);
                        break;
                    case "query":
                        // If the parameter is optional and no value is given, don't add to url.
                        if (parameterDefinition.IsRequired && String.IsNullOrEmpty(value))
                        {
                            throw new GoogleApiException(Service.Name,
                                String.Format("Required parameter \"{0}\" missing.", parameter.Key));
                        }

                        if (!Object.Equals(value, parameterDefinition.DefaultValue) || parameterDefinition.IsRequired)
                        {
                            requestBuilder.AddParameter(RequestParameterType.Query, parameter.Key, value);
                        }
                        break;
                    default:
                        throw new NotSupportedException(
                            "Found an unsupported Parametertype [" + parameterDefinition.ParameterType + "]");
                }
            }

            return requestBuilder.GetWebRequest();
        }

        /// <summary>
        /// Gets the supported return mime type
        /// </summary>
        private static string GetReturnMimeType()
        {
            // The .NET client library supports only json format
            return "application/json";
        }

        /// <summary>
        /// Returns the default ETagAction for a specific http verb.
        /// </summary>
        [VisibleForTestOnly]
        internal static ETagAction GetDefaultETagAction(string httpVerb)
        {
            switch (httpVerb)
            {
                default:
                    return ETagAction.Ignore;

                case GET: // Incoming data should only be updated if it has been changed on the server.
                    return ETagAction.IfNoneMatch;

                case PUT: // Outgoing data should only be commited if it hasn't been changed on the server.
                case POST:
                case PATCH:
                case DELETE:
                    return ETagAction.IfMatch;
            }
        }

        private ICreateHttpRequest webRequestFactory;

        /// <summary>
        /// Factory used to create HttpWebRequest objects.
        /// </summary>
        public ICreateHttpRequest WebRequestFactory
        {
            get
            {
                return this.webRequestFactory;
            }
            set
            {
                value.ThrowIfNull("HttpRequestFactory");
                this.webRequestFactory = value;
            }
        }

        /// <summary>
        /// Creates the ready-to-send WebRequest containing all the data specified in this request class.
        /// </summary>
        /// <param name="onRequestReady">An action to execute when the request has been prepared.</param>
        [VisibleForTestOnly]
        internal WebRequest CreateWebRequest(Action<WebRequest> onRequestReady)
        {
            HttpWebRequest httpRequest = BuildRequest();

            // Create the request.
            Authenticator.ApplyAuthenticationToRequest(httpRequest);

            // Insert the content type and user agent.
            httpRequest.ContentType = string.Format(
                "{0}; charset={1}", GetReturnMimeType(), ContentCharset.WebName);

            // The UserAgent header can only be set on a non-Silverlight platform.
            // Silverlight uses the user agent of the browser instead.
#if !SILVERLIGHT
            var osPlatform = Environment.OSVersion.Platform;
            var osVersion = Environment.OSVersion.Version;
            var clrVersion = Environment.Version;
            httpRequest.UserAgent = String.Format(UserAgent, ApplicationName, ApiVersion,
                osPlatform, osVersion, clrVersion);
#endif

            // Add the E-tag header:
            if (!string.IsNullOrEmpty(ETag))
            {
                ETagAction action = this.ETagAction;
                if (action == ETagAction.Default)
                {
                    action = GetDefaultETagAction(httpRequest.Method);
                }

                switch (action)
                {
                    case ETagAction.IfMatch:
                        httpRequest.Headers[HttpRequestHeader.IfMatch] = ETag;
                        break;

                    case ETagAction.IfNoneMatch:
                        httpRequest.Headers[HttpRequestHeader.IfNoneMatch] = ETag;
                        break;
                }
            }

#if !SILVERLIGHT
            // Check if compression is supported.
            if (Service.GZipEnabled)
            {
                httpRequest.UserAgent += GZipUserAgentSuffix;
                httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
#endif

            // Attach a body if a POST and there is something to attach.
            if (HttpMethodHasBody(httpRequest.Method))
            {
                if (!string.IsNullOrEmpty(Body))
                {
                    AttachBody(httpRequest, onRequestReady);
                    return httpRequest;
                }
                else
                {
                    // Set the "Content-Length" header, which is required for every http method declaring a body. This 
                    // is required as e.g. the google servers will throw a "411 - Length required" error otherwise.
#if !SILVERLIGHT
                    httpRequest.ContentLength = 0;
#else
                    // Set by the browser on Silverlight. Cannot be modified by the user.
#endif
                }
            }

            onRequestReady(httpRequest);
            return httpRequest;
        }

        /// <summary>
        /// Adds the body of this request to the specified WebRequest.
        /// </summary>
        /// <param name="request">The WebRequest which needs a body attached.</param>
        /// <param name="onRequestReady">An action to complete when the request is ready.</param>
        /// <remarks>Automatically applies GZip-compression if globally enabled.</remarks>
        [VisibleForTestOnly]
        internal void AttachBody(WebRequest request, Action<WebRequest> onRequestReady)
        {
            request.BeginGetRequestStream(new AsyncCallback(EndAttachBody),
                new object[] { request, onRequestReady });
        }

        /// <summary>
        /// Complete the attach-body portion of the request and continue executing the call.
        /// </summary>
        /// <param name="asyncResult">The asyncResult of the attach body call.</param>
        internal void EndAttachBody(IAsyncResult asyncResult)
        {
            object[] state = (object[])asyncResult.AsyncState;
            WebRequest request = (WebRequest)state[0];
            Action<WebRequest> onRequestReady = (Action<WebRequest>)state[1];

            Stream bodyStream = request.EndGetRequestStream(asyncResult);

#if !SILVERLIGHT
            // If enabled: Encapsulate in GZipStream.
            if (Service.GZipEnabled)
            {
                // Change the content encoding and apply a gzip filter.
                request.Headers.Add(HttpRequestHeader.ContentEncoding, GZipEncoding);
                bodyStream = new GZipStream(bodyStream, CompressionMode.Compress);
            }
#endif
            // Write data into the stream.
            using (bodyStream)
            {
                byte[] postBody = ContentCharset.GetBytes(Body);
                bodyStream.Write(postBody, 0, postBody.Length);
            }

            onRequestReady(request);
        }

        /// <summary>
        /// Returns true if this http method can have a body.
        /// </summary>
        public static bool HttpMethodHasBody(string httpMethod)
        {
            switch (httpMethod)
            {
                case DELETE:
                case GET:
                    return false;
                case PATCH:
                case POST:
                case PUT:
                    return true;
                default:
                    throw new NotSupportedException(string.Format("The HttpMethod[{0}] is not supported", httpMethod));
            }
        }

        public override string ToString()
        {
            return string.Format("{0}({1} @ {2})", GetType(), ServiceRequest.MethodName, BuildRequest().RequestUri);
        }
    }
}
