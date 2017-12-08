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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Logging;
using Google.Apis.Testing;
using System.Net.Http.Headers;

namespace Google.Apis.Http
{
    /// <summary>
    /// A message handler which contains the main logic of our HTTP requests. It contains a list of 
    /// <see cref="IHttpUnsuccessfulResponseHandler"/>s for handling abnormal responses, a list of 
    /// <see cref="IHttpExceptionHandler"/>s for handling exception in a request and a list of 
    /// <see cref="IHttpExecuteInterceptor"/>s for intercepting a request before it has been sent to the server.
    /// It also contains important properties like number of tries, follow redirect, etc.
    /// </summary>
    public class ConfigurableMessageHandler : DelegatingHandler
    {
        /// <summary>The class logger.</summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ConfigurableMessageHandler>();

        /// <summary>Maximum allowed number of tries.</summary>
        [VisibleForTestOnly]
        public const int MaxAllowedNumTries = 20;

        /// <summary>
        /// Key for unsuccessful response handlers in an <see cref="HttpRequestMessage"/> properties.
        /// </summary>
        public const string UnsuccessfulResponseHandlerKey = "__UnsuccessfulResponseHandlerKey";

        /// <summary>
        /// Key for unsuccessful response handlers in an <see cref="HttpRequestMessage"/> properties.
        /// </summary>
        public const string ExceptionHandlerKey = "__ExceptionHandlerKey";

        /// <summary>
        /// Key for unsuccessful response handlers in an <see cref="HttpRequestMessage"/> properties.
        /// </summary>
        public const string ExecuteInterceptorKey = "__ExecuteInterceptorKey";

        /// <summary>
        /// Key for a stream response interceptor provider in an <see cref="HttpRequestMessage"/> properties.
        /// </summary>
        public const string ResponseStreamInterceptorProviderKey = "__ResponseStreamInterceptorProviderKey";

        /// <summary>The current API version of this client library.</summary>
        private static readonly string ApiVersion = Google.Apis.Util.Utilities.GetLibraryVersion();

        /// <summary>The User-Agent suffix header which contains the <see cref="ApiVersion"/>.</summary>
        private static readonly string UserAgentSuffix = "google-api-dotnet-client/" + ApiVersion + " (gzip)";

        #region IHttpUnsuccessfulResponseHandler, IHttpExceptionHandler and IHttpExecuteInterceptor lists

        #region Lock objects

        // The following lock objects are used to lock the list of handlers and interceptors in order to be able to
        // iterate over them from several threads and to keep this class thread-safe.
        private readonly object unsuccessfulResponseHandlersLock = new object();
        private readonly object exceptionHandlersLock = new object();
        private readonly object executeInterceptorsLock = new object();

        #endregion

        /// <summary>A list of <see cref="IHttpUnsuccessfulResponseHandler"/>.</summary>
        private readonly IList<IHttpUnsuccessfulResponseHandler> unsuccessfulResponseHandlers =
            new List<IHttpUnsuccessfulResponseHandler>();

        /// <summary>A list of <see cref="IHttpExceptionHandler"/>.</summary>
        private readonly IList<IHttpExceptionHandler> exceptionHandlers =
            new List<IHttpExceptionHandler>();

        /// <summary>A list of <see cref="IHttpExecuteInterceptor"/>.</summary>
        private readonly IList<IHttpExecuteInterceptor> executeInterceptors =
            new List<IHttpExecuteInterceptor>();

        /// <summary>
        /// Gets a list of <see cref="IHttpUnsuccessfulResponseHandler"/>s.
        /// <remarks>
        /// Since version 1.10, <see cref="AddUnsuccessfulResponseHandler"/> and
        /// <see cref="RemoveUnsuccessfulResponseHandler"/> were added in order to keep this class thread-safe.
        /// More information is available on
        /// <a href="https://github.com/google/google-api-dotnet-client/issues/592">#592</a>.
        /// </remarks>
        /// </summary>
        [Obsolete("Use AddUnsuccessfulResponseHandler or RemoveUnsuccessfulResponseHandler instead.")]
        public IList<IHttpUnsuccessfulResponseHandler> UnsuccessfulResponseHandlers
        {
            get { return unsuccessfulResponseHandlers; }
        }

        /// <summary>Adds the specified handler to the list of unsuccessful response handlers.</summary>
        public void AddUnsuccessfulResponseHandler(IHttpUnsuccessfulResponseHandler handler)
        {
            lock (unsuccessfulResponseHandlersLock)
            {
                unsuccessfulResponseHandlers.Add(handler);
            }
        }

