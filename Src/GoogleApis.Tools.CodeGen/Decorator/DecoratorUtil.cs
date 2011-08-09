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
        public static CodeTypeMemberCollection CreateAutoProperty(string name,
                                                                  string summaryComment,
                                                                  CodeTypeReference propertyType,
                                                                  IEnumerable<string> usedNames,
                                                                  bool readOnly)
        {
            // Validate parameters.
            name.ThrowIfNullOrEmpty("name");
            propertyType.ThrowIfNull("propertyType");
            usedNames.ThrowIfNull("usedNames");

            // Generate the property name.
            string propertyName = GeneratorUtils.GetPropertyName(name, usedNames);

            // Create backening field.
            var field = CreateBackingField(name, propertyType, usedNames.Concat(propertyName));
            string fieldName = field.Name;
            var fieldNameRef = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName);

            // Add property.
            var property = new CodeMemberProperty();
            property.Name = propertyName;
            property.Attributes = MemberAttributes.Public;

            if (summaryComment.IsNotNullOrEmpty())
            {
                property.Comments.Add(new CodeCommentStatement("<summary>" + summaryComment + "</summary>", true));
            }
            property.Type = propertyType;
            property.HasGet = true;
            property.HasSet = !readOnly;

            // Add getter and setter.
            property.GetStatements.Add(new CodeMethodReturnStatement(fieldNameRef));
            if (property.HasSet)
            {
                property.SetStatements.Add(
                    new CodeAssignStatement(fieldNameRef, new CodePropertySetValueReferenceExpression()));
            }

            // Return the result.
            var col = new CodeTypeMemberCollection();
            col.Add(field);
            col.Add(property);
            return col;
        }

        /// <summary>
        /// Creates a backening field for the name provided.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        public static CodeMemberField CreateBackingField(string name,
                                                         CodeTypeReference fieldType,
                                                         IEnumerable<string> usedWords)
        {
            // Validate parameters.
            name.ThrowIfNullOrEmpty("name");
            fieldType.ThrowIfNull("fieldType");
            usedWords.ThrowIfNull("usedWords");

            // Generate field name.
            var fieldName = GeneratorUtils.GetFieldName(name, usedWords);

            // Create the field.
            var field = new CodeMemberField(fieldType, fieldName);
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
        /// Returns a collection of joined keys and values as KeyValuePairs.
        /// Will return the default value of V for pair.Value if values is null.
        /// </summary>
        /// <throws>Will throw an ArgumentException if the enumerables are of different length.</throws>
        [VisibleForTestOnly]
        internal static IEnumerable<KeyValuePair<K, V>> GetEnumerablePairs<K, V>(IEnumerable<K> keys,
                                                                                 IEnumerable<V> values)
        {
            keys.ThrowIfNull("keys");

            if (values == null)
            {
                foreach (K key in keys)
                {
                    yield return new KeyValuePair<K, V>(key, default(V));
                }
                yield break;
            }

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
        /// Returns the enumeration which has the same keys declared, or null if no match was found.
        /// </summary>
        public static CodeTypeReference FindFittingEnumeration(CodeTypeDeclaration declaration,
                                                               IEnumerable<string> keys,
                                                               IEnumerable<string> comments)
        {
            declaration.ThrowIfNull("declaration");
            keys.ThrowIfNull("keys");

            // Iterate through all members and look for an enum definition.
            foreach (CodeTypeMember typeMember in declaration.Members)
            {
                CodeTypeDeclaration decl = typeMember as CodeTypeDeclaration;
                if (decl == null || !IsFittingEnum(decl, keys, comments))
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
        /// Determines whether the given enum has the same pairs as specified.
        /// </summary>
        /// <returns></returns>
        [VisibleForTestOnly]
        internal static bool IsFittingEnum(CodeTypeDeclaration enumType,
                                           IEnumerable<string> values,
                                           IEnumerable<string> comments)
        {
            return IsFittingEnum(enumType, GetEnumerablePairs(values, comments));
        }

        /// <summary>
        /// Determines whether the given enum has the same pairs as specified.
        /// </summary>
        [VisibleForTestOnly]
        internal static bool IsFittingEnum(CodeTypeDeclaration enumType,
                                           IEnumerable<KeyValuePair<string, string>> enumPairs)
        {
            if (enumType == null || !enumType.IsEnum)
            {
                return false;
            }

            // Check that this enumeration defines all keys.
            int count = 0;
            var enumPairDictionary = enumPairs.ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (CodeTypeMember field in enumType.Members)
            {
                // Retrieve the StringValue attribute.
                CodeAttributeDeclaration decl = (from CodeAttributeDeclaration d in field.CustomAttributes
                                                 where d.Name == typeof(StringValueAttribute).FullName
                                                 select d).Single();


                string enumFieldValue = ((CodePrimitiveExpression) decl.Arguments[0].Value).Value.ToString();

                if (!enumPairDictionary.ContainsKey(enumFieldValue))
                {
                    // Field is not present in the list of declared keys.
                    return false;
                }

                // Get the key value pair representing this enum value.
                string comment = enumPairDictionary[enumFieldValue];

                // Confirm that the comments are identical.
                CodeCommentStatementCollection colA = field.Comments;
                CodeCommentStatementCollection colB = CreateSummaryComment(comment);
                if (colA.Count != colB.Count || (colA.Count > 0 && colA[0].Comment.Text != colB[0].Comment.Text))
                {
                    return false; // Comment is different.
                }

                count++;
            }

            if (count != enumPairDictionary.Count())
            {
                return false; // The amount of declared field differs -> not the same enum.
            }

            // Every check has passed. This enum is compatible with what we are looking for.
            return true;
        }
    }
}