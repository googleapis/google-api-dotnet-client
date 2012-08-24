/*
Copyright 2011 Google Inc

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
    /// Generates the two standard constructors of a request.
    ///  1. A constructor taking the service and mandatory parameters.
    ///  2. A constructor taking the service and all mandatory + optional parameters.
    /// Example:
    /// <c>public ListRequest(ISchemaAwareRequestExecutor service, int requiredParameter, ..) : base(service) {..}</c>
    /// <c>public ListRequest(ISchemaAwareRequestExecutor s, int required, string optional..) : base(service) {..}</c>
    /// </summary>
    public class RequestConstructorDecorator : BaseRequestConstructorDecorator
    {
        /// <summary>
        /// Defines whether this decorator should also add a constructor containing optional and mandatory parameters.
        /// </summary>
        public bool CreateOptionalConstructor { get; set; }

        /// <summary>
        /// Creates a new request constructor decorator.
        /// </summary>
        /// <remarks>Will create only the mandatory-only constructor</remarks>
        public RequestConstructorDecorator(IObjectTypeProvider objectTypeProvider) : base(objectTypeProvider) { }

        #region IRequestDecorator Members

        public override void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            requestClass.Members.Add(CreateRequiredConstructor(resourceClass, request, false));

            if (CreateOptionalConstructor && request.HasOptionalParameters())
            {
                requestClass.Members.Add(CreateRequiredConstructor(resourceClass, request, true));
            }
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

            // ISchemaAwareRequestExecutor service
            var serviceArg = new CodeParameterDeclarationExpression(typeof(IRequestProvider), "service");
            constructor.Parameters.Add(serviceArg);

            // : base(service)
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("service"));

            // Add all required arguments to the constructor.
            AddBodyParameter(constructor, request);
            AddRequestParameters(resourceClass, request, constructor, addOptionalParameters);

            return constructor;
        }
    }
}