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

namespace Google.Apis.Http
{
    /// <summary>
    /// This message handler contains the main logic of our Http requests. It contains a list of 
    /// <see cref="IHttpUnsuccessfulResponseHandler"/>s for handling abnormal responses, a list of 
    /// <see cref="IHttpExceptionHandler"/>s for handling exception in a request and a list of 
    /// <see cref="IHttpExecuteInterceptor"/>s for intercepting a request before it has been sent to the server.
    /// It also contains important properties like num of retires, follow redirect, etc.
    /// </summary>
    public class ConfigurableMessageHandler : DelegatingHandler
    {
        /// <summary> The class logger. </summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ConfigurableMessageHandler>();

        /// <summary> Maximum allowed number of tries. </summary>
        [VisibleForTestOnly]
        internal const int MaxAllowedNumTries = 20;

        /// <summary> The current API version of this client library. </summary>
        private static readonly string ApiVersion = Utilities.GetLibraryVersion();

        /// <summary> The User-Agent suffix header which contains the <seealso cref="ApiVersion"/>. </summary>
        private static readonly string UserAgentSuffix = "google-api-dotnet-client/" + ApiVersion + " (gzip)";

        #region IHttpUnsuccessfulResponseHandler, IHttpExceptionHandler and IHttpExecuteInterceptor lists

        /// <summary> A list of <see cref="IHttpUnsuccessfulResponseHandler"/>. </summary>
        private readonly IList<IHttpUnsuccessfulResponseHandler> unsuccessfulResponseHandlers =
            new List<IHttpUnsuccessfulResponseHandler>();

        /// <summary> A list of <see cref="IHttpExceptionHandler"/>. </summary>
        private readonly IList<IHttpExceptionHandler> exceptionHandlers =
            new List<IHttpExceptionHandler>();

        /// <summary> A list of <see cref="IHttpExecuteInterceptor"/>. </summary>
        private readonly IList<IHttpExecuteInterceptor> executeInterceptors =
            new List<IHttpExecuteInterceptor>();

        /// <summary> Gets a list of <see cref="IHttpUnsuccessfulResponseHandler"/>. </summary>
        public IList<IHttpUnsuccessfulResponseHandler> UnsuccessfulResponseHandlers
        {
            get { return unsuccessfulResponseHandlers; }
        }

        /// <summary> Gets a list of <see cref="IHttpExceptionHandler"/>. </summary>
        public IList<IHttpExceptionHandler> ExceptionHandlers
        {
            get { return exceptionHandlers; }
        }

        /// <summary> Gets a list of <see cref="IHttpExecuteInterceptor"/>. </summary>
        public IList<IHttpExecuteInterceptor> ExecuteInterceptors
        {
            get { return executeInterceptors; }
        }

        #endregion

        /// <summary> Number of tries. Default is <c>10</c>. </summary>
        private int numTries = 10;

        /// <summary> 
        /// Gets or sets the number of tries that will be allowed to execute. Retries occur as a result of either
        /// <see cref="IHttpUnsuccessfulResponseHandler"/> or <see cref="IHttpExceptionHandler"/> which handles the
        /// abnormal Http response or exception, before being terminated. 
        /// Set <c>1</c> for not retrying requests. The default value is <c>10</c>".
        /// </summary>
        public int NumTries
        {
            get { return numTries; }
            set
            {
                if (value > MaxAllowedNumTries || value < 1)
                {
                    throw new ArgumentOutOfRangeException("NumRetries");
                }
                numTries = value;
            }
        }

        /// <summary> 
        /// Gets or sets whether the handler should follow a redirect when a redirect response is received. Default 
        /// value is <c>true</c>.
        /// </summary>
        public bool FollowRedirect { get; set; }

        /// <summary> Gets or sets whether logging is enabled. Default value is <c>true</c>. </summary>
        public bool IsLoggingEnabled { get; set; }

        /// <summary> Gets or sets the application name which will be used on the User-Agent header. </summary>
        public string ApplicationName { get; set; }

        /// <summary> Constructs a new configurable message handler </summary>
        public ConfigurableMessageHandler(HttpMessageHandler httpMessageHandler)
            : base(httpMessageHandler)
        {
            // set default values
            FollowRedirect = true;
            IsLoggingEnabled = true;
        }

