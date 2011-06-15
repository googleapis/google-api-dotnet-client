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
using System.IO;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Util;
using log4net;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Abstract implementation of a resource generator
    /// </summary>
    public abstract class ResourceBaseGenerator : BaseGenerator
    {
        public const string ResourceNameConst = "Resource";
        protected const string ParameterDictionaryName = "parameters";
        protected const string ReturnVariableName = "ret";
        public const string ServiceFieldName = "service";
        private static readonly ILog logger = LogManager.GetLogger(typeof(ResourceBaseGenerator));

        protected void ResourceCallAddBodyDeclaration(IMethod method,
                                                      CodeMemberMethod member,
                                                      CodeTypeReference bodyType)
        {
            switch (method.HttpMethod)
            {
                case Request.GET:
                case Request.DELETE:
                    // string body = null;
                    var bodyVarDeclaration = new CodeVariableDeclarationStatement(bodyType, "body");
                    bodyVarDeclaration.InitExpression = new CodePrimitiveExpression(null);
                    member.Statements.Add(bodyVarDeclaration);
                    break;
                case Request.PUT:
                case Request.POST:
                case Request.PATCH:
                    // add body Parameter
                    member.Parameters.Add(new CodeParameterDeclarationExpression(bodyType, "body"));
                    break;
                default:
                    throw new NotSupportedException("Unsupported HttpMethod [" + method.HttpMethod + "]");
            }
        }

        /// <summary>
        /// Returns the .NET equivalent of the type specified within the paramater
        /// </summary>
        [VisibleForTestOnly]
        internal static Type GetParameterType(IParameter param)
        {
            param.ThrowIfNull("param");
            
            switch (param.ValueType)
            {
                case null:
                case "":
                case "string":
                    return typeof(string);
                case "boolean":
                    return typeof(bool);
                case "integer":
                    return typeof(long);
                default:
                    logger.Error(
                        "FAIL - found unkown parameter.type [" + param.ValueType + "] for parameter [" + param.Name +
                        "]");
                    return typeof(string);
            }
        }

        /// <summary>
        /// Returns the reference to the type which is described in the parameter. Creates types if necessary.
        /// </summary>
        /// <param name="declaration">Newly generated type if required, or null</param>
        [VisibleForTestOnly]
        internal static CodeTypeReference GetParameterTypeReference(IParameter param,
                                                                    IMethod method,
                                                                    out CodeTypeDeclaration declaration)
        {
            declaration = null;
            method.ThrowIfNull("method");
            Type underlyingType = GetParameterType(param);
            CodeTypeReference paramTypeRef = new CodeTypeReference(underlyingType);
            bool isValueType = underlyingType.IsValueType;

            // Check if we need to declare a custom type for this parameter. 
            // If the parameter is an enum, we will have to generate the enumeration first
            if (param.EnumValues != null && param.EnumValues.Count() > 0)
            {
                // Naming scheme: MethodnameParametername
                string proposedName = method.Name + GeneratorUtils.UpperFirstLetter(param.Name);
                declaration = DecoratorUtil.GenerateEnum(
                    proposedName, param.Description, param.EnumValues, param.EnumValueDescriptions);
                paramTypeRef = new CodeTypeReference(declaration.Name);
                isValueType = true;
            }

            // Check if this is an optional value parameter.
            if (isValueType && !param.Required)
            {
                // An optional value parameter has to be nullable.
                paramTypeRef = new CodeTypeReference(paramTypeRef.BaseType + "?");
            }

            return paramTypeRef;
        }

        /// <summary>
        /// Creates a declaration for the specified parameter.
        /// </summary>
        protected CodeParameterDeclarationExpression DeclareInputParameter(IParameter param,
                                                                           IMethod method,
                                                                           out CodeTypeDeclaration declaration)
        {
            CodeTypeReference paramTypeRef = GetParameterTypeReference(param, method, out declaration);

            return new CodeParameterDeclarationExpression(
                paramTypeRef, GeneratorUtils.GetParameterName(param, method.Parameters.Keys.Without(param.Name)));
        }

        protected void AddParameterComment(IMethodCommentCreator commentCreator,
                                           CodeMemberMethod member,
                                           IParameter param,
                                           string parameterName)
        {
            if (commentCreator != null)
            {
                member.Comments.AddRange(commentCreator.CreateParameterComment(param, parameterName));
            }
        }

        protected CodeAssignStatement AssignParameterToDictionary(IParameter param, int parameterCount, IMethod method)
        {
            method.ThrowIfNull("method");

            var assign = new CodeAssignStatement();
            assign.Left = new CodeArrayIndexerExpression(
                new CodeVariableReferenceExpression(ParameterDictionaryName), new CodePrimitiveExpression(param.Name));

            assign.Right =
                new CodeVariableReferenceExpression(
                    GeneratorUtils.GetParameterName(param, method.Parameters.Keys.Without(param.Name)));
            return assign;
        }

        protected virtual CodeExpression GetBodyAsString(IMethod method)
        {
            return new CodeVariableReferenceExpression("body");
        }

        /// <summary>
        /// this.service.ExecuteRequest(...);
        /// </summary>
        protected CodeMethodInvokeExpression CreateExecuteCall(IMethod method)
        {
            var call = new CodeMethodInvokeExpression();


            call.Method =
                new CodeMethodReferenceExpression(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), ServiceFieldName),
                    StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName);

            call.Parameters.Add(
                new CodeFieldReferenceExpression(new CodeTypeReferenceExpression(GetClassName()), ResourceNameConst));
            call.Parameters.Add(new CodePrimitiveExpression(method.Name));
            call.Parameters.Add(GetBodyAsString(method));
            call.Parameters.Add(new CodeVariableReferenceExpression(ParameterDictionaryName));
            return call;
        }

        /// <summary>
        /// ret = this.service.ExecuteRequest(...);
        /// </summary>
        protected virtual CodeStatement CreateExecuteRequest(IMethod method)
        {
            var call = CreateExecuteCall(method);

            var assign = new CodeVariableDeclarationStatement(typeof(Stream), ReturnVariableName, call);

            return assign;
        }

        protected abstract string GetClassName();
    }
}