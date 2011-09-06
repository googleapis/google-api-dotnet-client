/*
Copyright 2011 Google Inc

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

namespace Google.Apis.Tools.CodeGen.Decorator
{
    /// <summary>
    /// Defines a ObjectTypeProvider to be used by method and class decorators.
    /// Used to get/generate a code type reference to the ReturnType and BodyType of a method.
    /// </summary>
    public interface IObjectTypeProvider
    {
        /// <summary>
        /// Returns a reference to the return type of this method.
        /// </summary>
        CodeTypeReference GetReturnType(IMethod method);

        /// <summary>
        /// Returns  a reference to the body type of this method.
        /// </summary>
        CodeTypeReference GetBodyType(IMethod method);
    }
}
