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
using System.CodeDom;
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    [TestFixture()]
    public class SchemaGeneratorTest
    {
        [Test()]
        public void ConstructorTest()
        {
            var empty = new List<ISchemaDecorator>(0);
            Assert.DoesNotThrow(() => new SchemaGenerator(empty));
            Assert.Throws(typeof(ArgumentNullException), () => new SchemaGenerator(null));
        }
        
        [Test()]
        public void CreateClassParameterCheck()
        {
            var empty = new List<ISchemaDecorator>(0);
            var schemaGen = new SchemaGenerator(empty);
            Assert.Throws(typeof(ArgumentNullException), () => schemaGen.CreateClass(null));
        }
        
        [Test()]
        public void CreateClassSingle ()
        {
            var empty = new List<ISchemaDecorator>(0);
            var schemaGen = new SchemaGenerator(empty);
            MockSchema schema = new MockSchema(){
                Id = "mockSchemaObject", 
                Name = "mockSchemaObject" , 
                SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")};
            var typeDeclaration = schemaGen.CreateClass(schema);
            Assert.IsNotNull(typeDeclaration);
            Assert.AreEqual("MockSchemaObject", typeDeclaration.Name);
            Assert.IsEmpty(typeDeclaration.Members);
        }
        
        [Test()]
        public void CreateClassWithSingleDecorator()
        {
            var oneDecorator = new List<ISchemaDecorator>(1){new CountingDecorator()};
            var schemaGen = new SchemaGenerator(oneDecorator);
            MockSchema schema = new MockSchema(){
                Id = "mockSchemaObject", 
                Name = "mockSchemaObject" , 
                SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")};
            schemaGen.CreateClass(schema);
            Assert.AreEqual(1, ((CountingDecorator)oneDecorator[0]).Count);
        }
        
        [Test()]
        public void CreateClassWithMultipleDecorators()
        {
            var once = new CountingDecorator();
            var threeTimes= new CountingDecorator();
            var decorators = new List<ISchemaDecorator>(4){once, threeTimes, threeTimes, threeTimes};
            var schemaGen = new SchemaGenerator(decorators);
            MockSchema schema = new MockSchema(){
                Id = "mockSchemaObject", 
                Name = "mockSchemaObject" , 
                SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")};
            schemaGen.CreateClass(schema);
            Assert.AreEqual(1, ((CountingDecorator)decorators[0]).Count);
            Assert.AreEqual(3, ((CountingDecorator)decorators[1]).Count);
            Assert.AreEqual(3, ((CountingDecorator)decorators[2]).Count);
            Assert.AreEqual(3, ((CountingDecorator)decorators[3]).Count);
        }
        
        private class CountingDecorator : ISchemaDecorator
        {
            public int Count{get;set;}
            
            public void DecorateClass (CodeTypeDeclaration typeDeclaration, ISchema schema, INestedClassProvider internalClassProvider)
            {
                typeDeclaration.ThrowIfNull("typeDeclaration");
                schema.ThrowIfNull("schema");
                internalClassProvider.ThrowIfNull("internalClassProvider");
                Count++;
            }
        }
    }
}
