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
using log4net;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// Adds a method to the resource class for each method defined in the resource json. 
    /// The designed method returns a Requestclass-instance instead of directly executing the requests.
    /// All required parameters will be added the the method parameter list, whereas optional ones are left out.
    /// 
    /// Example:
    /// <c>public virtual ListRequest List(string apiName, string apiVersion)</c>
    /// </summary>
    public class RequestMethodResourceDecorator : IResourceDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(StandardMethodResourceDecorator));
        private readonly IMethodCommentCreator commentCreator;
        private readonly IObjectTypeProvider objectTypeProvider;

        public RequestMethodResourceDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
            commentCreator = new DefaultEnglishCommentCreator();
        }

        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            var gen = new ResourceGenerator(className, objectTypeProvider, commentCreator);
            foreach (var method in resource.Methods.Values)
            {
                logger.DebugFormat("Adding Standard Method {0}.{1}", resource.Name, method.Name);
                
                // Add the default request method to the class:
                CodeTypeMember convenienceMethod = gen.CreateMethod(resourceClass, resource, method, false);
                if (convenienceMethod != null)
                {
                    resourceClass.Members.Add(convenienceMethod);
                }

                // Add the request method specifiying all parameters (also optional ones) to the class:
                if (method.HasOptionalParameters())
                {
                    convenienceMethod = gen.CreateMethod(resourceClass, resource, method, true);
                    if (convenienceMethod != null)
                    {
                        resourceClass.Members.Add(convenienceMethod);
                    }
                }
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

        /// <summary>
        /// The internal method generator used by this decorator.
        /// </summary>
        [VisibleForTestOnly]
        internal class ResourceGenerator : ResourceBaseGenerator
        {
            private readonly string className;
            private readonly IMethodCommentCreator commentCreator;
            private readonly IObjectTypeProvider objectTypeProvider;

            public ResourceGenerator(string className,
                                     IObjectTypeProvider objectTypeProvider,
                                     IMethodCommentCreator commentCreator)
            {
                this.objectTypeProvider = objectTypeProvider;
                this.className = className;
                this.commentCreator = commentCreator;
            }

            [VisibleForTestOnly]
            internal CodeTypeReference GetReturnType(IMethod method)
            {
                if (method.ResponseType.IsNullOrEmpty())
                {
                    return new CodeTypeReference("System.IO.Stream");
                }

                return objectTypeProvider.GetReturnType(method);
            }

            public CodeTypeReference GetBodyType(IMethod method)
            {
                if (method.RequestType.IsNullOrEmpty())
                {
                    return new CodeTypeReference(typeof(string));
                }

                return objectTypeProvider.GetBodyType(method);
            }

            public CodeMemberMethod CreateMethod(CodeTypeDeclaration classDeclaration,
                                                 IResource resource,
                                                 IMethod method,
                                                 bool addOptionalParameters)
            {
                // Create a new method and set the outer attributes.
                var member = new CodeMemberMethod();
                member.Name = GeneratorUtils.GetMethodName(method, resource.Methods.Keys.Without(method.Name));
                member.Attributes = MemberAttributes.Public;
                if (commentCreator != null)
                {
                    member.Comments.AddRange(commentCreator.CreateMethodComment(method));
                }

                // Check if this method has a body.
                CodeExpressionCollection constructorParameters = new CodeExpressionCollection();
                constructorParameters.Add(new CodeVariableReferenceExpression(ServiceFieldName));
                if (method.HasBody)
                {
                    ResourceCallAddBodyDeclaration(method, member, GetBodyType(method), false);
                }

                // If a body parameter or similar parameters were added, also add them to the constructor.
                foreach (CodeParameterDeclarationExpression existingParameter in member.Parameters)
                {
                    constructorParameters.Add(new CodeVariableReferenceExpression(existingParameter.Name));
                }

                // Add all request parameters to this method.
                AddAllDeclaredParameters(
                    classDeclaration, method, member, constructorParameters, addOptionalParameters);

                // new ...Request(paramOne, paramTwo, paramThree)
                CodeTypeReference requestType = new CodeTypeReference(RequestClassGenerator.GetProposedName(method));
                member.ReturnType = requestType;
                var newRequest = new CodeObjectCreateExpression(requestType);
                newRequest.Parameters.AddRange(constructorParameters);

                // return ...;
                var returnStatment = new CodeMethodReturnStatement(newRequest);
                member.Statements.Add(returnStatment);

                return member;
            }

            [VisibleForTestOnly]
            internal void AddAllDeclaredParameters(CodeTypeDeclaration classDeclaration,
                                                   IMethod method,
                                                   CodeMemberMethod member,
                                                   CodeExpressionCollection constructorParameters,
                                                   bool addOptionalParameters)
            {
                // Add all parameters to the method.
                if (method.Parameters != null)
                {
                    foreach (var param in method.GetAllParametersSorted())
                    {
                        if (!addOptionalParameters && !param.IsRequired)
                        {
                            continue;
                        }

                        string parameterName = GeneratorUtils.GetParameterName(
                            param, method.Parameters.Keys.Without(param.Name));
                        member.Parameters.Add(DeclareInputParameter(classDeclaration, param, method));
                        constructorParameters.Add(new CodeVariableReferenceExpression(parameterName));
                        AddParameterComment(commentCreator, member, param, parameterName);
                    }
                }
            }

            protected override string GetClassName()
            {
                return className;
            }
        }

        #endregion
    }
}