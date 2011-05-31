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
using System.IO;
using Google.Apis.Testing;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds an execute method to the service which accepts an object and Serilises it to Json. 
    /// </summary>
    public class SchemaAwearExecuteMethodDecorator : IServiceDecorator
    {
        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.BaseTypes.Add(typeof(ISchemaAwareRequestExecutor));
            serviceClass.Members.Add(CreateExecuteMethod());
        }

        #endregion

        /// <summary>
        /// Adds an execute method to the service which accepts an object and Serilises it to Json.
        /// <code>
        ///     public Stream Execute(string resource, string method, object body, IDictonary&lt;string, string&gt; parameters) {
        ///         return execute(resource, method, ObjectToJson(body), parameters);
        ///     }
        /// </code> 
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateExecuteMethod()
        {
            var method = new CodeMemberMethod();

            method.Name = StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName;
            method.ReturnType = new CodeTypeReference(typeof(Stream));
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string), "resource"));
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string), "method"));
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(object), "body"));
            method.Parameters.Add(
                new CodeParameterDeclarationExpression(typeof(IDictionary<string, object>), "parameters"));
            // ObjectToJson(body)
            var objectToJson = new CodeMethodInvokeExpression();
            objectToJson.Method = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "ObjectToJson");
            objectToJson.Parameters.Add(new CodeVariableReferenceExpression("body"));

            // execute(resource, method, ObjectToJson(body), parameters)
            var methodInvoke = new CodeMethodInvokeExpression();
            methodInvoke.Method = new CodeMethodReferenceExpression(
                new CodeThisReferenceExpression(), StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName);
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("resource"));
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("method"));
            methodInvoke.Parameters.Add(objectToJson);
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("parameters"));

            var returnStatment = new CodeMethodReturnStatement(methodInvoke);

            method.Statements.Add(returnStatment);

            return method;
        }
    }
}