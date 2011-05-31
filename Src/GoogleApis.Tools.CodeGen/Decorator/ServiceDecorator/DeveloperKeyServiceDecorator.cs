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

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Declares the DeveloperKey property and field
    /// <code>
    ///     private string developerKey;
    ///     public virtual string DeveloperKey { ... }
    /// </code>
    /// </summary>
    public class DeveloperKeyServiceDecorator : IServiceDecorator
    {
        /// <summary>
        /// Defines the name of the "DeveloperKey" property
        /// </summary>
        public const string DeveloperKeyPropertyName = "DeveloperKey";

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            DecoratorUtil.AddAutoProperty<string>(serviceClass, DeveloperKeyPropertyName,
                                                  "Sets the DeveloperKey which this service uses for all requests");
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
