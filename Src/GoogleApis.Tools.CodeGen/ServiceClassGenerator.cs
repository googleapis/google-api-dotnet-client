
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ServiceClassGenerator:CommonGenerator {

		public ServiceClassGenerator() {
		}
		
		private string GetFieldName(Resource resource){
			return resource.Name;
		}
		
		private void AddResourceField(CodeTypeDeclaration serviceType,
		                               Resource resource){
			// Add local private variables for each Resource
			var localVar = new CodeMemberField(GetClassName(resource),GetFieldName(resource));				
			localVar.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceType.Members.Add(localVar);
		}
		
		private void AddResourceGetter(CodeTypeDeclaration serviceType, 
		                              Resource resource){
			var getter = new CodeMemberProperty();
			getter.Name = GetClassName(resource);
			getter.HasGet = true;
			getter.HasSet = false;
			getter.Type = new CodeTypeReference(GetClassName(resource));
			getter.GetStatements.Add(
			     new CodeMethodReturnStatement(GetFieldReference(resource)));
			
			serviceType.Members.Add(getter);
		}
		
		private CodeExpression GetFieldReference(Resource resource){
			return new CodeFieldReferenceExpression(
			     	new CodeThisReferenceExpression(),
			        GetFieldName(resource));
		}
		
		
		private void AddResourceAssignment(CodeConstructor constructor, Resource resource){
			constructor.Statements.Add(
				new CodeAssignStatement(GetFieldReference(resource),
			        new CodeObjectCreateExpression(GetClassName(resource), new CodeThisReferenceExpression())                                           
			        ));
			                       
		}
		
		public CodeTypeDeclaration CreateServiceClass(Service service){
			string serviceClassName = UpperFirstLetter(service.Name) + "Service";
			var serviceType = new CodeTypeDeclaration(serviceClassName);
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			
			
			foreach(var pair in service.Resources){
				Resource resource = pair.Value;
				AddResourceGetter(serviceType, resource);				
				AddResourceField(serviceType, resource);
				AddResourceAssignment(constructor, resource);
			}
			
			serviceType.Members.Add(constructor);
			
			return serviceType;			
		}
	}
}
