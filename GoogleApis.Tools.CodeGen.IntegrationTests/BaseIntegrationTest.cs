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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Google.Apis.Discovery;
using Microsoft.CSharp;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Google.Apis.Tools.CodeGen.IntegrationTests
{
    /// <summary>
    /// Abstract base class for CodeGeneration Integration Tests.
    /// </summary>
    public abstract class BaseIntegrationTest
    {
        /// <summary>
        /// Compiles a source file into a library by using the specified compile function.
        /// </summary>
        protected static Assembly CompileLibrary(Func<CompilerParameters, CodeDomProvider, CompilerResults> compile,
                                                 params string[] furtherReferences)
        {
            var provider = CodeDomProvider.CreateProvider("CSharp");
            var compilerParameters = new CompilerParameters();

            // Add all referenced assemblies of the CodeGen to this lib.
            foreach (Type type in new[] { typeof(IService), typeof(JsonConverter) })
            {
                compilerParameters.ReferencedAssemblies.Add(GetReferencePathToAssembly(type.Assembly));
            }

            compilerParameters.ReferencedAssemblies.Add("System.dll");
            compilerParameters.ReferencedAssemblies.Add("System.Web.dll");
            compilerParameters.ReferencedAssemblies.AddRange(furtherReferences);

            // Run the compiler.
            CompilerResults results = compile(compilerParameters, provider);

            if (results.Errors.HasErrors)
            {
                string[] errors = (from CompilerError e in results.Errors select e.ToString()).ToArray();
                string errorMessage = String.Join(Environment.NewLine, errors);
                throw new ArgumentException("Compilation has failed: " + Environment.NewLine + errorMessage);
            }

            return results.CompiledAssembly;
        }

        /// <summary>
        /// Returns a compiler-friendly reference path to the specified assembly.
        /// </summary>
        protected static string GetReferencePathToAssembly(Assembly assembly)
        {
            return new Uri(assembly.GetName().CodeBase).LocalPath;
        }

        /// <summary>
        /// Executes the set of commands on the specified assembly.
        /// </summary>
        protected static T ExecuteCommands<T>(Assembly toInclude, string returnValueType, params string[] commands)
        {
            // Build the environment.
            var env = new StringBuilder();
            env.AppendLine("using System;");
            env.AppendLine("using System.Web;");
            env.AppendLine("using System.Net;");
            env.AppendLine("using System.Collections;");
            env.AppendLine("using System.Collections.Generic;");
            env.AppendLine("using System.Text;");
            env.AppendLine("using Google.Apis.Discovery;");
            env.AppendLine("using Newtonsoft.Json;");
            env.AppendLine("");
            env.AppendLine("public class GeneratedClass {");
            {
                env.AppendLine(
                    string.Format("  public static {0} GeneratedMethod() {{", returnValueType ?? typeof(T).FullName));
                {
                    var lines =
                        commands.SelectMany(str => str.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
                    foreach (var line in lines)
                    {
                        env.AppendLine("   "+line);
                    }
                }
                env.AppendLine("  }");
            }
            env.AppendLine("}");

            Assembly generatedAssembly = null;
            try
            {
                // Compile the code.
                string furtherReferences = GetReferencePathToAssembly(toInclude);
                generatedAssembly =
                    CompileLibrary(
                        (cp, provider) => provider.CompileAssemblyFromSource(cp, env.ToString()), furtherReferences);
                Assert.NotNull(generatedAssembly);
            }
            catch (ArgumentException ex)
            {
                string P = Environment.NewLine + Environment.NewLine.PadLeft(15, '-');
                throw new Exception("Failing code:" + P + env + P, ex);
            }

            // Run the code.
            MethodInfo genMethod = generatedAssembly.GetType("GeneratedClass").GetMethod("GeneratedMethod");
            return (T) genMethod.Invoke(null, BindingFlags.Static, null, null, null);
        }

        /// <summary>
        /// Generates the CodeCompileUnit for the specified service by using the CodeGenerator.
        /// </summary>
        protected static CodeCompileUnit CodegenService(IService service)
        {
            // Generate the service.
            var generator = new GoogleServiceGenerator(service, "Generated");
            return generator.GenerateCode();
        }

        /// <summary>
        /// Compiles a code unit into a library.
        /// </summary>
        protected static Assembly CompileCodeUnit(CodeCompileUnit generatedCode)
        {
            // Compile the code
            try
            {
                var assembly = CompileLibrary((cp, provider) => provider.CompileAssemblyFromDom(cp, generatedCode));
                return assembly;
            }
            catch (ArgumentException ex)
            {
                // Get a dump of the C# source code to help with debugging.
                var stringBuilder = new StringBuilder();
                using (StringWriter writer = new StringWriter(stringBuilder))
                {
                    var options = new CodeGeneratorOptions();
                    options.IndentString = "  ";
                    new CSharpCodeProvider().GenerateCodeFromCompileUnit(generatedCode, writer, options);
                }
                string code = stringBuilder.ToString();
                throw new ArgumentException(ex.Message + Environment.NewLine.PadRight(20, '=') + code);
            }
        }

        /// <summary>
        /// Discovers the service described by the specified json
        /// </summary>
        protected static IService GetService(string discoveryJson)
        {
            // Create the discovery document fetcher.
            var device = new StringDiscoveryDevice { Document = discoveryJson };

            // Discover the service using the hand-coded discovery service.
            var discovery = new DiscoveryService(device);
            return discovery.GetService(DiscoveryVersion.Version_1_0);
        }
    }
}
