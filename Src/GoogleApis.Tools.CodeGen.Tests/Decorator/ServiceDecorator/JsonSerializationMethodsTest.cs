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
using System.IO;
using Google.Apis.Requests;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests the generated Json Serialization methods of the generated service
    /// </summary>
    [TestFixture]
    public class JsonSerializationMethodsTest
    {
        /// <summary>
        /// Asserts that the specified type contains a member with the given name
        /// </summary>
        private void AssertContainsName(CodeTypeMemberCollection coll, string name)
        {
            foreach (CodeTypeMember member in coll)
            {
                if (name == member.Name)
                {
                    return;
                }
            }
            Assert.Fail("Failed to find [" + name + "] in CodeTypeMembers");
        }

        /// <summary>
        /// Tests the JsonSerializer @ Objects. Confirms that the signature looks like:
        ///     public TOutput JsonToObject<TOutput>(Stream stream)
        /// </summary>
        [Test]
        public void CreateJsonToObjectTest()
        {
            JsonSerializationMethods decorator = new JsonSerializationMethods();
            CodeMemberMethod method = decorator.CreateResponseToObject();
            Assert.IsNotNull(method);
            Assert.AreEqual(MemberAttributes.Public, method.Attributes);
            Assert.AreEqual("DeserializeResponse", method.Name);
            Assert.IsNotEmpty(method.TypeParameters);
            Assert.AreEqual(1, method.TypeParameters.Count);
            Assert.IsNotEmpty(method.Parameters);
            Assert.AreEqual(1, method.Parameters.Count);
            Assert.AreEqual(new CodeTypeReference(typeof(IResponse)).BaseType, method.Parameters[0].Type.BaseType);
            Assert.IsNotEmpty(method.Statements);
        }

        /// <summary>
        /// Tests the JsonDeserializer. Confirms that the signature looks like:
        ///     public string ObjectToJson(object obj)
        /// </summary>
        [Test]
        public void CreateObjectToJsonTest()
        {
            JsonSerializationMethods decorator = new JsonSerializationMethods();
            CodeMemberMethod method = decorator.CreateObjectToJson();

            Assert.IsNotNull(method);
            Assert.AreEqual(MemberAttributes.Public, method.Attributes);
            Assert.AreEqual(new CodeTypeReference(typeof(String)).BaseType, method.ReturnType.BaseType);
            Assert.AreEqual("SerializeObject", method.Name);
            Assert.IsNotNull(method.Parameters);
            Assert.AreEqual(1, method.Parameters.Count);
            Assert.AreEqual(new CodeTypeReference(typeof(object)).BaseType, method.Parameters[0].Type.BaseType);
            Assert.IsNotEmpty(method.Statements);
        }

        /// <summary>
        /// Tests the JsonDeserializer. Confirms that the signature looks like:
        ///     public void RegisterSerializer(ISerializer serializer)
        /// </summary>
        [Test]
        public void CreateRegisterSerializerTest()
        {
            JsonSerializationMethods decorator = new JsonSerializationMethods();
            CodeMemberMethod method = decorator.CreateRegisterSerializer();

            Assert.IsNotNull(method);
            Assert.AreEqual(MemberAttributes.Public, method.Attributes);
            Assert.AreEqual(new CodeTypeReference(typeof(void)).BaseType, method.ReturnType.BaseType);
            Assert.AreEqual("RegisterSerializer", method.Name);
            Assert.IsNotNull(method.Parameters);
            Assert.AreEqual(1, method.Parameters.Count);
            Assert.AreEqual(new CodeTypeReference(typeof(ISerializer)).BaseType, method.Parameters[0].Type.BaseType);
            Assert.IsNotEmpty(method.Statements);
            Assert.AreEqual(1, method.Statements.Count);
        }

        /// <summary>
        /// Tests the class decorator
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            JsonSerializationMethods decorator = new JsonSerializationMethods();
            Assert.Throws(typeof(ArgumentNullException), () => decorator.DecorateClass(null, null));
            CodeTypeDeclaration declaration = new CodeTypeDeclaration("TestClass");
            decorator.DecorateClass(null, declaration);

            Assert.AreEqual(3, declaration.Members.Count);
            AssertContainsName(declaration.Members, "SerializeObject");
            AssertContainsName(declaration.Members, "DeserializeResponse");
            AssertContainsName(declaration.Members, "RegisterSerializer");
        }
    }
}