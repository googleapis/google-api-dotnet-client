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

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Tools.CodeGen.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Tests the Nested Class Name Generator
    /// </summary>
    [TestFixture]
    public class NestedClassNameGeneratorTest
    {
        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new NestedClassNameGenerator());
        }

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void GenerateNameEdgeCases()
        {
            CodeTypeDeclaration testType = new CodeTypeDeclaration();
            var schema = new JsonSchema();

            var generator = new NestedClassNameGenerator();

            Assert.Throws<ArgumentNullException>(() => generator.GenerateName(null, schema));
            Assert.Throws<ArgumentNullException>(() => generator.GenerateName(testType, null));
            Assert.That(generator.GenerateName(testType, schema), Is.Null);
        }

        /// <summary>
        /// Tests the generation of names for array types
        /// </summary>
        [Test]
        public void GenerateNameArrayTest()
        {
            CodeTypeDeclaration testType = new CodeTypeDeclaration();
            testType.BaseTypes.Add(typeof(IList));
            var schema = new JsonSchema();

            var generator = new NestedClassNameGenerator();

            Assert.That(generator.GenerateName(testType, schema), Is.EqualTo("Item"));
        }

        /// <summary>
        /// Tests the generation of names for array types
        /// </summary>
        [Test]
        public void GenerateNameTitleTest()
        {
            CodeTypeDeclaration testType = new CodeTypeDeclaration();
            testType.Name = "Class";

            // Title Name <-> Type Nam
            var testNames = new Dictionary<string, string>();
            testNames.Add("test", "ClassTest");
            testNames.Add("test_case", "ClassTestCase"); // Also partially tests the  GeneratorUtils class
            testNames.Add("icons", "Icon");
            testNames.Add("properties", "Property");

            var generator = new NestedClassNameGenerator();

            // Test all cases
            foreach (KeyValuePair<string, string> testPair in testNames)
            {
                var schema = new JsonSchema();
                schema.Title = testPair.Key;

                Assert.That(generator.GenerateName(testType, schema), Is.EqualTo(testPair.Value));
            }
        }
    }
}
