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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Represents a generator for request classes. The generated class represents a request made to an service, 
    /// containing all the request parameters and defining the response type.
    /// </summary>
    public class RequestClassGenerator : BaseGenerator
    {
        /// <summary>
        /// Defines the naming scheme for request classes.
        /// </summary>
        /// <remarks>{0} represents the name of the method for which this request is intended.</remarks>
        public const string RequestClassNamingScheme = "{0}Request";

        private readonly IEnumerable<IRequestDecorator> requestDecorators;

        /// <summary>
        /// Constructs a new instance of the request class generator, and uses the specified decorator list
        /// to decorate the generated request classes.
        /// </summary>
        public RequestClassGenerator(IEnumerable<IRequestDecorator> requestDecorators)
        {
            this.requestDecorators = requestDecorators;
        }

        /// <summary>
        /// Generates the Request-classes for all methods in a resource.
        /// </summary>
        public CodeTypeMemberCollection GenerateRequestClasses(CodeTypeDeclaration resourceClass, IResource resource)
        {
            CodeTypeMemberCollection newMembers = new CodeTypeMemberCollection();
            IList<string> usedNames = new List<string>(GeneratorUtils.GetUsedWordsFromMembers(resourceClass.Members));
            foreach (IMethod method in resource.Methods.Values)
            {
                // Generate the request class and add it to the result collection.
                CodeTypeDeclaration requestClass = GenerateRequestClass(resource, method, resourceClass, usedNames);
                newMembers.Add(requestClass);
                usedNames.Add(requestClass.Name);
            }

            return newMembers;
        }

        /// <summary>
        /// Generates a request class for the specified method
        /// </summary>
        [VisibleForTestOnly]
        internal CodeTypeDeclaration GenerateRequestClass(IResource resource,
                                                          IMethod method,
                                                          CodeTypeDeclaration resourceClass,
                                                          IEnumerable<string> usedNames)
        {
            // Generate a request class for this method
            CodeTypeDeclaration requestClass = new CodeTypeDeclaration();
            string proposedName = GetProposedName(method);
            requestClass.Name = GeneratorUtils.GetClassName(proposedName, usedNames);

            // Run the decorators for request classes.
            foreach (IRequestDecorator decorator in requestDecorators)
            {
                decorator.DecorateClass(resource, method, requestClass, resourceClass);
            }

            return requestClass;
        }

        /// <summary>
        /// Returns the proposed name for a request class for the specified method.
        /// Does not check for used names.
        /// </summary>
        public static string GetProposedName(IMethod method)
        {
            return GeneratorUtils.GetClassName(string.Format(RequestClassNamingScheme, method.Name), new string[0]);
        }
    }
}