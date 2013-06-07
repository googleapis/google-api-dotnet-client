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
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary> Tests for the VersionInformationServiceDecorator class. </summary>
    [TestFixture]
    public class VersionInformationServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary> Tests if the generation of a discovery version field works. </summary>
        [Test]
        public void TestCreateDiscoveryVersionField()
        {
            var decorator = new VersionInformationServiceDecorator();
            var codeMemberField = decorator.CreateDiscoveryVersionField(CreateService());

            Assert.AreEqual(VersionInformationServiceDecorator.DiscoveryVersionName, codeMemberField.Name);
        }

        /// <summary> Tests if the generation of a version field works. </summary>
        [Test]
        public void TestCreateVersionField()
        {
            var decorator = new VersionInformationServiceDecorator();
            var codeMemberField = decorator.CreateVersionField(CreateService());

            Assert.AreEqual(VersionInformationServiceDecorator.VersionName, codeMemberField.Name);
            Assert.AreEqual(Version, ((CodePrimitiveExpression)codeMemberField.InitExpression).Value);
        }

        /// <summary> Tests if the class decorator works. </summary>
        [Test]
        public void TestDecorateClass()
        {
            var decorator = new VersionInformationServiceDecorator();
            CodeTypeDeclaration codeType = new CodeTypeDeclaration("TestClass");
            decorator.DecorateClass(CreateService(), codeType);
            Assert.AreEqual(2, codeType.Members.Count);

            CheckCompile(codeType, true, "Failed to compile VersionInformationServiceDecorator output");
        }
    }
}