        /// <summary>
        /// The main logic of sending a request to the server. This send method adds the User-Agent header to a request
        /// with <see cref="ApplicationName"/> and the library version. It also calls interceptors before each attempt,
        /// and unsuccessful response handler or exception handlers when abnormal response or exception occurred.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var loggable = IsLoggingEnabled && Logger.IsDebugEnabled;

            int triesRemaining = NumTries;
            Exception lastException = null;

            // set User-Agent header
            var userAgent = (ApplicationName == null ? "" : ApplicationName + " ") + UserAgentSuffix;
            // TODO: setting the User-Agent won't work on Silverlight. We may need to create a special callback here to 
            // set it correctly. Also check what happen in WP?
            request.Headers.Add("User-Agent", userAgent);

            HttpResponseMessage response = null;
            do // while (triesRemaining > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (response != null)
                {
                    response.Dispose();
                    response = null;
                }
                lastException = null;

                // intercept the request
                // TODO(peleyal): rethink if each execute interceptor should be implemented as DelegateHandler, and 
                // then remove this execute interceptor!
                foreach (var interceptor in executeInterceptors)
                {
                    interceptor.Intercept(request);
                }

                try
                {
                    // send the request!
                    response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    lastException = ex;
                }

                // decrease the number of retries
                triesRemaining--;

                // exception was thrown , try to handle it
                if (response == null)
                {
                    var exceptionHandled = false;

                    // try to handle the exception with each handler
                    foreach (var handler in exceptionHandlers)
                    {
                        exceptionHandled |= handler.HandleException(new HandleExceptionArgs
                            {
                                Request = request,
                                Exception = lastException,
                                TotalTries = NumTries,
                                CurrentFailedTry = NumTries - triesRemaining,
                                CancellationToken = cancellationToken
                            });
                    }

                    if (!exceptionHandled)
                    {
                        Logger.Error(lastException,
                            "Exception was thrown while executing an Http request and it wasn't handled");
                        throw lastException;
                    }
                    else if (loggable)
                    {
                        Logger.Debug("Exception {0} was thrown, but it was handled by an exception handler",
                            lastException.Message);
                    }
                }
                else
                {
                    if (response.IsSuccessStatusCode)
                    {
                        // no need to retry, the response was successful
                        triesRemaining = 0;
                    }
                    else
                    {
                        bool errorHandled = false;

                        // try to handle the abnormal Http response with each handler
                        foreach (var handler in unsuccessfulResponseHandlers)
                        {
                            errorHandled |= handler.HandleResponse(new HandleUnsuccessfulResponseArgs
                                {
                                    Request = request,
                                    Response = response,
                                    TotalTries = NumTries,
                                    CurrentFailedTry = NumTries - triesRemaining,
                                    CancellationToken = cancellationToken
                                });
                        }

                        if (!errorHandled)
                        {
                            if (HandleRedirect(response))
                            {
                                errorHandled = true;
                                if (loggable)
                                {
                                    Logger.Debug("Redirect response was handled successfully. Redirect to {0}",
                                        response.Headers.Location);
                                }
                            }
                            else
                            {
                                if (loggable)
                                {
                                    Logger.Debug("An abnormal response wasn't handled. Status code is {0}",
                                        response.StatusCode);
                                }

                                // no need to retry, because no handler handled the abnormal response
                                triesRemaining = 0;
                            }
                        }
                        else if (loggable)
                        {
                            Logger.Debug("An abnormal response was handled by an unsuccessful response handler. " +
                                "Status Code is {0}", response.StatusCode);
                        }
                    }
                }
            } while (triesRemaining > 0); // not a success status code but it was handled

            // if the response is null, we should throw the last exception
            if (response == null)
            {
                Logger.Error(lastException, "Exception was thrown while executing an Http request");
                throw lastException;
            }
            else if (!response.IsSuccessStatusCode)
            {
                Logger.Debug("Abnormal response is being returned. Status Code is {0}", response.StatusCode);
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
            if (!message.IsRedirectStatusCode() || !FollowRedirect || uri == null)
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
            // clear Authorization and If-* headers
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
