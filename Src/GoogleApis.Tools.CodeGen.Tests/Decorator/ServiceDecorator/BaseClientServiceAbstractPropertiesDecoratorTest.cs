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

using System;
using System.CodeDom;
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Authentication;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Tests for the BaseClientServiceAbstractPropertiesDecorator class
    /// </summary>
    [TestFixture]
    class BaseClientServiceAbstractPropertiesDecoratorTest : BaseServiceDecoratorTest
    {
        #region Helper

        private object GetReturnPrimitiveValue(CodeMemberProperty property)
        {
            Assert.That(property.GetStatements.Count, Is.EqualTo(1));
            Assert.That(property.GetStatements[0], Is.TypeOf(typeof(CodeMethodReturnStatement)));
            var returnStatement = property.GetStatements[0] as CodeMethodReturnStatement;
            Assert.That(returnStatement.Expression, Is.TypeOf(typeof(CodePrimitiveExpression)));
            var primitive = returnStatement.Expression as CodePrimitiveExpression;
            return primitive.Value;
        }

        #endregion

        #region Name

        /// <summary>
        /// Tests if the generation of a name field works
        /// </summary>
        [Test]
        public void TestCreateNameField()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var codeMemberField = decorator.CreateNameProperty(CreateService());

            Assert.AreEqual("Name", codeMemberField.Name);
            Assert.AreEqual(Name, GetReturnPrimitiveValue(codeMemberField));
        }

        #endregion

        #region BaseUri

        /// <summary>
        /// Tests if the generation of an uri field works
        /// </summary>
        [Test]
        public void TestCreateUriField()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var codeMemberField = decorator.CreateUriProperty(CreateService());

            Assert.AreEqual("BaseUri", codeMemberField.Name);
            Assert.AreEqual(BaseUri.ToString(), GetReturnPrimitiveValue(codeMemberField));
        }

        #endregion

        #region Features

        /// <summary>
        /// Tests if the generation of a features list property works (for a non empty list)
        /// </summary>
        [Test]
        public void TestCreateFeaturesList()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var property = decorator.CreateFeaturesProperty(CreateService());

            Assert.AreEqual("Features", property.Name);

            Assert.That(property.GetStatements.Count, Is.EqualTo(1));
            Assert.That(property.GetStatements[0], Is.TypeOf(typeof(CodeMethodReturnStatement)));
            var returnStatement = property.GetStatements[0] as CodeMethodReturnStatement;
            Assert.That(returnStatement.Expression, Is.TypeOf(typeof(CodeArrayCreateExpression)));
            var arrayExpression = returnStatement.Expression as CodeArrayCreateExpression;

            Assert.That(arrayExpression.CreateType.BaseType, Is.EqualTo("System.string"));
            Assert.That(arrayExpression.Initializers.Count, Is.EqualTo(4));
        }

        /// <summary>
        /// Tests if the generation of a features list property works (for empty list)
        /// </summary>
        [Test]
        public void TestCreateEmptyFeaturesList()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var service = CreateService();
            ((MockService)service).Features = new List<String>();

            var property = decorator.CreateFeaturesProperty(service);

            Assert.AreEqual("Features", property.Name);

            Assert.That(property.GetStatements.Count, Is.EqualTo(1));
            Assert.That(property.GetStatements[0], Is.TypeOf(typeof(CodeMethodReturnStatement)));
            var returnStatement = property.GetStatements[0] as CodeMethodReturnStatement;
            Assert.That(returnStatement.Expression, Is.TypeOf(typeof(CodeArrayCreateExpression)));
            var arrayExpression = returnStatement.Expression as CodeArrayCreateExpression;

            Assert.That(arrayExpression.CreateType.BaseType, Is.EqualTo("System.string"));
            Assert.That(arrayExpression.Initializers.Count, Is.EqualTo(0));
        }

        #endregion

        #region Parameters

        /// <summary>
        /// Tests if the generation of a service parameters property works
        /// </summary>
        [Test]
        public void TestCreateParametersProprety()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var service = CreateService();

            var propertyCollection = decorator.CreateServiceParametersProperty();

            Assert.AreEqual(2, propertyCollection.Count);

            Assert.IsInstanceOf(typeof(CodeMemberField), propertyCollection[0]);
            Assert.IsInstanceOf(typeof(CodeMemberProperty), propertyCollection[1]);

            CodeMemberField field = (CodeMemberField)propertyCollection[0];
            CodeMemberProperty property = (CodeMemberProperty)propertyCollection[1];

            Assert.IsTrue(field.Name.Equals("_serviceParameters"));
            Assert.AreEqual("ServiceParameters", property.Name);

            Assert.AreEqual(2, property.Type.TypeArguments.Count);
            // read the following to understand the next assert
            // http://msdn.microsoft.com/en-us/library/system.codedom.codetypereference.basetype(v=vs.90).aspx
            Assert.AreEqual("System.Collections.Generic.IDictionary`2", property.Type.BaseType);

            Assert.AreEqual("System.String", property.Type.TypeArguments[0].BaseType);
            Assert.AreEqual("Google.Apis.Discovery.IParameter", property.Type.TypeArguments[1].BaseType);

        }

        #endregion

        [Test]
        public void DecorateClass()
        {
            var decorator = new BaseClientServiceAbstractPropertiesDecorator();
            var service = CreateService();

            var codeType = new CodeTypeDeclaration("TestClass");

            decorator.DecorateClass(service, codeType);

            codeType.BaseTypes.Add(new CodeTypeReference(typeof(MockBaseClientServiceAbstractPropertiesDecorator)));
            CheckCompile(codeType, false, "Failed To Compile result from StandardServiceFieldResourceDecorator",
                new[] { new CodeNamespaceImport("Google.Apis.Testing") },
                new[] { typeof(MockBaseClientServiceAbstractPropertiesDecorator) });
        }
    }
}
