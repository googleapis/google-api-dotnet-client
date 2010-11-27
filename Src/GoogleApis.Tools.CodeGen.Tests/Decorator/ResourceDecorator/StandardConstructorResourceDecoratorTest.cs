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
			CodeConstructor constructor = decorator.CreateConstructor (ServiceClassName);
			Assert.AreEqual(1, constructor.Parameters.Count);
			var param = constructor.Parameters[0];
			Assert.AreEqual(ServiceClassName, param.Type.BaseType);
		}
		
		[Test()]
		public void TestDecorateClass ()
		{
			var decorator = new StandardConstructorResourceDecorator();
			var resourceClass = new CodeTypeDeclaration(ResourceClassName);
			var resource = CreateResource();
			decorator.DecorateClass(resource, null, resourceClass, null, ServiceClassName, null);
			
			Assert.AreEqual(1, resourceClass.Members.Count);
			var member = resourceClass.Members[0];
			
			Assert.IsInstanceOf(typeof(CodeConstructor), member);
			// Constructor is tested in TestCreateConstructor
		}
	}
}