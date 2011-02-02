using System;
using System.CodeDom;

using NUnit.Framework;
using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
    
namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    [TestFixture()]
    public class StandardPropertyDecoratorTest
    {
        [Test()]
        public void TestCase ()
        {
        }
        
        public void DecoratClassTest (CodeTypeDeclaration typeDeclaration, ISchema schema)
        {
            
        }
        
        
        public void GenerateAllFields (ISchema schema)
        {
            
        }
        
        public void GenerateField(string name, JsonSchema propertySchema, int index)
        {
            
        }
        
        [Test()]
        public void GetCodeType(JsonSchema propertySchema)
        {
            
        }
        
        [Test()]
        public void GenerateAllProperties (ISchema schema)
        {
        }
        
        [Test()]
        public void GetFieldName(string name, int index)
        {
            
        }
        
        [Test()]
        public void GetPropertyName()
        {
            var decorator = new StandardPropertyDecorator();
            Assert.AreEqual("Fish", decorator.GetPropertyName("fish",1));
            Assert.AreEqual("IntProperty1", decorator.GetPropertyName("int",1));
        }
    }
}

