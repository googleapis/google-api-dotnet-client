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
using Google.Apis.Tools.CodeGen.Decorator.ResourceContainerDecorator;
using System.Linq;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the StandardResourcePropertyServiceDecorator class
    /// </summary>
    [TestFixture]
    public class StandardResourcePropertyServiceDecoratorTest : BaseServiceDecoratorTest
    {
        /// <summary>
        /// Tests if the CreateResoruceField method generates a resource field
        /// </summary>
        [Test]
        public void CreateResourceFieldTest()
        {
            var decorator = new StandardResourcePropertyServiceDecorator();
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);

            CodeMemberField codeField = decorator.CreateResourceField(resource, Enumerable.Empty<string>());

            Assert.IsNotNull(codeField);
            Assert.AreEqual(ResourceName+"Resource", codeField.Type.BaseType);
            Assert.AreEqual("_Test", codeField.Name);
        }

        /// <summary>
        /// Tests if the CreateResourceGetter generate a appropriate getter
        /// </summary>
        [Test]
        public void CreateResourceGetterTest()
        {
            var decorator = new StandardResourcePropertyServiceDecorator();
            var resource = CreateResourceDiscoveryV_1_0(ResourceName, ResourceAsJson);

            CodeMemberProperty codeProperty = decorator.CreateResourceGetter(resource, Enumerable.Empty<string>());

            Assert.IsNotNull(codeProperty);
            Assert.IsFalse(codeProperty.HasSet);
            Assert.IsTrue(codeProperty.HasGet);
            Assert.AreEqual(ResourceName, codeProperty.Name);
            Assert.AreEqual(ResourceName + "Resource", codeProperty.Type.BaseType);
        }

        /// <summary>
        /// Tests if the decorate class method works
        /// todo: Write a test for StandardResourcePropertyServiceDecorator.DecorateClass
        /// </summary>
        [Test]
        public void TestDecorateClass() {}
    }
}