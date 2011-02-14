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

using Newtonsoft.Json.Schema;
using NUnit.Framework;

using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    [TestFixture()]
    public class SchemaDecoratorUtilTest
    {
        [Test()]
        public void GetFieldName ()
        {
            Assert.AreEqual("fISH", SchemaDecoratorUtil.GetFieldName("FISH",1));
            Assert.AreEqual("intField1", SchemaDecoratorUtil.GetFieldName("int",1));
        }
        
        [Test()]
        public void GetPropertyName ()
        {
            Assert.AreEqual("Fish", SchemaDecoratorUtil.GetPropertyName("fish",1));
            Assert.AreEqual("IntProperty1", SchemaDecoratorUtil.GetPropertyName("int",1));
        }
        
        [Test()]
        public void GetCodeTypeArgumentValidationTest ()
        {
            var internalClassProvider = new ObjectInternalClassProvider();
            Assert.Throws(typeof(ArgumentNullException), () => SchemaDecoratorUtil.GetCodeType(null, internalClassProvider));
            var schema = new JsonSchema();
            Assert.Throws(typeof(ArgumentNullException), () => SchemaDecoratorUtil.GetCodeType(schema, null));
            
            Assert.Throws(typeof(NotSupportedException), () => SchemaDecoratorUtil.GetCodeType(schema, internalClassProvider));
        }
        
        [Test()]
        public void GetCodeTypeTest ()
        {
            var schema = new JsonSchema();
            var internalClassProvider = new ObjectInternalClassProvider();
            schema.Type = JsonSchemaType.String;
            Assert.AreEqual(typeof(string).FullName, SchemaDecoratorUtil.GetCodeType(schema, internalClassProvider).BaseType);
            schema.Type = JsonSchemaType.Integer;
            Assert.AreEqual(typeof(long).FullName, SchemaDecoratorUtil.GetCodeType(schema, internalClassProvider).BaseType);
            schema.Type = JsonSchemaType.Float;
            Assert.AreEqual(typeof(double).FullName, SchemaDecoratorUtil.GetCodeType(schema, internalClassProvider).BaseType);
            schema.Type = JsonSchemaType.Boolean;
            Assert.AreEqual(typeof(bool).FullName, SchemaDecoratorUtil.GetCodeType(schema, internalClassProvider).BaseType);
        }
    }
}
