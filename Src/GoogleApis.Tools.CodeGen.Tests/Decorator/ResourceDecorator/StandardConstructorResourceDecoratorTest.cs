using System;
using System.CodeDom;
using System.Collections.Generic;
using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
	[TestFixture()]
	public class StandardConstructorResourceDecoratorTest : BaseResourceDecoratorTest
	{		
		[Test()]
		public void TestCreateConstructor ()
		{
			var decorator = new StandardConstructorResourceDecorator();
			CodeConstructor constructor = decorator.CreateConstructor (SERVICE_CLASS_NAME);
			Assert.AreEqual(1, constructor.Parameters.Count);
			var param = constructor.Parameters[0];
			Assert.AreEqual(SERVICE_CLASS_NAME, param.Type.BaseType);
		}
		
		[Test()]
		public void TestDecorateClass ()
		{
			var decorator = new StandardConstructorResourceDecorator();
			var resourceClass = new CodeTypeDeclaration(RESOURCE_CLASS_NAME);
			var resource = new Resource(CreateJsonResourceDefinition());
			decorator.DecorateClass(resource, null, resourceClass, null, SERVICE_CLASS_NAME, null);
			
			Assert.AreEqual(1, resourceClass.Members.Count);
			var member = resourceClass.Members[0];
			
			Assert.IsInstanceOf(typeof(CodeConstructor), member);
			// Constructor is tested in TestCreateConstructor
		}
	}
}