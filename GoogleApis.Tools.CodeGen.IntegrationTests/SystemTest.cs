/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen;
using Google.Apis.Tools.CodeGen.Generator;
using log4net;
using Newtonsoft.Json;
using NUnit.Framework;

namespace GoogleApis.Tools.CodeGen.IntegrationTests
{
    /// <summary>
    /// This test fixture will test the full procedure of:
    /// - Discovering discovery.
    /// - CodeGenerating discovery.
    /// - Executing the List function of discovery on the generated lib.
    /// - Discovering each listed service.
    /// - Generating each listed service.
    /// - Compiling the generated file of each service.
    /// </summary>
    [TestFixture]
    public class SystemTest
    {
        private class API
        {
            public string Title { get; set; }
            public string Name { get; set; }
            public string Version { get; set; }
        }

        private static readonly ILog Logger = LogManager.GetLogger(typeof(SystemTest));

        #region Test Helper methods

        private static IService DiscoverService(string serviceName, string serviceVersion)
        {
            // Create the discovery URL
            var discoveryURL = string.Format(GoogleServiceGenerator.GoogleDiscoveryURL, serviceName, serviceVersion);
            var device = new CachedWebDiscoveryDevice(new Uri(discoveryURL));

            // Discover the servi2ce using the hand-coded discovery service
            var discovery = new DiscoveryService(device);
            return discovery.GetService(serviceVersion, DiscoveryVersion.Version_1_0);
        }

        private static Assembly CompileLibrary(Func<CompilerParameters, CodeDomProvider, CompilerResults> compile,
                                        params string[] furtherReferences)
        {
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var cp = new CompilerParameters();

            // Add all referenced assemblies of the CodeGen to this lib
            foreach (Type type in new[] { typeof(IService), typeof(LogManager), typeof(JsonConverter) })
            {
                var name = type.Assembly.GetName();
                cp.ReferencedAssemblies.Add(name.CodeBase.Replace("file:///", ""));
            }
            cp.ReferencedAssemblies.Add("System.dll");
            cp.ReferencedAssemblies.Add("System.Web.dll");
            cp.ReferencedAssemblies.AddRange(furtherReferences);

            // Run the compiler
            CompilerResults results = compile(cp, provider);

            if (results.Errors.HasErrors)
            {
                string[] errors = (from CompilerError e in results.Errors select e.ToString()).ToArray();
                string errorMessage = String.Join(Environment.NewLine, errors);
                throw new ArgumentException("Compilation has failed: " + Environment.NewLine + errorMessage);
            }

            return results.CompiledAssembly;
        }

        private static T ExecuteCommands<T>(Assembly toInclude, string returnValueType, params string[] commands)
        {
            // Build the environment
            var env = new StringBuilder();
            env.AppendLine("using System;");
            env.AppendLine("using System.Web;");
            env.AppendLine("using System.Net;");
            env.AppendLine("using System.Collections;");
            env.AppendLine("using System.Collections.Generic;");
            env.AppendLine("using System.Text;");
            env.AppendLine("using Google.Apis.Discovery;");
            env.AppendLine("using log4net;");
            env.AppendLine("using Newtonsoft.Json;");
            env.AppendLine("");
            env.AppendLine("public class GeneratedClass {");
            {
                env.AppendLine(
                    string.Format("public static {0} GeneratedMethod() {{", returnValueType ?? typeof(T).FullName));
                {
                    foreach (var line in commands)
                    {
                        env.AppendLine(line);
                    }
                }
                env.AppendLine("}");
            }
            env.AppendLine("}");

            // Compile the code
            string furtherReferences = toInclude.GetName().CodeBase.Replace("file:///", "");
            Assembly generatedAssembly =
                CompileLibrary(
                    (cp, provider) => provider.CompileAssemblyFromSource(cp, env.ToString()), furtherReferences);
            Assert.NotNull(generatedAssembly);

            // Run the code
            MethodInfo genMethod = generatedAssembly.GetType("GeneratedClass").GetMethod("GeneratedMethod");
            return (T)genMethod.Invoke(null, BindingFlags.Static, null, null, null);
        }

        private static CodeCompileUnit CodegenService(IService service)
        {
            // Generate the service
            var generator = new GoogleServiceGenerator(service, "Generated");
            CodeCompileUnit generatedCode = generator.GenerateCode();
            return generatedCode;
        }

        private static Assembly CompileService(CodeCompileUnit generatedCode)
        {
            // Compile the code
            var assembly = CompileLibrary((cp, provider) => provider.CompileAssemblyFromDom(cp, generatedCode));
            return assembly;
        }

