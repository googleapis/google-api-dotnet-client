// /*
// Copyright 2010 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */
using System;
using Newtonsoft.Json.Schema;

using Google.Apis.Util;


namespace Google.Apis.Discovery.Schema
{
    internal class FutureJsonSchema : JsonSchema
    {
        public bool Resolved{get; private set;}
        
        public FutureJsonSchema (string id)
        {
            this.Id = id;
            this.Resolved = false;
        }
        
        public void Resolve(JsonSchema schema)
        {
            schema.ThrowIfNull("schema");
            if (schema is FutureJsonSchema)
            {
                throw new ArgumentException("schema","Resolved schema cannot be a FutureJsonSchema");
            }
            
            if (schema.Id != this.Id)
            {
                throw new ArgumentException("schema", "Attempting to resolve a FutureSchema with incorrect id FutureId["+this.Id+"] passedinId["+schema.Id+"]");
            }
            
            if ( Resolved ) 
            {
                throw new InvalidOperationException("This FutureJsonSchema has already been resolved." +  this.Id);
            }
            
            Resolved = true;
            this.AdditionalProperties = schema.AdditionalProperties;
            this.AllowAdditionalProperties = schema.AllowAdditionalProperties;
            this.Default = schema.Default;
            this.Description = schema.Description;
            this.Disallow = schema.Disallow;
            this.DivisibleBy = schema.DivisibleBy;
            this.Enum = schema.Enum;
            this.ExclusiveMaximum = schema.ExclusiveMaximum;
            this.ExclusiveMinimum = schema.ExclusiveMinimum;
            this.Extends = schema.Extends;
            this.Format = schema.Format;
            this.Hidden = schema.Hidden;
            this.Id = schema.Id;
            this.Identity = schema.Identity;
            this.Items = schema.Items;
            this.Maximum = schema.Maximum;
            this.MaximumItems = schema.MaximumItems;
            this.MaximumLength = schema.MaximumLength;
            this.Minimum = schema.Minimum;
            this.MinimumItems = schema.MinimumItems;
            this.MinimumLength = schema.MinimumLength;
            this.Options = schema.Options;
            this.Pattern = schema.Pattern;
            this.PatternProperties = schema.PatternProperties;
            this.Properties = schema.Properties;
            this.ReadOnly = schema.ReadOnly;
            this.Required = schema.Required;
            this.Requires = schema.Requires;
            this.Title = schema.Title;
            this.Transient = schema.Transient;
            this.Type = schema.Type;
        }
    }
}
