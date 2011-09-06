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
using System.IO;
using System.Net;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// WebDiscoveryDevice allows clients to fetch discovery documents from a web based service.
    /// </summary>
    public class WebDiscoveryDevice : IDiscoveryDevice
    {
        public WebDiscoveryDevice()
        {
            TimeoutInSeconds = 30;
        }

        public WebDiscoveryDevice(Uri discoveryUri) : this()
        {
            DiscoveryUri = discoveryUri;
        }

        /// <summary>
        /// The URI of the discovery document
        /// </summary>
        public Uri DiscoveryUri { get; set; }

        /// <summary>
        /// The fetch timeout of this request (in seconds)
        /// </summary>
        public int TimeoutInSeconds { get; set; }

        private Stream responseStream { get; set; }
        private HttpWebResponse response { get; set; }

        #region IDiscoveryDevice Members

        /// <summary>
        /// Fetches the discovery document from a Webserver using HttpWebRequest.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/>
        /// </returns>
        public Stream Fetch()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(DiscoveryUri);

            // The timeout property is only supported on regular .NET.
#if !SILVERLIGHT
            request.Timeout = TimeoutInSeconds * 1000;
#endif

            IAsyncResult async = request.BeginGetResponse(null, null);
            response = (HttpWebResponse) request.EndGetResponse(async);
            Stream responseData = response.GetResponseStream();

            return responseData;
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            if (responseStream != null)
            {
                responseStream.Dispose();
            }
        }

        #endregion
    }
}