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
using System.Collections.Generic;
using Google.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests the ErrorResponseDecorator class.
    /// </summary>
    [TestFixture]
    public class ResponseInterfaceDecoratorTest
    {
        /// <summary>
        /// Tests if the constructor can be called without an exception.
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            Assert.DoesNotThrow(() => new ResponseInterfaceDecoratorTest());
        }

        /// <summary>
        /// Tests the CreateErrorProperty method.
        /// </summary>
        [Test]
        public void CreateErrorPropertyTest()
        {
            CodeTypeMemberCollection col = ResponseInterfaceDecorator.CreateErrorProperty(new CodeTypeDeclaration());

            var prop = col[1] as CodeMemberProperty;
            Assert.AreEqual(prop.Name, "Error");
            Assert.AreEqual(typeof(RequestError).FullName, prop.Type.BaseType);
            Assert.AreEqual(1, prop.CustomAttributes.Count);

            // AutoProperty functionality is tested in the DecoratorUtils test case.
        }

        /// <summary>
        /// Tests the CreateETagProperty method.
        /// </summary>
        [Test]
        public void CreateETagPropertyTest()
        {
            CodeTypeMemberCollection col = ResponseInterfaceDecorator.CreateETagProperty(new CodeTypeDeclaration());

            var prop = col[1] as CodeMemberProperty;
            Assert.AreEqual(prop.Name, "ETag");
            Assert.AreEqual(typeof(string).FullName, prop.Type.BaseType);
            Assert.AreEqual(0, prop.CustomAttributes.Count);

            // AutoProperty functionality is tested in the DecoratorUtils test case.
        }

        /// <summary>
        /// Confirms the result of the DecorateClass-method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            // Init required vars.
            var decorator = new ResponseInterfaceDecorator();
            var declaration = new CodeTypeDeclaration();
            var schema = new MockSchema { SchemaDetails = new JsonSchema() };
            var internalClassProvider = new ObjectInternalClassProvider();
            var implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>();
            implDetails.Add(schema.SchemaDetails, new SchemaImplementationDetails());

            // Test edge cases.
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
            Assert.AreEqual(0, declaration.BaseTypes.Count);
            Assert.AreEqual(0, declaration.Members.Count);

            // Test simple functionality.
            var details = new SchemaImplementationDetails { IsMethodResult = true };
            implDetails = new Dictionary<JsonSchema, SchemaImplementationDetails>
                                  { { schema.SchemaDetails, details } };

            decorator.DecorateClass(declaration, schema, implDetails, internalClassProvider);

            Assert.AreEqual(1, declaration.BaseTypes.Count);
            Assert.AreEqual(4, declaration.Members.Count); // 2 properties with a field each

            // Test with already existing e-tag field.
            declaration = new CodeTypeDeclaration();
            declaration.Members.Add(new CodeMemberProperty() { Name = "ETag" });
            decorator.DecorateClass(declaration, schema, implDetails, internalClassProvider);

            Assert.AreEqual(1, declaration.BaseTypes.Count);
            Assert.AreEqual(3, declaration.Members.Count); // one property with a field, and the previously added one.
        }
    }
}