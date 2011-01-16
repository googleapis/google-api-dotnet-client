using System;

using NUnit.Framework;
using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;

namespace Google.Apis.Tests.Apis.Discovery.Schema
{
    [TestFixture()]
    public class FutureJsonSchemaResolverTest
    {
        [Test()]
        public void TestAddSimple ()
        {
            var resolver = new FutureJsonSchemaResolver();
            Assert.AreEqual(0, resolver.LoadedSchemas.Count);
            
            var schema1 = new JsonSchema(){Id = "1"};
            var schema2 = new JsonSchema(){Id = "2"};
            
            resolver.LoadedSchemas.Add(schema1);
            
            Assert.AreEqual(1, resolver.LoadedSchemas.Count);
            Assert.True(Object.ReferenceEquals(schema1, resolver.LoadedSchemas[0]));
            
            resolver.LoadedSchemas.Add(schema2);
            
            Assert.AreEqual(2, resolver.LoadedSchemas.Count);
            Assert.True(Object.ReferenceEquals(schema1, resolver.LoadedSchemas[0]));
            Assert.True(Object.ReferenceEquals(schema2, resolver.LoadedSchemas[1]));   
        }
        
        [Test()]
        public void TestAddDuplicateFail()
        {
            var resolver = new FutureJsonSchemaResolver();
            Assert.AreEqual(0, resolver.LoadedSchemas.Count);
            
            var schema1 = new JsonSchema(){Id = "1"};
            var schema2 = new JsonSchema(){Id = "1"};
            
            resolver.LoadedSchemas.Add(schema1);
            Assert.AreEqual(1, resolver.LoadedSchemas.Count);
            
            Assert.Throws<InvalidOperationException>( () => resolver.LoadedSchemas.Add(schema1));
            Assert.AreEqual(1, resolver.LoadedSchemas.Count);
            
            Assert.Throws<InvalidOperationException>( () => resolver.LoadedSchemas.Add(schema2));
            Assert.AreEqual(1, resolver.LoadedSchemas.Count);
        }
        
        [Test()]
        public void TestAddResolveFuture()
        {
            var resolver = new FutureJsonSchemaResolver();
            Assert.AreEqual(0, resolver.LoadedSchemas.Count);
            
            var futureSchema1 = new FutureJsonSchema("1");
            var schema1 = new JsonSchema(){Id = "1", Title = "Title For 1"};
            var futureSchema2 = new FutureJsonSchema("2");
            var schema2 = new JsonSchema(){Id = "2", Title = "Title For 2"};
            
            resolver.LoadedSchemas.Add(futureSchema1);
            resolver.LoadedSchemas.Add(futureSchema2);
            
            Assert.AreEqual(2, resolver.LoadedSchemas.Count);
            
            resolver.LoadedSchemas.Add(schema2);
            Assert.AreEqual(2, resolver.LoadedSchemas.Count);
            
            var resolvedFuture2 = resolver.GetSchema("2") as FutureJsonSchema;
            var resolvedFuture1 = resolver.GetSchema("1") as FutureJsonSchema;
            
            Assert.NotNull(resolvedFuture1);
            Assert.NotNull(resolvedFuture2);
            Assert.AreSame(resolvedFuture1, futureSchema1);
            Assert.AreSame(resolvedFuture2, futureSchema2);
            Assert.IsFalse(resolvedFuture1.Resolved);
            Assert.IsTrue(resolvedFuture2.Resolved);
            Assert.AreEqual("Title For 2", resolvedFuture2.Title);
            Assert.IsNull(resolvedFuture1.Title);
            
            resolver.LoadedSchemas.Add(schema1);
            Assert.AreEqual(2, resolver.LoadedSchemas.Count);
            
            resolvedFuture2 = resolver.GetSchema("2") as FutureJsonSchema;
            resolvedFuture1 = resolver.GetSchema("1") as FutureJsonSchema;
            
            Assert.NotNull(resolvedFuture1);
            Assert.NotNull(resolvedFuture2);
            Assert.AreSame(resolvedFuture1, futureSchema1);
            Assert.AreSame(resolvedFuture2, futureSchema2);
            Assert.IsTrue(resolvedFuture1.Resolved);
            Assert.IsTrue(resolvedFuture2.Resolved);
            Assert.AreEqual("Title For 2", resolvedFuture2.Title);
            Assert.AreEqual("Title For 1", resolvedFuture1.Title);
            
        }
        
