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
	public class Resource
	{
		public string Name {get;set;}
		private Dictionary<string, Method> methods;
		private JSONDictionary information;

		private Resource ()
		{
		}
		
		internal Resource (KeyValuePair<string, object> kvp)
		{
			this.Name = kvp.Key;
			this.information = kvp.Value as JSONDictionary;
			if (this.information == null)
				throw new ArgumentException ("got no valid dictionary");
		}

		public Dictionary<string, Method> Methods {
			get {
				if (this.methods == null) {
					JSONDictionary js = this.information[ServiceFactory.Methods] as JSONDictionary;
					if (js != null) {
						this.methods = new Dictionary<string, Method> ();
						foreach (KeyValuePair<string, object> kvp in js) {
							Method m = new Method (kvp);
							this.methods.Add (kvp.Key, m);
						}
					}
				}
				return this.methods;
			}
		}
	}
}
