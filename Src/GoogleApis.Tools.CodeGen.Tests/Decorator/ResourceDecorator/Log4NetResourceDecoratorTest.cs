using System;
using System.CodeDom;

using log4net;
using NUnit.Framework;


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
	}
}
