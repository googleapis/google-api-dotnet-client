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
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Responsible for generating the Service class, this is handled primarly by calling
    /// a secsesion of IServiceDecorator's 
    /// </summary>
    /// <seealso cref="IServiceDecorator"/>
    public class ServiceClassGenerator : BaseGenerator
    {
        public const string GenericServiceName = "_service";
        public const string AuthenticatorName = "_authenticator";
        public const string AuthenticatorPropertyName = "Authenticator";
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ServiceClassGenerator>();

        private readonly IEnumerable<IServiceDecorator> decorators;
        private readonly ResourceContainerGenerator resourceContainerGenerator;
        private readonly IService service;

        public ServiceClassGenerator(IService service,
                                     IEnumerable<IServiceDecorator> decorators,
                                     ResourceContainerGenerator resourceContainerGenerator)
        {
            this.decorators = decorators;
            this.service = service;
            this.resourceContainerGenerator = resourceContainerGenerator;
        }

        /// <summary>
        /// Creates a fully functional service class for the specified service
        /// </summary>
        public CodeTypeDeclaration CreateServiceClass()
        {
            string serviceClassName = GeneratorUtils.GetSafeMemberName(
                Enumerable.Empty<string>(), GeneratorUtils.TargetCase.ToUpper, service.Name + "Service",
                service.Name + "Cls");
            logger.Debug("Starting Generation of Class {0}", serviceClassName);
            var serviceClass = new CodeTypeDeclaration(serviceClassName);
            serviceClass.IsPartial = true;
            serviceClass.BaseTypes.Add(typeof(IRequestProvider));

            // Decorate the service class.
            foreach (IServiceDecorator serviceDecorator in decorators)
            {
                logger.Debug("Decorating Class {0} with {1}", serviceClassName, serviceDecorator);
                serviceDecorator.DecorateClass(service, serviceClass);
            }

            return serviceClass;
        }

        /// <summary>
        /// Returns the field reference to the given resource
        /// </summary>
        public static CodeFieldReferenceExpression GetFieldReference(IResource resource,
                                                                     IEnumerable<string> otherResourceNames)
        {
            return new CodeFieldReferenceExpression(
                new CodeThisReferenceExpression(), GeneratorUtils.GetFieldName(resource, otherResourceNames));
        }
    }
}