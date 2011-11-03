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
using log4net;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Tests for the Log4NetResourceDecorator
    /// </summary>
    [TestFixture]
    public class Log4NetResourceDecoratorTest : BaseResourceDecoratorTest
    {
        /// <summary>
        /// Tests class decoration
        /// </summary>
        [Test]
        public void TestDecorateClass()
        {
            var resourceClass = CreateDecoratedResourceClass(new Log4NetResourceDecorator());
            Assert.AreEqual(1, resourceClass.Members.Count); // Assert One Member was added
            var declaration = resourceClass.Members[0];
            Assert.IsNotNull(declaration);
            Assert.IsInstanceOf(typeof(CodeMemberField), declaration);

            var field = (CodeMemberField) declaration;

            Assert.AreEqual(Log4NetResourceDecorator.LoggerName, field.Name);
            Assert.AreEqual(typeof(ILog).FullName, field.Type.BaseType);

            Assert.IsNotNull(field.InitExpression);

            // Partial compile so don't treat warning as errors yet.
            CheckCompile(resourceClass, false, "Failed To Compile after Log4NetResourceDecorator.DecorateClass");
        }

        /// <summary>
        /// Tests logging after method execution
        /// </summary>
        [Test]
        public void TestDecorateMethodAfterExecute()
        {
            var decorator = new Log4NetResourceDecorator();
            var resourceClass = CreateDecoratedResourceClass(decorator);
            var codeMember = new CodeMemberMethod();
            codeMember.Name = "OneTestMethod";
            resourceClass.Members.Add(codeMember);
            IResource resource = CreateResourceDiscoveryV_1_0("TestResource", SimpleResource);
            decorator.DecorateMethodBeforeExecute(resource, resource.Methods["simpleMethod"], codeMember);
            decorator.DecorateMethodAfterExecute(resource, resource.Methods["simpleMethod"], codeMember);

            Assert.AreEqual(2, codeMember.Statements.Count);
            var statment = codeMember.Statements[1];
            Assert.IsInstanceOf(typeof(CodeExpressionStatement), statment);

            CodeMethodInvokeExpression methodInvoke =
                (CodeMethodInvokeExpression) ((CodeExpressionStatement) statment).Expression;
            Assert.AreEqual(1, methodInvoke.Parameters.Count);
            Assert.IsInstanceOf(typeof(CodePrimitiveExpression), methodInvoke.Parameters[0]);
            Assert.AreEqual(
                "Done Executing TestResource.simpleMethod", ((CodePrimitiveExpression) methodInvoke.Parameters[0]).Value);

            CheckCompile(
                resourceClass, false, "Failed To Compile after Log4NetResourDecorator.DecorateMethodAfterExecute");
        }

        /// <summary>
        /// Tests logging before method execution
        /// </summary>
        [Test]
        public void TestDecorateMethodBeforeExecute()
        {
            var decorator = new Log4NetResourceDecorator();
            var resourceClass = CreateDecoratedResourceClass(decorator);
            var codeMember = new CodeMemberMethod();
            codeMember.Name = "OneTestMethod";
            resourceClass.Members.Add(codeMember);
            IResource resource = CreateResourceDiscoveryV_1_0("TestResource", SimpleResource);
            decorator.DecorateMethodBeforeExecute(resource, resource.Methods["simpleMethod"], codeMember);

            Assert.AreEqual(1, codeMember.Statements.Count);
            var statment = codeMember.Statements[0];
            Assert.IsInstanceOf(typeof(CodeExpressionStatement), statment);

            CodeMethodInvokeExpression methodInvoke =
                (CodeMethodInvokeExpression) ((CodeExpressionStatement) statment).Expression;
            Assert.AreEqual(1, methodInvoke.Parameters.Count);
            Assert.IsInstanceOf(typeof(CodePrimitiveExpression), methodInvoke.Parameters[0]);
            Assert.AreEqual(
                "Executing TestResource.simpleMethod", ((CodePrimitiveExpression) methodInvoke.Parameters[0]).Value);

            CheckCompile(
                resourceClass, false, "Failed To Compile after Log4NetResourDecorator.DecorteMethodBeforeExecute");
        }
    }
}