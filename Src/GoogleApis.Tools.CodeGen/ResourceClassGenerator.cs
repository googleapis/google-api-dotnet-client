
using System;
using System.CodeDom;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen {


	public class ResourceClassGenerator: CommonGenerator{

		public ResourceClassGenerator() {
		}
		
		private static String GetMethodName(Method method){
			return UpperFirstLetter(method.Name);
		}
		
		/// <summary>
		/// Create the class for a given resource and add all the methods.
		/// </summary>
		/// <param name="res">
		/// A <see cref="Resource"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeTypeDeclaration"/>
		/// </returns>
		public CodeTypeDeclaration CreateClass(Resource res, String serviceClassName) {
			var resourceClass = new CodeTypeDeclaration(GetClassName(res));			
			
			foreach(var method in res.Methods.Values) {
				resourceClass.Members.Add(CreateClassMethod(method));
			}
		
			return resourceClass;
		}
		
		/// <summary>
		/// For a given resource, there are number of methods, this function creates a single method
		/// </summary>
		/// <param name="method">
		/// A <see cref="Method"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeMemberMethod"/>
		/// </returns>
		private CodeMemberMethod CreateClassMethod(Method method) {
			var member = new CodeMemberMethod();
			
			member.Name = GetMethodName(method);
			member.ReturnType = new CodeTypeReference("System.IO.Stream");
			
			// Add Required parameters to the method.
			var paramList = method.Parameters.Values;
			foreach(var param in paramList) {
				member.Parameters.Add( 
				  new CodeParameterDeclarationExpression(typeof(string), param.Name));
			}
			
			return member;
		}
	}
}
