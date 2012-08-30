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

using System.CodeDom;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Tests for the ServiceRequestInheritanceDecorator.
    /// </summary>
    [TestFixture]
    public class ServiceRequestInheritanceDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ServiceRequestInheritanceDecorator(
                new DefaultObjectTypeProvider("Schema")));
        }

        /// <summary>
        /// Confirms that the decorator adds the ServiceRequest inheritance.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new ServiceRequestInheritanceDecorator(
                new DefaultObjectTypeProvider("Schema"));
            var resource = new MockResource();
            var method = new MockMethod() { ResponseType = "MySchema" };
            var decl = new CodeTypeDeclaration();
            var resourceDecl = new CodeTypeDeclaration();

            // Check for ": ServiceRequest<Schema.MySchema>".
            decorator.DecorateClass(resource, method, decl, resourceDecl);
            Assert.AreEqual(1, decl.BaseTypes.Count);
            Assert.AreEqual(typeof(ServiceRequest<>).FullName, decl.BaseTypes[0].BaseType);
            Assert.AreEqual(1, decl.BaseTypes[0].TypeArguments.Count);
            Assert.AreEqual("Schema.MySchema", decl.BaseTypes[0].TypeArguments[0].BaseType);
        }
    }
}
