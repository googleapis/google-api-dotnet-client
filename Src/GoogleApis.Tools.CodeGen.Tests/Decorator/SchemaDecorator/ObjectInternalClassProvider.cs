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

using System.CodeDom;
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Tests
{
    /// <summary>
    /// Simple implementation of IInteralClassProvider, always returns object. For use in tests only. 
    /// </summary>
    public class ObjectInternalClassProvider : INestedClassProvider
    {
        #region INestedClassProvider Members

        public CodeTypeReference GetClassName(JsonSchema definition, SchemaImplementationDetails details)
        {
            return new CodeTypeReference(typeof(object));
        }

        #endregion
    }
}