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

using System.CodeDom;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Authentication;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Services;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary> Tests for the StandardConstructServiceDecorator class. </summary>
    [TestFixture]
    public class StandardConstructServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests if resource assignments can be added
        /// </summary>
        [Test]
        public void TestAddResourceAssignments()
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = "TestMethod";
            var decorator = new StandardConstructServiceDecorator();

            var service = CreateBuzzService();
            decorator.AddResourceAssignments(service, method);

            Assert.AreEqual(7, method.Statements.Count);
            foreach (var statment in method.Statements)
            {
                Assert.IsInstanceOf(typeof(CodeAssignStatement), statment);
                var assign = (CodeAssignStatement)statment;
                Assert.IsNotNull(assign.Left);
                Assert.IsNotNull(assign.Right);
                Assert.IsInstanceOf(typeof(CodeFieldReferenceExpression), assign.Left);
                Assert.IsInstanceOf(typeof(CodeObjectCreateExpression), assign.Right);
            }
        }

        /// <summary>
        /// Tests if the CreateConstructorWithArgs methods returns the correct result
        /// </summary>
        [Test]
        public void TestCreateConstructorWithArgs()
        {
            var decorator = new StandardConstructServiceDecorator();
            IService service = CreateBuzzService();
            CodeConstructor constructor = decorator.CreateConstructorWithArgs();

            Assert.AreEqual(1, constructor.Parameters.Count);
            Assert.AreEqual(typeof(BaseClientService.Initializer).FullName, constructor.Parameters[0].Type.BaseType);
            Assert.AreEqual("initializer", constructor.Parameters[0].Name);

            Assert.AreEqual(0, constructor.Statements.Count);
        }

        /// <summary>
        /// Tests the class decorator
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var codeType = new CodeTypeDeclaration("TestClass");
            var decorator = new StandardConstructServiceDecorator();
            var service = CreateBuzzService();

            Assert.AreEqual(0, codeType.Members.Count);
            decorator.DecorateClass(service, codeType);

            Assert.AreEqual(1, codeType.Members.Count); // We expect one member to be added
            Assert.IsInstanceOf(typeof(CodeConstructor), codeType.Members[0]);
            var constructor = (CodeConstructor)codeType.Members[0];

            // Assinging service.Resource.Count statemenets + initParameters()
            Assert.AreEqual(constructor.Statements.Count, service.Resources.Count + 1);

            //We have already tested the statment formation in the other tests.
        }
    }
}