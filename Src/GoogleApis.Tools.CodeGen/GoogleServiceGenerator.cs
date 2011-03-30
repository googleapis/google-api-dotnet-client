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
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.ResourceContainerDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

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

        private readonly IService service;
        private readonly string codeClientNamespace;

        private readonly IEnumerable<IResourceDecorator> resourceDecorators;
        private readonly IEnumerable<IServiceDecorator> serviceDecorators;
        private readonly IEnumerable<IResourceContainerDecorator> resourceContainerDecorators;
        private readonly GoogleSchemaGenerator schemaGenerator;
        
        public static readonly IList<IResourceDecorator> StandardResourceDecorators = (new List<IResourceDecorator>(){
                    new StandardServiceFieldResourceDecorator(false),
                    new StandardResourceNameResourceDecorator(),
                    new StandardConstructorResourceDecorator (), 
                    new StandardMethodResourceDecorator (), 
                    new Log4NetResourceDecorator (), 
                    new DictonaryOptionalParameterResourceDecorator ()}).
                    AsReadOnly();
        public static IList<IResourceDecorator> GetSchemaAwareResourceDecorators(string schemaNamespace)
        {
            return (new List<IResourceDecorator>(){
                    new StandardServiceFieldResourceDecorator(true),
                    new StandardResourceNameResourceDecorator(),
                    new StandardConstructorResourceDecorator (), 
                    new StandardMethodResourceDecorator (),
                    new StandardMethodResourceDecorator (
                            true, true, new StandardMethodResourceDecorator.DefaultObjectTypeProvider(schemaNamespace)),
                    new Log4NetResourceDecorator (), 
                    new DictonaryOptionalParameterResourceDecorator ()}).
                    AsReadOnly();
        }

        public static readonly IList<IServiceDecorator> StandardServiceDecorators = (new List<IServiceDecorator>(){
                    new StandardServiceFieldServiceDecorator(),
                    new StandardConstructServiceDecorator (), 
                    new EasyConstructServiceDecorator (), 
                    new VersionInformationServiceDecorator (), 
                    new StandardExecuteMethodServiceDecorator ()}).
                    AsReadOnly();
        public static readonly IList<IServiceDecorator> SchemaAwareServiceDecorators = (new List<IServiceDecorator>(){
                    new StandardServiceFieldServiceDecorator(),
                    new StandardConstructServiceDecorator (), 
                    new EasyConstructServiceDecorator (), 
                    new VersionInformationServiceDecorator (), 
                    new StandardExecuteMethodServiceDecorator (),
                    new SchemaAwearExecuteMethodDecorator(),
                    new NewtonsoftJsonSerializer()}).
                    AsReadOnly();
        public static readonly IList<IResourceContainerDecorator> StandardResourceContainerDecorator = (new List<IResourceContainerDecorator>(){
                    new StandardResourcePropertyServiceDecorator()}).
                    AsReadOnly();

        
        public GoogleServiceGenerator (IService service, string clientNamespace, 
                    IEnumerable<IResourceDecorator> resourceDecorators, 
                    IEnumerable<IServiceDecorator> serviceDecorators,
                    IEnumerable<IResourceContainerDecorator> resourceContainerDecorators,
                    GoogleSchemaGenerator schemaGenerator)
        {
            service.ThrowIfNull("service");
            clientNamespace.ThrowIfNull("clientNamespace");
            resourceDecorators.ThrowIfNull("resourceDecorators");
            serviceDecorators.ThrowIfNull("serviceDecorators");
            resourceContainerDecorators.ThrowIfNull("resourceContainerDecorators");
            
            this.codeClientNamespace = clientNamespace;
            this.service = service;
            
            // Defensive copy and readonly
            this.resourceDecorators = new List<IResourceDecorator> 
                (resourceDecorators).AsReadOnly ();
            this.serviceDecorators = new List<IServiceDecorator> 
                (serviceDecorators).AsReadOnly ();
            this.resourceContainerDecorators = new List<IResourceContainerDecorator> 
                (resourceContainerDecorators).AsReadOnly ();
            this.schemaGenerator = schemaGenerator;
        }

        public GoogleServiceGenerator (IService service, string clientNamespace) : 
            this(service, clientNamespace, 
                GetSchemaAwareResourceDecorators(clientNamespace + ".Data"), 
                SchemaAwareServiceDecorators,
                StandardResourceContainerDecorator,
                new GoogleSchemaGenerator(GoogleSchemaGenerator.DeafultSchemaDecorators, clientNamespace + ".Data")
                )
        {   
        }
  
        internal static IDiscoveryService CreateDefaultCachingDiscovery(string serviceName)
        {
            // Set up how discovery works.
            string cacheDirectory = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData), "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists (cacheDirectory) == false) {
                Directory.CreateDirectory (cacheDirectory);
            }
            var webfetcher = new CachedWebDiscoveryDevice (
                                new Uri ("https://www.googleapis.com/discovery/0.1/describe?api=" + serviceName), 
                                new DirectoryInfo (cacheDirectory));
            return new DiscoveryService (webfetcher);
        }
        
        /// <summary>
        /// Generates the given service saving to the outputFile in the language passed in.
        /// </summary>
        public static void GenerateService (string serviceName, string version, string clientNamespace, 
                                            string language, string outputFile)
        {
            var discovery = CreateDefaultCachingDiscovery(serviceName);
            // Build the service based on discovery information.
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_1, null);
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            var generatedCode = generator.GenerateCode ();
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (outputFile, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                provider.GenerateCodeFromCompileUnit (generatedCode, tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
        }
        
        [VisibleForTestOnly]
        internal CodeNamespace GenerateSchemaCode()
        {
            if(this.schemaGenerator != null)
            {
                return schemaGenerator.GenerateSchemaClasses(this.service);
            }
            return null;
        }
        
        [VisibleForTestOnly]
        internal CodeNamespace GenerateClientCode()
        {
            var clientNamespace = CreateNamespace (codeClientNamespace);
            AddClientUsings (clientNamespace);
            
            ResourceContainerGenerator resourceContainerGenerator = 
                new ResourceContainerGenerator(resourceContainerDecorators);
            
            var serviceClass = new ServiceClassGenerator (service, serviceDecorators, resourceContainerGenerator)
                .CreateServiceClass ();
            string serviceClassName = serviceClass.Name;
            
            clientNamespace.Types.Add (serviceClass);
            CreateResources (clientNamespace, serviceClassName,service, resourceContainerGenerator, 1);
            
            return clientNamespace;
        }

        public CodeCompileUnit GenerateCode ()
        {
            logger.Debug ("Starting Code Generation...");
            LogDecorators ();
            
            var compileUnit = new CodeCompileUnit ();
            
            var schemaCode = GenerateSchemaCode();
            if ( schemaCode != null )
            {
                compileUnit.Namespaces.Add(schemaCode);
            }
            
            compileUnit.Namespaces.Add(GenerateClientCode());
            
            logger.Debug ("Generation Complete.");
            return compileUnit;
        }
        
        private int CreateResources ( CodeNamespace clientNamespace,
                                      string serviceClassName, 
                                      IResourceContainer resourceContainer,
                                      ResourceContainerGenerator resourceContainerGenerator,
                                      int resourceNumber)
        {
            foreach (var res in resourceContainer.Resources.Values) {
                // Create a class for the resource
                logger.DebugFormat ("Adding Resource {0}", res.Name);
                var resourceGenerator = new ResourceClassGenerator (
                    res, serviceClassName, 
                    resourceNumber, resourceDecorators, resourceContainerGenerator);
                clientNamespace.Types.Add (resourceGenerator.CreateClass ());
                resourceNumber++;
                resourceNumber = CreateResources(clientNamespace, serviceClassName, res, 
                                                 resourceContainerGenerator, resourceNumber);
            }
            return resourceNumber;
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
                logger.Debug ("With Resource Container Decorators:");
                foreach (IResourceContainerDecorator dec in resourceContainerDecorators) {
                    logger.Debug (">>>>" + dec.ToString ());
                }
            }
        }

        private CodeNamespace CreateNamespace (string nameSpace)
        {
            return new CodeNamespace (nameSpace);
        }

        private void AddClientUsings (CodeNamespace codeNamespace)
        {
            codeNamespace.Imports.Add (new CodeNamespaceImport ("System"));
            codeNamespace.Imports.Add (new CodeNamespaceImport ("System.IO"));
            codeNamespace.Imports.Add (new CodeNamespaceImport ("System.Collections.Generic"));
            codeNamespace.Imports.Add (new CodeNamespaceImport ("Google.Apis"));
            codeNamespace.Imports.Add (new CodeNamespaceImport ("Google.Apis.Discovery"));            
        }
    }
}
