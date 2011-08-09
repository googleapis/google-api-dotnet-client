/*
Copyright 2011 Google Inc

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

using System.CodeDom;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Tests for the BodyPropertyDecorator.
    /// </summary>
    [TestFixture]
    public class BodyPropertyDecoratorTest
    {
        /// <summary>
        /// Confirms that the constructor of this decorator runs without any problem.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new BodyPropertyDecorator(new DefaultObjectTypeProvider("Schema")));
        }

        /// <summary>
        /// Confirms that the decorator will not add the body members to non-body requests.
        /// </summary>
        [Test]
        public void DecorateClassNonBodyTest()
        {
            var decorator = new BodyPropertyDecorator(new DefaultObjectTypeProvider("Schema"));
            var resource = new MockResource();
            var method = new MockMethod() { Name = "Test", HasBody = false };
            var decl = new CodeTypeDeclaration();
            var resourceDecl = new CodeTypeDeclaration();
            decorator.DecorateClass(resource, method, decl, resourceDecl);

            Assert.AreEqual(0, decl.Members.Count);
        }

        /// <summary>
        /// Confirms that the decorator adds the Body-property and method to the class.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new BodyPropertyDecorator(new DefaultObjectTypeProvider("Schema"));
            var resource = new MockResource();
            var method = new MockMethod() { Name = "Test", RequestType = "SomeSchema", HasBody = true };
            var decl = new CodeTypeDeclaration();
            var resourceDecl = new CodeTypeDeclaration();
            decorator.DecorateClass(resource, method, decl, resourceDecl);

            Assert.AreEqual(3, decl.Members.Count);
            Assert.IsInstanceOf<CodeMemberField>(decl.Members[0]);
            Assert.IsInstanceOf<CodeMemberProperty>(decl.Members[1]);
            Assert.AreEqual("Body", decl.Members[1].Name);
            Assert.IsInstanceOf<CodeMemberMethod>(decl.Members[2]);
            Assert.AreEqual("GetBody", decl.Members[2].Name);
        }

        /// <summary>
        /// Confirms that the GenerateBodyProperty method generates a property and field member.
        /// </summary>
        [Test]
        public void GenerateBodyPropertyTest()
        {
            var decorator = new BodyPropertyDecorator(new DefaultObjectTypeProvider("Schema"));
            var method = new MockMethod() { Name = "Test", RequestType = "SomeSchema", HasBody = true };
            var bodyType = new CodeTypeReference(typeof(object));
            CodeTypeMemberCollection newMembers = decorator.GenerateBodyProperty(method, bodyType);

            // Confirm that the result consists out of a field and a property.
            Assert.AreEqual(2, newMembers.Count);
            CollectionAssert.AreEqual(
                new[] { typeof(CodeMemberField), typeof(CodeMemberProperty) },
                (from CodeTypeMember m in newMembers select m.GetType()));
        }

        /// <summary>
        /// Confirms that the GenerateGetBodyOverride method generates a valid method.
        /// </summary>
        [Test]
        public void GenerateGetBodyOverrideTest()
        {
            var decorator = new BodyPropertyDecorator(new DefaultObjectTypeProvider("Schema"));
            var method = new MockMethod() { Name = "Test", RequestType = "SomeSchema", HasBody = true };
            CodeMemberMethod newMethod = decorator.GenerateGetBodyOverride(method);

            Assert.AreEqual(ServiceRequest<object>.GetBodyMethodName, newMethod.Name);
            Assert.AreEqual(MemberAttributes.Override | MemberAttributes.Family, newMethod.Attributes);
            Assert.AreEqual(0, newMethod.Parameters.Count);
            Assert.AreEqual(typeof(object).FullName, newMethod.ReturnType.BaseType);
            Assert.AreEqual(1, newMethod.Statements.Count);
        }
    }
}
