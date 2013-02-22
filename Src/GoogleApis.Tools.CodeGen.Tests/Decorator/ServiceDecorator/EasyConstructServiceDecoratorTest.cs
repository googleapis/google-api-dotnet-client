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

using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary> Tests for the EasyConstructServiceDecorator class. </summary>
    [TestFixture]
    public class EasyConstructServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests if the CreateEmptyConstructor method returns the correct result.
        /// </summary>
        [Test]
        public void TestCreateEmptyConstructor()
        {
            var decorator = new EasyConstructServiceDecorator();
            CodeConstructor constructor = decorator.CreateEmptyConstructor();

            // Check parameters.
            Assert.AreEqual(0, constructor.Parameters.Count);

            // Check statements.
            Assert.AreEqual(0, constructor.Statements.Count);

            // Check chained parameters.
            Assert.AreEqual(1, constructor.ChainedConstructorArgs.Count);
            Assert.IsInstanceOf<CodeObjectCreateExpression>(constructor.ChainedConstructorArgs[0]);
        }

        /// <summary>
        /// Tests the DecorateClass method on this decorator.
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var codeType = new CodeTypeDeclaration("TestClass");
            var decorator = new EasyConstructServiceDecorator();
            var service = CreateBuzzService();

            decorator.DecorateClass(service, codeType);

            Assert.AreEqual(1, codeType.Members.Count); // We expect one constructor to be generated.

            // Test the empty constructor.
            Assert.IsInstanceOf(typeof(CodeConstructor), codeType.Members[0]);
            var constructor = (CodeConstructor)codeType.Members[0];
            Assert.AreEqual(0, constructor.Parameters.Count);
            Assert.AreEqual(0, constructor.Statements.Count);
        }
    }
}