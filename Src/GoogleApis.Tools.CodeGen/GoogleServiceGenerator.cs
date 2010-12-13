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
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen
{
    /// <summary>
    /// The main entry for generating code to access google services.
    /// For a default generation try calling 
    /// <example>
    ///     <code>
    ///         GoogleServiceGenerator.GenerateService("buzz", "v1", "Com.Example.Namespace", "CSharp", "c:\example\");
    ///     </code>
    /// </example>
    /// </summary>
    public class GoogleServiceGenerator : BaseGenerator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(GoogleServiceGenerator));

        private readonly CodeCompileUnit compileUnit;
        private readonly IService service;
        private readonly string codeClientNamespace;

        private readonly IEnumerable<IResourceDecorator> resourceDecorators;
        private readonly IEnumerable<IServiceDecorator> serviceDecorators;

        private CodeNamespace client;

        public GoogleServiceGenerator (IService service, string clientNamespace, IEnumerable<IResourceDecorator> resourceDecorators, 
                        IEnumerable<IServiceDecorator> serviceDecorators)
        {
            compileUnit = new CodeCompileUnit ();
            this.codeClientNamespace = clientNamespace;
            this.service = service;
            
            // Defensive copy and readonly
            this.resourceDecorators = new List<IResourceDecorator> (resourceDecorators).AsReadOnly ();
            this.serviceDecorators = new List<IServiceDecorator> (serviceDecorators).AsReadOnly ();
        }

        public GoogleServiceGenerator (IService service, string clientNamespace) : 
            this(service, clientNamespace, 
                new IResourceDecorator[] {
                    new StandardServiceFieldResourceDecorator(),
                    new StandardResourceNameResourceDecorator(),
                    new StandardConstructorResourceDecorator (), 
                    new StandardMethodResourceDecorator (), 
                    new Log4NetResourceDecorator (), 
                    new DictonaryOptionalParameterResourceDecorator () }, 
                new IServiceDecorator[] { 
                    new StandardServiceFieldServiceDecorator(),
                    new StandardResourcePropertyServiceDecorator(),
                    new StandardConstructServiceDecorator (), 
                    new EasyConstructServiceDecorator (), 
                    new VersionInformationServiceDecorator (), 
                    new StandardExecuteMethodServiceDecorator () })
        {   
        }
  
        /// <summary>
        /// Generates the given service saving to the outputFile in the language passed in.
        /// </summary>
        public static void GenerateService (string serviceName, string version, string clientNamespace, 
                                            string language, string outputFile)
        {
            // Set up how discovery works.
            string cacheDirectory = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData), "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists (cacheDirectory) == false) {
                Directory.CreateDirectory (cacheDirectory);
            }
            var webfetcher = new CachedWebDiscoveryDevice (
                                new Uri ("http://www.googleapis.com/discovery/0.1/describe?api=" + serviceName), 
                                new DirectoryInfo (cacheDirectory));
            var discovery = new DiscoveryService (webfetcher);
            // Build the service based on discovery information.
            var service = discovery.GetService (version);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (outputFile, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
        }
        
        public CodeCompileUnit GenerateCode ()
        {
            logger.Debug ("Starting Code Generation...");
            LogDecorators ();
            
            
            CreateClient (codeClientNamespace);
            AddUsings (false);
            
            var serviceClass = new ServiceClassGenerator (service, serviceDecorators).CreateServiceClass ();
            string serviceClassName = serviceClass.Name;
            
            client.Types.Add (serviceClass);
            
            int resourceNumber = 1;
            foreach (var res in service.Resources.Values) {
                // Create a class for the resource
                logger.DebugFormat ("Adding Resource {0}", res.Name);
                var resourceGenerator = new ResourceClassGenerator (res, serviceClassName, resourceNumber, resourceDecorators);
                client.Types.Add (resourceGenerator.CreateClass ());
                resourceNumber++;
            }
            
            logger.Debug ("Generation Complete.");
            return compileUnit;
        }

        private void LogDecorators ()
        {
            if (logger.IsDebugEnabled) {
                logger.Debug ("With Service Decorators:");
                foreach (IServiceDecorator dec in serviceDecorators) {
                    logger.Debug (">>>>" + dec.ToString ());
                }
                logger.Debug ("With Resource Decorators:");
                foreach (IResourceDecorator dec in resourceDecorators) {
                    logger.Debug (">>>>" + dec.ToString ());
                }
            }
        }


        private void CreateClient (string nameSpace)
        {
            client = new CodeNamespace (nameSpace);
            compileUnit.Namespaces.Add (client);
        }

        private void AddUsings (bool forTest)
        {
            client.Imports.Add (new CodeNamespaceImport ("System"));
            client.Imports.Add (new CodeNamespaceImport ("System.IO"));
            client.Imports.Add (new CodeNamespaceImport ("System.Collections.Generic"));
            client.Imports.Add (new CodeNamespaceImport ("Google.Apis"));
            client.Imports.Add (new CodeNamespaceImport ("Google.Apis.Discovery"));
            
            if (forTest) {
                client.Imports.Add (new CodeNamespaceImport ("NUnit.Framework"));
                client.Imports.Add (new CodeNamespaceImport (codeClientNamespace));
            }
        }
    }
}

