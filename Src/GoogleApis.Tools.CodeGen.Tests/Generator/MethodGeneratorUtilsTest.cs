using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Tests.Generator
{
    [TestFixture()]
    public class MethodGeneratorUtilsTest
    {
        [Test()]
        public void TestGetRequiredParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = MethodGeneratorUtils.GetRequiredParameters(method).ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("req_a", parameters[0].Name);
            Assert.AreEqual("req_b", parameters[1].Name);
        }

        [Test()]
        public void TestGetOptionalParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            List<IParameter> parameters = MethodGeneratorUtils.GetOptionalParameters(method).ToList();
            Assert.AreEqual(2, parameters.Count);
            Assert.AreEqual("opt_a", parameters[0].Name);
            Assert.AreEqual("opt_b", parameters[1].Name);

            method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest);
            parameters = MethodGeneratorUtils.GetOptionalParameters(method).ToList();
            Assert.AreEqual(0, parameters.Count);
        }

        [Test()]
        public void TestHasOptionalParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(MethodGeneratorUtils.HasOptionalParameters(method));
            Assert.That(MethodGeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest)));
            Assert.IsFalse(MethodGeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest)));
            Assert.IsFalse(MethodGeneratorUtils.HasOptionalParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest)));
        }

        [Test()]
        public void TestHasRequiredParameters()
        {
            var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
            Assert.That(method.HasRequiredParameters());
            Assert.IsFalse(MethodGeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneOptionalParameterTest)));
            Assert.That(MethodGeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.oneRequiredParameterTest)));
            Assert.IsFalse(MethodGeneratorUtils.HasRequiredParameters(GetMethod(BaseCodeGeneratorTest.TestMethodNames.noParameterTest)));
        }

        [Test()]
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

        [Test()]
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

        [Test()]
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

        private IMethod GetMethod(BaseCodeGeneratorTest.TestMethodNames testMethod)
        {
            var resource = BaseCodeGeneratorTest.CreateResourceDivcoveryV_0_1(BaseCodeGeneratorTest.ResourceName, BaseCodeGeneratorTest.ResourceAsJson);
            return resource.Methods[testMethod.ToString()];
        }
    }
}
