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
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds a convenience zero argument constructor to the service.
    /// Using the AuthenticatorFactory to get the IAuthenticator and using a DiscoverService based 
    /// on a WebDiscoveryDevice. This is an optional decorator.
    /// <code>
    ///   public [..]Service(IAuthenticator auth) { .. }
    /// </code>
    /// </summary>
    public class EasyConstructServiceDecorator : IServiceDecorator
    {
        /// <summary>
        /// Name of the constant string field which contains the discovery document.
        /// </summary>
        public const string DiscoveryConstantName = "DiscoveryDocument";

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(CreateEmptyConstructor());
            serviceClass.Members.Add(CreateAuthenticatorConstructor(service, serviceClass));
            serviceClass.Members.Add(CreateDiscoveryConstant(service));
        }

        #endregion

        [VisibleForTestOnly]
        internal CodeConstructor CreateEmptyConstructor()
        {
            // Example:  new TestService() : this(NullAuthenticator.Instance)
            var constructor = new CodeConstructor();

            constructor.Attributes = MemberAttributes.Public;
            var nullAuthenticator = new CodeTypeReferenceExpression(typeof(NullAuthenticator));
            constructor.ChainedConstructorArgs.Add(new CodeFieldReferenceExpression(nullAuthenticator, "Instance"));
            return constructor;
        }

        [VisibleForTestOnly]
        internal CodeConstructor CreateAuthenticatorConstructor(IService service, CodeTypeDeclaration serviceClass)
        {
            // Example:  new TestService(IAuthenticator authenticator) : this(..., authenticator)
            var constructor = new CodeConstructor();

            constructor.Attributes = MemberAttributes.Public;
            constructor.Parameters.Add(
                new CodeParameterDeclarationExpression(
                    typeof(IAuthenticator), ServiceClassGenerator.AuthenticatorName));
            constructor.ChainedConstructorArgs.Add(GetService(service, serviceClass));
            constructor.ChainedConstructorArgs.Add(
                new CodeVariableReferenceExpression(ServiceClassGenerator.AuthenticatorName));
            return constructor;
        }

        [VisibleForTestOnly]
        internal CodeMemberField CreateDiscoveryConstant(IService service)
        {
            string json = ((BaseService) service).GetDiscoveryDocument();

            // Example:  private const string DiscoveryDocument = "...";
            var field = new CodeMemberField(typeof(string), DiscoveryConstantName);
            field.Attributes = MemberAttributes.Const | MemberAttributes.Private; 
            field.InitExpression = new CodePrimitiveExpression(json);
            return field;
        }
        
        [VisibleForTestOnly]
        internal CodeExpression GetService(IService service, CodeTypeDeclaration serviceClass)
        {
            // Example:
            //     new DiscoveryService(new StringDiscoveryDevice(DiscoveryDocument)).GetService(DiscoveryVersionUsed)
            var discoveryDevice = new CodeObjectCreateExpression();
            discoveryDevice.CreateType = new CodeTypeReference(typeof(StringDiscoveryDevice));
            discoveryDevice.Parameters.Add(new CodeVariableReferenceExpression(DiscoveryConstantName));

            var discoveryConstructor = new CodeObjectCreateExpression();
            discoveryConstructor.CreateType = new CodeTypeReference(typeof(DiscoveryService));
            discoveryConstructor.Parameters.Add(discoveryDevice);

            var getServiceCall = new CodeMethodInvokeExpression();
            getServiceCall.Method = new CodeMethodReferenceExpression(discoveryConstructor, "GetService");
            getServiceCall.Parameters.Add(
                new CodeFieldReferenceExpression(
                    new CodeTypeReferenceExpression(serviceClass.Name),
                    VersionInformationServiceDecorator.DiscoveryVersionName));
            getServiceCall.Parameters.Add(GetVersionSpecificParameter(service, serviceClass));

            return getServiceCall;
        }

        /// <summary>
        /// Returns a CodeExpression that creates a Discovery specific FactoryParameter.
        /// Resulting Code:     new FactoryParameterV*(new Uri(DiscoveryService.BaseUri))
        /// </summary>
        [VisibleForTestOnly]
        internal CodeExpression GetVersionSpecificParameter(IService service, CodeTypeDeclaration serviceClass)
        {
            // Example:  DiscoveryService.BaseUri
            var baseUriRef = new CodeFieldReferenceExpression(
                new CodeTypeReferenceExpression(serviceClass.Name), VersionInformationServiceDecorator.BaseUriName);

            // Example:  new Uri(..)
            var uriConstructor = new CodeObjectCreateExpression();
            uriConstructor.CreateType = new CodeTypeReference(typeof(Uri));
            uriConstructor.Parameters.Add(baseUriRef);

            // Example:  new ..FactoryParameters(..)
            switch (service.DiscoveryVersion)
            {
                case DiscoveryVersion.Version_0_3:
                    return new CodeObjectCreateExpression(
                        typeof(FactoryParameterV0_3), uriConstructor);

                case DiscoveryVersion.Version_1_0:
                    return new CodeObjectCreateExpression(
                        typeof(FactoryParameterV1_0), uriConstructor);

                default:
                    throw new NotSupportedException(
                        "The Discovery version " + service.DiscoveryVersion + " is not yet supported");
            }
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}