
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ServiceClassGenerator:CommonGenerator {
		private const string GENERIC_SERVICE_NAME = "genericService";

		public ServiceClassGenerator() {
		}
		
		public CodeTypeDeclaration CreateServiceClass(IService service){
			string serviceClassName = UpperFirstLetter(service.Name) + "Service";
			var serviceClass = new CodeTypeDeclaration(serviceClassName);
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			
			AddServiceFields(serviceClass);
			
			int resourceNumber = 1;
			foreach(var pair in service.Resources){
				Resource resource = pair.Value;
				AddResourceGetter(serviceClass, resource, resourceNumber);				
				AddResourceField(serviceClass, resource, resourceNumber);
				AddResourceAssignment(constructor, resource, resourceNumber);
				resourceNumber++;
			}
			
			serviceClass.Members.Add(constructor);
			
			return serviceClass;			
		}

		private void AddServiceFields(CodeTypeDeclaration serviceClass){
			var field = new CodeMemberField(typeof(IService),GENERIC_SERVICE_NAME);				
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
