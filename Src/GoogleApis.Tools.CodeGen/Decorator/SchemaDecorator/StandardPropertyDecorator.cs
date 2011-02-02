using System;
using System.Collections.Generic;
using System.CodeDom;
using System.Linq;

using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    public class StandardPropertyDecorator: ISchemaDecorator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(StandardPropertyDecorator));
        
        public StandardPropertyDecorator ()
        {
        }
        
        public void DecoratClass (CodeTypeDeclaration typeDeclaration, ISchema schema)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            typeDeclaration.Members.AddRange(GenerateAllFields(schema).ToArray());
            typeDeclaration.Members.AddRange(GenerateAllProperties(schema).ToArray());
        }
        
        
        [VisibleForTestOnly]
        internal IList<CodeMemberField> GenerateAllFields (ISchema schema)
        {
            schema.ThrowIfNull("schema");
            
            var fields = new List<CodeMemberField>();
            int index = 0;
            foreach (var propertyPair in schema.SchemaDetails.Properties)
            {
                fields.Add(GenerateField(propertyPair.Key, propertyPair.Value, index));
                index++;
            }
            return fields;
        }
        
        [VisibleForTestOnly]
        internal CodeMemberField GenerateField(string name, JsonSchema propertySchema, int index)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");
            
            var ret = new CodeMemberField(GetCodeType(propertySchema), GetFieldName(name, index));
            ret.Attributes = MemberAttributes.Private;
            
            return ret;
        }
        
        [VisibleForTestOnly]
        internal CodeTypeReference GetCodeType(JsonSchema propertySchema)
        {
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
                    return new CodeTypeReference(typeof(float));
                default:
                    logger.WarnFormat("Found currently unsupported type {0} as part of {1}", propertySchema.Type.Value, propertySchema.ToString());
                    return new CodeTypeReference(typeof(object));
            }
        }
        
        [VisibleForTestOnly]
        internal IList<CodeTypeMember> GenerateAllProperties (ISchema schema)
        {
            var properties = new List<CodeTypeMember>();
            return properties;
        }
        
        [VisibleForTestOnly]
        internal string GetFieldName(string name, int index)
        {
            return GeneratorUtils.GetFieldName(name, index);
        }
        
        [VisibleForTestOnly]
        internal string GetPropertyName(string name, int index)
        {
            return GeneratorUtils.GetPropertyName(name, index);
        }
        
        
    }
}

