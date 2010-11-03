
using System;
using System.Text;
using System.Text.RegularExpressions;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {

	public class CommonGenerator {
		
		public CommonGenerator() {
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
		
		private String GetSafeMemberName(String baseName, String uniquieifier){
			StringBuilder sb = new StringBuilder();
			bool isFirst = true;
			bool changed = false;
			foreach(char c in baseName){
				if(isFirst){
					if(IsValidFirstChar(c) == false){
						changed = true;
						continue;
					}
					sb.Append(c);
					isFirst = false;
					continue;
				}
				
				if(IsValidBodyChar(c) == false){
					changed = true;
					continue;
				}
				sb.Append(c);
			}
			if(changed){
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
