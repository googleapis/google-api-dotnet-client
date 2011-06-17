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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the EnumResourceDecorator class.
    /// </summary>
    [TestFixture]
    public class EnumResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Tests the constructor of this decorator.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new EnumResourceDecorator());
        }

        /// <summary>
        /// Tests the DecorateClass method.
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            // Test that this decorator does not throw an exception.
            CodeTypeDeclaration decoratedClass = CreateDecoratedResourceClass(new EnumResourceDecorator());

            // Generation of enum is tested within the DecoratorUtilTest.
            var query = (from CodeTypeDeclaration m in decoratedClass.Members where m.IsEnum select m);
            Assert.AreEqual(1, query.Count());

            // Check the generated enum type.
            CodeTypeDeclaration enumType = query.Single();
            Assert.AreEqual(3, enumType.Members.Count);
        }
    }
}
