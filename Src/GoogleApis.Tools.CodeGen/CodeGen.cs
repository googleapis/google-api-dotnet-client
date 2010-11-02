using System;
using System.CodeDom;
using Google.Apis.Discovery;


namespace Google.Apis.Tools.CodeGen
{
	public class CodeGen {
		
		private CodeCompileUnit compileUnit;
		private CodeNamespace client;
		private Service _service;
		private string _clientNamespace;
		
		public CodeGen (Service _service, string clientNamespace) {
			compileUnit = new CodeCompileUnit();
			_clientNamespace = clientNamespace;
			this._service = _service;
		}
		
		public CodeCompileUnit Generate() {
						
			CreateClient();
			AddUsings();
			
			foreach(var res in _service.Resources) {
				// Create a class for the resource
				client.Types.Add(CreateClass(res.Value));
			}
			
			return compileUnit;
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
			var className = client.Name;
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
			
			member.Name = method.Name;
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
			client = new CodeNamespace(_clientNamespace + "." + _service.Name);	
			compileUnit.Namespaces.Add(client);
		}
	
		private void AddUsings() {
			client.Imports.Add(new CodeNamespaceImport("System"));
			client.Imports.Add(new CodeNamespaceImport("System.IO."));
			client.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
		}
	}
}

