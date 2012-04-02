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
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests
{
    /// <summary>
    /// Test the class ResourceBaseGenerator.
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
        /// For testing of ResourceBaseGenerator, extend and make public all methods and fields.
        /// </summary>
        private class ForTestOnly : ResourceBaseGenerator
        {
            public void ResourceCallAddBodyDeclaration(IMethod method,
                                                           CodeMemberMethod member,
                                                           CodeTypeReference codeType)
            {
                ResourceCallAddBodyDeclaration(method, member, codeType, /* add body even if unused */ true);
            }

            protected override string GetClassName()
            {
                return "TestClassName";
            }
        }

        /// <summary>
        /// Tests the GetParameterType method for valid results for common types.
        /// </summary>
        [Test]
        public void TestGetParameterType()
        {
            Assert.Throws(typeof(ArgumentNullException), () => ResourceBaseGenerator.GetParameterType(null));

            MockParameter param = new MockParameter();

            // Null => string.
            param.ValueType = null;
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "" => string.
            param.ValueType = "";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "string" => string.
            param.ValueType = "string";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // "integer" => long.
            param.ValueType = "integer";
            Assert.AreEqual(typeof(long), ResourceBaseGenerator.GetParameterType(param));

            // "boolean" => bool.
            param.ValueType = "boolean";
            Assert.AreEqual(typeof(bool), ResourceBaseGenerator.GetParameterType(param));

            // "AnyOldRubbish" => string.
            param.ValueType = "AGreatBigFish";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));

            // repeatable "string" => Repeatable<string>.
            param.IsRepeatable = true;
            param.ValueType = "string";
            Assert.AreEqual(typeof(Repeatable<string>), ResourceBaseGenerator.GetParameterType(param));
        }
        
        [Test]
        public void TestGetParameterTypeReference()
        {
            MockParameter param = new MockParameter() { Name = "Parameter" };
            CodeTypeDeclaration decl = new CodeTypeDeclaration();
            CodeTypeReference refType;

            param.IsRequired = true;

            // Normal string.
            param.ValueType = "string";
            refType = ResourceBaseGenerator.GetParameterTypeReference(decl, param);
            Assert.AreEqual(typeof(string).FullName, refType.BaseType);

            // Normal int
            param.ValueType = "integer";
            refType = ResourceBaseGenerator.GetParameterTypeReference(decl, param);
            Assert.AreEqual(typeof(long).FullName, refType.BaseType);

            // optional int
            param.IsRequired = false;
            param.ValueType = "integer";
            refType = ResourceBaseGenerator.GetParameterTypeReference(decl, param);
            Assert.AreEqual("System.Int64?", refType.BaseType);

            // Enumeration
            param.IsRequired = true;
            param.ValueType = "string";
            param.EnumValues = new[] { "TestA", "TestB" };
            param.EnumValueDescriptions = new[] { "DescA", "DescB" };
            decl.Members.Add(EnumResourceDecorator.GenerateEnum(
                decl, "TestEnum", null, param.EnumValues, param.EnumValueDescriptions));
            refType = ResourceBaseGenerator.GetParameterTypeReference(decl, param);
            Assert.AreEqual("TestEnum", refType.BaseType);

            // Optional enumeration
            param.IsRequired = false;
            param.ValueType = "string";
            param.EnumValues = new[] { "TestA", "TestB" };
            param.EnumValueDescriptions = new[] { "DescA", "DescB" };
            refType = ResourceBaseGenerator.GetParameterTypeReference(decl, param);
            Assert.AreEqual("TestEnum" + "?", refType.BaseType);
        }

        /// <summary>
        /// Tests if the ResourceCallBodyDeclaration generates a valid method.
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