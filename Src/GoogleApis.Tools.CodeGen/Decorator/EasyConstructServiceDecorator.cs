
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class EasyConstructServiceDecorator : IServiceDecorator {
		public void DecorateClass (Google.Apis.Discovery.IService service, CodeTypeDeclaration serviceClass)
		{
			var constructor = new CodeConstructor();
			
			constructor.Attributes = MemberAttributes.Public;
			constructor.ChainedConstructorArgs.Add(GetService(serviceClass));
			constructor.ChainedConstructorArgs.Add(GetAuthenticator());
				
			serviceClass.Members.Add(constructor);
		}

		protected CodeExpression GetService(CodeTypeDeclaration serviceClass){
			/*
			new DiscoveryService(
				new WebDiscoveryDevice(
					new Uri("http://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)
					)).GetService(version)
			*/
			var discoveryUrl = new CodePrimitiveExpression("http://www.googleapis.com/discovery/0.1/describe?api=");
			var serviceName = new CodeFieldReferenceExpression(
			                  	new CodeTypeReferenceExpression(serviceClass.Name), 
			                    ServiceClassGenerator.NAME_NAME);
			
			
			var uriConstructor = new CodeObjectCreateExpression();
			uriConstructor.CreateType = new CodeTypeReference(typeof(Uri));
			uriConstructor.Parameters.Add( 
				new CodeBinaryOperatorExpression(discoveryUrl, 
			                                  	 CodeBinaryOperatorType.Add, 
			                                     serviceName));
			
			var webConstructor = new CodeObjectCreateExpression();
			webConstructor.CreateType = new CodeTypeReference(typeof(WebDiscoveryDevice));
			webConstructor.Parameters.Add(uriConstructor);
			
			var discoveryConstructor = new CodeObjectCreateExpression();
			discoveryConstructor.CreateType = new CodeTypeReference(typeof(DiscoveryService));
			discoveryConstructor.Parameters.Add(webConstructor);
			
			var getServiceCall = new CodeMethodInvokeExpression();
			getServiceCall.Method = new CodeMethodReferenceExpression(discoveryConstructor, "GetService");
			getServiceCall.Parameters.Add(
				new CodeFieldReferenceExpression(
			    	new CodeTypeReferenceExpression(serviceClass.Name), 
			        ServiceClassGenerator.VERSION_NAME));
			
			return getServiceCall;
		}
		
		protected CodeExpression GetAuthenticator(){
			return new CodeObjectCreateExpression("ConsoleAuthenticator");
		}
	}
}
