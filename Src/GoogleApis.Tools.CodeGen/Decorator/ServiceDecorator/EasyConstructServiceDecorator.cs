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

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds a convenience zero argument constructor to the service.
    /// Using the AuthenticatorFactory to get the IAuthenticator and using a DiscoverService based on a WebDiscoveryDevice
    /// This is an optional decorator.
    /// </summary>
    public class EasyConstructServiceDecorator : IServiceDecorator
    {
        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            var constructor = CreateConstructor(service, serviceClass);
            serviceClass.Members.Add(constructor);
        }

        #endregion

        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructor(IService service, CodeTypeDeclaration serviceClass)
        {
            var constructor = new CodeConstructor();

            constructor.Attributes = MemberAttributes.Public;
            constructor.ChainedConstructorArgs.Add(GetService(service, serviceClass));
            constructor.ChainedConstructorArgs.Add(GetAuthenticator());
            return constructor;
        }

        [VisibleForTestOnly]
        internal CodeExpression GetDiscoveryUrl(IService service, CodeTypeDeclaration serviceClass)
        {
            var discoveryUrlFormat = new CodePrimitiveExpression(GetUrlFormat(service));
            var serviceName = new CodeFieldReferenceExpression(
                new CodeTypeReferenceExpression(serviceClass.Name), VersionInformationServiceDecorator.NameName);
            var serviceVersion = new CodeFieldReferenceExpression(
                new CodeTypeReferenceExpression(serviceClass.Name), VersionInformationServiceDecorator.VersionName);
            var stringFormat = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression(typeof(string)), "Format", discoveryUrlFormat, serviceName,
                serviceVersion);
            return stringFormat;
        }

        [VisibleForTestOnly]
        internal CodeExpression GetService(IService service, CodeTypeDeclaration serviceClass)
        {
            /*
            new DiscoveryService(
                new WebDiscoveryDevice(
                    new Uri(string.Format(
                        "https://www.googleapis.com/discovery/0.1/describe?api={0}&version={1}",
                        serviceName, serviceVersion))
                    )).GetService(version, DiscoveryVersionUsed)
            */
            CodeExpression discoveryUrl = GetDiscoveryUrl(service, serviceClass);

            var uriConstructor = new CodeObjectCreateExpression();
            uriConstructor.CreateType = new CodeTypeReference(typeof(Uri));
            uriConstructor.Parameters.Add(discoveryUrl);

            var webConstructor = new CodeObjectCreateExpression();
            webConstructor.CreateType = new CodeTypeReference(typeof(CachedWebDiscoveryDevice));
            webConstructor.Parameters.Add(uriConstructor);

            var discoveryConstructor = new CodeObjectCreateExpression();
            discoveryConstructor.CreateType = new CodeTypeReference(typeof(DiscoveryService));
            discoveryConstructor.Parameters.Add(webConstructor);

            var getServiceCall = new CodeMethodInvokeExpression();
            getServiceCall.Method = new CodeMethodReferenceExpression(discoveryConstructor, "GetService");
            getServiceCall.Parameters.Add(
                new CodeFieldReferenceExpression(
                    new CodeTypeReferenceExpression(serviceClass.Name), VersionInformationServiceDecorator.VersionName));
            getServiceCall.Parameters.Add(
                new CodeFieldReferenceExpression(
                    new CodeTypeReferenceExpression(serviceClass.Name),
                    VersionInformationServiceDecorator.DiscoveryVersionName));
            getServiceCall.Parameters.Add(GetVersionSpecificParameter(service, serviceClass));

            return getServiceCall;
        }

        private static string GetUrlFormat(IService service)
        {
            switch (service.DiscoveryVersion)
            {
                case DiscoveryVersion.Version_0_3:
                    return "https://www.googleapis.com/discovery/v0.3/describe/{0}/{1}";
                case DiscoveryVersion.Version_1_0:
                    return "https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest";
                default:
                    throw new NotSupportedException(
                        string.Format("Discovery Version {0} is not supported", service.DiscoveryVersion));
            }
        }


        /// <summary>
        /// Returns a CodeExpression that creates a Discovery specific FactoryParameter.
        /// Resulting Code:     new FactoryParameterV*(new Uri(DiscoveryService.BaseUri))
        /// </summary>
        [VisibleForTestOnly]
        internal CodeExpression GetVersionSpecificParameter(IService service, CodeTypeDeclaration serviceClass)
        {
            // DiscoveryService.BaseUri
            var baseUriRef = new CodeFieldReferenceExpression(
                new CodeTypeReferenceExpression(serviceClass.Name), VersionInformationServiceDecorator.BaseUriName);

            // new Uri(..)
            var uriConstructor = new CodeObjectCreateExpression();
            uriConstructor.CreateType = new CodeTypeReference(typeof(Uri));
            uriConstructor.Parameters.Add(baseUriRef);

            // new ..FactoryParameters(..)
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

        /// <summary>
        /// Generates the following code
        /// <code>
        ///     Authentication.AuthenticatorFactory.
        ///         GetInstance().
        ///         GetRegisteredAuthenticator();   
        /// </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeExpression GetAuthenticator()
        {
            var authenticatorFactory =
                new CodeMethodInvokeExpression(
                    new CodeMethodReferenceExpression(
                        new CodeTypeReferenceExpression(typeof(AuthenticatorFactory)), "GetInstance"));
            return new CodeMethodInvokeExpression(authenticatorFactory, "GetRegisteredAuthenticator");
            //return new CodeObjectCreateExpression("ConsoleAuthenticator");
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}