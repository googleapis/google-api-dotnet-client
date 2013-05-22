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
using System.Net.Http;
using System.Text;

namespace Google.Apis.Http
{
    /// <summary> 
    /// Unsuccessful response handler which is invoked when an abnormal Http response is returned when sending an Http 
    /// request.
    /// </summary>
    public interface IHttpUnsuccessfulResponseHandler
    {
        /// <summary>
        /// Handles an abnormal response when sending an Http request. 
        /// A simple rule must be followed, if you modify the request object in a way that the abnormal response can 
        /// be resolved, you must return <c>true</c>.
        /// </summary>
        /// <param name="request">The sent request</param>
        /// <param name="response">The abnormal response</param>
        /// <param name="supportsRetry">Whether there will actually be a retry if this handler returns <c>true</c>
        /// </param>
        /// <returns>Whether or not this handler has made a change that will require the request to be resent</returns>
        bool HandleResponse(HttpRequestMessage request, HttpResponseMessage response, bool supportsRetry);
    }
}
