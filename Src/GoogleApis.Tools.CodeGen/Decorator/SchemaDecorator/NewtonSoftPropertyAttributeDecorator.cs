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
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds Newtonsoft.Json.JsonPropertyAttribute to each property.
    /// Requires StandardPropertyDecorator or similar to have run before this. 
    /// </summary>
    public class NewtonSoftPropertyAttributeDecorator : IPropertyDecorator
    {
        private static readonly CodeTypeReference jsonPropertyAttribute =
            new CodeTypeReference(typeof(JsonPropertyAttribute));

        #region IPropertyDecorator Members

        public void DecorateProperty(CodeMemberProperty propertyDefinition, KeyValuePair<string, JsonSchema> propertyPair)
        {
            propertyDefinition.CustomAttributes.Add(CreateAttribute(propertyPair.Key));
        }

        #endregion

        [VisibleForTestOnly]
        internal static CodeAttributeDeclaration CreateAttribute(string name)
        {
            var argument = new CodeAttributeArgument(new CodePrimitiveExpression(name));
            var attribute = new CodeAttributeDeclaration(jsonPropertyAttribute, new[] { argument });
            return attribute;
        }
    }
}