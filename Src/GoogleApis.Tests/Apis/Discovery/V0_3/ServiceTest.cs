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
using System.Collections.Generic;
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
        
        private const string SchemaJson = @"{
              'ChiliPhotoalbumsListJson': '{\'id\':\'ChiliPhotoalbumsListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotoalbumsResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#albumsFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
              'ChiliPhotoalbumsResourceJson': '{\'id\':\'ChiliPhotoalbumsResourceJson\',\'properties\':{\'tags\':{\'items\':{\'type\':\'string\'},\'type\':\'array\'},\'id\':{\'type\':\'integer\'},\'firstPhotoId\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'lastModified\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'links\':{\'properties\':{\'alternate\':{\'$ref\':\'Link\'},\'enclosure\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'},\'version\':{\'type\':\'integer\'}},\'type\':\'object\'}',
              'ChiliPhotosInsertJson': '{\'id\':\'ChiliPhotosInsertJson\',\'properties\':{\'collection\':{\'properties\':{\'albumId\':{\'type\':\'any\'},\'album\':{\'type\':\'any\'},\'photo\':{\'properties\':{\'photoUrl\':{\'type\':\'any\'}},\'type\':\'object\'}},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#album\',\'type\':\'string\'}},\'type\':\'object\'}',
              'ChiliPhotosListJson': '{\'id\':\'ChiliPhotosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#photosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
              'ChiliPhotosResourceJson': '{\'id\':\'ChiliPhotosResourceJson\',\'properties\':{\'lastModified\':{\'type\':\'string\'},\'album\':{\'properties\':{\'id\':{\'type\':\'integer\'},\'page_link\':{\'$ref\':\'Link\'}},\'type\':\'object\'},\'links\':{\'additionalProperties\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'properties\':{\'alternate\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'}},\'type\':\'object\'},\'kind\':{\'type\':\'string\'},\'version\':{\'type\':\'integer\'},\'id\':{\'type\':\'integer\'},\'timestamp\':{\'type\':\'number\'},\'fileSize\':{\'type\':\'integer\'},\'title\':{\'type\':\'string\'},\'created\':{\'type\':\'string\'},\'description\':{\'type\':\'string\'},\'owner\':{\'properties\':{\'id\':{\'type\':\'string\'},\'profileUrl\':{\'type\':\'string\'},\'thumbnailUrl\':{\'type\':\'string\'},\'name\':{\'type\':\'string\'}},\'type\':\'object\'},\'video\':{\'$ref\':\'Video\'}},\'type\':\'object\'}',
              'ChiliVideosListJson': '{\'id\':\'ChiliVideosListJson\',\'properties\':{\'items\':{\'items\':{\'$ref\':\'ChiliPhotosResourceJson\'},\'type\':\'array\'},\'kind\':{\'default\':\'buzz#videosFeed\',\'type\':\'string\'}},\'type\':\'object\'}',
              'Link': '{\'id\':\'Link\',\'properties\':{\'title\':{\'type\':\'string\'},\'height\':{\'type\':\'integer\'},\'count\':{\'type\':\'integer\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'integer\'},\'type\':{\'type\':\'string\'},\'href\':{\'type\':\'string\'}},\'type\':\'object\'}',
              'Video': '{\'id\':\'Video\',\'properties\':{\'duration\':{\'type\':\'integer\'},\'streams\':{\'items\':{\'$ref\':\'Link\'},\'type\':\'array\'},\'size\':{\'type\':\'integer\'}},\'type\':\'object\'}'
             }";
  
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
            Assert.IsTrue(service.Schemas.ContainsKey("Activitiylist"));
            Assert.IsTrue(service.Schemas.ContainsKey("ChiliActivitiesCountJson"));
            Assert.IsTrue(service.Schemas.ContainsKey("ChiliPeopleListJson"));
            Assert.IsTrue(service.Schemas.ContainsKey("Video"));
            Assert.IsNotNull(service.Schemas["Activitiylist"].SchemaDetails);
            Assert.IsNotNull(service.Schemas["ChiliActivitiesCountJson"].SchemaDetails);
            Assert.IsNotNull(service.Schemas["ChiliPeopleListJson"].SchemaDetails);
            Assert.IsNotNull(service.Schemas["Video"].SchemaDetails);
        }
        
        [Test()]
        public void ParseSchemasTest()
        {
            JsonDictionary js = (JsonDictionary) Google.Apis.Json.JsonReader.Parse(SchemaJson);
            var dict = ServiceV0_3.ParseSchemas(js);
            Assert.IsNotNull(dict);
            Assert.AreEqual(8, dict.Count);
            foreach(string key in new string[]{"ChiliPhotoalbumsListJson","ChiliPhotoalbumsResourceJson", "ChiliPhotosInsertJson", "ChiliPhotosListJson", 
                "ChiliPhotosResourceJson", "ChiliVideosListJson", "Link", "Video"})
            {
                Assert.True(dict.ContainsKey(key),string.Format("Key[{0}] was not found", key)); 
                Assert.IsNotNull(dict[key],string.Format("Key[{0}] was null", key));
            }
        }
        
        [Test()]
        public void ParseSchemasEmptyTest()
        {
            JsonDictionary js = new JsonDictionary();
            var dict = ServiceV0_3.ParseSchemas(js);
            Assert.AreEqual(0, dict.Count);
        }
        
        [Test()]
        public void ParseSchemasArgumentTest()
        {
            Assert.Throws(typeof(ArgumentNullException), () => ServiceV0_3.ParseSchemas(null));
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
