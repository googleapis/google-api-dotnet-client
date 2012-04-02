/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Reflection;
using Google;
using Google.Apis.Discovery;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Tools.CodeGen;

namespace GoogleApis.Tools.ServiceGenerator
{
    /// <summary>
    /// The Generator used to generate strongly typed services.
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// The prefix which is used when a Google service is being generated.
        /// </summary>
        private const string GooglePrefix = "Google.Apis.";

        /// <summary>
        /// The directory where the generated files will be put.
        /// </summary>
        public string OutputDir { get; set; }

        /// <summary>
        /// The flags with which this generator was created.
        /// </summary>
        public GeneratorFlags Flags { get; private set; }

        /// <summary>
        /// Creates a new instance of the generator.
        /// </summary>
        public Generator(GeneratorFlags flags)
        {
            OutputDir = "Services";
            Flags = flags;
        }

        /// <summary>
        /// Generates a Google service based upon its name and version.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="serviceVersion">Version of the service.</param>
        /// <param name="outputDir">The directory in which the generated services are put.</param>
        /// <param name="flags">The flags describing the generator settings.</param>
        public void GenerateGoogleService(string serviceName,
                                          string serviceVersion)
        {
            Console.WriteLine("Generating google service...");
            string uri = String.Format(GoogleServiceGenerator.GoogleDiscoveryURL, serviceName, serviceVersion);
            GenerateService(new Uri(uri));
        }

        /// <summary>
        /// Generates the service described by the specified API object.
        /// </summary>
        /// <param name="api">The API to generate.</param>
        public void GenerateService(DirectoryList.ItemsData api)
        {
            GenerateService(new Uri(api.DiscoveryLink));
        }

        /// <summary>
        /// Generates all services in the specified discovery repository.
        /// </summary>
        public void GenerateServices(IEnumerable<DirectoryList.ItemsData> apis)
        {
            Console.WriteLine("Generating services from discovery repository...");
            foreach (DirectoryList.ItemsData api in apis)
            {
                GenerateService(api);
            }
        }

        /// <summary>
        /// Generates a service from the specified discovery uri.
        /// </summary>
        /// <param name="url">The URL or file where the discovery document can be found.</param>
        public void GenerateService(Uri url)
        {
            Console.WriteLine(" Generating: " + url);

            // Create the output directory if it does not exist yet.
            if (!Directory.Exists(OutputDir))
            {
                Directory.CreateDirectory(OutputDir);
            }

            // Discover the service.
            Console.WriteLine("  Fetching " + url);
            IDiscoveryDevice src = url.IsFile
                                       ? (IDiscoveryDevice)
                                         new StreamDiscoveryDevice
                                             {
                                                 DiscoveryStream = File.Open(url.LocalPath, FileMode.Open)
                                             }
                                       : new StringDiscoveryDevice { Document = Utils.FetchDocument(url) };
            var discovery = new DiscoveryService(src);
            IService service = discovery.GetService(DiscoveryVersion.Version_1_0);

            // Generate the formal names based upon the discovery data.
            string name = service.Name;
            string version = service.Version;

            string formalServiceName = GeneratorUtils.UpperFirstLetter(name);
            string serviceNamespace = GeneratorUtils.GetNamespaceName(formalServiceName);
            if ((Flags & GeneratorFlags.GoogleService) > 0) // If this is a google service, add the google prefix.
            {
                formalServiceName = GooglePrefix + formalServiceName;
                serviceNamespace = GooglePrefix + serviceNamespace;
            }

            string baseFileName = Path.Combine(OutputDir, formalServiceName + "." + version);
            string fileName = baseFileName + ".cs";
            string libfileName = baseFileName + ".dll";
            serviceNamespace = String.Format("{0}.{1}", serviceNamespace, GeneratorUtils.GetNamespaceName(version));

            // Produce the code.
            var generator = new GoogleServiceGenerator(service, serviceNamespace);
            CodeCompileUnit generatedCode = generator.GenerateCode();
            WriteCodeToFile(generatedCode, fileName);

            if ((Flags & GeneratorFlags.CompileLibrary) > 0)
            {
                CompileIntoLibrary(service, generatedCode, libfileName);
            }
        }

