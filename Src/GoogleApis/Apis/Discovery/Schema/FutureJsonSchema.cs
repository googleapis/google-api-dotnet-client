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
using Newtonsoft.Json.Schema;
using Google.Apis.Util;

namespace Google.Apis.Discovery.Schema
{
    /// <summary>
    /// A future (to be resolved) JsonSchema
    /// </summary>
    internal class FutureJsonSchema : JsonSchema
    {
        /// <summary>
        /// Creates a new Future Json Schema with the specified ID
        /// </summary>
        public FutureJsonSchema(string id)
        {
            Id = id;
            Resolved = false;
        }

        /// <summary>
        /// Determines whether this schema has been resolved
        /// </summary>
        public bool Resolved { get; private set; }

        /// <summary>
        /// Resolves the current schema by using the specified schema
        /// </summary>
        /// <param name="schema"></param>
        public void Resolve(JsonSchema schema)
        {
            schema.ThrowIfNull("schema");
            if (schema is FutureJsonSchema && ((FutureJsonSchema) schema).Resolved == false)
            {
                throw new ArgumentException("Schema given to resolve this future was an unresolved future.", "schema");
            }

            if (schema is FutureJsonSchema)
            {
                throw new ArgumentException("Resolved schema cannot be a FutureJsonSchema", "schema");
            }

            if (schema.Id != Id)
            {
                throw new ArgumentException(
                    "schema",
                    "Attempting to resolve a FutureSchema with incorrect id FutureId[" + Id + "] passedinId[" +
                    schema.Id + "]");
            }

            if (Resolved)
            {
                throw new InvalidOperationException("This FutureJsonSchema has already been resolved." + Id);
            }

            Resolved = true;
            AdditionalProperties = schema.AdditionalProperties;
            AllowAdditionalProperties = schema.AllowAdditionalProperties;
            Default = schema.Default;
            Description = schema.Description;
            Disallow = schema.Disallow;
            Enum = schema.Enum;
            
            Extends = schema.Extends;
            Format = schema.Format;
            Hidden = schema.Hidden;
            Id = schema.Id;
            Identity = schema.Identity;
            Items = schema.Items;
            Maximum = schema.Maximum;
            MaximumItems = schema.MaximumItems;
            MaximumLength = schema.MaximumLength;
            Minimum = schema.Minimum;
            MinimumItems = schema.MinimumItems;
            MinimumLength = schema.MinimumLength;
            Options = schema.Options;
            Pattern = schema.Pattern;
            
            Properties = schema.Properties;
            ReadOnly = schema.ReadOnly;
            
            Requires = schema.Requires;
            Title = schema.Title;
            Transient = schema.Transient;
            Type = schema.Type;
             
            // The Newtonsoft.Silverlight implementation does not contain all properties.
            // Only add them if we are using the regular Newtonsoft.dll
#if !SILVERLIGHT
            Required = schema.Required;
            PatternProperties = schema.PatternProperties;
            ExclusiveMaximum = schema.ExclusiveMaximum;
            ExclusiveMinimum = schema.ExclusiveMinimum;
            DivisibleBy = schema.DivisibleBy;
#endif
        }
    }
}