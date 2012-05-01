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
    /// Base class supporting UploadConstructorDecorator and RequestConstructorDecorator.
    /// </summary>
    public abstract class BaseRequestConstructorDecorator : IRequestDecorator
    {
        protected readonly IObjectTypeProvider objectTypeProvider;

        protected BaseRequestConstructorDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
        }

        public abstract void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass);

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
        /// Adds all required parameters and assign statements of this request to the specified constructor.
        /// </summary>
        [VisibleForTestOnly]
        internal void AddRequestParameters(CodeTypeDeclaration resourceClass,
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

                // Retrieve parameter name and type.
                string name = parameter.Name;
                CodeTypeReference type = ResourceBaseGenerator.GetParameterTypeReference(
                    resourceClass, parameter);

                // Generate valid names for the parameter and the field.
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

                // Add the initialization expression (e.g. this.schema = schema;)
                var initStatement = new CodeAssignStatement();
                initStatement.Left = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);
                initStatement.Right = new CodeVariableReferenceExpression(parameterName);
                constructor.Statements.Add(initStatement);
            }
        }
    }
}