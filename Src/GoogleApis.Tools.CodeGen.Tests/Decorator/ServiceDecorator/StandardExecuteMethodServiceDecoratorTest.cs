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

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;


namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    [TestFixture]
    public class StandardExecuteMethodServiceDecoratorTest : BaseServiceDecoratorTest
    {
        [Test]
        public void CreateWithDeveloperKeyTest()
        {
            var decorator = new StandardExecuteMethodServiceDecorator();

            CodeConditionStatement result = decorator.CreateWithDeveloperKey();

            Assert.IsNotNull(result);
            Assert.That(result.TrueStatements.Count, Is.EqualTo(1));
            Assert.That(result.TrueStatements[0], Is.InstanceOf<CodeAssignStatement>());
            Assert.That(result.FalseStatements.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestCreateExecuteRequestMethod()
        {
            var decorator = new StandardExecuteMethodServiceDecorator();
            CodeMemberMethod method = decorator.CreateExecuteRequestMethod();

            Assert.AreEqual(StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName, method.Name);

            Assert.AreEqual(4, method.Parameters.Count);
            Assert.AreEqual("System.String", method.Parameters[0].Type.BaseType);
            Assert.AreEqual("System.String", method.Parameters[1].Type.BaseType);
            Assert.AreEqual("System.String", method.Parameters[2].Type.BaseType);
            Assert.That(method.Parameters[3].Type.BaseType.Contains("IDictionary"),
                        "Base Type was " + method.Parameters[3].Type.BaseType);
            Assert.AreEqual("System.IO.Stream", method.ReturnType.BaseType);
        }

        [Test]
        public void TestDecorateClass()
        {
            IService service = CreateService();
            var decorator = new StandardExecuteMethodServiceDecorator();
            var codeType = new CodeTypeDeclaration("TestClass");

            var requiredDecorator = new StandardServiceFieldServiceDecorator();
            requiredDecorator.DecorateClass(service, codeType);
            var anotherRequiredDecorator = new DeveloperKeyServiceDecorator();
            anotherRequiredDecorator.DecorateClass(service, codeType);

            decorator.DecorateClass(service, codeType);

            CheckCompile(codeType, false, "Failed To Compile StandardExecuteMethodServiceDecorator");
        }
    }
}