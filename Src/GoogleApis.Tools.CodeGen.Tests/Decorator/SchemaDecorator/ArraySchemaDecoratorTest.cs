/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests the ArraySchemaDecorator class, which provides support
    /// for top-level json arrays
    /// </summary>
    [TestFixture]
    public class ArraySchemaDecoratorTest
    {
        /// <summary>
        /// Tests if the constructor can be called without an exception
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            Assert.DoesNotThrow(() => new ArraySchemaDecoratorTest());
        }

        /// <summary>
        /// Confirms the result of the DecorateClass-method
        /// </summary>
        [Test]
        public void DecorateClassGenerationTest()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var decorator = new ArraySchemaDecorator();
            var internalClassProvider = new ObjectInternalClassProvider();
            var decl = new CodeTypeDeclaration();

            var schema = new MockSchema();
            schema.Name = "test";
            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Type = JsonSchemaType.Array;
            schema.SchemaDetails.Items = new List<JsonSchema>();
            schema.SchemaDetails.Items.Clear();
            schema.SchemaDetails.Items.Add(
                new JsonSchema { Description = "Test", Id = "TestSchema", Type = JsonSchemaType.Object });
            implDetails.Add(schema.SchemaDetails, new SchemaImplementationDetails());
            implDetails.Add(schema.SchemaDetails.Items[0], new SchemaImplementationDetails());
            Assert.DoesNotThrow(() => decorator.DecorateClass(decl, schema, implDetails, internalClassProvider));

            Assert.That(decl.BaseTypes.Count, Is.EqualTo(1));
            Assert.That(decl.BaseTypes[0].BaseType, Is.StringStarting("List<"));

            // Subtype will only be created later on by the NestedClassGenerator,
            // and therefore cannot be tested here
        }

        /// <summary>
        /// Tests the parameters of the DecorateClass method using null-inputs
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var decorator = new ArraySchemaDecorator();
            var declaration = new CodeTypeDeclaration();
            var schema = new MockSchema { SchemaDetails = new JsonSchema() };
            var internalClassProvider = new ObjectInternalClassProvider();
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(null, schema, implDetails, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(declaration, null, implDetails, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(declaration, schema, null, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException), () => decorator.DecorateClass(declaration, schema, implDetails, null));
            decorator.DecorateClass(declaration, schema, implDetails, internalClassProvider);
        }

        /// <summary>
        /// Tests the edge cases of the different classes handed to the DecorateClass method
        /// </summary>
        [Test]
        public void DecorateClassTestEdgeCases()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var decorator = new ArraySchemaDecorator();
            var internalClassProvider = new ObjectInternalClassProvider();
            CodeTypeDeclaration declaration = null;

            var schema = new MockSchema();
            schema.Name = "test";
            schema.SchemaDetails = null;
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.DecorateClass(new CodeTypeDeclaration(), schema, implDetails, internalClassProvider));

            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Type = JsonSchemaType.Float;
            Assert.DoesNotThrow(
                () =>
                decorator.DecorateClass(
                    declaration = new CodeTypeDeclaration(), schema, implDetails, internalClassProvider));
            Assert.That(declaration.BaseTypes.Count, Is.EqualTo(0));

            schema.SchemaDetails.Type = JsonSchemaType.Array;
            schema.SchemaDetails.Items = new List<JsonSchema>();
            schema.SchemaDetails.Items.Add(new JsonSchema());
            schema.SchemaDetails.Items.Add(new JsonSchema());
            Assert.DoesNotThrow(
                () =>
                decorator.DecorateClass(
                    declaration = new CodeTypeDeclaration(), schema, implDetails, internalClassProvider));
            Assert.That(declaration.BaseTypes.Count, Is.EqualTo(0));
        }
    }
}