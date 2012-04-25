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

using System;
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen
{
    /// <summary>
    /// Utility class for the SchemaDecorator
    /// </summary>
    public static class SchemaDecoratorUtil
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType(typeof(SchemaDecoratorUtil));

        /// <summary>
        /// Generates a field name
        /// </summary>
        internal static string GetFieldName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GeneratorUtils.GetFieldName(name, wordsUsedInContext);
        }

        /// <summary>
        /// Generates a property name
        /// </summary>
        internal static string GetPropertyName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GeneratorUtils.GetPropertyName(name, wordsUsedInContext);
        }

        /// <summary>
        /// Returns a code type references for the specified json schema.
        /// Generates the appropriate references.
        /// </summary>
        internal static CodeTypeReference GetCodeType(JsonSchema propertySchema,
                                                      SchemaImplementationDetails details,
                                                      INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            if (propertySchema.Type.HasValue == false)
            {
                throw new NotSupportedException("propertySchema has no Type. " + propertySchema);
            }

            switch (propertySchema.Type.Value)
            {
                case JsonSchemaType.String:
                    return new CodeTypeReference(typeof(string));
                case JsonSchemaType.Integer:
                    return new CodeTypeReference(typeof(long?));
                case JsonSchemaType.Boolean:
                    return new CodeTypeReference(typeof(bool?));
                case JsonSchemaType.Float:
                    return new CodeTypeReference(typeof(double?));
                case JsonSchemaType.Array:
                    return GetArrayTypeReference(propertySchema, details, internalClassProvider);
                case JsonSchemaType.Object:
                    return GetObjectTypeReference(propertySchema, details, internalClassProvider);
                case JsonSchemaType.Any:
                    return new CodeTypeReference(typeof(string));
                default:
                    logger.Warning(
                        "Found currently unsupported type {0} as part of {1}", propertySchema.Type.Value,
                        propertySchema);
                    return new CodeTypeReference(typeof(object));
            }
        }

        /// <summary>
        /// Resolves/generates an object type reference for a schema.
        /// </summary>
        internal static CodeTypeReference GetObjectTypeReference(JsonSchema propertySchema,
                                                                 SchemaImplementationDetails details,
                                                                 INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            if (propertySchema.Type != JsonSchemaType.Object)
            {
                throw new ArgumentException("Must be of JsonSchemaType.Array", "propertySchema");
            }
            if (propertySchema.Id.IsNotNullOrEmpty())
            {
                logger.Debug("Found Object with id using type {0}", propertySchema.Id);
                return new CodeTypeReference(propertySchema.Id);
            }

            return internalClassProvider.GetClassName(propertySchema, details);
        }

        /// <summary>
        /// Resolves/generates an array type reference for a schema.
        /// </summary>
        [VisibleForTestOnly]
        internal static CodeTypeReference GetArrayTypeReference(JsonSchema propertySchema,
                                                                 SchemaImplementationDetails details,
                                                                 INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            if (propertySchema.Type != JsonSchemaType.Array)
            {
                throw new ArgumentException("Must be of JsonSchemaType.Array", "propertySchema");
            }

            var arrayItems = propertySchema.Items;
            if (arrayItems != null && arrayItems.Count == 1)
            {
                CodeTypeReference itemType = arrayItems[0].Id.IsNotNullOrEmpty()
                    ? new CodeTypeReference(arrayItems[0].Id)
                    : GetCodeType(arrayItems[0], details, internalClassProvider);
                logger.Debug("type for array {0}", itemType.BaseType);
                return new CodeTypeReference(typeof(IList<>))
                {
                    TypeArguments = { itemType }
                };
            }

            logger.Warning("Found Array of unhandled type. {0}", propertySchema);
            return new CodeTypeReference(typeof(System.Collections.IList));
        }
    }
}