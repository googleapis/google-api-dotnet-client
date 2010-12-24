using System;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery
{
    [TestFixture()]
    public class ServiceFactoryImplTest
    {
        [Test()]
        public void ServiceFactoryDiscoveryV0_2ConstructorTest ()
        {
            var param = new FactoryParameterV0_2("server", "base");
            var json = (JsonDictionary)JsonReader.Parse(ServiceFactoryTest.V0_2SAMPLE_DISCOVERY);
            var fact = new ServiceFactoryDiscoveryV0_2(json, param);
            
            Assert.AreEqual("adsense-mgmt", fact.Name);
            Assert.AreEqual(param, fact.Param);
            Assert.AreEqual(json, fact.Information);
            
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceFactoryDiscoveryV0_2(null, param));
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceFactoryDiscoveryV0_2(json, null));
        }
    }
}

