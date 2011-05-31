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
using Google.Apis.Discovery.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Classes that implement this interface will add code to the 
    /// typeDeclaration based on the ISchema passed in.
    /// Example on class may add fields to the typeDeclaration to 
    /// represent each of the fields described in the schema
    /// </summary>
    /// <seealso cref="ISchema"/>
    public interface ISchemaDecorator
    {
        void DecorateClass(CodeTypeDeclaration typeDeclaration,
                           ISchema schema,
                           INestedClassProvider internalClassProvider);
    }
}