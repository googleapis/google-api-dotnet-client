using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    [TestFixture()]
    public class SchemaAwearExecuteMethodDecoratorTest
    {
        [Test()]
        public void TestCreateExecuteMethod ()
        {
            var decorator = new SchemaAwearExecuteMethodDecorator();
            var createdMethod = decorator.CreateExecuteMethod();
            
            Assert.AreEqual(4, createdMethod.Parameters.Count);
            Assert.AreEqual(new CodeTypeReference(typeof(string)).BaseType, createdMethod.Parameters[0].Type.BaseType);
            Assert.AreEqual(new CodeTypeReference(typeof(string)).BaseType, createdMethod.Parameters[1].Type.BaseType);
            Assert.AreEqual(new CodeTypeReference(typeof(object)).BaseType, createdMethod.Parameters[2].Type.BaseType);
            Assert.AreEqual(new CodeTypeReference(typeof(IDictionary<string, string>)).BaseType, createdMethod.Parameters[3].Type.BaseType);
            
            Assert.AreSame(new CodeTypeReference(typeof(Stream)).BaseType, createdMethod.ReturnType.BaseType);
        }
    }
}
