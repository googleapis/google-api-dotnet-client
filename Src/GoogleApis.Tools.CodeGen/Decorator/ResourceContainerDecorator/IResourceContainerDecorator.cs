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
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceContainerDecorator
{
    /// <summary>
    /// Decorates ResourceContainers, a resourceContainer is any object
    /// that can contain Resources, a service is a resourceContainer 
    /// also a Resource is a resource container since it can 
    /// contain Resources.
    /// </summary>
    /// <seealso cref="IResourceContainer"/>
    public interface IResourceContainerDecorator
    {
        /// <summary>
        /// Adds code to the containerClass based on the definitions contained in the resourceContainer.
        /// </summary>
        void DecorateClass(IResourceContainer service, CodeTypeDeclaration containerClass);
    }
}