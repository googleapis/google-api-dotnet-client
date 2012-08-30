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
using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;

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
        /// <summary>
        /// Decorates the schema class with the information provided by this decorator. For example a 
        /// ISchemaDecorator could add a constructor, or properties to the Schema class that we are generating
        /// </summary>
        /// <param name="typeDeclaration">Class to decorate</param>
        /// <param name="schema">Source schema to use</param>
        /// <param name="implDetails">Further implementation details for all decorators</param>
        /// <param name="internalClassProvider">Provider which is used for the generation of nested classes</param>
        void DecorateClass(CodeTypeDeclaration typeDeclaration,
                           ISchema schema,
                           IDictionary<JsonSchema,SchemaImplementationDetails> implDetails,
                           INestedClassProvider internalClassProvider);
    }
}