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
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds Newtonsoft.Json.JsonPropertyAttribute to each property.
    /// Requires StandardPropertyDecorator or similar to have run before this. 
    /// </summary>
    public class NewtonSoftPropertyAttributeDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(NewtonSoftPropertyAttributeDecorator));

        private static readonly CodeTypeReference jsonPropertyAttribute =
            new CodeTypeReference(typeof(JsonPropertyAttribute));

        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          INestedClassProvider internalClassProvider)
        {
            AddAttributesToAllProperties(name, schema, typeDeclaration);
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  INestedClassProvider internalClassProvider)
        {
            AddAttributesToAllProperties(schema.Name, schema.SchemaDetails, typeDeclaration);
        }

        #endregion

        [VisibleForTestOnly]
        internal void AddAttributesToAllProperties(string name, JsonSchema schema, CodeTypeDeclaration typeDeclaration)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            logger.DebugFormat("Adding attributes to properties for {0}", name);

            if (schema.Properties.IsNullOrEmpty())
            {
                logger.Debug("No proeprties found for schema " + name);
                return;
            }

            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                var schemaFieldName = propertyPair.Key;
                var propertyDefinition = SchemaUtil.FindCodePropertyForName(
                    typeDeclaration, schemaFieldName, index++, schema.Properties.Keys);
                propertyDefinition.CustomAttributes.Add(CreateAttribute(schemaFieldName));
            }
        }

        [VisibleForTestOnly]
        internal static CodeAttributeDeclaration CreateAttribute(string name)
        {
            var argument = new CodeAttributeArgument(new CodePrimitiveExpression(name));
            var attribute = new CodeAttributeDeclaration(jsonPropertyAttribute, new[] { argument });
            return attribute;
        }
    }
}