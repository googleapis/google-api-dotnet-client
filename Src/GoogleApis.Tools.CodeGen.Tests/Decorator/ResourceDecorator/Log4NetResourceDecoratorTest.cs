using System;
using System.CodeDom;

using log4net;
using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
	[TestFixture()]
	public class Log4NetResourceDecoratorTest : BaseResourceDecoratorTest
	{
		[Test()]
		public void TestDecorateClass ()
		{
			var resourceClass = CreateDecoratedResourceClass(new Log4NetResourceDecorator());
			Assert.AreEqual(1, resourceClass.Members.Count); // Assert One Member was added
			var declaration = resourceClass.Members[0];
			Assert.IsNotNull(declaration);
			Assert.IsInstanceOf(typeof(CodeMemberField), declaration);
			
			var field = (CodeMemberField)declaration;
			
			Assert.AreEqual(Log4NetResourceDecorator.LoggerName, field.Name);
			Assert.AreEqual(typeof(ILog).FullName, field.Type.BaseType);
			
			Assert.IsNotNull(field.InitExpression);
			
			// Partial compile so don't treat warning as errors yet.
			CheckCompile(resourceClass, false, "Failed To Compile after Log4NetResourceDecorator.DecorateClass");
		}
		
		[Test()]
		public void TestDecorateMethodBeforeExecute()
		{
			var decorator = new Log4NetResourceDecorator();
			var resourceClass = CreateDecoratedResourceClass(decorator);
			var codeMember = new CodeMemberMethod();
			codeMember.Name = "OneTestMethod";
			resourceClass.Members.Add(codeMember);
			Resource resource = CreateResource("TestResource", SimpleResource);
			decorator.DecorateMethodBeforeExecute(
				resource, 
				resource.Methods["simpleMethod"], 
				codeMember);
			
			Assert.AreEqual(1, codeMember.Statements.Count);
			var statment = codeMember.Statements[0];
			Assert.IsInstanceOf(typeof(CodeExpressionStatement), statment);
			
			CodeMethodInvokeExpression methodInvoke = (CodeMethodInvokeExpression)((CodeExpressionStatement)statment).Expression;
			Assert.AreEqual(1, methodInvoke.Parameters.Count);
			Assert.IsInstanceOf(typeof(CodePrimitiveExpression), methodInvoke.Parameters[0]);
			Assert.AreEqual("Executing TestResource.simpleMethod", ((CodePrimitiveExpression)methodInvoke.Parameters[0]).Value);
			
			CheckCompile(resourceClass, false, "Failed To Compile after Log4NetResourDecorator.DecorteMethodBeforeExecute");
		}
	}
}
