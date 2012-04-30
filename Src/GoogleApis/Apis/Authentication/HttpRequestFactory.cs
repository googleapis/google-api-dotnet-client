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
using System.Net;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// Use the Create method to create HttpWebRequests given a Uri.
    /// </summary>
    public class HttpRequestFactory : ICreateHttpRequest
    {
        #region ICreateHttpRequest Members

        public HttpWebRequest Create(Uri target, string method)
        {
            var req = WebRequest.Create(target) as HttpWebRequest;
            req.Method = method;

#if !SILVERLIGHT
            // Turn off Expect100Continue behavior. For web method calls it is not used
            // and many servers reject the request if this is present on PUT or POST 
            // requests with a body present. If used, Expect100Continue prevents the client
            // from sending the request body unless the server approves the request by sending
            // Expect100Continue.
            req.ServicePoint.Expect100Continue = false;
#endif

            return req;
        }

        #endregion

        /// <summary>
        /// Gets an instance of HttpRequestFactory (immutable)
        /// </summary>
        public static HttpRequestFactory Instance { get { return new HttpRequestFactory(); } }
    }
}