/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator;

namespace Google.Apis.Tools.CodeGen {


	public class ResourceClassGenerator: CommonGenerator{
		private const string ServiceFieldName = "service";
		private const string ResourceNameConst = "RESOURCE";
		private const string ParameterDictionaryName = "parameters";
		private const string ReturnVariableName = "ret";
		private readonly Resource resource; 
		private readonly String serviceClassName; 
		private readonly int resourceNumber;
		private readonly IResourceDecorator[] decorators;

		public ResourceClassGenerator(Resource resource, String serviceClassName, int resourceNumber, 
		                              params IResourceDecorator[] decorators) {
			this.resource = resource;
			this.serviceClassName = serviceClassName;
			this.resourceNumber = resourceNumber;
			this.decorators = decorators;
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
				resourceClass.Members.Add(CreateMethod(method, methodNumber));
				methodNumber++;
			}
			
			foreach(IResourceDecorator decorator in this.decorators){
				decorator.DecorateClass(this.resource, serviceClassName, resourceClass);
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
			var serviceField = new CodeMemberField(serviceClassName,ServiceFieldName);				
			serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			resourceClass.Members.Add(serviceField);
		}
		
		/// <summary>
		/// Adds <code>private const string RESOURCE = "activities";</code> to the resource class
		/// </summary>
		private void AddResourceNameConst(CodeTypeDeclaration resourceClass){
			var serviceField = new CodeMemberField(typeof(string),ResourceNameConst);				
			serviceField.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			serviceField.InitExpression = new CodePrimitiveExpression(resource.Name);
			
			resourceClass.Members.Add(serviceField);
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
		private CodeMemberMethod CreateMethod(Method method, int methodNumber) {
			var member = new CodeMemberMethod();
			
			member.Name = GetMethodName(method, methodNumber);
			member.ReturnType = new CodeTypeReference("System.IO.Stream");
			member.Attributes = MemberAttributes.Public;
			
			// Add Required parameters to the method.
			var paramList = method.Parameters.Values;
			
			CodeStatementCollection assignmentStatments = new CodeStatementCollection();
			
			int parameterCount = 1;
			foreach(var param in paramList) {
				member.Parameters.Add(DeclareParameter(param, parameterCount));
				assignmentStatments.Add(AssignParameterToDictionary(param, parameterCount));
				parameterCount++;
			}
			
			//System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
			member.Statements.Add(DeclareParamaterDictionary());
			
			//parameters["<%=parameterName%>"] = <%=parameterName%>;
			member.Statements.AddRange(assignmentStatments);
			
			foreach(IResourceDecorator decorator in this.decorators){
				decorator.DecorateMethodBeforeExecute(this.resource, method, member);
			}
			
			// System.IO.Stream ret = this.service.ExecuteRequest(this.RESOURCE, "<%=methodName%>", parameters);
			member.Statements.Add(CreateExecuteRequest(method));
			
			foreach(IResourceDecorator decorator in this.decorators){
				decorator.DecorateMethodAfterExecute(this.resource, method, member);
			}
			
			// return ret;
			var returnStatment = new CodeMethodReturnStatement(
			                       	new CodeVariableReferenceExpression(ReturnVariableName));
			
			member.Statements.Add(returnStatment);
			
			return member;
		}
		
		private CodeStatement CreateExecuteRequest(Method method){
			var call = new CodeMethodInvokeExpression();
			
			call.Method = new CodeMethodReferenceExpression(
				new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), ServiceFieldName),
			    "ExecuteRequest");
			
			call.Parameters.Add(
			     new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), ResourceNameConst));
			call.Parameters.Add(
			     new CodePrimitiveExpression(method.Name));
			call.Parameters.Add(new CodeVariableReferenceExpression(ParameterDictionaryName));
			
			var assign = new CodeVariableDeclarationStatement(typeof(System.IO.Stream), ReturnVariableName, call);

			return assign;
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
