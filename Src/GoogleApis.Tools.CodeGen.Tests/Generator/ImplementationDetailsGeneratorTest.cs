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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Test for the ImplementationDetailsGenerator class
    /// </summary>
    [TestFixture]
    public class ImplementationDetailsGeneratorTest
    {
        /// <summary>
        /// Tests the constructor of the generator
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ImplementationDetailsGenerator());
        }

        /// <summary>
        /// Tests the GetOrCreateDetails method
        /// </summary>
        [Test]
        public void GetOrCreateDetailsTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema();

            // Test parameter validation
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.GetOrCreateDetails(null, schema));
            Assert.Throws<ArgumentNullException>(() => ImplementationDetailsGenerator.GetOrCreateDetails(dic, null));

            // Test single add
            SchemaImplementationDetails details;
            Assert.IsNotNull(details = ImplementationDetailsGenerator.GetOrCreateDetails(dic, schema));

            // Test duplicate
            Assert.AreEqual(details, ImplementationDetailsGenerator.GetOrCreateDetails(dic, schema));

            // Test second add
            var schema2 = new JsonSchema();
            Assert.IsNotNull(ImplementationDetailsGenerator.GetOrCreateDetails(dic, schema2));
            Assert.AreEqual(2, dic.Count);
        }

        /// <summary>
        /// Tests the AddIsMethodResult method.
        /// </summary>
        [Test]
        public void AddIsMethodResultTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema();
            var service = new MockService();
            service.Schemas.Add("TestSchema", new MockSchema() { SchemaDetails = schema });
            var method = new MockMethod() { ResponseType = "TestSchema"};

            // Test parameter validation:
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(null, service, method));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(dic, null, method));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(dic, service, (IMethod)null));

            // Test single add:
            ImplementationDetailsGenerator.AddIsMethodResult(dic, service, method);
            Assert.AreEqual(dic.Count, 1);

            var implDetails = dic[schema];
            Assert.IsTrue(implDetails.IsMethodResult);
        }

        /// <summary>
        /// Tests the recursive AddIsMethodResult method.
        /// </summary>
        [Test]
        public void AddIsMethodResultRecursionTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema();

            var method = new MockMethod() { ResponseType = "TestSchema" };

            var subresource = new MockResource();
            subresource.Methods.Add("TestMethod", method);

            var resource = new MockResource();
            resource.Resources.Add("Subresource", subresource);
            
            var service = new MockService();
            service.Schemas.Add("TestSchema", new MockSchema { SchemaDetails = schema });
            service.Resources.Add("TestResource", resource);

            // Test parameter validation:
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(null, service, service.Resources.Values));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(dic, null, service.Resources.Values));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.AddIsMethodResult(dic, service, (IEnumerable<IResource>) null));

            // Test recursive add:
            ImplementationDetailsGenerator.AddIsMethodResult(dic, service, service.Resources.Values);
            Assert.AreEqual(dic.Count, 1);

            var implDetails = dic[schema];
            Assert.IsTrue(implDetails.IsMethodResult);
        }

        /// <summary>
        /// Tests the GenerateDetails method.
        /// </summary>
        [Test]
        public void GenerateDetailsTest()
        {
            var gen = new ImplementationDetailsGenerator();
            Assert.Throws<ArgumentNullException>(() => gen.GenerateDetails(null));
            
            // Test the generation for the mock service.
            var service = new MockService();
            IDictionary<JsonSchema, SchemaImplementationDetails> dic = gen.GenerateDetails(service);
            Assert.IsNotNull(dic);
            Assert.AreEqual(dic.Count, 0);
        }

        /// <summary>
        /// Tests the ProposeNameIfNecessary method.
        /// </summary>
        [Test]
        public void ProposeNameIfNecessaryTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();

            // Test parameter validation.
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.ProposeNameIfNecessary(null, "a", new JsonSchema()));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.ProposeNameIfNecessary(dic, null, new JsonSchema()));
            Assert.Throws<ArgumentNullException>(
                () => ImplementationDetailsGenerator.ProposeNameIfNecessary(dic, "a", null));

            // Test with already named schema.
            ImplementationDetailsGenerator.ProposeNameIfNecessary(dic, "Test", new JsonSchema() { Id = "Test" });
            Assert.AreEqual(0, dic.Count);

            // Test with unnamed schema.
            var schema = new JsonSchema();
            ImplementationDetailsGenerator.ProposeNameIfNecessary(dic, "Test", schema);
            Assert.AreEqual(1, dic.Count);
            Assert.AreEqual("Test", dic[schema].ProposedName);
        }

        /// <summary>
        /// Tests the AddDetails method.
        /// </summary>
        [Test]
        public void AddDetailsTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema();

            // Test parameter validation.
            Assert.Throws<ArgumentNullException>(() => ImplementationDetailsGenerator.AddDetails(null, schema));
            Assert.Throws<ArgumentNullException>(() => ImplementationDetailsGenerator.AddDetails(dic, null));
            
            // Test simple execution.
            ImplementationDetailsGenerator.AddDetails(dic, schema);
            Assert.AreEqual(1, dic.Count);
            Assert.IsTrue(dic[schema].TraversedByGenerator);
        }

        /// <summary>
        /// Tests the AddDetails method.
        /// </summary>
        [Test]
        public void AddDetailsSubschemaTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema() { Id = "NamedSchema" };
            var propertySchema = new JsonSchema();
            var itemSchema = new JsonSchema();
            var additionalPropertiesSchema = new JsonSchema();

            schema.Items = new List<JsonSchema>();
            schema.Properties = new Dictionary<string, JsonSchema>();
            schema.AdditionalProperties = additionalPropertiesSchema;

            // Check properties and items.
            schema.Items.Add(itemSchema);
            schema.Properties.Add("TestProperty", propertySchema);
            ImplementationDetailsGenerator.AddDetails(dic, schema);

            // Confirm results.
            Assert.AreEqual(4, dic.Count);
            Assert.AreEqual("NamedSchema", dic[itemSchema].ProposedName);
            Assert.AreEqual("TestPropertyData", dic[propertySchema].ProposedName);
            Assert.AreEqual("NamedSchemaProperties", dic[additionalPropertiesSchema].ProposedName);
        }

        /// <summary>
        /// Tests the AddDetails method
        /// </summary>
        [Test]
        public void AddDetailsRecursionTest()
        {
            var dic = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new JsonSchema();

            // Check endless recursion handling
            schema.Properties = new Dictionary<string, JsonSchema>();
            schema.Properties.Add("Myself", schema);
            ImplementationDetailsGenerator.AddDetails(dic, schema);
            Assert.AreEqual(1, dic.Count);

            // Confirm name proposal
            Assert.AreEqual("MyselfData", dic[schema].ProposedName);
        }
    }
}
