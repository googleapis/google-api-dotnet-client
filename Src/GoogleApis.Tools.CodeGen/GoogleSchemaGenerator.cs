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
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using log4net;

namespace Google.Apis.Tools.CodeGen
{
    /// <summary>
    /// For a given service, creates a namespace and generates a class for each schema defined in that service.
    /// Using the ISchemaDecorators provided.  
    /// </summary>
    public class GoogleSchemaGenerator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(GoogleSchemaGenerator));

        public static readonly IEnumerable<ISchemaDecorator> DefaultSchemaDecorators =
            (new List<ISchemaDecorator>
                 {
                     new StandardPropertyFieldDecorator(),
                     new StandardPropertyDecorator(),
                     new StandardSchemaCommentDecorator(),
                     new NewtonSoftPropertyAttributeDecorator(),
                     new ArraySchemaDecorator(),
                 }).AsReadOnly();

        private readonly IList<ISchemaDecorator> decorators;
        private readonly string schemaNamespace;

        public GoogleSchemaGenerator(IEnumerable<ISchemaDecorator> decorators, string schemaNamespace)
        {
            decorators.ThrowIfNull("decorators");
            schemaNamespace.ThrowIfNull("schemaNamespace");
            this.decorators = new List<ISchemaDecorator>(decorators).AsReadOnly();
            this.schemaNamespace = schemaNamespace;
        }

        /// <summary>
        /// Generates all schema classes for the specified service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public CodeNamespace GenerateSchemaClasses(IService service)
        {
            service.ThrowIfNull("service");

            logger.DebugFormat("Starting to generate schemas for {1} in namespace {0}", schemaNamespace, service.Name);
            LogDecorators();
            var codeNamespace = new CodeNamespace(schemaNamespace);
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            SchemaGenerator generator = new SchemaGenerator(decorators);
            foreach (var schemaPair in service.Schemas)
            {
                logger.DebugFormat("Generating Schema {0}", schemaPair.Key);
                codeNamespace.Types.Add(generator.CreateClass(schemaPair.Value, service.Schemas.Keys));
            }
            return codeNamespace;
        }

        private void LogDecorators()
        {
            if (logger.IsDebugEnabled == false)
            {
                return;
            }
            logger.Debug("With Schema descorators:");
            if (decorators.Any() == false)
            {
                logger.Debug(">>>NO DECORATORS");
            }

            foreach (var decorator in decorators)
            {
                logger.DebugFormat(">>>{0}", decorator);
            }
        }
    }
}