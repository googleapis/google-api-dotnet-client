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

using Google.Apis.JSON;
using Google.Apis.Requests;

namespace Google.Apis.Discovery
{
	// represents a single version of a service
	public class Service
	{
		private JSONDictionary information;
		public string Name {get; private set;}
		public string Version {get; private set;}
		
		private Dictionary<string, Method> serviceMethods;
		private Dictionary<string, Resource> resources;

		internal Service (string version, string name, JSONDictionary js)
		{
			this.Version = version;
			this.Name = name;
			this.information = js;
		}

		private Service ()
		{
		}

		public Uri BaseUri {
			get { return new Uri (this.information[ServiceFactory.discovery_baseUrl] as string); }
		}

		public Uri RpcUri {
			get { return new Uri (this.information[ServiceFactory.discovery_rpcUrl] as string); }
		}

		public Dictionary<string, Resource> Resources {
			get {
				if (this.resources == null) {
					JSONDictionary js = this.information[ServiceFactory.discovery_resources] as JSONDictionary;
					if (js != null) {
						this.resources = new Dictionary<string, Resource> ();
						foreach (KeyValuePair<string, object> kvp in js) {
							Resource r = new Resource (kvp);
							this.resources.Add (kvp.Key, r);
						}
					}
				}
				return this.resources;
			}
		}

		/// <summary>
		/// Creates a Request Object based on the HTTP Method Type.
		/// </summary>
		/// <param name="method">
		/// A <see cref="Method"/>
		/// </param>
		/// <returns>
		/// A <see cref="Request"/>
		/// </returns>
		public Request CreateRequest (string resource, string methodName)
		{
			var method = this.Resources[resource].Methods[methodName];
			var request = Request.CreateRequest(this, method);
			
			return request;
		}
	}
}
