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
    public interface IResource : IResourceContainer
    {
        Dictionary<string, IMethod> Methods{get;}
    }
    
    
    
	internal abstract class BaseResource : IResource
	{
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(IResource));
        private Dictionary<string, IMethod> methods;
        private Dictionary<string, IResource> resources;
		private JsonDictionary information;
        
        public string Name {get;set;}
		
		internal BaseResource (KeyValuePair<string, object> kvp)
		{
            logger.DebugFormat("Constructing Resource [{0}]", kvp.Key);
			this.Name = kvp.Key;
			this.information = kvp.Value as JsonDictionary;
			if (this.information == null)
				throw new ArgumentException ("got no valid dictionary");
		}

		public Dictionary<string, IMethod> Methods 
		{
			get {
				if (this.methods == null) 
				{
					this.methods = FetchMethods ();
				}
				return this.methods;
			}
		}
        
        
        public IDictionary<string, IResource> Resources 
        {
            get 
            {
                if (this.resources == null) 
                {                    
                    this.resources = FetchResources ();
                }
                return this.resources;
            }
        }
        
        private Dictionary<string, IMethod> FetchMethods ()
        {
            if(this.information.ContainsKey(ServiceFactory.Methods) == false)
            {
                return new Dictionary<string, IMethod>(0);
            }
            
            JsonDictionary js = this.information[ServiceFactory.Methods] as JsonDictionary;
            if (js == null)
            {
                return new Dictionary<string, IMethod>(0);
            }
            
            var methods = new Dictionary<string, IMethod> ();
            foreach (KeyValuePair<string, object> kvp in js) 
            {
                IMethod m = CreateMethod(kvp);
                methods.Add (kvp.Key, m);
            }   
            return methods;
        }

        
        private Dictionary<string, IResource> FetchResources ()
        {
            if(this.information.ContainsKey(ServiceFactory.Resources) == false)
            {
                return new Dictionary<string, IResource>(0);
            }
            
            JsonDictionary js = this.information[ServiceFactory.Resources] as JsonDictionary;
            if (js == null)
            {
                return new Dictionary<string, IResource>(0);
            }
                
            var resources = new Dictionary<string, IResource> ();
            foreach (KeyValuePair<string, object> kvp in js) 
            {
                IResource r = CreateResource(kvp);
                resources.Add (kvp.Key, r);
            }
            return resources;                
        }
        
        protected abstract IResource CreateResource(KeyValuePair<string, object> kvp);
        protected abstract IMethod CreateMethod(KeyValuePair<string, object> kvp);
	}
    
    internal class ResourceV0_1: BaseResource
    {
        internal ResourceV0_1 (KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        protected override IMethod CreateMethod (KeyValuePair<string, object> kvp)
        {
            return new MethodV0_1(kvp);
        }
        
        protected override IResource CreateResource (KeyValuePair<string, object> kvp)
        {
            return new ResourceV0_1(kvp);
        }
    }
    
    internal class ResourceV0_2: BaseResource
    {
        internal ResourceV0_2 (KeyValuePair<string, object> kvp):base(kvp)
        {
        }
        
        protected override IMethod CreateMethod (KeyValuePair<string, object> kvp)
        {
            return new MethodV0_2(kvp);
        }
        
        protected override IResource CreateResource (KeyValuePair<string, object> kvp)
        {
            return new ResourceV0_2(kvp);
        }
        
    }
    
}