        /// <summary>Removes the specified handler from the list of unsuccessful response handlers.</summary>
        public void RemoveUnsuccessfulResponseHandler(IHttpUnsuccessfulResponseHandler handler)
        {
            lock (unsuccessfulResponseHandlersLock)
            {
                unsuccessfulResponseHandlers.Remove(handler);
            }
        }

        /// <summary>
        /// Gets a list of <see cref="IHttpExceptionHandler"/>s.
        /// <remarks>
        /// Since version 1.10, <see cref="AddExceptionHandler"/> and <see cref="RemoveExceptionHandler"/> were added
        /// in order to keep this class thread-safe.  More information is available on
        /// <a href="https://github.com/google/google-api-dotnet-client/issues/592">#592</a>.
        /// </remarks>
        /// </summary>
        [Obsolete("Use AddExceptionHandler or RemoveExceptionHandler instead.")]
        public IList<IHttpExceptionHandler> ExceptionHandlers
        {
            get { return exceptionHandlers; }
        }

        /// <summary>Adds the specified handler to the list of exception handlers.</summary>
        public void AddExceptionHandler(IHttpExceptionHandler handler)
        {
            lock (exceptionHandlersLock)
            {
                exceptionHandlers.Add(handler);
            }
        }

        /// <summary>Removes the specified handler from the list of exception handlers.</summary>
        public void RemoveExceptionHandler(IHttpExceptionHandler handler)
        {
            lock (exceptionHandlersLock)
            {
                exceptionHandlers.Remove(handler);
            }
        }

        /// <summary>
        /// Gets a list of <see cref="IHttpExecuteInterceptor"/>s.
        /// <remarks>
        /// Since version 1.10, <see cref="AddExecuteInterceptor"/> and <see cref="RemoveExecuteInterceptor"/> were
        /// added in order to keep this class thread-safe.  More information is available on
        /// <a href="https://github.com/google/google-api-dotnet-client/issues/592">#592</a>.
        /// </remarks>
        /// </summary>
        [Obsolete("Use AddExecuteInterceptor or RemoveExecuteInterceptor instead.")]
        public IList<IHttpExecuteInterceptor> ExecuteInterceptors
        {
            get { return executeInterceptors; }
        }

        /// <summary>Adds the specified interceptor to the list of execute interceptors.</summary>
        public void AddExecuteInterceptor(IHttpExecuteInterceptor interceptor)
        {
            lock (executeInterceptorsLock)
            {
                executeInterceptors.Add(interceptor);
            }
        }

        /// <summary>Removes the specified interceptor from the list of execute interceptors.</summary>
        public void RemoveExecuteInterceptor(IHttpExecuteInterceptor interceptor)
        {
            lock (executeInterceptorsLock)
            {
                executeInterceptors.Remove(interceptor);
            }
        }

        #endregion

        private int _loggingRequestId = 0;

        private ILogger _instanceLogger = Logger;

        /// <summary>
        /// For testing only.
        /// This defaults to the static <see cref="Logger"/>, but can be overridden for fine-grain testing. 
        /// </summary>
        internal ILogger InstanceLogger
        {
            get { return _instanceLogger; }
            set { _instanceLogger = value.ForType<ConfigurableMessageHandler>(); }
        }

        /// <summary>Number of tries. Default is <c>3</c>.</summary>
        private int numTries = 3;

        /// <summary>
        /// Gets or sets the number of tries that will be allowed to execute. Retries occur as a result of either
        /// <see cref="IHttpUnsuccessfulResponseHandler"/> or <see cref="IHttpExceptionHandler"/> which handles the
        /// abnormal HTTP response or exception before being terminated. 
        /// Set <c>1</c> for not retrying requests. The default value is <c>3</c>.
        /// <remarks>
        /// The number of allowed redirects (3xx) is defined by <see cref="NumRedirects"/>. This property defines
        /// only the allowed tries for >=400 responses, or when an exception is thrown. For example if you set 
        /// <see cref="NumTries"/> to 1 and <see cref="NumRedirects"/> to 5, the library will send up to five redirect
        /// requests, but will not send any retry requests due to an error HTTP status code.
        /// </remarks>
        /// </summary>
        public int NumTries
        {
            get { return numTries; }
            set
            {
                if (value > MaxAllowedNumTries || value < 1)
                {
                    throw new ArgumentOutOfRangeException("NumTries");
                }
                numTries = value;
            }
        }

        /// <summary>Number of redirects allowed. Default is <c>10</c>.</summary>
        private int numRedirects = 10;

