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
        internal const int MaxAllowedNumTries = 20;

        /// <summary>The current API version of this client library.</summary>
        private static readonly string ApiVersion = Google.Apis.Util.Utilities.GetLibraryVersion();

        /// <summary>The User-Agent suffix header which contains the <see cref="ApiVersion"/>.</summary>
        private static readonly string UserAgentSuffix = "google-api-dotnet-client/" + ApiVersion + " (gzip)";

        #region IHttpUnsuccessfulResponseHandler, IHttpExceptionHandler and IHttpExecuteInterceptor lists

        /// <summary>A list of <see cref="IHttpUnsuccessfulResponseHandler"/>.</summary>
        private readonly IList<IHttpUnsuccessfulResponseHandler> unsuccessfulResponseHandlers =
            new List<IHttpUnsuccessfulResponseHandler>();

        /// <summary>A list of <see cref="IHttpExceptionHandler"/>.</summary>
        private readonly IList<IHttpExceptionHandler> exceptionHandlers =
            new List<IHttpExceptionHandler>();

        /// <summary>A list of <see cref="IHttpExecuteInterceptor"/>.</summary>
        private readonly IList<IHttpExecuteInterceptor> executeInterceptors =
            new List<IHttpExecuteInterceptor>();

        /// <summary>Gets a list of <see cref="IHttpUnsuccessfulResponseHandler"/>.</summary>
        public IList<IHttpUnsuccessfulResponseHandler> UnsuccessfulResponseHandlers
        {
            get { return unsuccessfulResponseHandlers; }
        }

        /// <summary>Gets a list of <see cref="IHttpExceptionHandler"/>.</summary>
        public IList<IHttpExceptionHandler> ExceptionHandlers
        {
            get { return exceptionHandlers; }
        }

        /// <summary>Gets a list of <see cref="IHttpExecuteInterceptor"/>.</summary>
        public IList<IHttpExecuteInterceptor> ExecuteInterceptors
        {
            get { return executeInterceptors; }
        }

        #endregion

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

        /// <summary>Gets or sets the application name which will be used on the User-Agent header.</summary>
        public string ApplicationName { get; set; }

        /// <summary>Constructs a new configurable message handler.</summary>
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

                // Intercept the request.
                foreach (var interceptor in executeInterceptors)
                {
                    await interceptor.InterceptAsync(request, cancellationToken).ConfigureAwait(false);
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

                    // Try to handle the exception with each handler.
                    foreach (var handler in exceptionHandlers)
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
                        Logger.Error(lastException,
                            "Exception was thrown while executing a HTTP request and it wasn't handled");
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
                        // No need to retry, the response was successful.
                        triesRemaining = 0;
                    }
                    else
                    {
                        bool errorHandled = false;

                        // Try to handle the abnormal HTTP response with each handler.
                        foreach (var handler in unsuccessfulResponseHandlers)
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

                                // No need to retry, because no handler handled the abnormal response.
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
            } while (triesRemaining > 0); // Not a successful status code but it was handled.

            // If the response is null, we should throw the last exception.
            if (response == null)
            {
                Logger.Error(lastException, "Exception was thrown while executing a HTTP request");
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
