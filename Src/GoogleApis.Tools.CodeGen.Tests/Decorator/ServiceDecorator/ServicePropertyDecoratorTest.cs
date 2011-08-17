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

using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests the DeveloperKeyServiceDecorator
    /// </summary>
    [TestFixture]
    public class DeveloperKeyServiceDecoratorTest : BaseServiceDecoratorTest
    {
        [Test]
        public void TestDecorateClass()
        {
            var decorator = new DeveloperKeyServiceDecorator();
            var service = CreateService();
            var codeType = new CodeTypeDeclaration("TestClass");

            decorator.DecorateClass(service, codeType);

            Assert.AreEqual(2, codeType.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[0]);
            Assert.IsInstanceOf(typeof(CodeMemberProperty), codeType.Members[1]);

            CodeMemberField devkeyField = (CodeMemberField)codeType.Members[0];
            CodeMemberProperty devkeyProperty = (CodeMemberProperty)codeType.Members[1];

            Assert.AreEqual("DeveloperKey", devkeyProperty.Name);
            Assert.AreEqual("developerKey", devkeyField.Name);
            Assert.AreEqual(typeof(string).FullName, devkeyField.Type.BaseType);
            Assert.AreEqual(typeof(string).FullName, devkeyProperty.Type.BaseType);

            CheckCompile(codeType, false, "Failed To Compile result from ServicePropertyDecoratorDecorator");
        }
    }
}

