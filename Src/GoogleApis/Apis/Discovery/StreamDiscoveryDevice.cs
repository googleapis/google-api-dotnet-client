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

using System.IO;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// The discovery document will be passed in as a Stream.
    /// </summary>
    public class StreamDiscoveryDevice : IDiscoveryDevice
    {
        /// <summary>
        /// The stream that will contain the discovery data.
        /// </summary>
        public Stream DiscoveryStream { get; set; }

        #region IDiscoveryDevice Members

        /// <summary>
        /// Fetches the discovery document from a user defined stream.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/>
        /// </returns>
        public Stream Fetch()
        {
            return DiscoveryStream;
        }

        public void Dispose()
        {
            if (DiscoveryStream != null)
            {
                DiscoveryStream.Dispose();
            }
        }

        #endregion
    }
}