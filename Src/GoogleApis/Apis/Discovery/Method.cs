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
using Google.Apis.Util;

namespace Google.Apis.Discovery
{
	internal abstract class BaseMethod:IMethod
	{
		internal readonly protected JsonDictionary information;
		
		internal protected Dictionary<string, IParameter> parameters;
        
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
        
        public string ResponseType
        {
            get {
                var responseDict = this.information.GetValueAsNull (ServiceFactory.ResponseType) as JsonDictionary;
                return responseDict.GetValueAsNull("$ref") as string;
            }
        }

		public Dictionary<string, IParameter> Parameters 
		{
			get {
				if (this.parameters == null) 
				{
					this.parameters = FetchParameters ();
				}
				return this.parameters;
			}
		}
        
        private Dictionary<string, IParameter> FetchParameters ()
        {
            if( this.information.ContainsKey(ServiceFactory.Parameters) == false)
            {
                return new Dictionary<string, IParameter>(0);
            }
            
            JsonDictionary js = this.information[ServiceFactory.Parameters] as JsonDictionary;
            if (js == null) 
            {
                return new Dictionary<string, IParameter>(0);                
            }
            
            var parameters = new Dictionary<string, IParameter> ();
            foreach (KeyValuePair<string, object> kvp in js) 
            {
                IParameter p = new Parameter (kvp);
                parameters.Add (kvp.Key, p);
            }
            return parameters;
        }
	}
    
    /// <summary>
    /// Represents a Method from Discovery Version 0.1
    /// </summary>
    internal class MethodV0_1:BaseMethod
    {
        private const string PathUrl = "pathUrl";

        public MethodV0_1(KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        public override string RestPath 
        {
            get { return this.information[PathUrl] as string; }
        }
        
    }
    
    /// <summary>
    /// Represents a Method from Discovery Version 0.2
    /// </summary>
    internal class MethodV0_2:BaseMethod
    {
        private const string PathUrl = "restPath";

        public MethodV0_2(KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        public override string RestPath 
        {
            get { return this.information[PathUrl] as string; }
        }
    }
}