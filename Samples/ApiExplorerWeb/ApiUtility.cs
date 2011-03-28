using System;
using System.Collections.Generic;
using Google.Apis.Discovery;
using System.IO;
using Google.Apis.Json;
using System.Collections;

namespace Google.Apis.Samples.ApiExplorerWeb
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
            string serverUrl = discoveryLinks[serviceName][version];
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
