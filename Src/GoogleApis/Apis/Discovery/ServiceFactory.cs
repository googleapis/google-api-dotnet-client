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
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Json;
using Google.Apis.Testing;

namespace Google.Apis.Discovery 
{
    public abstract class ServiceFactory
    {
        internal const string VersionInfo = "versionInfo";
        
        internal const string RpcUrl = "rpcUrl";
        internal const string Resources = "resources";
        internal const string Methods = "methods";
        internal const string RpcName = "rpcName";
        internal const string HttpMethod = "httpMethod";
        internal const string Parameters = "parameters";
    
        internal const string ParameterType = "parameterType";
        internal const string Pattern = "pattern";
        internal const string Required = "required";
        internal const string DefaultValue = "defaultValue";
        internal const string ValueType = "valueType";

        public static IServiceFactory CreateServiceFactory(Stream discovery, DiscoveryVersion version, IFactoryParameter param)
        {
            JsonDictionary information = JsonReader.Parse(discovery) as JsonDictionary;
            
            switch(version){
                case DiscoveryVersion.Version_0_1:
                    return new ServiceFactoryDiscoveryV0_1(information);
                case DiscoveryVersion.Version_0_2:
                    return new ServiceFactoryDiscoveryV0_2(information, (FactoryV0_2Parameter)param);
                case DiscoveryVersion.Version_0_3:
                default:
                    throw new NotSupportedException("The Version "+version +" is not supported");
            }
        }
        
        public interface IFactoryParameter
        {
        }
        
        public class FactoryV0_2Parameter:IFactoryParameter
        {
            public FactoryV0_2Parameter():this(null, null)
            {
                ;
            }
            public FactoryV0_2Parameter(string serverUrl, string baseUrl)
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
            internal const string BaseUrl = "restBasePath";
            internal const string PathUrl = "restPath";
            
            private readonly JsonDictionary information;
            private readonly FactoryV0_2Parameter param;
            private readonly string name;
            public ServiceFactoryDiscoveryV0_2(JsonDictionary discovery, FactoryV0_2Parameter param) 
            {
                this.information = discovery;
                this.name = information["name"].ToString();                
                this.param = param;
            }
            
            public IService GetService(string version) 
            {
                return new ServiceV0_2(version, this.name, param, information);
            }
        }
        
    	[VisibleForTestOnly]
        internal class ServiceFactoryDiscoveryV0_1 :IServiceFactory
    	{
            internal const string BaseUrl = "baseUrl";
            internal const string PathUrl = "pathUrl";
            
    	    private JsonDictionary information;
    	    private string name;
    	    public ServiceFactoryDiscoveryV0_1(JsonDictionary discovery) 
            {
    	      this.information = discovery;
    	      if (this.information == null)
    	        throw new ArgumentException("Discovery document in invalid form");
    	
    	      // if present discard the data element
              this.information = this.information["data"] as JsonDictionary;
                if (this.information == null)
    	        throw new ArgumentException("Discovery document has no data element");
    	      if (this.information.Count != 1)
    	        throw new ArgumentException("More than one element found");
    	      foreach (KeyValuePair<string, object> kvp in this.information) {
    	        this.name = kvp.Key;
    	        this.information = kvp.Value as JsonDictionary;
    	      }
    	      if (this.information == null)
    	        throw new ArgumentException("Discovery document has no service dictionary");
    		  /*
    	      if (this.information.Count >= 2)
    	        throw new ArgumentException("Discovery document has too many children beneath the service name");
    	
    	      this.information = this.information["versionInfo"] as JSONDictionary;
    	      if (this.information == null)
    	        throw new ArgumentException("Discovery document has no versionInfo for the service");*/
    	    }
    	
    	    public IService GetService(string version) 
    		{
    			// now find the right versioninfo set
    			JsonDictionary js = this.information[version] as JsonDictionary;
    			if (js == null)
    			{
    				throw new ArgumentException("Did not find version: " + version + " in the discovery document");
    			}
    			
    			return new ServiceV0_1(version, this.name, js);
    	    }
    	  }	
    }
}
