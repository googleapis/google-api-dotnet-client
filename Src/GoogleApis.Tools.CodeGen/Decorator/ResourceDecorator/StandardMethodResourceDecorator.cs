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

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator {
	public class StandardMethodResourceDecorator : IResourceDecorator {
		private static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(StandardMethodResourceDecorator));

		public void DecorateClass(Resource resource, 
		                          string className, 
		                          CodeTypeDeclaration resourceClass, 
		                          ResourceClassGenerator generator, 
		                          string serviceClassName,
		                          IEnumerable<IResourceDecorator> allDecorators) {
			ResourceGenerator gen = new ResourceGenerator(className);
			int methodNumber = 1;
			foreach (var method in resource.Methods.Values) {
				Logger.DebugFormat("Adding Standard Method {0}.{1}", resource.Name, method.Name);
				CodeTypeMember convenienceMethod = gen.CreateMethod(resource, method, methodNumber, allDecorators);
				if (convenienceMethod != null) {
					resourceClass.Members.Add(convenienceMethod);
				}
				methodNumber++;
			}
			
		}

		public void DecorateMethodBeforeExecute(Resource resource, Method method, CodeMemberMethod codeMember) {
			;
		}


		public void DecorateMethodAfterExecute(Resource resource, Method method, CodeMemberMethod codeMember) {
			;
		}

		private class ResourceGenerator : ResourceBaseGenerator {
			private readonly string className;

			public ResourceGenerator(string className) {
				this.className = className;
			}

			public CodeTypeMember CreateMethod(Resource resource, Method method, int methodNumber, IEnumerable<IResourceDecorator> allDecorators) {
				var member = new CodeMemberMethod();
				
				member.Name = GetMethodName(method, methodNumber);
				member.ReturnType = new CodeTypeReference("System.IO.Stream");
				member.Attributes = MemberAttributes.Public;
				
				// Add All parameters to the method.
				var paramList = method.Parameters.Values;
				
				CodeStatementCollection assignmentStatments = new CodeStatementCollection();
				
				ResourceCallAddBodyDeclaration(method, member);
				
				int parameterCount = 1;
				foreach (var param in paramList) {
					member.Parameters.Add(DeclareInputParameter(param, parameterCount));
					assignmentStatments.Add(AssignParameterToDictionary(param, parameterCount));
					parameterCount++;
				}
				
				//System.Collections.Generic.Dictionary<string, string> parameters = new System.Collections.Generic.Dictionary<string, string>();
				member.Statements.Add(DeclareParamaterDictionary());
				
				//parameters["<%=parameterName%>"] = <%=parameterName%>;
				member.Statements.AddRange(assignmentStatments);
				
				foreach (IResourceDecorator decorator in allDecorators) {
					decorator.DecorateMethodBeforeExecute(resource, method, member);
				}
				
				// System.IO.Stream ret = this.service.ExecuteRequest(this.RESOURCE, "<%=methodName%>", parameters);
				member.Statements.Add(CreateExecuteRequest(method));
				
				foreach (IResourceDecorator decorator in allDecorators) {
					decorator.DecorateMethodAfterExecute(resource, method, member);
				}
				
				// return ret;
				var returnStatment = new CodeMethodReturnStatement(new CodeVariableReferenceExpression(ReturnVariableName));
				
				member.Statements.Add(returnStatment);
				
				return member;
			}
			
			protected override string GetClassName() {
				return className;
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
}

