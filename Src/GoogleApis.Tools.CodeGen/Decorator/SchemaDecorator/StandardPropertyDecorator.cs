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
using Google.Apis.Tools.CodeGen.Generator;
using log4net;
using Newtonsoft.Json.Schema;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds all the properties (getters and setters) for schema classes.
    /// This depends on fields being added by StandardFieldDecorator, or similar.
    /// </summary>
    public class StandardPropertyDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(StandardPropertyDecorator));

        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");
            typeDeclaration.Members.AddRange(GenerateAllProperties(name, schema, internalClassProvider).ToArray());
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  SchemaImplementationDetails implDetails,
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            typeDeclaration.Members.AddRange(
                GenerateAllProperties(schema.Name, schema.SchemaDetails, internalClassProvider).ToArray());
        }

        #endregion

        [VisibleForTestOnly]
        internal IList<CodeMemberProperty> GenerateAllProperties(string name,
                                                                 JsonSchema schema,
                                                                 INestedClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            logger.DebugFormat("Adding properties for {0}", name);


            var fields = new List<CodeMemberProperty>();

            if (schema.Properties.IsNullOrEmpty())
            {
                logger.Debug("No proeprties found for schema " + name);
                return fields;
            }

            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                fields.Add(
                    GenerateProperty(
                        propertyPair.Key, propertyPair.Value, index++, internalClassProvider, schema.Properties.Keys));
            }
            return fields;
        }

        [VisibleForTestOnly]
        internal CodeMemberProperty GenerateProperty(string name,
                                                     JsonSchema propertySchema,
                                                     int index,
                                                     INestedClassProvider internalClassProvider,
                                                     IEnumerable<string> otherPropertyNames)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");

            var ret = new CodeMemberProperty();
            ret.Name = SchemaDecoratorUtil.GetPropertyName(name, index, otherPropertyNames);
            ret.Type = SchemaDecoratorUtil.GetCodeType(propertySchema, internalClassProvider);
            ret.Attributes = MemberAttributes.Public;

            ret.HasGet = true;
            var fieldReference = new CodeFieldReferenceExpression(
                new CodeThisReferenceExpression(), SchemaDecoratorUtil.GetFieldName(name, index, otherPropertyNames));
            ret.GetStatements.Add(new CodeMethodReturnStatement(fieldReference));

            ret.HasSet = true;
            var parameterReference = new CodeVariableReferenceExpression("value");
            ret.SetStatements.Add(new CodeAssignStatement(fieldReference, parameterReference));

            return ret;
        }
    }
}