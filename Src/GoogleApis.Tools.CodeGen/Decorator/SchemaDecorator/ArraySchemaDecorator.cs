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
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Decorator for schemas which represent an array themself (type: array)
    /// This Decorator constructs an IList implementation for the schema
    /// </summary>
    public class ArraySchemaDecorator : ISchemaDecorator
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ArraySchemaDecorator>();

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

            JsonSchema details = schema.SchemaDetails;
            details.ThrowIfNull("schemaDetails");

            // Check if this decorator can be applied to the schema);
            if (details.Type != JsonSchemaType.Array)
            {
                return;
            }

            if (details.Items == null || details.Items.Count != 1)
            {
                logger.Warning("Found array scheme of unhandled type. {0}", details);
                return; // not supported
            }

            // Generate or find the nested type
            JsonSchema itemScheme = details.Items[0];
            SchemaImplementationDetails implDetail = implDetails[itemScheme];
            implDetail.ProposedName = "Entry"; // Change the name to a custom one.
            CodeTypeReference item = SchemaDecoratorUtil.GetCodeType(itemScheme, implDetail, internalClassProvider);

            // Insert the base type before any interface declaration
            typeDeclaration.BaseTypes.Insert(0, new CodeTypeReference(typeof(List<>))
                {
                    TypeArguments = { item }
                });
        }

        #endregion
    }
}