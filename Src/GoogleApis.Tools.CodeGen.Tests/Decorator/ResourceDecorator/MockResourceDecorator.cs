using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
	public class MockResourceDecorator:IResourceDecorator
	{
		public int DecorateClassCalled{get; private set;}
		public int DecorateMethodBeforeExecuteCalled{get; private set;}
		public int DecorateMethodAfterExecuteCalled{get; private set;}
		
		#region IResourceDecorator implementation
		public void DecorateClass (Resource resource, string className, 
		                           CodeTypeDeclaration resourceClass, ResourceClassGenerator generator, 
		                           string serviceClassName, IEnumerable<IResourceDecorator> allDecorators)
		{
			DecorateClassCalled += 1;
		}
		
		
		public void DecorateMethodBeforeExecute (Resource resource, Method method, CodeMemberMethod codeMember)
		{
			DecorateMethodBeforeExecuteCalled += 1;
		}
		
		
		public void DecorateMethodAfterExecute (Resource resource, Method method, CodeMemberMethod codeMember)
		{
			DecorateMethodAfterExecuteCalled += 1;
		}
		
		#endregion
		
	}
}

