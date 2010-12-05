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
using System.Collections.Generic;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen
{

    /// <summary>
    /// Responsible for generating the Service class, this is handled primarly by calling
    /// a secsesion of IServiceDecorator's 
    /// </summary>
    /// <seealso cref="IServiceDecorator"/>
    public class ServiceClassGenerator : BaseGenerator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(ServiceClassGenerator));

        public const string GenericServiceName = "genericService";
        public const string AuthenticatorName = "authenticator";

        private readonly IEnumerable<IServiceDecorator> decorators;
        private readonly IService service;

        public ServiceClassGenerator (IService service, IEnumerable<IServiceDecorator> decorators)
        {
            this.decorators = decorators;
            this.service = service;
        }

        public CodeTypeDeclaration CreateServiceClass ()
        {
            string serviceClassName = GeneratorUtils.UpperFirstLetter (service.Name) + "Service";
            logger.DebugFormat ("Starting Generation of Class {0}", serviceClassName);
            var serviceClass = new CodeTypeDeclaration (serviceClassName);
            serviceClass.BaseTypes.Add (typeof(IRequestExecutor));
            
            foreach (IServiceDecorator serviceDecorator in decorators) {
                logger.DebugFormat("Decorating Class {0} with {1}", serviceClassName, serviceDecorator.ToString());
                serviceDecorator.DecorateClass (service, serviceClass);
            }
            
            return serviceClass;
        }

        public static CodeFieldReferenceExpression GetFieldReference (Resource resource, int resourceNumber)
        {
            return new CodeFieldReferenceExpression (new CodeThisReferenceExpression (), 
                          GeneratorUtils.GetFieldName (resource, resourceNumber));
        }
    }
}