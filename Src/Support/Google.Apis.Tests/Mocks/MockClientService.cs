/*
Copyright 2017 Google Inc

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
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Util;

namespace Google.Apis.Tests.Mocks
{
    /// <summary>
    /// Mock-Response for testing purposes.
    /// </summary>
    public class MockClientService : BaseClientService
    {
        public override string Name { get { return "TestService"; } }

        public override string BaseUri { get; }
        public override string BasePath => "";
        public override string BatchUri { get; }
        public override string BatchPath => "";

        private IList<string> _features = new List<string> { "rest", "rpc", "json", "atom" };
        public override IList<string> Features { get { return _features; } }
        public void SetFeatures(IList<string> features) { _features = features; }

        public MockClientService(string baseUri = @"https://testexample.google.com", string batchUri = null)
            : this(new Initializer(), baseUri, batchUri)
        {
        }

        public MockClientService(Initializer initializer,
            string baseUri = @"https://testexample.google.com", string batchUri = null)
            : base(initializer)
        {
            BaseUri = baseUri;
            BatchUri = batchUri;
        }

        protected override BackOffHandler CreateBackOffHandler()
        {
            // we create a mock back-off handler here which doesn't make calls to thread sleep. It just add the waited
            // time span into a list.
            return new MockBackOffHandler(new ExponentialBackOff());
        }
    }
}
