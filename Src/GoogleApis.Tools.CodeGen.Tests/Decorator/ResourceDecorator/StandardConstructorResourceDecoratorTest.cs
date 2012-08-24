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
using Google.Apis.Discovery;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests the StandardConstructorResourceDecorator
    /// </summary>
    [TestFixture]
    public class StandardConstructorResourceDecoratorTest : BaseResourceDecoratorTest
    {
        private IResource CreateEmptyResource()
        {
            return CreateResourceDiscoveryV_1_0("MockResource", "{ }");
        }

        private IResource CreateNonEmptyResource()
        {
            var resource = CreateResourceDiscoveryV_1_0("MockResource", "{ }");
            resource.Resources.Add("Subresource", CreateResourceDiscoveryV_1_0("Subresource", "{ }"));
            resource.Resources.Add("AnotherSubresource", CreateResourceDiscoveryV_1_0("AnotherSubresource", "{ }"));
            return resource;
        }

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void TestCreateConstructor()
        {
            var decorator = new StandardConstructorResourceDecorator();
            CodeConstructor constructor = decorator.CreateConstructor(ServiceClassName, CreateEmptyResource());
            Assert.AreEqual(2, constructor.Parameters.Count);
            var param = constructor.Parameters[0];
            Assert.AreEqual(ServiceClassName, param.Type.BaseType);
            Assert.AreEqual(2, constructor.Statements.Count);
            param = constructor.Parameters[1];
            Assert.AreEqual(typeof(Google.Apis.Authentication.IAuthenticator).FullName, param.Type.BaseType);
        }


        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void TestCreateConstructorWithSubresources()
        {
            var decorator = new StandardConstructorResourceDecorator();
            CodeConstructor constructor = decorator.CreateConstructor(ServiceClassName, CreateNonEmptyResource());
            Assert.AreEqual(4, constructor.Statements.Count);
        }

        /// <summary>
        /// Test the decoration functionallity
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var decorator = new StandardConstructorResourceDecorator();
            var resourceClass = new CodeTypeDeclaration(ResourceClassName);
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);
            decorator.DecorateClass(resource, null, resourceClass, null, ServiceClassName, null);

            Assert.AreEqual(1, resourceClass.Members.Count);
            var member = resourceClass.Members[0];

            Assert.IsInstanceOf(typeof(CodeConstructor), member);
            // Constructor is tested in TestCreateConstructor
        }

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void TestCreateSubresourceStatement()
        {
            var decorator = new StandardConstructorResourceDecorator();
            CodeStatementCollection statements = decorator.CreateSubresourceCreateStatements(CreateNonEmptyResource());
            Assert.AreEqual(2, statements.Count);

            Assert.That(statements[0], Is.InstanceOf<CodeAssignStatement>());
            CodeAssignStatement firstStatement = (CodeAssignStatement) statements[0];

            // Check the field name
            Assert.That(firstStatement.Left, Is.InstanceOf<CodeFieldReferenceExpression>());
            Assert.That(((CodeFieldReferenceExpression)firstStatement.Left).FieldName, Is.EqualTo("_Subresource"));

            // Check the constructor
            var right = firstStatement.Right as CodeObjectCreateExpression;
            Assert.IsNotNull(right);
            Assert.That(right.CreateType.BaseType, Is.EqualTo("SubresourceResource"));
        }
    }
}