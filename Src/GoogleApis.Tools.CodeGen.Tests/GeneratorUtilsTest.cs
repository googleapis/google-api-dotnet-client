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
using Google.Apis.Tools.CodeGen;
using Google.Apis.Json;

namespace Google.Apis.Tools.CodeGen.Tests
{
    [TestFixture()]
    public class GeneratorUtilsTest
    {
        [Test()]
        public void LowwerFirstTest()
        {
            string upper = "ABC";
            string lower = "aBC";
            
            Assert.AreEqual(lower, GeneratorUtils.LowerFirstLetter(lower));
            Assert.AreEqual(lower, GeneratorUtils.LowerFirstLetter(upper));
            
            Assert.AreEqual("", GeneratorUtils.LowerFirstLetter(""));
            Assert.AreEqual(null, GeneratorUtils.LowerFirstLetter(null));
        }
        
        [Test()]
        public void UpperFirstTest()
        {
            string upper = "ABC";
            string lower = "aBC";
            
            Assert.AreEqual(upper, GeneratorUtils.UpperFirstLetter(lower));
            Assert.AreEqual(upper, GeneratorUtils.UpperFirstLetter(upper));
            
            Assert.AreEqual("", GeneratorUtils.UpperFirstLetter(""));
            Assert.AreEqual(null, GeneratorUtils.UpperFirstLetter(null));
        }
        
        [Test()]
        public void ValidFirstCharTest()
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidFirstChar(c), "Char "+c+" should be valid");
            }
            for(char c = 'a'; c <= 'z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidFirstChar(c), "Char "+c+" should be valid");
            }

            for(char c = Char.MinValue; c<'A'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int)c + " should be invalid");
            }
            
            for(char c = (char)('Z' + 1); c<'a'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int)c + " should be invalid");
            }
            
            for(char c = (char)('z' + 1); c< Char.MaxValue; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidFirstChar(c), "Char " + (int)c + " should be invalid");
            }   
        }
        
        [Test()]
        public void ValidBodyCharTest()
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char "+c+" should be valid");
            }
            for(char c = 'a'; c <= 'z'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char "+c+" should be valid");
            }
            
            for(char c = '0'; c <= '9'; c++)
            {
                Assert.IsTrue(GeneratorUtils.IsValidBodyChar(c), "Char "+c+" should be valid");
            }

   
            for(char c = Char.MinValue; c<'0'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int)c + " should be invalid");
            }
            
            for(char c = (char)('9' + 1) ; c<'A'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int)c + " should be invalid");
            }
            
            for(char c = (char)('Z' + 1); c<'a'; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int)c + " should be invalid");
            }
            
            for(char c = (char)('z' + 1); c< Char.MaxValue; c++)
            {
                Assert.IsFalse(GeneratorUtils.IsValidBodyChar(c), "Char " + (int)c + " should be invalid");
            }     
        }
        
        [Test()]
        public void GetSafeMemberNameTest()
        {
            IList<string> simpleSafeWords = new List<string>(){"unsafe", "words", "abound"};
            string uniquie = "UnIqUie";
            Assert.AreEqual("fishBurger", GeneratorUtils.GetSafeMemberName("fishBurger", uniquie, simpleSafeWords));
            Assert.AreEqual(uniquie, GeneratorUtils.GetSafeMemberName("!@#$$%^&^&**((())_+}{|\":\\\t\r", uniquie, simpleSafeWords));
            Assert.AreEqual(simpleSafeWords[0] + uniquie, GeneratorUtils.GetSafeMemberName(simpleSafeWords[0], uniquie, simpleSafeWords));
            
            foreach(string word in GeneratorUtils.UnsafeWords)
            {
                Assert.AreEqual(word + uniquie, GeneratorUtils.GetSafeMemberName(word, uniquie, GeneratorUtils.UnsafeWords));
            }
        }
        
        [Test()]
        public void GetParameterNameTest()
        {
            var paramArgs = new KeyValuePair<string,object>("safeName", new JsonDictionary());
            IParameter param = new Parameter(paramArgs);
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, 1));
            
            paramArgs = new KeyValuePair<string,object>("string", new JsonDictionary());
            param = new Parameter(paramArgs);
            Assert.AreEqual("stringParam1", GeneratorUtils.GetParameterName(param, 1));
            
            paramArgs = new KeyValuePair<string,object>("String", new JsonDictionary());
            param = new Parameter(paramArgs);
            Assert.AreEqual("stringParam1", GeneratorUtils.GetParameterName(param, 1));
            
            paramArgs = new KeyValuePair<string,object>("SafeName", new JsonDictionary());
            param = new Parameter(paramArgs);
            Assert.AreEqual("safeName", GeneratorUtils.GetParameterName(param, 1));
        }
        
        [Test()]
        public void TestGetRequiredParameters(){
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = GeneratorUtils.GetRequiredParameters(method).ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
        }
        
        [Test()]
        public void TestGetOptionalParameters(){
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = GeneratorUtils.GetOptionalParameters(method).ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);
            
            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest);
            parameters = GeneratorUtils.GetOptionalParameters(method).ToList();
            Assert.AreEqual(0, parameters.Count);
        }
        
        [Test()]
        public void TestHasOptionalParameters(){
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(GeneratorUtils.HasOptionalParameters(method));
            Assert.That(GeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest)));
            Assert.IsFalse(GeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest)));
            Assert.IsFalse(GeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest)));
        }
        
        [Test()]
        public void TestHasRequiredParameters(){
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(GeneratorUtils.HasRequiredParameters(method));
            Assert.IsFalse(GeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest)));
            Assert.That(GeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest)));
            Assert.IsFalse(GeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest)));
        }
        
        private IMethod GetMethod(BaseCodeGeneratorTest.TestMethodNames testMethod){
            var resource = BaseCodeGeneratorTest.CreateResourceDivcoveryV_0_1 (BaseCodeGeneratorTest.ResourceName, BaseCodeGeneratorTest.ResourceAsJson);
            return resource.Methods[testMethod.ToString()];
        }
    }
}