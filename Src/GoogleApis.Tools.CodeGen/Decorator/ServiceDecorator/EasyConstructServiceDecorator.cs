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
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Services;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds a convenience zero argument constructor to the service.
    /// Using the AuthenticatorFactory to get the IAuthenticator. 
    /// This is an optional decorator.
    /// <code>
    ///   public [..]Service() : this(new Initializer()) {}
    /// </code>
    /// </summary>
    public class EasyConstructServiceDecorator : IServiceDecorator
    {
        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(CreateEmptyConstructor());
        }

        #endregion

        /// <summary>
        /// Creates the following constructor
        ///     public XXXService() : this(new Initializer())
        /// </summary>
        [VisibleForTestOnly]
        internal CodeConstructor CreateEmptyConstructor()
        {
            var constructor = new CodeConstructor();

            constructor.Attributes = MemberAttributes.Public;
            var initializer = new CodeObjectCreateExpression(typeof(BaseClientService.Initializer));
            constructor.ChainedConstructorArgs.Add(initializer);
            return constructor;
        }
    }
}