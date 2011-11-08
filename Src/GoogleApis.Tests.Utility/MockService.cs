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
using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
using Google.Apis.Requests;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Mock service for testing purposes
    /// </summary>
    public class MockService : IService
    {
        public const string DefaultBaseUrl = "https://testexample.google.com";
        public const string DefaultRpcUri = "https://testexample.google.com/rpc";

        public MockService()
        {
            Name = "TestService";
            Title = "The Test Service";
            Resources = new Dictionary<string, IResource>();
            Version = "V1.0Test";
            BaseUri = new Uri(DefaultBaseUrl);
            RpcUri = new Uri(DefaultRpcUri);
            DiscoveryVersion = DiscoveryVersion.Version_1_0;
            Schemas = new Dictionary<string, ISchema>();
            Id = "TestId";
            Labels = new List<string> { "alpha", "beta", "release" };
            DocumentationLink = "http://www.google.com";
            Protocol = "rest";
            Description = "Test description";
            Features = new List<string> { "rest", "rpc", "json", "atom" };
            Scopes = new Dictionary<string, Scope>();
        }

        #region IService Members

        public string Name { get; set; }
        public string Title { get; set; }
        public IDictionary<string, IResource> Resources { get; set; }
        public string Version { get; set; }
        public Uri BaseUri { get; set; }
        public Uri RpcUri { get; set; }
        public bool GZipEnabled { get; set; }
        public DiscoveryVersion DiscoveryVersion { get; set; }
        public IDictionary<string, ISchema> Schemas { get; set; }

        public ISerializer Serializer
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Id { get; private set; }
        public IList<string> Labels { get; private set; }
        public IDictionary<string, Scope> Scopes { get; private set; }
        public IDictionary<string, IParameter> Parameters { get; private set; }
        public string DocumentationLink { get; private set; }
        public string Protocol { get; private set; }
        public string Description { get; private set; }
        public IList<string> Features { get; private set; }

        public IRequest CreateRequest(string resource, string methodName)
        {
            throw new NotImplementedException();
        }

        public string SerializeRequest(object obj)
        {
            throw new NotImplementedException();
        }

        public RequestError DeserializeError(IResponse input)
        {
            throw new NotImplementedException();
        }

        public T DeserializeResponse<T>(IResponse input)
        {
            throw new NotImplementedException();
        }

        public bool HasFeature(Features feature)
        {
            throw new NotImplementedException();
        }

        #endregion

        public Dictionary<string, IMethod> Methods { get; set; }

        public IResource Parent { get; set; }

        public string Path { get; set; }

        public bool IsServiceResource { get; set; }
    }
}