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
    
    public class FactoryParameterV1_0 : FactoryParameterV0_3, IFactoryParameter
    {
        public FactoryParameterV1_0():this(null,null)
        {
            ;
        }
        
        public FactoryParameterV1_0(string serverUrl, string baseUrl): base(serverUrl, baseUrl)
        {
            ;
        }
    }
    
    public class FactoryParameterV0_3 : IFactoryParameter
    {
        public FactoryParameterV0_3():this(null,null)
        {
            ;
        }
        
        public FactoryParameterV0_3(string serverUrl, string baseUrl)
        {
            this.ServerUrl = serverUrl;
            this.BaseUrl = baseUrl;
        }
        
        public string ServerUrl{get;set;}
        public string BaseUrl{get;set;}

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
            return new ServiceV1_0(version, this.Name, this.Param, Information);
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
