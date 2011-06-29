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
    /// Generates the standard constructor for requests.
    /// Example:
    /// <c>public ListRequest(ISchemaAwareRequestExecutor service, int requiredParameter, ..) : base(service) {..}</c>
    /// </summary>
    public class RequestConstructorDecorator : IRequestDecorator
    {
        private readonly IObjectTypeProvider objectTypeProvider;

        /// <summary>
        /// Creates a new request constructor decorator.
        /// </summary>
        public RequestConstructorDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
        }

        #region IRequestDecorator Members

        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            requestClass.Members.Add(CreateRequiredConstructor(resourceClass, request, false));

            if (request.HasOptionalParameters())
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
            var serviceArg = new CodeParameterDeclarationExpression(typeof(ISchemaAwareRequestExecutor), "service");
            constructor.Parameters.Add(serviceArg);

            // : base(service)
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("service"));

            // Add all required arguments to the constructor.
            AddBodyParameter(constructor, request);
            AddParameters(resourceClass, request, constructor, addOptionalParameters);

            return constructor;
        }

        /// <summary>
        /// Adds the body parameter and statement to the constructor if it is required.
        /// </summary>
        [VisibleForTestOnly]
        internal void AddBodyParameter(CodeConstructor constructor, IMethod request)
        {
            const string varName = "body";

            if (!request.HasBody)
            {
                return; // No body parameter required.
            }

            CodeTypeReference bodyType = objectTypeProvider.GetBodyType(request);
            var thisRef = new CodeThisReferenceExpression();

            // TBody body
            constructor.Parameters.Add(new CodeParameterDeclarationExpression(bodyType, varName));

            // this.Body = body;
            var assign = new CodeAssignStatement();
            assign.Left = new CodePropertyReferenceExpression(thisRef, BodyPropertyDecorator.BodyPropertyName);
            assign.Right = new CodeVariableReferenceExpression(varName);
            constructor.Statements.Add(assign);
        }

        /// <summary>
        /// Adds all required parameters and statements of this request to the specified constructor.
        /// </summary>
        [VisibleForTestOnly]
        internal void AddParameters(CodeTypeDeclaration resourceClass,
                                    IMethod request,
                                    CodeConstructor constructor,
                                    bool addOptional)
        {
            if (request.Parameters == null)
            {
                return; // Nothing to do here.
            }

            foreach (IParameter parameter in request.GetAllParametersSorted())
            {
                if (!addOptional && !parameter.IsRequired)
                {
                    continue;
                }

                // Retrieve parameter data.
                string name = parameter.Name;
                CodeTypeReference type = ResourceBaseGenerator.GetParameterTypeReference(
                    resourceClass, parameter, request);
                IEnumerable<string> usedWords = from IParameter p in request.Parameters.Values select p.Name;
                string parameterName = GeneratorUtils.GetParameterName(parameter, usedWords.Without(parameter.Name));
                string fieldName = GeneratorUtils.GetFieldName(name, Enumerable.Empty<string>());

                // Add the constructor parameter. (e.g. JsonSchema schema)
                var newParameter = new CodeParameterDeclarationExpression(type, parameterName);
                constructor.Parameters.Add(newParameter);

                // Make the parameter optional if required.
                if (!parameter.IsRequired)
                {
                    var optionalTypeRef = new CodeTypeReference(typeof(OptionalAttribute));
                    newParameter.CustomAttributes.Add(new CodeAttributeDeclaration(optionalTypeRef));
                }

                // Add the initialisation expression (e.g. this.schema = schema;)
                var initStatement = new CodeAssignStatement();
                initStatement.Left = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);
                initStatement.Right = new CodeVariableReferenceExpression(parameterName);
                constructor.Statements.Add(initStatement);
            }
        }
    }
}