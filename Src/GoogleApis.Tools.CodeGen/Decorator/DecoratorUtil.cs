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
using System.ComponentModel;
using System.Linq;
using System.Security;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator
{
    /// <summary>
    /// Helper class for all decorators.
    /// </summary>
    internal static class DecoratorUtil
    {
        /// <summary>
        /// Creates and adds a public auto-property (property and backening field) to the class.
        /// </summary>
        /// <typeparam name="TProperty">Type used for the propery.</typeparam>
        public static CodeTypeMemberCollection CreateAutoProperty<TProperty>(CodeTypeDeclaration serviceClass,
                                                                    string name,
                                                                    string summaryComment)
        {
            // Validate parameters.
            serviceClass.ThrowIfNull("serviceClass");
            name.ThrowIfNullOrEmpty("name");

            // Check if the name has already been used.
            if (serviceClass.Members.FindPropertyByName(name) != null)
            {
                throw new ArgumentException(
                    string.Format("The property name [{0}] was already used within this class", name), "name");
            }

            // Create backening field.
            var field = CreateBackingField<TProperty>(serviceClass, name);
            string fieldName = field.Name;
            var fieldNameRef = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);

            // Add property.
            var property = new CodeMemberProperty();
            property.Name = name;
            property.Attributes = MemberAttributes.Public;

            if (summaryComment.IsNotNullOrEmpty())
            {
                property.Comments.Add(new CodeCommentStatement("<summary>" + summaryComment + "</summary>", true));
            }
            property.Type = new CodeTypeReference(typeof(TProperty));
            property.HasGet = true;
            property.HasSet = true;

            // Add getter and setter.
            property.GetStatements.Add(new CodeMethodReturnStatement(fieldNameRef));

            property.SetStatements.Add(
                new CodeAssignStatement(fieldNameRef, new CodePropertySetValueReferenceExpression()));

            // Return the result.
            var col = new CodeTypeMemberCollection();
            col.Add(field);
            col.Add(property);
            return col;
        }

        /// <summary>
        /// Creates a backening field for the name provided.
        /// </summary>
        /// <typeparam name="TProperty">Type used for the propery.</typeparam>
        /// <param name="name">The name of the property.</param>
        /// <returns></returns>
        public static CodeMemberField CreateBackingField<TProperty>(CodeTypeDeclaration serviceClass, string name)
        {
            // Validate parameters.
            serviceClass.ThrowIfNull("serviceClass");
            name.ThrowIfNullOrEmpty("name");

            // Generate field name.
            var fieldName = Char.IsLower(name[0]) ? "_" + name : GeneratorUtils.LowerFirstLetter(name);

            // Check if it was already used.
            if (serviceClass.Members.FindFieldByName(fieldName) != null)
            {
                throw new ArgumentException(
                    string.Format("The property name [{0}] was already used within this class", name), "name");
            }

            // Create the field.
            var field = new CodeMemberField(typeof(TProperty), fieldName);
            field.Attributes = MemberAttributes.Private;
            return field;
        }

        /// <summary>
        /// Creates a summary comment containing the text specified.
        /// Returns an empty collection if the summary string is null or empty.
        /// </summary>
        public static CodeCommentStatementCollection CreateSummaryComment(string summary)
        {
            var comments = new CodeCommentStatementCollection();
            if (summary.IsNotNullOrEmpty())
            {
                var text = "<summary>" + XmlEscapeComment(summary) + "</summary>";
                comments.Add(new CodeCommentStatement(new CodeComment(text, true)));
            }
            return comments;
        }

        /// <summary>
        /// Escapes a string for use in a XML comment.
        /// </summary>
        public static string XmlEscapeComment(string description)
        {
            return SecurityElement.Escape(description);
        }

        /// <summary>
        /// Creates an enumeration from the provided data.
        /// </summary>
        /// <param name="typeDeclaration">The type which should contain this enumeration.</param>
        /// <param name="proposedName">The proposed name for this enumeration.</param>
        /// <param name="description">Description of the enum class.</param>
        /// <param name="entries">Enum entries in the form (name, comment/description).</param>
        /// <returns>The generated enum type.</returns>
        public static CodeTypeDeclaration GenerateEnum(CodeTypeDeclaration typeDeclaration,
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
                member.Comments.AddRange(CreateSummaryComment(enumEntry.Value));

                // Add member to enum.
                decl.Members.Add(member);
            }

            // Class comment:
            decl.Comments.AddRange(CreateSummaryComment(description));

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
        public static CodeTypeDeclaration GenerateEnum(CodeTypeDeclaration typeDeclaration,
                                                       string proposedName,
                                                       string description,
                                                       IEnumerable<string> enumValues,
                                                       IEnumerable<string> enumDescriptions)
        {
            // Add the comments to the values if possible, or create empty ones.
            IEnumerable<KeyValuePair<string, string>> enumEntries = enumDescriptions.IsNullOrEmpty()
                              ? enumValues.Select((str) => new KeyValuePair<string, string>(str, null))
                              : GetEnumerablePairs(enumValues, enumDescriptions);
            return GenerateEnum(typeDeclaration, proposedName, description, enumEntries);
        }
    
        /// <summary>
        /// Returns a collection of joined keys and values as KeyValuePairs
        /// </summary>
        [VisibleForTestOnly]
        internal static IEnumerable<KeyValuePair<K, V>> GetEnumerablePairs<K, V>(IEnumerable<K> keys,
                                                                                 IEnumerable<V> values)
        {
            keys.ThrowIfNull("keys");
            values.ThrowIfNull("values");

            if (keys.Count() != values.Count())
            {
                throw new ArgumentException("Both enumerables must be of the the same length.");
            }

            IEnumerator<K> keysEnumerator = keys.GetEnumerator();
            IEnumerator<V> valuesEnumerator = values.GetEnumerator();

            // Return both enumerables as KeyValuePairs
            while (keysEnumerator.MoveNext() && valuesEnumerator.MoveNext())
            {
                yield return new KeyValuePair<K, V>(keysEnumerator.Current, valuesEnumerator.Current);
            }
        }

        /// <summary>
        /// Adds the specified members to the given class.
        /// Skips elements which already have been added.
        /// </summary>
        public static void AddMembersToClass(CodeTypeDeclaration classDeclaration,
                                             CodeTypeMemberCollection membersToAdd)
        {
            classDeclaration.ThrowIfNull("classDecl");
            membersToAdd.ThrowIfNull("membersToAdd");

            // Create a list of all used names within the current scope.
            IEnumerable<string> query = from CodeTypeMember m in classDeclaration.Members select m.Name;
            List<string> usedNames = new List<string>(query);

            // Create methods.
            foreach (CodeTypeMember member in membersToAdd)
            {
                if (!usedNames.Contains(member.Name))
                {
                    // If this member has not yet been added, add the new type.
                    // Due to method overloads (AsStream, AsObject) it might have been added already.
                    usedNames.Add(member.Name);
                    classDeclaration.Members.Add(member);
                }
            }
        }

        /// <summary>
        /// Returns the enumeration which has the same keys declared, or null if no match was found.
        /// </summary>
        public static CodeTypeReference FindFittingEnumeration(CodeTypeDeclaration declaration,
                                                               IEnumerable<string> keys)
        {
            declaration.ThrowIfNull("declaration");
            keys.ThrowIfNull("keys");

            // Iterate through all members and look for an enum definition.
            foreach (CodeTypeMember typeMember in declaration.Members)
            {
                CodeTypeDeclaration decl = typeMember as CodeTypeDeclaration;
                if (decl == null || !IsFittingEnum(decl, keys))
                {
                    continue;
                }

                // Every check has passed. This enum is compatible with the type we are looking for.
                return new CodeTypeReference(typeMember.Name);
            }

            // No matching enumeration was found. Return null.
            return null;
        }

        /// <summary>
        /// Determines whether the given enum has the same keys as specified.
        /// </summary>
        [VisibleForTestOnly]
        internal static bool IsFittingEnum(CodeTypeDeclaration enumType, IEnumerable<string> keys)
        {
            if (enumType == null || !enumType.IsEnum)
            {
                return false;
            }

            // Check that this enumeration defines all keys.
            int count = 0;
            foreach (CodeTypeMember field in enumType.Members)
            {
                // Retrieve the StringValue attribute.
                CodeAttributeDeclaration decl = (from CodeAttributeDeclaration d in field.CustomAttributes
                                                 where d.Name == typeof(StringValueAttribute).FullName
                                                 select d).Single();


                string enumFieldValue = ((CodePrimitiveExpression)decl.Arguments[0].Value).Value.ToString();
                if (!keys.Contains(enumFieldValue))
                {
                    // Field is not present in the list of declared keys
                    return false;
                }

                count++;
            }

            if (count != keys.Count())
            {
                return false; // The amount of declared field differs -> not the same enum.
            }

            // Every check has passed. This enum is compatible with what we are looking for.
            return true;
        }
    }
}