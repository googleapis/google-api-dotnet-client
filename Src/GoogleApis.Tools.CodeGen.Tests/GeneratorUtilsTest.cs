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
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tools.CodeGen.Tests
{
    /// <summary>
    /// Tests for the GeneratorUtils class
    /// </summary>
    [TestFixture]
    public class GeneratorUtilsTest
    {
        /// <summary>
        /// Tests the generation of safe parameter names
        /// </summary>
        [Test]
        public void GetParameterNameTest()
        {
            var factory = ServiceFactory.Default;
            IParameter param = factory.CreateParameter("safeName", new JsonDictionary());
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, Enumerable.Empty<string>()));

            param = factory.CreateParameter("string", new JsonDictionary());
            Assert.AreEqual("stringValue", GeneratorUtils.GetParameterName(param, Enumerable.Empty<string>()));

            param = factory.CreateParameter("String", new JsonDictionary());
            Assert.AreEqual("stringValue", GeneratorUtils.GetParameterName(param, Enumerable.Empty<string>()));

            param = factory.CreateParameter("SafeName", new JsonDictionary());
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, Enumerable.Empty<string>()));
        }

        /// <summary>
        /// Tests the generation of safe member names
        /// </summary>
        [Test]
        public void GetSafeMemberNameTest()
        {
            IList<string> simpleSafeWords = new List<string> { "unsafe", "words", "abound" };

            Assert.AreEqual(
                "fishBurger",
                GeneratorUtils.GetSafeMemberName(simpleSafeWords, 0, "fishBurger"));
            Assert.AreEqual(
                "member",
                GeneratorUtils.GetSafeMemberName(
                    simpleSafeWords, GeneratorUtils.TargetCase.ToLower, "!@#$$%^&^&**((())+}{|\":\\\t\r"));
            
            foreach (string word in GeneratorUtils.UnsafeWords)
            {
                Assert.AreEqual(word + "Member", GeneratorUtils.GetSafeMemberName(GeneratorUtils.UnsafeWords, 0, word));
            }

            // Test the "basenameMember"-pattern
            string[] unsafeWords = new string[GeneratorUtils.SafeMemberMaximumIndex];
            for (int i = 0; i < unsafeWords.Length; i++)
                unsafeWords[i] = "test" + (i == 0 ? "" : (i + 1).ToString());

            Assert.AreEqual("testMember", GeneratorUtils.GetSafeMemberName(unsafeWords, 0, "test"));
        }

        /// <summary>
        /// Tests if the LowerFirstLetter method works
        /// </summary>
        [Test]
        public void LowwerFirstTest()
        {
            string upper = "ABC";
            string lower = "aBC";

            Assert.AreEqual(lower, GeneratorUtils.LowerFirstLetter(lower));
            Assert.AreEqual(lower, GeneratorUtils.LowerFirstLetter(upper));

            Assert.AreEqual("", GeneratorUtils.LowerFirstLetter(""));
            Assert.AreEqual(null, GeneratorUtils.LowerFirstLetter(null));
        }

        /// <summary>
        /// Tests if the UpperfirstLetter method works
        /// </summary>
        [Test]
        public void UpperFirstTest()
        {
            string upper = "ABC";
            string lower = "aBC";

            Assert.AreEqual(upper, GeneratorUtils.UpperFirstLetter(lower));
            Assert.AreEqual(upper, GeneratorUtils.UpperFirstLetter(upper));

            Assert.AreEqual("", GeneratorUtils.UpperFirstLetter(""));
            Assert.AreEqual(null, GeneratorUtils.UpperFirstLetter(null));
        }

        /// <summary>
        /// Tests if the generator can generate valid body names
        /// </summary>
        [Test]
        public void ValidBodyCharTest()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char " + c + " should be valid");
            }
            for (char c = 'a'; c <= 'z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char " + c + " should be valid");
            }

            for (char c = '0'; c <= '9'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char " + c + " should be valid");
            }

            Assert.IsTrue(GeneratorUtils.IsValidBodyChar('_'));
            
            for (char c = Char.MinValue; c < '0'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('9' + 1); c < 'A'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('Z' + 1); c < 'a'; c++)
            {
                if (c == '_')
                {
                    continue;
                }

                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('z' + 1); c < Char.MaxValue; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int) c + " should be invalid");
            }
        }

        /// <summary>
        /// Tests if the generator will only generate valid first chars
        /// </summary>
        [Test]
        public void ValidFirstCharTest()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidFirstChar(c), "Char " + c + " should be valid");
            }
            for (char c = 'a'; c <= 'z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidFirstChar(c), "Char " + c + " should be valid");
            }

            Assert.IsTrue(GeneratorUtils.IsValidBodyChar('_'));

            for (char c = Char.MinValue; c < 'A'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('Z' + 1); c < 'a'; c++)
            {
                if (c == '_')
                {
                    continue;
                }

                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('z' + 1); c < Char.MaxValue; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }
        }

        /// <summary>
        /// Tests the GetWordContextListFromClass method
        /// </summary>
        [Test]
        public void GetWordContextListFromClassTest()
        {
            // Test validation.
            Assert.Throws<ArgumentNullException>(() => GeneratorUtils.GetWordContextListFromClass(null).First());

            // Test normal operation
            var decl = new CodeTypeDeclaration();
            decl.Name = "MockClass";
            decl.Members.Add(new CodeMemberField(typeof(int), "FieldA"));
            decl.Members.Add(new CodeMemberProperty() { Name = "FieldB" });
            decl.Members.Add(new CodeTypeDeclaration() { Name = "NestedClassC" });

            CollectionAssert.AreEqual(
                new[] { "MockClass", "FieldA", "FieldB", "NestedClassC" },
                GeneratorUtils.GetWordContextListFromClass(decl));
        }
        
        /// <summary>
        /// Checks that the MakeValidMemberName method returns valid member names.
        /// </summary>
        [Test]
        public void MakeValidMemberNameTest()
        {
            // Test empty strings.
            Assert.AreEqual(null, GeneratorUtils.MakeValidMemberName(null));
            Assert.AreEqual(null, GeneratorUtils.MakeValidMemberName(""));

            // Tests strings consisting only out of invalid characters
            Assert.AreEqual(null, GeneratorUtils.MakeValidMemberName("!@#"));
            Assert.AreEqual(null, GeneratorUtils.MakeValidMemberName("   "));
            Assert.AreEqual(null, GeneratorUtils.MakeValidMemberName("123456789"));

            // Test valid names
            Assert.AreEqual("SomeClassName2", GeneratorUtils.MakeValidMemberName("SomeClassName2"));
            Assert.AreEqual("_memberName", GeneratorUtils.MakeValidMemberName("_memberName"));

            // Test that invalid characters are removed
            Assert.AreEqual("ref", GeneratorUtils.MakeValidMemberName("$ref"));
            Assert.AreEqual("unknown", GeneratorUtils.MakeValidMemberName("(unknown)"));
            Assert.AreEqual("FooBar", GeneratorUtils.MakeValidMemberName("Foo@bar"));
            Assert.AreEqual("fooBar", GeneratorUtils.MakeValidMemberName("foo!@#$bar"));
        }

        /// <summary>
        /// Confirms that the IsNameValidInContext method will recognize invalid names.
        /// </summary>
        [Test]
        public void IsNameValidInContextTest()
        {
            string[] emptyList = new string[0];
            string[] forbiddenContext = new[] { "evil", "foo", "bar", "INVALID" };

            // Test with an empty name.
            Assert.IsFalse(GeneratorUtils.IsNameValidInContext(null, emptyList));
            Assert.IsFalse(GeneratorUtils.IsNameValidInContext("", emptyList));

            // Test with a valid name.
            Assert.IsTrue(GeneratorUtils.IsNameValidInContext("foobar", emptyList));
            Assert.IsTrue(GeneratorUtils.IsNameValidInContext("foobar", forbiddenContext));
            
            // Test with some invalid names.
            Assert.IsFalse(GeneratorUtils.IsNameValidInContext("foo", forbiddenContext));
            Assert.IsFalse(GeneratorUtils.IsNameValidInContext("evil", forbiddenContext));

            // Confirm that character casing is valued.
            Assert.IsTrue(GeneratorUtils.IsNameValidInContext("Foo", forbiddenContext));
            Assert.IsTrue(GeneratorUtils.IsNameValidInContext("Evil", forbiddenContext));
            Assert.IsTrue(GeneratorUtils.IsNameValidInContext("invalid", forbiddenContext));
            Assert.IsFalse(GeneratorUtils.IsNameValidInContext("INVALID", forbiddenContext));
        }

        /// <summary>
        /// Tests the AlterCase method.
        /// </summary>
        [Test]
        public void AlterFirstCharCaseTest()
        {
            // Test empty strings.
            Assert.IsNull(GeneratorUtils.AlterFirstCharCase(null, GeneratorUtils.TargetCase.ToLower));
            Assert.AreEqual("", GeneratorUtils.AlterFirstCharCase("", GeneratorUtils.TargetCase.ToLower));

            // Test the ToLower variant.
            Assert.AreEqual("a", GeneratorUtils.AlterFirstCharCase("A", GeneratorUtils.TargetCase.ToLower));
            Assert.AreEqual("a", GeneratorUtils.AlterFirstCharCase("a", GeneratorUtils.TargetCase.ToLower));

            // Test the ToUpper variant.
            Assert.AreEqual("A", GeneratorUtils.AlterFirstCharCase("a", GeneratorUtils.TargetCase.ToUpper));
            Assert.AreEqual("A", GeneratorUtils.AlterFirstCharCase("A", GeneratorUtils.TargetCase.ToUpper));

            // Test the DontChange variant.
            Assert.AreEqual("a", GeneratorUtils.AlterFirstCharCase("a", GeneratorUtils.TargetCase.DontChange));
            Assert.AreEqual("A", GeneratorUtils.AlterFirstCharCase("A", GeneratorUtils.TargetCase.DontChange));

            // Test a more complex string.
            Assert.AreEqual("FooBar", GeneratorUtils.AlterFirstCharCase("fooBar", GeneratorUtils.TargetCase.ToUpper));
            Assert.AreEqual("fooBar", GeneratorUtils.AlterFirstCharCase("FooBar", GeneratorUtils.TargetCase.ToLower));
        }

        /// <summary>
        /// Confirm the returned enumeration of the AppendIndices method.
        /// </summary>
        [Test]
        public void AppendIndicesTest()
        {
            Assert.Throws<ArgumentException>(() => GeneratorUtils.AppendIndices("test", 10, 1).First());
            
            CollectionAssert.AreEqual(new string[0], GeneratorUtils.AppendIndices(null, 1, 5));
            CollectionAssert.AreEqual(new string[0], GeneratorUtils.AppendIndices("", 1, 5));
            CollectionAssert.AreEqual(new[] { "abc1", "abc2", "abc3" }, GeneratorUtils.AppendIndices("abc", 1, 3));
        }

        /// <summary>
        /// Test for GenerateAlternativeNamesFor method.
        /// </summary>
        [Test]
        public void GenerateAlternativeNamesForTest()
        {
            // Generate the list of expected values.
            IEnumerable<string> expect = new[] { "to", "toMember" };
            expect = expect.Concat(GeneratorUtils.AppendIndices("to", 2, GeneratorUtils.SafeMemberMaximumIndex));
            expect = expect.Concat(GeneratorUtils.AppendIndices("toMember", 2, GeneratorUtils.SafeMemberMaximumIndex));

            // Compare with the implementation.
            IEnumerable<string> alternatives = GeneratorUtils.GenerateAlternativeNamesFor("to");
            CollectionAssert.AreEquivalent(expect, alternatives);
        }

        /// <summary>
        /// Tests the GetPropertyName method.
        /// </summary>
        [Test]
        public void GetPropertyNameTest()
        {
            Assert.AreEqual("Test", GeneratorUtils.GetPropertyName("test", new string[0]));
            Assert.AreEqual("ETag", GeneratorUtils.GetPropertyName("etag", new string[0]));
            Assert.AreEqual("ETagValue", GeneratorUtils.GetPropertyName("etag", new[] { "ETag" }));
        }

        /// <summary>
        /// Tests the GetEnumName method.
        /// </summary>
        [Test]
        public void GetEnumNameTest()
        {
            Assert.AreEqual("Test", GeneratorUtils.GetEnumName("test", new string[0]));
            Assert.AreEqual("TestEnum", GeneratorUtils.GetEnumName("test", new[] { "Test" }));
            Assert.AreEqual("TestMember", GeneratorUtils.GetEnumName("test", new[] { "Test", "TestEnum" }));
        }

        /// <summary>
        /// Tests the GetEnumValueName method.
        /// </summary>
        [Test]
        public void GetEnumValueNameTest()
        {
            Assert.AreEqual("Test", GeneratorUtils.GetEnumValueName("test", new string[0]));
            Assert.AreEqual("TestValue", GeneratorUtils.GetEnumValueName("test", new[] { "Test" }));
            Assert.AreEqual("TestMember", GeneratorUtils.GetEnumValueName("test", new[] { "Test", "TestValue" }));
        }

        /// <summary>
        /// Tests the GetSchemaReference method.
        /// </summary>
        [Test]
        public void GetSchemaReferenceTest()
        {
            Assert.Throws<ArgumentNullException>(() => GeneratorUtils.GetSchemaReference("Namespace", null));
            Assert.Throws<ArgumentException>(() => GeneratorUtils.GetSchemaReference("Namespace", ""));
            Assert.Throws<ArgumentNullException>(() => GeneratorUtils.GetSchemaReference(null, "Type"));
            Assert.Throws<ArgumentException>(() => GeneratorUtils.GetSchemaReference("", "Type"));
            Assert.AreEqual("Namespace.Type", GeneratorUtils.GetSchemaReference("Namespace", "Type").BaseType);
        }

        /// <summary>
        /// Tests the FindPropertyByName method.
        /// </summary>
        [Test]
        public void FindPropertyByNameTest()
        {
            CodeTypeMemberCollection collection = null;

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName(null));
            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName("name"));

            collection = new CodeTypeMemberCollection(new[] { new CodeTypeMember(), });

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName(null));
            Assert.Throws(typeof(ArgumentException), () => collection.FindPropertyByName(""));

            Assert.IsNull(collection.FindPropertyByName("AnyString"));

            collection.Add(CreateMemberProperty("Fish"));
            collection.Add(CreateMemberProperty("Cat"));
            collection.Add(CreateMemberProperty("Tree"));
            collection.Add(CreateMemberProperty("House"));

            CodeTypeMember willNotFind = new CodeMemberMethod();
            willNotFind.Name = "WillNotFindMethod";
            collection.Add(willNotFind);

            willNotFind = new CodeMemberField();
            willNotFind.Name = "WillNotFindField";
            collection.Add(willNotFind);

            willNotFind = new CodeMemberEvent();
            willNotFind.Name = "WillNotFindEvent";
            collection.Add(willNotFind);

            Assert.IsNull(collection.FindPropertyByName("AnyString"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindMethod"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindField"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindEvent"));
            Assert.IsNotNull(collection.FindPropertyByName("Fish"));
            Assert.IsNotNull(collection.FindPropertyByName("Cat"));
            Assert.IsNotNull(collection.FindPropertyByName("Tree"));
            Assert.IsNotNull(collection.FindPropertyByName("House"));

            Assert.AreEqual("Fish", collection.FindPropertyByName("Fish").Name);
            Assert.AreEqual("Cat", collection.FindPropertyByName("Cat").Name);
            Assert.AreEqual("Tree", collection.FindPropertyByName("Tree").Name);
            Assert.AreEqual("House", collection.FindPropertyByName("House").Name);
        }

        /// <summary>
        /// Tests the FindMemberByName method.
        /// </summary>
        [Test]
        public void FindMemberByNameTest()
        {
            CodeTypeMemberCollection collection = null;

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindMemberByName(null));
            Assert.Throws(typeof(ArgumentNullException), () => collection.FindMemberByName("name"));

            collection = new CodeTypeMemberCollection(new[] { new CodeTypeMember(), });

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindMemberByName(null));
            Assert.Throws(typeof(ArgumentException), () => collection.FindMemberByName(""));

            Assert.IsNull(collection.FindMemberByName("AnyString"));

            collection.Add(CreateMemberProperty("Fish"));
            collection.Add(CreateMemberProperty("Cat"));
            collection.Add(CreateMemberProperty("Tree"));
            collection.Add(CreateMemberProperty("House"));

            CodeTypeMember willAlsoFind = new CodeMemberMethod();
            willAlsoFind.Name = "WillAlsoFindMethod";
            collection.Add(willAlsoFind);

            willAlsoFind = new CodeMemberField();
            willAlsoFind.Name = "WillAlsoFindField";
            collection.Add(willAlsoFind);

            willAlsoFind = new CodeMemberEvent();
            willAlsoFind.Name = "WillAlsoFindEvent";
            collection.Add(willAlsoFind);

            Assert.IsNull(collection.FindMemberByName("AnyString"));
            Assert.IsNotNull(collection.FindMemberByName("WillAlsoFindMethod"));
            Assert.IsNotNull(collection.FindMemberByName("WillAlsoFindField"));
            Assert.IsNotNull(collection.FindMemberByName("WillAlsoFindEvent"));
            Assert.IsNotNull(collection.FindMemberByName("Fish"));
            Assert.IsNotNull(collection.FindMemberByName("Cat"));
            Assert.IsNotNull(collection.FindMemberByName("Tree"));
            Assert.IsNotNull(collection.FindMemberByName("House"));

            Assert.AreEqual("Fish", collection.FindMemberByName("Fish").Name);
            Assert.AreEqual("Cat", collection.FindMemberByName("Cat").Name);
            Assert.AreEqual("Tree", collection.FindMemberByName("Tree").Name);
            Assert.AreEqual("House", collection.FindMemberByName("House").Name);
        }

        private CodeMemberProperty CreateMemberProperty(string name)
        {
            var member = new CodeMemberProperty();
            member.Name = name;
            return member;
        }

        /// <summary>
        /// Tests the FindMemberByName method.
        /// </summary>
        [Test]
        public void FindTypeMemberByNameTest()
        {
            CodeTypeMemberCollection collection = null;

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindTypeMemberByName(null));
            Assert.Throws(typeof(ArgumentNullException), () => collection.FindTypeMemberByName("name"));

            collection = new CodeTypeMemberCollection(new[] { new CodeTypeMember(), });

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindTypeMemberByName(null));
            Assert.Throws(typeof(ArgumentException), () => collection.FindTypeMemberByName(""));

            Assert.IsNull(collection.FindTypeMemberByName("AnyString"));

            collection.Add(CreateMemberProperty("Fish"));

            CodeTypeMember member = new CodeMemberMethod();
            member.Name = "Method";
            collection.Add(member);

            member = new CodeMemberField();
            member.Name = "Field";
            collection.Add(member);

            member = new CodeMemberEvent();
            member.Name = "Event";
            collection.Add(member);

            collection.Add(new CodeTypeDeclaration() { Name = "Class" });

            Assert.IsNull(collection.FindTypeMemberByName("AnyString"));
            Assert.IsNull(collection.FindTypeMemberByName("Method"));
            Assert.IsNull(collection.FindTypeMemberByName("Field"));
            Assert.IsNull(collection.FindTypeMemberByName("Event"));
            Assert.IsNull(collection.FindTypeMemberByName("Fish"));

            Assert.IsNotNull(collection.FindTypeMemberByName("Class"));
            Assert.AreEqual("Class", collection.FindTypeMemberByName("Class").Name);
        }

        [Test, Sequential]
        public void GetNamespaceNameTest(
            [Values("v1", "__", "1.1", "v1-sandbox", "")] string inName,
            [Values("v1", "__", "_1_1", "v1_sandbox", null)] string outName)
        {
            Assert.That(GeneratorUtils.GetNamespaceName(inName), Is.EqualTo(outName));
        }
    }
}