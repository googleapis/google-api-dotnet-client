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
using System.Reflection;
using Google.Apis.Discovery;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.IntegrationTests
{
    /// <summary>
    /// Integration test for the CodeGenerator.
    /// Tests whether certain services can be generated. Tests special use-cases.
    /// 
    /// Tests:
    /// - The CodeGenerator project.
    /// - The Integration of the CodeGenerator with the CoreLibrary.
    /// </summary>
    [TestFixture]
    public class CodegenTest : BaseIntegrationTest
    {
        private static IService GetService(string discoveryJson)
        {
            // Create the discovery document fetcher.
            var device = new StringDiscoveryDevice { Document = discoveryJson };

            // Discover the service using the hand-coded discovery service.
            var discovery = new DiscoveryService(device);
            return discovery.GetService(DiscoveryVersion.Version_1_0);
        }

        /// <summary>
        /// Generates and compiles a service from its json discovery document.
        /// </summary>
        /// <param name="discoveryJson">The discovery document of this service.</param>
        /// <returns>Compiled codegen service.</returns>
        private static Assembly GenerateService(string discoveryJson)
        {
            IService service = GetService(discoveryJson);
            CodeCompileUnit code = CodegenService(service);
            return CompileCodeUnit(code);
        }

        /// <summary>
        /// Tests the CodeGenerator with a service which has no schemas declared.
        /// </summary>
        [Test]
        public void NoSchemaServiceTest()
        {
            const string JSON =
                @"{
                    ""kind"": ""discovery#restDescription"",
                    ""id"": ""testService:v1"",
                    ""name"": ""testService"",
                    ""version"": ""v1"",
                    ""description"": ""A test service"",
                    ""protocol"": ""rest"",
                    ""basePath"": ""https://example.com/basePath/"",
                    ""resources"": {
                        ""myclass"": {
                            ""methods"": {
                                ""get"": {
                                    ""id"": ""myclass.get"",
                                    ""path"": ""get/{id}"",
                                    ""httpMethod"": ""GET"",
                                    ""parameters"": {
                                        ""id"": {
                                            ""type"": ""string"",
                                            ""required"": true,
                                            ""location"": ""path""
                                        }
                                    }
                                }
                            }
                        }
                    }
                }";
            
            // Generate this service.
            Assembly generatedAssembly = GenerateService(JSON);
            Assert.IsNotNull(generatedAssembly);
        }

        /// <summary>
        /// Tests the CodeGenerator with a service providing a simple schema.
        /// </summary>
        [Test]
        public void SimpleSchemaServiceTest()
        {
            const string JSON =
                @"{
                    ""kind"": ""discovery#restDescription"",
                    ""id"": ""testService:v1"",
                    ""name"": ""testService"",
                    ""version"": ""v1"",
                    ""description"": ""A test service"",
                    ""protocol"": ""rest"",
                    ""basePath"": ""https://example.com/basePath/"",
                    ""schemas"": {
                        ""TestSchema"": {
                           ""id"": ""TestSchema"",
                           ""type"": ""object"",
                           ""properties"": {
                             ""id"": {
                               ""type"": ""string"",
                               ""description"": ""The ID of this test.""
                             }
                           }
                        }
                    },
                    ""resources"": {
                        ""myclass"": {
                            ""methods"": {
                                ""get"": {
                                    ""id"": ""myclass.get"",
                                    ""path"": ""get/{id}"",
                                    ""httpMethod"": ""GET"",
                                    ""parameters"": {
                                        ""id"": {
                                            ""type"": ""string"",
                                            ""required"": true,
                                            ""location"": ""path""
                                        }
                                    }
                                }
                            }
                        }
                    }
                }";

            // Generate this service.
            Assembly generatedAssembly = GenerateService(JSON);
            Assert.IsNotNull(generatedAssembly);
        }
    }
}
