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
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery
{
    /// <summary>
    /// Tests the "ServiceFactory" class
    /// </summary>
    [TestFixture]
    public class ServiceFactoryTest
    {
        private const string EmptyJson = "{'Fish' : 'chips'}"; // I guess David wrote this :-D

        //TODO(davidwaters) Fill in exmaples
        public const string DiscoveryV1_0Example =
            @"{""kind"": ""discovery#restDescription"",
 ""id"": ""adsense:v1beta1"",
 ""name"": ""adsense"",
 ""version"": ""v1beta1"",
 ""description"": ""AdSense Management API"",
 ""icons"": {
  ""x16"": ""http://www.google.com/images/icons/product/search-16.gif"",
  ""x32"": ""http://www.google.com/images/icons/product/search-32.gif""
 },
 ""labels"": [
  ""labs""
 ],
 ""protocol"": ""rest"",
 ""basePath"": ""/adsense/v1beta1/"",
 ""auth"": {
        ""oauth2"": {
            ""scopes"": {
                ""https://www.googleapis.com/auth/adsense"": {
                    ""description"": ""View your AdSense data""
                }
            }
        }
 },
 ""schemas"": {'sample' : {'id':'Sample'}},
 ""resources"": {
  ""adclients"": {
   ""methods"": {
    ""list"": {
     ""id"": ""adsense.adclients.list"",
     ""path"": ""ad_clients"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad clients in this AdSense account."",
     ""response"": {
      ""$ref"": ""AdClients""
     },
     ""scopes"": [
      ""https://www.googleapis.com/auth/adsense""
     ]
    }
   }
  },
  ""adunits"": {
   ""methods"": {
    ""list"": {
     ""id"": ""adsense.adunits.list"",
     ""path"": ""ad_clients/{ad_client_id}/ad_units"",
     ""httpMethod"": ""GET"",
     ""description"": ""List all ad units in this AdSense account."",
     ""parameters"": {
      ""ad_client_id"": {
       ""type"": ""string"",
       ""description"": ""Ad client for which to list ad units."",
       ""required"": true,
       ""location"": ""path""
      }
     },
     ""parameterOrder"": [
      ""ad_client_id""
     ],
     ""response"": {
      ""$ref"": ""AdUnits""
     },
     ""scopes"": [
      ""https://www.googleapis.com/auth/adsense""
     ]
    }
   }
  }
 }
}
";

        public const string DiscoveryV0_3SmallestExample =
            "{'name' : 'SmallExample'," + "'restBasePath' : 'https://api.example.com/example'," + "'version' : 'v1'," +
            "'resources' : {'mgmt' : {'name' : 'mgmt', " + "'resources' : {" +
            "'a':{'name':'a'}, 'b':{'name':'b'}, 'c':{}}}";

        private Stream CreateStringStream(string source)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(source));
        }

        /// <summary>
        /// Tests that the CreateServiceFactory-method validates the discovery version
        /// </summary>
        [Test]
        public void TestCreateServiceFactoryInvalidVersion()
        {
            var stream = CreateStringStream(DiscoveryV1_0Example);
            Assert.Throws<NotSupportedException>(
                () => ServiceFactory.Get((DiscoveryVersion) 56));
        }

        /// <summary>
        /// Tests that the v0.3 discovery factory can be created
        /// </summary>
        [Test]
        public void TestCreateServiceFactoryV0_3()
        {
            var stream = CreateStringStream(DiscoveryV0_3SmallestExample);
            IServiceFactory factory = ServiceFactory.Get(DiscoveryVersion.Version_0_3);
            Assert.NotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV0_3), factory);
        }

        /// <summary>
        /// Tests that the v1.0 discovery factory can be created
        /// </summary>
        [Test]
        public void TestCreateServiceFactoryV1_0()
        {
            // Test without factory parameter
            var stream = CreateStringStream(DiscoveryV1_0Example);
            IServiceFactory factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);
            Assert.IsNotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV1_0), factory);
        }

        /// <summary>
        /// Tests that a v0.3 service can be created
        /// </summary>
        [Test]
        public void TestV0_3GetService()
        {
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_0_3);
            var json = JsonReader.Parse(CreateStringStream(DiscoveryV0_3SmallestExample)) as JsonDictionary;
            IService service = factory.CreateService(json, null);

            Assert.NotNull(service);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual("mgmt", service.Resources.Keys.First());
            Assert.AreEqual("a", service.Resources["mgmt"].Resources.Keys.First());
            Assert.AreEqual(3, service.Resources["mgmt"].Resources.Count);
            Assert.AreEqual("a", service.Resources["mgmt"].Resources.Keys.First());
        }

        /// <summary>
        /// Tests that a v1.0 service can be created
        /// </summary>
        [Test]
        public void TestV1_0GetService()
        {
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);
            var json = JsonReader.Parse(CreateStringStream(DiscoveryV1_0Example)) as JsonDictionary;
            IService service = factory.CreateService(json, null);

            Assert.NotNull(service);
            Assert.AreEqual(2, service.Resources.Count);
            Assert.AreEqual("adclients", service.Resources.Keys.First());
            Assert.AreEqual(1, service.Resources["adclients"].Methods.Count);
        }
    }
}