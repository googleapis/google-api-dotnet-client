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
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Tests.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests for the StandardPropertyDecorator
    /// </summary>
    [TestFixture]
    public class StandardPropertyDecoratorTest
    {
        /// <summary>
        /// Test if the constructor succeeds
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            Assert.DoesNotThrow(() => new StandardPropertyDecorator());
        }

        /// <summary>
        /// Tests if the class decorator validates inputs
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new StandardPropertyDecorator();
            var declaration = new CodeTypeDeclaration();
            var schema = new MockSchema() { Name = "TestSchema", SchemaDetails = new JsonSchema() };
            var internalClassProvider = new ObjectInternalClassProvider();
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();

            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(null, schema, implDetails, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(declaration, null, implDetails, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(declaration, schema, null, internalClassProvider));

            decorator.DecorateClass(declaration, schema, implDetails, internalClassProvider);
        }

        /// <summary>
        /// Tests the GenerateAllProperties method
        /// </summary>
        [Test]
        public void GenerateAllPropertiesTest()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new MockSchema();
            var internalClassProvider = new ObjectInternalClassProvider();
            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Type = JsonSchemaType.Object;
            schema.SchemaDetails.Properties = new Dictionary<string, JsonSchema>();
            implDetails.Add(schema.SchemaDetails, new SchemaImplementationDetails());
            string name = "test";

            foreach (var pair in StandardPropertyFieldDecoratorTest.NamesToType)
            {
                JsonSchema property = new JsonSchema();
                property.Type = pair.Value;
                property.Id = pair.Key;
                property.Description = StandardPropertyFieldDecoratorTest.NamesToDescription[pair.Key];
                schema.SchemaDetails.Properties.Add(pair.Key, property);
                implDetails.Add(property, new SchemaImplementationDetails());
            }

            var decorator = new StandardPropertyDecorator();
            IList<CodeMemberProperty> generatedProperties = decorator.GenerateAllProperties(
                name, schema.SchemaDetails, implDetails, internalClassProvider);

            Assert.NotNull(generatedProperties);
            Assert.AreEqual(StandardPropertyFieldDecoratorTest.NamesToType.Count, generatedProperties.Count);
            foreach (var field in generatedProperties)
            {
                Assert.That(
                    StandardPropertyFieldDecoratorTest.NamesToType.ContainsKey(field.Name.ToLower()),
                    "field name was not present in namesToType " + field.Name);
            }

            int item = 0;
            foreach (var pair in StandardPropertyFieldDecoratorTest.NamesToType)
            {
                var field = generatedProperties[item++];
                Assert.AreEqual(
                    pair.Key, field.Name.ToLower(),
                    string.Format("Name different for expected at index {0}", item - 1));
                Assert.AreEqual(
                    SchemaDecoratorUtil.GetCodeType(new JsonSchema { Type = pair.Value }, null, internalClassProvider)
                        .BaseType, field.Type.BaseType);
            }
        }

        /// <summary>
        /// Tests edge cases for the generate all properties method
        /// </summary>
        [Test]
        public void GenerateAllPropertiesTestEdgeCases()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var decorator = new StandardPropertyDecorator();
            var internalClassProvider = new ObjectInternalClassProvider();
            string name = "test";
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllProperties(name, null, implDetails, internalClassProvider));

            var schema = new MockSchema();
            schema.Name = "test";
            schema.SchemaDetails = null;
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllProperties(name, schema.SchemaDetails, implDetails, internalClassProvider));


            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Properties = null;
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllProperties(null, schema.SchemaDetails, implDetails, internalClassProvider));
            var expectedEmpty = decorator.GenerateAllProperties(
                name, schema.SchemaDetails, implDetails, internalClassProvider);
            Assert.IsNotNull(expectedEmpty);
            Assert.AreEqual(0, expectedEmpty.Count);
        }
    }
}