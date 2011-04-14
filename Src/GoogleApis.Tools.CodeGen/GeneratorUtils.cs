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
    public sealed class GeneratorUtils
    {
        #region unsafe words
        //C# reserved words
        private static readonly string[] UnsafeWordsArray = new string[] { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
        "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum",
        "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto",
        "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
        "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public",
        "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string",
        "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
        "unsafe", "ushort", "using", "virtual", "void", "volatile", "while",    
        //C# proposed reserved words
        "await", "async",
        //CodeGen Specific
        "body" };
        public static readonly IList<string> UnsafeWords = new List<string> (UnsafeWordsArray).AsReadOnly ();
        #endregion

        #region private constructor - prevent instantiation
        private GeneratorUtils ()
        {
            throw new NotSupportedException ("Static Methods only do not construct.");
        }
        #endregion

        #region Lower/UpperFirst
        public static string LowerFirstLetter (string str)
        {
            if (str == null || str.Length == 0)
            {
                return str;
            }
            if (str.Length == 1)
            {
                return Char.ToLower (str[0]).ToString ();
            }
            
            return Char.ToLower (str[0]) + str.Substring (1);
        }

        public static string UpperFirstLetter (string str)
        {
            if (str == null || str.Length == 0)
            {
                return str;
            }
            if (str.Length == 1)
            {
                return Char.ToUpper (str[0]).ToString ();
            }
            
            return Char.ToUpper (str[0]) + str.Substring (1);
        }
        #endregion

        #region IsValid[First|BodyChar]
        public static bool IsValidFirstChar (char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
            // [A-Za-z]
        }

        public static bool IsValidBodyChar (char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
            // [A-Za-z0-9]
        }
        #endregion
  
        #region Safe  Names
        
        public static string GetSafeMemberName (string baseName, string uniquieifier, 
                IEnumerable<string> unsafeWords, IEnumerable<string> wordsUsedInContext)
        {
            unsafeWords.ThrowIfNull("unsafeWords");
            baseName.ThrowIfNullOrEmpty("baseName");
            wordsUsedInContext.ThrowIfNull("wordsUsedInContext");
            uniquieifier.ThrowIfNullOrEmpty("uniquieifier");

            StringBuilder sb = new StringBuilder ();
            bool isFirst = true;
            bool requiresUniqueAddition = false;
            bool nextCharToUpper = false;
            bool modifiedName = false;

            string lowerbaseName = baseName.ToLower ();
            
            foreach (char c in baseName)
            {
                if (isFirst)
                {
                    if (GeneratorUtils.IsValidFirstChar (c) == false)
                    {
                        modifiedName = true;
                        continue;
                    }
                    sb.Append (c);
                    isFirst = false;
                    continue;
                }
                
                if (GeneratorUtils.IsValidBodyChar (c) == false)
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
            if (unsafeWords.Contains(sb.ToString(), CaseInsensitiveStringCompareer.Instance))
            {
                requiresUniqueAddition = true;
            }
            if (modifiedName && wordsUsedInContext.Contains(sb.ToString(), CaseInsensitiveStringCompareer.Instance))
            {
                requiresUniqueAddition = true;
            }

            if (requiresUniqueAddition || sb.Length == 0)
            {
                sb.Append (uniquieifier);
            }
            
            return sb.ToString ();
        }


        internal class CaseInsensitiveStringCompareer : IEqualityComparer<string>
        {
            private static CaseInsensitiveStringCompareer instance = new CaseInsensitiveStringCompareer();
            public static IEqualityComparer<string> Instance
            {
                get { return instance; }
            }

            public bool Equals(string x, string y)
            {
                return string.Compare(x, y, true) == 0;
            }

            public int GetHashCode(string obj)
            {
                return obj.GetHashCode();
            }
        }

        public static string GetSafeMemberName(string baseName, string uniquieifier, IEnumerable<string> wordsUsedInContext)
        {
            return GetSafeMemberName (baseName, uniquieifier, UnsafeWords, wordsUsedInContext);
        }
        
        /// <summary>
        /// From the Parameter and its placement constructs a safe name.
        /// </summary>
        /// <param name="parameter">
        ///     The Parameter
        /// </param>
        /// <param name="paramNumber">The order of this parameter used if the name is not usable</param>
        public static string GetParameterName (IParameter parameter, int paramNumber, IEnumerable<string> otherParameterNames)
        {
            return LowerFirstLetter(GetSafeMemberName(parameter.Name, "Param" + paramNumber, otherParameterNames));
        }
        
        public static string GetMethodName (IMethod method, int methodNumber, IEnumerable<string> wordsUsedInContext )
        {
            return UpperFirstLetter( GetSafeMemberName( method.Name, "Method" + methodNumber, wordsUsedInContext));
        }

        public static string GetClassName (IResourceContainer resource, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter( GetSafeMemberName( resource.Name, "Resource" + resourceNumber, wordsUsedInContext));
        }
        
        public static string GetFieldName (IResource resource, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return LowerFirstLetter( GetSafeMemberName( resource.Name, "Field" + resourceNumber, wordsUsedInContext));
        }
        
        public static string GetFieldName (string name, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return LowerFirstLetter( GetSafeMemberName( name, "Field" + resourceNumber, wordsUsedInContext));
        }
        
        public static string GetPropertyName(string name, int resourceNumber, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter( GetSafeMemberName( name, "Property" + resourceNumber, wordsUsedInContext));
        }
        
        public static string GetClassName (ISchema schema, IEnumerable<string> wordsUsedInContext)
        {
            return UpperFirstLetter( GetSafeMemberName(schema.Name, "", wordsUsedInContext) );
        }
        
        #endregion
    }
}
