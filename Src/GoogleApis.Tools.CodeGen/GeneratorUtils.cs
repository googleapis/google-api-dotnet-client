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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
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
                                                                    "extern", "false", "finally", "fixed", "float", "for",
                                                                    "foreach", "goto", "if", "implicit", "in", "int",
                                                                    "interface", "internal", "is", "lock", "long",
                                                                    "namespace", "new", "null", "object", "operator",
                                                                    "out", "override", "params", "private", "protected",
                                                                    "public", "readonly", "ref", "return", "sbyte",
                                                                    "sealed", "short", "sizeof", "stackalloc", "static",
                                                                    "string", "struct", "switch", "this", "throw", "true",
                                                                    "try", "typeof", "uint", "ulong", "unchecked",
                                                                    "unsafe", "ushort", "using", "virtual", "void",
                                                                    "volatile", "while", //C# proposed reserved words
                                                                    "await", "async", //CodeGen Specific
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
        /// Checks if the char is a valid first char for a field/variable name
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidFirstChar(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
            // [A-Za-z]
        }

        /// <summary>
        /// Checks if this char is allowed within field/variable names
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidBodyChar(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
            // [A-Za-z0-9]
        }

        #endregion

        #region Safe  Names

        /// <summary>
        /// Creates a safe member name which can be used within code environments
        /// </summary>
        public static string GetSafeMemberName(string baseName,
                                               string uniquieifier,
                                               IEnumerable<string> unsafeWords,
                                               IEnumerable<string> wordsUsedInContext)
        {
            unsafeWords.ThrowIfNull("unsafeWords");
            baseName.ThrowIfNullOrEmpty("baseName");
            wordsUsedInContext.ThrowIfNull("wordsUsedInContext");
            uniquieifier.ThrowIfNullOrEmpty("uniquieifier");

            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            bool requiresUniqueAddition = false;
            bool nextCharToUpper = false;
            bool modifiedName = false;

            foreach (char c in baseName)
            {
                if (isFirst)
                {
                    if (IsValidFirstChar(c) == false)
                    {
                        modifiedName = true;
                        continue;
                    }
                    sb.Append(c);
                    isFirst = false;
                    continue;
                }

                if (IsValidBodyChar(c) == false)
                {
                    modifiedName = true;
                    nextCharToUpper = true;
                    continue;
                }
                if (nextCharToUpper)
                {
                    sb.Append(Char.ToUpper(c));
                    nextCharToUpper = false;
                }
                else
                {
                    sb.Append(c);
                }
            }

            // Would be faster with a hashtable.contains but this is fast enough for generating code.
            if (unsafeWords.Contains(sb.ToString(), CaseInsensitiveStringComparer.Instance))
            {
                requiresUniqueAddition = true;
            }
            if (modifiedName && wordsUsedInContext.Contains(sb.ToString(), CaseInsensitiveStringComparer.Instance))
            {
                requiresUniqueAddition = true;
            }

            if (requiresUniqueAddition || sb.Length == 0)
            {
                sb.Append(uniquieifier);
            }

            return sb.ToString();
        }


        /// <summary>
        /// Creates a safe member name which can be used within code environments
        /// </summary>
        public static string GetSafeMemberName(string baseName,
                                               string uniquieifier,
                                               IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(baseName, uniquieifier, UnsafeWords, wordsUsedInContext);
        }

        /// <summary>
        /// From the Parameter and its placement constructs a safe name.
        /// </summary>
        /// <param name="parameter">
        ///     The Parameter
        /// </param>
        /// <param name="paramNumber">The order of this parameter used if the name is not usable</param>
        public static string GetParameterName(IParameter parameter,
                                              int paramNumber,
                                              IEnumerable<string> otherParameterNames)
        {
            return LowerFirstLetter(GetSafeMemberName(parameter.Name, "Param" + paramNumber, otherParameterNames));
        }

        /// <summary>
        /// Returns a safe and appropriate method name for the specified method
        /// </summary>
        public static string GetMethodName(IMethod method, int methodNumber, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter(GetSafeMemberName(method.Name, "Method" + methodNumber, wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the specified resource container
        /// </summary>
        public static string GetClassName(IResourceContainer resource,
                                          int resourceNumber,
                                          IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter(GetSafeMemberName(resource.Name, "Resource" + resourceNumber, wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the specified resoure
        /// </summary>
        public static string GetFieldName(IResource resource, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return LowerFirstLetter(GetSafeMemberName(resource.Name, "Field" + resourceNumber, wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the given input name
        /// </summary>
        public static string GetFieldName(string name, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return LowerFirstLetter(GetSafeMemberName(name, "Field" + resourceNumber, wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate property name for the given input name
        /// </summary>
        public static string GetPropertyName(string name, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter(GetSafeMemberName(name, "Property" + resourceNumber, wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate property name for the given input name without using the words
        /// specified in the illegal words list
        /// </summary>
        /// <param name="illegalWords">Words which will never be used</param>
        /// <param name="wordsUsedInContext">Words which won't be used when renaming the property</param>
        public static string GetPropertyName(string name,
                                             int resourceNumber,
                                             IEnumerable<string> wordsUsedInContext,
                                             IEnumerable<string> illegalWords)
        {
            return
                UpperFirstLetter(
                    GetSafeMemberName(
                        name, "Property" + resourceNumber, UnsafeWordsArray.Concat(illegalWords), wordsUsedInContext));
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the given schema
        /// </summary>
        public static string GetClassName(ISchema schema, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter(GetSafeMemberName(schema.Name, "Cls", wordsUsedInContext));
        }

        /// <summary>
        /// Comparer which ignores the case of a string
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
    }
}