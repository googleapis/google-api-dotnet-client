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

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using Google.Apis.Testing;


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
                    if (DecoratorUtil.FindFittingEnumeration(
                            resourceClass, parameter.EnumValues, parameter.EnumValueDescriptions) != null)
                    {
                        continue;
                    }

                    // Create and add the enumeration.
                    resourceClass.Members.Add(GenerateEnum(
                            resourceClass, parameter.Name, parameter.Description, parameter.EnumValues,
                            parameter.EnumValueDescriptions));
                }
            }
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

        #endregion

        /// <summary>
        /// Creates an enumeration from the provided data.
        /// </summary>
        /// <param name="typeDeclaration">The type which should contain this enumeration.</param>
        /// <param name="proposedName">The proposed name for this enumeration.</param>
        /// <param name="description">Description of the enum class.</param>
        /// <param name="entries">Enum entries in the form (name, comment/description).</param>
        /// <returns>The generated enum type.</returns>
        [VisibleForTestOnly]
        internal static CodeTypeDeclaration GenerateEnum(CodeTypeDeclaration typeDeclaration,
                                                       string proposedName,
                                                       string description,
                                                       IEnumerable<KeyValuePair<string, string>> entries)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            proposedName.ThrowIfNullOrEmpty("proposedName");
            entries.ThrowIfNull("entries");

            // Create a safe enum name by avoiding the names of all members which are already in this type.
            IEnumerable<string> memberNames = from CodeTypeMember m in typeDeclaration.Members select m.Name;
            string name = GeneratorUtils.GetEnumName(proposedName, memberNames);

            // Create the enum type.
            var decl = new CodeTypeDeclaration(name);
            decl.IsEnum = true;

            // Get the EnumStringValueTypeConverter type.
            Type converterType = typeof(EnumStringValueTypeConverter);

            // [TypeConverter(..)]
            var typeConvAttribute = new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(TypeConverterAttribute)));

            // .. typeof(EnumStringValueTypeConverter) ..
            typeConvAttribute.Arguments.Add(new CodeAttributeArgument(new CodeTypeOfExpression(converterType)));
            decl.CustomAttributes.Add(typeConvAttribute);

            foreach (KeyValuePair<string, string> enumEntry in entries)
            {
                // Consider the names of all members in the current type as used words.
                IEnumerable<string> usedNames = from CodeTypeMember m in decl.Members select m.Name;
                string safeName = GeneratorUtils.GetEnumValueName(enumEntry.Key, usedNames);
                var member = new CodeMemberField(typeof(int), safeName);

                // Attribute:
                var valueAttribute = new CodeAttributeDeclaration();
                valueAttribute.Name = typeof(StringValueAttribute).FullName;
                valueAttribute.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(enumEntry.Key)));
                member.CustomAttributes.Add(valueAttribute);

                // Comments:
                member.Comments.AddRange(DecoratorUtil.CreateSummaryComment(enumEntry.Value));

                // Add member to enum.
                decl.Members.Add(member);
            }

            // Class comment:
            decl.Comments.AddRange(DecoratorUtil.CreateSummaryComment(description));

            return decl;
        }

        /// <summary>
        /// Creates an enumeration from the provided data.
        /// </summary>
        /// <param name="typeDeclaration">The type which should contain this enumeration.</param>
        /// <param name="proposedName">The proposed name of the enumeration.</param>
        /// <param name="description">Description of the enum class.</param>
        /// <param name="enumValues">All enumeration values.</param>
        /// <param name="enumDescriptions">All enumeration comments.</param>
        /// <returns>Generated enum type.</returns>
        [VisibleForTestOnly]
        internal static CodeTypeDeclaration GenerateEnum(CodeTypeDeclaration typeDeclaration,
                                                       string proposedName,
                                                       string description,
                                                       IEnumerable<string> enumValues,
                                                       IEnumerable<string> enumDescriptions)
        {
            // Add the comments to the values if possible, or create empty ones.
            IEnumerable<KeyValuePair<string, string>> enumEntries = DecoratorUtil.GetEnumerablePairs(
                enumValues, enumDescriptions);
            return GenerateEnum(typeDeclaration, proposedName, description, enumEntries);
        }
    }
}