        [Test()]
        public void TestGetSchemaSimplePresent()
        {
            var schema1 = new JsonSchema(){Id = "1", Title = "Title For 1"};
            var schema2 = new JsonSchema(){Id = "2", Title = "Title For 2"};
            var schema3 = new JsonSchema(){Id = "3", Title = "Title For 3"};
            
            var resolver = new FutureJsonSchemaResolver();
            resolver.LoadedSchemas.Add(schema1);
            resolver.LoadedSchemas.Add(schema2);
            resolver.LoadedSchemas.Add(schema3);
            
            var resolvedSchema2 = resolver.GetSchema("2");
            var resolvedSchema1 = resolver.GetSchema("1");
            var resolvedSchema3 = resolver.GetSchema("3");
            
            Assert.AreSame(schema1, resolvedSchema1);
            Assert.AreSame(schema2, resolvedSchema2);
            Assert.AreSame(schema3, resolvedSchema3);
        }
        
        [Test()]
        public void TestGetSchemaSimpleMissing()
        {
            var schema1 = new JsonSchema(){Id = "1", Title = "Title For 1"};
            var schema2 = new JsonSchema(){Id = "2", Title = "Title For 2"};
            var schema3 = new JsonSchema(){Id = "3", Title = "Title For 3"};
            
            var resolver = new FutureJsonSchemaResolver();
            resolver.LoadedSchemas.Add(schema1);
            resolver.LoadedSchemas.Add(schema2);
            resolver.LoadedSchemas.Add(schema3);
            
            var resolvedSchema2 = resolver.GetSchema("2");
            var resolvedSchema1 = resolver.GetSchema("1");
            var resolvedSchema3 = resolver.GetSchema("3");
            var resolvedSchema4 = resolver.GetSchema("4") as FutureJsonSchema;
            var resolvedSchema5 = resolver.GetSchema("5") as FutureJsonSchema;
            
            Assert.AreSame(schema1, resolvedSchema1);
            Assert.AreSame(schema2, resolvedSchema2);
            Assert.AreSame(schema3, resolvedSchema3);
            Assert.IsNotNull(resolvedSchema4);
            Assert.IsNotNull(resolvedSchema5);
            Assert.False(resolvedSchema4.Resolved);
            Assert.False(resolvedSchema5.Resolved);
            
        }
        
        [Test()]
        public void TestValidate()
        {
            var schema1 = new JsonSchema(){Id = "1", Title = "Title For 1"};
            var schema2 = new JsonSchema(){Id = "2", Title = "Title For 2"};
            var schema3 = new JsonSchema(){Id = "3", Title = "Title For 3"};
            var schema4 = new JsonSchema(){Id = "4", Title = "Title For 4"};
            var schema5 = new JsonSchema(){Id = "5", Title = "Title For 5"};
            
            var resolver = new FutureJsonSchemaResolver();
            resolver.LoadedSchemas.Add(schema1);
            resolver.LoadedSchemas.Add(schema2);
            resolver.LoadedSchemas.Add(schema3);
            
            resolver.GetSchema("4"); // Adds 4
            resolver.GetSchema("5"); // Adds 5
            
            Assert.Throws<ApplicationException>(() => resolver.ResolveAndVerify());
            
            resolver.LoadedSchemas.Add(schema5);
            
            Assert.Throws<ApplicationException>(() => resolver.ResolveAndVerify());
            
            resolver.LoadedSchemas.Add(schema4);
            
            Assert.DoesNotThrow(() => resolver.ResolveAndVerify());
        }
    }
}
