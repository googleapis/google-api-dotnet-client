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
        public void GenerateAllPropertiesTest (ISchema schema)
        {
        }
        
       
    }
}

