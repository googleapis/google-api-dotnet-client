using System;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery.V0_3
{
    [TestFixture()]
    public class ServiceTest
    {
        private const string TestVersion = "TestVersion";
        private const string TestName = "TestName";
  
        [Test()]
        public void ConstuctorArugumentValidationTest()
        {
            var param = new FactoryParameterV0_3(){
                ServerUrl = "http://server/"};
            var js = new JsonDictionary();
            js["restBasePath"] = "test/path";
            
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceV0_3(null, TestName, param, js));
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceV0_3(TestVersion, null, param, js));
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceV0_3(TestVersion, TestName, null, js));
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceV0_3(TestVersion, TestName, param, null));
            
            new ServiceV0_3(TestVersion, TestName, param, js);
        }
        
        [Test()]
        public void VersionTest ()
        {
            var param = new FactoryParameterV0_3(){
                ServerUrl = "http://server/"};
            var js = new JsonDictionary();
            js["restBasePath"] = "test/path";
            var service = new ServiceV0_3(TestVersion, TestName, param, js);
            Assert.AreEqual(service.DiscoveryVersion, DiscoveryVersion.Version_0_3);
        }
    }
}

