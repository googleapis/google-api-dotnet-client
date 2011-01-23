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

using NUnit.Framework;
using Newtonsoft.Json.Schema;


using Google.Apis.Discovery.Schema;

namespace Google.Apis.Tests.Apis.Discovery.Schema
{
    [TestFixture()]
    public class FutureJsonSchemaTest
    {
        [Test()]
        public void ConstructorTest ()
        {
            var actual = new FutureJsonSchema("123ABC");
            Assert.False(actual.Resolved);
            Assert.AreEqual("123ABC", actual.Id);
            Assert.IsNull(actual.Maximum);
            Assert.IsNull(actual.Type);
        }
        
        [Test()]
        public void ResolveFailTest()
        {
            var actual = new FutureJsonSchema("123ABC");
            var wrongId = new JsonSchema(){Id = "Go Fish"};
            var wrongType = new FutureJsonSchema("123ABC");
            var sucess = new JsonSchema() {Id = "123ABC"};
            
            Assert.Throws(typeof(ArgumentException), () => actual.Resolve(wrongId));
            Assert.Throws(typeof(ArgumentException), () => actual.Resolve(wrongType));
            Assert.Throws(typeof(ArgumentNullException), () => actual.Resolve(null));
            
            actual.Resolve(sucess);
            
            Assert.Throws(typeof(InvalidOperationException), () => actual.Resolve(sucess));
        }
        
        [Test()]
        public void ResolveFailPass()
        {
            var actual = new FutureJsonSchema("123ABC");
            var sucess = new JsonSchema() {Id = "123ABC", Maximum = 12.5, Minimum = 5.3, Required = true };
            
            actual.Resolve(sucess);
            
            Assert.True(actual.Resolved);
            Assert.AreEqual(12.5, actual.Maximum.Value);
            Assert.AreEqual(5.3, actual.Minimum.Value);
            Assert.AreEqual(true, actual.Required);
        }
    }
}

