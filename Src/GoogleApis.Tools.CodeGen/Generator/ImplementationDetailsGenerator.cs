/*
Copyright 2011 Google Inc

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
using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Generator for the SchemaImplementationDetails class. 
    /// Scans the resources and other fields of a discovered services to provide additional information
    /// for the schema decorators, which cannot be found within the json of a schema.
    /// Amongst others used by the ErrorResponseDecorator to find out which schemas are referred by methods.
    /// </summary>
    public class ImplementationDetailsGenerator
    {
        /// <summary>
        /// Generates the implementation details for a whole service
        /// </summary>
        public IDictionary<JsonSchema, SchemaImplementationDetails> GenerateDetails(IService service)
        {
            service.ThrowIfNull("service");

            Dictionary<JsonSchema, SchemaImplementationDetails> dictionary =
                new Dictionary<JsonSchema, SchemaImplementationDetails>();

            // Create details for all schemas where they are necessary
            AddIsMethodResult(dictionary, service, service.Resources.Values);

            return dictionary;
        }

        [VisibleForTestOnly]
        internal static SchemaImplementationDetails GetOrCreateDetails(
            IDictionary<JsonSchema, SchemaImplementationDetails> details, JsonSchema schema)
        {
            details.ThrowIfNull("details");
            schema.ThrowIfNull("schema");

            // If no implementation details have been added yet, create a new entry);
            if (!details.ContainsKey(schema))
            {
                details.Add(schema, new SchemaImplementationDetails());
            }
            return details[schema];
        }


        [VisibleForTestOnly]
        internal static void AddIsMethodResult(IDictionary<JsonSchema, SchemaImplementationDetails> details,
                                               IService service,
                                               IEnumerable<IResource> resources)
        {
            details.ThrowIfNull("details");
            service.ThrowIfNull("service");
            resources.ThrowIfNull("method");

            foreach (IResource resource in resources)
            {
                // Check methods
                foreach (IMethod method in resource.Methods.Values)
                {
                    AddIsMethodResult(details, service, method);
                }

                // Check subresources (if applicable)
                if (resource.Resources != null)
                {
                    AddIsMethodResult(details, service, resource.Resources.Values);
                }
            }
        }

        [VisibleForTestOnly]
        internal static void AddIsMethodResult(IDictionary<JsonSchema, SchemaImplementationDetails> details,
                                               IService service,
                                               IMethod method)
        {
            details.ThrowIfNull("details");
            service.ThrowIfNull("service");
            method.ThrowIfNull("method");

            string id = method.ResponseType;

            if (string.IsNullOrEmpty(id))
            {
                // Return if this method has no response type
                return; 
            }

            // Check if this name is a valid schema
            if (!service.Schemas.ContainsKey(id))
            {
                return;
            }

            ISchema schema = service.Schemas[id];

            // If no implementation details have been added yet, create a new entry
            SchemaImplementationDetails implementationDetails = GetOrCreateDetails(details, schema.SchemaDetails);

            // Change the value
            implementationDetails.IsMethodResult = true;
        }
    }
}
