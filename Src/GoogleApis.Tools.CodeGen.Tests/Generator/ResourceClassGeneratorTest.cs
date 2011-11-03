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

using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using NUnit.Framework;
using Moq;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Test cases for the ResourceContainerGenerator.
    /// </summary>
    [TestFixture]
    public class ResourceClassGeneratorTest
    {
        private class CountingDecorator : IResourceDecorator
        {
            public int Count { get; set; }

            #region IResourceDecorator Members

            public void DecorateClass(IResource resource,
                                      string className,
                                      CodeTypeDeclaration resourceClass,
                                      ResourceClassGenerator generator,
                                      string serviceClassName,
                                      IEnumerable<IResourceDecorator> allDecorators)
            {
                Count++;
            }

            public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

            public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember) {}

            #endregion
        }

        private static ResourceContainerGenerator ConstructContainerGenerator()
        {
            return new ResourceContainerGenerator(GoogleServiceGenerator.StandardResourceContainerDecorator);
        }

        private static RequestClassGenerator ConstructRequestGenerator()
        {
            var mockService = new Mock<IService>();
            mockService
              .Setup(m => m.Parameters)
              .Returns(() => null);

            return new RequestClassGenerator(
              GoogleServiceGenerator.GetSchemaAwareRequestDecorators("Generated", mockService.Object));
        }


        private ResourceClassGenerator ConstructGenerator(IResource resource,
                                                          params IResourceDecorator[] additionalDecorators)
        {
            return new ResourceClassGenerator(
                resource, "TestService", additionalDecorators, ConstructRequestGenerator(),
                ConstructContainerGenerator(), Enumerable.Empty<string>());
        }

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => ConstructContainerGenerator());
            Assert.DoesNotThrow(
                () =>
                ConstructGenerator(
                    new MockResource { Name = "TestResource" }, new CountingDecorator(),
                    new SubresourceClassDecorator()));
        }

        /// <summary>
        /// Confirms that the generator can create a simple resource class.
        /// </summary>
        [Test]
        public void GenerationTest()
        {
            var resource = new MockResource();
            resource.Name = "Test";
            resource.Methods.Add(
                "TestMethod", new MockMethod { Name = "TestMethod", HttpMethod = "GET", ResponseType = "int" });

            // Run the generator.
            var counter = new CountingDecorator();
            var generator = ConstructGenerator(resource, counter, new SubresourceClassDecorator());
            CodeTypeDeclaration clss = generator.CreateClass();
            Assert.IsNotNull(clss);
            Assert.AreEqual("TestResource", clss.Name);

            // Confirm that decorators have run.
            Assert.AreEqual(1, counter.Count);
        }

        /// <summary>
        /// Confirms that subresources are generated as nested classes.
        /// </summary>
        [Test]
        public void SubresourceGenerationTest()
        {
            var subresource = new MockResource();
            subresource.Name = "Sub";

            var resource = new MockResource();
            resource.Name = "Test";
            resource.Resources .Add(new KeyValuePair<string, IResource>("Sub", subresource));

            // Run the generator.
            var counter = new CountingDecorator();
            var generator = ConstructGenerator(resource, counter, new SubresourceClassDecorator());
            CodeTypeDeclaration clss = generator.CreateClass();
            Assert.IsNotNull(clss);
            Assert.AreEqual(2, counter.Count);

            // Confirm that a subclass has been added.
            var subtypes = from CodeTypeMember m in clss.Members where (m is CodeTypeDeclaration) select m;
            Assert.AreEqual(1, subtypes.Count());
            Assert.AreEqual("SubResource", subtypes.First().Name);
        }
    }
}