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

using System.CodeDom;
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// An optional Decorator that adds a Method to the resource class for each Method.
    /// The method added will have a parameter for each of the required parameters, all the optional parameters will be 
    /// passed in a IDictionary&lt;string,string&gt;
    /// e.g.
    /// <code>
    ///     public virtual Stream Search(IDictionary&lt;string, string&gt; parameters)
    /// </code>
    /// </summary>
    public class DictionaryOptionalParameterResourceDecorator : IResourceDecorator
    {
        private readonly IMethodCommentCreator commentCreator;

        public DictionaryOptionalParameterResourceDecorator(IMethodCommentCreator commentCreator)
        {
            this.commentCreator = commentCreator;
        }

        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            ResourceGenerator gen = new ResourceGenerator(className, commentCreator);
            int methodNumber = 1;
            foreach (var method in resource.Methods.Values)
            {
                CodeTypeMemberCollection newDecls;
                CodeTypeMember convenienceMethod = gen.CreateMethod(
                    resource, method, methodNumber, allDecorators, out newDecls);
                if (convenienceMethod != null)
                {
                    resourceClass.Members.Add(convenienceMethod);

                    foreach (CodeTypeMember member in newDecls)
                    {
                        if (resourceClass.Members.FindMemberByName(member.Name) == null)
                        {
                            // If this member has not yet been added, add the new type.
                            // Due to method overloads (AsStream, AsObject) it might have been added already.
                            resourceClass.Members.Add(member);
                        }
                    }
                }
                methodNumber++;
            }
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            ;
        }


        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            ;
        }

        #endregion

        #region Nested type: ResourceGenerator

        [VisibleForTestOnly]
        internal class ResourceGenerator : ResourceBaseGenerator
        {
            private readonly string className;
            private readonly IMethodCommentCreator commentCreator;

            public ResourceGenerator(string className, IMethodCommentCreator commentCreator)
            {
                className.ThrowIfNullOrEmpty("className");

                this.className = className;
                this.commentCreator = commentCreator;
            }

            /// <summary>
            /// Returns the type of the body of a method
            /// </summary>
            /// <param name="method"></param>
            /// <returns></returns>
            public CodeTypeReference GetBodyType(IMethod method)
            {
                // TODO(davidwaters@google.com): extend to allow more body types as per standardMethodResourceDecorator
                return new CodeTypeReference(typeof(string));
            }

            /// <summary>
            /// Creates a new method declaration based upon the parameters
            /// </summary>
            public CodeMemberMethod CreateMethod(IResource resource,
                                                 IMethod method,
                                                 int methodNumber,
                                                 IEnumerable<IResourceDecorator> allDecorators,
                                                 out CodeTypeMemberCollection paramTypeDeclarations)
            {
                paramTypeDeclarations = new CodeTypeMemberCollection();

                if (method.HasOptionalParameters() == false)
                {
                    // Wrong decorator. This one is only for methods with optional parameters
                    return null;
                }

                var member = new CodeMemberMethod();

                member.Name = GeneratorUtils.GetMethodName(method, resource.Methods.Keys);
                member.ReturnType = new CodeTypeReference("System.IO.Stream");
                member.Attributes = MemberAttributes.Public;
                if (commentCreator != null)
                {
                    member.Comments.AddRange(commentCreator.CreateMethodComment(method));
                }

                // Add Manditory parameters to the method.
                var paramList = method.GetRequiredParameters();

                CodeStatementCollection assignmentStatments = new CodeStatementCollection();

                ResourceCallAddBodyDeclaration(method, member, GetBodyType(method));

                int parameterCount = 1;
                foreach (var param in paramList)
                {
                    string parameterName = GeneratorUtils.GetParameterName(param, method.Parameters.Keys);
                    CodeTypeDeclaration newDecl;
                    member.Parameters.Add(DeclareInputParameter(param, method, out newDecl));
                    AddParameterComment(commentCreator, member, param, parameterName);
                    assignmentStatments.Add(AssignParameterToDictionary(param, parameterCount, method));
                    parameterCount++;

                    // If a new type had to be declared for this parameter, add it to the list of types.
                    if (newDecl != null)
                    {
                        paramTypeDeclarations.Add(newDecl);
                    }
                }


                /*
                 * TODO(davidwaters@google.com) I belive the commented out code is more correct and works in MS.net but 
                 * not mono see mono bugid 353744
                var dictType = new CodeTypeReference("System.Collections.Generic.IDictionary");
                dictType.TypeArguments.Add(typeof(string));
                dictType.TypeArguments.Add(typeof(string));
                dictType.Options = CodeTypeReferenceOptions.GenericTypeParameter;
                */

                var dictType = new CodeTypeReference(typeof(IDictionary<string, object>));
                var dictParameter = new CodeParameterDeclarationExpression(dictType, ParameterDictionaryName);
                member.Parameters.Add(dictParameter);

                //parameters["<%=parameterName%>"] = <%=parameterName%>;
                member.Statements.AddRange(assignmentStatments);

                foreach (IResourceDecorator decorator in allDecorators)
                {
                    decorator.DecorateMethodBeforeExecute(resource, method, member);
                }

                // System.IO.Stream ret = this.service.ExecuteRequest(this.RESOURCE, "<%=methodName%>", parameters);
                member.Statements.Add(CreateExecuteRequest(method));

                foreach (IResourceDecorator decorator in allDecorators)
                {
                    decorator.DecorateMethodAfterExecute(resource, method, member);
                }

                // return ret;
                var returnStatment =
                    new CodeMethodReturnStatement(new CodeVariableReferenceExpression(ReturnVariableName));

                member.Statements.Add(returnStatment);

                return member;
            }

            protected override string GetClassName()
            {
                return className;
            }
        }

        #endregion
    }
}