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
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen
{
    public abstract class ResourceBaseGenerator : BaseGenerator
    {
        public const string ResourceNameConst = "Resource";
        protected const string ParameterDictionaryName = "parameters";
        protected const string ReturnVariableName = "ret";
        public const string ServiceFieldName = "service";

        public ResourceBaseGenerator ()
        {
        }

        protected IEnumerable<Parameter> GetRequiredParameters (Method method)
        {
            if(method == null || method.Parameters == null || method.Parameters.Count == 0)
            {
                return new List<Parameter>(0);
            }
            return from p in method.Parameters 
                    where p.Value.Required 
                    select p.Value;
        }


        protected IEnumerable<Parameter> GetOptionalParameters (Method method)
        {
            if(method == null || method.Parameters == null || method.Parameters.Count == 0)
            {
                return new List<Parameter>(0);
            }
            return from p in method.Parameters 
                    where p.Value.Required == false
                    select p.Value;
        }

        protected bool HasRequiredParameters (Method method)
        {
            return GetRequiredParameters (method).Any ();
        }

        protected bool HasOptionalParameters (Method method)
        {
            return GetOptionalParameters (method).Any ();
        }

        protected void ResourceCallAddBodyDeclaration (Method method, CodeMemberMethod member)
        {
            switch (method.HttpMethod)
            {
            case "GET":
            case "DELETE":
                // string body = null;
                var bodyVarDeclaration = new CodeVariableDeclarationStatement (typeof(string), "body");
                bodyVarDeclaration.InitExpression = new CodePrimitiveExpression (null);
                member.Statements.Add (bodyVarDeclaration);
                break;
            case "PUT":
            case "POST":
                // add body Parameter
                member.Parameters.Add (new CodeParameterDeclarationExpression (typeof(string), "body"));
                break;
            default:
                throw new NotSupportedException ("Unsupported HttpMethod [" + method.HttpMethod + "]");
            }
        }

        protected CodeParameterDeclarationExpression DeclareInputParameter (Parameter param, int parameterCount)
        {
            return new CodeParameterDeclarationExpression (typeof(string), GeneratorUtils.GetParameterName (param, parameterCount));
        }

        protected CodeAssignStatement AssignParameterToDictionary (Parameter param, int parameterCount)
        {
            
            var assign = new CodeAssignStatement ();
            assign.Left = new CodeArrayIndexerExpression (new CodeVariableReferenceExpression (ParameterDictionaryName), new CodePrimitiveExpression (param.Name));
            
            assign.Right = new CodeVariableReferenceExpression (GeneratorUtils.GetParameterName (param, parameterCount));
            
            
            return assign;
        }

        protected CodeStatement CreateExecuteRequest (Method method)
        {
            var call = new CodeMethodInvokeExpression ();
            
            call.Method = new CodeMethodReferenceExpression (new CodeFieldReferenceExpression (new CodeThisReferenceExpression (), ServiceFieldName), StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName);
            
            call.Parameters.Add (new CodeFieldReferenceExpression (new CodeTypeReferenceExpression (this.GetClassName ()), ResourceNameConst));
            call.Parameters.Add (new CodePrimitiveExpression (method.Name));
            call.Parameters.Add (new CodeVariableReferenceExpression ("body"));
            call.Parameters.Add (new CodeVariableReferenceExpression (ParameterDictionaryName));
            
            var assign = new CodeVariableDeclarationStatement (typeof(System.IO.Stream), ReturnVariableName, call);
            
            return assign;
        }

        protected abstract string GetClassName ();
    }
}
