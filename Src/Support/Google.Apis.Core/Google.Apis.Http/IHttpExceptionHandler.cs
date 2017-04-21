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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>Argument class to <see cref="IHttpExceptionHandler.HandleExceptionAsync"/>.</summary>
    public class HandleExceptionArgs
    {
        /// <summary>Gets or sets the sent request.</summary>
        public HttpRequestMessage Request { get; set; }

        /// <summary>Gets or sets the exception which occurred during sending the request.</summary>
        public Exception Exception { get; set; }

        /// <summary>Gets or sets the total number of tries to send the request.</summary>
        public int TotalTries { get; set; }

        /// <summary>Gets or sets the current failed try.</summary>
        public int CurrentFailedTry { get; set; }

        /// <summary>Gets an indication whether a retry will occur if the handler returns <c>true</c>.</summary>
        public bool SupportsRetry
        {
            get { return TotalTries - CurrentFailedTry > 0; }
        }

        /// <summary>Gets or sets the request's cancellation token.</summary>
        public CancellationToken CancellationToken { get; set; }
    }

    /// <summary>Exception handler is invoked when an exception is thrown during a HTTP request.</summary>
    public interface IHttpExceptionHandler
    {
        /// <summary>
        /// Handles an exception thrown when sending a HTTP request. 
        /// A simple rule must be followed, if you modify the request object in a way that the exception can be 
        /// resolved, you must return <c>true</c>.
        /// </summary>
        /// <param name="args">
        /// Handle exception argument which properties such as the request, exception, current failed try.
        /// </param>
        /// <returns>Whether this handler has made a change that requires the request to be resent.</returns>
        Task<bool> HandleExceptionAsync(HandleExceptionArgs args);
    }
}
