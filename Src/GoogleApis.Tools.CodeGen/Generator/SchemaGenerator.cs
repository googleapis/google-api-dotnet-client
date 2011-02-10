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

using Newtonsoft.Json.Schema;
    
using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Util;


namespace Google.Apis.Tools.CodeGen.Generator
{
    public class SchemaGenerator : BaseGenerator
    {
        private readonly IEnumerable<ISchemaDecorator> decorators;
        public SchemaGenerator (IEnumerable<ISchemaDecorator> decorators)
        {
            decorators.ThrowIfNull("decorators");
            this.decorators = decorators;
        }
        
        public CodeTypeDeclaration CreateClass(ISchema schema)
        {
            schema.ThrowIfNull("schema");
            string className = GeneratorUtils.GetClassName (schema);
            var typeDeclaration = new CodeTypeDeclaration(className);
            var internalClassGenerator = new InternalClassGenerator(typeDeclaration, decorators);
            foreach( ISchemaDecorator schemaDecorator in decorators)
            {
                schemaDecorator.DecoratClass(typeDeclaration, schema, internalClassGenerator);
            }
            internalClassGenerator.GenerateInternalClasses();
            
            return typeDeclaration;
        }
        
        private class InternalClassGenerator: IInternalClassProvider
        {
            private readonly CodeTypeDeclaration typeDeclaration;
            private readonly IEnumerable<ISchemaDecorator> decorators;
            private readonly IDictionary<JsonSchema, int> schemaOrder;
            private int nextSchemaNumber; 
            
            public InternalClassGenerator(CodeTypeDeclaration typeDeclaration, IEnumerable<ISchemaDecorator> decorators)
            {
                this.typeDeclaration = typeDeclaration;
                this.decorators = decorators;
                this.schemaOrder = new Dictionary<JsonSchema, int>();
                nextSchemaNumber = 1;
            }
            
            public void GenerateInternalClasses()
            {
            }
            
            public CodeTypeReference GetInternalClassName (JsonSchema definition)
            {
                if( schemaOrder.ContainsKey(definition) )
                {
                    return GetSchemaName(schemaOrder[definition]);
                }
                int schemaNumber = nextSchemaNumber++;
                schemaOrder.Add(definition, schemaNumber);
                return GetSchemaName(schemaNumber);
            }
            
            private static CodeTypeReference GetSchemaName(int schemaNumber)
            {
                return new CodeTypeReference(string.Format("InternalClass{0}", schemaNumber));
            }
            
        }
    }
}
