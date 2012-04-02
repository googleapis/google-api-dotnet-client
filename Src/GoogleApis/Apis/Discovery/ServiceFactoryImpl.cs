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
    /// Defines the base factory parameters which are used to create a service
    /// </summary>
    public class FactoryParameters
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
        public FactoryParameters()
        {
            ServerUrl = DefaultServerUrl;
        }

        /// <summary>
        /// Creates a new factory parameter by splitting the specified service URI into ServerUrl and BasePath
        /// </summary>
        public FactoryParameters(Uri serviceUri)
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
        public FactoryParameters(string serverUrl)
            : this(new Uri(serverUrl))
        {
        }

        /// <summary>
        /// Creates a new factory parameter for a service
        /// </summary>
        /// <param name="serverUrl">URL of this service</param>
        /// <param name="basePath">Base path to the service</param>
        public FactoryParameters(string serverUrl, string basePath)
            : this(serverUrl)
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
    internal class ServiceFactoryDiscoveryV1_0 : IServiceFactory
    {
        protected ServiceFactoryDiscoveryV1_0() : base() { }

        public virtual IMethod CreateMethod(string name, JsonDictionary dictionary)
        {
            return new MethodV1_0(this, name, dictionary);
        }

        public virtual IParameter CreateParameter(string name, JsonDictionary dictionary)
        {
            return new ParameterV1_0(this, name, dictionary);
        }

        public virtual IResource CreateResource(string name, JsonDictionary dictionary)
        {
            return new Resource(this, name, dictionary);
        }

        public virtual IService CreateService(JsonDictionary dictionary, FactoryParameters param)
        {
            return new ServiceV1_0(this, dictionary, param);
        }

        public virtual DiscoveryVersion Version { get { return DiscoveryVersion.Version_1_0; } }

        private static IServiceFactory instance;

        public static IServiceFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceFactoryDiscoveryV1_0();
            }
            return instance;
        }
    }

    /// <summary>
    ///   A Factory used by discovery to create v0.3 Services
    /// </summary>
    internal class ServiceFactoryDiscoveryV0_3 : IServiceFactory
    {
        protected ServiceFactoryDiscoveryV0_3() : base() { }

        public virtual IMethod CreateMethod(string name, JsonDictionary dictionary)
        {
            return new MethodV1_0(this, name, dictionary);
        }

        public virtual IParameter CreateParameter(string name, JsonDictionary dictionary)
        {
            return new ParameterV1_0(this, name, dictionary);
        }

        public virtual IResource CreateResource(string name, JsonDictionary dictionary)
        {
            return new Resource(this, name, dictionary);
        }

        public virtual IService CreateService(JsonDictionary dictionary, FactoryParameters param)
        {
            return new ServiceV0_3(this, dictionary, param);
        }

        public virtual DiscoveryVersion Version { get { return DiscoveryVersion.Version_0_3; } }

        private static IServiceFactory instance;

        public static IServiceFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new ServiceFactoryDiscoveryV0_3();
            }
            return instance;
        }
    }
}