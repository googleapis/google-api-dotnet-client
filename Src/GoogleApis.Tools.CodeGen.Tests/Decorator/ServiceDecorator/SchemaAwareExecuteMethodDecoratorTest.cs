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

using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the SchemaAwareExecuteMethodDecorator
    /// </summary>
    [TestFixture]
    public class SchemaAwareExecuteMethodDecoratorTest
    {
        /// <summary>
        /// Tests if the CreateExecuteMethod method gives the correct result
        /// </summary>
        [Test]
        public void TestCreateExecuteMethod()
        {
            var decorator = new SchemaAwearExecuteMethodDecorator();
            var createdMethod = decorator.CreateExecuteMethod();

            Assert.AreEqual(4, createdMethod.Parameters.Count);
            Assert.AreEqual(new CodeTypeReference(typeof(string)).BaseType, createdMethod.Parameters[0].Type.BaseType);
            Assert.AreEqual(new CodeTypeReference(typeof(string)).BaseType, createdMethod.Parameters[1].Type.BaseType);
            Assert.AreEqual(new CodeTypeReference(typeof(object)).BaseType, createdMethod.Parameters[2].Type.BaseType);
            Assert.AreEqual(
                new CodeTypeReference(typeof(IDictionary<string, string>)).BaseType,
                createdMethod.Parameters[3].Type.BaseType);

            Assert.AreEqual(new CodeTypeReference(typeof(Stream)).BaseType, createdMethod.ReturnType.BaseType);
        }
    }
}