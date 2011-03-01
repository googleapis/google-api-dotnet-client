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

using Newtonsoft.Json.Schema;

using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen
{
    public class SchemaDecoratorUtil
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(SchemaDecoratorUtil));
        
        private SchemaDecoratorUtil ()
        {
            throw new NotSupportedException("Please Don't construct");
        }
        
        internal static string GetFieldName(string name, int index)
        {
            return GeneratorUtils.GetFieldName(name, index);
        }
        
        internal static string GetPropertyName(string name, int index)
        {
            return GeneratorUtils.GetPropertyName(name, index);
        }
        
        internal static CodeTypeReference GetCodeType(JsonSchema propertySchema, INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            if( propertySchema.Type.HasValue == false )
            {
                throw new NotSupportedException("propertySchema has no Type. " + propertySchema.ToString());
            }
            switch(propertySchema.Type.Value)
            {
                case JsonSchemaType.String:
                    return new CodeTypeReference(typeof(string));
                case JsonSchemaType.Integer:
                    return new CodeTypeReference(typeof(long));
                case JsonSchemaType.Boolean:
                    return new CodeTypeReference(typeof(bool));
                case JsonSchemaType.Float:
                    return new CodeTypeReference(typeof(double));
                case JsonSchemaType.Array:
                    return GetArrayTypeRefereence(propertySchema, internalClassProvider);
                case JsonSchemaType.Object:
                    return GetObjectTypeReference(propertySchema, internalClassProvider);  
                case JsonSchemaType.Any:
                    return new CodeTypeReference(typeof(string));
                default:
                    logger.WarnFormat("Found currently unsupported type {0} as part of {1}", propertySchema.Type.Value, propertySchema.ToString());
                    return new CodeTypeReference(typeof(object));
            }
        }
        
        internal static CodeTypeReference GetObjectTypeReference(JsonSchema propertySchema, INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            if( propertySchema.Type != JsonSchemaType.Object)
            {
                throw new ArgumentException("Must be of JsonSchemaType.Array","propertySchema");    
            }
            if ( propertySchema.Id.IsNotNullOrEmpty())
            {
                logger.DebugFormat("Found Object with id using type {0}", propertySchema.Id);
                return new CodeTypeReference(propertySchema.Id);
            }
            
            
            return internalClassProvider.GetClassName(propertySchema);
        }
        
        [VisibleForTestOnly]
        internal static CodeTypeReference GetArrayTypeRefereence(JsonSchema propertySchema, INestedClassProvider internalClassProvider)
        {
            propertySchema.ThrowIfNull("propertySchema");
            if( propertySchema.Type != JsonSchemaType.Array)
            {
                throw new ArgumentException("Must be of JsonSchemaType.Array","propertySchema");    
            }
            
            var arrayItems = propertySchema.Items;
            if(arrayItems != null && arrayItems.Count == 1 )
            {
                if(arrayItems[0].Id.IsNotNullOrEmpty())
                {
                    return new CodeTypeReference("IList<" + arrayItems[0].Id + ">");
                }
                string arrayType = "IList<" + GetCodeType(arrayItems[0], internalClassProvider).BaseType + ">";
                logger.DebugFormat("type for array {0}", arrayType);
                return new CodeTypeReference(arrayType);
            }
            
            logger.WarnFormat("Found Array of unhandled type. {0}", propertySchema.ToString());
            return new CodeTypeReference("IList");
        }
    }
}
