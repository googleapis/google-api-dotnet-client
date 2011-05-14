using System;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Util;


namespace Google.Apis.Tests.Apis.Discovery
{
    [TestFixture()]
    public class BaseServiceTest
    {
        private class ConcreateClass : BaseService
        {
            public ConcreateClass(string version, string name, JsonDictionary js): base(version, name, js)
            {
                ;
            }
            
            public override Uri BaseUri {
                get {throw new NotImplementedException ();}
            }

            public override DiscoveryVersion DiscoveryVersion {
                get {throw new NotImplementedException ();}
            }
        }
        
        
        [Test()]
        public void TestNoThrowOnFieldsMissing()
        {
            var dict = new JsonDictionary();
            var impl = new ConcreateClass("V1","NameTest", dict);
            
            Assert.AreEqual("V1", impl.Version);
            Assert.AreEqual(null, impl.Id);
            Assert.IsNotNull(impl.Labels);
            MoreAsserts.IsEmpty(impl.Labels);
            Assert.AreEqual("NameTest", impl.Name);
            Assert.IsNull(impl.Protocol);
        }
        
        [Test()]
        public void TestSimpleGetters()
        {
            var dict = new JsonDictionary();
            dict.Add("basePath", "TestBasePath");
            dict.Add("description", "Test Description");
            dict.Add("documentationLink", "https://ww.google.com/");
            dict.Add("features", new ArrayList(){"feature1", "feature2"});
            dict.Add("id", "TestId");
            
            Assert.Fail("Test yet to be written");
        }
    }
}

