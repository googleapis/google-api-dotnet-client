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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Generates a class for one Resource. This uses the passed in decorators to do the work.
    /// </summary>
    /// <seealso cref="IResourceDecorator"/>
    public class ResourceClassGenerator : BaseGenerator
    {
        private readonly String className;
        private readonly IEnumerable<IResourceDecorator> decorators;
        private readonly IResource resource;
        private readonly ResourceContainerGenerator resourceConainerGenerator;
        private readonly int resourceNumber;
        private readonly String serviceClassName;

        public ResourceClassGenerator(IResource resource,
                                      String serviceClassName,
                                      int resourceNumber,
                                      IEnumerable<IResourceDecorator> decorators,
                                      ResourceContainerGenerator resourceConainerGenerator,
                                      IEnumerable<string> otherResourceNames)
        {
            this.resource = resource;
            this.serviceClassName = serviceClassName;
            this.resourceNumber = resourceNumber;
            this.decorators = decorators;
            className = GeneratorUtils.GetClassName(resource, otherResourceNames);
            this.resourceConainerGenerator = resourceConainerGenerator;
        }

        /// <summary>
        /// Create the class for a given resource and add all the methods.
        /// </summary>
        /// <param name="res">
        /// A <see cref="Resource"/>
        /// </param>
        /// <returns>
        /// A <see cref="CodeTypeDeclaration"/>
        /// </returns>
        public CodeTypeDeclaration CreateClass()
        {
            var resourceClass = new CodeTypeDeclaration(className);

            foreach (IResourceDecorator decorator in decorators)
            {
                decorator.DecorateClass(resource, className, resourceClass, this, serviceClassName, decorators);
            }

            resourceConainerGenerator.AddResourceContainerDecorations(resource, resourceClass);

            return resourceClass;
        }
    }
}