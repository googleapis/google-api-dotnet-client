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
using System;
using System.CodeDom;

using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    [TestFixture]
    public class StandardResourceNameResourceDecoratorTest:BaseResourceDecoratorTest
    {
        [Test]
        public void DecorateClassTest()
        {
            var decorator = new StandardResourceNameResourceDecorator();
            var decoratedClass = CreateDecoratedResourceClass(decorator);
            
            Assert.AreEqual(1, decoratedClass.Members.Count);
            Assert.IsInstanceOf(typeof(CodeMemberField), decoratedClass.Members[0]);
            Assert.AreEqual(ResourceBaseGenerator.ResourceNameConst, decoratedClass.Members[0].Name);
            
            CheckCompile(decoratedClass, false, "Failed To Compile StandardResourceNameResourceDecorator");
        }
        
        [Test]
        public void CreateResourceNameConstTest()
        {
            var decorator = new StandardResourceNameResourceDecorator();
            CodeMemberField codeField = decorator.CreateResourceNameConst("TestResourceName");
            
            Assert.AreEqual(ResourceBaseGenerator.ResourceNameConst, codeField.Name);
            Assert.AreEqual(typeof(string).FullName, codeField.Type.BaseType);
            Assert.IsInstanceOf(typeof(CodePrimitiveExpression),codeField.InitExpression);              
            
            var initExpression = (CodePrimitiveExpression)codeField.InitExpression;
            Assert.AreEqual("TestResourceName", initExpression.Value);
        }
    }
}