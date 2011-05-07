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
using System.IO;
using System.Text;
using System.Linq;


using NUnit.Framework;

using Google.Apis.Discovery;

namespace Google.Apis.Tests.Apis.Discovery
{


    [TestFixture()]
    public class ServiceFactoryTest
    {
        private const string EmptyJson = "{'Fish' : 'chips'}";
        //TODO(davidwaters) Fill in exmaples
        public const string DiscoveryV1_0Example = "{'Fish' : 'chips'}";
        public const string DiscoveryV0_3Example = "{'Fish' : 'chips'}";
        
        [Test()]
        public void TestV1_0GetService()
        {
            var param = new FactoryParameterV1_0();
            var factory = ServiceFactory.CreateServiceFactory(CreateStringStream(DiscoveryV1_0Example), DiscoveryVersion.Version_1_0, param);
            IService service = factory.GetService ("v1beta1");
            
            Assert.NotNull(service);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual("mgmt", service.Resources.Keys.First());
            Assert.AreEqual(5, service.Resources["mgmt"].Resources.Count);
        }
        
        [Test()]
        public void TestV0_3GetService()
        {
            var param = new FactoryParameterV0_3();
            var factory = ServiceFactory.CreateServiceFactory(CreateStringStream(DiscoveryV1_0Example), DiscoveryVersion.Version_0_3, param);
            IService service = factory.GetService ("v1beta1");
            
            Assert.NotNull(service);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual("mgmt", service.Resources.Keys.First());
            Assert.AreEqual(5, service.Resources["mgmt"].Resources.Count);
        }
      
        [Test()]
        public void TestCreateServiceFactoryV1_0()
        {
            Assert.Fail("No Test yet");
            var stream = CreateStringStream(EmptyJson);
            var param = new FactoryParameterV1_0();
            IServiceFactory factory = ServiceFactory.CreateServiceFactory (stream, DiscoveryVersion.Version_1_0, param);
            Assert.IsNotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV1_0), factory);
        }
        
        [Test()]
        public void TestCreateServiceFactoryV0_3()
        {
            var stream = CreateStringStream(EmptyJson);
            var param = new FactoryParameterV0_3();
            IServiceFactory factory = ServiceFactory.CreateServiceFactory(stream, DiscoveryVersion.Version_0_3, param);
            Assert.NotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV0_3), factory);
        }
        
        [Test()]
        public void TestCreateServiceFactoryInvalidVersion()
        {
            var stream = CreateStringStream(EmptyJson);
            Assert.Throws<NotSupportedException>(() => ServiceFactory.CreateServiceFactory (stream, (DiscoveryVersion)56, null));
        }
        
        [Test()]
        public void TestCreateServiceFactoryInvalidParameters()
        {
            var stream = CreateStringStream(EmptyJson);
            var param = new FactoryParameterV1_0();
            Assert.Throws<ArgumentNullException>(() => ServiceFactory.CreateServiceFactory (null, DiscoveryVersion.Version_1_0, param));
            Assert.Throws<ArgumentNullException>(() => ServiceFactory.CreateServiceFactory (stream, DiscoveryVersion.Version_1_0, null));
        }
        
        private Stream CreateStringStream(string source)
        {
            return new MemoryStream(UTF8Encoding.UTF8.GetBytes(source));
        }
    }
}
