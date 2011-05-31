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

using System.Collections.Generic;
using System.CodeDom;
using System.Linq;
using log4net;
using Newtonsoft.Json.Schema;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Decorator for standard property fields
    /// </summary>
    public class StandardPropertyFieldDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(StandardPropertyFieldDecorator));

        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            typeDeclaration.Members.AddRange(GenerateAllFields(name, schema, internalClassProvider).ToArray());
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            typeDeclaration.Members.AddRange(
                GenerateAllFields(schema.Name, schema.SchemaDetails, internalClassProvider).ToArray());
        }

        #endregion

        [VisibleForTestOnly]
        internal IList<CodeMemberField> GenerateAllFields(string name,
                                                          JsonSchema schema,
                                                          INestedClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNull("name");

            var fields = new List<CodeMemberField>();
            if (schema.Properties.IsNullOrEmpty())
            {
                logger.Debug("No Properties found for " + name);
                return fields;
            }

            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                fields.Add(
                    GenerateField(
                        propertyPair.Key, propertyPair.Value, index, internalClassProvider, schema.Properties.Keys));
                index++;
            }
            return fields;
        }

        [VisibleForTestOnly]
        internal CodeMemberField GenerateField(string name,
                                               JsonSchema propertySchema,
                                               int index,
                                               INestedClassProvider internalClassProvider,
                                               IEnumerable<string> otherFieldNames)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");
            internalClassProvider.ThrowIfNull("internalClassProvider");

            var ret = new CodeMemberField(
                SchemaDecoratorUtil.GetCodeType(propertySchema, internalClassProvider),
                SchemaDecoratorUtil.GetFieldName(name, index, otherFieldNames));
            ret.Attributes = MemberAttributes.Private;

            return ret;
        }
    }
}