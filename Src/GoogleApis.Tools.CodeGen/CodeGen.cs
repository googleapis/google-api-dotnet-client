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
using System.CodeDom;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using System.Collections.Generic;

namespace Google.Apis.Tools.CodeGen
{
	public class CodeGen:BaseGenerator {
		
		private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CodeGen));
		
		private readonly CodeCompileUnit compileUnit;
		private CodeNamespace client;
		private readonly IService service;
		private readonly string clientNamespace;
		
		private readonly IEnumerable<IResourceDecorator> resourceDecorators;
		private readonly IEnumerable<IServiceDecorator> serviceDecorators;
		
		
		
		public CodeGen (IService service, string clientNamespace, 
		                IEnumerable<IResourceDecorator> resourceDecorators, 
		                IEnumerable<IServiceDecorator> serviceDecorators) {
			compileUnit = new CodeCompileUnit();
			this.clientNamespace = clientNamespace;
			this.service = service;
			
			this.resourceDecorators = resourceDecorators;
			this.serviceDecorators = serviceDecorators;
		}
		
		public CodeGen (IService service, string clientNamespace): 
			this(service, clientNamespace, 
			     new IResourceDecorator[]{
					new StandardConstructorResourceDecorator(),
					new StandardMethodResourceDecorator(),
					new Log4NetResourceDecorator(), 
					new DictonaryOptionalParameterResourceDecorator()},
				new IServiceDecorator[]{
					new EasyConstructServiceDecorator(),
					new VersionInformationServiceDecorator()}) {
			
		}
		
		public CodeCompileUnit Generate() {
			Logger.Debug("Starting Generation...");
			if ( Logger.IsDebugEnabled ) {
				Logger.Debug("With Service Decorators:");
				foreach(IServiceDecorator dec in serviceDecorators){
					Logger.Debug(">>>>" + dec.ToString());
				}
				Logger.Debug("With Resource Decorators:");
				foreach(IResourceDecorator dec in resourceDecorators){
					Logger.Debug(">>>>" + dec.ToString());
				}
			}

						
			CreateClient();
			AddUsings();

			var serviceClass = new ServiceClassGenerator(service, serviceDecorators).
				CreateServiceClass();
			string serviceClassName = serviceClass.Name;

			client.Types.Add(serviceClass);
			
			int resourceNumber = 1;
			foreach(var res in service.Resources.Values) {
				// Create a class for the resource
				Logger.DebugFormat("Adding Resource {0}", res.Name);
				var resourceGenerator = new ResourceClassGenerator(
				     res, 
				     serviceClassName, 
				     resourceNumber,
				     resourceDecorators);
				client.Types.Add(resourceGenerator.CreateClass());
				resourceNumber++;
			}
			
			Logger.Debug("Generation Complete.");
			return compileUnit;
		}
		
		
		
		private void CreateClient() {
			//client = new CodeNamespace(clientNamespace + "." + UpperFirstLetter(service.Name));	
			client = new CodeNamespace(clientNamespace);	
			compileUnit.Namespaces.Add(client);
		}
	
		private void AddUsings() {
			client.Imports.Add(new CodeNamespaceImport("System"));
			client.Imports.Add(new CodeNamespaceImport("System.IO"));
			client.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
			client.Imports.Add(new CodeNamespaceImport("Google.Apis"));
			client.Imports.Add(new CodeNamespaceImport("Google.Apis.Discovery"));
		}
	}
}

