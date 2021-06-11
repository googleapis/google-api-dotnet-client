// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Google.Apis.Tests.Apis.Http
{
    public class HttpClientFactoryTest
    {
        [Fact]
        public void WithProxy()
        {
            var proxy = new DummyWebProxy();
            var factory = new DummyHttpClientFactory(proxy);

            var httpClientHandler = factory.CreateClientHandler();

            Assert.Same(proxy, httpClientHandler.Proxy);
        }

        private class DummyHttpClientFactory : HttpClientFactory
        {
            public DummyHttpClientFactory(IWebProxy proxy):base(proxy)
            { }

            // Hiding base just to make this one public for testing purposes.
            public new HttpClientHandler CreateClientHandler() => base.CreateClientHandler();
        }

        /// <summary>
        /// Dummy implementation because System.Net.WebProxy is not available in
        /// netcoreapp1.*
        /// </summary>
        private class DummyWebProxy : IWebProxy
        {
            public ICredentials Credentials { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public Uri GetProxy(Uri destination) => throw new NotImplementedException();
            

            public bool IsBypassed(Uri host) => throw new NotImplementedException();
        }
    }
}
