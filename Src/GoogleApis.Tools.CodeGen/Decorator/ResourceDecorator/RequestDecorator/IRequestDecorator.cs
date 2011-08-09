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

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Classes that implement this interface will be called when building a request within a resource class.
    /// </summary>
    public interface IRequestDecorator
    {
        /// <summary>
        /// Adds code to the class "requestClass" based on the specified "request" method.
        /// </summary>
        void DecorateClass(IResource resource,
                           IMethod request,
                           CodeTypeDeclaration requestClass,
                           CodeTypeDeclaration resourceClass);
    }
}