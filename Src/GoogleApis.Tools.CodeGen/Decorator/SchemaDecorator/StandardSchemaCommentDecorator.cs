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
using System.Security;

using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    public class StandardSchemaCommentDecorator:ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(StandardSchemaCommentDecorator));
        
        public StandardSchemaCommentDecorator ()
        {
        }
        
        public void DecorateClass (CodeTypeDeclaration typeDeclaration, ISchema schema, INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            schema.SchemaDetails.ThrowIfNull("schema.SchemaDetails");
            
            typeDeclaration.Comments.AddRange(CreateComment(schema.SchemaDetails));
            AddCommentsToAllProperties(schema.Name, schema.SchemaDetails, typeDeclaration);
        }
        
        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration, string name, JsonSchema schema,
                                          INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            
            typeDeclaration.Comments.AddRange(CreateComment(schema));
            AddCommentsToAllProperties(name, schema, typeDeclaration);
        }
        
        [VisibleForTestOnly]
        internal void AddCommentsToAllProperties (string name, JsonSchema schema, CodeTypeDeclaration typeDeclaration)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            typeDeclaration.ThrowIfNull("typeDeclaration");
            
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
                var propertyDefinition = SchemaUtil.FindCodePropertyForName(
                    typeDeclaration, schemaFieldName, index++,schema.Properties.Keys);
                propertyDefinition.Comments.AddRange(CreateComment(propertyPair.Value));
            }
        }
        
        [VisibleForTestOnly]
        internal CodeCommentStatementCollection CreateComment(JsonSchema schmea)
        {
            schmea.ThrowIfNull("schema");
            
            var comments = new CodeCommentStatementCollection();
            var text = "<summary>" + XmlEscapeComment(schmea.Description) + "</summary>";
            
            if ( schmea.Description.IsNotNullOrEmpty() )
            {
                comments.Add(new CodeCommentStatement(new CodeComment(text, true)));
            }
            return comments;
        }
        
        private string XmlEscapeComment(string description)
        {
            return SecurityElement.Escape(description);
        }
    }
}

