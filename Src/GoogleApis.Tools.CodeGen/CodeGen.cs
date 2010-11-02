using System;
using System.CodeDom;
using Google.Apis.Discovery;


namespace Google.Apis.Tools.CodeGen
{
	public class CodeGen:CommonGenerator {
		
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
			
			var serviceClass = new ServiceClassGenerator().CreateServiceClass(service);
			string serviceClassName = serviceClass.Name;
			
			client.Types.Add(serviceClass);
			var resourceGenerator = new ResourceClassGenerator();
			foreach(var res in service.Resources) {
				// Create a class for the resource
				client.Types.Add(resourceGenerator.CreateClass(res.Value, serviceClassName));
			}
			
			return compileUnit;
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

