/*
Copyright 2011 Google Inc

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
using System.Collections;
using System.Collections.Generic;
using System.IO;

using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Samples.ApiExplorer
{
    /// <summary>
    /// Utility methods to work with discovery API.
    /// </summary>
    public class ApiUtility
    {
        private Dictionary<string, Dictionary<string, DiscoveryService>> DiscoveryDevices = 
            new Dictionary<string,Dictionary<string,DiscoveryService>>();

        private Dictionary<string, Dictionary<string, string>> discoveryLinks = 
            new Dictionary<string, Dictionary<string, string>>();

        public ApiUtility()
        {
            WebDiscoveryDevice discoveryDevice = new WebDiscoveryDevice
            {
                DiscoveryUri = new Uri("https://www.googleapis.com/discovery/v0.3/directory")
            };
            using (Stream stream = discoveryDevice.Fetch())
            {
                JsonDictionary information = JsonReader.Parse(stream) as JsonDictionary;
                ArrayList items = information["items"] as ArrayList;
                foreach (JsonDictionary item in items)
                {
                    string discoveryLink = "https://www.googleapis.com/discovery/v0.3/" + item["discoveryLink"].ToString();
                    string name = item["name"].ToString();
                    string version = item["version"].ToString();
                    if (!discoveryLinks.ContainsKey(name))
                    {
                        discoveryLinks.Add(name, new Dictionary<string, string>());
                    }
                    discoveryLinks[name].Add(version, discoveryLink);
                }
            }
        }

        public string[] getServiceNames()
        {
            string[] arr = new string[discoveryLinks.Keys.Count];
            discoveryLinks.Keys.CopyTo(arr, 0);
            return arr;
        }

        public string[] GetVersions(string serviceName)
        {
            string[] arr = new string[discoveryLinks[serviceName].Keys.Count];
            discoveryLinks[serviceName].Keys.CopyTo(arr, 0);
            return arr;
        }

        public IService GetService(string serviceName, string version)
        {
            DiscoveryService discovery = GetDiscoveryService(serviceName, version);
            string serverUrl = "https://www.googleapis.com";
            return discovery.GetService(version, DiscoveryVersion.Version_0_3, new FactoryParameterV0_3(serverUrl, null));
        }

        public IDictionary<string, IResource> GetResources(string serviceName, string version)
        {
            IService service = GetService(serviceName, version);
            IDictionary<string, IResource> resources = service.Resources;
            return resources;
        }

        public IDictionary<string, IMethod> GetMethods(string serviceName, string resourceName, string version)
        {
            IDictionary<string, IResource> resources = GetResources(serviceName, version);
            return resources[resourceName].Methods;
        }

        public IMethod GetMethod(string serviceName, string resourceName, string methodName, string version)
        {
            return GetMethods(serviceName, resourceName, version)[methodName];
        }

        private DiscoveryService GetDiscoveryService(string serviceName, string version)
        {
            if (!DiscoveryDevices.ContainsKey(serviceName))
            {
                DiscoveryDevices.Add(serviceName, new Dictionary<string, DiscoveryService>());
            }

            if (!DiscoveryDevices[serviceName].ContainsKey(version))
            {
                WebDiscoveryDevice discoveryDevice = new WebDiscoveryDevice
                {
                    DiscoveryUri = new Uri(discoveryLinks[serviceName][version])
                };

                DiscoveryDevices[serviceName].Add(version, new DiscoveryService(discoveryDevice));
            }

            return DiscoveryDevices[serviceName][version];
        }

    }
}
