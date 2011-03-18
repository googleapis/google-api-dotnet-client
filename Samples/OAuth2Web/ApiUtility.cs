using System;
using Google.Apis.Discovery;
using System.Collections.Generic;

namespace Google.Apis.Samples.OAuth2Web
{
    /// <summary>
    /// Utility methods to work with discovery API.
    /// </summary>
    public static class ApiUtility
    {
        public static IService GetService(string serviceName)
        {
            WebDiscoveryDevice discoveryDevice = new WebDiscoveryDevice
            {
                DiscoveryUri = new Uri("https://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)
            };

            DiscoveryService discovery = new DiscoveryService(discoveryDevice);
            IService service = discovery.GetService("v1", DiscoveryVersion.Version_0_1, null);
            return service;
        }

        public static IDictionary<string, IResource> GetResources(string serviceName)
        {
            IService service = GetService(serviceName);
            IDictionary<string, IResource> resources = service.Resources;
            return resources;
        }

        public static IDictionary<string, IMethod> GetMethods(string serviceName, string resourceName)
        {
            IDictionary<string, IResource> resources = GetResources(serviceName);
            return resources[resourceName].Methods;
        }

        public static IMethod GetMethod(string serviceName, string resourceName, string methodName)
        {
            return GetMethods(serviceName, resourceName)[methodName];
        }
    }
}
