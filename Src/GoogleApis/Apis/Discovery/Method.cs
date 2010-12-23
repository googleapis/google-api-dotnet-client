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
using Google.Apis.Requests;

namespace Google.Apis.Discovery
{
    public interface IMethod
    {
        string Name {get;set;}
        string RestPath{get;} 
        string RpcName {get;}
        string HttpMethod {get;}
        Dictionary<string, Parameter> Parameters{get;} 
    }
    
	internal abstract class BaseMethod:IMethod
	{
		internal protected JsonDictionary information;
		
		internal protected Dictionary<string, Parameter> parameters;
        
		internal BaseMethod (KeyValuePair<string, object> kvp)
		{
			this.Name = kvp.Key;
			this.information = kvp.Value as JsonDictionary;
			if (this.information == null)
				throw new ArgumentException ("got no valid dictionary");
		}

        public string Name {get;set;}
        
		public abstract string RestPath {get;}

		public string RpcName 
		{
			get { return this.information[ServiceFactory.RpcName] as string; }
		}

		public string HttpMethod 
		{
			get { return this.information.GetValueAsNull (ServiceFactory.HttpMethod) as string; }
		}

		public Dictionary<string, Parameter> Parameters 
		{
			get {
				if (this.parameters == null) 
				{
					this.parameters = FetchParameters ();
				}
				return this.parameters;
			}
		}
        
        private Dictionary<string, Parameter> FetchParameters ()
        {
            if( this.information.ContainsKey(ServiceFactory.Parameters) == false)
            {
                return new Dictionary<string, Parameter>(0);
            }
            
            JsonDictionary js = this.information[ServiceFactory.Parameters] as JsonDictionary;
            if (js == null) 
            {
                return new Dictionary<string, Parameter>(0);                
            }
            
            var parameters = new Dictionary<string, Parameter> ();
            foreach (KeyValuePair<string, object> kvp in js) 
            {
                Parameter p = new Parameter (kvp);
                parameters.Add (kvp.Key, p);
            }
            return parameters;
        }
	}
    
    internal class MethodV0_1:BaseMethod
    {
        public MethodV0_1(KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        public override string RestPath 
        {
            get { return this.information[ServiceFactory.ServiceFactoryDiscoveryV0_1.PathUrl] as string; }
        }
        
    }
    internal class MethodV0_2:BaseMethod
    {
        public MethodV0_2(KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        public override string RestPath 
        {
            get { return this.information[ServiceFactory.ServiceFactoryDiscoveryV0_2.PathUrl] as string; }
        }
    }
}