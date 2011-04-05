/*
Copyright 2011 Google Inc

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

namespace Google.Apis.Samples.ApiExplorer
{
    /// <summary>
    /// Provides a set of properties to store and recreate a particular Api method call.
    /// </summary>
    public class MethodCallContext
    {
        public MethodCallContext(string service, string version, string resource, string method, IDictionary<string, string> parameters)
        {
            this.Service = service;
            this.Version = version;
            this.Resource = resource;
            this.Method = method;
            this.Parameters = parameters;
        }

        public string Service
        {
            get;
            private set;
        }

        public string Version
        {
            get;
            private set;
        }

        public string Resource
        {
            get;
            private set;
        }

        public string Method
        {
            get;
            private set;
        }

        public IDictionary<string, string> Parameters
        {
            get;
            private set;
        }
    }
}
