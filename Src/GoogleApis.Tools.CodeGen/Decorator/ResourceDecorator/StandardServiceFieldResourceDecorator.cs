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
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// Adds a reference to the IRequestExecutor, this is a standard decorator so must be present 
    /// or another Decorator that provides adds the same field.
    /// </summary>
    public class StandardServiceFieldResourceDecorator : IResourceDecorator
    {
        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            if (resource.IsServiceResource)
            {
                resourceClass.Members.Add(CreateFakeServiceField());
            }
            else
            {
                resourceClass.Members.Add(CreateServiceField(serviceClassName));
                resourceClass.Members.Add(CreateAuthenticatorField());
            }
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            // NoOp
        }

        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            // NoOp
        }

        #endregion

        /// <summary>
        /// Adds <code>private BuzzService service;</code> to the resource class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateServiceField(string serviceClassName)
        {
            CodeMemberField serviceField;
            serviceField = new CodeMemberField(serviceClassName, ResourceBaseGenerator.ServiceFieldName);
            serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            return serviceField;
        }

        /// <summary>
        /// Adds <code>private Google.Apis.Authentication.IAuthenticator authenticator;</code> to the resource class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateAuthenticatorField()
        {
            CodeMemberField serviceField;
            serviceField = new CodeMemberField(typeof(Google.Apis.Authentication.IAuthenticator),
                ServiceClassGenerator.AuthenticatorName);
            serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            return serviceField;
        }

        /// <summary>
        /// Adds <code>private BuzzService service { get { return this; } }</code> to the resource class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateFakeServiceField()
        {
            // private BuzzService service { .. }
            CodeMemberProperty serviceProperty = new CodeMemberProperty();
            serviceProperty.Type = new CodeTypeReference(typeof(IRequestProvider));
            serviceProperty.Name = ResourceBaseGenerator.ServiceFieldName;
            serviceProperty.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            
            // get { return this; }
            serviceProperty.HasGet = true;
            serviceProperty.GetStatements.Add(new CodeMethodReturnStatement(new CodeThisReferenceExpression()));
            return serviceProperty;
        }
    }
}