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
using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Defines the factory parameters which are used to create a v1.0 Service
    /// </summary>
    public class FactoryParameterV1_0 : BaseFactoryParameters
    {
        public FactoryParameterV1_0() {}

        /// <summary>
        /// Creates a new v1.0 factory parameter by splitting the specified service URI into ServerUrl and BasePath
        /// </summary>
        public FactoryParameterV1_0(Uri serviceUri) : base(serviceUri) {}

        /// <summary>
        /// Creates a parameter set for a v1.0 service
        /// </summary>
        /// <param name="serverUrl">The absolute URL pointing to the server on which the service resides</param>
        public FactoryParameterV1_0(string serverUrl) : base(serverUrl) {}

        /// <summary>
        /// Creates a parameter set for a v1.0 service
        /// </summary>
        /// <param name="serverUrl">The absolute URL pointing to the server on which the service resides</param>
        /// <param name="basePath">The relative path to the service on the server</param>
        public FactoryParameterV1_0(string serverUrl, string basePath) : base(serverUrl, basePath) {}
    }

    /// <summary>
    ///   Defines the factory parameters which are used to create a v0.3 Service
    /// </summary>
    public class FactoryParameterV0_3 : BaseFactoryParameters
    {
        public FactoryParameterV0_3() {}

        /// <summary>
        /// Creates a new v0.3 factory parameter by splitting the specified service URI into ServerUrl and BasePath
        /// </summary>
        public FactoryParameterV0_3(Uri serviceUri) : base(serviceUri) {}

        /// <summary>
        /// Creates a parameter set for a v0.3 service
        /// </summary>
        /// <param name="serverUrl">The absolute URL pointing to the server on which the service resides</param>
        public FactoryParameterV0_3(string serverUrl) : base(serverUrl) {}

        /// <summary>
        /// Creates a parameter set for a v0.3 service
        /// </summary>
        /// <param name="serverUrl">The absolute URL pointing to the server on which the service resides</param>
        /// <param name="basePath">The relative path to the service on the server</param>
        public FactoryParameterV0_3(string serverUrl, string basePath) : base(serverUrl, basePath) {}
    }

    /// <summary>
    /// Defines the base factory parameters which are used to create a service
    /// </summary>
    public abstract class BaseFactoryParameters : IFactoryParameter
    {
        /// <summary>
        /// The default server URL used
        /// Points to the Google API repository
        /// </summary>
        public const string DefaultServerUrl = "https://www.googleapis.com";

        /// <summary>
        /// Creates a new factory parameter for a service
        /// Sets the server url to the default google url
        /// </summary>
        protected BaseFactoryParameters()
        {
            ServerUrl = DefaultServerUrl;
        }

        /// <summary>
        /// Creates a new factory parameter by splitting the specified service URI into ServerUrl and BasePath
        /// </summary>
        protected BaseFactoryParameters(Uri serviceUri)
        {
            serviceUri.ThrowIfNull("serviceUri");

            // Retrieve Scheme and Host
            ServerUrl = serviceUri.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped);
            ServerUrl.ThrowIfNullOrEmpty("ServerUrl");

            // Retrieve the remaining right part
            BasePath = serviceUri.GetComponents(UriComponents.PathAndQuery, UriFormat.UriEscaped);
            ServerUrl.ThrowIfNullOrEmpty("BasePath");
        }

        /// <summary>
        /// Creates a new factory parameter for a service
        /// </summary>
        protected BaseFactoryParameters(string serverUrl)
        {
            serverUrl.ThrowIfNullOrEmpty("serverUrl");
            ServerUrl = serverUrl;
        }

        /// <summary>
        /// Creates a new factory parameter for a service
        /// </summary>
        /// <param name="serverUrl">URL of this service</param>
        /// <param name="basePath">Base path to the service</param>
        protected BaseFactoryParameters(string serverUrl, string basePath) : this(serverUrl)
        {
            BasePath = basePath;
        }

        /// <summary>
        /// The absolute server URL
        /// </summary>
        public string ServerUrl { get; set; }

        /// <summary>
        /// The relative base path
        /// </summary>
        public string BasePath { get; set; }
    }

    /// <summary>
    /// A Factory used by discovery to create v1.0 Services
    /// </summary>
    internal class ServiceFactoryDiscoveryV1_0 : BaseServiceFactory
    {
        public ServiceFactoryDiscoveryV1_0(JsonDictionary discovery, FactoryParameterV1_0 param)
            : base(discovery, param) {}

        public override IService GetService()
        {
            return new ServiceV1_0((FactoryParameterV1_0) Param, Information);
        }
    }

    /// <summary>
    ///   A Factory used by discovery to create v0.3 Services
    /// </summary>
    internal class ServiceFactoryDiscoveryV0_3 : BaseServiceFactory
    {
        public ServiceFactoryDiscoveryV0_3(JsonDictionary discovery, FactoryParameterV0_3 param)
            : base(discovery, param) {}

        public override IService GetService()
        {
            return new ServiceV0_3((FactoryParameterV0_3) Param, Information);
        }
    }

    /// <summary>
    ///   An abstract version independent implementation of a service factory
    /// </summary>
    internal abstract class BaseServiceFactory : IServiceFactory
    {
        protected BaseServiceFactory(JsonDictionary discovery, BaseFactoryParameters param)
        {
            discovery.ThrowIfNullOrEmpty("discovery");
            param.ThrowIfNull("param");

            Name = discovery.GetMandatoryValue<string>("name");
            if (Name.IsNullOrEmpty())
            {
                throw new ArgumentException("No service name found in the JsonDictionary");
            }

            Information = discovery;
            Param = param;
        }

        [VisibleForTestOnly]
        internal JsonDictionary Information { get; private set; }

        [VisibleForTestOnly]
        internal BaseFactoryParameters Param { get; private set; }

        [VisibleForTestOnly]
        internal string Name { get; private set; }

        #region IServiceFactory Members

        public abstract IService GetService();

        #endregion
    }
}