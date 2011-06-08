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
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Sets the title property to a generated default for each JsonSchema which has no title set
    /// </summary>
    public class StandardTitleModificator : ISchemaDecorator, INestedClassSchemaDecorator
    {
        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  SchemaImplementationDetails details,
                                  INestedClassProvider internalClassProvider)
        {
            schema.ThrowIfNull("schema");
            GenerateTitles(schema.SchemaDetails);
        }

        public void DecorateInternalClass(CodeTypeDeclaration typeDeclaration,
                                          string name,
                                          JsonSchema schema,
                                          SchemaImplementationDetails details,
                                          INestedClassProvider internalClassProvider)
        {
            GenerateTitles(schema);
        }

        /// <summary>
        /// Assigns a title to this schema and subschema's
        /// </summary>
        /// <param name="schema"></param>
        private void GenerateTitles(JsonSchema schema)
        {
            schema.ThrowIfNull("schema");
            
            // Generate title for this property
            if (string.IsNullOrEmpty(schema.Title) && !string.IsNullOrEmpty(schema.Id))
            {
                schema.Title = schema.Id;
            }

            // Generate titles for properties
            if (schema.Properties != null)
            {
                foreach (KeyValuePair<string, JsonSchema> pair in schema.Properties)
                {
                    var subschema = pair.Value;

                    if (!string.IsNullOrEmpty(subschema.Title))
                    {
                        continue; // Already has a title
                    }

                    string title;

                    if (string.IsNullOrEmpty(subschema.Id))
                    {
                        // Generate a name and save it as a title
                        title = pair.Key;
                    }
                    else
                        title = subschema.Id;

                    // Assign the title
                    subschema.Title = title;

                    // If this is not a named type, also generate titles for subelements
                    // This is required because otherwise array subitems won't be initialized
                    if (string.IsNullOrEmpty(subschema.Id))
                    {
                        GenerateTitles(subschema);
                    }
                }
            }

            // Generate titles for items
            if (schema.Items != null)
            {
                foreach (JsonSchema item in schema.Items)
                {
                    if (!string.IsNullOrEmpty(item.Title))
                    {
                        continue; // Already has a title
                    }

                    item.Title = schema.Title;
                }
            }
        }
    }
}
