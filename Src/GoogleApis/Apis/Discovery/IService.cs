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

using Google.Apis.Requests;
using Google.Apis.Discovery.Schema;

namespace Google.Apis.Discovery 
{


    /// <summary>
    /// Represent a specific version of a service as defined in Google Api Discovery Document.
    /// Has a collection of IResources and ISchemas
    /// </summary>
    /// <seealso cref="IResource"/>
    /// <seealso cref="ISchema"/>
	public interface IService : IResourceContainer
	{
		/// <summary> The version of this serivce </summary>
		string Version {get;}
		Uri BaseUri {get;}
		Uri RpcUri {get;}
        
        /// <summary>The version of the discovery that defined this service. </summary>
        DiscoveryVersion DiscoveryVersion{get;}
        
        /// <summary>A dictionary containing all the schemas defined in this Service </summary>
        IDictionary<string, ISchema> Schemas{get;} 

		/// <summary>
		/// Creates a Request Object based on the HTTP Method Type.
		/// </summary>
		IRequest CreateRequest (string resource, string methodName);		
	}
}
