/*
Copyright 2020 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests
{
    public class ClientServiceRequestExtensionsTest
    {
        [Fact]
        public void Configure_NullRequest()
        {
            TestRequest request = null;
            Assert.Throws<ArgumentNullException>(() => request.Configure(r => { }));
        }

        [Fact]
        public void Configure_NullConfigureAction()
        {
            var request = new TestRequest(new MockClientService());
            Assert.Throws<ArgumentNullException>(() => request.Configure(null));
        }

        [Fact]
        public void Configure_Valid()
        {
            var request = new TestRequest(new MockClientService());
            Assert.Null(request.ArbitraryQueryParameter);
            var result = request.Configure(r => r.ArbitraryQueryParameter = "value");
            Assert.Same(request, result);
            Assert.Equal("value", request.ArbitraryQueryParameter);
        }

        private class TestRequest : ClientServiceRequest<string>
        {
            public TestRequest(IClientService service) : base(service)
            {
            }

            public override string MethodName => throw new NotImplementedException();
            public override string RestPath => throw new NotImplementedException();
            public override string HttpMethod => throw new NotImplementedException();
            protected override object GetBody() => throw new NotImplementedException();

            public string ArbitraryQueryParameter { get; set; }
        }
    }
}