        /// <summary>
        /// Gets or sets the number of redirects that will be allowed to execute. The default value is <c>10</c>.
        /// See <see cref="NumTries"/> for more information.
        /// </summary>
        public int NumRedirects
        {
            get { return numRedirects; }
            set
            {
                if (value > MaxAllowedNumTries || value < 1)
                {
                    throw new ArgumentOutOfRangeException("NumRedirects");
                }
                numRedirects = value;
            }
        }

        /// <summary>
        /// Gets or sets whether the handler should follow a redirect when a redirect response is received. Default 
        /// value is <c>true</c>.
        /// </summary>
        public bool FollowRedirect { get; set; }

        /// <summary>Gets or sets whether logging is enabled. Default value is <c>true</c>.</summary>
        public bool IsLoggingEnabled { get; set; }

        /// <summary>
        /// Specifies the type(s) of request/response events to log.
        /// </summary>
        [Flags]
        public enum LogEventType
        {
            /// <summary>
            /// Log no request/response information.
            /// </summary>
            None = 0,

            /// <summary>
            /// Log the request URI.
            /// </summary>
            RequestUri = 1,

            /// <summary>
            /// Log the request headers.
            /// </summary>
            RequestHeaders = 2,

            /// <summary>
            /// Log the request body. The body is assumed to be ASCII, and non-printable charaters are replaced by '.'.
            /// Warning: This causes the body content to be buffered in memory, so use with care for large requests.
            /// </summary>
            RequestBody = 4,

            /// <summary>
            /// Log the response status.
            /// </summary>
            ResponseStatus = 8,

            /// <summary>
            /// Log the response headers.
            /// </summary>
            ResponseHeaders = 16,

            /// <summary>
            /// Log the response body. The body is assumed to be ASCII, and non-printable characters are replaced by '.'.
            /// Warning: This causes the body content to be buffered in memory, so use with care for large responses.
            /// </summary>
            ResponseBody = 32,

            /// <summary>
            /// Log abnormal response messages.
            /// </summary>
            ResponseAbnormal = 64,
        }

        /// <summary>
        /// The request/response types to log.
        /// </summary>
        public LogEventType LogEvents { get; set; }

        /// <summary>Gets or sets the application name which will be used on the User-Agent header.</summary>
        public string ApplicationName { get; set; }

        /// <summary>Constructs a new configurable message handler.</summary>
        public ConfigurableMessageHandler(HttpMessageHandler httpMessageHandler)
            : base(httpMessageHandler)
        {
            // set default values
            FollowRedirect = true;
            IsLoggingEnabled = true;
            LogEvents = LogEventType.RequestUri | LogEventType.ResponseStatus | LogEventType.ResponseAbnormal;
        }

        private void LogHeaders(string initialText, HttpHeaders headers1, HttpHeaders headers2)
        {
            var headers = (headers1 ?? Enumerable.Empty<KeyValuePair<string, IEnumerable<string>>>())
                .Concat(headers2 ?? Enumerable.Empty<KeyValuePair<string, IEnumerable<string>>>()).ToList();
            var args = new object[headers.Count * 2];
            var fmt = new StringBuilder(headers.Count * 32);
            fmt.Append(initialText);
            var argBuilder = new StringBuilder();
            for (int i = 0; i < headers.Count; i++)
            {
                fmt.Append($"\n  [{{{i * 2}}}] '{{{1 + i * 2}}}'");
                args[i * 2] = headers[i].Key;
                argBuilder.Clear();
                args[1 + i * 2] = string.Join("; ", headers[i].Value);
            }
            InstanceLogger.Debug(fmt.ToString(), args);
        }

        private async Task LogBody(string fmtText, HttpContent content)
        {
            // This buffers the body content within the HttpContent if required.
            var bodyBytes = content != null ? await content.ReadAsByteArrayAsync() : new byte[0];
            char[] bodyChars = new char[bodyBytes.Length];
            for (int i = 0; i < bodyBytes.Length; i++)
            {
                var b = bodyBytes[i];
                bodyChars[i] = b >= 32 && b <= 126 ? (char)b : '.';
            }
            InstanceLogger.Debug(fmtText, new string(bodyChars));
        }

        /// <summary>
        /// The main logic of sending a request to the server. This send method adds the User-Agent header to a request
        /// with <see cref="ApplicationName"/> and the library version. It also calls interceptors before each attempt,
        /// and unsuccessful response handler or exception handlers when abnormal response or exception occurred.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var loggable = IsLoggingEnabled && InstanceLogger.IsDebugEnabled;
            string loggingRequestId = "";
            if (loggable)
            {
                loggingRequestId = Interlocked.Increment(ref _loggingRequestId).ToString("X8");
            }

