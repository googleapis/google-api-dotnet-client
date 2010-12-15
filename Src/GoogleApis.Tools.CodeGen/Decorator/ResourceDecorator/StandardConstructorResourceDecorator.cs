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
    /// Creates a constructor for this resource, this is a standard decorator so this either needs to be 
    /// present or another decorator that creates a constructor with the same signature put in.
    /// </summary>
    public class StandardConstructorResourceDecorator : IResourceDecorator
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger (typeof(StandardConstructorResourceDecorator));

        public void DecorateClass (IResource resource, string className, CodeTypeDeclaration resourceClass, 
                                   ResourceClassGenerator generator, string serviceClassName, 
                                   IEnumerable<IResourceDecorator> allDecorators)
        {
            logger.DebugFormat ("Adding standard constructor to Resource[{0}]", resource.Name);
            resourceClass.Members.Add (CreateConstructor (serviceClassName));
        }


        public void DecorateMethodBeforeExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
        }


        public void DecorateMethodAfterExecute (IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
        }

        [VisibleForTestOnly]
        internal CodeConstructor CreateConstructor (String serviceClassName)
        {
            var constructor = new CodeConstructor ();
            
            // public [ResourceClass]([ServiceClass] service)
            constructor.Attributes = MemberAttributes.Public;
            constructor.Parameters.Add (new CodeParameterDeclarationExpression (serviceClassName, 
                                                ResourceBaseGenerator.ServiceFieldName));
            
            // this.service = service
            constructor.Statements.Add (
                new CodeAssignStatement (
                    new CodeFieldReferenceExpression (
                        new CodeThisReferenceExpression (), 
                        ResourceBaseGenerator.ServiceFieldName), 
                    new CodeArgumentReferenceExpression (ResourceBaseGenerator.ServiceFieldName)));
            return constructor;
        }
    }
}

