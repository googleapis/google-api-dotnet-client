
using System;
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ServiceClassGenerator:CommonGenerator {
		private const string GENERIC_SERVICE_NAME = "genericService";
		private const string AUTHENTICATOR_NAME = "authenticator";

		public ServiceClassGenerator() {
		}
		
		public CodeTypeDeclaration CreateServiceClass(IService service){
			string serviceClassName = UpperFirstLetter(service.Name) + "Service";
			var serviceClass = new CodeTypeDeclaration(serviceClassName);
			var baseConstructor = CreateConstructorArgService();
			
			serviceClass.Members.Add(CreateExecuteRequest());
			
			AddServiceFields(serviceClass);
			
			int resourceNumber = 1;
			foreach(var pair in service.Resources){
				Resource resource = pair.Value;
				AddResourceGetter(serviceClass, resource, resourceNumber);				
				AddResourceField(serviceClass, resource, resourceNumber);
				AddResourceAssignment(baseConstructor, resource, resourceNumber);
				resourceNumber++;
			}
			
			serviceClass.Members.Add(baseConstructor);
			
			return serviceClass;					
		}
		
		/// <summary>
		/// <code>Google.Apis.Requests.Request request = this.genericService.CreateRequest(resource, method);</code>
		/// </summary>
		private CodeVariableDeclarationStatement CreateRequestLocalVar(){
			var createRequest = new CodeMethodInvokeExpression();
			createRequest.Method = new CodeMethodReferenceExpression(
			                         new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), GENERIC_SERVICE_NAME),
			                         "CreateRequest");
			createRequest.Parameters.Add(new CodeVariableReferenceExpression("resource"));
			createRequest.Parameters.Add(new CodeVariableReferenceExpression("method"));
			
			var createAndAssignRequest = new CodeVariableDeclarationStatement();
			createAndAssignRequest.Type = new CodeTypeReference(typeof(Requests.Request));
			createAndAssignRequest.Name = "request";
			createAndAssignRequest.InitExpression = createRequest;
			
			return createAndAssignRequest;
		}
		
		private CodeTypeMember CreateExecuteRequest(){
			var method = new CodeMemberMethod();
			
			method.Name = "ExecuteRequest";
			method.ReturnType = new CodeTypeReference(typeof(System.IO.Stream));
			method.Attributes = MemberAttributes.Public;
			method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string),"resource"));
			method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string),"method"));
			method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string),"body"));
			method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IDictionary<string,string>),"parameters"));
			
			//Google.Apis.Requests.Request request = this.genericService.CreateRequest(resource, method);
			method.Statements.Add(CreateRequestLocalVar());
			
			
			
			// return request
			//		.WithAuthentication(authentication)
			//	    .WithParameters(parameterDictionary)
			//		.WithBody(bodyString)
			//		.ExecuteRequest()
			
			//request.WithParameters(parameters)
			var methodInvoke = new CodeMethodInvokeExpression(
								new CodeMethodReferenceExpression(
			                        new CodeVariableReferenceExpression("request"),
					    			"WithParameters"),
					    		new CodeVariableReferenceExpression("parameters"));
			
			methodInvoke = new CodeMethodInvokeExpression(
					    new CodeMethodReferenceExpression(methodInvoke,"WithAuthentication"),
					    new CodeVariableReferenceExpression("authenticator"));
			
			//.WithBody(body)
			methodInvoke = new CodeMethodInvokeExpression(
					    new CodeMethodReferenceExpression(methodInvoke,"WithBody"),
					    new CodeVariableReferenceExpression("body"));
			//.ExecuteRequest()	
			methodInvoke = new CodeMethodInvokeExpression(
			    new CodeMethodReferenceExpression(methodInvoke, "ExecuteRequest"));
			var returnStatment = new CodeMethodReturnStatement(methodInvoke);
			 
			method.Statements.Add(returnStatment);
			                                                                                             
			
			return method;
		}
		
		private CodeConstructor CreateConstructorArgService(){
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			constructor.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IService),GENERIC_SERVICE_NAME));
			constructor.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IAuthenticator),AUTHENTICATOR_NAME));
			
			
			{
				var assignService = new CodeAssignStatement();
				assignService.Left = new CodeFieldReferenceExpression(
					new CodeThisReferenceExpression(),
				    GENERIC_SERVICE_NAME);			
				assignService.Right = new CodeVariableReferenceExpression(GENERIC_SERVICE_NAME);
				
				constructor.Statements.Add(assignService);
			}
			
			{
				var assignAuthenticator = new CodeAssignStatement();
				assignAuthenticator.Left = new CodeFieldReferenceExpression(
					new CodeThisReferenceExpression(),
				    AUTHENTICATOR_NAME);			
				assignAuthenticator.Right = new CodeVariableReferenceExpression(AUTHENTICATOR_NAME);
				
				constructor.Statements.Add(assignAuthenticator); 
			}
			
			
			return constructor;
		}

		
		private void AddServiceFields(CodeTypeDeclaration serviceClass){
			var field = new CodeMemberField(typeof(IService),GENERIC_SERVICE_NAME);				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);			
			
			field = new CodeMemberField(typeof(IAuthenticator),AUTHENTICATOR_NAME);				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);
		}
		
		
		private void AddResourceField(CodeTypeDeclaration serviceClass,
		                               Resource resource, int resourceNumber){
			// Add local private variables for each Resource
			var field = new CodeMemberField(
				GetClassName(resource,resourceNumber),GetFieldName(resource, resourceNumber));				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);
		}
		
		private void AddResourceGetter(CodeTypeDeclaration serviceClass, 
		                              Resource resource, int resourceNumber){
			var getter = new CodeMemberProperty();
			getter.Name = GetClassName(resource,resourceNumber);
			getter.HasGet = true;
			getter.HasSet = false;
			getter.Type = new CodeTypeReference(GetClassName(resource, resourceNumber));
			getter.GetStatements.Add(
			     new CodeMethodReturnStatement(GetFieldReference(resource, resourceNumber)));
			
			serviceClass.Members.Add(getter);
		}
		
		private CodeExpression GetFieldReference(Resource resource, int resourceNumber){
			return new CodeFieldReferenceExpression(
			     	new CodeThisReferenceExpression(),
			        GetFieldName(resource, resourceNumber));
		}
		
		
		private void AddResourceAssignment(
		                                   CodeConstructor constructor, 
		                                   Resource resource, 
		                                   int resourceNumber){
			constructor.Statements.Add(
				new CodeAssignStatement(GetFieldReference(resource, resourceNumber),
			        new CodeObjectCreateExpression(
			        	GetClassName(resource, resourceNumber), 
			            new CodeThisReferenceExpression())                                           
			        ));
		}
		
	}
}
