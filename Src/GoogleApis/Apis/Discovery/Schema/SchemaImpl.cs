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

using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Testing;

namespace Google.Apis.Discovery.Schema
{
    internal class SchemaImpl : ISchema
    {
        private readonly string name;
        private readonly JsonDictionary dictionay;
        private List<ISchemaProperty> properties;
        
        public SchemaImpl (KeyValuePair<string, object> kvp)
        {
            this.name = kvp.Key;
            this.dictionay = (JsonDictionary)kvp.Value; 
        }
        
        public string Name { get { return name;} }
        public string Id {get{return (string)dictionay["id"];}}
        
        public IList<ISchemaProperty> Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = fetchProperties(dictionay);
                }
                return properties.AsReadOnly();
            }
            
        }
        
        [VisibleForTestOnly]
        internal static List<ISchemaProperty> fetchProperties(JsonDictionary dict)
        {
            var list = new List<ISchemaProperty>();
            return list;
        }
    }
}

