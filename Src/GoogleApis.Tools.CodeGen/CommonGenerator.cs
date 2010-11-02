
using System;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class CommonGenerator {

		public CommonGenerator() {
		}
		
		protected static String GetClassName(Resource resource){
			return UpperFirstLetter(resource.Name);
		}
		
		protected static String UpperFirstLetter(String str){
			if(str == null || str.Length == 0){
				return str;
			}
			if(str.Length == 1){
				return Char.ToUpper(str[0]).ToString();
			}
			
			return Char.ToUpper(str[0]) + str.Substring(1);
		}
	}
}
