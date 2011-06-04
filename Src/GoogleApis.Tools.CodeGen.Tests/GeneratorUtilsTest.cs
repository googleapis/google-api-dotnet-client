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
            var paramArgs = new KeyValuePair<string, object>("safeName", new JsonDictionary());
            IParameter param = new ParameterFactory.BaseParameter(paramArgs);
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, 1, Enumerable.Empty<string>()));

            paramArgs = new KeyValuePair<string, object>("string", new JsonDictionary());
            param = new ParameterFactory.BaseParameter(paramArgs);
            Assert.AreEqual("stringParam1", GeneratorUtils.GetParameterName(param, 1, Enumerable.Empty<string>()));

            paramArgs = new KeyValuePair<string, object>("String", new JsonDictionary());
            param = new ParameterFactory.BaseParameter(paramArgs);
            Assert.AreEqual("stringParam1", GeneratorUtils.GetParameterName(param, 1, Enumerable.Empty<string>()));

            paramArgs = new KeyValuePair<string, object>("SafeName", new JsonDictionary());
            param = new ParameterFactory.BaseParameter(paramArgs);
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, 1, Enumerable.Empty<string>()));
        }

        /// <summary>
        /// Tests the generation of safe member names
        /// </summary>
        [Test]
        public void GetSafeMemberNameTest()
        {
            IList<string> simpleSafeWords = new List<string> { "unsafe", "words", "abound" };
            string uniquie = "UnIqUie";
            Assert.AreEqual("fishBurger", GeneratorUtils.GetSafeMemberName("fishBurger", uniquie, simpleSafeWords));
            Assert.AreEqual(
                uniquie, GeneratorUtils.GetSafeMemberName("!@#$$%^&^&**((())_+}{|\":\\\t\r", uniquie, simpleSafeWords));
            Assert.AreEqual(
                simpleSafeWords[0] + uniquie,
                GeneratorUtils.GetSafeMemberName(simpleSafeWords[0], uniquie, simpleSafeWords));

            foreach (string word in GeneratorUtils.UnsafeWords)
            {
                Assert.AreEqual(
                    word + uniquie, GeneratorUtils.GetSafeMemberName(word, uniquie, GeneratorUtils.UnsafeWords));
            }
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

            for (char c = Char.MinValue; c < 'A'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('Z' + 1); c < 'a'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }

            for (char c = (char) ('z' + 1); c < Char.MaxValue; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int) c + " should be invalid");
            }
        }
    }
}