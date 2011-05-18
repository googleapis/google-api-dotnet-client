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
        /// Mac / Unix (Mono)
        /// mono ListServices.exe buzz
        /// mono ListServices.exe latitude
        /// mono ListServices.exe moderator
        /// </example>
        public static void Main (string[] args)
        {
            // Define our discovery source
            string serviceName = "moderator";
            string uri = "https://www.googleapis.com/discovery/v1/apis/{0}/v1/rest";
            
            if (args.Length == 1) {
                serviceName = args[0];
            }

            var webfetcher = new WebDiscoveryDevice { DiscoveryUri = new Uri (string.Format (uri, serviceName)) };
            var discovery = new DiscoveryService (webfetcher);
            
            // Build the service based on discovery information.
            var service = discovery.GetService ("v1", DiscoveryVersion.Version_1_0, new FactoryParameterV1_0 ());
            
            #region Output: Service listing
            
            // Highlight output
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Output general API information
            Console.WriteLine ("API Information:");
            Console.WriteLine ("  Name:        {0}", service.Name);
            // Console.WriteLine("  Title:       {0}", service.Name);
            Console.WriteLine ("  ID:          {0}", service.Id);
            Console.WriteLine ("  Description: {0}", service.Description);
            Console.WriteLine ("  BaseURI:     {0}", service.BaseUri);
            // Console.WriteLine("  RPC URI:     {0}", service.RpcUri); // no longer supported?
            Console.WriteLine ("");
            
            // Output a small count-summary of this service
            Console.WriteLine ("Summary:");
            Console.WriteLine ("  Schemes:     {0}", service.Schemas.Count);
            Console.WriteLine ("  Features:    {0}", service.Features.Count);
            Console.WriteLine ("  Resources:   {0}", service.Resources.Count);
            Console.WriteLine ("  Labels:      {0}", service.Labels.Count);
            
            // Output all resources & methods
            Console.WriteLine ("");
            Console.WriteLine ("Resources / Services:");
            
            OutputResourcesRecursivly (service, "  ");
            
            #endregion
        }

        private static void OutputResourcesRecursivly (IResourceContainer container, string prefix)
        {
            // Display the name of the container
            Console.WriteLine (prefix + container.Name);
            prefix += "    ";
            
            // If applicable: Show methods
            var resource = container as IResource;
            if (resource != null) {
                foreach (var method in resource.Methods.Values) {
                    Console.WriteLine ((prefix + method.Name + "()").PadRight (25) + method.Description);
                }
            }
            
            // Recursivly output all subcontainers
            foreach (var subcontainer in container.Resources.Values) {
                OutputResourcesRecursivly (subcontainer, prefix);
            }
        }
    }
}
