/*
Copyright 2013 Google Inc

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

using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary> Tests for the InitServiceParametersDecorator class. </summary>
    [TestFixture]
    public class InitServiceParametersDecoratorTest
    {
        /// <summary> Tests if the a new init parameters was generated. </summary>
        [Test]
        public void CreateInitParametersMethod()
        {
            var decorator = new InitServiceParametersDecorator();
            var service = new MockService();
            var decl = new CodeTypeDeclaration();

            decorator.DecorateClass(service, decl);

            Assert.AreEqual(1, decl.Members.Count);
            Assert.That(decl.Members[0], Is.InstanceOf<CodeMemberMethod>());
            var method = decl.Members[0] as CodeMemberMethod;
            Assert.AreEqual("InitParameters", method.Name);
            Assert.AreEqual(0, method.Parameters.Count);
            Assert.AreEqual(typeof(void).FullName, method.ReturnType.BaseType);

            // The method itself is tested as part of DecoratorUtilTest
        }
    }
}
