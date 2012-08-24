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
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

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
        /// <summary>
        /// Enum used to communicate to code which version of the helper methods to generate
        /// on a particular method call. 
        /// </summary>
        internal enum MethodType
        {
            /// <summary>
            /// Generate a standard ServiceRequest helper method.
            /// </summary>
            Request,
            /// <summary>
            /// Generate a MediaUpload ServiceReqeuest helper method.
            /// </summary>
            Media,
        }

        /// <summary>
        /// Defines whether optional parameters are added to the request methods or not.
        /// </summary>
        public bool AddOptionalParameters { get; set; }

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<RequestMethodResourceDecorator>();
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
                logger.Debug("Adding RequestObject Method {0}.{1}", resource.Name, method.Name);
                
                // Add the default request method to the class:
                CodeTypeMember convenienceMethod = 
                    gen.CreateMethod(resourceClass, resource, method, false, MethodType.Request);
                if (convenienceMethod != null)
                {
                    resourceClass.Members.Add(convenienceMethod);
                }

                // Add the media upload request method to the class:
                if (method.MediaUpload != null)
                {
                    CodeTypeMember uploadMethod = 
                        gen.CreateMethod(resourceClass, resource, method, false, MethodType.Media);
                    if (uploadMethod != null)
                    {
                        resourceClass.Members.Add(uploadMethod);
                    }
                }

                // Add the request method specifiying all parameters (also optional ones) to the class:
                if (AddOptionalParameters && method.HasOptionalParameters())
                {
                    convenienceMethod = 
                        gen.CreateMethod(resourceClass, resource, method, true, MethodType.Request);
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

            private const string StreamParameterName = "stream";
            private const string ContentTypeParameterName = "contentType";

            public ResourceGenerator(string className,
                                     IObjectTypeProvider objectTypeProvider,
                                     IMethodCommentCreator commentCreator)
            {
                this.objectTypeProvider = objectTypeProvider;
                this.className = className;
                this.commentCreator = commentCreator;
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
                                                 bool addOptionalParameters,
                                                 MethodType methodType)
            {
                // Create a new method and make it public.
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
                    // If so, add a body parameter.
                    ResourceCallAddBodyDeclaration(method, member, GetBodyType(method), false);
                }

                // If a body parameter or similar parameters were added, also add them to the constructor.
                foreach (CodeParameterDeclarationExpression existingParameter in member.Parameters)
                {
                    constructorParameters.Add(new CodeVariableReferenceExpression(existingParameter.Name));
                }

                // Add all request parameters to this method.
                AddDeclaredParameters(
                    classDeclaration, method, member, constructorParameters, addOptionalParameters);

                string requestClassNamingScheme = RequestClassGenerator.RequestClassNamingScheme;

                // If this is the media-upload convenience method, add the stream and content-type
                // parameters.
                if (methodType == MethodType.Media)
                {
                    member.Parameters.Add(new CodeParameterDeclarationExpression(
                        typeof(System.IO.Stream), StreamParameterName));
                    member.Parameters.Add(new CodeParameterDeclarationExpression(
                        typeof(System.String), ContentTypeParameterName));

                    constructorParameters.Add(new CodeVariableReferenceExpression(StreamParameterName));
                    constructorParameters.Add(new CodeVariableReferenceExpression(ContentTypeParameterName));

                    requestClassNamingScheme = RequestClassGenerator.MediaUploadClassNamingScheme;
                }

                // new ...Request(paramOne, paramTwo, paramThree)
                // TODO(mlinder): add method signature collision checking here.
                CodeTypeReference requestType = new CodeTypeReference(
                    RequestClassGenerator.GetProposedName(
                        method, requestClassNamingScheme));
                member.ReturnType = requestType;
                var newRequest = new CodeObjectCreateExpression(requestType);
                newRequest.Parameters.AddRange(constructorParameters);

                // return ...;
                var returnStatment = new CodeMethodReturnStatement(newRequest);
                member.Statements.Add(returnStatment);

                return member;
            }

            [VisibleForTestOnly]
            internal void AddDeclaredParameters(CodeTypeDeclaration classDeclaration,
                                                   IMethod method,
                                                   CodeMemberMethod member,
                                                   CodeExpressionCollection constructorParameters,
                                                   bool addOptionalParameters)
            {
                if (method.Parameters == null)
                {
                    return;
                }

                // Add all parameters to the method.
                foreach (var param in method.GetAllParametersSorted())
                {
                    if (!addOptionalParameters && !param.IsRequired)
                    {
                        continue;
                    }

                    // Generate a safe parameter name which was not yet used.
                    string parameterName = GeneratorUtils.GetParameterName(
                        param, method.Parameters.Keys.Without(param.Name));

                    // Declare the parameter, and add it to the list of constructor parameters of the request class.
                    member.Parameters.Add(DeclareInputParameter(classDeclaration, param, method));
                    constructorParameters.Add(new CodeVariableReferenceExpression(parameterName));
                    AddParameterComment(commentCreator, member, param, parameterName);
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