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
        
        public void DecoratClass (CodeTypeDeclaration typeDeclaration, ISchema schema, IInternalClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            typeDeclaration.Members.AddRange(GenerateAllProperties(schema, internalClassProvider).ToArray());
        }
        
        [VisibleForTestOnly]
        internal IList<CodeMemberProperty> GenerateAllProperties (ISchema schema, IInternalClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            schema.SchemaDetails.ThrowIfNull("schema.SchemaDetails");
            logger.DebugFormat("Adding properties for {0}", schema.Name);
            
            
            var fields = new List<CodeMemberProperty>();
            
            if ( schema.SchemaDetails.Properties.IsNullOrEmpty() )
            {
                logger.Debug("No proeprties found for schema " + schema.Name);
                return fields;
            }
            
            int index = 0;
            foreach (var propertyPair in schema.SchemaDetails.Properties)
            {
                fields.Add(GenerateProperty(propertyPair.Key, propertyPair.Value, index, internalClassProvider));
                index++;
            }
            return fields;
        }
        
        [VisibleForTestOnly]
        internal CodeMemberProperty GenerateProperty(string name, JsonSchema propertySchema, int index, 
                                                     IInternalClassProvider internalClassProvider)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");
            
            var ret = new CodeMemberProperty();
            ret.Name = SchemaDecoratorUtil.GetPropertyName(name, index);
            ret.Type = SchemaDecoratorUtil.GetCodeType(propertySchema, internalClassProvider);
            ret.Attributes = MemberAttributes.Public;
            
            ret.HasGet = true;
            var fieldReference = new CodeFieldReferenceExpression(
                                     new CodeThisReferenceExpression(), 
                                     SchemaDecoratorUtil.GetFieldName(name,index));
            ret.GetStatements.Add(new CodeMethodReturnStatement(fieldReference));
            
            ret.HasSet = true;
            var parameterReference = new CodeVariableReferenceExpression("value");
            ret.SetStatements.Add(new CodeAssignStatement(fieldReference, parameterReference));
            
            return ret;
        }
    }
}

