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
        #region IRequestDecorator Members

        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            requestClass.Members.Add(CreateConstructor(resourceClass, request));
        }

        #endregion

        /// <summary>
        /// Creates the constructor for this request class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructor(CodeTypeDeclaration resourceClass, IMethod request)
        {
            var constructor = new CodeConstructor();

            // ISchemaAwareRequestExecutor service
            var serviceArg = new CodeParameterDeclarationExpression(typeof(ISchemaAwareRequestExecutor), "service");
            constructor.Parameters.Add(serviceArg);

            // : base(service)
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("service"));

            // Add all required arguments to the constructor.
            AddRequiredParameters(resourceClass, request, constructor);

            return constructor;
        }

        /// <summary>
        /// Adds all required parameters of this request to the specified constructor.
        /// </summary>
        [VisibleForTestOnly]
        internal void AddRequiredParameters(CodeTypeDeclaration resourceClass,
                                            IMethod request,
                                            CodeConstructor constructor)
        {
            if (request.Parameters == null)
            {
                return; // Nothing to do here.
            }

            foreach (IParameter parameter in request.Parameters.Values)
            {
                if (!parameter.IsRequired)
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

                // Add the initialisation expression (e.g. this.schema = schema;)
                var initStatement = new CodeAssignStatement();
                initStatement.Left = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);
                initStatement.Right = new CodeVariableReferenceExpression(parameterName);
                constructor.Statements.Add(initStatement);
            }
        }
    }
}