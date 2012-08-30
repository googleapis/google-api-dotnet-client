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
using Newtonsoft.Json.Schema;
using Google.Apis.Discovery.Schema;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Mock Schema for testing purposes
    /// </summary>
    public sealed class MockSchema : ISchema
    {
        public MockSchema()
        {
            SchemaDetails = new JsonSchema();
        }

        #region ISchema Members

        public string Name { get; set; }
        public string Id { get; set; }
        public JsonSchema SchemaDetails { get; set; }

        #endregion

        public static JsonSchema CreateSimpleSchema(string id)
        {
            JsonSchema simpleProperty = new JsonSchema();
            simpleProperty.Id = "name";
            simpleProperty.Type = JsonSchemaType.String;
            simpleProperty.Required = true;

            JsonSchema example = new JsonSchema();
            example.Id = id;
            example.Type = JsonSchemaType.Object;
            example.Properties = new Dictionary<string, JsonSchema>();
            example.Properties.Add("name", simpleProperty);

            return example;
        }
    }
}