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
using NUnit.Framework;
using Google.Apis.Authentication;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the EasyConstructServiceDecorator class.
    /// </summary>
    [TestFixture]
    public class EasyConstructServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests if the CreateAuthenticatorConstructor method returns the correct result.
        /// </summary>
        [Test]
        public void TestCreateAuthenticatorConstructor()
        {
            var codeType = new CodeTypeDeclaration("TestClass");
            var decorator = new EasyConstructServiceDecorator();
            var service = CreateBuzzService();
            CodeConstructor constructor = decorator.CreateAuthenticatorConstructor(service, codeType);

            // Check parameters.
            Assert.AreEqual(1, constructor.Parameters.Count);
            Assert.AreEqual(typeof(IAuthenticator).FullName, constructor.Parameters[0].Type.BaseType);
            Assert.AreEqual(ServiceClassGenerator.AuthenticatorName, constructor.Parameters[0].Name);

            // Check statements.
            Assert.AreEqual(0, constructor.Statements.Count);

            // Check chained parameters.
            Assert.AreEqual(2, constructor.ChainedConstructorArgs.Count);
        }

        /// <summary>
        /// Tests if the CreateEmptyConstructor method returns the correct result.
        /// </summary>
        [Test]
        public void TestCreateEmptyConstructor()
        {
            var decorator = new EasyConstructServiceDecorator();
            CodeConstructor constructor = decorator.CreateEmptyConstructor();

            // Check parameters.
            Assert.AreEqual(0, constructor.Parameters.Count);

            // Check statements.
            Assert.AreEqual(0, constructor.Statements.Count);

            // Check chained parameters.
            Assert.AreEqual(1, constructor.ChainedConstructorArgs.Count);
            Assert.IsInstanceOf<CodeFieldReferenceExpression>(constructor.ChainedConstructorArgs[0]);
        }

        /// <summary>
        /// Tests if the CreateDiscoveryConstant method returns the correct result.
        /// </summary>
        [Test]
        public void TestCreateDiscoveryConstant()
        {
            var decorator = new EasyConstructServiceDecorator();
            CodeMemberField field = decorator.CreateDiscoveryConstant(CreateBuzzService());

            // Validate the constant.
            Assert.AreEqual(EasyConstructServiceDecorator.DiscoveryConstantName, field.Name);
            Assert.AreEqual(typeof(string).ToString(), field.Type.BaseType);
            Assert.IsInstanceOf<CodePrimitiveExpression>(field.InitExpression);
        }
        
        /// <summary>
        /// Tests the DecorateClass method on this decorator.
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var codeType = new CodeTypeDeclaration("TestClass");
            var decorator = new EasyConstructServiceDecorator();
            var service = CreateBuzzService();

            decorator.DecorateClass(service, codeType);

            Assert.AreEqual(3, codeType.Members.Count); // We expect two members to be added.

            // Test the empty constructor.
            Assert.IsInstanceOf(typeof(CodeConstructor), codeType.Members[0]);
            var constructor = (CodeConstructor)codeType.Members[0];
            Assert.AreEqual(0, constructor.Parameters.Count);
            Assert.AreEqual(0, constructor.Statements.Count);

            // Test the constructor taking the authenticator.
            Assert.IsInstanceOf(typeof(CodeConstructor), codeType.Members[1]);
            var constructor2 = (CodeConstructor)codeType.Members[1];
            Assert.AreEqual(1, constructor2.Parameters.Count);
            Assert.AreEqual(0, constructor2.Statements.Count);

            // Test the generated constant.
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[2]);
            Assert.AreEqual(EasyConstructServiceDecorator.DiscoveryConstantName, codeType.Members[2].Name);
        }
    }
}