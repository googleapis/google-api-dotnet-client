using System;
using System.CodeDom;

using NUnit.Framework;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    [TestFixture()]
    public class StandardServiceFieldResourceDecoratorTest : BaseServiceDecoratorTest
    {
        [Test()]
        public void TestDecorateClass ()
        {
            var decorator = new StandardServiceFieldResourceDecorator();
            var service = CreateService();
            var codeType = new CodeTypeDeclaration("TestClass");
            
            decorator.DecorateClass(service, codeType);
            
            Assert.AreEqual(2, codeType.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[0]);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[1]);
            
            CodeMemberField serviceDeclaration = (CodeMemberField)codeType.Members[0];
            CodeMemberField authenticationDeclaration = (CodeMemberField)codeType.Members[1];
            
            Assert.AreEqual(ServiceClassGenerator.GenericServiceName, serviceDeclaration.Name);
            Assert.AreEqual(ServiceClassGenerator.AuthenticatorName, authenticationDeclaration.Name);
            Assert.AreEqual(typeof(IService).FullName, serviceDeclaration.Type.BaseType);
            Assert.AreEqual(typeof(IAuthenticator).FullName, authenticationDeclaration.Type.BaseType);
            
            CheckCompile(codeType, false, "Failed To Compile result from StandardServiceFieldResourceDecorator");
        }
    }
}

