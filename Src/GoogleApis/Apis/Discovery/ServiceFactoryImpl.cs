// /*
// Copyright 2010 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Defines the factory parameters which are used to create a v1.0 Service
    /// </summary>
    public class FactoryParameterV1_0 : FactoryParameterV0_3
    {
        public FactoryParameterV1_0() : base() {}

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
    /// Defines the factory parameters which are used to create a v0.3 Service
    /// </summary>
    public class FactoryParameterV0_3 : BaseFactoryParameters
    {
        public FactoryParameterV0_3() : base() {}

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
        public const string DefaultServerUrl = "https://www.googleapis.com/";

        /// <summary>
        /// Creates a new factory parameter for a service
        /// Sets the server url to the default google url
        /// </summary>
        protected BaseFactoryParameters()
        {
            ServerUrl = DefaultServerUrl;
        }

        /// <summary>
        /// Creates a new factory parameter for a service
        /// </summary>
        /// <param name="serverUrl"></param>
        protected BaseFactoryParameters(string serverUrl)
        {
            serverUrl.ThrowIfNullOrEmpty("serverUrl");
            ServerUrl = serverUrl;
        }

        /// <summary>
        /// Creates a new factory parameter for a service
        /// </summary>
        /// <param name="serverUrl"></param>
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
        ///  The relative base path
        /// </summary>
        public string BasePath { get; set; }
    }
    
    internal class ServiceFactoryDiscoveryV1_0 : ServiceFactoryDiscoveryV0_3
    {
        public ServiceFactoryDiscoveryV1_0 (JsonDictionary discovery, FactoryParameterV1_0 param) : 
            base(discovery, param)
        {
            ;
        }
        
        public override IService GetService (string version)
        {
            return new ServiceV1_0(version, this.Name, (FactoryParameterV1_0)this.Param, Information);
        }
    }
    
    internal class ServiceFactoryDiscoveryV0_3 : IServiceFactory
    {
        private readonly JsonDictionary information;
        private readonly FactoryParameterV0_3 param;
        private readonly string name;
        public ServiceFactoryDiscoveryV0_3 (JsonDictionary discovery, FactoryParameterV0_3 param)
        {
            discovery.ThrowIfNullOrEmpty("discovery");
            param.ThrowIfNull("param");
            
            if ( discovery.ContainsKey("name")  == false ||
                 (discovery["name"] as string).IsNullOrEmpty())
            {
                throw new ArgumentException("No Name present in discovery");
            }
                
            this.information = discovery;
            this.name = information["name"].ToString ();
            this.param = param;
        }

        public virtual IService GetService (string version)
        {
            return new ServiceV0_3 (version, this.name, param, information);
        }
        
        [VisibleForTestOnly]
        internal string Name{get{return name;}}
        [VisibleForTestOnly]
        internal FactoryParameterV0_3 Param{get{return param;}}
        [VisibleForTestOnly]
        internal JsonDictionary Information{get{return information;}}
        
    }    
}
