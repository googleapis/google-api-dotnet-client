using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Testing;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds an execute method to the service which accepts an object and Serilises it to Json. 
    /// </summary>
    public class SchemaAwearExecuteMethodDecorator : IServiceDecorator
    {
        /// <summary>
        /// Adds an execute method to the service which accepts an object and Serilises it to Json.
        /// <code>
        ///     public Stream Execute(string resource, string method, object body, IDictonary&lt;string, string&gt; parameters) {
        ///         return execute(resource, method, ObjectToJson(body), parameters);
        ///     }
        /// </code> 
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateExecuteMethod ()
        {
            var method = new CodeMemberMethod ();
            
            method.Name = StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName;
            method.ReturnType = new CodeTypeReference (typeof(System.IO.Stream));
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add (new CodeParameterDeclarationExpression (typeof(string), "resource"));
            method.Parameters.Add (new CodeParameterDeclarationExpression (typeof(string), "method"));
            method.Parameters.Add (new CodeParameterDeclarationExpression (typeof(object), "body"));
            method.Parameters.Add (new CodeParameterDeclarationExpression (typeof(IDictionary<string, string>), 
                                                                           "parameters"));
            // ObjectToJson(body)
            var objectToJson = new CodeMethodInvokeExpression();
            objectToJson.Method = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), 
                                        "ObjectToJson");
            objectToJson.Parameters.Add(new CodeVariableReferenceExpression("body"));
            
            // execute(resource, method, ObjectToJson(body), parameters)
            var methodInvoke = new CodeMethodInvokeExpression();
            methodInvoke.Method = new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), 
                                        StandardExecuteMethodServiceDecorator.ExecuteRequestMethodName);
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("resource"));
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("method"));
            methodInvoke.Parameters.Add(objectToJson);
            methodInvoke.Parameters.Add(new CodeVariableReferenceExpression("parameters"));
            
            var returnStatment = new CodeMethodReturnStatement (methodInvoke);
            
            method.Statements.Add (returnStatment);
            
            return method;
        }
        
        public void DecorateClass (Discovery.IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.BaseTypes.Add(typeof(ISchemaAwareRequestExecutor));
            serviceClass.Members.Add(CreateExecuteMethod());
        }
    }
}
