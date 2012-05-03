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
using System.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using System.Collections.Generic;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests for the SchemaDecoratorUtil
    /// </summary>
    [TestFixture]
    public class SchemaDecoratorUtilTest
    {
        /// <summary>
        /// Tests the GetCodeType method for argument validation
        /// </summary>
        [Test]
        public void GetCodeTypeArgumentValidationTest()
        {
            var internalClassProvider = new ObjectInternalClassProvider();
            Assert.Throws(
                typeof(ArgumentNullException),
                () => SchemaDecoratorUtil.GetCodeType(null, null, internalClassProvider));
            var schema = new JsonSchema();
            Assert.Throws(typeof(ArgumentNullException), () => SchemaDecoratorUtil.GetCodeType(schema, null, null));

            Assert.Throws(
                typeof(NotSupportedException),
                () => SchemaDecoratorUtil.GetCodeType(schema, null, internalClassProvider));
        }

        /// <summary>
        /// Test the GetCodeType method for valid results
        /// </summary>
        [Test]
        public void GetCodeTypeTest()
        {
            var schema = new JsonSchema();
            var internalClassProvider = new ObjectInternalClassProvider();

            schema.Type = JsonSchemaType.String;
            CodeTypeReference result = SchemaDecoratorUtil.GetCodeType(schema, null, internalClassProvider);
            Assert.AreEqual(typeof(string).FullName, result.BaseType);

            schema.Type = JsonSchemaType.Integer;
            result = SchemaDecoratorUtil.GetCodeType(schema, null, internalClassProvider);
            Assert.AreEqual(typeof(Nullable<>).FullName, result.BaseType);
            Assert.AreEqual(typeof(long).FullName, result.TypeArguments[0].BaseType);

            schema.Type = JsonSchemaType.Float;
            result = SchemaDecoratorUtil.GetCodeType(schema, null, internalClassProvider);
            Assert.AreEqual(typeof(Nullable<>).FullName, result.BaseType);
            Assert.AreEqual(typeof(double).FullName, result.TypeArguments[0].BaseType);

            schema.Type = JsonSchemaType.Boolean;
            result = SchemaDecoratorUtil.GetCodeType(schema, null, internalClassProvider);
            Assert.AreEqual(typeof(Nullable<>).FullName, result.BaseType);
            Assert.AreEqual(typeof(bool).FullName, result.TypeArguments[0].BaseType);
        }

        /// <summary>
        /// Tests the GetFieldName method
        /// </summary>
        [Test]
        public void GetFieldName()
        {
            Assert.AreEqual("_FISH", SchemaDecoratorUtil.GetFieldName("FISH", Enumerable.Empty<string>()));
            Assert.AreEqual("_int", SchemaDecoratorUtil.GetFieldName("int", Enumerable.Empty<string>()));
            Assert.AreEqual(
                "_fishAndChips", SchemaDecoratorUtil.GetFieldName("fish-and-chips", Enumerable.Empty<string>()));
        }

        /// <summary>
        /// Tests the GetPropertyName method
        /// </summary>
        [Test]
        public void GetPropertyName()
        {
            Assert.AreEqual("Fish", SchemaDecoratorUtil.GetPropertyName("fish", Enumerable.Empty<string>()));
            Assert.AreEqual("Int", SchemaDecoratorUtil.GetPropertyName("int", Enumerable.Empty<string>()));
            Assert.AreEqual(
                "FishAndChips", SchemaDecoratorUtil.GetPropertyName("fish-and-chips", Enumerable.Empty<string>()));
        }
    }
}