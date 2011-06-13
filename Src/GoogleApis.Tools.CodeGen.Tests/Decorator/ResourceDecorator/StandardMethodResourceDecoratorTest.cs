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
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests the StandardMethodResourceDecorator
    /// </summary>
    [TestFixture]
    public class StandardMethodResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Test the generator
        /// </summary>
        public void TestResourceGenerator()
        {
            var generator = new StandardMethodResourceDecorator.ResourceGenerator(
                "TestClassName", false, false, null, "", null);
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);
            var method = resource.Methods[TestMethodNames.getTest.ToString()];
            var mockDecorator = new MockResourceDecorator();
            CodeTypeMemberCollection paramDecl;

            CodeMemberMethod generatedMember = generator.CreateMethod(
                resource, method, 1, new List<IResourceDecorator> { mockDecorator }, out paramDecl);

            Assert.AreEqual(0, mockDecorator.DecorateClassCalled);
            Assert.AreEqual(1, mockDecorator.DecorateMethodBeforeExecuteCalled);
            Assert.AreEqual(1, mockDecorator.DecorateMethodAfterExecuteCalled);

            Assert.AreEqual(4, generatedMember.Parameters.Count);
            Assert.AreEqual(0, paramDecl.Count);
        }

        private IDictionary<TestMethodNames, CodeMemberMethod> CreateMethodDictionary(CodeTypeDeclaration decoratedClass)
        {
            var dict = new Dictionary<TestMethodNames, CodeMemberMethod>();
            foreach (var member in decoratedClass.Members)
            {
                if (member is CodeMemberMethod == false)
                {
                    continue;
                }
                var method = (CodeMemberMethod) member;
                var methodName = (TestMethodNames) Enum.Parse(typeof(TestMethodNames), method.Name.Replace("AsStream", ""), true);
                dict.Add(methodName, method);
            }
            return dict;
        }

        /// <summary>
        /// Test the decorator
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var decorator = new StandardMethodResourceDecorator();
            var decoratedClass = CreateDecoratedResourceClass(
                new StandardServiceFieldResourceDecorator(false), new StandardResourceNameResourceDecorator(), decorator);

            Assert.AreEqual(2 + Enum.GetValues(typeof(TestMethodNames)).Length, decoratedClass.Members.Count);

            var dict = CreateMethodDictionary(decoratedClass);

            // check that a method is generated for each of the TestMethodNames 
            foreach (TestMethodNames methodName in 
                Enum.GetValues(typeof(TestMethodNames)))
            {
                if (dict.ContainsKey(methodName) == false)
                {
                    Assert.Fail("Failed to Produce a method for " + methodName);
                }
            }

            // check the parameters are as expected
            var method = dict[TestMethodNames.getTest];
            Assert.AreEqual(4, method.Parameters.Count);

            for (int i = 0; i < method.Parameters.Count; i++ )
            {
                Assert.That(method.Parameters[i].Name, Is.EqualTo(ResourceGetTestParameterNames[i]));
            }

            method = dict[TestMethodNames.postTest];
            Assert.AreEqual(6, method.Parameters.Count);

            method = dict[TestMethodNames.noParameterTest];
            Assert.AreEqual(0, method.Parameters.Count);

            CheckCompile(decoratedClass, false, "Failed To Compile using StandardMethodResourceDecorator()");
        }
    }
}