
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ResourceClassGenerator: CommonGenerator{
		private const string ServiceFieldName = "service";

		public ResourceClassGenerator() {
		}
		
		private static String GetMethodName(Method method){
			return UpperFirstLetter(method.Name);
		}
		
		private void AddConstructor(CodeTypeDeclaration resourceClass, String serviceClassName){
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			constructor.Parameters.Add(
			   new CodeParameterDeclarationExpression(serviceClassName, ServiceFieldName));
			
			constructor.Statements.Add(
				new CodeAssignStatement(
			    	new CodeFieldReferenceExpression(
			     		new CodeThisReferenceExpression(),
			        	ServiceFieldName),
			        new CodeArgumentReferenceExpression(ServiceFieldName)			                                                   
			        )
			  	);
			
			resourceClass.Members.Add(constructor);
		}
		
		private void AddServiceField(CodeTypeDeclaration resourceClass, String serviceClassName){
			var serciveField = new CodeMemberField(serviceClassName,ServiceFieldName);				
			serciveField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			resourceClass.Members.Add(serciveField);
		}
		
		/// <summary>
		/// Create the class for a given resource and add all the methods.
		/// </summary>
		/// <param name="res">
		/// A <see cref="Resource"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeTypeDeclaration"/>
		/// </returns>
		public CodeTypeDeclaration CreateClass(Resource res, String serviceClassName) {
			var resourceClass = new CodeTypeDeclaration(GetClassName(res));			
			
			AddServiceField(resourceClass, serviceClassName);
			AddConstructor(resourceClass, serviceClassName);
			
			foreach(var method in res.Methods.Values) {
				resourceClass.Members.Add(CreateClassMethod(method));
			}
		
			return resourceClass;
		}
		
		/// <summary>
		/// For a given resource, there are number of methods, this function creates a single method
		/// </summary>
		/// <param name="method">
		/// A <see cref="Method"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeMemberMethod"/>
		/// </returns>
		private CodeMemberMethod CreateClassMethod(Method method) {
			var member = new CodeMemberMethod();
			
			member.Name = GetMethodName(method);
			member.ReturnType = new CodeTypeReference("System.IO.Stream");
			member.Attributes = MemberAttributes.Public;
			
			// Add Required parameters to the method.
			var paramList = method.Parameters.Values;
			foreach(var param in paramList) {
				member.Parameters.Add( 
				  new CodeParameterDeclarationExpression(typeof(string), param.Name));
			}
			
			return member;
		}
	}
}
