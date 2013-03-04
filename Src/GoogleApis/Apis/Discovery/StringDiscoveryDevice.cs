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
using System.Text;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Hosts the DiscoveryDocument in a user defined stream.
    /// 
    /// Handy for testing.
    /// </summary>
    public class StringDiscoveryDevice : IDiscoveryDevice
    {
        /// <summary>
        /// The discovery document.
        /// </summary>
        public String Document { get; set; }

        private Stream outputStream { get; set; }

        /// <summary>
        /// Creates a new StringDiscoveryDevice.
        /// </summary>
        public StringDiscoveryDevice() {}

        /// <summary>
        /// Creates a new StringDiscoveryDevice.
        /// </summary>
        /// <param name="document">The string containing the discovery document</param>
        public StringDiscoveryDevice(string document)
        {
            Document = document;
        }

        #region IDiscoveryDevice Members

        /// <summary>
        /// Fetches the Discovery Document from an user supplied string
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/>
        /// </returns>
        public Stream Fetch()
        {
            byte[] text = Encoding.UTF8.GetBytes(Document);
            outputStream = new MemoryStream(text);
            return outputStream;
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            if (outputStream != null)
            {
                outputStream.Dispose();
            }
        }

        #endregion
    }
}