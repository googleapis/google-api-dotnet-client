
using System;
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ResourceClassGenerator: CommonGenerator{
		private const string ServiceFieldName = "service";
		private const string ResourceNameConst = "RESOURCE";
		private const string ParameterDictionaryName = "parameters";
		private readonly Resource resource; 
		private readonly String serviceClassName; 
		private readonly int resourceNumber;

		public ResourceClassGenerator(Resource resource, String serviceClassName, int resourceNumber) {
			this.resource = resource;
			this.serviceClassName = serviceClassName;
			this.resourceNumber = resourceNumber;
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
		public CodeTypeDeclaration CreateClass() {
			var resourceClass = new CodeTypeDeclaration(GetClassName(resource, resourceNumber));			
			
			AddServiceField(resourceClass, serviceClassName);
			AddResourceNameConst(resourceClass);
			AddConstructor(resourceClass, serviceClassName);
			
			int methodNumber = 1;
			foreach(var method in resource.Methods.Values) {
				resourceClass.Members.Add(CreateClassMethod(method, methodNumber));
				methodNumber++;
			}
		
			return resourceClass;
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
		
		/// <summary>
		/// Adds <code>private BuzzService service;</code> to the resource class.
		/// </summary>
		private void AddServiceField(CodeTypeDeclaration resourceClass, String serviceClassName){
			var serciveField = new CodeMemberField(serviceClassName,ServiceFieldName);				
			serciveField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			resourceClass.Members.Add(serciveField);
		}
		
		/// <summary>
		/// Adds <code>private const string RESOURCE = "activities";</code> to the resource class
		/// </summary>
		private void AddResourceNameConst(CodeTypeDeclaration resourceClass){
			var serciveField = new CodeMemberField(typeof(string),ResourceNameConst);				
			serciveField.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			serciveField.InitExpression = new CodePrimitiveExpression(resource.Name);
			
			resourceClass.Members.Add(serciveField);
		}
		
	
		
		/// <summary>
		/// For a given resource, there are number of methods, this function creates a single 
		/// method
		/// </summary>
		/// <param name="method">
		/// A <see cref="Method"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeMemberMethod"/>
		/// </returns>
		private CodeMemberMethod CreateClassMethod(Method method, int methodNumber) {
			var member = new CodeMemberMethod();
			
			member.Name = GetMethodName(method, methodNumber);
			member.ReturnType = new CodeTypeReference("System.IO.Stream");
			member.Attributes = MemberAttributes.Public;
			
			// Add Required parameters to the method.
			var paramList = method.Parameters.Values;
			
			member.Statements.Add(DeclareParamaterDictionary());
			
			int parameterCount = 1;
			foreach(var param in paramList) {
				member.Parameters.Add(DeclareParameter(param, parameterCount));
				member.Statements.Add(AssignParameterToDictionary(param, parameterCount));
				parameterCount++;
			}
			
			return member;
		}
		
		private CodeAssignStatement AssignParameterToDictionary(
			Parameter param, 
		    int parameterCount){
			
			var assign = new CodeAssignStatement();
			assign.Left = new CodeArrayIndexerExpression(
			    new CodeVariableReferenceExpression(ParameterDictionaryName),
			    new CodePrimitiveExpression(param.Name));
			
			assign.Right = new CodeVariableReferenceExpression(GetParameterName(param, parameterCount));
			                                             
			
			return assign;
		}
		
		private CodeParameterDeclarationExpression DeclareParameter(
			Parameter param, 
		    int parameterCount){
			return  new CodeParameterDeclarationExpression(
				  	typeof(string), 
				    GetParameterName(param, parameterCount));
		}
		
		/// <summary>
		/// produces
		/// Dictionary<string, string> parameters = new Dictionary<string, string>();
		/// </summary>
		private CodeStatement DeclareParamaterDictionary(){
			// produces
			//Dictionary<string, string> parameters = new Dictionary<string, string>();
			return new CodeVariableDeclarationStatement(
				typeof(Dictionary<string, string>),ParameterDictionaryName, 
			    new CodeObjectCreateExpression(typeof(Dictionary<string, string>)));
		}
	}
}
