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

using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
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
        public IDictionary<string, ISchema> Schemas{get;set;}
        public string Id {get; private set;}
        public IList<string> Labels {get; private set;}
        public string DocumentationLink {get; private set;}
        public string Protocol {get; private set;}
        
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
            this.Schemas = new Dictionary<string, ISchema>();
            this.Id = "TestId";
            this.Labels = new List<string>(){"alpha","beta","release"};
            this.DocumentationLink = "http://www.google.com";
            this.Protocol = "rest";
        }
    }
}

