using System;
using System.CodeDom;

using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;
using System.Collections.Generic;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds Newtonsoft.Json.JsonPropertyAttribute to each property.
    /// Requires StandardPropertyDecorator or similar to have run before this. 
    /// </summary>
    public class NewtonSoftPropertyAttributeDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(NewtonSoftPropertyAttributeDecorator));
        
        private static readonly CodeTypeReference jsonPropertyAttribute = new CodeTypeReference(typeof(JsonPropertyAttribute));
        
        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration, 
                string name, JsonSchema schema, INestedClassProvider internalClassProvider)
        {
            AddAttributesToAllProperties(name, schema, typeDeclaration);
        }
        
        public void DecorateClass (CodeTypeDeclaration typeDeclaration, ISchema schema, INestedClassProvider internalClassProvider)
        {
            AddAttributesToAllProperties(schema.Name, schema.SchemaDetails, typeDeclaration);
        }
        
        [VisibleForTestOnly]
        internal void AddAttributesToAllProperties (string name, JsonSchema schema, CodeTypeDeclaration typeDeclaration)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            logger.DebugFormat("Adding attributes to properties for {0}", name);
            
            if ( schema.Properties.IsNullOrEmpty() )
            {
                logger.Debug("No proeprties found for schema " + name);
                return;
            }
            
            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                var schemaFieldName = propertyPair.Key;
                var propertyDefinition = FindCodePropertyForName(
                    typeDeclaration, schemaFieldName, index++,schema.Properties.Keys);
                propertyDefinition.CustomAttributes.Add(CreateAttribute(schemaFieldName));
            }
        }
        
        
        static internal CodeMemberProperty FindCodePropertyForName(CodeTypeDeclaration typeDeclaration, string name, int index, 
            IEnumerable<string> otherNames)
        {
            string propertyName = SchemaDecoratorUtil.GetPropertyName(name, index, otherNames);
            CodeMemberProperty property = typeDeclaration.Members.FindPropertyByName(propertyName);
            property.ThrowIfNull(string.Format("Failed to find property by name[{0}] for propertySchemaName[{1}]", propertyName, name));
            return property;
        }
        
        [VisibleForTestOnly]
        static internal CodeAttributeDeclaration CreateAttribute(string name)
        {
            var argument = new CodeAttributeArgument(new CodePrimitiveExpression(name));
            var attribute = new CodeAttributeDeclaration(jsonPropertyAttribute, new [] {argument});
            return attribute;
        }
       
    }
}