        /// <summary>
        /// Writes the specified code unit to a .cs source file.
        /// </summary>
        /// <param name="generatedCode"></param>
        /// <param name="targetFile"></param>
        private static void WriteCodeToFile(CodeCompileUnit generatedCode, string targetFile)
        {
            var provider = CodeDomProvider.CreateProvider("CSharp");

            using (StreamWriter sw = new StreamWriter(targetFile, false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, "  ");

                // Generate source code using the code provider.
                provider.GenerateCodeFromCompileUnit(generatedCode, tw, new CodeGeneratorOptions());

                // Close the output file.
                tw.Close();
            }

            Console.WriteLine("  Source generated in '" + targetFile + "'");
        }

        /// <summary>
        /// Compiles the specified code unit into a .dll.
        /// </summary>
        private static void CompileIntoLibrary(IService service, CodeCompileUnit code, string targetFile)
        {
            // Set the AssemblyInfo
            AddAssemblyInfo<AssemblyTitleAttribute>(code, service.Title);
            AddAssemblyInfo<AssemblyCompanyAttribute>(code, "Google Inc");
            AddAssemblyInfo<AssemblyProductAttribute>(code, service.Id);
            AddAssemblyInfo<AssemblyVersionAttribute>(code, typeof(IService).Assembly.GetName().Version.ToString());
            AddAssemblyInfo<AssemblyCopyrightAttribute>(code, "© " + DateTime.UtcNow.Year + " Google Inc");

            // Set up the compiler.
            string xmlDocFile = Path.ChangeExtension(targetFile, ".xml");
            var cp = new CompilerParameters();
            cp.OutputAssembly = targetFile;
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = false;
            cp.ReferencedAssemblies.Add("System.dll");
            cp.IncludeDebugInformation = true;
            cp.CompilerOptions = "/doc:" + xmlDocFile;

            // Add the (third party) references required by the generated code.
            foreach (Type type in new[] { typeof(Newtonsoft.Json.JsonConvert), typeof(GoogleApiException) })
            {
                cp.ReferencedAssemblies.Add(new Uri(type.Assembly.CodeBase).LocalPath);
            }

            // Compile the code into a .dll.
            var provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerResults results = provider.CompileAssemblyFromDom(cp, code);

            if (results.Errors.HasErrors || results.CompiledAssembly == null)
            {
                Console.Error.WriteLine("  Compilation failed!");
                foreach (CompilerError error in results.Errors)
                {
                    Console.Error.WriteLine("{0}:{1} - {2}", error.FileName, error.Line, error.ErrorText);
                }
            }
            else
            {
                Console.Out.WriteLine("  Library generated in '" + targetFile + "'");
                Console.Out.WriteLine("  XML Doc generated in '" + xmlDocFile + "'");
            }
        }
                
        /// <summary>
        /// Adds the specified AssemblyInfo attribute to the code unit.
        /// </summary>
        /// <typeparam name="T">Attribute to add.</typeparam>
        /// <param name="code">Where to add the attribute.</param>
        /// <param name="value">The string value of the attribute.</param>
        private static void AddAssemblyInfo<T>(CodeCompileUnit code, string value) where T : Attribute
        {
            var attrib = new CodeAttributeDeclaration(new CodeTypeReference(typeof(T)));
            attrib.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(value)));
            code.AssemblyCustomAttributes.Add(attrib);
        }
    }

    /// <summary>
    /// Flags for the service-generator.
    /// </summary>
    [Flags]
    public enum GeneratorFlags
    {
        /// <summary>
        /// No special generator flags.
        /// </summary>
        None = 0,

        /// <summary>
        /// Compiles a .dll file after the source code has been generated.
        /// </summary>
        CompileLibrary = 1 << 0,

        /// <summary>
        /// Adds a "Google" prefix to the generated files.
        /// </summary>
        GoogleService = 1 << 1,
    }
}
