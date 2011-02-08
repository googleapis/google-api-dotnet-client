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
using System.Collections.Generic;

using Newtonsoft.Json.Schema;
using NUnit.Framework;

using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
    
namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    [TestFixture()]
    public class StandardPropertyDecoratorTest
    {
        [Test()]
        public void ConstructorTest ()
        {
            Assert.DoesNotThrow(() => new StandardPropertyDecorator());
        }
        
        [Test()]
        public void DecoratClassTest ()
        {
            var decorator = new StandardPropertyDecorator();
            var declaration = new CodeTypeDeclaration();
            var schema = new MockSchema();
            Assert.Throws(typeof(ArgumentNullException), () => decorator.DecoratClass(null, schema));
            Assert.Throws(typeof(ArgumentNullException), () => decorator.DecoratClass(declaration, null));
        }
        
        [Test()]
        public void GenerateAllPropertiesTestEdgeCases()
        {
            var decorator = new StandardPropertyDecorator();
            Assert.Throws(typeof(ArgumentNullException), () => decorator.GenerateAllProperties(null));
            
            var schema = new MockSchema();
            schema.Name = "test";
            schema.SchemaDetails = null;
            Assert.Throws(typeof(ArgumentNullException), () => decorator.GenerateAllProperties(schema));
            
            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Properties = null;
            var expectedEmpty = decorator.GenerateAllProperties(schema);
            Assert.IsNotNull(expectedEmpty);
            Assert.AreEqual(0, expectedEmpty.Count);
        }
        
        [Test()]
        public void GenerateAllPropertiesTest ()
        {
            var schema = new MockSchema();
            schema.SchemaDetails = new JsonSchema();
            schema.SchemaDetails.Type = JsonSchemaType.Object;
            schema.SchemaDetails.Properties = new Dictionary<string, JsonSchema>();
            foreach(var pair in StandardPropertyFieldDecoratorTest.NamesToType)
            {
                JsonSchema property = new JsonSchema();
                property.Type = pair.Value;
                property.Id = pair.Key;
                schema.SchemaDetails.Properties.Add(pair.Key, property);
            }
            
            var decorator = new StandardPropertyDecorator();
            IList<CodeMemberProperty> generatedFields = decorator.GenerateAllProperties(schema);
            
            Assert.NotNull(generatedFields);
            Assert.AreEqual(StandardPropertyFieldDecoratorTest.NamesToType.Count, generatedFields.Count);
            foreach(var field in generatedFields)
            {
                Assert.That(StandardPropertyFieldDecoratorTest.NamesToType.ContainsKey(field.Name.ToLower()), "field name was not present in namesToType " + field.Name);                
            }
            
            int item = 0;
            foreach(var pair in StandardPropertyFieldDecoratorTest.NamesToType)
            {
                var field = generatedFields[item++];
                Assert.AreEqual(pair.Key, field.Name.ToLower(), string.Format("Name different for expected at index {0}", item -1));
                Assert.AreEqual(SchemaDecoratorUtil.GetCodeType(new JsonSchema(){Type = pair.Value}).BaseType, field.Type.BaseType);
            }
        }
        
       
    }
}

