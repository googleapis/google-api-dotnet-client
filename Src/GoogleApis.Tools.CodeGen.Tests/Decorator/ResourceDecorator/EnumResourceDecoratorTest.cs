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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the EnumResourceDecorator class.
    /// </summary>
    [TestFixture]
    public class EnumResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new EnumResourceDecorator());
        }

        /// <summary>
        /// Tests the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            // Test that this decorator does not throw an exception.
            CodeTypeDeclaration decoratedClass = CreateDecoratedResourceClass(new EnumResourceDecorator());

            // Generation of enum is tested within the DecoratorUtilTest.
            var query = (from CodeTypeDeclaration m in decoratedClass.Members where m.IsEnum select m);
            Assert.AreEqual(1, query.Count());

            // Check the generated enum type.
            CodeTypeDeclaration enumType = query.Single();
            Assert.AreEqual(3, enumType.Members.Count);
        }

        /// <summary>
        /// Tests the GenerateEnum method.
        /// </summary>
        [Test]
        public void GenerateEnumTest()
        {
            const string name = "TestEnum";
            const string desc = "TestDescription";
            string[] elems = new[] { "ElemA", "ElemB", "ElemC" };
            string[] elemDescriptions = new[] { "DescA", "DescB", "DescC" };
            var typeDecl = new CodeTypeDeclaration();

            // Check that the method validates its inputs.
            Assert.Throws<ArgumentNullException>(
                () => EnumResourceDecorator.GenerateEnum(null, name, desc, elems, elemDescriptions));
            Assert.Throws<ArgumentNullException>(
                () => EnumResourceDecorator.GenerateEnum(typeDecl, null, desc, elems, elemDescriptions));
            Assert.Throws<ArgumentNullException>(
                () => EnumResourceDecorator.GenerateEnum(typeDecl, name, desc, null, elemDescriptions));

            // Check that the generated enumeration contains all elements.
            CodeTypeDeclaration decl = EnumResourceDecorator.GenerateEnum(typeDecl, name, desc, elems, elemDescriptions);
            Assert.AreEqual(name, decl.Name);
            Assert.IsTrue(decl.IsEnum);
            Assert.AreEqual(1, decl.Comments.Count);

            Assert.AreEqual(3, decl.Members.Count);
            Assert.AreEqual("ElemA", decl.Members[0].Name);
            Assert.AreEqual("ElemB", decl.Members[1].Name);
            Assert.AreEqual("ElemC", decl.Members[2].Name);

            Assert.AreEqual(1, decl.Members[0].Comments.Count);
            Assert.AreEqual(1, decl.Members[1].Comments.Count);
            Assert.AreEqual(1, decl.Members[2].Comments.Count);

            // Check that the code does not fail when no comments are provided
            decl = EnumResourceDecorator.GenerateEnum(typeDecl, name, desc, elems, null);
            Assert.IsNotNull(decl);
        }

    }
}
