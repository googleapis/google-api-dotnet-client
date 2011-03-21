using System;
using Google.Apis.Discovery;
using System.Collections.Generic;

namespace Google.Apis.Samples.ApiExplorerWinForm
{
    /// <summary>
    /// Utility methods to work with discovery API.
    /// </summary>
    public static class ApiUtility
    {
        public static string[] GetVersions(string serviceName)
        {
            DiscoveryService discovery = GetDiscoveryService(serviceName);
            return discovery.GetVersions(DiscoveryVersion.Version_0_1, null);
        }

        public static IService GetService(string serviceName, string version)
        {
            DiscoveryService discovery = GetDiscoveryService(serviceName);
            return discovery.GetService(version, DiscoveryVersion.Version_0_1, null);
        }

        public static IDictionary<string, IResource> GetResources(string serviceName, string version)
        {
            IService service = GetService(serviceName, version);
            IDictionary<string, IResource> resources = service.Resources;
            return resources;
        }

        public static IDictionary<string, IMethod> GetMethods(string serviceName, string resourceName, string version)
        {
            IDictionary<string, IResource> resources = GetResources(serviceName, version);
            return resources[resourceName].Methods;
        }

        public static IMethod GetMethod(string serviceName, string resourceName, string methodName, string version)
        {
            return GetMethods(serviceName, resourceName, version)[methodName];
        }

        private static DiscoveryService GetDiscoveryService(string serviceName)
        {
            WebDiscoveryDevice discoveryDevice = new WebDiscoveryDevice
            {
                DiscoveryUri = new Uri("https://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)
            };

            return new DiscoveryService(discoveryDevice);
        }
    }
}
