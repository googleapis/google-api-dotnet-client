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

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Util;
using Newtonsoft.Json.Schema;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Generator which creates names for nested classes based upon the environment they are in
    /// </summary>
    public class NestedClassNameGenerator
    {
        /// <summary>
        /// Generates a name for the nested class which resides in the specified parent type
        /// </summary>
        /// <returns>A generated name, or null if this generator is unable to generate a name</returns>
        public string GenerateName(CodeTypeDeclaration parentType, JsonSchema nestedClass)
        {
            parentType.ThrowIfNull("parentType");
            nestedClass.ThrowIfNull("parentType");

            // Check if the parent is an Array/List Schema
            foreach (CodeTypeReference baseType in parentType.BaseTypes)
            {
                if (baseType.BaseType.Equals(typeof(IList).FullName))
                {
                    // It implements IList -> yes
                    return "Item";
                }
            }

            // Check if a title is set););
            if (string.IsNullOrEmpty(nestedClass.Title) == false)
            {
                return GenerateTypeName(nestedClass.Title, parentType, parentType.Members);
            }

            return null; // No name can be generated based upon the environment
        }

        /// <summary>
        /// Generates a safe type name from the specified title
        /// </summary>
        private string GenerateTypeName(string title, CodeTypeDeclaration parent, CodeTypeMemberCollection usedMembers)
        {
            title.ThrowIfNull("title");
            usedMembers.ThrowIfNull("usedMembers");
            string newTitle = title;

            // Remove the plural-'s' (if applicable)););
            if (newTitle.Length > 3 && newTitle.EndsWith("s"))
            {
                if (newTitle.EndsWith("ies"))
                {
                    newTitle = newTitle.Substring(0, newTitle.Length - "ies".Length) + "y";
                }
                else
                {
                    newTitle = newTitle.Substring(0, newTitle.Length - 1);
                }
            }

            // Create list of used words
            var usedWords = new List<string>(usedMembers.Count);

            foreach (CodeTypeMember member in usedMembers)
            {
                usedWords.Add(member.Name);
            }
            usedWords.Add(title); // Will most likely be used by the property using this class

            // Create a nice type name
            newTitle = GeneratorUtils.GetClassName(newTitle, usedWords);

            // Modifiy it, if the name interferes with the property name
            string propertyName = GeneratorUtils.GetPropertyName(title, 0, usedWords);
            if (newTitle.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase))
            {
                newTitle = parent.Name + newTitle;
            }

            return newTitle;
        }
    }
}