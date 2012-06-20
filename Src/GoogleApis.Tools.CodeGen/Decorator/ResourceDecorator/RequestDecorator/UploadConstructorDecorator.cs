/*
Copyright 2012 Google Inc

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
using System.Linq;
using System.Runtime.InteropServices;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Generates the standard constructors of an upload request.
    ///  1. A constructor taking the service and mandatory parameters and initalizing the base class
    ///     with the baseUri, path and HTTP method for this upload request.
    /// Example:
    /// <c>public InsertRequest(BaseService service, int requiredParameter, ..) : base(service.BaseUri, "path", "POST") {..}</c>
    /// </summary>
    public class UploadConstructorDecorator : BaseRequestConstructorDecorator
    {
        private const string AuthenticatorName = "Authenticator";
        private const string ServiceName = "service";
        private const string BaseUriName = "BaseUri";

        private const string StreamParameterName = "stream";
        private const string ContentTypeParameterName = "contentType";

        /// <summary>
        /// Creates a new request constructor decorator.
        /// </summary>
        /// <remarks>Will create the constructor with all required properties.</remarks>
        public UploadConstructorDecorator(IObjectTypeProvider objectTypeProvider) : base(objectTypeProvider) { }

        #region IRequestDecorator Members

        public override void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            requestClass.Members.Add(CreateRequiredConstructor(resourceClass, request, false));
        }

        #endregion

        /// <summary>
        /// Creates the constructor for this request class which only takes required arguments.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeConstructor CreateRequiredConstructor(CodeTypeDeclaration resourceClass,
                                                           IMethod request,
                                                           bool addOptionalParameters)
        {
            var constructor = new CodeConstructor();
            constructor.Attributes = MemberAttributes.Public;

            // IRequestProvider service
            var serviceArg = new CodeParameterDeclarationExpression(typeof(IRequestProvider), ServiceName);
            constructor.Parameters.Add(serviceArg);

            // : base(service, "path", "HTTPMETHOD")
            constructor.BaseConstructorArgs.Add(
                new CodePropertyReferenceExpression(
                    new CodeVariableReferenceExpression(ServiceName), BaseUriName));
            constructor.BaseConstructorArgs.Add(new CodePrimitiveExpression(request.MediaUpload.Simple.Path));
            constructor.BaseConstructorArgs.Add(new CodePrimitiveExpression(request.HttpMethod));

            // Add all required arguments to the constructor.
            AddBodyParameter(constructor, request);

            // Add common upload arguements.
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression(StreamParameterName));
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression(ContentTypeParameterName));

            AddAuthorizationAssignment(constructor);
            AddRequestParameters(resourceClass, request, constructor, addOptionalParameters);

            constructor.Parameters.Add(new CodeParameterDeclarationExpression(
                new CodeTypeReference(typeof(System.IO.Stream)), StreamParameterName));
            constructor.Parameters.Add(new CodeParameterDeclarationExpression(
                new CodeTypeReference(typeof(System.String)), ContentTypeParameterName));

            return constructor;
        }

        /// <summary>
        /// Adds this.Authenticator = service.Authenticator to <paramref name="constructor"/>
        /// </summary>
        /// <param name="constructor">The resumable upload constructor.</param>
        private void AddAuthorizationAssignment(CodeConstructor constructor)
        {
            constructor.Statements.Add(
                new CodeAssignStatement(
                    new CodePropertyReferenceExpression(
                        new CodeThisReferenceExpression(), AuthenticatorName),
                    new CodePropertyReferenceExpression(
                        new CodeVariableReferenceExpression(ServiceName), AuthenticatorName)));
        }
    }
}