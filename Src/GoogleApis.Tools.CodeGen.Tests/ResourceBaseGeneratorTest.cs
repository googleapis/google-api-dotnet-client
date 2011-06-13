/*
Copyright 2010 Google Inc

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
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Generator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests
{
    /// <summary>
    /// Test the class ResourceBaseGenerator
    /// </summary>
    [TestFixture]
    public class ResourceBaseGeneratorTest : BaseCodeGeneratorTest
    {
        public IMethod GetMethod(TestMethodNames testMethod)
        {
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);
            return resource.Methods[testMethod.ToString()];
        }

        /// <summary>
        /// For testing of ResourceBaseGenerator, extend and make public all methods and fields
        /// </summary>
        private class ForTestOnly : ResourceBaseGenerator
        {
            public new void ResourceCallAddBodyDeclaration(IMethod method,
                                                           CodeMemberMethod member,
                                                           CodeTypeReference codeType)
            {
                base.ResourceCallAddBodyDeclaration(method, member, codeType);
            }

            protected override string GetClassName()
            {
                return "TestClassName";
            }
        }

        /// <summary>
        /// Tests the GetParameterType method for valid results for common types
        /// </summary>
        [Test]
        public void TestGetParameterType()
        {
            Assert.Throws(typeof(ArgumentNullException), () => ResourceBaseGenerator.GetParameterType(null));

            MockParameter param = new MockParameter();

            // Null => string
            param.ValueType = null;
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "" => string
            param.ValueType = "";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "string" => string
            param.ValueType = "string";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "integer" => long
            param.ValueType = "integer";
            Assert.AreEqual(typeof(long), ResourceBaseGenerator.GetParameterType(param));

            // "boolean" => bool
            param.ValueType = "boolean";
            Assert.AreEqual(typeof(bool), ResourceBaseGenerator.GetParameterType(param));

            // "AnyOldRubbish" => string
            param.ValueType = "AGreatBigFish";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // Test nullable types

        }

        /// <summary>
        /// Tests the GetParameterTypeReference method
        /// </summary>
        [Test]
        public void TestGetParameterTypeReference()
        {
            MockParameter param = new MockParameter() { Name = "Parameter" };
            MockMethod method = new MockMethod() { Name = "Method" };
            CodeTypeDeclaration decl;
            CodeTypeReference refType;

            param.Required = true;

            // Normal string.
            param.ValueType = "string";
            refType = ResourceBaseGenerator.GetParameterTypeReference(param, method, out decl);
            Assert.AreEqual(typeof(string).FullName, refType.BaseType);
            Assert.IsNull(decl);

            // Normal int
            param.ValueType = "integer";
            refType = ResourceBaseGenerator.GetParameterTypeReference(param, method, out decl);
            Assert.AreEqual(typeof(long).FullName, refType.BaseType);
            Assert.IsNull(decl);

            // optional int
            param.Required = false;
            param.ValueType = "integer";
            refType = ResourceBaseGenerator.GetParameterTypeReference(param, method, out decl);
            Assert.AreEqual("System.Int64?", refType.BaseType);
            Assert.IsNull(decl);

            // Enumeration
            param.Required = true;
            param.ValueType = "string";
            param.Enum = new[] { "TestA", "TestB" };
            param.EnumDescriptions = new[] { "DescA", "DescB" };
            refType = ResourceBaseGenerator.GetParameterTypeReference(param, method, out decl);
            Assert.IsNotNull(decl);
            Assert.AreEqual(decl.Name, refType.BaseType);
            Assert.IsTrue(decl.IsEnum);

            // Optional enumeration
            param.Required = false;
            param.ValueType = "string";
            param.Enum = new[] { "TestA", "TestB" };
            param.EnumDescriptions = new[] { "DescA", "DescB" };
            refType = ResourceBaseGenerator.GetParameterTypeReference(param, method, out decl);
            Assert.IsNotNull(decl);
            Assert.AreEqual(decl.Name + "?", refType.BaseType);
            Assert.IsTrue(decl.IsEnum);
        }

        /// <summary>
        /// Tests if the ResourceCallBodyDeclaration generates a valid method
        /// </summary>
        [Test]
        public void TestResourceCallAddBodyDeclaration()
        {
            var method = GetMethod(TestMethodNames.getTest);
            var tester = new ForTestOnly();
            var member = new CodeMemberMethod();

            tester.ResourceCallAddBodyDeclaration(method, member, new CodeTypeReference(typeof(string)));
            Assert.AreEqual(0, member.Parameters.Count);

            method = GetMethod(TestMethodNames.postTest);
            member = new CodeMemberMethod();
            tester.ResourceCallAddBodyDeclaration(method, member, new CodeTypeReference(typeof(string)));
            Assert.AreEqual(1, member.Parameters.Count);
        }
    }
}