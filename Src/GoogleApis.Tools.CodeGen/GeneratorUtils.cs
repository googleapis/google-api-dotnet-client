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
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '_'); ;
            // [A-Za-z] or _
        }

        /// <summary>
        /// Checks if this char is allowed within field/variable names
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsValidBodyChar(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || (c == '_');
            // [A-Za-z0-9] or _
        }

        #endregion

        #region Safe  Names
        /// <summary>
        /// The maximum index used for method generation when the proposed name is already used
        /// </summary>
        internal const int SafeMemberMaximumIndex = 16;

        /// <summary>
        /// Defines a change operation which should be applied to a letter
        /// </summary>
        public enum TargetCase
        {
            /// <summary>
            /// Don't change the casing
            /// </summary>
            DontChange,

            /// <summary>
            /// Change the casing to upper
            /// </summary>
            ToUpper,
            
            /// <summary>
            /// Change the casing to lower
            /// </summary>
            ToLower,
        }

        /// <summary>
        /// Creates a safe member name which can be used within code environments.
        /// Also checks for disallowed C# keywords words
        /// </summary>
        public static string GetSafeMemberName(IEnumerable<string> unsafeWords, TargetCase firstCharCase, string baseName,
                                               params string[] alternativeNames)
        {
            unsafeWords.ThrowIfNull("unsafeWords");
            baseName.ThrowIfNullOrEmpty("baseName");
            alternativeNames.ThrowIfNull("alternativeNames");

            IEnumerable<string> illegalWords = UnsafeWords.Concat(unsafeWords);

            foreach (string proposedName in new[] { baseName }.Concat(alternativeNames))
            {
                string name = ValidateMemberName(illegalWords, proposedName, firstCharCase);

                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
            }

            // Generate a name in the form of baseName{0}
            for (int i = 2; i <= SafeMemberMaximumIndex; i++)
            {
                string proposedName = baseName + i;
                string name = ValidateMemberName(illegalWords, proposedName, firstCharCase);

                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }              
            }
            // Generate a name in the form of baseNameMember{0}
            for (int i = 1; i <= SafeMemberMaximumIndex; i++)
            {
                string proposedName = baseName + "Member" + (i == 1 ? "" : i.ToString());
                string name = ValidateMemberName(illegalWords, proposedName, firstCharCase);

                if (!string.IsNullOrEmpty(name))
                {
                    return name;
                }
            }

            throw new ArgumentException(string.Format("Unable to generate a safe member name for '{0}'", baseName));
        }

        private static string ValidateMemberName(IEnumerable<string> illegalWords,
                                                 string proposedName,
                                                 TargetCase firstCharCase)
        {
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            bool nextCharToUpper = false;

            foreach (char c in proposedName)
            {
                if (isFirst)
                {
                    if (IsValidFirstChar(c) == false)
                    {
                        continue;
                    }

                    char newChar = c;

                    // If the change to upper/lower flag is set, change the case
                    if (firstCharCase == TargetCase.ToUpper)
                    {
                        newChar = Char.ToUpper(c);
                    }
                    else if (firstCharCase == TargetCase.ToLower)
                    {
                        newChar = Char.ToLower(c);
                    }

                    sb.Append(newChar);
                    isFirst = false;
                    continue;
                }

                if (IsValidBodyChar(c) == false)
                {
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

            // Check if the name can be used safely
            if (illegalWords.Contains(sb.ToString()))
            {
                // Already taken, return null
                return null;
            }

            if (sb.Length == 0)
            {
                // Empty string
                return null;
            }

            // This name seems safe - return it.
            return sb.ToString();
        }

        /// <summary>
        /// From the Parameter and its placement constructs a safe name.
        /// </summary>
        /// <param name="parameter">
        ///     The Parameter
        /// </param>
        /// <param name="otherParameterNames">Enumerable of all parameter names used within the same method</param>
        public static string GetParameterName(IParameter parameter,
                                              IEnumerable<string> otherParameterNames)
        {
            string name = parameter.Name;
            return GetSafeMemberName(otherParameterNames, TargetCase.ToLower, name, name + "Value", name + "Param");
        }

        /// <summary>
        /// Returns a safe and appropriate method name for the specified method
        /// </summary>
        public static string GetMethodName(IMethod method, IEnumerable<string> wordsUsedInContext)
        {
            string name = method.Name;
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Method", name + "Call");
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the specified resource container
        /// </summary>
        public static string GetClassName(IResourceContainer resource,
                                          IEnumerable<string> wordsUsedInContext)
        {
            string name = resource.Name;
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Resource", name + "Object");
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the specified resoure
        /// </summary>
        public static string GetFieldName(IResource resource, IEnumerable<string> wordsUsedInContext)
        {
            return GetFieldName(resource.Name, wordsUsedInContext);
        }

        /// <summary>
        /// Returns a safe and appropriate field name for the given input name
        /// </summary>
        public static string GetFieldName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToLower, name, name + "Value", name + "Field");
        }

        /// <summary>
        /// Returns a safe and appropriate property name for the given input name without using the words
        /// specified in the illegal words list
        /// </summary>
        public static string GetPropertyName(string name, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Value", name + "Property");
        }

        /// <summary>
        /// Returns a safe and appropriate class name for the given schema
        /// </summary>
        public static string GetClassName(ISchema schema, IEnumerable<string> wordsUsedInContext)
        {
            string name = schema.Name;
            return GetSafeMemberName(wordsUsedInContext, TargetCase.ToUpper, name, name + "Schema", name + "Class", name + "Data");
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