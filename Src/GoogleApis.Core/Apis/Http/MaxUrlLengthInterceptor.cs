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
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Testing;

namespace Google.Apis.Http
{
    /// <summary>
    /// Intercepts HTTP GET requests with a URLs longer than a specified maximum number of characters.
    /// The interceptor will change such requests as follows:
    /// <list type="bullet">
    /// <item>The request's method will be changed to POST</item>
    /// <item>A <c>X-HTTP-Method-Override</c> header will be added with the value <c>GET</c></item>
    /// <item>Any query parameters from the URI will be moved into the body of the request.</item>
    /// <item>If query parameters are moved, the content type is set to <c>application/x-www-form-urlencoded</c></item>
    /// </list>
    /// </summary>
    [VisibleForTestOnly]
    internal class MaxUrlLengthInterceptor : IHttpExecuteInterceptor
    {
        private readonly uint maxUrlLength;

        ///<summary>Constructs a new Max URL length interceptor with the given max length.</summary>
        public MaxUrlLengthInterceptor(uint maxUrlLength)
        {
            this.maxUrlLength = maxUrlLength;
        }

        public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Method != HttpMethod.Get || request.RequestUri.AbsoluteUri.Length <= maxUrlLength)
            {
                return TaskEx.Delay(0);
            }
            // Change the method to POST.
            request.Method = HttpMethod.Post;
            var query = request.RequestUri.Query;
            if (!String.IsNullOrEmpty(query))
            {
                // Move query parameters to the body (without the "?").
                request.Content = new StringContent(query.Substring(1));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                var requestString = request.RequestUri.ToString();
                // The new request URI is the old one minus the "?" and everything that follows, since we moved the
                // query params to the body. For example: "www.example.com/?q=foo" => "www.example.com/".
                request.RequestUri = new Uri(requestString.Remove(requestString.IndexOf("?")));
            }
            request.Headers.Add("X-HTTP-Method-Override", "GET");
            return TaskEx.Delay(0);
        }
    }
}
