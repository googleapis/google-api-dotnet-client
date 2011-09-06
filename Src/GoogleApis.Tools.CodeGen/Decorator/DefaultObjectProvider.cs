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

using System.CodeDom;
using Google.Apis.Discovery;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator
{
    /// <summary>
    /// The default object type provider. Returns references to schema types.
    /// </summary>
    public class DefaultObjectTypeProvider : IObjectTypeProvider
    {
        private readonly string schemaNamespace;

        /// <summary>
        /// Creates a new default object type provider using the specified namespace name.
        /// </summary>
        /// <param name="schemaNamespace"></param>
        public DefaultObjectTypeProvider(string schemaNamespace)
        {
            this.schemaNamespace = schemaNamespace;
        }

        #region IObjectTypeProvider Members

        public CodeTypeReference GetReturnType(IMethod method)
        {
            method.ThrowIfNull("method");
            return GeneratorUtils.GetSchemaReference(schemaNamespace, method.ResponseType);
        }

        public CodeTypeReference GetBodyType(IMethod method)
        {
            method.ThrowIfNull("method");
            return GeneratorUtils.GetSchemaReference(schemaNamespace, method.RequestType);
        }

        #endregion
    }
}
