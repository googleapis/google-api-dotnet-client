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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Generates a class for one Resource. This uses the passed in decorators to do the work.
    /// </summary>
    /// <seealso cref="IResourceDecorator"/>
    public class ResourceClassGenerator : BaseGenerator
    {
        private readonly string className;
        private readonly IEnumerable<IResourceDecorator> decorators;
        private readonly RequestClassGenerator requestClassGenerator;
        private readonly IResource resource;
        private readonly ResourceContainerGenerator resourceContainerGenerator;
        private readonly string serviceClassName;

        /// <summary>
        /// Name of the IAuthenticator field of the resource class.
        /// </summary>
        public const string AuthenticatorName = "_authenticator";

        /// <summary>
        /// Returns the generator used to generate the Resource Container.
        /// </summary>
        public ResourceContainerGenerator ContainerGenerator
        {
            get { return resourceContainerGenerator; }
        }

        /// <summary>
        /// Returns the generator used to generate all Request classes.
        /// </summary>
        public RequestClassGenerator RequestGenerator
        {
            get { return requestClassGenerator; }
        }

        public ResourceClassGenerator(IResource resource,
                                      string serviceClassName,
                                      IEnumerable<IResourceDecorator> decorators,
                                      RequestClassGenerator requestClassGenerator,
                                      ResourceContainerGenerator resourceContainerGenerator,
                                      IEnumerable<string> otherResourceNames)
        {
            this.resource = resource;
            this.serviceClassName = serviceClassName;
            this.decorators = decorators;
            className = resource.IsServiceResource
                            ? serviceClassName
                            : GeneratorUtils.GetClassName(resource, otherResourceNames);
            this.resourceContainerGenerator = resourceContainerGenerator;
            this.requestClassGenerator = requestClassGenerator;
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

            if (resource.IsServiceResource) // If this is a root resource/the service itself, a class already exists.
            {
                resourceClass.IsPartial = true;
            }

            foreach (IResourceDecorator decorator in decorators)
            {
                decorator.DecorateClass(resource, className, resourceClass, this, serviceClassName, decorators);
            }

            resourceContainerGenerator.AddResourceContainerDecorations(resource, resourceClass);
            resourceClass.Members.AddRange(requestClassGenerator.GenerateRequestClasses(resourceClass, resource));

            return resourceClass;
        }
    }
}