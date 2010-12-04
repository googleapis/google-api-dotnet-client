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
            string serviceClassName = UpperFirstLetter (service.Name) + "Service";
            logger.DebugFormat ("Starting Generation of Class {0}", serviceClassName);
            var serviceClass = new CodeTypeDeclaration (serviceClassName);
            serviceClass.BaseTypes.Add (typeof(IRequestExecutor));
            
            AddServiceFields (serviceClass);
            
            int resourceNumber = 1;
            foreach (var pair in service.Resources) {
                Resource resource = pair.Value;
                AddResourceGetter (serviceClass, resource, resourceNumber);
                AddResourceField (serviceClass, resource, resourceNumber);
                resourceNumber++;
            }
            
            foreach (IServiceDecorator serviceDecorator in decorators) {
                serviceDecorator.DecorateClass (service, serviceClass);
            }
            
            return serviceClass;
        }


        /// <summary>
        /// Declars the fields genericService and authenticator
        /// <code>
        ///     private Google.Apis.Discovery.IService genericService;
        ///     private Google.Apis.Authentication.IAuthenticator authenticator;
        /// </code>
        /// </summary>
        /// <param name="serviceClass">
        /// </param>
        [VisibleForTestOnly]
        static internal void AddServiceFields (CodeTypeDeclaration serviceClass)
        {
            var field = new CodeMemberField (typeof(IService), GenericServiceName);
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            serviceClass.Members.Add (field);
            
            field = new CodeMemberField (typeof(IAuthenticator), AuthenticatorName);
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            serviceClass.Members.Add (field);
        }


        /// <summary>
        /// 
        /// </summary>
        private void AddResourceField (CodeTypeDeclaration serviceClass, Resource resource, int resourceNumber)
        {
            // Add local private variables for each Resource
            var field = new CodeMemberField (GetClassName (resource, resourceNumber), GetFieldName (resource, resourceNumber));
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            serviceClass.Members.Add (field);
        }

        private void AddResourceGetter (CodeTypeDeclaration serviceClass, Resource resource, int resourceNumber)
        {
            var getter = new CodeMemberProperty ();
            getter.Name = GetClassName (resource, resourceNumber);
            getter.HasGet = true;
            getter.HasSet = false;
            getter.Attributes = MemberAttributes.Public;
            getter.Type = new CodeTypeReference (GetClassName (resource, resourceNumber));
            getter.GetStatements.Add (new CodeMethodReturnStatement (GetFieldReference (resource, resourceNumber)));
            
            serviceClass.Members.Add (getter);
        }

        public static CodeFieldReferenceExpression GetFieldReference (Resource resource, int resourceNumber)
        {
            return new CodeFieldReferenceExpression (new CodeThisReferenceExpression (), GetFieldName (resource, resourceNumber));
        }
    }
}