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

using System;
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Test-cases for the AdditionalPropertiesSchemaDecorator class.
    /// </summary>
    [TestFixture]
    public class AdditionalPropertiesSchemaDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this class.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new AdditionalPropertiesSchemaDecorator());
        }

        /// <summary>
        /// Tests the parameter validation of the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassValidationTest()
        {
            var decl = new CodeTypeDeclaration();
            var dec = new AdditionalPropertiesSchemaDecorator();
            var schema = new MockSchema();
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var provider = new SchemaGenerator.NestedClassGenerator(decl, new ISchemaDecorator[0], "");

            // Test all parameters.
            Assert.Throws<ArgumentNullException>(() => dec.DecorateClass(null, schema, implDetails, provider));
            Assert.Throws<ArgumentNullException>(() => dec.DecorateClass(decl, null, implDetails, provider));
            Assert.Throws<ArgumentNullException>(() => dec.DecorateClass(decl, schema, null, provider));
            Assert.Throws<ArgumentNullException>(() => dec.DecorateClass(decl, schema, implDetails, null));
            dec.DecorateClass(decl, schema, implDetails, provider);
        }

        /// <summary>
        /// Tests the parameter validation of the ImplementAdditionalProperties method.
        /// </summary>
        [Test]
        public void ImplementAdditionalPropertiesValidationTest()
        {
            var decl = new CodeTypeDeclaration();
            var dec = new AdditionalPropertiesSchemaDecorator();
            var json = new JsonSchema();
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var provider = new SchemaGenerator.NestedClassGenerator(decl, new ISchemaDecorator[0], "");

            // Test all parameters.
            Assert.Throws<ArgumentNullException>(
                () => dec.ImplementAdditionalProperties(null, json, implDetails, provider));
            Assert.Throws<ArgumentNullException>(
                () => dec.ImplementAdditionalProperties(decl,  null, implDetails, provider));
            Assert.Throws<ArgumentNullException>(
                () => dec.ImplementAdditionalProperties(decl, json, null, provider));
            Assert.Throws<ArgumentNullException>(
                () => dec.ImplementAdditionalProperties(decl, json, implDetails, null));

            // Test simple operation
            dec.ImplementAdditionalProperties(decl, json, implDetails, provider);
            Assert.AreEqual(0, decl.BaseTypes.Count);
            Assert.AreEqual(0, decl.Members.Count);
        }

        /// <summary>
        /// Tests the parameter validation of the ImplementAdditionalProperties method.
        /// </summary>
        [Test]
        public void ImplementAdditionalPropertiesTest()
        {
            var decl = new CodeTypeDeclaration() { Name = "Top" };
            var dec = new AdditionalPropertiesSchemaDecorator();
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var provider = new SchemaGenerator.NestedClassGenerator(decl, new ISchemaDecorator[0], "");

            // Test generation of additional properties.
            var json = new JsonSchema();
            json.AdditionalProperties = new JsonSchema() { Type = JsonSchemaType.Object};
            implDetails.Add(json, new SchemaImplementationDetails() { ProposedName = "Sub" });
            dec.ImplementAdditionalProperties(decl, json, implDetails, provider);

            // Confirm inheritance change.
            Assert.AreEqual(1, decl.BaseTypes.Count);
            Assert.AreEqual(typeof(string).FullName, decl.BaseTypes[0].TypeArguments[0].BaseType);
            Assert.AreEqual("Top.Sub", decl.BaseTypes[0].TypeArguments[1].BaseType);
            
            // Confirm generation of nested class.
            provider.GenerateNestedClasses(implDetails);
            Assert.AreEqual(1, decl.Members.Count);
            Assert.IsInstanceOf<CodeTypeDeclaration>(decl.Members[0]);
        }
    }
}
