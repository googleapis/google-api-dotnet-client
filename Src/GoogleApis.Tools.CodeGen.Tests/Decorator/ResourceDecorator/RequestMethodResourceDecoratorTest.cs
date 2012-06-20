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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests the RequestMethodResourceDecorator
    /// </summary>
    [TestFixture]
    public class RequestMethodResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Confirms that the constructor of this method runs without any problem.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new RequestMethodResourceDecorator(new DefaultObjectTypeProvider("schema")));
        }

        /// <summary>
        /// Test that the decorator will generate a method with parameters.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new RequestMethodResourceDecorator(new DefaultObjectTypeProvider("Schema"));
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);
            var decl = new CodeTypeDeclaration("TestClass");

            // Test the DecorateClass method with optional parameters.
            decorator.AddOptionalParameters = true;
            decorator.DecorateClass(resource, decl.Name, decl, null, null, null);
            Assert.AreEqual(10, decl.Members.Count); // 5 methods with one overload each.
            Assert.AreEqual("GetTest", decl.Members[0].Name);
            Assert.AreEqual("GetTest", decl.Members[1].Name);

            // Test the DecorateClass method without optional parameters.
            decl = new CodeTypeDeclaration("TestClass");
            decorator.AddOptionalParameters = false;
            decorator.DecorateClass(resource, decl.Name, decl, null, null, null);
            Assert.AreEqual(6, decl.Members.Count); // 6 methods defined in the resource json.
        }

        /// <summary>
        /// Confirms the generated method.
        /// </summary>
        [Test]
        public void CreateMethodTest()
        {
            const string className = "TestClass";
            var typeProvider = new DefaultObjectTypeProvider("Schema");
            var commentCreator = new DefaultEnglishCommentCreator();
            var generator = new RequestMethodResourceDecorator.ResourceGenerator(
                className, typeProvider, commentCreator);

            // Generate a method.
            var decl = new CodeTypeDeclaration();
            var resource = new MockResource();
            var method = new MockMethod() { Name = "Test", Parameters = new Dictionary<string, IParameter>()};
            method.Parameters.Add(
                "a", new MockParameter() { Name = "a", ParameterType = "string", IsRequired = false });
            method.Parameters.Add(
                "b", new MockParameter() { Name = "b", ParameterType = "string", IsRequired = true });
            CodeMemberMethod generatedMethod = generator.CreateMethod(decl, resource, method, true, 
                RequestMethodResourceDecorator.MethodType.Request);

            Assert.AreEqual("Test", generatedMethod.Name);
            Assert.AreEqual(2, generatedMethod.Parameters.Count); // two parameters defined.
            Assert.AreEqual(1, generatedMethod.Statements.Count); // one "new ...Request()" statement.
            Assert.AreEqual("TestRequest", generatedMethod.ReturnType.BaseType);
        }
    }
}