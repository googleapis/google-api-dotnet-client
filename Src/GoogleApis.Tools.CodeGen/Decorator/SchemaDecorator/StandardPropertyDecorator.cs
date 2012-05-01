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
using System.Linq;
using Google.Apis.Discovery.Schema;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds all the properties (getters and setters) for schema classes.
    /// This depends on fields being added by StandardFieldDecorator, or similar.
    /// </summary>
    public class StandardPropertyDecorator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<StandardPropertyDecorator>();

        private readonly IEnumerable<IPropertyDecorator> propertyDecorators;

        public StandardPropertyDecorator(params IPropertyDecorator[] propertyDecorators)
        {
            propertyDecorators.ThrowIfNull("propertyDecorators");
            this.propertyDecorators = propertyDecorators;
        }

        #region INestedClassSchemaDecorator Members

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                          INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            implDetails.ThrowIfNull("details");
            internalClassProvider.ThrowIfNull("internalClassProvider");

            SchemaImplementationDetails details = implDetails[schema];

            typeDeclaration.Members.AddRange(
                GenerateAllProperties(name, schema, implDetails, internalClassProvider, 
                                      typeDeclaration.Name)
                     .ToArray());
        }

        #endregion

        #region ISchemaDecorator Members

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclatation");
            schema.ThrowIfNull("schema");
            implDetails.ThrowIfNull("implDetails");
            
            typeDeclaration.Members.AddRange(
                GenerateAllProperties(
                    schema.Name, schema.SchemaDetails, implDetails, internalClassProvider, typeDeclaration.Name).
                    ToArray());
        }

        #endregion

        [VisibleForTestOnly]
        internal IList<CodeMemberProperty> GenerateAllProperties(string name,
                                                                 JsonSchema schema,
                                                                 IDictionary<JsonSchema, SchemaImplementationDetails>
                                                                     implDetails,
                                                                 INestedClassProvider internalClassProvider,
                                                                 params string[] usedWordsInContext)
        {
            schema.ThrowIfNull("schema");
            name.ThrowIfNullOrEmpty("name");
            logger.Debug("Adding properties for {0}", name);

            var fields = new List<CodeMemberProperty>();

            if (schema.Properties.IsNullOrEmpty())
            {
                logger.Debug("No properties found for schema " + name);
                return fields;
            }


            IEnumerable<string> allUsedWordsInContext = usedWordsInContext.Concat(schema.Properties.Keys);
            int index = 0;
            foreach (var propertyPair in schema.Properties)
            {
                SchemaImplementationDetails details = implDetails[propertyPair.Value];

                CodeMemberProperty property = GenerateProperty(
                    propertyPair.Key, propertyPair.Value, details, index++, internalClassProvider,
                    allUsedWordsInContext.Except(new[] { propertyPair.Key }));

                foreach (var decorator in propertyDecorators)
                {
                    decorator.DecorateProperty(property, propertyPair);
                }

                fields.Add(property);
            }
            return fields;
        }

        [VisibleForTestOnly]
        internal CodeMemberProperty GenerateProperty(string name,
                                                     JsonSchema propertySchema,
                                                     SchemaImplementationDetails details,
                                                     int index,
                                                     INestedClassProvider internalClassProvider,
                                                     IEnumerable<string> disallowedNames)
        {
            name.ThrowIfNullOrEmpty("name");
            propertySchema.ThrowIfNull("propertySchema");

            var ret = new CodeMemberProperty();
            ret.Name = SchemaDecoratorUtil.GetPropertyName(name, disallowedNames);
            ret.Type = SchemaDecoratorUtil.GetCodeType(propertySchema, details, internalClassProvider);
            ret.Attributes = MemberAttributes.Public;

            ret.HasGet = true;
            var fieldReference = new CodeFieldReferenceExpression(
                new CodeThisReferenceExpression(), SchemaDecoratorUtil.GetFieldName(name, disallowedNames));
            ret.GetStatements.Add(new CodeMethodReturnStatement(fieldReference));

            ret.HasSet = true;
            var parameterReference = new CodeVariableReferenceExpression("value");
            ret.SetStatements.Add(new CodeAssignStatement(fieldReference, parameterReference));

            return ret;
        }
    }
}