            int triesRemaining = NumTries;
            int redirectRemaining = NumRedirects;

            Exception lastException = null;

            // Set User-Agent header.
            var userAgent = (ApplicationName == null ? "" : ApplicationName + " ") + UserAgentSuffix;
            // TODO: setting the User-Agent won't work on Silverlight. We may need to create a special callback here to 
            // set it correctly.
            request.Headers.Add("User-Agent", userAgent);

            HttpResponseMessage response = null;
            do // While (triesRemaining > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (response != null)
                {
                    response.Dispose();
                    response = null;
                }
                lastException = null;

                // We keep a local list of the interceptors, since we can't call await inside lock.
                List<IHttpExecuteInterceptor> interceptors;
                lock (executeInterceptorsLock)
                {
                    interceptors = executeInterceptors.ToList();
                }
                if (request.Properties.TryGetValue(ExecuteInterceptorKey, out var interceptorsValue) &&
                    interceptorsValue is List<IHttpExecuteInterceptor> perCallinterceptors)
                {
                    interceptors.AddRange(perCallinterceptors);
                }

                // Intercept the request.
                foreach (var interceptor in interceptors)
                {
                    await interceptor.InterceptAsync(request, cancellationToken).ConfigureAwait(false);
                }
                if (loggable)
                {
                    if ((LogEvents & LogEventType.RequestUri) != 0)
                    {
                        InstanceLogger.Debug("Request[{0}] (triesRemaining={1}) URI: '{2}'", loggingRequestId, triesRemaining, request.RequestUri);
                    }
                    if ((LogEvents & LogEventType.RequestHeaders) != 0)
                    {
                        LogHeaders($"Request[{loggingRequestId}] Headers:", request.Headers, request.Content?.Headers);
                    }
                    if ((LogEvents & LogEventType.RequestBody) != 0)
                    {
                        await LogBody($"Request[{loggingRequestId}] Body: '{{0}}'", request.Content);
                    }
                }
                try
                {
                    // Send the request!
                    response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    lastException = ex;
                }

                // Decrease the number of retries.
                if (response == null || ((int)response.StatusCode >= 400 || (int)response.StatusCode < 200))
                {
                    triesRemaining--;
                }

