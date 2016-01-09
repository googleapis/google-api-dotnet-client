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

using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Ionic.Zlib;

using Google.Apis.Services;

namespace Google.Apis.Requests
{
    /// <summary>Extension methods to <see cref="System.Net.Http.HttpRequestMessage"/>.</summary>
    static class HttpRequestMessageExtenstions
    {
        /// <summary>
        /// Sets the content of the request by the given body and the the required GZip configuration.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="service">The service.</param>
        /// <param name="body">The body of the future request. If <c>null</c> do nothing.</param>
        /// <param name="gzipEnabled">
        /// Indicates if the content will be wrapped in a GZip stream, or a regular string stream will be used.
        /// </param>
        internal static void SetRequestSerailizedContent(this HttpRequestMessage request,
            IClientService service, object body, bool gzipEnabled)
        {
            if (body == null)
            {
                return;
            }
            HttpContent content = null;

            var mediaType = "application/" + service.Serializer.Format;
            var serializedObject = service.SerializeObject(body);
            if (gzipEnabled)
            {
                content = CreateZipContent(serializedObject);
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType)
                {
                    CharSet = Encoding.UTF8.WebName
                };
            }
            else
            {
                content = new StringContent(serializedObject, Encoding.UTF8, mediaType);
            }

            request.Content = content;
        }

        /// <summary>Creates a GZip content based on the given content.</summary>
        /// <param name="content">Content to GZip.</param>
        /// <returns>GZiped HTTP content.</returns>
        internal static HttpContent CreateZipContent(string content)
        {
            var stream = CreateGZipStream(content);
            var sc = new StreamContent(stream);
            sc.Headers.ContentEncoding.Add("gzip");
            return sc;
        }

        /// <summary>Creates a GZip stream by the given serialized object.</summary>
        private static Stream CreateGZipStream(string serializedObject)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(serializedObject);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress, true))
                {
                    gzip.Write(bytes, 0, bytes.Length);
                }

                // Reset the stream to the beginning. It doesn't work otherwise!
                ms.Position = 0;
                byte[] compressed = new byte[ms.Length];
                ms.Read(compressed, 0, compressed.Length);
                return new MemoryStream(compressed);
            }
        }
    }
}
