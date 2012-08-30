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
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Tests for the RequestClass generator.
    /// </summary>
    [TestFixture]
    public class RequestClassGeneratorTest
    {
        private class CountingRequestDecorator : IRequestDecorator
        {
            public int TimesCalled { get; private set; }

            public void DecorateClass(IResource resource,
                                      IMethod request,
                                      CodeTypeDeclaration requestClass,
                                      CodeTypeDeclaration resourceClass)
            {
                TimesCalled++;
            }
        }

        /// <summary>
        /// Tests the constructor of the request class generator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new RequestClassGenerator(Enumerable.Empty<IRequestDecorator>()));
        }

        /// <summary>
        /// Confirms that request classes are generated for all methods in the resource.
        /// </summary>
        [Test]
        public void GenerateRequestClassesTest()
        {
            var decorator = new CountingRequestDecorator();
            var generator = new RequestClassGenerator(new IRequestDecorator[] { decorator });
            var decl = new CodeTypeDeclaration();

            // Create a test resource.
            var resource = new MockResource();
            resource.Methods.Add("MethodA", new MockMethod() { Name = "MethodA"});
            resource.Methods.Add("MethodB", new MockMethod() { Name = "MethodB"});

            // Run the generator
            CodeTypeMemberCollection collection = generator.GenerateRequestClasses(decl, resource);
            Assert.AreEqual(2, decorator.TimesCalled);
            Assert.AreEqual(2, collection.Count);
            Assert.IsInstanceOf<CodeTypeDeclaration>(collection[0]);
            Assert.IsInstanceOf<CodeTypeDeclaration>(collection[1]);
            CollectionAssert.AreEqual(
                new[]
                    {
                        string.Format(RequestClassGenerator.RequestClassNamingScheme, "MethodA"),
                        string.Format(RequestClassGenerator.RequestClassNamingScheme, "MethodB"),
                    },
                from CodeTypeMember m in collection select m.Name);
        } 

        private class MockRequestDecorator : IRequestDecorator
        {
            private string memberName;

            public MockRequestDecorator(string memberName)
            {
                this.memberName = memberName;
            }

            public void DecorateClass(IResource resource,
                                      IMethod request,
                                      CodeTypeDeclaration requestClass,
                                      CodeTypeDeclaration resourceClass)
            {
                requestClass.Members.Add(new CodeTypeMember { Name = memberName });
            }
        }

        /// <summary>
        /// Confirms that the decorators of the RequestClassGenerator are executed in order.
        /// </summary>
        [Test]
        public void GenerateRequestClassDecoratorOrderTest()
        {
            var generator =
                new RequestClassGenerator(
                    new IRequestDecorator[]
                        {
                            new MockRequestDecorator("One"), new MockRequestDecorator("Two"),
                            new MockRequestDecorator("Three")
                        });
            var decl = new CodeTypeDeclaration();
            var resource = new MockResource();
            var method = new MockMethod();

            // Check the order of the generated members.
            var genClass = generator.GenerateRequestClass(resource, method, decl, Enumerable.Empty<string>());
            Assert.AreEqual(3, genClass.Members.Count);
            Assert.AreEqual("One", genClass.Members[0].Name);
            Assert.AreEqual("Two", genClass.Members[1].Name);
            Assert.AreEqual("Three", genClass.Members[2].Name);
        }

        /// <summary>
        /// Confirms that the GenerateRequestClass method generates a valid request class.
        /// </summary>
        [Test]
        public void GenerateRequestClassTest()
        {
            var decorator = new CountingRequestDecorator();
            var generator = new RequestClassGenerator(new IRequestDecorator[] { decorator });
            var decl = new CodeTypeDeclaration();

            // Create a test resource.
            var resource = new MockResource();
            MockMethod method = new MockMethod() { Name = "MethodA" };
            resource.Methods.Add("MethodA", method);

            // Run the generator
            CodeTypeDeclaration newClass = generator.GenerateRequestClass(resource, method, decl, new string[0]);
            Assert.IsNotNull(newClass);
            Assert.AreEqual(1, decorator.TimesCalled);
            Assert.AreEqual(0, newClass.Members.Count);
        }

        /// <summary>
        /// Confirms that the string returned from GetProposedName fits the intended standard.
        /// </summary>
        [Test]
        public void GetProposedNameTest()
        {
            Assert.AreEqual("TestRequest", RequestClassGenerator.GetProposedName(
                new MockMethod() { Name = "Test"},
                RequestClassGenerator.RequestClassNamingScheme));
            Assert.AreEqual("AbcRequest", RequestClassGenerator.GetProposedName(
                new MockMethod() { Name = "abc" },
                RequestClassGenerator.RequestClassNamingScheme));
        }
    }
}
