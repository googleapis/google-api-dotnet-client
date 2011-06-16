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
using System.Collections.Generic;
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// A given schema may contain nested classes, classes that implement this method may 
    /// decorate those internal classes, often classes that implement this 
    /// interface will also implement ISchemaDecorator
    /// </summary>
    /// <seealso cref="ISchemaDecorator"/> 
    public interface INestedClassSchemaDecorator
    {
        /// <summary>
        /// Decorates the schema class with the information provided by this decorator. For example a 
        /// INestedClassSchemaDecorator could add a constructor, or properties to the nested schema class 
        /// that we are generating.
        /// </summary>
        /// <param name="typeDeclaration">Nested class to decorate.</param>
        /// <param name="name">Name of this class.</param>
        /// <param name="schema">Schema describing this class.</param>
        /// <param name="implDetails">Details for the implementation.</param>
        /// <param name="internalClassProvider">Provider used for generating nested classes.</param>
        void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                   string name,
                                   JsonSchema schema,
                                   IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                   INestedClassProvider internalClassProvider);
    }
}