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
using System.Linq;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    /// <summary>
    /// Tests for the MethodGeneratorUtil class.
    /// </summary>
    [TestFixture]
    public class MethodGeneratorUtilsTest
    {
        private IMethod GetMethod(BaseCodeGeneratorTest.TestMethodNames testMethod)
        {
            var resource = BaseCodeGeneratorTest.CreateResourceDiscoveryV_1_0(
                BaseCodeGeneratorTest.ResourceName, BaseCodeGeneratorTest.ResourceAsJson);
            return resource.Methods[testMethod.ToString()];
        }

        /// <summary>
        /// Tests if the parameters are sorted correctly.
        /// </summary>
        [Test]
        public void TestAllParameterSorting()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            IParameter[] parameters = method.GetAllParametersSorted().ToArray();
            Assert.AreEqual(4, parameters.Length);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
            Assert.AreEqual("opt_a", parameters[2].Name);
            Assert.AreEqual("opt_b", parameters[3].Name);

            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.postTest);
            parameters = method.GetAllParametersSorted().ToArray();
            Assert.AreEqual(5, parameters.Length);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
            Assert.AreEqual("req_c", parameters[2].Name);
            Assert.AreEqual("opt_a", parameters[3].Name);
            Assert.AreEqual("opt_b", parameters[4].Name);
        }

        /// <summary>
        /// Tests if the parameters are sorted correctly when a sorting order is proposed.
        /// </summary>
        [Test]
        public void TestProposedSorting()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest2);

            // Test with all parameters:
            IParameter[] parameters = method.GetAllParametersSorted().ToArray();
            Assert.AreEqual(4, parameters.Length);
            Assert.AreEqual("req_b", parameters[0].Name);
            Assert.AreEqual("opt_a", parameters[1].Name);
            Assert.AreEqual("req_a", parameters[2].Name);
            Assert.AreEqual("opt_b", parameters[3].Name);

            // Test with optional ones only:
            parameters = method.GetOptionalParameters().ToArray();
            Assert.AreEqual(2, parameters.Length);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);

            // Test with required ones only:
            parameters = method.GetRequiredParameters().ToArray();
            Assert.AreEqual(2, parameters.Length);
            Assert.AreEqual("req_b", parameters[0].Name);
            Assert.AreEqual("req_a", parameters[1].Name);
        }


        /// <summary>
        /// Tests if optional parameters are added correctly.
        /// </summary>
        [Test]
        public void TestGetOptionalParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = method.GetOptionalParameters().ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);

            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest);
            parameters = method.GetOptionalParameters().ToList();
            Assert.AreEqual(0, parameters.Count);
        }

        /// <summary>
        /// Tests if required parameters are added correctly.
        /// </summary>
        [Test]
        public void TestGetRequiredParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = method.GetRequiredParameters().ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
        }

        /// <summary>
        /// Tests if optional parameters are recognized.
        /// </summary>
        [Test]
        public void TestHasOptionalParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(method.HasOptionalParameters());
            Assert.That(
                GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest).HasOptionalParameters());
            Assert.IsFalse(
                GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest).HasOptionalParameters());
            Assert.IsFalse(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest).HasOptionalParameters());
        }

        /// <summary>
        /// Tests if required parameters are recognized.
        /// </summary>
        [Test]
        public void TestHasRequiredParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(method.HasRequiredParameters());
            Assert.IsFalse(
                GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest).HasRequiredParameters());
            Assert.That(
                GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest).HasRequiredParameters());
            Assert.IsFalse(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest).HasRequiredParameters());
        }

        /// <summary>
        /// Tests if optional parameters are sorted correctly.
        /// </summary>
        [Test]
        public void TestOptionalParameterSorting()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            IParameter[] parameters = method.GetOptionalParameters().ToArray();
            Assert.AreEqual(2, parameters.Length);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);

            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.postTest);
            parameters = method.GetOptionalParameters().ToArray();
            Assert.AreEqual(2, parameters.Length);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);
        }

        /// <summary>
        /// Tests if required parameters are sorted correctly.
        /// </summary>
        [Test]
        public void TestRequiredParameterSorting()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            IParameter[] parameters = method.GetRequiredParameters().ToArray();
            Assert.AreEqual(2, parameters.Length);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);

            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.postTest);
            parameters = method.GetRequiredParameters().ToArray();
            Assert.AreEqual(3, parameters.Length);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
            Assert.AreEqual("req_c", parameters[2].Name);
        }
    }
}