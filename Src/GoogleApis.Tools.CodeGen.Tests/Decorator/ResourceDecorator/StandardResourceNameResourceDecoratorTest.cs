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
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the StandardResourceNameResourceDecorator
    /// </summary>
    [TestFixture]
    public class StandardResourceNameResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Tests the generation of resource names
        /// </summary>
        [Test]
        public void CreateResourceNameConstTest()
        {
            var decorator = new StandardResourceNameResourceDecorator();
            CodeMemberField codeField = decorator.CreateResourceNameConst("TestResourceName");

            Assert.AreEqual(ResourceBaseGenerator.ResourceNameConst, codeField.Name);
            Assert.AreEqual(typeof(string).FullName, codeField.Type.BaseType);
            Assert.IsInstanceOf(typeof(CodePrimitiveExpression), codeField.InitExpression);

            var initExpression = (CodePrimitiveExpression) codeField.InitExpression;
            Assert.AreEqual("TestResourceName", initExpression.Value);
        }

        /// <summary>
        /// Tests the abilitiy of this decorator to generate a correct named subresource.
        /// </summary>
        [Test]
        public void DecorateClassSubresourceTest()
        {
            // Create a top and a sub resource.
            var subJson = new JsonDictionary();
            var topJson = new JsonDictionary();
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);
            var topResource = factory.CreateResource("Top", topJson);
            var subResource = factory.CreateResource("Sub", subJson);
            ((Resource)subResource).Parent = topResource;

            var decorator = new StandardResourceNameResourceDecorator();
            var decoratedClass = new CodeTypeDeclaration { Name = "Sub" };
            decorator.DecorateClass(
                subResource, "Sub", decoratedClass, null, ServiceClassName, new IResourceDecorator[0]);

            Assert.AreEqual(1, decoratedClass.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), decoratedClass.Members[0]);
            var resourceField = (CodeMemberField) decoratedClass.Members[0];
            Assert.AreEqual("Top.Sub", ((CodePrimitiveExpression) resourceField.InitExpression).Value);

            CheckCompile(decoratedClass, false, "Failed To Compile StandardResourceNameResourceDecorator");
        }

        /// <summary>
        /// Test the decorator
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new StandardResourceNameResourceDecorator();
            var decoratedClass = CreateDecoratedResourceClass(decorator);

            Assert.AreEqual(1, decoratedClass.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), decoratedClass.Members[0]);
            Assert.AreEqual(ResourceBaseGenerator.ResourceNameConst, decoratedClass.Members[0].Name);

            CheckCompile(decoratedClass, false, "Failed To Compile StandardResourceNameResourceDecorator");
        }
    }
}