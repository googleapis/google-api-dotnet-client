/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.CodeDom;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Test class for the "BaseResourceDecorator"
    /// </summary>
    public abstract class BaseResourceDecoratorTest : BaseCodeGeneratorTest
    {
        /// <summary>
        /// Creates a CodeTypeDeclaration decorated with the given IResourceDecorator.
        /// </summary>
        protected CodeTypeDeclaration CreateDecoratedResourceClass(params IResourceDecorator[] allDecorators)
        {
            var parts = ResourceClassName.Split('.');
            var shortClassName = parts[parts.Length - 1];
            var resourceClass = new CodeTypeDeclaration(shortClassName);
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);

            foreach (var decorator in allDecorators)
            {
                decorator.DecorateClass(
                    resource, ResourceClassName, resourceClass, null, ServiceClassName, allDecorators);
            }
            return resourceClass;
        }
    }
}