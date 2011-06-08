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

using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Util;
using log4net;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Schema Generator
    /// </summary>
    public class SchemaGenerator : BaseGenerator
    {
        private readonly IEnumerable<ISchemaDecorator> decorators;

        public SchemaGenerator(IEnumerable<ISchemaDecorator> decorators)
        {
            decorators.ThrowIfNull("decorators");
            this.decorators = decorators;
        }

        /// <summary>
        /// Creates a fully working class for the specified schema
        /// </summary>
        public CodeTypeDeclaration CreateClass(ISchema schema,
                                               IDictionary<JsonSchema, SchemaImplementationDetails> detailCollection,
                                               IEnumerable<string> otherSchemaNames)
        {
            schema.ThrowIfNull("schema");
            detailCollection.ThrowIfNull("detailCollection");
            otherSchemaNames.ThrowIfNull("otherSchemaNames");

            // Retrieve details
            SchemaImplementationDetails details = null;
            if (detailCollection.ContainsKey(schema.SchemaDetails))
            {
                details = detailCollection[schema.SchemaDetails];
            }

            string className = GeneratorUtils.GetClassName(schema, otherSchemaNames);
            var typeDeclaration = new CodeTypeDeclaration(className);
            var nestedClassGenerator = new NestedClassGenerator(typeDeclaration, decorators, "");
            foreach (ISchemaDecorator schemaDecorator in decorators)
            {
                schemaDecorator.DecorateClass(typeDeclaration, schema, details, nestedClassGenerator);
            }
            nestedClassGenerator.GenerateNestedClasses(detailCollection);

            return typeDeclaration;
        }

        #region Nested type: NestedClassGenerator

        [VisibleForTestOnly]
        internal class NestedClassGenerator : INestedClassProvider
        {
            private static readonly ILog logger = LogManager.GetLogger(typeof(NestedClassGenerator));

            private readonly IEnumerable<ISchemaDecorator> decorators;

            /// <summary>
            /// Maps Schemas to the index they appared so schemas found multiple time will resolve to the same name.
            /// This also allows us to generate the internal classes at the end instead of as we find them.
            /// </summary>
            private readonly IDictionary<JsonSchema, int> schemaOrder;

            private readonly CodeTypeDeclaration typeDeclaration;

            /// <summary>A string to make this nested class names unique</summary>
            private readonly string uniquefier;

            private int nextSchemaNumber;

            public NestedClassGenerator(CodeTypeDeclaration typeDeclaration,
                                        IEnumerable<ISchemaDecorator> decorators,
                                        string uniquefier)
            {
                this.typeDeclaration = typeDeclaration;
                this.decorators = decorators;
                schemaOrder = new Dictionary<JsonSchema, int>();
                nextSchemaNumber = 1;
                this.uniquefier = uniquefier;
            }

            #region INestedClassProvider Members

            /// <summary>
            /// Gets a class name as a CodeTypeReference for the given schema of the form "IntenalClassN" where 
            /// N is an integer. Given the same JsonSchema this will return the same classname.
            /// </summary>
            public CodeTypeReference GetClassName(JsonSchema definition)
            {
                if (schemaOrder.ContainsKey(definition))
                {
                    return GetSchemaName(schemaOrder[definition]);
                }
                int schemaNumber = nextSchemaNumber++;
                schemaOrder.Add(definition, schemaNumber);
                return GetSchemaName(schemaNumber);
            }

            #endregion

            public void GenerateNestedClasses(IDictionary<JsonSchema, SchemaImplementationDetails> detailCollection)
            {
                foreach (var pair in schemaOrder)
                {
                    typeDeclaration.Members.Add(GenerateNestedClass(pair.Key, detailCollection, pair.Value));
                }
            }

            [VisibleForTestOnly]
            internal CodeTypeDeclaration GenerateNestedClass(JsonSchema schema,
                                                             IDictionary<JsonSchema, SchemaImplementationDetails>
                                                                 detailCollection,
                                                             int orderOfNestedClass)
            {
                schema.ThrowIfNull("schema");

                // Retrieve details
                SchemaImplementationDetails details = null;
                if (detailCollection.ContainsKey(schema))
                {
                    details = detailCollection[schema];
                }
                
                string className = GetClassName(schema).BaseType;
                var typeDeclaration = new CodeTypeDeclaration(className);
                typeDeclaration.Attributes = MemberAttributes.Public;
                var nestedClassGenerator = new NestedClassGenerator(
                    typeDeclaration, decorators, uniquefier + orderOfNestedClass + "_");

                foreach (ISchemaDecorator schemaDecorator in decorators)
                {
                    if (schemaDecorator is INestedClassSchemaDecorator)
                    {
                        logger.DebugFormat(
                            "Found IInternalClassSchemaDecorator {0} - decorating {1}", schemaDecorator, className);
                        ((INestedClassSchemaDecorator) schemaDecorator).DecorateInternalClass(
                            typeDeclaration, className, schema, details, nestedClassGenerator);
                    }
                }
                nestedClassGenerator.GenerateNestedClasses(detailCollection);

                return typeDeclaration;
            }

            private CodeTypeReference GetSchemaName(int schemaNumber)
            {
                return new CodeTypeReference(string.Format("NestedClass{0}{1}", uniquefier, schemaNumber));
            }
        }

        #endregion
    }
}