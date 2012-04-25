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

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Discovery is the root of all access to the APIs.
    /// 
    /// At a high-level it is a factory to create an API object for a given discovery document.
    /// 
    ///
    /// </summary>
    /// <example>
    ///     <code>
    /// var webDiscovery = new WebDiscoveryDevice { DiscoveryURI = "http://test.com"};
    /// var d = new Discover(webDiscovery);
    /// var buzzApi = d.CreateAPI();
    /// 
    /// var buzzFeed = buzzApi.WithCredentials().On().Get(Dictionary());
    /// 
    /// // If you want to host your own Apiary discovery document, you can use the FileDiscoveryDecive
    /// var fileDiscovery = new FileDiscoveryDevice { DiscoveryFile = "c:/text.txt"};
    /// var d = new Discover(fileDiscovery);
    /// var buzzApi = d.CreateAPI();
    /// 
    /// var buzzFeed = buzzApi.CreateRequest().WithCredentials().On().Get(Dictionary());
    /// 
    /// // If you want to host your own Apiary discovery document, you can also use the StreamDiscoveryDevice
    /// var streamDiscovery = new StreamDiscoveryDevice { DiscoveryStream = new FileStream("c:/test.txt") };
    /// var d = new Discover(streamDiscovery);
    /// var buzzApi = d.CreateAPI();
    /// 
    /// var buzzFeed = buzzApi.WithCredentials().On().Get(Dictionary());
    ///     </code>
    /// </example>
    public class DiscoveryService : IDiscoveryService
    {
        /// <summary>
        /// Insantiates the discovery class
        /// </summary>
        public DiscoveryService(IDiscoveryDevice discovery)
        {
            DiscoveryDevice = discovery;
        }

        /// <summary>
        /// The discovery mechanism to use.
        /// </summary>
        public IDiscoveryDevice DiscoveryDevice { get; private set; }

        #region IDiscoveryService Members

        /// <summary>
        /// Create a service object for a specific version of discovery.
        /// </summary>
        /// <param name="version">Version of discovery to use.</param>
        /// <returns></returns>
        public IService GetService(DiscoveryVersion version)
        {
            return this.GetService(version, null);
        }


        /// <summary>
        /// Create a service object for a specific version of discovery.
        /// </summary>
        /// <param name="version">Version of discovery to use.</param>
        /// <param name="param">Parameters intended to initialize the factory.</param>
        /// <returns></returns>
        public IService GetService(DiscoveryVersion version, FactoryParameters param)
        {
            var factory = ServiceFactory.Get(version);
            using (var documentStream = DiscoveryDevice.Fetch())
            {
                // Parse the document.
                var dictionary = Json.JsonReader.Parse(documentStream) as Json.JsonDictionary;
                return factory.CreateService(dictionary, param);
            }
        }

        #endregion
    }
}