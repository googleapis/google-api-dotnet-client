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
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// A decorator which adds enumerations for enumerable method parameters to a resource.
    /// </summary>
    public class EnumResourceDecorator : IResourceDecorator
    {
        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            foreach (IMethod method in resource.Methods.Values)
            {
                foreach (IParameter parameter in method.Parameters.Values)
                {
                    if (parameter.EnumValues.IsNullOrEmpty())
                    {
                        continue; // Not an enumeration type.
                    }

                    // Check whether the type already exists.
                    if (DecoratorUtil.FindFittingEnumeration(resourceClass, parameter.EnumValues) != null)
                    {
                        continue;
                    }

                    // Create and add the enumeration.
                    resourceClass.Members.Add(
                        DecoratorUtil.GenerateEnum(
                            resourceClass, parameter.Name, parameter.Description, parameter.EnumValues,
                            parameter.EnumValueDescriptions));
                }
            }
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        #endregion
    }
}