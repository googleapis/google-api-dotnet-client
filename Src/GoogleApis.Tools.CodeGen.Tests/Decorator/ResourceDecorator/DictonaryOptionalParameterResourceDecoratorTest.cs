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
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
	[TestFixture()]
	public class DictonaryOptionalParameterResourceDecoratorTest: BaseResourceDecoratorTest
	{
		[Test()]
		public void TestCreateMethodNoArgs ()
		{
			var resource = CreateResource (BaseCodeGeneratorTest.ResourceName, BaseCodeGeneratorTest.ResourceAsJson);
			var methodGenerator = new DictonaryOptionalParameterResourceDecorator.ResourceGenerator("TestResourceClassName");
			
			var method = resource.Methods[BaseCodeGeneratorTest.TestMethodNames.noParameterTest.ToString()];
			
			var member = methodGenerator.CreateMethod(resource,method,1, new List<IResourceDecorator>());
			Assert.IsNull(member, "With no parameters we should have no method.");
			
			method = resource.Methods[BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest.ToString()];
			member = methodGenerator.CreateMethod(resource,method,1, new List<IResourceDecorator>());
			Assert.IsNull(member, "With no optional parameters we should have no method.");
			
			method = resource.Methods[BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest.ToString()];
			member = methodGenerator.CreateMethod(resource,method,1, new List<IResourceDecorator>());
			Assert.IsNotNull(member);
			Assert.AreEqual(1, member.Parameters.Count);
			//TODO(davidwaters@google.com) - due to a bug in mono bugId 353744 this assert does not pass
			//Assert.AreEqual("System.Collections.Generic.IDictionary", member.Parameters[0].Type.BaseType);
			Assert.That(member.Parameters[0].Type.BaseType.StartsWith("System.Collections.Generic.IDictionary"));
		}
	}
}