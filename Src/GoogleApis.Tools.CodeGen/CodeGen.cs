using System;
using System.CodeDom;
using Google.Apis.Discovery;


namespace Google.Apis.Tools.CodeGen
{
	public class CodeGen {
		
		private readonly CodeCompileUnit compileUnit;
		private CodeNamespace client;
		private readonly Service service;
		private readonly string clientNamespace;
		
		public CodeGen (Service service, string clientNamespace) {
			compileUnit = new CodeCompileUnit();
			this.clientNamespace = clientNamespace;
			this.service = service;
		}
		
		public CodeCompileUnit Generate() {
						
			CreateClient();
			AddUsings();
			
			foreach(var res in service.Resources) {
				// Create a class for the resource
				client.Types.Add(CreateClass(res.Value));
			}
			
			return compileUnit;
		}
		
		private static String UpperFirstLetter(String str){
			if(str == null || str.Length == 0){
				return str;
			}
			if(str.Length == 1){
				return Char.ToUpper(str[0]).ToString();
			}
			
			return Char.ToUpper(str[0]) + str.Substring(1);
		}
		
		private static String GetClassName(Resource resource){
			return UpperFirstLetter(resource.Name);
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
		private CodeTypeDeclaration CreateClass(Resource res) {
			var className = GetClassName(res);
			
			var resourceClass = new CodeTypeDeclaration(className);
			
			var methods = res.Methods.Values;
			
			foreach(var method in methods) {
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
				if(param.Required) {
					
				}
			}
			
			return member;
		}
		
		private void CreateClient() {
			client = new CodeNamespace(clientNamespace + "." + UpperFirstLetter(service.Name));	
			compileUnit.Namespaces.Add(client);
		}
	
		private void AddUsings() {
			client.Imports.Add(new CodeNamespaceImport("System"));
			client.Imports.Add(new CodeNamespaceImport("System.IO"));
			client.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
		}
	}
}

