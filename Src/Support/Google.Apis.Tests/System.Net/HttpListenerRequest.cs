/*
Copyright 2017 Google Inc

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

#if NETCOREAPP1_0 || NETCOREAPP1_1

using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace System.Net
{
    public class HttpListenerRequest
    {
        internal static async Task<HttpListenerRequest> Build(Stream stream)
        {
            var bytes = new AsyncStream(stream);
            // Read line 0
            var requestLineParts = (await bytes.ReadLine().ConfigureAwait(false)).Trim().Split(' ');
            if (requestLineParts.Length != 3)
            {
                throw new InvalidOperationException("First HTTP line incorrectly formatted");
            }
            if (requestLineParts[2] != "HTTP/1.1")
            {
                throw new InvalidOperationException("Line 0 must start with HTTP/1.1");
            }
            var path = requestLineParts[1];
            // Read headers
            NameValueCollection headers = new NameValueCollection();
            while (true)
            {
                var line = (await bytes.ReadLine().ConfigureAwait(false)).Trim();
                if (line == "")
                {
                    break;
                }
                int colonPos = line.IndexOf(':');
                if (colonPos < 0)
                {
                    throw new InvalidOperationException("Invalid header");
                }
                var name = line.Substring(0, colonPos).Trim();
                var value = line.Substring(colonPos + 1).Trim();
                headers.Add(name, value);
            }
            // Create url
            var url = new Uri($"http://{headers["Host"]}{path}");
            // Handle query-string
            NameValueCollection queryString = new NameValueCollection();
            var queryPos = path.IndexOf('?');
            if (queryPos >= 0)
            {
                var queries = path.Substring(queryPos + 1).Split('&');
                foreach (var query in queries)
                {
                    var queryParts = query.Split(new[] { '=' }, 2);
                    queryString.Add(queryParts[0], queryParts.Length == 1 ? "" : queryParts[1]);
                }
            }
            // Handle contentLength
            long contentLength = -1;
            if (headers.AllKeys.Contains("Content-Length"))
            {
                contentLength = long.Parse(headers["Content-Length"]);
            }
            // Get body
            var bodyStream = new MemoryStream();
            if (contentLength >= 0)
            {
                var bodyBytes = await bytes.ReadCount((int)contentLength).ConfigureAwait(false);
                bodyStream = new MemoryStream(bodyBytes.ToArray());
            }
            return new HttpListenerRequest(url, queryString, headers, contentLength, bodyStream);
        }

        public HttpListenerRequest(Uri url, NameValueCollection queryString, NameValueCollection headers, long contentLength64, Stream inputStream)
        {
            Url = url;
            QueryString = queryString;
            Headers = headers;
            ContentLength64 = contentLength64;
            InputStream = inputStream;
        }

        public Uri Url { get; }
        public NameValueCollection QueryString { get; }
        public NameValueCollection Headers { get; }
        public long ContentLength64 { get; }

        public Stream InputStream { get; }
    }
}

#elif NET452 || NET46
// Nothing required
#else
#error Unsupported platform
#endif
