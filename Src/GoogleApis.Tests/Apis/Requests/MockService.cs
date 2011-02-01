using System;
using System.Collections.Generic;

using Google.Apis.Discovery;
using Google.Apis.Requests;

namespace Google.Apis.Tests.Apis.Requests
{
    public class MockService : IService
    {
        public const string DefaultBaseUrl = "https://testexample.google.com";
        public const string DefaultRpcUri = "https://testexample.google.com/rpc";
        
        public string Name {get; set;}
        public IDictionary<string, IResource> Resources {get; set;}
        public string Version {get; set;}
        public Uri BaseUri {get; set;}
        public Uri RpcUri {get; set;}
        public DiscoveryVersion DiscoveryVersion{get; set;}
        
        public IRequest CreateRequest (string resource, string methodName)
        {
            throw new NotImplementedException ();
        }
        
        public MockService ()
        {
            this.Name = "TestService";
            this.Resources = new Dictionary<string, IResource>();
            this.Version = "V1.0Test";
            this.BaseUri = new Uri(DefaultBaseUrl );
            this.RpcUri = new Uri(DefaultRpcUri );
            this.DiscoveryVersion = DiscoveryVersion.Version_0_3;
        }
    }
}

