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
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the ScopeEnumDecorator.
    /// </summary>
    [TestFixture]
    public class ScopeEnumDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ScopeEnumDecorator());
        }

        /// <summary>
        /// Tests the decorate class method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new ScopeEnumDecorator();
            var service = new MockService();
            var decl = new CodeTypeDeclaration();

            // Confirm that no enumeration is added if 0 scopes are available.
            decorator.DecorateClass(service, decl);
            Assert.AreEqual(0, decl.Members.Count);

            // Confirm that an enumeration is added if scopes are available.
            service.Scopes.Add("a", new Scope { ID = "a", Description = "description A" });
            service.Scopes.Add("b", new Scope { ID = "b", Description = "description B" });
            decorator.DecorateClass(service, decl);
            Assert.AreEqual(1, decl.Members.Count);
            Assert.IsInstanceOf<CodeTypeDeclaration>(decl.Members[0]);

            CodeTypeDeclaration enumType = decl.Members[0] as CodeTypeDeclaration;
            Assert.IsNotNull(enumType);
            Assert.IsTrue(enumType.IsEnum);
            Assert.AreEqual(ScopeEnumDecorator.EnumName, enumType.Name);
        }

        /// <summary>
        /// Tests whether the generated code compiles or not.
        /// </summary>
        [Test]
        public void CompileTest()
        {
            var decorator = new ScopeEnumDecorator();
            var service = new MockService();
            var decl = new CodeTypeDeclaration("TestClass");

            // Test with a simple scope enumeration
            service.Scopes.Add("a", new Scope { ID = "a", Description = "description A" });
            service.Scopes.Add("b", new Scope { ID = "b", Description = "description B" });

            Scope complex = new Scope() { ID = "https://example.com/test/auth123" };
            service.Scopes.Add(complex.ID, complex);

            decorator.DecorateClass(service, decl);
            CheckCompile(decl, false, "Failed To Compile ScopeEnumDecorator");
        }

        /// <summary>
        /// Confirms that the GenerateScopeEnumeration method returns an appropriate enum.
        /// </summary>
        [Test]
        public void GenerateScopeEnumerationTest()
        {
            // Test an empty enumeration:
            CodeTypeDeclaration decl = ScopeEnumDecorator.GenerateScopeEnumeration(Enumerable.Empty<Scope>());
            Assert.IsTrue(decl.IsEnum);
            Assert.AreEqual(0, decl.Members.Count);
            Assert.AreEqual(0, decl.Members.Count);

            // Test a enumeration with two elements:
            Scope[] scopes = new[]
                                 {
                                     new Scope { ID = "FO_BA" }, new Scope { ID = "b", Description = "b description" },
                                     new Scope { ID = "https://example.com/test" }
                                 };
            decl = ScopeEnumDecorator.GenerateScopeEnumeration(scopes);
            Assert.AreEqual(3, decl.Members.Count);
            Assert.AreEqual("FO_BA", decl.Members[0].Name);
            Assert.AreEqual("B", decl.Members[1].Name);
            Assert.AreEqual("Test", decl.Members[2].Name);
            Assert.AreEqual(1, decl.Members[0].CustomAttributes.Count);
        }

        /// <summary>
        /// Confirms the generated names of the GetValueName 
        /// </summary>
        [Test]
        public void GetValueNameTest()
        {
            Assert.Throws<ArgumentNullException>(() => ScopeEnumDecorator.GetValueName(null));
            Assert.Throws<ArgumentNullException>(() => ScopeEnumDecorator.GetValueName(new Scope()));
            Assert.AreEqual("test", ScopeEnumDecorator.GetValueName(new Scope { ID = "test" }));
            Assert.AreEqual("123/456/678", ScopeEnumDecorator.GetValueName(new Scope { ID = "123/456/678" }));
            Assert.AreEqual(
                "http://example.com/", ScopeEnumDecorator.GetValueName(new Scope { ID = "http://example.com/" }));
            Assert.AreEqual("test", ScopeEnumDecorator.GetValueName(new Scope { ID = "http://example.com/test" }));
            Assert.AreEqual(
                "http://example.com/te", ScopeEnumDecorator.GetValueName(new Scope { ID = "http://example.com/te" }));
            Assert.AreEqual(
                "test", ScopeEnumDecorator.GetValueName(new Scope { ID = "http://example.com/auth/test" }));
            Assert.AreEqual(
                "test", ScopeEnumDecorator.GetValueName(new Scope { ID = "http://example.com/auth/scopes/test" }));
        }
    }
}