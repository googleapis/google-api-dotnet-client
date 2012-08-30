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
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Declars the fields genericService and authenticator
    /// <code>
    ///     private Google.Apis.Discovery.IService genericService;
    ///     private Google.Apis.Authentication.IAuthenticator authenticator;
    /// </code>
    /// </summary>
    public class StandardServiceFieldServiceDecorator : IServiceDecorator
    {
        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            AddServiceFields(serviceClass);
            AddAuthenticatorProperty(serviceClass);
        }

        #endregion

        private void AddServiceFields(CodeTypeDeclaration serviceClass)
        {
            var field = new CodeMemberField(typeof(IService), ServiceClassGenerator.GenericServiceName);
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            serviceClass.Members.Add(field);

            field = new CodeMemberField(typeof(IAuthenticator), ServiceClassGenerator.AuthenticatorName);
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            serviceClass.Members.Add(field);
        }

        /// <summary>
        /// Add a IAuthenticator property "Authenticator" to the service.
        /// </summary>
        /// <param name="serviceClass">The service class to decorate.</param>
        private void AddAuthenticatorProperty(CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(new CodeMemberProperty() { 
                Attributes = MemberAttributes.Final | MemberAttributes.Public,
                Name = ServiceClassGenerator.AuthenticatorPropertyName,
                Type = new CodeTypeReference(typeof(IAuthenticator)),
                GetStatements = { 
                    new CodeMethodReturnStatement(
                        new CodeFieldReferenceExpression(
                            new CodeThisReferenceExpression(), ServiceClassGenerator.AuthenticatorName))
                },
                ImplementationTypes = { typeof(IRequestProvider) },
            });
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}