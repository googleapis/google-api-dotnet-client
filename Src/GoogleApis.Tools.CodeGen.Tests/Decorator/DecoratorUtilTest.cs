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
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator
{
    /// <summary>
    /// Tests the DecoratorUtil class.
    /// </summary>
    [TestFixture]
    public class DecoratorUtilTest
    {
        /// <summary>
        /// Tests edge cases for the AddAutoProperty method.
        /// </summary>
        [Test]
        public void CreateAutoPropertyEdgeCaseTest()
        {
            const string name = "TestProperty";
            const string comment = "Comment";
            CodeTypeReference type = new CodeTypeReference(typeof(object));
            string[] usedWords = new string[] { };

            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.CreateAutoProperty(null, comment, type, usedWords, false));
            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.CreateAutoProperty(name, comment, null, usedWords, false));
            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.CreateAutoProperty(name, comment, type, null, false));
            Assert.DoesNotThrow(() => DecoratorUtil.CreateAutoProperty(name, null, type, usedWords, false));
        }

        /// <summary>
        /// Tests the AddAutoProperty method.
        /// </summary>
        [Test]
        public void CreateAutoPropertyTest()
        {
            const string name = "TestProperty";
            const string comment = "Comment";
            CodeTypeReference type = new CodeTypeReference(typeof(int));
            string[] usedWords = new string[] { };

            CodeTypeMemberCollection col = DecoratorUtil.CreateAutoProperty(name, comment, type, usedWords, false);

            Assert.That(col.Count, Is.EqualTo(2));
            Assert.That(col[1], Is.InstanceOf<CodeMemberProperty>());
            Assert.That(col[1].Attributes, Is.EqualTo(MemberAttributes.Public));
            Assert.That(col[0], Is.InstanceOf<CodeMemberField>());

            var property = col[1] as CodeMemberProperty;
            Assert.IsNotNull(property);
            Assert.That(property.Name, Is.EqualTo(name));
            Assert.That(property.Type.BaseType, Is.EqualTo(typeof(int).FullName));

            // Backening field is tested in its own unit case.
        }

        /// <summary>
        /// Tests edge cases for the CreateBackingfield method.
        /// </summary>
        [Test]
        public void CreateBackingFieldEdgeCaseTest()
        {
            const string name = "TestProperty";
            CodeTypeReference type = new CodeTypeReference(typeof(object));
            string[] usedWords = new string[] {};

            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackingField(null, type, usedWords));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackingField(name, null, usedWords));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackingField(name, type, null));
        }

        /// <summary>
        /// Tests the generation of backing fields.
        /// </summary>
        [Test]
        public void CreateBackingFieldTest()
        {
            const string name = "TestProperty";
            CodeTypeReference type = new CodeTypeReference(typeof(bool));
            string[] usedWords = new string[] { };

            CodeMemberField field = DecoratorUtil.CreateBackingField(name, type, usedWords);
            Assert.IsNotNull(field);
            Assert.That(field.Name, Is.EqualTo("_TestProperty"));
            Assert.That(field.Type.BaseType, Is.EqualTo(typeof(bool).FullName));
            Assert.That(field.Attributes, Is.EqualTo(MemberAttributes.Private));
        }

        /// <summary>
        /// Tests the creation of a simple comment.
        /// </summary>
        [Test]
        public void CreateSummaryCommentTest()
        {
            string aShortDescription = "A Short description for test";
            var result = DecoratorUtil.CreateSummaryComment(aShortDescription);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsNotNull(result[0].Comment);
            Assert.AreEqual(true, result[0].Comment.DocComment);
            Assert.AreEqual("<summary>" + aShortDescription + "</summary>", result[0].Comment.Text);
        }
        /// <summary>
        /// Checks if empty comments can be created.
        /// </summary>
        [Test]
        public void CreateSummaryCommentEmptyCommentTest()
        {
            // Test an empty comment.
            var result = DecoratorUtil.CreateSummaryComment("");
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);

            // Test a null comment.
            result = DecoratorUtil.CreateSummaryComment(null);
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        /// <summary>
        /// Checks if xml escapes are done on non-compilant xml strings.
        /// </summary>
        [Test]
        public void CreateSummaryCommentXmlEscapeTest()
        {
            string aShortDescription = "A 'Short\" <description> <for/> test & fun";
            var result = DecoratorUtil.CreateSummaryComment(aShortDescription);
            string desiredComment =
                "<summary>A &apos;Short&quot; &lt;description&gt; &lt;for/&gt; test &amp; fun</summary>";
            Assert.AreEqual(desiredComment, result[0].Comment.Text);
        }
        
        /// <summary>
        /// Tests the AddMembersToClass method.
        /// </summary>
        [Test]
        public void AddMembersToClassTest()
        {
            var decl = new CodeTypeDeclaration();
            var memberA = new CodeTypeMember() { Name = "MemberA" };
            var memberB = new CodeTypeMember() { Name = "MemberB" };
            var memberC = new CodeTypeMember() { Name = "MemberA" };

            // Test parameter validation
            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.AddMembersToClass(null, new CodeTypeMemberCollection()));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.AddMembersToClass(decl, null));

            // Add a single element.
            DecoratorUtil.AddMembersToClass(decl, new CodeTypeMemberCollection(new[] { memberA }));
            Assert.AreEqual(1, decl.Members.Count);

            // Confirm that this element is skipped when adding it twice.
            DecoratorUtil.AddMembersToClass(decl, new CodeTypeMemberCollection(new[] { memberA }));
            Assert.AreEqual(1, decl.Members.Count);

            // Add the remaining elements
            DecoratorUtil.AddMembersToClass(decl, new CodeTypeMemberCollection(new[] { memberA, memberB, memberC }));
            Assert.AreEqual(2, decl.Members.Count);
        }

        /// <summary>
        /// Tests the GetEnumerablePairs method..
        /// </summary>
        [Test]
        public void GetEnumerablePairsTest()
        {
            string[] keys = new[] { "a", "b", "c" };
            string[] values = new[] { "1", "2", "3" };
            string[] invalidSized = new[] { "1", "2", "3", "x", "y" };

            // Test parameter validation.
            Assert.Throws<ArgumentNullException>(
                () => DecoratorUtil.GetEnumerablePairs((string[]) null, values).First());
            Assert.DoesNotThrow(() => DecoratorUtil.GetEnumerablePairs(keys, (string[])null).First());

            Assert.Throws<ArgumentException>(() => DecoratorUtil.GetEnumerablePairs(keys, invalidSized).First());
            Assert.Throws<ArgumentException>(() => DecoratorUtil.GetEnumerablePairs(invalidSized, values).First());

            // Test simple operation.
            IEnumerable<KeyValuePair<string, string>> joined = DecoratorUtil.GetEnumerablePairs(keys, values);
            Assert.AreEqual(3, joined.Count());
            
            foreach (KeyValuePair<string,string> pair in joined)
            {
                Assert.AreEqual(pair.Key[0] - 'a', pair.Value[0] - '1');
            }
        }

        /// <summary>
        /// Tests the FindFittingEnumeration method.
        /// </summary>
        [Test]
        public void FindFittingEnumerationTest()
        {
            CodeTypeDeclaration decl = new CodeTypeDeclaration();
            IEnumerable<string> enumValues = new[] { "foo", "bar", "42" };
            IEnumerable<string> enumValues2 = new[] { "foo", "bar", "cake" };
            IEnumerable<string> enumValues3 = new[] { "foo", "bar" };

            // Test parameter validation.
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.FindFittingEnumeration(decl, null, null));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.FindFittingEnumeration(null, enumValues, null));

            // Test with empty class.
            Assert.IsNull(DecoratorUtil.FindFittingEnumeration(decl, enumValues, null));

            // Add an enum, and check whether it can be found.
            CodeTypeDeclaration testEnum = EnumResourceDecorator.GenerateEnum(
                decl, "SomeName", "SomeDescription", enumValues, null);
            decl.Members.Add(testEnum);
            Assert.AreEqual(testEnum.Name, DecoratorUtil.FindFittingEnumeration(decl, enumValues, null).BaseType);

            // Confirm that the other values are not found.
            Assert.IsNull(DecoratorUtil.FindFittingEnumeration(decl, enumValues2, null));
            Assert.IsNull(DecoratorUtil.FindFittingEnumeration(decl, enumValues3, null));

            // Check that the code also works with two enumerations
            CodeTypeDeclaration testEnum3 = EnumResourceDecorator.GenerateEnum(
                decl, "SomeOtherName", "SomeDescription", enumValues3, null);
            decl.Members.Add(testEnum3);

            Assert.AreEqual(testEnum.Name, DecoratorUtil.FindFittingEnumeration(decl, enumValues, null).BaseType);
            Assert.AreEqual(testEnum3.Name, DecoratorUtil.FindFittingEnumeration(decl, enumValues3, null).BaseType);
            Assert.IsNull(DecoratorUtil.FindFittingEnumeration(decl, enumValues2, null));
        }

        /// <summary>
        /// Test the IsFittingEnum method
        /// </summary>
        [Test]
        public void IsFittingEnumTest()
        {
            var decl = new CodeTypeDeclaration();
            IEnumerable<string> enumValues = new[] { "foo", "bar", "42" };
            IEnumerable<string> enumValues2 = new[] { "foo", "bar", "cake" };
            IEnumerable<string> enumValues3 = new[] { "foo", "bar" };

            // Add an enum, and check whether it can be found.
            CodeTypeDeclaration testEnum = EnumResourceDecorator.GenerateEnum(
                decl, "SomeName", "SomeDescription", enumValues, null);
            decl.Members.Add(testEnum);
            Assert.IsTrue(DecoratorUtil.IsFittingEnum(testEnum, enumValues, null));
            Assert.IsFalse(DecoratorUtil.IsFittingEnum(testEnum, enumValues2, null));
            Assert.IsFalse(DecoratorUtil.IsFittingEnum(testEnum, enumValues3, null));
            Assert.IsFalse(DecoratorUtil.IsFittingEnum(testEnum, Enumerable.Empty<string>(), null));
        }

        /// <summary>
        /// Test the IsFittingEnum method with enum comments
        /// </summary>
        [Test]
        public void IsFittingEnumCommectTest()
        {
            var decl = new CodeTypeDeclaration();
            IEnumerable<string> enumValues = new[] { "foo", "bar", "42" };
            IEnumerable<string> enumCommentsA = new[] { "fish", "dolphins", "mice" };
            IEnumerable<string> enumCommentsB = new[] { "fishy", "dolphiny", "micy" };
            IEnumerable<string> enumCommentsC = null;

            // Add an enum, and check whether it can be found.
            CodeTypeDeclaration testEnum = EnumResourceDecorator.GenerateEnum(
                decl, "SomeName", "SomeDescription", enumValues, enumCommentsA);
            decl.Members.Add(testEnum);
            Assert.IsTrue(DecoratorUtil.IsFittingEnum(testEnum, enumValues, enumCommentsA));
            Assert.IsFalse(DecoratorUtil.IsFittingEnum(testEnum, enumValues, enumCommentsB));
            Assert.IsFalse(DecoratorUtil.IsFittingEnum(testEnum, enumValues, enumCommentsC));
        }
    }
}