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
            var service = CreateService();
            Assert.AreEqual(service.DiscoveryVersion, DiscoveryVersion.Version_0_3);
        }
        
        
        
        [Test()]
        public void RessourceTest()
        {
            var service = CreateService();
            Assert.AreEqual(1, service.Resources.Count);
            Assert.IsNotNull(service.Resources["activities"]);
        }
        
        [Test()]
        public void SchemaTest()
        {
            var service = CreateService();
            Assert.AreEqual(31, service.Schemas.Count);
            Assert.IsNotNull(service.Schemas["Activitiylist"]);
            Assert.IsNotNull(service.Schemas["ChiliActivitiesCountJson"]);
            Assert.IsNotNull(service.Schemas["ChiliPeopleListJson"]);
            Assert.IsNotNull(service.Schemas["Video"]);
        }
        
        private ServiceV0_3 CreateService()
        {
            var param = new FactoryParameterV0_3(){
                ServerUrl = "http://server/"};
            var json = (JsonDictionary)JsonReader.Parse(ServiceFactoryImplTest.BuzzV0_3_Json);
            return new ServiceV0_3(TestVersion, TestName, param, json);
        }
    }
}

