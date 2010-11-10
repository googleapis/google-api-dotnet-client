
using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator {


	public class DictonaryOptionalParameterResourceDecorator : IResourceDecorator {

		public void DecorateClass(Resource resource, string className, CodeTypeDeclaration resourceClass, ResourceClassGenerator generator, IResourceDecorator[] allDecorators) {
			ResourceGenerator gen = new ResourceGenerator(className);
			int methodNumber = 1;
			foreach (var method in resource.Methods.Values) {
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


		public DictonaryOptionalParameterResourceDecorator() {
		}

		private class ResourceGenerator : ResourceBaseGenerator {
			private readonly string className;
			
			public ResourceGenerator(string className){
				this.className = className;
			}
			
			

			public CodeTypeMember CreateMethod(Resource resource, Method method, int methodNumber, IResourceDecorator[] allDecorators) {
				if (HasOptionalParameters(method) == false) {
					return null;
				}
				
				var member = new CodeMemberMethod();
				
				member.Name = GetMethodName(method, methodNumber);
				member.ReturnType = new CodeTypeReference("System.IO.Stream");
				member.Attributes = MemberAttributes.Public;
				
				// Add Manditory parameters to the method.
				var paramList = GetRequiredParameters(method);
				
				CodeStatementCollection assignmentStatments = new CodeStatementCollection();
				
				ResourceCallAddBodyDeclaration(method, member);
				
				int parameterCount = 1;
				foreach (var param in paramList) {
					member.Parameters.Add(DeclareInputParameter(param, parameterCount));
					assignmentStatments.Add(AssignParameterToDictionary(param, parameterCount));
					parameterCount++;
				}
				
				member.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IDictionary<string, string>), ParameterDictionaryName));
				
				
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
			protected override string GetClassName ()
			{
				return className;
			}			
		}
		
		
		
	}
}
