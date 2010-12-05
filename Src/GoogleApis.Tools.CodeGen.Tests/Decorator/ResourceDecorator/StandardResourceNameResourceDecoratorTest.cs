using System;
using System.CodeDom;

using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    [TestFixture]
    public class StandardResourceNameResourceDecoratorTest:BaseResourceDecoratorTest
    {
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
        
        [Test]
        public void CreateResourceNameConstTest()
        {
            var decorator = new StandardResourceNameResourceDecorator();
            CodeMemberField codeField = decorator.CreateResourceNameConst("TestResourceName");
            
            Assert.AreEqual(ResourceBaseGenerator.ResourceNameConst, codeField.Name);
            Assert.AreEqual(typeof(string).FullName, codeField.Type.BaseType);
            Assert.IsInstanceOf(typeof(CodePrimitiveExpression),codeField.InitExpression);              
            
            var initExpression = (CodePrimitiveExpression)codeField.InitExpression;
            Assert.AreEqual("TestResourceName", initExpression.Value);
        }
    }
}