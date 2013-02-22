/*
Copyright 2013 Google Inc.
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
using System.Linq;
using System.Text;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Runtime Parametert represents a parameter which is used on the service runtime. <br/>
    /// <code>IClientService</code> contains parameters which are common to all requests <br/>
    /// <code>ServiceRequest</code> contains parameters which are relevant for the specific requesut.
    /// </summary>
    internal class RuntimeParameter : IParameter
    {
        public string Name { get; internal set; }
        public string Pattern { get; internal set; }
        public bool IsRequired { get; internal set; }
        public string ParameterType { get; internal set; }
        public string DefaultValue { get; internal set; }
        public IEnumerable<string> EnumValues { get; internal set; }
    }
}
