/*
Copyright 2013 Google Inc

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
using Google.Apis.Requests;

namespace Google.Apis.Testing
{
    /// <summary> A mock service request for testing purposes. </summary>
    public class MockClientServiceRequest : IClientServiceRequest
    {
        public string MethodName { get; set; }
        public string RestPath { get; set; }
        public string HttpMethod { get; set; }

        public System.IO.Stream FetchAsStream()
        {
            throw new NotImplementedException();
        }

        public void FetchAsyncAsStream(ExecuteRequestDelegate<System.IO.Stream> methodToCall = null)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, IParameter> RequestParameters { get; set; }
    }
}
