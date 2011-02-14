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

