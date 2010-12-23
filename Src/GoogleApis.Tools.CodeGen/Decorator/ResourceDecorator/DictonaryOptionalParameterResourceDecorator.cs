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
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// An optional Decorator that add a Method to the resource class for each Method.
    /// The method added will have a parameter for each of the required parameters, all the optional parameters will be 
    /// passed in a IDictionary&lt;string,string&gt;
    /// e.g.
    /// <code>
    ///     public virtual Stream Search(IDictionary&lt;string, string&gt; parameters)
    /// </code>
    /// </summary>
    public class DictonaryOptionalParameterResourceDecorator : IResourceDecorator
    {

        public void DecorateClass (IResource resource, string className, CodeTypeDeclaration resourceClass, 
                                   ResourceClassGenerator generator, string serviceClassName, 
                                   IEnumerable<IResourceDecorator> allDecorators)
        {
            ResourceGenerator gen = new ResourceGenerator (className);
            int methodNumber = 1;
            foreach (var method in resource.Methods.Values) {
                CodeTypeMember convenienceMethod = gen.CreateMethod (resource, method, methodNumber, allDecorators);
                if (convenienceMethod != null) {
                    resourceClass.Members.Add (convenienceMethod);
                }
                methodNumber++;
            }
            
        }

        public void DecorateMethodBeforeExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            ;
        }


        public void DecorateMethodAfterExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            ;
        }


        public DictonaryOptionalParameterResourceDecorator ()
        {
        }

        [VisibleForTestOnly]
        internal class ResourceGenerator : ResourceBaseGenerator
        {
            private readonly string className;

            public ResourceGenerator (string className)
            {
                this.className = className;
            }

            public CodeMemberMethod CreateMethod (IResource resource, IMethod method, int methodNumber, 
                                                  IEnumerable<IResourceDecorator> allDecorators)
            {
                if (GeneratorUtils.HasOptionalParameters (method) == false) {
                    return null;
                }
                
                var member = new CodeMemberMethod ();
                
                member.Name = GeneratorUtils.GetMethodName (method, methodNumber);
                member.ReturnType = new CodeTypeReference ("System.IO.Stream");
                member.Attributes = MemberAttributes.Public;
                
                // Add Manditory parameters to the method.
                var paramList = GeneratorUtils.GetRequiredParameters (method);
                
                CodeStatementCollection assignmentStatments = new CodeStatementCollection ();
                
                ResourceCallAddBodyDeclaration (method, member);
                
                int parameterCount = 1;
                foreach (var param in paramList) {
                    member.Parameters.Add (DeclareInputParameter (param, parameterCount));
                    assignmentStatments.Add (AssignParameterToDictionary (param, parameterCount));
                    parameterCount++;
                }
                
                                /*
                 * TODO(davidwaters@google.com) I belive the commented out code is more correct and works in MS.net but 
                 * not mono see mono bugid 353744
                var dictType = new CodeTypeReference("System.Collections.Generic.IDictionary");
                dictType.TypeArguments.Add(typeof(string));
                dictType.TypeArguments.Add(typeof(string));
                dictType.Options = CodeTypeReferenceOptions.GenericTypeParameter;
                */
var dictType = new CodeTypeReference (typeof(IDictionary<string, string>));
                var dictParameter = new CodeParameterDeclarationExpression (dictType, ParameterDictionaryName);
                member.Parameters.Add (dictParameter);
                
                
                //parameters["<%=parameterName%>"] = <%=parameterName%>;
                member.Statements.AddRange (assignmentStatments);
                
                foreach (IResourceDecorator decorator in allDecorators) {
                    decorator.DecorateMethodBeforeExecute (resource, method, member);
                }
                
                // System.IO.Stream ret = this.service.ExecuteRequest(this.RESOURCE, "<%=methodName%>", parameters);
                member.Statements.Add (CreateExecuteRequest (method));
                
                foreach (IResourceDecorator decorator in allDecorators) {
                    decorator.DecorateMethodAfterExecute (resource, method, member);
                }
                
                // return ret;
                var returnStatment = new CodeMethodReturnStatement (
                    new CodeVariableReferenceExpression (ReturnVariableName));
                
                member.Statements.Add (returnStatment);
                
                return member;
            }
            protected override string GetClassName ()
            {
                return className;
            }
        }
    }
}
