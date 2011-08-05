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
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Decorator which adds comments to schemas
    /// </summary>
    public class StandardSchemaCommentDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<StandardSchemaCommentDecorator>();

        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                          INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            implDetails.ThrowIfNull("details");
            internalClassProvider.ThrowIfNull("internalClassProvider");

            typeDeclaration.Comments.AddRange(CreateComment(schema));
            AddCommentsToAllProperties(name, schema, typeDeclaration);
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            implDetails.ThrowIfNull("implDetails");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            schema.SchemaDetails.ThrowIfNull("schema.SchemaDetails");

            typeDeclaration.Comments.AddRange(CreateComment(schema.SchemaDetails));
            AddCommentsToAllProperties(schema.Name, schema.SchemaDetails, typeDeclaration);
        }

        #endregion

        [VisibleForTestOnly]
        internal void AddCommentsToAllProperties(string name, JsonSchema schema, CodeTypeDeclaration typeDeclaration)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            typeDeclaration.ThrowIfNull("typeDeclaration");

            logger.Debug("Adding attributes to properties for {0}", name);

            if (schema.Properties.IsNullOrEmpty())
            {
                logger.Debug("No properties found for schema " + name);
                return;
            }

            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                var schemaFieldName = propertyPair.Key;
                var propertyDefinition = SchemaUtil.FindCodePropertyForName(
                    typeDeclaration, schemaFieldName, index++, schema.Properties.Keys);
                propertyDefinition.Comments.AddRange(CreateComment(propertyPair.Value));
            }
        }

        [VisibleForTestOnly]
        internal CodeCommentStatementCollection CreateComment(JsonSchema schema)
        {
            schema.ThrowIfNull("schema");
            return DecoratorUtil.CreateSummaryComment(schema.Description);
        }
    }
}