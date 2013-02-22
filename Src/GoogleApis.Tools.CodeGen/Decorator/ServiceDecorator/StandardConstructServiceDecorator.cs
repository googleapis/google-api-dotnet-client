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

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds the standard constuctor to the service class, 
    /// Invokes base service constructor with the initializer class and 
    /// creates a Resouce for each resource mentioned in the discovery document.
    /// e.g.
    ///     <code>
    ///     public XXXService(Initializer initializer) : base(initializer) 
    ///     {
    ///        this.activities = new Activities(this, Authenticator);
    ///        this.comments = new Comments(this, Authenticator);
    ///        this.groups = new Groups(this, Authenticator);
    ///        this.people = new People(this, Authenticator);
    ///        this.photos = new Photos(this, Authenticator);
    ///        this.related = new Related(this, Authenticator);
    ///        initParameters();
    ///    }
    ///     </code>
    /// </summary>
    public class StandardConstructServiceDecorator : IServiceDecorator
    {
        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            var baseConstructor = CreateConstructorWithArgs();

            AddResourceAssignments(service, baseConstructor);

            // generate: initParameters()
            baseConstructor.Statements.Add(new CodeMethodInvokeExpression(
                new CodeMethodReferenceExpression(new CodeThisReferenceExpression(), "InitParameters")));

            serviceClass.Members.Add(baseConstructor);
        }

        #endregion

        /// <summary>
        ///     Adds an assignment line for each Resource e.g.
        ///     <code>
        ///         this.people = new People(this);
        ///     </code>
        /// </summary>
        [VisibleForTestOnly]
        internal void AddResourceAssignments(IService service, CodeMemberMethod baseConstructor)
        {
            int resourceNumber = 1;
            foreach (var resource in service.Resources.Values)
            {
                AddResourceAssignment(baseConstructor, resource, resourceNumber, service.Resources.Keys);
                resourceNumber++;
            }
        }


        /// <summary>
        /// Creates the initializer constructor.
        /// e.g.
        ///     <code>
        ///         public XXXService(Initializer initializer)
        ///           : base(initializer) {}
        ///     </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructorWithArgs()
        {
            var constructor = new CodeConstructor();
            constructor.Attributes = MemberAttributes.Public;
            constructor.Parameters.Add(
                new CodeParameterDeclarationExpression(typeof(BaseClientService.Initializer), "initializer"));
            constructor.BaseConstructorArgs.Add(new CodeVariableReferenceExpression("initializer"));
            return constructor;
        }

        private void AddResourceAssignment(CodeMemberMethod constructor,
                                           IResource resource,
                                           int resourceNumber,
                                           IEnumerable<string> otherResourceNames)
        {
            IEnumerable<string> otherNames = otherResourceNames.Without(resource.Name);

            // Generate:  _files = new FilesResource(this, authenticator);
            constructor.Statements.Add(
                new CodeAssignStatement(
                    ServiceClassGenerator.GetFieldReference(resource, otherNames),
                    new CodeObjectCreateExpression(
                        GeneratorUtils.GetClassName(resource, otherNames),
                        new CodeThisReferenceExpression(),
                        new CodeVariableReferenceExpression(ServiceClassGenerator.AuthenticatorPropertyName))));
        }
    }
}