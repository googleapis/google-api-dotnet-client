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
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {

	public abstract class BaseGenerator {
		private static readonly string[] UNSAFE_WORDS = new string[]{
			//C# reserved words
			"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", 
			"checked", "class", "const", "continue", "decimal", "default", "delegate", 
			"do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", 
			"fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", 
			"interface", "internal", "is", "lock", "long", "namespace", "new", "null", 
			"object", "operator", "out", "override", "params", "private", "protected", "public", 
			"readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", 
			"static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", 
			"uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", 
			"volatile", "while", 
			//C# proposed reserved words
			"await", "async",
			//CodeGen Specific
			"body",
		};
		
		public BaseGenerator() {
		}
		
		protected String GetMethodName(Method method, int methodNumber){
			return UpperFirstLetter(GetSafeMemberName(method.Name,"Method" + methodNumber));
		}
		
		protected String GetClassName(Resource resource, int resourceNumber){
			return UpperFirstLetter(GetSafeMemberName(resource.Name,"Resource" + resourceNumber));
		}
		
		protected String GetFieldName(Resource resource, int resourceNumber){
			return GetSafeMemberName(resource.Name, "Field" + resourceNumber);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameter">
		/// A <see cref="Parameter"/>
		/// </param>
		/// <param name="paramNumber">The order of this parameter used if the name is not usable</param>
		/// <returns>
		/// A <see cref="String"/>
		/// </returns>
		protected String GetParameterName(Parameter parameter, int paramNumber){
			return GetSafeMemberName(parameter.Name, "Param" + paramNumber);
		}
		
		protected String LowwerFirstLetter(String str){
			if(str == null || str.Length == 0){
				return str;
			}
			if(str.Length == 1){
				return Char.ToLower(str[0]).ToString();
			}
			
			return Char.ToLower(str[0]) + str.Substring(1);
		}
		
		protected String UpperFirstLetter(String str){
			if(str == null || str.Length == 0){
				return str;
			}
			if(str.Length == 1){
				return Char.ToUpper(str[0]).ToString();
			}
			
			return Char.ToUpper(str[0]) + str.Substring(1);
		}
		
		private String GetSafeMemberName(string baseName, String uniquieifier){
			return GetSafeMemberName(baseName, uniquieifier, UNSAFE_WORDS);
		}
		
		private String GetSafeMemberName(string baseName, String uniquieifier, IEnumerable<String> unsafeWords){
			StringBuilder sb = new StringBuilder();
			bool isFirst = true;
			bool requiresUniqueAddition = false;
			
			string lowerbaseName = baseName.ToLower();
			foreach(string word in unsafeWords){
				if(lowerbaseName.Equals(word.ToLower())){
					requiresUniqueAddition = true;
				}
			}
			
			foreach(char c in baseName){
				if(isFirst){
					if(IsValidFirstChar(c) == false){
						requiresUniqueAddition = true;
						continue;
					}
					sb.Append(c);
					isFirst = false;
					continue;
				}
				
				if(IsValidBodyChar(c) == false){
					requiresUniqueAddition = true;
					continue;
				}
				sb.Append(c);
			}
			if(requiresUniqueAddition){
				sb.Append(uniquieifier);
			}
			
			return sb.ToString();
		}
		
		private bool IsValidFirstChar(char c){
			return (c >= 'a' && c <= 'z') ||
				(c >= 'A' && c <= 'Z'); // [A-Za-z]
		}
		
		private bool IsValidBodyChar(char c){
			return (c >= 'a' && c <= 'z') ||
				(c >= 'A' && c <= 'Z') ||
				(c >= '0' && c <= '9'); // [A-Za-z0-9]
		}
		
	}
}
