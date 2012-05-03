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
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceContainerDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
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
        /// <summary>
        /// Defines the URL used to discover Google APIs
        /// {0}: Service name
        /// {1}: Version
        /// </summary>
        public const string GoogleDiscoveryURL = "https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest";

        /// <summary>
        /// The nested namespace where data classes are generated.
        /// </summary>
        private const string DataNamespaceExtension = ".Data";

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<GoogleServiceGenerator>();

        /// <summary>
        /// List of all request class decorators
        /// </summary>
        public static IList<IRequestDecorator> GetSchemaAwareCommonRequestDecorators(
          string schemaNamespace, IService service)
        {
            var typeProvider = new DefaultObjectTypeProvider(schemaNamespace);

            return (new List<IRequestDecorator>
                        {
                            new CommonParameterRequestDecorator(service.Parameters),
                            new ParameterPropertyDecorator(),
                        }).AsReadOnly();
        }

        /// <summary>
        /// List of all request class decorators
        /// </summary>
        public static IList<IRequestDecorator> GetSchemaAwareRequestDecorators(
          string schemaNamespace, IService service)
        {
            var typeProvider = new DefaultObjectTypeProvider(schemaNamespace);

            return (new List<IRequestDecorator>()
                        {
                            new ServiceRequestInheritanceDecorator(typeProvider),
                            new BodyPropertyDecorator(typeProvider),
                            new RequestConstructorDecorator(typeProvider) { CreateOptionalConstructor = false },
                            new ServiceRequestFieldDecorator(),
                        }).AsReadOnly();
        }

        /// <summary>
        /// List of all upload class decorators
        /// </summary>
        public static IList<IRequestDecorator> GetSchemaAwareUploadDecorators(
          string schemaNamespace, IService service)
        {
            var typeProvider = new DefaultObjectTypeProvider(schemaNamespace);

            return (new List<IRequestDecorator>
                        {
                            new ResumableUploadInheritanceDecorator(typeProvider),
                            new UploadConstructorDecorator(typeProvider),
                        }).AsReadOnly();
        }

        /// <summary>
        /// List of all schema aware service decorators
        /// </summary>
        public static readonly IList<IServiceDecorator> SchemaAwareServiceDecorators =
            (new List<IServiceDecorator>
                 {
                     new StandardServiceFieldServiceDecorator(),
                     new StandardConstructServiceDecorator(),
                     new EasyConstructServiceDecorator(),
                     new VersionInformationServiceDecorator(),
                     new CreateRequestMethodServiceDecorator(),
                     new JsonSerializationMethods(),
                     new ApiKeyServiceDecorator(),
                     new ScopeEnumDecorator(),
                 }).AsReadOnly();

        /// <summary>
        /// List of all resource container decorators
        /// </summary>
        public static readonly IList<IResourceContainerDecorator> StandardResourceContainerDecorator =
            (new List<IResourceContainerDecorator> { new StandardResourcePropertyServiceDecorator() }).AsReadOnly();

        private readonly string codeClientNamespace;
        private readonly IEnumerable<IResourceContainerDecorator> resourceContainerDecorators;
        private readonly IEnumerable<IResourceDecorator> resourceDecorators;
        private readonly GoogleSchemaGenerator schemaGenerator;
        private readonly IService service;
        private readonly IEnumerable<IServiceDecorator> serviceDecorators;

        /// <summary>
        /// Generates a new instance of the service generator for a specific service
        /// </summary>
        public GoogleServiceGenerator(IService service,
                                      string clientNamespace,
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

            codeClientNamespace = clientNamespace;
            this.service = service;

            // Defensive copy and readonly
            this.resourceDecorators = new List<IResourceDecorator>(resourceDecorators).AsReadOnly();
            this.serviceDecorators = new List<IServiceDecorator>(serviceDecorators).AsReadOnly();
            this.resourceContainerDecorators =
                new List<IResourceContainerDecorator>(resourceContainerDecorators).AsReadOnly();
            this.schemaGenerator = schemaGenerator;
        }

        /// <summary>
        /// Generates a new service generator for a specific service
        /// </summary>
        public GoogleServiceGenerator(IService service, string clientNamespace)
            : this(
                service, clientNamespace, GetSchemaAwareResourceDecorators(DataNamespace(clientNamespace)),
                SchemaAwareServiceDecorators, StandardResourceContainerDecorator,
                new GoogleSchemaGenerator(GoogleSchemaGenerator.DefaultSchemaDecorators, DataNamespace(clientNamespace))) {}

        /// <summary>
        /// Returns a list of all schema aware resource decorators
        /// </summary>
        public static IList<IResourceDecorator> GetSchemaAwareResourceDecorators(string schemaNamespace)
        {
            var typeProvider = new DefaultObjectTypeProvider(schemaNamespace);

            return
                (new List<IResourceDecorator>
                     {
                         new SubresourceClassDecorator(),
                         new EnumResourceDecorator(),
                         new StandardServiceFieldResourceDecorator(),
                         new StandardResourceNameResourceDecorator(),
                         new StandardConstructorResourceDecorator(),
                         new RequestMethodResourceDecorator(typeProvider) { AddOptionalParameters = false },
                     }).AsReadOnly
                    ();
        }

        /// <summary>
        /// Creates a cached web discovery device
        /// </summary>
        internal static IDiscoveryService CreateDefaultCachingDiscovery(string serviceUrl)
        {
            // Set up how discovery works.
            string cacheDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists(cacheDirectory) == false)
            {
                Directory.CreateDirectory(cacheDirectory);
            }
            var webfetcher = new CachedWebDiscoveryDevice(new Uri(serviceUrl), new DirectoryInfo(cacheDirectory));
            return new DiscoveryService(webfetcher);
        }

        /// <summary>
        /// Generates the given service saving to the outputFile in the language passed in.
        /// </summary>
        public static void GenerateService(string serviceName,
                                           string version,
                                           string clientNamespace,
                                           string language,
                                           string outputFile)
        {
            // Generate the discovery URL for that service
            string url = string.Format(GoogleDiscoveryURL, serviceName, version);

            var discovery = CreateDefaultCachingDiscovery(url);
            // Build the service based on discovery information.
            var service = discovery.GetService(DiscoveryVersion.Version_1_0, new FactoryParameters());

            var generator = new GoogleServiceGenerator(service, clientNamespace);
            var generatedCode = generator.GenerateCode();

            var provider = CodeDomProvider.CreateProvider(language);

            using (StreamWriter sw = new StreamWriter(outputFile, false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, "  ");

                // Generate source code using the code provider.
                provider.GenerateCodeFromCompileUnit(generatedCode, tw, new CodeGeneratorOptions());

                // Close the output file.
                tw.Close();
            }
        }

        [VisibleForTestOnly]
        internal CodeNamespace GenerateSchemaCode()
        {
            if (schemaGenerator != null)
            {
                return schemaGenerator.GenerateSchemaClasses(service);
            }
            return null;
        }

        [VisibleForTestOnly]
        internal CodeNamespace GenerateClientCode()
        {
            var clientNamespace = CreateNamespace(codeClientNamespace);
            AddClientUsings(clientNamespace);

            ResourceContainerGenerator resourceContainerGenerator =
                new ResourceContainerGenerator(resourceContainerDecorators);
            var requestClassGenerator = new RequestClassGenerator(
                GetSchemaAwareCommonRequestDecorators(DataNamespace(codeClientNamespace), service),
                GetSchemaAwareRequestDecorators(DataNamespace(codeClientNamespace), service),
                GetSchemaAwareUploadDecorators(DataNamespace(codeClientNamespace), service));

            var serviceClass =
                new ServiceClassGenerator(service, serviceDecorators, resourceContainerGenerator).CreateServiceClass();
            string serviceClassName = serviceClass.Name;

            clientNamespace.Types.Add(serviceClass);
            CreateResources(
                clientNamespace, serviceClassName, service, requestClassGenerator, resourceContainerGenerator);

            return clientNamespace;
        }

        /// <summary>
        /// Generates the code for this service
        /// </summary>
        public CodeCompileUnit GenerateCode()
        {
            logger.Debug("Starting Code Generation...");
            LogDecorators();

            var compileUnit = new CodeCompileUnit();

            

            var schemaCode = GenerateSchemaCode();
            if (schemaCode != null)
            {
                compileUnit.Namespaces.Add(schemaCode);
            }

            compileUnit.Namespaces.Add(GenerateClientCode());

            logger.Debug("Generation Complete.");
            return compileUnit;
        }

        private void CreateResources(CodeNamespace clientNamespace,
                                     string serviceClassName,
                                     IResource resource,
                                     RequestClassGenerator requestClassGenerator,
                                     ResourceContainerGenerator resourceContainerGenerator)
        {
            foreach (var res in resource.Resources.Values.Concat(resource))
            {
                // Create the current list of used names.
                IEnumerable<string> usedNames = resource.Resources.Keys;

                // Create a class for the resource.
                logger.Debug("Adding Resource {0}", res.Name);
                var resourceGenerator = new ResourceClassGenerator(
                    res, serviceClassName, resourceDecorators, requestClassGenerator, resourceContainerGenerator,
                    usedNames);
                var generatedClass = resourceGenerator.CreateClass();
                clientNamespace.Types.Add(generatedClass);
            }
        }

        private void LogDecorators()
        {
            if (logger.IsDebugEnabled)
            {
                logger.Debug("With Service Decorators:");
                foreach (IServiceDecorator dec in serviceDecorators)
                {
                    logger.Debug(">>>>" + dec);
                }
                logger.Debug("With Resource Decorators:");
                foreach (IResourceDecorator dec in resourceDecorators)
                {
                    logger.Debug(">>>>" + dec);
                }
                logger.Debug("With Resource Container Decorators:");
                foreach (IResourceContainerDecorator dec in resourceContainerDecorators)
                {
                    logger.Debug(">>>>" + dec);
                }
            }
        }

        private CodeNamespace CreateNamespace(string nameSpace)
        {
            return new CodeNamespace(nameSpace);
        }

        private void AddClientUsings(CodeNamespace codeNamespace)
        {
            codeNamespace.Imports.Add(new CodeNamespaceImport("System"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.IO"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("System.Collections.Generic"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("Google.Apis"));
            codeNamespace.Imports.Add(new CodeNamespaceImport("Google.Apis.Discovery"));
        }

        private static string DataNamespace(string clientNamespace)
        {
            return clientNamespace + DataNamespaceExtension;
        }
    }
}