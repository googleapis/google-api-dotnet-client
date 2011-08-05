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
using System.Linq;
using Google.Apis.Discovery.Schema;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Util;
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
        /// Creates a fully working class for the specified schema.
        /// </summary>
        public CodeTypeDeclaration CreateClass(ISchema schema,
                                               IDictionary<JsonSchema, SchemaImplementationDetails> detailCollection,
                                               IEnumerable<string> otherSchemaNames)
        {
            schema.ThrowIfNull("schema");
            detailCollection.ThrowIfNull("detailCollection");
            otherSchemaNames.ThrowIfNull("otherSchemaNames");

            // Get relevant name collection
            IEnumerable<string> relevantNames = otherSchemaNames.Without(schema.Name);

            string className = GeneratorUtils.GetClassName(schema, relevantNames);
            var typeDeclaration = new CodeTypeDeclaration(className);
            var nestedClassGenerator = new NestedClassGenerator(typeDeclaration, decorators, "");
            foreach (ISchemaDecorator schemaDecorator in decorators)
            {
                schemaDecorator.DecorateClass(typeDeclaration, schema, detailCollection, nestedClassGenerator);
            }
            nestedClassGenerator.GenerateNestedClasses(detailCollection);

            return typeDeclaration;
        }

        #region Nested type: NestedClassGenerator

        [VisibleForTestOnly]
        internal class NestedClassGenerator : INestedClassProvider
        {
            private static readonly ILogger logger = ApplicationContext.Logger.ForType<NestedClassGenerator>();

            private readonly IEnumerable<ISchemaDecorator> decorators;

            /// <summary>
            /// Maps Schemas to the name they received so schemas found multiple time will resolve to the same name.
            /// This also allows us to generate the internal classes at the end instead of as we find them.
            /// </summary>
            private readonly IDictionary<JsonSchema, KnownSubschema> knownSubschemas;

            private class KnownSubschema
            {
                /// <summary>
                /// The class name of this nested class
                /// </summary>
                public string ClassName { get; set; }

                /// <summary>
                /// The full reference by which this class can be addressed, e.g. TopClass.SubClass
                /// </summary>
                public CodeTypeReference Reference { get; set; }
            }

            private readonly CodeTypeDeclaration typeDeclaration;

            /// <summary>A string to make this nested class names unique</summary>
            private readonly string uniquefier;

            public NestedClassGenerator(CodeTypeDeclaration typeDeclaration,
                                        IEnumerable<ISchemaDecorator> decorators,
                                        string uniquefier)
            {
                this.typeDeclaration = typeDeclaration;
                this.decorators = decorators;
                knownSubschemas = new Dictionary<JsonSchema, KnownSubschema>();
                this.uniquefier = uniquefier;
            }

            #region INestedClassProvider Members

            /// <summary>
            /// Gets a class name as a CodeTypeReference for the given schema of the form "IntenalClassN" where 
            /// N is an integer. Given the same JsonSchema this will return the same classname.
            /// </summary>
            public CodeTypeReference GetClassName(JsonSchema definition, SchemaImplementationDetails details)
            {
                if (knownSubschemas.ContainsKey(definition))
                {
                    return knownSubschemas[definition].Reference;
                }

                string name = null;
                
                // First, try to generate a name based upon the environment.
                if (typeDeclaration != null && details != null && !string.IsNullOrEmpty(details.ProposedName))
                {
                    string proposedName = details.ProposedName;
                    IEnumerable<string> forbiddenWords = GeneratorUtils.GetWordContextListFromClass(typeDeclaration);
                    forbiddenWords =
                        forbiddenWords.Concat(from KnownSubschema k in knownSubschemas.Values select k.ClassName);

                    string generatedName = GeneratorUtils.GetClassName(proposedName, forbiddenWords);
                    if (generatedName.IsNotNullOrEmpty())
                    {
                        // The generated name is valid -> take it.
                        name = generatedName;
                    }
                }

                // If this name collides with an existing type, generate a unique name.
                if (name == null)
                {
                    name = GetSchemaName(knownSubschemas.Count+1);
                }

                // If the current class is not null, set the prefix to the class name as it will be required for
                // addressing this nested type.
                string prefix = "";
                if (typeDeclaration != null)
                {
                    prefix = typeDeclaration.Name + ".";
                }

                var newSubschema = new KnownSubschema();
                newSubschema.Reference = new CodeTypeReference(prefix + name);
                newSubschema.ClassName = name;
                knownSubschemas.Add(definition, newSubschema);
                return newSubschema.Reference;
            }

            #endregion

            public void GenerateNestedClasses(IDictionary<JsonSchema, SchemaImplementationDetails> detailCollection)
            {
                int i = 0;
                foreach (var pair in knownSubschemas)
                {
                    typeDeclaration.Members.Add(GenerateNestedClass(pair.Key, detailCollection, i+1));
                }
            }

            [VisibleForTestOnly]
            internal CodeTypeDeclaration GenerateNestedClass(JsonSchema schema,
                                                             IDictionary<JsonSchema, SchemaImplementationDetails>
                                                                 detailCollection,
                                                             int orderOfNestedClass)
            {
                schema.ThrowIfNull("schema");

                string className = knownSubschemas[schema].ClassName;
                var typeDeclaration = new CodeTypeDeclaration(className);
                typeDeclaration.Attributes = MemberAttributes.Public;
                var nestedClassGenerator = new NestedClassGenerator(
                    typeDeclaration, decorators, uniquefier + orderOfNestedClass + "_");

                foreach (ISchemaDecorator schemaDecorator in decorators)
                {
                    if (schemaDecorator is INestedClassSchemaDecorator)
                    {
                        logger.Debug(
                            "Found IInternalClassSchemaDecorator {0} - decorating {1}", schemaDecorator, className);
                        ((INestedClassSchemaDecorator) schemaDecorator).DecorateInternalClass(
                            typeDeclaration, className, schema, detailCollection, nestedClassGenerator);
                    }
                }
                nestedClassGenerator.GenerateNestedClasses(detailCollection);

                return typeDeclaration;
            }

            private string GetSchemaName(int schemaNumber)
            {
                return string.Format("NestedClass{0}{1}", uniquefier, schemaNumber);
            }
        }

        #endregion
    }
}