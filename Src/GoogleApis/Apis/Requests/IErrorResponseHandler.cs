/*
Copyright 2011 Google Inc

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

using System.Net;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents a class able to handle error responses.
    /// Can be used by authenticators to fix/reauthenticate requests.
    /// </summary>
    public interface IErrorResponseHandler
    {
        /// <summary>
        /// Returns true if this handler can handle the specified error.
        /// </summary>
        /// <param name="exception">The exception thrown while parsing the response.</param>
        /// <param name="error">Additional information about the error. Might be null.</param>
        /// <returns>True if this handler can handle the error.</returns>
        bool CanHandleErrorResponse(WebException exception, RequestError error);

        /// <summary>
        /// A method which should try to handle the error response by fixing the specified request.
        /// It will be called once the new webrequest is created.
        /// </summary>
        /// <param name="exception">The exception which was thrown by the service.</param>
        /// <param name="error">Additional information about the error which occured. Might be null.</param>
        /// <param name="request">The new WebRequest, which will be executed after the handler has run.</param>
        void HandleErrorResponse(WebException exception, RequestError error, WebRequest request);
    }
}
