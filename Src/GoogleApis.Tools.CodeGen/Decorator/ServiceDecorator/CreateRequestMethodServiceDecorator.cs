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

using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds the Method <code>CreateRequest(string resource, string method)</code>
    /// </summary>
    /// <remarks>
    /// This method is required for the generated code to function. So either this decorator or another 
    /// that creates this method should be included in the code-generation process.
    /// </remarks>
    public class CreateRequestMethodServiceDecorator : IServiceDecorator
    {
        /// <summary>
        /// The name of the CreateRequest-method
        /// </summary>
        public const string CreateRequestMethodName = "CreateRequest";

        private static readonly ILogger logger =
            ApplicationContext.Logger.ForType<CreateRequestMethodServiceDecorator>();

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            logger.Debug("Entering DecorateClass");
            serviceClass.Members.Add(GenerateCreateRequestMethod());
        }

        #endregion

        /// <summary>
        /// Generates the <c>IClientService.CreateRequest()</c> method.
        /// </summary>
        /// <returns><c>CodeMemberMethod</c> describing the method.</returns>
        internal CodeMemberMethod GenerateCreateRequestMethod()
        {
            var method = new CodeMemberMethod();

            // Generate: public override Google.Apis.Requests.IRequest CreateRequest(IServiceRequest serviceRequest)
            method.Name = CreateRequestMethodName;
            method.ReturnType = new CodeTypeReference(typeof(IRequest));
            method.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IClientServiceRequest), "serviceRequest"));

            //Google.Apis.Requests.IRequest request = Request.CreateRequest(this, serviceRequest);
            method.Statements.Add(CreateRequestLocalVar());

            // if (string.IsNullOrEmpty(APIKey) == false)
            //     request = request.WithAPIKey(APIKey)
            method.Statements.Add(CreateWithApiKey());

            // return request.WithAuthentication(Authenticator);
            var statement =
                new CodeMethodInvokeExpression(
                    new CodeMethodReferenceExpression(
                        new CodeVariableReferenceExpression("request"), "WithAuthentication"),
                    new CodeVariableReferenceExpression(ServiceClassGenerator.AuthenticatorPropertyName));
            var returnStatment = new CodeMethodReturnStatement(statement);

            method.Statements.Add(returnStatment);
            return method;
        }

        /// <summary>
        /// <code>Google.Apis.Requests.IRequest request = Request.CreateRequest(this, serviceRequest);</code>
        /// </summary>
        private CodeVariableDeclarationStatement CreateRequestLocalVar()
        {
            var createRequest = new CodeMethodInvokeExpression();
            createRequest.Method =
                new CodeMethodReferenceExpression(
                    new CodeTypeReferenceExpression(typeof(Request)), "CreateRequest");
            createRequest.Parameters.Add(new CodeThisReferenceExpression());
            createRequest.Parameters.Add(new CodeVariableReferenceExpression("serviceRequest"));

            var createAndAssignRequest = new CodeVariableDeclarationStatement();
            createAndAssignRequest.Type = new CodeTypeReference(typeof(IRequest));
            createAndAssignRequest.Name = "request";
            createAndAssignRequest.InitExpression = createRequest;

            return createAndAssignRequest;
        }

        /// <summary>
        /// if (string.IsNullOrEmpty(APIKey) == false)
        ///    request = request.WithAPIKey(APIKey)
        /// </summary>
        /// <returns></returns>
        internal CodeConditionStatement CreateWithApiKey()
        {
            // !string.IsNullOrEmpty(Key)
            var condition = new CodeBinaryOperatorExpression(
                new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(typeof(string)), "IsNullOrEmpty",
                        new CodeVariableReferenceExpression("ApiKey")),
                CodeBinaryOperatorType.ValueEquality,
                new CodePrimitiveExpression(false));

            // if (...) {
            var block = new CodeConditionStatement(condition);

            // request = request.WithKey(Key)
            var getProperty = new CodePropertyReferenceExpression(
                new CodeThisReferenceExpression(), "ApiKey");
            var request = new CodeMethodInvokeExpression(
                new CodeVariableReferenceExpression("request"), "WithKey", getProperty);

            var trueCase = new CodeAssignStatement(new CodeVariableReferenceExpression("request"), request);

            // }
            block.TrueStatements.Add(trueCase);

            return block;
        }
    }
}