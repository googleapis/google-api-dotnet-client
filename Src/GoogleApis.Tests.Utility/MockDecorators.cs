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
using System.Linq;
using System.Text;

using Google.Apis.Authentication;
using Google.Apis.Discovery;

namespace Google.Apis.Testing
{
    /// <summary>
    /// Mock base class to test <code>BaseClientServiceAbstractPropertiesDecorator</code> is compiled.
    /// Because <code>BaseClientRequestAbstractPropertiesDecorator</code> creates overrides properties we must
    /// have a base class that declare those abstract properties, otherwise the class won't compile.
    /// We can't use <code>BaseClientService</code> here becuase it contains other properties which the 
    /// tested decorator doesn't implemented.
    /// </summary>
    public abstract class MockBaseClientServiceAbstractPropertiesDecorator
    {
        public abstract IDictionary<string, IParameter> ServiceParameters { get; }
        public abstract IList<string> Features { get; }
        public abstract string BaseUri { get; }
        public abstract string BasePath { get; }
        public abstract string Name { get; }
    }
}
