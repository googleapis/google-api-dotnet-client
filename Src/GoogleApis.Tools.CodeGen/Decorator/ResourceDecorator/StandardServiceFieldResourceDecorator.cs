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
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// Adds a reference to the IRequestExecutor, this is a standard decorator so must be present 
    /// or another Decorator that provides adds the same field.
    /// </summary>
    public class StandardServiceFieldResourceDecorator: IResourceDecorator
    {
        public void DecorateClass (IResource resource, string className, CodeTypeDeclaration resourceClass, 
                                   ResourceClassGenerator generator, string serviceClassName, 
                                   IEnumerable<IResourceDecorator> allDecorators)
        {
            resourceClass.Members.Add (CreateServiceField());
        }

        public void DecorateMethodBeforeExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            // NoOp
        }

        public void DecorateMethodAfterExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            // NoOp
        }
        
         /// <summary>
        /// Adds <code>private BuzzService service;</code> to the resource class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateServiceField ()
        {
            var serviceField = new CodeMemberField (typeof(IRequestExecutor), ResourceBaseGenerator.ServiceFieldName);
            serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            
            return serviceField;
        }
    }
}

