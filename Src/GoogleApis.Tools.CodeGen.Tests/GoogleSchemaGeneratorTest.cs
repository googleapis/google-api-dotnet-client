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
using System.CodeDom;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Tests.Generator;

namespace Google.Apis.Tools.CodeGen.Tests
{
    /// <summary>
    /// Tests for the GoogleSchemaGenerator class
    /// </summary>
    [TestFixture]
    public class GoogleSchemaGeneratorTest
    {
        /// <summary>
        /// Tests if the construcotr checks for valid parameters
        /// </summary>
        [Test]
        public void ConstructorParameterValidationTest()
        {
            Assert.Throws(typeof(ArgumentNullException), () => new GoogleSchemaGenerator(null, "Fish.Chips"));
            Assert.Throws(
                typeof(ArgumentNullException), () => new GoogleSchemaGenerator(new List<ISchemaDecorator>(), null));
            Assert.DoesNotThrow(() => new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips"));
        }

        /// <summary>
        /// Tests if the GenerateSchemaClasses method checks for valid parameters
        /// </summary>
        [Test]
        public void GenerateSchemaClassesParameterValidationTest()
        {
            var generator = new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips");
            Assert.Throws(typeof(ArgumentNullException), () => generator.GenerateSchemaClasses(null));
            var mockService = new MockService();
            Assert.DoesNotThrow(() => generator.GenerateSchemaClasses(mockService));
        }

        /// <summary>
        /// Tests if the GenerateSchemaClasses method works
        /// </summary>
        [Test]
        public void GenerateSchemaClassesTest()
        {
            var generator = new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips");
            var mockService = new MockService();

            var mockSchema = new MockSchema();
            mockSchema.Id = "Fish";
            mockSchema.Name = "Fish";
            mockSchema.SchemaDetails = new JsonSchema();
            mockService.Schemas.Add("Fish", mockSchema);

            mockSchema = new MockSchema();
            mockSchema.Id = "Chips";
            mockSchema.Name = "Chips";
            mockSchema.SchemaDetails = new JsonSchema();
            mockService.Schemas.Add("Chips", mockSchema);

            CodeNamespace result = generator.GenerateSchemaClasses(mockService);

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Types.Count);
            List<string> classNames = new List<string>(2);
            classNames.Add(result.Types[0].Name);
            classNames.Add(result.Types[1].Name);

            Assert.That(classNames.Contains("Fish"));
            Assert.That(classNames.Contains("Chips"));
        }
    }
}