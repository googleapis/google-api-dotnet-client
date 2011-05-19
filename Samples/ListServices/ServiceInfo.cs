/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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

using Google.Apis.Discovery;

namespace Google.Apis.Samples.ListServices
{
    /// <summary>
    /// Shows information about a specific service
    /// </summary>
    public class ServiceInfo
    {
        /// <summary>
        /// The underlying service
        /// </summary>
        public IService Service { get; private set; }

        /// <summary>
        /// Creates a new instance of ServiceInfo
        /// </summary>
        /// <param name="serviceName">
        /// The service name under which it can be found in discovery
        /// </param>
        /// <param name="serviceVersion">
        /// The specific service version to retrieve
        /// </param>
        public ServiceInfo(string serviceName, string serviceVersion)
        {
            // Create the discovery source
            string uri = "https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest";
            var webfetcher = new WebDiscoveryDevice { DiscoveryUri = new Uri(string.Format(uri, serviceName, serviceVersion)) };
            var discovery = new DiscoveryService(webfetcher);
            
            // Build the service based on discovery information.
            Service = discovery.GetService(serviceVersion, DiscoveryVersion.Version_1_0, new FactoryParameterV1_0());
        }

        /// <summary>
        /// Outputs the service info to the console
        /// </summary>
        public void Display()
        {
            DisplaySummary();
            Console.WriteLine(); // Seperate both sections
            DisplayResources(Service, "  ");
        }

        #region Helper methods

        private void DisplaySummary()
        {
            // Output general API information
            Console.WriteLine("API Information:");
            Console.WriteLine("  Name:        {0}", Service.Name);
            Console.WriteLine("  Title:       {0}", Service.Name);
            Console.WriteLine("  ID:          {0}", Service.Id);
            Console.WriteLine("  Description: {0}", Service.Description);
            Console.WriteLine("  BaseURI:     {0}", Service.BaseUri);
            Console.WriteLine("");

            // Output a small count-summary of this service
            Console.WriteLine("Summary:");
            Console.WriteLine("  Schemes:     {0}", Service.Schemas.Count);
            Console.WriteLine("  Features:    {0}", Service.Features.Count);
            Console.WriteLine("  Resources:   {0}", Service.Resources.Count);
            Console.WriteLine("  Labels:      {0}", Service.Labels.Count);
        }

        private void DisplayResources(IResourceContainer container, string prefix)
        {
             // Display the name of the container
            Console.WriteLine(prefix + container.Name);
            prefix += "    ";
            
            // If applicable: Show methods
            var resource = container as IResource;
            if (resource != null) {
                foreach (var method in resource.Methods.Values) {
                    Console.WriteLine((prefix + method.Name + "()").PadRight(25) + method.Description);
                }
            }
            
            // Recursivly output all subcontainers
            foreach (var subcontainer in container.Resources.Values) {
                DisplayResources(subcontainer, prefix);
            }
        }

        #endregion
    }
}