        private static Assembly TestService(API api)
        {
            Logger.Debug("Testing service: " + api.Title);

            // Discover the service
            IService service = DiscoverService(api.Name, api.Version);

            // Codegen the service
            CodeCompileUnit code = CodegenService(service);

            // Compile the service
            Assembly asm = CompileService(code);

            // Return the result
            return asm;
        }

        #endregion

        #region Test contents

        private static IService DiscoverDiscovery()
        {
            return DiscoverService("discovery", "v1");
        }

        private static Assembly CodegenDiscovery(IService discovery)
        {
            // Generate discovery.
            CodeCompileUnit code = CodegenService(discovery);
            return CompileService(code);
        }

        private static API[] DiscoveryListServices(Assembly discovery)
        {
            // Build the command.
            var code = new StringBuilder();
            code.AppendLine("Generated.DiscoveryService service = new Generated.DiscoveryService();");
            code.AppendLine("Generated.Data.DirectoryList list = service.Apis.List(null, null, null).Fetch();");

            code.AppendLine(
                string.Format(
                    "foreach (Generated.Data.DirectoryList.Items{0} item in list.Items) {{",
                    ImplementationDetailsGenerator.PropertyClassSuffix));
            {
                code.AppendLine("yield return new string[]");
                code.AppendLine("   { item.Title, item.Name, item.Version };");
            }
            code.AppendLine("}");

            // Execute the code.
            IEnumerable<string[]> apiList = ExecuteCommands<IEnumerable<string[]>>(
                discovery, "IEnumerable<string[]>", code.ToString());

            Assert.IsNotNull(apiList);

            // Fetch API list.
            API[] apis = apiList.Select(api => new API { Title = api[0], Name = api[1], Version = api[2] }).ToArray();
            return apis;
        }

        #endregion

        /// <summary>
        /// Tries to discover discovery.
        /// </summary>
        [Test]
        public void DiscoverDiscoveryTest()
        {
            IService discovery = DiscoverDiscovery();
            Assert.IsNotNull(discovery, "Discovery could not be discovered");
            Assert.That(discovery.Name, Is.EqualTo("discovery"));
        }

        /// <summary>
        /// Tries to code generate discovery.
        /// </summary>
        [Test]
        public void CodegenDiscoveryTest()
        {
            // Discover discovery.
            IService discovery = DiscoverDiscovery();

            // Generate discovery.
            Assembly generatedCode = CodegenDiscovery(discovery);
            Assert.IsNotNull(generatedCode, "No code was generated by the code generator");
        }

        /// <summary>
        /// Tries to list all services available on discovery.
        /// </summary>
        [Test]
        public void DiscoveryListServicesTest()
        {
            // Discover discovery.
            IService discovery = DiscoverDiscovery();

            // Generate discovery.
            Assembly discoveryAssembly = CodegenDiscovery(discovery);

            // Call the .List method.
            API[] apis = DiscoveryListServices(discoveryAssembly);
            Assert.That(apis.Length, Is.GreaterThan(0));
        }

        /// <summary>
        /// Runs the code generator on all discovered services.
        /// </summary>
        [Test]
        public void CodegenAllServicesTest()
        {
            // Discover discovery.
            IService discovery = DiscoverDiscovery();

            // Generate discovery.
            Assembly discoveryAssembly = CodegenDiscovery(discovery);

            // Call the .List method.
            API[] apis = DiscoveryListServices(discoveryAssembly);

            // Run the generator.
            List<Exception> exceptions = new List<Exception>();
            List<string> failedAPIs = new List<string>();
            foreach (API api in apis)
            {
                try
                {
                    Assert.NotNull(TestService(api));
                }
                catch (Exception e)
                {
                    // Catch all exceptions, and throw them together.
                    failedAPIs.Add(api.Name);
                    exceptions.Add(e);
                }
            }

            // Create the error message.
            if (exceptions.Count > 0)
            {
                var message = new StringBuilder();
                message.AppendLine(
                    string.Format("Failed to generate {0} out of {1} APIs:", failedAPIs.Count, apis.Length));
                message.AppendLine(String.Join(", ", failedAPIs.ToArray()));
                message.AppendLine();

                int i = 0;
                int j = 0;
                var msgs = failedAPIs.Join(
                    exceptions, str => i++, ex => j++, (str, ex) => new { API = str, Exception = ex });
                foreach (var entries in msgs)
                {
                    message.AppendLine(string.Format("API '{0}' failed with:", entries.API));
                    message.AppendLine(string.Format("   {0}", entries.Exception));
                }

                Assert.Fail(message.ToString());
            }
        }
    }
}