                // Exception was thrown, try to handle it.
                if (response == null)
                {
                    var exceptionHandled = false;

                    // We keep a local list of the handlers, since we can't call await inside lock.
                    List<IHttpExceptionHandler> handlers;
                    lock (exceptionHandlersLock)
                    {
                        handlers = exceptionHandlers.ToList();
                    }
                    if (request.Properties.TryGetValue(ExceptionHandlerKey, out var handlersValue) &&
                        handlersValue is List<IHttpExceptionHandler> perCallHandlers)
                    {
                        handlers.AddRange(perCallHandlers);
                    }

                    // Try to handle the exception with each handler.
                    foreach (var handler in handlers)
                    {
                        exceptionHandled |= await handler.HandleExceptionAsync(new HandleExceptionArgs
                            {
                                Request = request,
                                Exception = lastException,
                                TotalTries = NumTries,
                                CurrentFailedTry = NumTries - triesRemaining,
                                CancellationToken = cancellationToken
                            }).ConfigureAwait(false);
                    }

                    if (!exceptionHandled)
                    {
                        InstanceLogger.Error(lastException,
                            "Response[{0}] Exception was thrown while executing a HTTP request and it wasn't handled", loggingRequestId);
                        throw lastException;
                    }
                    else if (loggable && (LogEvents & LogEventType.ResponseAbnormal) != 0)
                    {
                        InstanceLogger.Debug("Response[{0}] Exception {1} was thrown, but it was handled by an exception handler",
                            loggingRequestId, lastException.Message);
                    }
                }
                else
                {
                    if (loggable)
                    {
                        if ((LogEvents & LogEventType.ResponseStatus) != 0)
                        {
                            InstanceLogger.Debug("Response[{0}] Response status: {1} '{2}'", loggingRequestId, response.StatusCode, response.ReasonPhrase);
                        }
                        if ((LogEvents & LogEventType.ResponseHeaders) != 0)
                        {
                            LogHeaders($"Response[{loggingRequestId}] Headers:", response.Headers, response.Content?.Headers);
                        }
                        if ((LogEvents & LogEventType.ResponseBody) != 0)
                        {
                            await LogBody($"Response[{loggingRequestId}] Body: '{{0}}'", response.Content);
                        }
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        // No need to retry, the response was successful.
                        triesRemaining = 0;
                    }
                    else
                    {
                        bool errorHandled = false;

                        // We keep a local list of the handlers, since we can't call await inside lock.
                        List<IHttpUnsuccessfulResponseHandler> handlers;
                        lock (unsuccessfulResponseHandlersLock)
                        {
                            handlers = unsuccessfulResponseHandlers.ToList();
                        }
                        if (request.Properties.TryGetValue(UnsuccessfulResponseHandlerKey, out var handlersValue) &&
                            handlersValue is List<IHttpUnsuccessfulResponseHandler> perCallHandlers)
                        {
                            handlers.AddRange(perCallHandlers);
                        }

                        // Try to handle the abnormal HTTP response with each handler.
                        foreach (var handler in handlers)
                        {
                            errorHandled |= await handler.HandleResponseAsync(new HandleUnsuccessfulResponseArgs
                                {
                                    Request = request,
                                    Response = response,
                                    TotalTries = NumTries,
                                    CurrentFailedTry = NumTries - triesRemaining,
                                    CancellationToken = cancellationToken
                                }).ConfigureAwait(false);
                        }

                        if (!errorHandled)
                        {
                            if (FollowRedirect && HandleRedirect(response))
                            {
                                if (redirectRemaining-- == 0)
                                {
                                    triesRemaining = 0;
                                }

                                errorHandled = true;
                                if (loggable && (LogEvents & LogEventType.ResponseAbnormal) != 0)
                                {
                                    InstanceLogger.Debug("Response[{0}] Redirect response was handled successfully. Redirect to {1}",
                                        loggingRequestId, response.Headers.Location);
                                }
                            }
                            else
                            {
                                if (loggable && (LogEvents & LogEventType.ResponseAbnormal) != 0)
                                {
                                    InstanceLogger.Debug("Response[{0}] An abnormal response wasn't handled. Status code is {1}",
                                        loggingRequestId, response.StatusCode);
                                }

                                // No need to retry, because no handler handled the abnormal response.
                                triesRemaining = 0;
                            }
                        }
                        else if (loggable && (LogEvents & LogEventType.ResponseAbnormal) != 0)
                        {
                            InstanceLogger.Debug("Response[{0}] An abnormal response was handled by an unsuccessful response handler. " +
                                "Status Code is {1}", loggingRequestId, response.StatusCode);
                        }
                    }
                }
            } while (triesRemaining > 0); // Not a successful status code but it was handled.

            // If the response is null, we should throw the last exception.
            if (response == null)
            {
                InstanceLogger.Error(lastException, "Request[{0}] Exception was thrown while executing a HTTP request", loggingRequestId);
                throw lastException;
            }
            else if (!response.IsSuccessStatusCode && loggable && (LogEvents & LogEventType.ResponseAbnormal) != 0)
            {
                InstanceLogger.Debug("Response[{0}] Abnormal response is being returned. Status Code is {1}", loggingRequestId, response.StatusCode);
            }

            return response;
        }

        /// <summary>
        /// Handles redirect if the response's status code is redirect, redirects are turned on, and the header has
        /// a location.
        /// When the status code is <c>303</c> the method on the request is changed to a GET as per the RFC2616 
        /// specification. On a redirect, it also removes the <c>Authorization</c> and all <c>If-*</c> request headers.
        /// </summary>
        /// <returns> Whether this method changed the request and handled redirect successfully. </returns>
        private bool HandleRedirect(HttpResponseMessage message)
        {
            // TODO(peleyal): think if it's better to move that code to RedirectUnsucessfulResponseHandler
            var uri = message.Headers.Location;
            if (!message.IsRedirectStatusCode() || uri == null)
            {
                return false;
            }

            var request = message.RequestMessage;
            request.RequestUri = new Uri(request.RequestUri, uri);
            // Status code for a resource that has moved to a new URI and should be retrieved using GET.
            if (message.StatusCode == HttpStatusCode.SeeOther)
            {
                request.Method = HttpMethod.Get;
            }
            // Clear Authorization and If-* headers.
            request.Headers.Remove("Authorization");
            request.Headers.IfMatch.Clear();
            request.Headers.IfNoneMatch.Clear();
            request.Headers.IfModifiedSince = null;
            request.Headers.IfUnmodifiedSince = null;
            request.Headers.Remove("If-Range");
            return true;
        }
    }
}
