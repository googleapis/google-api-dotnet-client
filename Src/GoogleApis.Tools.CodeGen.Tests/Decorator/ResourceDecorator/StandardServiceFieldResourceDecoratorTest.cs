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
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the StandardServiceFieldResourceDecorator
    /// </summary>
    [TestFixture]
    public class StandardServiceFieldResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Tests the decorator
        /// </summary>
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new StandardServiceFieldResourceDecorator();
            CodeNamespace nameSpace = new CodeNamespace("Google.Apis.Tools.CodeGen.Tests");
            nameSpace.Types.Add(new CodeTypeDeclaration("TestServiceClass"));

            CodeTypeDeclaration codeType = CreateDecoratedResourceClass(decorator);
            nameSpace.Types.Add(codeType);

            Assert.AreEqual(2, codeType.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), codeType.Members[0]);
            var codeField = (CodeMemberField) codeType.Members[0];
            Assert.AreEqual(ResourceBaseGenerator.ServiceFieldName, codeField.Name);
            var ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(nameSpace);

            CheckCompile(ccu, false, "Failed To Compile StandardServiceFieldResourceDecorator");
        }

        /// <summary>
        /// Tests the ability to create the service field
        /// </summary>
        [Test]
        public void TestCreateServiceField()
        {
            string serviceName = typeof(IRequestProvider).FullName;
            var decorator = new StandardServiceFieldResourceDecorator();
            CodeMemberField codeField = decorator.CreateServiceField(serviceName);

            Assert.IsNotNull(codeField);
            Assert.AreEqual(ResourceBaseGenerator.ServiceFieldName, codeField.Name);
            Assert.AreEqual(serviceName, codeField.Type.BaseType);
            Assert.IsNull(codeField.InitExpression);
        }
    }
}