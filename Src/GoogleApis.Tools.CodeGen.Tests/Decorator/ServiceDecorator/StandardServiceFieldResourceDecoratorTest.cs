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
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the StandardServiceFieldResourceDecorator class
    /// </summary>
    [TestFixture]
    public class StandardServiceFieldResourceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests the Decorateclass method for valid results
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var decorator = new StandardServiceFieldServiceDecorator();
            var service = CreateService();
            var codeType = new CodeTypeDeclaration("TestClass");

            decorator.DecorateClass(service, codeType);

            Assert.AreEqual(3, codeType.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[0]);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[1]);
            Assert.IsInstanceOf(typeof(CodeMemberProperty), codeType.Members[2]);

            CodeMemberField serviceDeclaration = (CodeMemberField) codeType.Members[0];
            CodeMemberField authenticationDeclaration = (CodeMemberField)codeType.Members[1];
            CodeMemberProperty authenticationPropertyDeclaration = (CodeMemberProperty)codeType.Members[2];

            Assert.AreEqual(ServiceClassGenerator.GenericServiceName, serviceDeclaration.Name);
            Assert.AreEqual(ServiceClassGenerator.AuthenticatorName, authenticationDeclaration.Name);
            Assert.AreEqual(typeof(IService).FullName, serviceDeclaration.Type.BaseType);
            Assert.AreEqual(typeof(IAuthenticator).FullName, authenticationDeclaration.Type.BaseType);
            Assert.AreEqual("Authenticator", authenticationPropertyDeclaration.Name);

            CheckCompile(codeType, false, "Failed To Compile result from StandardServiceFieldResourceDecorator");
        }
    }
}