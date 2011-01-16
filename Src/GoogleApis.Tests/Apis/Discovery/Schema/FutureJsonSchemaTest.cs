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

