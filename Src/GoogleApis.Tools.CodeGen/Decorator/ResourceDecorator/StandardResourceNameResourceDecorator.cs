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
    /// Adds the resource name as a private const field to the generated resource class.
    /// This is a standard class so this need to be present or another decorator that add a field 
    /// with the same name and type.
    /// </summary>
    public class StandardResourceNameResourceDecorator : IResourceDecorator
    {
        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            string fullName = resource.Path;
            resourceClass.Members.Add(CreateResourceNameConst(fullName));
        }


        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            //NoOp
        }


        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            //NoOp
        }

        #endregion

        /// <summary>
        /// Adds <code>private const string Resource = "activities";</code> to the resource class
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateResourceNameConst(string resourceName)
        {
            var serviceField = new CodeMemberField(typeof(string), ResourceBaseGenerator.ResourceNameConst);
            serviceField.Attributes = MemberAttributes.Const | MemberAttributes.Private;
            serviceField.InitExpression = new CodePrimitiveExpression(resourceName);

            return serviceField;
        }
    }
}