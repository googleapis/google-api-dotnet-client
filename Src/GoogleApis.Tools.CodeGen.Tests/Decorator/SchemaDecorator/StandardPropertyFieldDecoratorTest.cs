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
using System.Linq;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests for the StandardPropertyFieldDecorator class
    /// </summary>
    [TestFixture]
    public class StandardPropertyFieldDecoratorTest
    {
        internal static readonly IDictionary<string, JsonSchemaType> NamesToType =
            new SortedDictionary<string, JsonSchemaType>
                {
                    { "a", JsonSchemaType.Boolean },
                    { "b", JsonSchemaType.Integer },
                    { "c", JsonSchemaType.Float },
                    { "d", JsonSchemaType.String },
                    { "e", JsonSchemaType.Boolean },
                    { "f", JsonSchemaType.Integer },
                };

        internal static readonly IDictionary<string, string> NamesToDescription =
            new SortedDictionary<string, string>
                { { "a", null }, { "b", "" }, { "c", "c" }, { "d", "d" }, { "e", "e" }, { "f", "f" }, };

        private readonly INestedClassProvider internalClassProvider = new ObjectInternalClassProvider();

        /// <summary>
        /// Tests the GenerateAllfield method for functionallity
        /// </summary>
        [Test]
        public void GenerateAllFieldsTest()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var schema = new MockSchema();
            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Type = JsonSchemaType.Object;
            schema.SchemaDetails.Properties = new Dictionary<string, JsonSchema>();
            implDetails.Add(schema.SchemaDetails, new SchemaImplementationDetails());

            foreach (var pair in NamesToType)
            {
                JsonSchema property = new JsonSchema();
                property.Type = pair.Value;
                property.Id = pair.Key;
                schema.SchemaDetails.Properties.Add(pair.Key, property);
                implDetails.Add(property, new SchemaImplementationDetails());
            }

            var decorator = new StandardPropertyFieldDecorator();
            IList<CodeMemberField> generatedFields = decorator.GenerateAllFields(
                "test", schema.SchemaDetails, implDetails, internalClassProvider);

            Assert.NotNull(generatedFields);
            Assert.AreEqual(NamesToType.Count, generatedFields.Count);
            foreach (var field in generatedFields)
            {
                Assert.That(
                    NamesToType.ContainsKey(field.Name.Substring(1)), "field name was not present in namesToType " + field.Name);
            }

            int item = 0;
            foreach (var pair in NamesToType)
            {
                var field = generatedFields[item++];
                Assert.AreEqual(
                    "_" + pair.Key, field.Name, string.Format("Name different for expected at index {0}", item - 1));
                Assert.AreEqual(
                    SchemaDecoratorUtil.GetCodeType(new JsonSchema { Type = pair.Value }, null, internalClassProvider)
                        .BaseType, field.Type.BaseType);
            }
        }

        /// <summary>
        /// Test edge cases for the GenerateAllFields method
        /// </summary>
        [Test]
        public void GenerateAllFieldsTestEdgeCases()
        {
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            var decorator = new StandardPropertyFieldDecorator();
            var schema = new MockSchema();
            string name = "test";
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllFields(name, null, implDetails, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllFields(name, schema.SchemaDetails, null, internalClassProvider));
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllFields(name, schema.SchemaDetails, implDetails, null));

            schema.Name = "test";
            schema.SchemaDetails = null;
            Assert.Throws(
                typeof(ArgumentNullException),
                () => decorator.GenerateAllFields(name, schema.SchemaDetails, implDetails, internalClassProvider));

            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Properties = null;
            var expectedEmpty = decorator.GenerateAllFields(
                name, schema.SchemaDetails, implDetails, internalClassProvider);
            Assert.IsNotNull(expectedEmpty);
            Assert.AreEqual(0, expectedEmpty.Count);
        }

        /// <summary>
        /// Test the GenerateField method
        /// </summary>
        [Test]
        public void GenerateFieldTest()
        {
            var schema = new JsonSchema();
            var decorator = new StandardPropertyFieldDecorator();
            var implDetails = new SchemaImplementationDetails();

            schema.Type = JsonSchemaType.String;
            CodeMemberField generatedField = decorator.GenerateField(
                "normalName", schema, implDetails, 1, internalClassProvider, Enumerable.Empty<string>());

            Assert.NotNull(generatedField);
            Assert.AreEqual(typeof(string).FullName, generatedField.Type.BaseType);
            Assert.AreEqual("_normalName", generatedField.Name);
            Assert.AreEqual(MemberAttributes.Private, generatedField.Attributes);

            schema.Type = JsonSchemaType.Boolean;
            generatedField = decorator.GenerateField(
                "public", schema, implDetails, 2, internalClassProvider, Enumerable.Empty<string>());

            Assert.NotNull(generatedField);
            Assert.AreEqual(typeof(Nullable<>).FullName, generatedField.Type.BaseType);
            Assert.AreEqual(typeof(bool).FullName, generatedField.Type.TypeArguments[0].BaseType);
            Assert.AreEqual("_public", generatedField.Name);
            Assert.AreEqual(MemberAttributes.Private, generatedField.Attributes);

            generatedField = decorator.GenerateField(
                "UPPERCASE", schema, implDetails, 2, internalClassProvider, Enumerable.Empty<string>());

            Assert.NotNull(generatedField);
            Assert.AreEqual("_UPPERCASE", generatedField.Name);
        }
    }
}