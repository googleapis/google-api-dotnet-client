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
using Google.Apis.Requests;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;


namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the StandardExecuteMethodServiceDecorator class
    /// </summary>
    [TestFixture]
    public class CreateRequestMethodServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests if the ApiKey will be added as a property with backing field.
        /// </summary>
        [Test]
        public void CreateWithApiKeyTest()
        {
            var decorator = new CreateRequestMethodServiceDecorator();

            CodeConditionStatement result = decorator.CreateWithApiKey();

            Assert.IsNotNull(result);
            Assert.That(result.TrueStatements.Count, Is.EqualTo(1));
            Assert.That(result.TrueStatements[0], Is.InstanceOf<CodeAssignStatement>());
            Assert.That(result.FalseStatements.Count, Is.EqualTo(0));
        }

        /// <summary>
        /// Tests the CreateExecuteRequestMethod method for valid results
        /// </summary>
        [Test]
        public void TestGenerateCreateRequestMethod()
        {
            var decorator = new CreateRequestMethodServiceDecorator();
            CodeMemberMethod method = decorator.GenerateCreateRequestMethod();

            Assert.AreEqual(CreateRequestMethodServiceDecorator.CreateRequestMethodName, method.Name);

            Assert.AreEqual(2, method.Parameters.Count);
            Assert.AreEqual("System.String", method.Parameters[0].Type.BaseType);
            Assert.AreEqual("System.String", method.Parameters[1].Type.BaseType);
            Assert.AreEqual(typeof(IRequest).FullName, method.ReturnType.BaseType);
        }

        /// <summary>
        /// Tests the class decorator
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            IService service = CreateService();
            var decorator = new CreateRequestMethodServiceDecorator();
            var codeType = new CodeTypeDeclaration("TestClass");

            var requiredDecorator = new StandardServiceFieldServiceDecorator();
            requiredDecorator.DecorateClass(service, codeType);
            var anotherRequiredDecorator = new ApiKeyServiceDecorator();
            anotherRequiredDecorator.DecorateClass(service, codeType);

            decorator.DecorateClass(service, codeType);

            CheckCompile(codeType, false, "Failed To Compile StandardExecuteMethodServiceDecorator");
        }
    }
}