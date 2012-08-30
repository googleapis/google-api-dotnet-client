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

using System.IO;
using System.Net;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// A standard web response to a request. 
    /// Used to return the response stream and additional details about the response.
    /// </summary>
    public class Response : IResponse
    {
        private const string ETagResponseHeader = "ETag";
        private readonly WebResponse innerResponse;
        private Stream responseStream;

        /// <summary>
        /// Creates a new response encapsulating the webresponse specified.
        /// </summary>
        public Response(WebResponse innerResponse)
        {
            innerResponse.ThrowIfNull("innerResponse");
            this.innerResponse = innerResponse;
        }

        public Stream Stream
        {
            get { return responseStream ?? (responseStream = innerResponse.GetResponseStream()); }
        }

        public string ETag
        {
            get { return innerResponse.Headers[ETagResponseHeader]; }
        }
    }

    public static class ResponseExtensions
    {
        public static string ReadToEnd(this IResponse response)
        {
            using (var stream = new StreamReader(response.Stream))
            {
                return stream.ReadToEnd();
            }
        }
    }
}
