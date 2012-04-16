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
using System.Text;
using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen
{
    /// <summary>
    /// A collection of static utility methods for generators and decorators to use. 
    /// </summary>
    public static class GeneratorUtils
    {
        #region unsafe words

        //C# reserved words
        private static readonly string[] UnsafeWordsArray = new[]
                                                            {
                                                                "abstract", "as", "base", "bool", "break", "byte",
                                                                "case", "catch", "char", "checked", "class", "const", 
                                                                "continue", "decimal", "default", "delegate", "do", 
                                                                "double", "else", "enum", "event", "explicit",
                                                                "extern", "false", "finally", "fixed", "float",
                                                                "for", "foreach", "goto", "if", "implicit", "in",
                                                                "int", "interface", "internal", "is", "lock", "long", 
                                                                "namespace", "new", "null", "object", "operator",
                                                                "out", "override", "params", "private", "protected",
                                                                "public", "readonly", "ref", "return", "sbyte",
                                                                "sealed", "short", "sizeof", "stackalloc", "static",
                                                                "string", "struct", "switch", "this", "throw",
                                                                "true", "try", "typeof", "uint", "ulong",
                                                                "unchecked", "unsafe", "ushort", "using", "virtual",
                                                                "void", "volatile", "while",
                                                                //C# proposed reserved words
                                                                "await", "async", 
                                                                //CodeGen Specific
                                                                "body"
                                                            };

        /// <summary>
        /// List of all words which are unsafe in a code environment
        /// </summary>
        public static readonly IList<string> UnsafeWords = new List<string>(UnsafeWordsArray).AsReadOnly();

        #endregion

        #region Lower/UpperFirst

        /// <summary>
        /// Returns the given input string with a lower first letter
        /// </summary>
        public static string LowerFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            if (str.Length == 1)
            {
                return Char.ToLower(str[0]).ToString();
            }

            return Char.ToLower(str[0]) + str.Substring(1);
        }

        /// <summary>
        /// Returns the specified input string with a upper first letter
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UpperFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            if (str.Length == 1)
            {
                return Char.ToUpper(str[0]).ToString();
            }

            return Char.ToUpper(str[0]) + str.Substring(1);
        }

        #endregion

        #region IsValid[First|BodyChar]

        /// <summary>
        /// Checks if the char is a valid first char for a field/variable name.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidFirstChar(char c)
        {
            // [A-Za-z] or _
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '_');
        }

        /// <summary>
        /// Checks if this char is allowed within field/variable names.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidBodyChar(char c)
        {
            // [A-Za-z0-9] or _
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || (c == '_');
        }

        #endregion

        #region Safe  Names

        /// <summary>
        /// The maximum index used for method generation when the proposed name is already used.
        /// </summary>
        internal const int SafeMemberMaximumIndex = 8;

        /// <summary>
        /// Suffix for all resource containers
        /// </summary>
        internal const string ResourceContainerSuffix = "Resource";

        /// <summary>
        /// Defines a change operation which should be applied to a letter.
        /// </summary>
        public enum TargetCase
        {
            /// <summary>
            /// Don't change the casing
            /// </summary>
            DontChange = 0,

            /// <summary>
            /// Change the casing to upper
            /// </summary>
            ToUpper = 1,

            /// <summary>
            /// Change the casing to lower
            /// </summary>
            ToLower = 2,
        }

        /// <summary>
        /// Creates a safe member name which can be used within code environments.
        /// Also checks for disallowed C# keywords words.
        /// </summary>
        public static string GetSafeMemberName(IEnumerable<string> unsafeWords,
                                               TargetCase firstCharCase,
                                               string baseName,
                                               params string[] alternativeNames)
        {
            unsafeWords.ThrowIfNull("unsafeWords");
            baseName.ThrowIfNullOrEmpty("baseName");
            alternativeNames.ThrowIfNull("alternativeNames");

            // Watch for both C# language keywords and member names used in this scope.
            IEnumerable<string> illegalWords = UnsafeWords.Concat(unsafeWords);

            // Check whether the base name, or one of the proposed alternative names can be used.
            foreach (string proposedName in GenerateAlternativeNamesFor(baseName, alternativeNames))
            {
                // Validate/try making valid name out of the name
                string validName = MakeValidMemberName(proposedName);
                string casedValidName = AlterFirstCharCase(validName, firstCharCase);
                
                if (IsNameValidInContext(casedValidName, illegalWords))
                {
                    // We have a valid name - return the result.
                    return casedValidName;
                }
            }

            // We are out of meaningful naming options: Throw an exception.
            throw new ArgumentException(
                string.Format(
                    "Unable to generate safe member name: Out of meaningful names for member '{0}'", baseName));
        }

        /// <summary>
        /// Generates a set of alternative names (including the baseName itself) for the specified base name.
        /// 
        /// Naming schemes used:
        ///     1. baseName
        ///     2. proposed alternatives
        ///     3. baseName + "Member"
        ///     4. baseName + Index
        ///     5. baseName + "Member" + Index
        /// </summary>
        [VisibleForTestOnly]
        internal static IEnumerable<string> GenerateAlternativeNamesFor(string baseName,
                                                                       params string[] proposedAlternatives)
        {
            // First try the real name.
            yield return baseName;

            // Try the proposed alternative names next.
            foreach (string alternative in proposedAlternatives)
            {
                yield return alternative;
            }

            // Continue by appending "Member".
            yield return baseName + "Member";

            // If that did not work, append an index to the basename.
            foreach (string indexedName in  AppendIndices(baseName, 2, SafeMemberMaximumIndex))
            {
                yield return indexedName;
            }

            // As a last resort apply "Member" and an index.
            foreach (string indexedMemberName in AppendIndices(baseName + "Member", 2, SafeMemberMaximumIndex))
            {
                yield return indexedMemberName;
            }
        }

        /// <summary>
        /// Returns a set of strings which represents the baseName plus a number appended to it.
        /// Will return an empty set if the provided base name is empty or null.
        /// </summary>
        [VisibleForTestOnly]
        internal static IEnumerable<string> AppendIndices(string baseName, int startIndex, int maximumIndex)
        {
            if (maximumIndex < startIndex)
            {
                throw new ArgumentException("startIndex must be smaller than maximumIndex");
            }

            // If no base name is provided, do not produce any altered names.
            if (string.IsNullOrEmpty(baseName))
            {
                yield break;
            }

            for (int i = startIndex; i <= maximumIndex; i++)
            {
                yield return baseName + i;
            }
        }

        /// <summary>
        /// Removes invalid characters from the proposed member name, and makes the following char
        /// upper case if the previous body char was an invalid char (e.g. foo-bar will result in fooBar).
        /// May return null if the name consisted only out of invalid characters.
        /// </summary>
        [VisibleForTestOnly]
        internal static string MakeValidMemberName(string memberName)
        {
            // We cannot generate a valid name out of an empty string.
            if (string.IsNullOrEmpty(memberName))
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            bool nextCharToUpper = false;

            foreach (char c in memberName)
            {
                // Skip invalid first characters
                if (isFirst)
                {
                    if (IsValidFirstChar(c) == false)
                    {
                        continue;
                    }

                    sb.Append(c);
                    isFirst = false;
                    continue;
                }

                // If this char is invalid, the next one should be made upper case.
                if (IsValidBodyChar(c) == false)
                {
                    nextCharToUpper = true;
                    continue;
                }

                // Make the next char upper case.
                if (nextCharToUpper)
                {
                    sb.Append(Char.ToUpper(c));
                    nextCharToUpper = false;
                    continue;
                }

                // This char is valid - Append this char without changing anything.
                sb.Append(c);   
            }

            return sb.Length == 0 ? null : sb.ToString();
        }

        /// <summary>
        /// Changes the case of the first character.
        /// </summary>
        [VisibleForTestOnly]
        internal static string AlterFirstCharCase(string memberName, TargetCase firstCharCase)
        {
            if (string.IsNullOrEmpty(memberName))
            {
                return memberName;
            }

            char c = memberName[0];
            char newChar;

            switch (firstCharCase)
            {
                case TargetCase.ToUpper:
                    newChar = Char.ToUpper(c);
                    break;

                case TargetCase.ToLower:
                    newChar = Char.ToLower(c);
                    break;

                case TargetCase.DontChange:
                    return memberName;

                default:
                    throw new ArgumentOutOfRangeException("firstCharCase");
            }

            return newChar + memberName.Substring(1);
        }
        
        /// <summary>
        /// Returns the list of used words based upon a member collection
        /// </summary>
        public static IEnumerable<string> GetUsedWordsFromMembers(CodeTypeMemberCollection collection)
        {
            return from CodeTypeMember member in collection select member.Name;
        }

        /// <summary>
        /// Checks if the proposed name has already been used in the provided context
        /// </summary>
        [VisibleForTestOnly]
        internal static bool IsNameValidInContext(string name, IEnumerable<string> context)
        {
            // An empty name is never valid.
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            // Check if the name can be used safely.
            if (context.Contains(name))
            {
                // This name is already taken.
                return false;
            }

            return true;
        }

        /// <summary>
        /// From the Parameter and its placement constructs a safe name.
        /// </summary>
        /// <param name="parameter">
        ///     The Parameter.
        /// </param>
        /// <param name="otherParameterNames">Enumerable of all parameter names used within the same method.</param>
        public static string GetParameterName(IParameter parameter, IEnumerable<string> otherParameterNames)
        {
            string name = parameter.Name;
            return GetSafeMemberName(otherParameterNames, TargetCase.ToLower, name, name + "Value", name + "Param");
        }

        /// <summary>
        /// Returns a safe and appropriate method name for the specified method.
        /// </summary>
        public static string GetMethodName(IMethod method, IEnumerable<string> wordsUsedInContext)
        {
            string name = method.Name;
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Method", name + "Call");
        }

        /// <summary>
        /// Returns a safe and appropriate enumeration name for the specified enumeration.
        /// </summary>
        public static string GetEnumName(string enumName, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, enumName, enumName + "Enum");
        }

        /// <summary>
        /// Returns a safe and appropriate name for an enumeration value.
        /// </summary>
        public static string GetEnumValueName(string enumValue, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(
               wordsUsedInContext, TargetCase.ToUpper, enumValue, enumValue + "Value");
        }

        /// <summary>
        /// Return a safe name for a namespace.
        /// </summary>
        /// <param name="basename">The target (potentially unsafe) name.</param>
        /// <returns>A safe namepsace name.</returns>
        public static string GetNamespaceName(string basename)
        {
            if (String.IsNullOrEmpty(basename))
            {
                return null;
            }

            StringBuilder safeName = new StringBuilder();

            if (!IsValidFirstChar(basename[0]))
            {
                safeName.Append("_");
            }

            return safeName
                .Append(basename.Select(c => IsValidBodyChar(c)?c:'_').ToArray())
                .ToString();
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the specified resource container.
        /// </summary>
        public static string GetClassName(IResourceContainer resource, IEnumerable<string> wordsUsedInContext)
        {
            string name = resource.Name;

            if ((resource is IService) == false)
            {
                // Add a suffix to all resource containers (except the main service)
                name += ResourceContainerSuffix;
            }

            return GetSafeMemberName(
                wordsUsedInContext, TargetCase.ToUpper, name, resource.Name + "Res", name + "Object");
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the specified resoure.
        /// </summary>
        public static string GetFieldName(IResource resource, IEnumerable<string> wordsUsedInContext)
        {
            return GetFieldName(resource.Name, wordsUsedInContext);
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the given input name.
        /// </summary>
        public static string GetFieldName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(
                wordsUsedInContext, TargetCase.ToLower, "_" + name, name, name + "Value", name + "Field");
        }

        /// <summary>
        /// Returns a safe and appropriate property name for the given input name without using the words
        /// specified in the illegal words list.
        /// </summary>
        /// <remarks>Will rename "etag" to "ETag".</remarks>
        public static string GetPropertyName(string name, IEnumerable<string> wordsUsedInContext)
        {
            // Rename some properties to look nicer/to be properly capitalized.
            if (name == "etag")
            {
                name = "ETag";
            }

            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Value", name + "Property");
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the given schema.
        /// </summary>
        public static string GetClassName(ISchema schema, IEnumerable<string> wordsUsedInContext)
        {
            return GetClassName(schema.Name, wordsUsedInContext);
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the given schema
        /// </summary>
        public static string GetClassName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(
                wordsUsedInContext, TargetCase.ToUpper, name, name + "Schema", name + "Class", name + "Data");
        }

        /// <summary>
        /// Returns the reference to a specific schema.
        /// </summary>
        public static CodeTypeReference GetSchemaReference(string schemaNamespace, string responseType)
        {
            schemaNamespace.ThrowIfNullOrEmpty("schemaNamespace");
            responseType.ThrowIfNullOrEmpty("responseType");
            return new CodeTypeReference(schemaNamespace + "." + responseType);
        }

        /// <summary>
        /// Returns a list of used and therefore forbidden words from a type declaration.
        /// </summary>
        public static IEnumerable<string> GetWordContextListFromClass(CodeTypeDeclaration typeDeclaration)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");

            yield return typeDeclaration.Name;

            foreach (CodeTypeMember member in typeDeclaration.Members)
            {
                yield return member.Name;
            }
        }

        /// <summary>
        /// Comparer which ignores the case of a string.
        /// </summary>
        internal class CaseInsensitiveStringComparer : IEqualityComparer<string>
        {
            private static readonly CaseInsensitiveStringComparer instance = new CaseInsensitiveStringComparer();

            public static IEqualityComparer<string> Instance
            {
                get { return instance; }
            }

            #region IEqualityComparer<string> Members

            public bool Equals(string x, string y)
            {
                return string.Compare(x, y, true) == 0;
            }

            public int GetHashCode(string obj)
            {
                return obj.GetHashCode();
            }

            #endregion
        }

        #endregion
        
        /// <summary>
        /// Returns the first <see cref="System.CodeDom.CodeMemberProperty"/> with a 
        /// name that matches the passed in name - or null if no match is found.
        /// </summary>
        /// <param name="coll">May not be null</param>
        /// <param name="name">May not be null or empty</param>
        public static CodeMemberField FindFieldByName(this CodeTypeMemberCollection coll, string name)
        {
            coll.ThrowIfNull("coll");
            name.ThrowIfNullOrEmpty(name);

            foreach (CodeTypeMember member in coll)
            {
                if ((member is CodeMemberField) == false)
                {
                    continue;
                }
                var field = (CodeMemberField) member;
                if (field.Name == name)
                {
                    return field;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the first <see cref="System.CodeDom.CodeTypeMember"/> with a 
        /// name that matches the passed in name - or null if no match is found.
        /// </summary>
        /// <param name="coll">May not be null</param>
        /// <param name="name">May not be null or empty</param>
        public static CodeTypeMember FindMemberByName(this CodeTypeMemberCollection coll, string name)
        {
            coll.ThrowIfNull("coll");
            name.ThrowIfNullOrEmpty(name);

            foreach (CodeTypeMember member in coll)
            {
                if (member.Name == name)
                {
                    return member;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the first <see cref="System.CodeDom.CodeTypeDeclaration"/> with a 
        /// name that matches the passed in name - or null if no match is found.
        /// </summary>
        /// <param name="coll">May not be null</param>
        /// <param name="name">May not be null or empty</param>
        public static CodeTypeDeclaration FindTypeMemberByName(this CodeTypeMemberCollection coll, string name)
        {
            coll.ThrowIfNull("coll");
            name.ThrowIfNullOrEmpty(name);

            foreach (CodeTypeMember member in coll)
            {
                var field = member as CodeTypeDeclaration;
                if (field != null && field.Name == name)
                {
                    return field;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns the first <see cref="System.CodeDom.CodeMemberProperty"/> with a 
        /// name that matches the passed in name - or Null if no match found.
        /// </summary>
        /// <param name="coll">May not be null</param>
        /// <param name="name">May not be null or empty</param>
        public static CodeMemberProperty FindPropertyByName(this CodeTypeMemberCollection coll, string name)
        {
            coll.ThrowIfNull("coll");
            name.ThrowIfNullOrEmpty(name);

            foreach (CodeTypeMember member in coll)
            {
                if ((member is CodeMemberProperty) == false)
                {
                    continue;
                }
                var property = (CodeMemberProperty) member;
                if (property.Name == name)
                {
                    return property;
                }
            }
            return null;
        }
    }
}