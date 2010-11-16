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
using System.CodeDom.Compiler;
using System.IO;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen
{
	public class MainClass
	{
		
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		
		public static void Main (IDictionary<string, string> args){
			var version = "v1";
			var serviceName = "buzz";
			var clientNamespace = "Google.Apis.Clients";
			var language = "CSharp";
			var outputFile = "";
			
			if(args.ContainsKey("version")){
				version = args["version"];
			}
			
			if(args.ContainsKey("serviceName")){
				serviceName = args["serviceName"];
			}
			
			if(args.ContainsKey("clientNamespace")){
				clientNamespace = args["clientNamespace"];
			}
			
			if(args.ContainsKey("language")){
				language = args["language"];
			}
			
			if(args.ContainsKey("outputFile")){
				outputFile = args["outputFile"];
			}
			
			
			GenerateClass(serviceName, version, clientNamespace, language, outputFile);			
		}
		
		/// <summary>
		/// Creates an Strongly Typed Client API for a given service.
		/// 
		/// This Tool is meant to serve as an example of how you can build your own libraries to serve your needs.
		/// 
		/// </summary>
		/// <param name="args">
		/// A <see cref="System.String[]"/>
		/// </param>
		/// <example>
		/// execute as follows: GoogleApis.Tools.CodeGen.exe buzz
		/// 
		/// creates the following api:
		/// 
		/// var client = new BuzzClient();
		/// client
		/// 	.WithAuthentication()
		/// 	.Activties.
		/// 	.List()
		/// 
		/// client
		/// 	.WithAuthentication()
		/// 	.Activties.
		/// 	.Delete()
		/// 
		/// 
		/// </example>
		public static void Main (string[] args)
		{
			Logger.Debug("Entering CodeGen.Main");
			if(args.Length == 0) {
				Console.Error.WriteLine("Please Provide Argments.");
				return;	
			}
			Logger.Debug("Entering");
			
			var version = "v1";
			var serviceName = "buzz";
			var clientNamespace = "Google.Apis.Clients";
			var language = "CSharp";
			var outputFile = "";
			
			if(args.Length >= 1)
			{
				serviceName = args[0];
				
				if(args.Length >= 2) { 
					version = args[1];
					
					if(args.Length >= 3){
						outputFile = args[2];
						
						if(args.Length >=4){
							language = args[3];
						}
					}
				}
				
			}
				
			
			GenerateClass(serviceName, version, clientNamespace, language, outputFile);
			
		}
		
		public static void GenerateClass(string serviceName, string version, string clientNamespace, string language, string outputFile) {
			// Set up how discovery works.
			string cacheDirectory = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
			    "GoogleApis.Tools.CodeGenCache");
			if(Directory.Exists(cacheDirectory) == false){
				Directory.CreateDirectory(cacheDirectory);
			}
			var webfetcher = new CachedWebDiscoveryDevice(
			    new Uri("http://www.googleapis.com/discovery/0.1/describe?api=" + serviceName),
			    new DirectoryInfo(cacheDirectory));
			var discovery = new DiscoveryService(webfetcher);
			// Build the service based on discovery information.
			var service = discovery.GetService(version);
			
			var generator = new CodeGen(service, clientNamespace);
			
			var provider = CodeDomProvider.CreateProvider(language);
			
			using (StreamWriter sw = new StreamWriter(outputFile, false))
		    {
		        IndentedTextWriter tw = new IndentedTextWriter(sw, "  ");
		
		        // Generate source code using the code provider.
		        
				provider.GenerateCodeFromCompileUnit(generator.Generate(), tw,
		            new CodeGeneratorOptions());
		
		        // Close the output file.
		        tw.Close();
		    }
		}
	}
}

