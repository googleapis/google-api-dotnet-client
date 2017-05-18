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

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Http
{
    /// <summary>Argument class to <see cref="IHttpUnsuccessfulResponseHandler.HandleResponseAsync"/>.</summary>
    public class HandleUnsuccessfulResponseArgs
    {
        /// <summary>Gets or sets the sent request.</summary>
        public HttpRequestMessage Request { get; set; }

        /// <summary>Gets or sets the abnormal response.</summary>
        public HttpResponseMessage Response { get; set; }

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

    /// <summary>
    /// Unsuccessful response handler which is invoked when an abnormal HTTP response is returned when sending a HTTP
    /// request.
    /// </summary>
    public interface IHttpUnsuccessfulResponseHandler
    {
        /// <summary>
        /// Handles an abnormal response when sending a HTTP request. 
        /// A simple rule must be followed, if you modify the request object in a way that the abnormal response can 
        /// be resolved, you must return <c>true</c>.
        /// </summary>
        /// <param name="args">
        /// Handle response argument which contains properties such as the request, response, current failed try.
        /// </param>
        /// <returns>Whether this handler has made a change that requires the request to be resent.</returns>
        Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args);
    }
}
