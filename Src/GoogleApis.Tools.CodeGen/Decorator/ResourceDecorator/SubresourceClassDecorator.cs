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
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// This decorator adds subresources as nested classes to the current resource.
    /// 
    /// Example:
    ///   public class TopResource {
    ///      ...
    ///      public class SubResource {
    ///         ...
    ///      }
    ///   }
    /// </summary>
    public class SubresourceClassDecorator : IResourceDecorator
    {
        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            resource.ThrowIfNull("resource");
            className.ThrowIfNull("className");
            resourceClass.ThrowIfNull("resourceClass");
            generator.ThrowIfNull("generator");
            serviceClassName.ThrowIfNull("serviceClassName");
            allDecorators.ThrowIfNull("allDecorators");

            if (!resource.IsServiceResource) // Only add subresources of normal resources, not the root resource.
            {
                // Add all subresources.
                foreach (IResource subresource in resource.Resources.Values)
                {
                    // Consider all members in the current class as invalid names.
                    var forbiddenWords = from CodeTypeMember m in resourceClass.Members select m.Name;

                    // Generate and add the subresource.
                    CodeTypeDeclaration decl = GenerateSubresource(
                        subresource, serviceClassName, allDecorators, generator.RequestGenerator,
                        generator.ContainerGenerator, forbiddenWords);
                    resourceClass.Members.Add(decl);
                }
            }
        }
        
        [VisibleForTestOnly]
        internal CodeTypeDeclaration GenerateSubresource(IResource subresource,
                                     string serviceClassName,
                                     IEnumerable<IResourceDecorator> allDecorators,
                                     RequestClassGenerator requestClassGenerator,
                                     ResourceContainerGenerator containerGenerator,
                                     IEnumerable<string> forbiddenWords)
        {
            // Create a new generator for this subresource
            var subgenerator = new ResourceClassGenerator(
                subresource, serviceClassName, allDecorators, requestClassGenerator, containerGenerator,
                forbiddenWords);

            // Generate and add the subresource.
            return subgenerator.CreateClass();
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        #endregion
    }
}