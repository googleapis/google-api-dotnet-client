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

using System;
using System.CodeDom;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator
{
    /// <summary>
    /// Tests the DecoratorUtil class
    /// </summary>
    [TestFixture]
    public class DecoratorUtilTest
    {
        /// <summary>
        /// Tests edge cases for the AddAutoProperty method
        /// </summary>
        [Test]
        public void AddAutoPropertyEdgeCaseTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";
            const string comment = "Comment";

            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.AddAutoProperty<object>(null, name, comment));
            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, null, comment));
            Assert.Throws<ArgumentException>(() => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, "", comment));
            Assert.DoesNotThrow(() => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, name, null));
        }

        /// <summary>
        /// Tests the AddAutoProperty method
        /// </summary>
        [Test]
        public void AddAutoPropertyTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";
            const string comment = "Comment";

            CodeMemberProperty property = DecoratorUtil.AddAutoProperty<int>(typeDeclaration, name, comment);
            Assert.IsNotNull(property);
            Assert.That(property.Name, Is.EqualTo(name));
            Assert.That(property.Type.BaseType, Is.EqualTo(typeof(int).FullName));

            Assert.That(typeDeclaration.Members.Count, Is.EqualTo(2));
            Assert.That(typeDeclaration.Members[1], Is.InstanceOf<CodeMemberProperty>());
            Assert.That(typeDeclaration.Members[1].Attributes, Is.EqualTo(MemberAttributes.Public));
            Assert.That(typeDeclaration.Members[0], Is.InstanceOf<CodeMemberField>());

            // Backening field is tested in its own unit case

            // Test if an exception is thrown when the name is already used
            Assert.Throws<ArgumentException>(() => DecoratorUtil.AddAutoProperty<bool>(typeDeclaration, name, comment));
        }

        /// <summary>
        /// Tests edge cases for the CreateBackingfield method
        /// </summary>
        [Test]
        public void CreateBackingFieldEdgeCaseTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";

            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackingField<object>(null, name));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackingField<object>(typeDeclaration, null));
            Assert.Throws<ArgumentException>(() => DecoratorUtil.CreateBackingField<object>(typeDeclaration, ""));
        }

        /// <summary>
        /// Tests the generation of backing fields
        /// </summary>
        [Test]
        public void CreateBackingFieldTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";

            CodeMemberField field = DecoratorUtil.CreateBackingField<bool>(typeDeclaration, name);
            Assert.IsNotNull(field);
            Assert.That(field.Name, Is.EqualTo("testProperty"));
            Assert.That(field.Type.BaseType, Is.EqualTo(typeof(bool).FullName));
            Assert.That(field.Attributes, Is.EqualTo(MemberAttributes.Private));
        }
    }
}