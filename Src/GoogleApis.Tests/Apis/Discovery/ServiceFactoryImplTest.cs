using System;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery
{
    [TestFixture()]
    public class ServiceFactoryImplTest
    {
        internal const string BadDiscoveryv0_2_No_Name =  @"{
 'NO_name': 'adsense-mgmt',
 'version': 'v1beta1',
 'description': 'AdSense Management API',
 'restBasePath': '/adsense-mgmt/v1beta1/',
 'rpcPath': '/rpc',
 'resources': {
  'mgmt': {
   'resources': {
    'adunits': {'foo':'bar' }
    }
    }
    }
    }";

        [Test()]
        public void ServiceFactoryDiscoveryV0_2ConstructorSucsessFail ()
        {
            var param = new FactoryParameterV0_2("server", "base");
            var json = (JsonDictionary)JsonReader.Parse(ServiceFactoryTest.V0_2SAMPLE_DISCOVERY);
            
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceFactoryDiscoveryV0_2(null, param));
            Assert.Throws(typeof(ArgumentNullException), () => new ServiceFactoryDiscoveryV0_2(json, null));
            
            json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv0_2_No_Name);
            Assert.Throws(typeof(ArgumentException), () => new ServiceFactoryDiscoveryV0_2(json, param));
        }
        
        [Test()]
        public void ServiceFactoryDiscoveryV0_2ConstructorSucsessTest ()
        {
            var param = new FactoryParameterV0_2("server", "http://base");
            var json = (JsonDictionary)JsonReader.Parse(ServiceFactoryTest.V0_2SAMPLE_DISCOVERY);
            var fact = new ServiceFactoryDiscoveryV0_2(json, param);
            
            Assert.AreEqual("adsense-mgmt", fact.Name);
            Assert.AreEqual(param, fact.Param);
            Assert.AreEqual(json, fact.Information);
            Assert.IsInstanceOf(typeof(ServiceV0_2), fact.GetService("v1"));
        }
    }
}

