
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ServiceClassGenerator:CommonGenerator {

		public ServiceClassGenerator() {
		}
		
		
		
		private void AddResourceField(CodeTypeDeclaration serviceType,
		                               Resource resource, int resourceNumber){
			// Add local private variables for each Resource
			var localVar = new CodeMemberField(
				GetClassName(resource,resourceNumber),GetFieldName(resource, resourceNumber));				
			localVar.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceType.Members.Add(localVar);
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
		
		public CodeTypeDeclaration CreateServiceClass(Service service){
			string serviceClassName = UpperFirstLetter(service.Name) + "Service";
			var serviceType = new CodeTypeDeclaration(serviceClassName);
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			
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
	}
}
