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
namespace Google.Apis.Discovery
{
    public class FactoryParameterV0_3 : FactoryParameterV0_2, IFactoryParameter
    {
        public FactoryParameterV0_3():this(null,null)
        {
            ;
        }
        
        public FactoryParameterV0_3(string serverUrl, string baseUrl): base(serverUrl, baseUrl)
        {
            ;
        }
    }
    
    internal class ServiceFactoryDiscoveryV0_3 : IServiceFactory
    {
         private readonly JsonDictionary information;
        private readonly FactoryParameterV0_3 param;
        private readonly string name;
        public ServiceFactoryDiscoveryV0_3 (JsonDictionary discovery, FactoryParameterV0_3 param)
        {
            if ( discovery == null )
            {
                throw new ArgumentNullException("discovery");
            }
            if ( param == null )
            {
                throw new ArgumentNullException("param");
            }
            
            if ( discovery.ContainsKey("name")  == false ||
                 discovery["name"] as string == null || 
                ((string)discovery["name"]).Length == 0)
            {
                throw new ArgumentException("No Name present in discovery");
            }
                
            this.information = discovery;
            this.name = information["name"].ToString ();
            this.param = param;
        }

        public IService GetService (string version)
        {
            return new ServiceV0_2 (version, this.name, param, information);
        }
        
        [VisibleForTestOnly]
        internal string Name{get{return name;}}
        [VisibleForTestOnly]
        internal FactoryParameterV0_3 Param{get{return param;}}
        [VisibleForTestOnly]
        internal JsonDictionary Information{get{return information;}}
        
    }
    
    public class FactoryParameterV0_2 : IFactoryParameter
    {
        public FactoryParameterV0_2():this(null, null)
        {
            ;
        }
        public FactoryParameterV0_2(string serverUrl, string baseUrl)
        {
            this.ServerUrl = serverUrl;
            this.BaseUrl = baseUrl;
        }
        
        public string ServerUrl{get;set;}
        public string BaseUrl{get;set;}
    }
    
    [VisibleForTestOnly]
    internal class ServiceFactoryDiscoveryV0_2 : IServiceFactory
    {
        private readonly JsonDictionary information;
        private readonly FactoryParameterV0_2 param;
        private readonly string name;
        public ServiceFactoryDiscoveryV0_2 (JsonDictionary discovery, FactoryParameterV0_2 param)
        {
            if ( discovery == null )
            {
                throw new ArgumentNullException("discovery");
            }
            if ( param == null )
            {
                throw new ArgumentNullException("param");
            }
            
            if ( discovery.ContainsKey("name")  == false ||
                 discovery["name"] as string == null || 
                ((string)discovery["name"]).Length == 0)
            {
                throw new ArgumentException("No Name present in discovery");
            }
                
            this.information = discovery;
            this.name = information["name"].ToString ();
            this.param = param;
        }

        public IService GetService (string version)
        {
            return new ServiceV0_2 (version, this.name, param, information);
        }
        
        [VisibleForTestOnly]
        internal string Name{get{return name;}}
        [VisibleForTestOnly]
        internal FactoryParameterV0_2 Param{get{return param;}}
        [VisibleForTestOnly]
        internal JsonDictionary Information{get{return information;}}
    }
 
    [VisibleForTestOnly]
    internal class ServiceFactoryDiscoveryV0_1 : IServiceFactory
    {
  
        private JsonDictionary information;
        private string name;
        public ServiceFactoryDiscoveryV0_1 (JsonDictionary discovery)
        {
            this.information = discovery;
            if (this.information == null)
                throw new ArgumentException ("Discovery document in invalid form");
            
            // if present discard the data element
            this.information = this.information["data"] as JsonDictionary;
            if (this.information == null)
                throw new ArgumentException ("Discovery document has no data element");
            if (this.information.Count != 1)
                throw new ArgumentException ("More than one element found");
            foreach (KeyValuePair<string, object> kvp in this.information)
            {
                this.name = kvp.Key;
                this.information = kvp.Value as JsonDictionary;
            }
            if (this.information == null)
                throw new ArgumentException ("Discovery document has no service dictionary");
        }
                
        public IService GetService (string version)
        {
            // now find the right versioninfo set
            JsonDictionary js = this.information[version] as JsonDictionary;
            if (js == null)
            {
                throw new ArgumentException ("Did not find version: " + version + " in the discovery document");
            }
            
            return new ServiceV0_1 (version, this.name, js);
        }
    }
}
