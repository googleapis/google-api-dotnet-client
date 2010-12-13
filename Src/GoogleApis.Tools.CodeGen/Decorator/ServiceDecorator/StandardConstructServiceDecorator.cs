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

using Google.Apis.Discovery;
using Google.Apis.Authentication;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds the standard constuctor to the service class, 
    ///     assing genericService and authenticator to local vars
    ///     and create a Resouce for each resource mentioned in the discovery document.
    /// e.g.
    ///     <code>
    ///     public BuzzService(IService genericService, IAuthenticator authenticator) {
    ///        this.genericService = genericService;
    ///        this.authenticator = authenticator;
    ///        this.activities = new Activities(this);
    ///        this.comments = new Comments(this);
    ///        this.groups = new Groups(this);
    ///        this.people = new People(this);
    ///        this.photos = new Photos(this);
    ///        this.related = new Related(this);
    ///    }
    ///     </code>
    /// </summary>
    public class StandardConstructServiceDecorator : IServiceDecorator
    {
        public void DecorateClass (IService service, CodeTypeDeclaration serviceClass)
        {
            var baseConstructor = CreateConstructorWithArgs ();
            
            AddResourceAssignments (service, baseConstructor);
            
            serviceClass.Members.Add (baseConstructor);
        }


        /// <summary>
        ///     Adds an assignment line for each Resource e.g.
        ///     <code>
        ///         this.people = new People(this);
        ///     </code>
        /// </summary>
        [VisibleForTestOnly]
        internal void AddResourceAssignments (IService service, CodeMemberMethod baseConstructor)
        {
            int resourceNumber = 1;
            foreach (var pair in service.Resources) {
                Resource resource = pair.Value;
                AddResourceAssignment (baseConstructor, resource, resourceNumber);
                resourceNumber++;
            }
        }


        /// <summary>
        /// Creates the constructor with two arguments, ISerivce and IAuthenticator.
        /// Then assignes these to local variables.
        /// e.g.
        ///     <code>
        ///         public BuzzService(IService genericService, IAuthenticator authenticator) {
        ///             this.genericService = genericService;
        ///             this.authenticator = authenticator;
        ///     </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructorWithArgs ()
        {
            var constructor = new CodeConstructor ();
            constructor.Attributes = MemberAttributes.Public;
            constructor.Parameters.Add (new CodeParameterDeclarationExpression (typeof(IService), ServiceClassGenerator.GenericServiceName));
            constructor.Parameters.Add (new CodeParameterDeclarationExpression (typeof(IAuthenticator), ServiceClassGenerator.AuthenticatorName));
            
            {
                var assignService = new CodeAssignStatement ();
                // this.genericService = 
                assignService.Left = new CodeFieldReferenceExpression (new CodeThisReferenceExpression (), ServiceClassGenerator.GenericServiceName);
                // generricService
                assignService.Right = new CodeVariableReferenceExpression (ServiceClassGenerator.GenericServiceName);
                
                constructor.Statements.Add (assignService);
            }
            
            {
                var assignAuthenticator = new CodeAssignStatement ();
                // this.authenticator = 
                assignAuthenticator.Left = new CodeFieldReferenceExpression (new CodeThisReferenceExpression (), ServiceClassGenerator.AuthenticatorName);
                // authenticator
                assignAuthenticator.Right = new CodeVariableReferenceExpression (ServiceClassGenerator.AuthenticatorName);
                
                constructor.Statements.Add (assignAuthenticator);
            }
            
            return constructor;
        }

        private void AddResourceAssignment (CodeMemberMethod constructor, Resource resource, int resourceNumber)
        {
            constructor.Statements.Add (
                new CodeAssignStatement (
                    ServiceClassGenerator.GetFieldReference (resource, resourceNumber), 
                    new CodeObjectCreateExpression (
                        GeneratorUtils.GetClassName (resource, resourceNumber), 
                        new CodeThisReferenceExpression ())));
        }
        
        public override string ToString ()
        {
            return this.GetType().Name;
        }
        
    }
}

