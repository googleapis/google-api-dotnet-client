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

using System.Reflection;
using Google.Apis.Discovery;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.IntegrationTests.Core
{
    /// <summary>
    /// Tests the integration of the "Service" classes.
    /// </summary>
    public class ServiceTests : BaseIntegrationTest
    {
        /// <summary>
        /// Tests the CoreLibrary with a service which has methods declared on the service itsef.
        /// </summary>
        [Test]
        public void MethodOnServiceTest()
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
                    ""schemas"": { },
                    ""methods"": {
                        ""doTest"": {
                            ""id"": ""doTest"",
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
            IService service = GetService(JSON);
            Assert.AreEqual(1, service.Methods.Count);
            Assert.AreEqual("GET", service.Methods["doTest"].HttpMethod);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual(0, service.Resources["myclass"].Resources.Count);
            Assert.AreEqual(1, service.Resources["myclass"].Methods.Count);
        }
    }
}
