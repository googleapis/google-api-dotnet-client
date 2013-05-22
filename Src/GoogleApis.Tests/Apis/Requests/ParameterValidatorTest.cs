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

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Testing;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary> Tests <see cref="Google.Api.Requests.ParameterValidator"/>. </summary>
    [TestFixture]
    public class ParameterValidatorTest
    {
        /// <summary> Tests that validate regex returns <c>false</c> on empty parameter sets. </summary>
        [Test]
        public void ValidateRegexEmptyNeedsDataTest()
        {
            var parameter = new MockParameter() { Pattern = ".+", Name = "test" };
            Assert.IsFalse(ParameterValidator.ValidateRegex(parameter, ""));
        }

        /// <summary> Tests validate regex. </summary>
        [Test]
        public void ValidateRegexTest()
        {
            var parameter = new MockParameter() { Pattern = ".+", Name = "test" };
            Assert.IsTrue(ParameterValidator.ValidateRegex(parameter, "Test"));
        }

        /// <summary> Tests validate enum a non-enum parameter. </summary>
        [Test]
        public void ValidateEnumNullTest()
        {
            var p = new MockParameter() { Name = "test" };

            // Confirm that the method validates enumerations correctly.
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "one"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "two"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "three"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "One"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, ""));
        }

        /// <summary> Tests validate enum method. </summary>
        [Test]
        public void ValidateEnumTest()
        {
            var p = new MockParameter
                {
                    Name = "test",
                    EnumValues = new string[] { "one", "two", "three" }
                };
            // Confirm that the method validates enumerations correctly.
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "one"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "two"));
            Assert.IsTrue(ParameterValidator.ValidateEnum(p, "three"));
            Assert.IsFalse(ParameterValidator.ValidateEnum(p, "One"));
            Assert.IsFalse(ParameterValidator.ValidateEnum(p, ""));
            Assert.IsFalse(ParameterValidator.ValidateEnum(p, "FooBar"));
        }
    }
}