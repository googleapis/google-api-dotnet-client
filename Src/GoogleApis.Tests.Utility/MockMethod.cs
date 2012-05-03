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

using System.Collections.Generic;
using Google.Apis.Discovery;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// A mock method for testing purposes.
    /// </summary>
    public class MockMethod : IMethod
    {
        #region IMethod Members

        public string Name { get; set; }

        public string Description { get; set; }

        public string RestPath { get; set; }

        public string RpcName { get; set; }

        public string HttpMethod { get; set; }

        public string ResponseType { get; set; }

        public string RequestType { get; set; }

        public bool HasBody { get; set; }

        public Dictionary<string, IParameter> Parameters { get; set; }

        public IEnumerable<string> ParameterOrder { get; set; }

        public MediaUpload MediaUpload { get; set; }
        
        #endregion
    }
}