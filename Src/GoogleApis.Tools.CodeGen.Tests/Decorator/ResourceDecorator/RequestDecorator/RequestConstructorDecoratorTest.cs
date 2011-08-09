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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// Tests the RequestConstructorDecorator decorator.
    /// </summary>
    [TestFixture]
    public class RequestConstructorDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            var typeProvider = new DefaultObjectTypeProvider("Schema");
            Assert.DoesNotThrow(() => new RequestConstructorDecorator(typeProvider));
        }

        /// <summary>
        /// Tests the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>() };
            method.Parameters.Add("Param", new MockParameter() { Name = "Param" });
            var resource = new MockResource();
            resource.Methods.Add("Method", method);
            var resourceDecl = new CodeTypeDeclaration();
            var requestDecl = new CodeTypeDeclaration();
            var typeProvider = new DefaultObjectTypeProvider("Schema");

            // Confirm that the decorator has run correctly.
            var decorator = new RequestConstructorDecorator(typeProvider) { CreateOptionalConstructor = true };
            decorator.DecorateClass(resource, method, requestDecl, resourceDecl);
            Assert.AreEqual(2, requestDecl.Members.Count); // 2 Constructors.
            Assert.IsInstanceOf<CodeConstructor>(requestDecl.Members[0]);
            Assert.AreEqual(0, resourceDecl.Members.Count);

            // Test the decorator without optional parameters.
            requestDecl = new CodeTypeDeclaration();
            decorator.CreateOptionalConstructor = false;
            decorator.DecorateClass(resource, method, requestDecl, resourceDecl);
            Assert.AreEqual(1, requestDecl.Members.Count); // 1 Constructor.
            Assert.IsInstanceOf<CodeConstructor>(requestDecl.Members[0]);
            Assert.AreEqual(0, resourceDecl.Members.Count);
        }

        /// <summary>
        /// Tests the CreateConstructor method.
        /// </summary>
        [Test]
        public void CreateConstructorTest()
        {
            var parameter = new MockParameter() { Name = "Param", IsRequired = true };
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>() };
            method.Parameters.Add("Param", parameter);
            var resource = new MockResource();
            resource.Methods.Add("Method", method);
            var resourceDecl = new CodeTypeDeclaration();
            var typeProvider = new DefaultObjectTypeProvider("Schema");

            // Confirm that the "service" parameter is added.
            var decorator = new RequestConstructorDecorator(typeProvider);
            CodeConstructor constructor = decorator.CreateRequiredConstructor(resourceDecl, method, false);
            Assert.AreEqual(2, constructor.Parameters.Count);
            Assert.AreEqual("service", constructor.Parameters[0].Name);
            Assert.AreEqual(1, constructor.BaseConstructorArgs.Count);
        }

        /// <summary>
        /// Confirms that a body is added to the constructor if one is required.
        /// </summary>
        [Test]
        public void AddBodyParameterTest()
        {
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>() };
            var typeProvider = new DefaultObjectTypeProvider("Schema");

            // Confirm that no body parameter is added.
            var decorator = new RequestConstructorDecorator(typeProvider);
            CodeConstructor constructor = new CodeConstructor();
            method.HasBody = false;
            decorator.AddBodyParameter(constructor, method);
           
            Assert.AreEqual(0, constructor.Parameters.Count);
            Assert.AreEqual(0, constructor.Statements.Count);

            // Confirm that a required body parameter is added.
            method.RequestType = "MySchema";
            method.HasBody = true;
            constructor = new CodeConstructor();
            decorator.AddBodyParameter(constructor, method);

            Assert.AreEqual(1, constructor.Parameters.Count);
            Assert.AreEqual("body", constructor.Parameters[0].Name);
            Assert.AreEqual("Schema.MySchema", constructor.Parameters[0].Type.BaseType);
            Assert.AreEqual(1, constructor.Statements.Count);
        }

        /// <summary>
        /// Confirms that (only) required parameters are added by the AddRequiredParameters method.
        /// </summary>
        [Test]
        public void AddRequiredParametersTest()
        {
            var parameterA = new MockParameter() { Name = "ParamA", IsRequired = false };
            var parameterB = new MockParameter() { Name = "ParamB", IsRequired = true};
            var method = new MockMethod() { Name = "Method", Parameters = new Dictionary<string, IParameter>() };
            method.Parameters.Add("ParamA", parameterA);
            method.Parameters.Add("ParamB", parameterB);
            var resource = new MockResource();
            resource.Methods.Add("Method", method);
            var resourceDecl = new CodeTypeDeclaration();
            var typeProvider = new DefaultObjectTypeProvider("Schema");

            // Confirm that the "service" parameter is added.
            var decorator = new RequestConstructorDecorator(typeProvider);
            CodeConstructor constructor = new CodeConstructor();
            decorator.AddRequestParameters(resourceDecl, method, constructor, false);

            Assert.AreEqual(1, constructor.Parameters.Count);
            Assert.AreEqual("paramB", constructor.Parameters[0].Name);
            Assert.AreEqual(1, constructor.Statements.Count);

            // Check that optional parameters are added when the appropriate flag is set.
            constructor = new CodeConstructor();
            decorator.AddRequestParameters(resourceDecl, method, constructor, true);

            Assert.AreEqual(2, constructor.Parameters.Count);
            Assert.AreEqual("paramB", constructor.Parameters[0].Name);
            Assert.AreEqual("paramA", constructor.Parameters[1].Name);
            Assert.AreEqual(2, constructor.Statements.Count);
        }
    }
}
