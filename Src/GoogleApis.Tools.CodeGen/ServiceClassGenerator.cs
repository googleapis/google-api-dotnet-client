
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
			var serviceType = new CodeTypeDeclaration(serviceClassName);
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			
			AddServiceFields(serviceType);
			
			int resourceNumber = 1;
			foreach(var pair in service.Resources){
				Resource resource = pair.Value;
				AddResourceGetter(serviceType, resource, resourceNumber);				
				AddResourceField(serviceType, resource, resourceNumber);
				AddResourceAssignment(constructor, resource, resourceNumber);
				resourceNumber++;
			}
			
			serviceType.Members.Add(constructor);
			
			return serviceType;			
		}

		private void AddServiceFields(CodeTypeDeclaration serviceType){
			var field = new CodeMemberField(typeof(IService),GENERIC_SERVICE_NAME);				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceType.Members.Add(field);			
		}
		
		
		private void AddResourceField(CodeTypeDeclaration serviceType,
		                               Resource resource, int resourceNumber){
			// Add local private variables for each Resource
			var field = new CodeMemberField(
				GetClassName(resource,resourceNumber),GetFieldName(resource, resourceNumber));				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceType.Members.Add(field);
		}
		
		private void AddResourceGetter(CodeTypeDeclaration serviceType, 
		                              Resource resource, int resourceNumber){
			var getter = new CodeMemberProperty();
			getter.Name = GetClassName(resource,resourceNumber);
			getter.HasGet = true;
			getter.HasSet = false;
			getter.Type = new CodeTypeReference(GetClassName(resource, resourceNumber));
			getter.GetStatements.Add(
			     new CodeMethodReturnStatement(GetFieldReference(resource, resourceNumber)));
			
			serviceType.Members.Add(getter);
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
