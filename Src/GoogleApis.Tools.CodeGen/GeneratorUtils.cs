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
using System.Text;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen
{
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
        //C# proposed reserved words
        //CodeGen Specific
        "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "await", "async", "body" };
        public static readonly IList<string> UnsafeWords = new List<string> (UnsafeWordsArray).AsReadOnly ();
        #endregion

        #region private constructor - prevent instantiation
        private GeneratorUtils ()
        {
            throw new NotSupportedException ("Static Methods only do not construct.");
        }
        #endregion

        #region Lowwer/UpperFirst
        public static String LowwerFirstLetter (String str)
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

        public static String UpperFirstLetter (String str)
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
        
        public static String GetSafeMemberName (string baseName, String uniquieifier, IEnumerable<String> unsafeWords)
        {
            StringBuilder sb = new StringBuilder ();
            bool isFirst = true;
            bool requiresUniqueAddition = false;
            
            string lowerbaseName = baseName.ToLower ();
            
            // Would be faster with a hashtable.contains but this is fast enough for generating code.
            foreach (string word in unsafeWords) 
            {
                if (lowerbaseName.Equals (word))
                {
                    requiresUniqueAddition = true;
                }
            }
            
            foreach (char c in baseName)
            {
                if (isFirst)
                {
                    if (GeneratorUtils.IsValidFirstChar (c) == false)
                    {
                        requiresUniqueAddition = true;
                        continue;
                    }
                    sb.Append (c);
                    isFirst = false;
                    continue;
                }
                
                if (GeneratorUtils.IsValidBodyChar (c) == false)
                {
                    requiresUniqueAddition = true;
                    continue;
                }
                sb.Append (c);
            }
            if (requiresUniqueAddition)
            {
                sb.Append (uniquieifier);
            }
            
            return sb.ToString ();
        }
        
        private static String GetSafeMemberName (string baseName, String uniquieifier)
        {
            return GetSafeMemberName (baseName, uniquieifier, UnsafeWords);
        }
        
        /// <summary>
        /// From the Parameter and its placment constructs a safe name.
        /// </summary>
        /// <param name="parameter">
        ///     The Parameter
        /// </param>
        /// <param name="paramNumber">The order of this parameter used if the name is not usable</param>
        public static String GetParameterName (Parameter parameter, int paramNumber)
        {
            return LowwerFirstLetter(GetSafeMemberName (parameter.Name, "Param" + paramNumber));
        }
        
        public static String GetMethodName (Method method, int methodNumber)
        {
            return UpperFirstLetter( GetSafeMemberName( method.Name, "Method" + methodNumber));
        }

        public static String GetClassName (Resource resource, int resourceNumber)
        {
            return UpperFirstLetter( GetSafeMemberName( resource.Name, "Resource" + resourceNumber));
        }

        public static String GetFieldName (Resource resource, int resourceNumber)
        {
            return LowwerFirstLetter( GetSafeMemberName( resource.Name, "Field" + resourceNumber));
        }
        
        #endregion
    }
}
