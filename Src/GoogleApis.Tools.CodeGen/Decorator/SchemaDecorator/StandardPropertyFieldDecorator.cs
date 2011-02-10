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
    public class StandardPropertyFieldDecorator:ISchemaDecorator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(StandardPropertyFieldDecorator));
        
        public StandardPropertyFieldDecorator ()
        {
        }
        
        public void DecoratClass (CodeTypeDeclaration typeDeclaration, ISchema schema, IInternalClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            typeDeclaration.Members.AddRange(GenerateAllFields(schema, internalClassProvider).ToArray());            
        }
        
        [VisibleForTestOnly]
        internal IList<CodeMemberField> GenerateAllFields (ISchema schema, IInternalClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            schema.SchemaDetails.ThrowIfNull("schema.SchemaDetails");
            
            var fields = new List<CodeMemberField>();
            if ( schema.SchemaDetails.Properties.IsNullOrEmpty() )
            {
                logger.Debug("No Properties found for " + schema.Name);
                return fields;
            }
            
            int index = 0;
            foreach (var propertyPair in schema.SchemaDetails.Properties)
            {
                fields.Add(GenerateField(propertyPair.Key, propertyPair.Value, index, internalClassProvider));
                index++;
            }
            return fields;
        }
        
        [VisibleForTestOnly]
        internal CodeMemberField GenerateField(string name, JsonSchema propertySchema, int index, IInternalClassProvider internalClassProvider)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");
            
            var ret = new CodeMemberField(SchemaDecoratorUtil.GetCodeType(propertySchema, internalClassProvider), SchemaDecoratorUtil.GetFieldName(name, index));
            ret.Attributes = MemberAttributes.Private;
            
            return ret;
        }
    }
}

