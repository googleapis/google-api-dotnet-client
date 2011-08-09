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
using NUnit.Framework;
using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Util;
using System.Linq;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Tests for the SchemaGenerator class
    /// </summary>
    [TestFixture]
    public class SchemaGeneratorTest
    {
        private class CountingDecorator : ISchemaDecorator
        {
            public int Count { get; set; }

            #region ISchemaDecorator Members

            public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                      ISchema schema,
                                      IDictionary<JsonSchema, SchemaImplementationDetails> implDetails,
                                      INestedClassProvider internalClassProvider)
            {
                typeDeclaration.ThrowIfNull("typeDeclaration");
                schema.ThrowIfNull("schema");
                internalClassProvider.ThrowIfNull("internalClassProvider");
                Count++;
            }

            #endregion
        }

        /// <summary>
        /// Tests if the constructor works
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            var empty = new List<ISchemaDecorator>(0);
            Assert.DoesNotThrow(() => new SchemaGenerator(empty));
            Assert.Throws(typeof(ArgumentNullException), () => new SchemaGenerator(null));
        }

        /// <summary>
        /// Tests if the CreateClass method checks for valid parameters
        /// </summary>
        [Test]
        public void CreateClassParameterCheck()
        {
            var empty = new List<ISchemaDecorator>(0);
            var schemaGen = new SchemaGenerator(empty);
            Assert.Throws(
                typeof(ArgumentNullException), () => schemaGen.CreateClass(null, null, Enumerable.Empty<string>()));
        }

        /// <summary>
        /// Tests if the generator can create a simple single class
        /// </summary>
        [Test]
        public void CreateClassSingle()
        {
            var empty = new List<ISchemaDecorator>(0);
            var schemaGen = new SchemaGenerator(empty);
            MockSchema schema = new MockSchema
                                    {
                                        Id = "mockSchemaObject",
                                        Name = "mockSchemaObject",
                                        SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")
                                    };
            var typeDeclaration = schemaGen.CreateClass(
                schema, new Dictionary<JsonSchema, SchemaImplementationDetails>(), Enumerable.Empty<string>());
            Assert.IsNotNull(typeDeclaration);
            Assert.AreEqual("MockSchemaObject", typeDeclaration.Name);
            Assert.IsEmpty(typeDeclaration.Members);
        }

        /// <summary>
        /// Tests if multiple decorators are supported
        /// </summary>
        [Test]
        public void CreateClassWithMultipleDecorators()
        {
            var once = new CountingDecorator();
            var threeTimes = new CountingDecorator();
            var decorators = new List<ISchemaDecorator>(4) { once, threeTimes, threeTimes, threeTimes };
            var schemaGen = new SchemaGenerator(decorators);
            MockSchema schema = new MockSchema
                                    {
                                        Id = "mockSchemaObject",
                                        Name = "mockSchemaObject",
                                        SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")
                                    };
            schemaGen.CreateClass(
                schema, new Dictionary<JsonSchema, SchemaImplementationDetails>(), Enumerable.Empty<string>());
            Assert.AreEqual(1, ((CountingDecorator) decorators[0]).Count);
            Assert.AreEqual(3, ((CountingDecorator) decorators[1]).Count);
            Assert.AreEqual(3, ((CountingDecorator) decorators[2]).Count);
            Assert.AreEqual(3, ((CountingDecorator) decorators[3]).Count);
        }

        /// <summary>
        /// Test if a single decorator is supported
        /// </summary>
        [Test]
        public void CreateClassWithSingleDecorator()
        {
            var oneDecorator = new List<ISchemaDecorator>(1) { new CountingDecorator() };
            var schemaGen = new SchemaGenerator(oneDecorator);
            MockSchema schema = new MockSchema
                                    {
                                        Id = "mockSchemaObject",
                                        Name = "mockSchemaObject",
                                        SchemaDetails = MockSchema.CreateSimpleSchema("mockSchemaObject")
                                    };
            schemaGen.CreateClass(
                schema, new Dictionary<JsonSchema, SchemaImplementationDetails>(), Enumerable.Empty<string>());
            Assert.AreEqual(1, ((CountingDecorator) oneDecorator[0]).Count);
        }

        /// <summary>
        /// Test cases for the NestedClassGenerator class
        /// </summary>
        [TestFixture]
        public class NestedClassGeneratorTests
        {
            /// <summary>
            /// Tests the constructor of this class
            /// </summary>
            [Test]
            public void ConstructTest()
            {
                var empty = new List<ISchemaDecorator>(0);
                var decl = new CodeTypeDeclaration();
                Assert.DoesNotThrow(() => new SchemaGenerator.NestedClassGenerator(decl, empty, "1"));
            }

            /// <summary>
            /// Tests the GetClassName method
            /// </summary>
            [Test]
            public void GetClassNameWithoutDetailsTest()
            {
                var empty = new List<ISchemaDecorator>(0);
                var decl = new CodeTypeDeclaration() { Name = "Top" };
                var gen = new SchemaGenerator.NestedClassGenerator(decl, empty, "1_");

                var schema1 = new JsonSchema();
                Assert.AreEqual("Top.NestedClass1_1", gen.GetClassName(schema1, null).BaseType);
                Assert.AreEqual("Top.NestedClass1_1", gen.GetClassName(schema1, null).BaseType);
                Assert.AreEqual("Top.NestedClass1_2", gen.GetClassName(new JsonSchema(), null).BaseType);
            }

            /// <summary>
            /// Tests the GetClassName method
            /// </summary>
            [Test]
            public void GetClassNameWithDetailsTest()
            {
                var empty = new List<ISchemaDecorator>(0);
                var decl = new CodeTypeDeclaration() { Name = "Top" };
                var gen = new SchemaGenerator.NestedClassGenerator(decl, empty, "1_");

                var schema1 = new JsonSchema();
                var details = new SchemaImplementationDetails() { ProposedName = "TestClass" };
                Assert.AreEqual("Top.TestClass", gen.GetClassName(schema1, details).BaseType);
                Assert.AreEqual("Top.TestClass", gen.GetClassName(schema1, null).BaseType);
                Assert.AreEqual("Top.NestedClass1_2", gen.GetClassName(new JsonSchema(), null).BaseType);
            }

            /// <summary>
            /// Tests the GetClassName method
            /// </summary>
            [Test]
            public void GetClassNameWithDetailsCollisionsTest()
            {
                var empty = new List<ISchemaDecorator>(0);
                var decl = new CodeTypeDeclaration() { Name = "Top" };
                var gen = new SchemaGenerator.NestedClassGenerator(decl, empty, "1_");

                var schema1 = new JsonSchema();
                var schema2 = new JsonSchema();
                var details = new SchemaImplementationDetails() { ProposedName = "TestClass" };
                Assert.AreEqual("Top.TestClass", gen.GetClassName(schema1, details).BaseType);
                Assert.AreNotEqual("Top.TestClass", gen.GetClassName(schema2, details).BaseType);
            }
        }
    }
}