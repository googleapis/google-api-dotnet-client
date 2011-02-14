using System;
using System.Collections.Generic;
using System.CodeDom;
using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen;

using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Tests.Generator;


namespace Google.Apis.Tools.CodeGen.Tests
{
    [TestFixture()]
    public class GoogleSchemaGeneratorTest
    {
        [Test()]
        public void ConstructorParameterValidationTest ()
        {
            Assert.Throws(typeof(ArgumentNullException), () => new GoogleSchemaGenerator(null, "Fish.Chips"));
            Assert.Throws(typeof(ArgumentNullException), () => new GoogleSchemaGenerator(new List<ISchemaDecorator>(), null));
            Assert.DoesNotThrow( () => new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips"));
        }
        
        [Test()]
        public void GenerateSchemaClassesParameterValidationTest ()
        {
            var generator = new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips");
            Assert.Throws(typeof(ArgumentNullException), () => generator.GenerateSchemaClasses(null));
            var mockService = new MockService();
            Assert.DoesNotThrow( () => generator.GenerateSchemaClasses(mockService));
        }
        
        [Test()]
        public void GenerateSchemaClassesTest ()
        {
            var generator = new GoogleSchemaGenerator(new List<ISchemaDecorator>(), "Fish.Chips");
            var mockService = new MockService();
            
            var mockSchema = new MockSchema();
            mockSchema.Id = "Fish";
            mockSchema.Name = "Fish";
            mockService.Schemas.Add("Fish", mockSchema);
            
            mockSchema = new MockSchema();
            mockSchema.Id = "Chips";
            mockSchema.Name = "Chips";
            mockService.Schemas.Add("Chips", mockSchema);
            
            CodeNamespace result = generator.GenerateSchemaClasses(mockService);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Types.Count);
            List<string> classNames = new List<string>(2);
            classNames.Add(result.Types[0].Name);
            classNames.Add(result.Types[1].Name);
            
            Assert.That(classNames.Contains("Fish"));
            Assert.That(classNames.Contains("Chips"));
        }
    }
}
