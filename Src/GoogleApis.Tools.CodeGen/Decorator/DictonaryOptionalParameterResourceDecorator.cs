
using System;
using System.CodeDom;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator {


	public class DictonaryOptionalParameterResourceDecorator:IResourceDecorator {
		#region IResourceDecorator implementation
		public void DecorateClass (Google.Apis.Discovery.Resource resource, 
		                           string className, 
		                           CodeTypeDeclaration resourceClass)
		{
			throw new System.NotImplementedException();
		}
		
		
		public void DecorateMethodBeforeExecute (Google.Apis.Discovery.Resource resource, Google.Apis.Discovery.Method method, System.CodeDom.CodeMemberMethod codeMember)
		{
			;
		}
		
		
		public void DecorateMethodAfterExecute (Google.Apis.Discovery.Resource resource, Google.Apis.Discovery.Method method, System.CodeDom.CodeMemberMethod codeMember)
		{
			;
		}
		
		#endregion

		public DictonaryOptionalParameterResourceDecorator() {
		}
	}
}
