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

using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Tests for the ParameterPropertyDecorator class.
    /// </summary>
    [TestFixture]
    public class ParameterPropertyDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ParameterPropertyDecorator());
        }

        /// <summary>
        /// Tests the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>()};
            method.Parameters.Add("Param", new MockParameter() { Name = "Param"});
            method.Parameters.Add("Param2", new MockParameter() { Name = "Param2"});
            var resource = new MockResource();
            resource.Methods.Add("Method", method);
            var resourceDecl = new CodeTypeDeclaration();
            var requestDecl = new CodeTypeDeclaration();
            
            // Confirm that the decorator adds the two parameters as properties with a backing field each.
            var decorator = new ParameterPropertyDecorator();
            decorator.DecorateClass(resource, method, requestDecl, resourceDecl);
            Assert.AreEqual(4, requestDecl.Members.Count); // 2 properties + 2 field.
            Assert.AreEqual(0, resourceDecl.Members.Count);
        }

        /// <summary>
        /// Tests the GenerateParameterProperty method.
        /// </summary>
        [Test]
        public void GenerateParameterPropertyTest()
        {
            var parameter = new MockParameter() { Name = "Param" };
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>() };
            method.Parameters.Add("Param", parameter);
            var resource = new MockResource();
            resource.Methods.Add("Method", method);
            var resourceDecl = new CodeTypeDeclaration();

            // Confirm that two properties and two fields are generated.
            var decorator = new ParameterPropertyDecorator();
            CodeTypeMemberCollection newMembers = decorator.GenerateParameterProperty(
                parameter, method, resourceDecl, Enumerable.Empty<string>());
            Assert.AreEqual(2, newMembers.Count); // Property  + field.
            Assert.AreEqual(0, resourceDecl.Members.Count);

            // Check the generated property.
            Assert.IsInstanceOf<CodeMemberField>(newMembers[0]);

            CodeMemberProperty property = (CodeMemberProperty)newMembers[1];
            Assert.AreEqual("Param", property.Name);

            // Check that the property has a Key attribute.
            Assert.AreEqual(1, property.CustomAttributes.Count);
            Assert.AreEqual(
                typeof(RequestParameterAttribute).FullName, property.CustomAttributes[0].AttributeType.BaseType);
            Assert.AreEqual(
                "Param", ((CodePrimitiveExpression) property.CustomAttributes[0].Arguments[0].Value).Value);
        }
    }
}
