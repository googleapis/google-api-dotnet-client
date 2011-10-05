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
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// Classes that implement this interface will be called when building a resource class.
    /// </summary>
    public interface IResourceDecorator
    {
        /// <summary>
        /// Adds code to the resourceClass based on the resource.
        /// </summary>
        void DecorateClass(IResource resource,
                           string className,
                           CodeTypeDeclaration resourceClass,
                           ResourceClassGenerator generator,
                           string serviceClassName,
                           IEnumerable<IResourceDecorator> allDecorators);

        /// <summary>
        /// Adds code to a method just before execution of the execute method.
        /// This can be used for logging, instramenting or modifing the parameters before execution.
        /// </summary>
        void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember);

        /// <summary>
        /// Adds code to a method just after execution of the execute method.
        /// This can be used for logging, instramenting or modifing the return value after execution.
        /// </summary>
        void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember);
    }
}