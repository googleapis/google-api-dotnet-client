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
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using System.Linq;
using log4net;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Responsible for generating the Service class, this is handled primarly by calling
    /// a secsesion of IServiceDecorator's 
    /// </summary>
    /// <seealso cref="IServiceDecorator"/>
    public class ServiceClassGenerator : BaseGenerator
    {
        public const string GenericServiceName = "genericService";
        public const string AuthenticatorName = "authenticator";
        private static readonly ILog logger = LogManager.GetLogger(typeof(ServiceClassGenerator));

        private readonly IEnumerable<IServiceDecorator> decorators;
        private readonly ResourceContainerGenerator resourceConainerGenerator;
        private readonly IService service;

        public ServiceClassGenerator(IService service,
                                     IEnumerable<IServiceDecorator> decorators,
                                     ResourceContainerGenerator resourceConainerGenerator)
        {
            this.decorators = decorators;
            this.service = service;
            this.resourceConainerGenerator = resourceConainerGenerator;
        }

        /// <summary>
        /// Creates a fully functional service class for the specified service
        /// </summary>
        public CodeTypeDeclaration CreateServiceClass()
        {
            string serviceClassName =
                GeneratorUtils.UpperFirstLetter(
                    GeneratorUtils.GetSafeMemberName(service.Name + "Service", "Cls", Enumerable.Empty<string>()));
            logger.DebugFormat("Starting Generation of Class {0}", serviceClassName);
            var serviceClass = new CodeTypeDeclaration(serviceClassName);
            serviceClass.BaseTypes.Add(typeof(IRequestExecutor));

            foreach (IServiceDecorator serviceDecorator in decorators)
            {
                logger.DebugFormat("Decorating Class {0} with {1}", serviceClassName, serviceDecorator);
                serviceDecorator.DecorateClass(service, serviceClass);
            }

            resourceConainerGenerator.AddResourceContainerDecorations(service, serviceClass);

            return serviceClass;
        }

        /// <summary>
        /// Returns the field reference to the given resource
        /// </summary>
        public static CodeFieldReferenceExpression GetFieldReference(IResource resource,
                                                                     int resourceNumber,
                                                                     IEnumerable<string> otherResourceNames)
        {
            return new CodeFieldReferenceExpression(
                new CodeThisReferenceExpression(),
                GeneratorUtils.GetFieldName(resource, resourceNumber, otherResourceNames));
        }
    }
}