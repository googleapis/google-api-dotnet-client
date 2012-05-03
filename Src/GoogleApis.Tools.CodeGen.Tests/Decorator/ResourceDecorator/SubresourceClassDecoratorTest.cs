/*
Copyright 2011 Google Inc

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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceContainerDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the SubresourceClassDecorator.
    /// </summary>
    [TestFixture]
    public class SubresourceClassDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of the SubresourceClassDecorator class.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new SubresourceClassDecorator());
        }

        /// <summary>
        /// Confirms renaming of nested types if the name is already used within the class.
        /// </summary>
        [Test]
        public void DecorateClassRenamingTest()
        {
            var dec = new SubresourceClassDecorator();
            var resource = new MockResource();
            const string className = "TestClass";
            var decl = new CodeTypeDeclaration();
            const string serviceName = "TestService";
            var decorators = new IResourceDecorator[0];

            // Create generators.
            var resourceGen = new ResourceContainerGenerator(new IResourceContainerDecorator[0]);
            var requestGen = new RequestClassGenerator(new IRequestDecorator[0]);
            var gen = new ResourceClassGenerator(
                resource, serviceName, decorators, requestGen, resourceGen, new string[0]);

            // Add subresources.
            resource.Resources.Add("Sub1", new MockResource { Name = "Sub1" });
            resource.Resources.Add("Sub2", new MockResource { Name = "Sub2" });

            // Add existing members
            decl.Members.Add(new CodeMemberField { Name = "Sub1Resource" });

            // Test decoration.
            dec.DecorateClass(resource, className, decl, gen, serviceName, decorators);
            Assert.AreEqual(3, decl.Members.Count);
            Assert.AreEqual("Sub1Resource", decl.Members[0].Name);
            Assert.AreEqual("Sub1Res", decl.Members[1].Name);
            Assert.AreEqual("Sub2Resource", decl.Members[2].Name);
        }

        /// <summary>
        /// Confirms normal operation of the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var dec = new SubresourceClassDecorator();
            var resource = new MockResource();
            const string className = "TestClass";
            var decl = new CodeTypeDeclaration();
            const string serviceName = "TestService";
            var decorators = new IResourceDecorator[0];

            // Create generators.
            var resourceGen = new ResourceContainerGenerator(new IResourceContainerDecorator[0]);
            var requestGen = new RequestClassGenerator(new IRequestDecorator[0]);
            var gen = new ResourceClassGenerator(
                resource, serviceName, decorators, requestGen, resourceGen, new string[0]);

            // Add subresources.
            resource.Resources.Add("Sub1", new MockResource { Name = "Sub1" });
            resource.Resources.Add("Sub2", new MockResource { Name = "Sub2" });

            // Test decoration.
            dec.DecorateClass(resource, className, decl, gen, serviceName, decorators);
            Assert.AreEqual(2, decl.Members.Count);
            Assert.IsInstanceOf<CodeTypeDeclaration>(decl.Members[0]);
            Assert.IsInstanceOf<CodeTypeDeclaration>(decl.Members[1]);
        }

        /// <summary>
        /// Confirms parameter validation of the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassValidationTest()
        {
            var dec = new SubresourceClassDecorator();
            var resource = new MockResource();
            const string className = "TestClass";
            var decl = new CodeTypeDeclaration();
            const string serviceName = "TestService";
            IEnumerable<IResourceDecorator> decorators =
                GoogleServiceGenerator.GetSchemaAwareResourceDecorators("Generated.Data.");

            // Create generators.
            var resourceGen = new ResourceContainerGenerator(
                GoogleServiceGenerator.StandardResourceContainerDecorator);
            var requestGen = new RequestClassGenerator(new IRequestDecorator[0]);
            var gen = new ResourceClassGenerator(
                resource, serviceName, decorators, requestGen, resourceGen, new string[0]);

            // Validate method:
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(null, className, decl, gen, serviceName, decorators));
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(resource, null, decl, gen, serviceName, decorators));
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(resource, className, null, gen, serviceName, decorators));
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(resource, className, decl, null, serviceName, decorators));
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(resource, className, decl, gen, null, decorators));
            Assert.Throws<ArgumentNullException>(
                () => dec.DecorateClass(resource, className, decl, gen, serviceName, null));

            // Test normal use case.
            dec.DecorateClass(resource, className, decl, gen, serviceName, decorators);
        }

        /// <summary>
        /// Confirms operation of the GenerateSubresource method
        /// </summary>
        [Test]
        public void GenerateSubresourceTest()
        {
            var dec = new SubresourceClassDecorator();
            const string serviceName = "TestService";
            var decorators = new IResourceDecorator[0];

            // Create generators.
            var resourceGen = new ResourceContainerGenerator(new IResourceContainerDecorator[0]);
            var requestGen = new RequestClassGenerator(new IRequestDecorator[0]);

            // Test generation of the nested class
            var subresource = new MockResource { Name = "Sub" };
            CodeTypeDeclaration decl = dec.GenerateSubresource(
                subresource, serviceName, decorators, requestGen, resourceGen, new string[0]);

            Assert.IsNotNull(decl);
            Assert.AreEqual(decl.Name, "SubResource");
        }
    }
}