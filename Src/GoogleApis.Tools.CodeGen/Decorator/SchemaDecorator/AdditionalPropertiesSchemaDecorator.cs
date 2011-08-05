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
using System.Collections.Generic;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// This decorator implements the "AdditionalProperties" tag of a json schema.
    /// The "AdditionalProperties" tag is used to implement a collection of properties, whose names are not yet
    /// known at the time of discovery. 
    /// 
    /// The decorator adds a dictionary as a base type to support this feature. Example:
    ///   public class ResourcesData : Dictionary&lt;string,ResourcesData.Restresource&rt; { ... }
    /// </summary>
    public class AdditionalPropertiesSchemaDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                          INestedClassProvider internalClassProvider)
        {
            ImplementAdditionalProperties(typeDeclaration, schema, implDetails, internalClassProvider);
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                  INestedClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            ImplementAdditionalProperties(typeDeclaration, schema.SchemaDetails, implDetails, internalClassProvider);
        }

        #endregion

        /// <summary>
        /// Implements the additionalProperties tag on this schema if required.
        /// </summary>
        [VisibleForTestOnly]
        internal void ImplementAdditionalProperties(CodeTypeDeclaration type,
                                                    JsonSchema schema,
                                                    IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                                    INestedClassProvider internalClassProvider)
        {
            // Validate the input parameters.
            type.ThrowIfNull("type");
            schema.ThrowIfNull("schema");
            implDetails.ThrowIfNull("implDetails");
            internalClassProvider.ThrowIfNull("internalClassProvider");

            // Check if this decorator applies to the specified json schema.
            if (schema.AdditionalProperties == null)
            {
                return;
            }

            // Note/ToDo: Currently we only support AdditionalProperties for schemas
            //            specifiying no normal properties, as these won't be used
            //            by the newtonsoft json library if a dictionary is specified.
            if (schema.Properties != null && schema.Properties.Count > 0)
            {
                type.Comments.Add(new CodeCommentStatement("TODO: Add support for additionalProperties on schemas"));
                type.Comments.Add(new CodeCommentStatement("      which have normal properties defined."));
                return;
            }

            // Generate the underlying type.
            SchemaImplementationDetails details = implDetails[schema];
            CodeTypeReference underlyingTypeRef = SchemaDecoratorUtil.GetCodeType(
                schema.AdditionalProperties, details, internalClassProvider);

            // Add the base type reference.
            CodeTypeReference dictionaryRef = new CodeTypeReference(typeof(Dictionary<,>));
            dictionaryRef.TypeArguments.Add(typeof(string));
            dictionaryRef.TypeArguments.Add(underlyingTypeRef);
            type.BaseTypes.Add(dictionaryRef);
        }
    }
}