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

using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds a conveniounce zero argument constructor to the service.
    /// Using the AuthenticatorFactory to get the IAuthenticator and using a DiscoverService based on a WebDiscoveryDevice
    /// This is an optional decorator.
    /// </summary>
    public class EasyConstructServiceDecorator : IServiceDecorator
    {
        public void DecorateClass (IService service, CodeTypeDeclaration serviceClass)
        {
            var constructor = CreateConstructor (service, serviceClass);
            serviceClass.Members.Add (constructor);
        }

        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructor (IService service, CodeTypeDeclaration serviceClass)
        {
            var constructor = new CodeConstructor ();
            
            constructor.Attributes = MemberAttributes.Public;
            constructor.ChainedConstructorArgs.Add (GetService (service, serviceClass));
            constructor.ChainedConstructorArgs.Add (GetAuthenticator ());
            return constructor;
        }

        [VisibleForTestOnly]
        internal CodeExpression GetService (IService service, CodeTypeDeclaration serviceClass)
        {
            /*
            new DiscoveryService(
                new WebDiscoveryDevice(
                    new Uri("https://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)
                    )).GetService(version, DiscoveryVersionUsed)
            */            
            var discoveryUrl = new CodePrimitiveExpression ("https://www.googleapis.com/discovery/0.1/describe?api=");
            var serviceName = new CodeFieldReferenceExpression (
                new CodeTypeReferenceExpression (serviceClass.Name), VersionInformationServiceDecorator.NameName);
            
            
            var uriConstructor = new CodeObjectCreateExpression ();
            uriConstructor.CreateType = new CodeTypeReference (typeof(Uri));
            uriConstructor.Parameters.Add (new CodeBinaryOperatorExpression (discoveryUrl, CodeBinaryOperatorType.Add, serviceName));
            
            var webConstructor = new CodeObjectCreateExpression ();
            webConstructor.CreateType = new CodeTypeReference (typeof(WebDiscoveryDevice));
            webConstructor.Parameters.Add (uriConstructor);
            
            var discoveryConstructor = new CodeObjectCreateExpression ();
            discoveryConstructor.CreateType = new CodeTypeReference (typeof(DiscoveryService));
            discoveryConstructor.Parameters.Add (webConstructor);
            
            var getServiceCall = new CodeMethodInvokeExpression ();
            getServiceCall.Method = new CodeMethodReferenceExpression (discoveryConstructor, "GetService");
            getServiceCall.Parameters.Add (new CodeFieldReferenceExpression (
                new CodeTypeReferenceExpression (serviceClass.Name), VersionInformationServiceDecorator.VersionName));
            getServiceCall.Parameters.Add (new CodeFieldReferenceExpression (
                new CodeTypeReferenceExpression (serviceClass.Name), VersionInformationServiceDecorator.DiscoveryVersionName));
            getServiceCall.Parameters.Add (GetVersionSpecificParameter(service, serviceClass));
            
            return getServiceCall;
        }
        
        
        /// <summary>
        /// Returns a CodeExpression that creates a Discovery specific FactoryPatameter.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeExpression GetVersionSpecificParameter(IService service, CodeTypeDeclaration serviceClass)
        {
            switch(service.DiscoveryVersion)
            {
            case DiscoveryVersion.Version_0_1:
                return new CodePrimitiveExpression(null);
            
            case DiscoveryVersion.Version_0_2:
                return new CodeObjectCreateExpression(typeof(FactoryParameterV0_2),
                    new CodePrimitiveExpression(null),
                    new CodeFieldReferenceExpression (new CodeTypeReferenceExpression (serviceClass.Name), VersionInformationServiceDecorator.BaseUriName));

            case DiscoveryVersion.Version_0_3:
                 return new CodeObjectCreateExpression(typeof(FactoryParameterV0_3),
                    new CodePrimitiveExpression(null),
                    new CodeFieldReferenceExpression (new CodeTypeReferenceExpression (serviceClass.Name), VersionInformationServiceDecorator.BaseUriName));

            default:
                throw new NotSupportedException("The Discovery version "+service.DiscoveryVersion+" is not yet supported");
            }
        }

        /// <summary>
        /// Generatrs the following code
        /// <code>
        ///     Authentication.AuthenticatorFactory.
        ///         GetInstance().
        ///         GetRegisteredAuthenticator();   
        /// </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeExpression GetAuthenticator ()
        {
            var authenticatorFactory = new CodeMethodInvokeExpression (new CodeMethodReferenceExpression (new CodeTypeReferenceExpression (typeof(Authentication.AuthenticatorFactory)), "GetInstance"));
            return new CodeMethodInvokeExpression (authenticatorFactory, "GetRegisteredAuthenticator");
            //return new CodeObjectCreateExpression("ConsoleAuthenticator");
        }
        
        public override string ToString ()
        {
            return this.GetType().Name;
        }
    }
}
