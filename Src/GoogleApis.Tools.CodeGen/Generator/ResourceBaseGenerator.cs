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
using System.Collections.Generic;
using System.CodeDom;
using System.Linq;

using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Generator
{
    public abstract class ResourceBaseGenerator : BaseGenerator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(ResourceBaseGenerator));
        
        public const string ResourceNameConst = "Resource";
        protected const string ParameterDictionaryName = "parameters";
        protected const string ReturnVariableName = "ret";
        public const string ServiceFieldName = "service";

        public ResourceBaseGenerator ()
        {
        }

        protected void ResourceCallAddBodyDeclaration (
                IMethod method, CodeMemberMethod member, CodeTypeReference bodyType)
        {
            switch (method.HttpMethod)
            {
            case Request.GET:
            case Request.DELETE:
                // string body = null;
                var bodyVarDeclaration = new CodeVariableDeclarationStatement (bodyType, "body");
                bodyVarDeclaration.InitExpression = new CodePrimitiveExpression (null);
                member.Statements.Add (bodyVarDeclaration);
                break;
            case Request.PUT:
            case Request.POST:
            case Request.PATCH:
                // add body Parameter
                member.Parameters.Add (new CodeParameterDeclarationExpression (bodyType, "body"));
                break;
            default:
                throw new NotSupportedException ("Unsupported HttpMethod [" + method.HttpMethod + "]");
            }
        }
  
        public static Type GetParameterType(IParameter param)
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
                logger.Error("FAIL - found unkown parameter.type ["+param.ValueType+"] for parameter ["+param.Name+"]");
                return typeof(string);
            }
        }
        
        protected CodeParameterDeclarationExpression DeclareInputParameter (IParameter param, int parameterCount, IMethod method)
        {
            method.ThrowIfNull("method");
            Type paramType = GetParameterType(param);
            return new CodeParameterDeclarationExpression (paramType, 
                GeneratorUtils.GetParameterName (param, parameterCount, method.Parameters.Keys));
        }
  
        protected void AddParameterComment(IMethodCommentCreator commentCreator, CodeMemberMethod member, 
                IParameter param, string parameterName)
        {
            if(commentCreator != null)
            {
                member.Comments.AddRange(commentCreator.CreateParameterComment(param, parameterName));
            }
        }
        
        protected CodeAssignStatement AssignParameterToDictionary (IParameter param, int parameterCount, IMethod method)
        {
            method.ThrowIfNull("method");

            var assign = new CodeAssignStatement ();
            assign.Left = new CodeArrayIndexerExpression (new CodeVariableReferenceExpression (ParameterDictionaryName), new CodePrimitiveExpression (param.Name));
            
            assign.Right = new CodeVariableReferenceExpression (GeneratorUtils.GetParameterName (param, parameterCount, method.Parameters.Keys));
            return assign;
        }
  
        protected virtual CodeExpression GetBodyAsString(IMethod method)
        {
            return new CodeVariableReferenceExpression ("body");
        }
        
        /// <summary>
        /// this.service.ExecuteRequest(...);
        /// </summary>
        protected CodeMethodInvokeExpression CreateExecuteCall(IMethod method)
        {
            var call = new CodeMethodInvokeExpression ();
            
            
            call.Method = new CodeMethodReferenceExpression (
                               new CodeFieldReferenceExpression (
                                   new CodeThisReferenceExpression (), ServiceFieldName), 
                               StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName);
            
            call.Parameters.Add (new CodeFieldReferenceExpression (new CodeTypeReferenceExpression (this.GetClassName ()), ResourceNameConst));
            call.Parameters.Add (new CodePrimitiveExpression (method.Name));
            call.Parameters.Add (GetBodyAsString(method));
            call.Parameters.Add (new CodeVariableReferenceExpression (ParameterDictionaryName));
            return call;
        }
        
        /// <summary>
        /// ret = this.service.ExecuteRequest(...);
        /// </summary>
        protected virtual CodeStatement CreateExecuteRequest (IMethod method)
        {
            var call = CreateExecuteCall(method);
            
            var assign = new CodeVariableDeclarationStatement (typeof(System.IO.Stream), ReturnVariableName, call);
            
            return assign;
        }

        protected abstract string GetClassName ();
    }
}
