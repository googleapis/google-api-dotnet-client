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
    /// <summary>Represents a method's parameter.</summary>
    public class Parameter : IParameter
    {
        public string Name { get; set; }
        public string Pattern { get; set; }
        public bool IsRequired { get; set; }
        public string ParameterType { get; set; }
        public string DefaultValue { get; set; }
    }
}
