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
using System.IO;
using System.Runtime.InteropServices;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Abstract implementation of a resource generator.
    /// </summary>
    public abstract class ResourceBaseGenerator : BaseGenerator
    {
        public const string ResourceNameConst = "Resource";
        protected const string ParameterDictionaryName = "parameters";
        protected const string ReturnVariableName = "ret";
        public const string ServiceFieldName = "service";
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ResourceBaseGenerator>();

        protected void ResourceCallAddBodyDeclaration(IMethod method,
                                                      CodeMemberMethod member,
                                                      CodeTypeReference bodyType,
                                                      bool addBodyIfUnused)
        {
            switch (method.HttpMethod)
            {
                case Request.GET:
                case Request.DELETE:
                    if (!addBodyIfUnused)
                    {
                        break;
                    }

                    // string body = null;
                    var bodyVarDeclaration = new CodeVariableDeclarationStatement(bodyType, "body");
                    bodyVarDeclaration.InitExpression = new CodePrimitiveExpression(null);
                    member.Statements.Add(bodyVarDeclaration);
                    break;

                case Request.PUT:
                case Request.POST:
                case Request.PATCH:
                    // add body Parameter.
                    member.Parameters.Add(new CodeParameterDeclarationExpression(bodyType, "body"));
                    break;
                default:
                    throw new NotSupportedException("Unsupported HttpMethod [" + method.HttpMethod + "]");
            }
        }

        /// <summary>
        /// Returns the parameter type specified within the parameter.
        /// </summary>
        [VisibleForTestOnly]
        internal static Type GetParameterType(IParameter param)
        {
            param.ThrowIfNull("param");
            Type baseType = GetUnderlyingParameterType(param);

            // If this is a repeatable parameter, wrap the underlying type into a Repeatable<T>.
            if (param.IsRepeatable)
            {
                return typeof(Repeatable<>).MakeGenericType(baseType);
            }

            return baseType;
        }

        /// <summary>
        /// Retrieves the underlying, unmodified type of a parameter.
        /// </summary>
        private static Type GetUnderlyingParameterType(IParameter param)
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
        [VisibleForTestOnly]
        internal static CodeTypeReference GetParameterTypeReference(CodeTypeDeclaration classDeclaration,
                                                                    IParameter param)
        {
            Type underlyingType = GetParameterType(param);
            CodeTypeReference paramTypeRef = new CodeTypeReference(underlyingType);
            bool isValueType = underlyingType.IsValueType;

            // Check if we need to declare a custom type for this parameter. 
            // If the parameter is an enum, try finding the matching enumeration in the current class
            if (!param.EnumValues.IsNullOrEmpty())
            {
                // Naming scheme: MethodnameParametername
                CodeTypeReference enumReference = DecoratorUtil.FindFittingEnumeration(
                    classDeclaration, param.EnumValues, param.EnumValueDescriptions);

                if (enumReference != null)
                {
                    paramTypeRef = enumReference;
                    isValueType = true;
                }
            }

            // Check if this is an optional value parameter.
            if (isValueType && !param.IsRequired)
            {
                // An optional value parameter has to be nullable.
                paramTypeRef = new CodeTypeReference(paramTypeRef.BaseType + "?");
            }

            return paramTypeRef;
        }

        /// <summary>
        /// Creates a declaration for the specified parameter.
        /// </summary>
        protected CodeParameterDeclarationExpression DeclareInputParameter(CodeTypeDeclaration classDeclaration,
                                                                            IParameter param,
                                                                           IMethod method)
        {
            CodeTypeReference paramTypeRef = GetParameterTypeReference(classDeclaration, param);
            var decl = new CodeParameterDeclarationExpression(
                paramTypeRef, GeneratorUtils.GetParameterName(param, method.Parameters.Keys.Without(param.Name)));

            // If this parameter is optional, mark it as as a C# 4.0 optional parameter:
            if (!param.IsRequired)
            {
                // [Optional]
                decl.CustomAttributes.Add(
                    new CodeAttributeDeclaration(new CodeTypeReference(typeof(OptionalAttribute))));
            }
            return decl;
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
                    CreateRequestMethodServiceDecorator.CreateRequestMethodName);

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
            var dotStream = new CodePropertyReferenceExpression(call, "Stream");
            var assign = new CodeVariableDeclarationStatement(typeof(Stream), ReturnVariableName, dotStream);

            return assign;
        }

        protected abstract string GetClassName();
    }
}