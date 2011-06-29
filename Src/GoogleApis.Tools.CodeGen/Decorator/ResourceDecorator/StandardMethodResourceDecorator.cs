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
    /// Adds the standard methods to the given Resource class, 
    /// one method for each one described in the discovery document.
    /// There will be parameters added for each of the parameters described in the discovery document
    /// </summary>
    public class StandardMethodResourceDecorator : IResourceDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(StandardMethodResourceDecorator));
        private readonly bool acceptObjectsAsBody;
        private readonly IMethodCommentCreator commentCreator;
        private readonly string methodNameSufix;
        private readonly IObjectTypeProvider objectTypeProvider;
        private readonly bool returnObjects;

        /// <summary>
        /// Constructs a StandardMethodResourceDecorator which creates methods with body parameter as string 
        /// and return type as System.io.Stream.
        /// </summary>
        public StandardMethodResourceDecorator()
        {
            returnObjects = false;
            acceptObjectsAsBody = false;
            objectTypeProvider = null;
            commentCreator = new DefaultEnglishCommentCreator();

            methodNameSufix = "AsStream";
        }

        public StandardMethodResourceDecorator(bool returnObjects,
                                               bool acceptObjectsAsBody,
                                               IObjectTypeProvider objectTypeProvider,
                                               IMethodCommentCreator commentCreator)
        {
            if (returnObjects || acceptObjectsAsBody)
            {
                objectTypeProvider.ThrowIfNull("objectTypeProvider");
            }
            this.returnObjects = returnObjects;
            this.acceptObjectsAsBody = acceptObjectsAsBody;
            this.objectTypeProvider = objectTypeProvider;
            this.commentCreator = commentCreator;
            methodNameSufix = "AndExecute";
        }

        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            var newMembers = new CodeTypeMemberCollection();
            var gen = new ResourceGenerator(
                className, returnObjects, acceptObjectsAsBody, objectTypeProvider, methodNameSufix, commentCreator);
            int methodNumber = 1;
            foreach (var method in resource.Methods.Values)
            {
                logger.DebugFormat("Adding Standard Method {0}.{1}", resource.Name, method.Name);
                CodeTypeMember convenienceMethod = gen.CreateMethod(
                    resourceClass, resource, method, methodNumber, allDecorators);
                if (convenienceMethod != null)
                {
                    newMembers.Add(convenienceMethod);
                }
                methodNumber++;
            }

            // Add all new members.
            DecoratorUtil.AddMembersToClass(resourceClass, newMembers);
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
            private readonly bool acceptObjectsAsBody;
            private readonly string className;
            private readonly IMethodCommentCreator commentCreator;
            private readonly string methodNameSuffix;
            private readonly IObjectTypeProvider objectTypeProvider;
            private readonly bool returnObjects;

            public ResourceGenerator(string className,
                                     bool returnObjects,
                                     bool acceptObjectsAsBody,
                                     IObjectTypeProvider objectTypeProvider,
                                     string methodNameSuffix,
                                     IMethodCommentCreator commentCreator)
            {
                if (returnObjects || acceptObjectsAsBody)
                {
                    objectTypeProvider.ThrowIfNull("objectTypeProvider");
                }
                this.returnObjects = returnObjects;
                this.acceptObjectsAsBody = acceptObjectsAsBody;
                this.objectTypeProvider = objectTypeProvider;
                this.methodNameSuffix = methodNameSuffix;
                this.className = className;
                this.commentCreator = commentCreator;
            }

            [VisibleForTestOnly]
            internal CodeTypeReference GetReturnType(IMethod method)
            {
                if (returnObjects == false || method.ResponseType.IsNullOrEmpty())
                {
                    return new CodeTypeReference("System.IO.Stream");
                }
                else
                {
                    return objectTypeProvider.GetReturnType(method);
                }
            }

            public CodeTypeReference GetBodyType(IMethod method)
            {
                if (acceptObjectsAsBody == false || method.RequestType.IsNullOrEmpty())
                {
                    return new CodeTypeReference(typeof(string));
                }
                else
                {
                    return objectTypeProvider.GetBodyType(method);
                }
            }

            public CodeMemberMethod CreateMethod(CodeTypeDeclaration classDeclaration,
                                                 IResource resource,
                                                 IMethod method,
                                                 int methodNumber,
                                                 IEnumerable<IResourceDecorator> allDecorators)
            {
                var member = new CodeMemberMethod();

                member.Name = GeneratorUtils.GetMethodName(method, resource.Methods.Keys.Without(method.Name)) +
                              methodNameSuffix;
                member.ReturnType = GetReturnType(method);
                member.Attributes = MemberAttributes.Public;
                if (commentCreator != null)
                {
                    member.Comments.AddRange(commentCreator.CreateMethodComment(method));
                }


                CodeStatementCollection assignmentStatments = new CodeStatementCollection();
                ResourceCallAddBodyDeclaration(method, member, GetBodyType(method), true);

                AddAllDeclaredParameters(classDeclaration, method, member, assignmentStatments);

                //System.Collections.Generic.Dictionary<string, string> parameters = 
                //      new System.Collections.Generic.Dictionary<string, string>();
                member.Statements.Add(DeclareParamaterDictionary());

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

            protected override CodeExpression GetBodyAsString(IMethod method)
            {
                if (acceptObjectsAsBody == false || method.RequestType.IsNullOrEmpty())
                {
                    return base.GetBodyAsString(method);
                }

                // this.service.ObjectToJson(body)
                var service = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), ServiceFieldName);
                var body = new CodeVariableReferenceExpression("body");
                return new CodeMethodInvokeExpression(service, "ObjectToJson", body);
            }


            /// <summary>
            /// [ReturnType] ret = this.service.JsonToObject&lt;ReturnType&gt;(this.service.Execute(...));
            /// </summary>
            protected override CodeStatement CreateExecuteRequest(IMethod method)
            {
                method.ThrowIfNull("method");
                if (returnObjects == false || method.ResponseType.IsNullOrEmpty())
                {
                    return base.CreateExecuteRequest(method);
                }
                objectTypeProvider.ThrowIfNull("objectTypeProvider");

                var returnType = objectTypeProvider.GetReturnType(method);

                // this.service.Execute(...)
                var getStream = CreateExecuteCall(method);

                // this.service.JsonToObject<ReturnType>([stream])
                var call = new CodeMethodInvokeExpression();
                call.Method = new CodeMethodReferenceExpression();
                call.Method.TargetObject = new CodeFieldReferenceExpression(
                    new CodeThisReferenceExpression(), ServiceFieldName);
                call.Method.MethodName = "JsonToObject";
                call.Method.TypeArguments.Add(returnType);
                call.Parameters.Add(getStream);

                // [ReturnType] ret = [call]
                return new CodeVariableDeclarationStatement(returnType, ReturnVariableName, call);
            }

            [VisibleForTestOnly]
            protected void AddAllDeclaredParameters(CodeTypeDeclaration classDeclaration,
                                                    IMethod method,
                                                    CodeMemberMethod member,
                                                    CodeStatementCollection assignmentStatments)
            {
                // Add All parameters to the method.
                if (method.Parameters != null)
                {
                    int parameterCount = 1;
                    foreach (var param in method.GetAllParametersSorted())
                    {
                        string parameterName = GeneratorUtils.GetParameterName(
                            param, method.Parameters.Keys.Without(param.Name));
                        member.Parameters.Add(DeclareInputParameter(classDeclaration, param, method));
                        assignmentStatments.Add(AssignParameterToDictionary(param, parameterCount, method));
                        AddParameterComment(commentCreator, member, param, parameterName);
                        parameterCount++;
                    }
                }
            }

            protected override string GetClassName()
            {
                return className;
            }

            /// <summary>
            /// produces
            /// Dictionary<string, object> parameters = new Dictionary<string, object>();
            /// </summary>
            private CodeStatement DeclareParamaterDictionary()
            {
                // produces
                //Dictionary<string, object> parameters = new Dictionary<string, object>();
                return new CodeVariableDeclarationStatement(
                    typeof(Dictionary<string, object>), ParameterDictionaryName,
                    new CodeObjectCreateExpression(typeof(Dictionary<string, object>)));
            }
        }

        #endregion
    }
}