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
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Interface for decoration of the public properties generated on schema.
    /// These decorators are child decorators of the StandardPropertyDecorator.
    /// </summary>
    public interface IPropertyDecorator
    {
        /// <summary>
        /// Decorate the CodeDom property member.
        /// </summary>
        /// <param name="propertyDefinition">CodeDom property object.</param>
        /// <param name="propertyPair">The name/value pair representing a property in the schema.</param>
        void DecorateProperty(
            CodeMemberProperty propertyDefinition,
            KeyValuePair<string, JsonSchema> propertyPair);
    }
}
