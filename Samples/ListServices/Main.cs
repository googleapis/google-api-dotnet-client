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

using Google.Apis;
using Google.Apis.Discovery;

namespace Google.Apis.Samples.ListServices
{
	class MainClass
	{
		/// <summary>
		/// Lists all the services for a given API.
		/// 
		/// If no service is provided
		/// </summary>
		/// <param name="args">
		/// A <see cref="System.String[]"/>
		/// </param>
		/// <example>
		/// Windows:
		/// 
		/// ListServices.exe buzz
		/// ListServices.exe latitude
		/// ListServices.exe moderator
		/// 
		/// Mac (Mono)
		/// mono ListServices.exe buzz
		/// mono ListServices.exe latitude
		/// mono ListServices.exe moderator
		/// </example>
		public static void Main (string[] args)
		{
			string serviceName = "moderator";
			string uri = "https://www.googleapis.com/discovery/0.1/describe?api={0}&apiVersion=1";
			
			if(args.Length == 1) {
				serviceName = args[0];
			}
			
			var webfetcher = new WebDiscoveryDevice { DiscoveryUri = new Uri(string.Format(uri, serviceName))};
			var discovery = new DiscoveryService(webfetcher);
			
			// Build the service based on discovery information.
			var service = discovery.GetService("v1", DiscoveryVersion.Version_0_1, null);
			
			// Output sevice information
			foreach(var resource in service.Resources) {
				var methods = resource.Value.Methods;
				Console.Out.WriteLine("{0}", resource.Key);
				foreach(var methodEntry in methods) {
					Console.Out.WriteLine("\t- {0}", methodEntry.Value.RpcName);
				}
			}
		}
	}
}