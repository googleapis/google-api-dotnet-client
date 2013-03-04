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

using System.Collections.Generic;
using Google.Apis.Requests;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests the "MethodValidator" class
    /// </summary>
    [TestFixture]
    public class MethodValidatorTests
    {
        /// <summary>
        /// Tests the constructor of the MethodValidator
        /// </summary>
        [Test]
        public void ConstructorTest()
        {
            MockMethod m = new MockMethod();
            m.Name = "Test";

            Assert.IsInstanceOf<MethodValidator>(new MethodValidator(m, new ParameterCollection()));
        }

        /// <summary>
        /// Tests that the validator will return false on empty parameter sets
        /// </summary>
        [Test]
        public void ValidateRegexEmptyNeedsDataTest()
        {
            IMethod m = new MockMethod();
            var dict = new JsonDictionary { { "name", "test" }, { "pattern", ".+" } };

            var jsonObj = new KeyValuePair<string, object>("test", dict);


            var p = new ParameterFactory.BaseParameter(jsonObj);
            var inputData = new ParameterCollection();
            var validator = new MethodValidator(m, inputData);

            Assert.IsFalse(validator.ValidateRegex(p, ""));
        }

        /// <summary>
        /// Tests that the validator regex works
        /// </summary>
        [Test]
        public void ValidateRegexTest()
        {
            IMethod m = new MockMethod();
            var dict = new JsonDictionary { { "name", "test" }, { "pattern", ".+" } };

            var jsonObj = new KeyValuePair<string, object>("test", dict);


            var p = new ParameterFactory.BaseParameter(jsonObj);
            var inputData = new ParameterCollection();
            var validator = new MethodValidator(m, inputData);
            Assert.IsTrue(validator.ValidateRegex(p, "Test"));
        }
    }
}