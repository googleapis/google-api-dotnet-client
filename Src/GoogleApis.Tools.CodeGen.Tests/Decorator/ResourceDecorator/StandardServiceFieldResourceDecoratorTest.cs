using System;
using System.CodeDom;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    [TestFixture()]
    public class StandardServiceFieldResourceDecoratorTest:BaseResourceDecoratorTest
    {
        [Test()]
        public void DecorateClassTest ()
        {
            var decorator = new StandardServiceFieldResourceDecorator();
            CodeTypeDeclaration codeType = CreateDecoratedResourceClass (decorator);
            
            Assert.AreEqual(1, codeType.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[0]);
            var codeField = (CodeMemberField) codeType.Members[0];
            Assert.AreEqual(ResourceBaseGenerator.ServiceFieldName, codeField.Name);
            
            CheckCompile(codeType, false, "Failed To Compile StandardServiceFieldResourceDecorator");
        }
        
        [Test()]
        public void TestCreateServiceField()
        {
            var decorator = new StandardServiceFieldResourceDecorator();
            CodeMemberField codeField = decorator.CreateServiceField();
            
            Assert.IsNotNull(codeField);
            Assert.AreEqual(ResourceBaseGenerator.ServiceFieldName, codeField.Name);
            Assert.AreEqual(typeof(IRequestExecutor).FullName, codeField.Type.BaseType);
            Assert.IsNull(codeField.InitExpression);
        }
    }
}

