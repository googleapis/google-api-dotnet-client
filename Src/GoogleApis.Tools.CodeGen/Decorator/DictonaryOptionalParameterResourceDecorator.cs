
using System;
using System.CodeDom;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator {


	public class DictonaryOptionalParameterResourceDecorator:IResourceDecorator {
		public void DecorateClass (Google.Apis.Discovery.Resource resource, 
		                           string className, 
		                           CodeTypeDeclaration resourceClass,
		                           IResourceDecorator[] allDecorators)
		{
			throw new System.NotImplementedException();
		}
		
		
		public void DecorateMethodBeforeExecute (Resource resource, Method method, CodeMemberMethod codeMember)
		{
			;
		}
		
		
		public void DecorateMethodAfterExecute (Resource resource, Method method, CodeMemberMethod codeMember)
		{
			;
		}
		

		public DictonaryOptionalParameterResourceDecorator() {
		}
	}
}
