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
        
        internal const string V0_1SAMPLE_DISCOVERY = @"{
            'data':{
                'buzz':{
                    'v1':{'baseUrl':'https://www.googleapis.com/buzz/v1/',
                        'resources':{
                            'activities':{'methods':{'count':{'pathUrl':'activities/count','rpcName':'chili.activities.count','httpMethod':'GET','methodType':'rest','parameters':{'hl':{'parameterType':'query','required':false},'url':{'parameterType':'query','required':false}}},'delete':{'pathUrl':'activities/{userId}/{scope}/{postId}','rpcName':'chili.activities.delete','httpMethod':'DELETE','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'scope':{'parameterType':'path','pattern':'@.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'extractPeopleFromSearch':{'pathUrl':'activities/search/@people','rpcName':'chili.activities.extractPeopleFromSearch','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'bbox':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'lat':{'parameterType':'query','required':false},'lon':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'pid':{'parameterType':'query','required':false},'q':{'parameterType':'query','required':false},'radius':{'parameterType':'query','required':false}}},'get':{'pathUrl':'activities/{userId}/@self/{postId}','rpcName':'chili.activities.get','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'targetLang':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'insert':{'pathUrl':'activities/{userId}/@self','rpcName':'chili.activities.insert','httpMethod':'POST','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'media':{'parameterType':'query','required':false},'preview':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'list':{'pathUrl':'activities/{userId}/{scope}','rpcName':'chili.activities.list','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'max-comments':{'parameterType':'query','required':false},'max-liked':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'scope':{'parameterType':'path','pattern':'@(self|public|consumption|liked|comments)*','required':true},'targetLang':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'search':{'pathUrl':'activities/search','rpcName':'chili.activities.search','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'bbox':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'lat':{'parameterType':'query','required':false},'lon':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'pid':{'parameterType':'query','required':false},'q':{'parameterType':'query','required':false},'radius':{'parameterType':'query','required':false},'targetLang':{'parameterType':'query','required':false}}},'track':{'pathUrl':'activities/track','rpcName':'chili.activities.track','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'bbox':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'lat':{'parameterType':'query','required':false},'lon':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'pid':{'parameterType':'query','required':false},'q':{'parameterType':'query','required':false},'radius':{'parameterType':'query','required':false}}},'update':{'pathUrl':'activities/{userId}/{scope}/{postId}','rpcName':'chili.activities.update','httpMethod':'PUT','methodType':'rest','parameters':{'abuseType':{'parameterType':'query','required':false},'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'scope':{'parameterType':'path','pattern':'@.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}},
                            'comments':{'methods':{'delete':{'pathUrl':'activities/{userId}/@self/{postId}/@comments/{commentId}','rpcName':'chili.comments.delete','httpMethod':'DELETE','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'commentId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'get':{'pathUrl':'activities/{userId}/@self/{postId}/@comments/{commentId}','rpcName':'chili.comments.get','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'commentId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'targetLang':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'insert':{'pathUrl':'activities/{userId}/@self/{postId}/@comments','rpcName':'chili.comments.insert','httpMethod':'POST','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'list':{'pathUrl':'activities/{userId}/{scope}/{postId}/@comments','rpcName':'chili.comments.list','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'scope':{'parameterType':'path','pattern':'@.*','required':true},'targetLang':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'update':{'pathUrl':'activities/{userId}/{scope}/{postId}/@comments/{commentId}','rpcName':'chili.comments.update','httpMethod':'PUT','methodType':'rest','parameters':{'abuseType':{'parameterType':'query','required':false},'alt':{'parameterType':'query','required':false},'commentId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'scope':{'parameterType':'path','pattern':'@.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}},
                            'groups':{'methods':{'delete':{'pathUrl':'people/{userId}/@groups/{groupId}','rpcName':'chili.groups.delete','httpMethod':'DELETE','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'get':{'pathUrl':'people/{userId}/@groups/{groupId}/@self','rpcName':'chili.groups.get','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'insert':{'pathUrl':'people/{userId}/@groups','rpcName':'chili.groups.insert','httpMethod':'POST','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'list':{'pathUrl':'people/{userId}/@groups','rpcName':'chili.groups.list','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'update':{'pathUrl':'people/{userId}/@groups/{groupId}/@self','rpcName':'chili.groups.update','httpMethod':'PUT','methodType':'rest','parameters':{'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}},
                            'people':{'methods':{'delete':{'pathUrl':'people/{userId}/@groups/{groupId}/{personId}','rpcName':'chili.people.delete','httpMethod':'DELETE','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'personId':{'parameterType':'path','pattern':'(?!@self).*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'get':{'pathUrl':'people/{userId}/@self','rpcName':'chili.people.get','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'liked':{'pathUrl':'activities/{userId}/{scope}/{postId}/{groupId}','rpcName':'chili.people.liked','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'@liked','required':true},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'list':{'pathUrl':'people/{userId}/@groups/{groupId}','rpcName':'chili.people.list','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'relatedToUri':{'pathUrl':'people/{userId}/@related','rpcName':'chili.people.relatedToUri','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'uri':{'parameterType':'query','required':false}}},'reshared':{'pathUrl':'activities/{userId}/{scope}/{postId}/{groupId}','rpcName':'chili.people.reshared','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'@reshared','required':true},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}},'search':{'pathUrl':'people/search','rpcName':'chili.people.search','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'q':{'parameterType':'query','required':false}}},'update':{'pathUrl':'people/{userId}/@groups/{groupId}/{personId}','rpcName':'chili.people.update','httpMethod':'PUT','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'groupId':{'parameterType':'path','pattern':'[^/]+','required':true},'hl':{'parameterType':'query','required':false},'personId':{'parameterType':'path','pattern':'(?!@self).*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}},
                            'photos':{'methods':{'insert':{'pathUrl':'photos/{userId}/{albumId}','rpcName':'chili.photos.insert','httpMethod':'POST','methodType':'rest','parameters':{'albumId':{'parameterType':'path','pattern':'(@new|[^@].*)','required':true},'hl':{'parameterType':'query','required':false},'media':{'parameterType':'query','required':false},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}},
                            'related':{'methods':{'list':{'pathUrl':'activities/{userId}/{scope}/{postId}/@related','rpcName':'chili.related.list','httpMethod':'GET','methodType':'rest','parameters':{'alt':{'parameterType':'query','required':false},'c':{'parameterType':'query','required':false},'hl':{'parameterType':'query','required':false},'max-results':{'parameterType':'query','required':false},'postId':{'parameterType':'path','pattern':'.*','required':true},'scope':{'parameterType':'path','pattern':'@.*','required':true},'userId':{'parameterType':'path','pattern':'[^/]+','required':true}}}}}}},'v1partners':{'baseUrl':'https://www.googleapis.com/'}}}}";

        internal const string V0_2SAMPLE_DISCOVERY = @"

{
 'name': 'adsense-mgmt',
 'version': 'v1beta1',
 'description': 'AdSense Management API',
 'restBasePath': '/adsense-mgmt/v1beta1/',
 'rpcPath': '/rpc',
 'resources': {
  'mgmt': {
   'resources': {
    'adunits': {
     'methods': {
      'list': {
       'restPath': 'web_properties/{property_code}/ad_units',
       'rpcMethod': 'adsense.mgmt.adunits.list',
       'httpMethod': 'GET',
       'parameters': {
        'property_code': {
         'restParameterType': 'path',
         'pattern': '[^/]+',
         'required': true
        }
       }
      }
     }
    },
    'customchannels': {
     'methods': {
      'list': {
       'restPath': 'web_properties/{property_code}/custom_channels',
       'rpcMethod': 'adsense.mgmt.customchannels.list',
       'httpMethod': 'GET',
       'parameters': {
        'property_code': {
         'restParameterType': 'path',
         'pattern': '[^/]+',
         'required': true
        }
       }
      }
     }
    },
    'reports': {
     'methods': {
      'generate': {
       'restPath': 'reports/generate',
       'rpcMethod': 'adsense.mgmt.reports.generate',
       'httpMethod': 'GET'
      }
     }
    },
    'urlchannels': {
     'methods': {
      'list': {
       'restPath': 'web_properties/{property_code}/url_channels',
       'rpcMethod': 'adsense.mgmt.urlchannels.list',
       'httpMethod': 'GET',
       'parameters': {
        'property_code': {
         'restParameterType': 'path',
         'pattern': '[^/]+',
         'required': true
        }
       }
      }
     }
    },
    'webproperties': {
     'methods': {
      'list': {
       'restPath': 'web_properties',
       'rpcMethod': 'adsense.mgmt.webproperties.list',
       'httpMethod': 'GET'
      }
     }
    }
   }
  }
 }
}
";
        [Test()]
        public void TestV02GetService ()
        {
            UTF8Encoding.UTF8.GetBytes(V0_2SAMPLE_DISCOVERY);
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V0_2SAMPLE_DISCOVERY));
            var param = new FactoryParameterV0_2();
            param.ServerUrl = "http://elephant.lon:9996/";
            IServiceFactory factory = ServiceFactory.CreateServiceFactory (ms, DiscoveryVersion.Version_0_2, param);
            IService service = factory.GetService ("v1beta1");
            
            Assert.NotNull(service);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual("mgmt", service.Resources.Keys.First());
            Assert.AreEqual(5, service.Resources["mgmt"].Resources.Count);
            
        }
        
        
        [Test()]
        public void TestCreateServiceFactoryV0_1()
        {
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V0_1SAMPLE_DISCOVERY));
           
            IServiceFactory factory = ServiceFactory.CreateServiceFactory (ms, DiscoveryVersion.Version_0_1, null);
            Assert.IsNotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV0_1), factory);
        }
        
        [Test()]
        public void TestCreateServiceFactoryV0_2()
        {
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V0_2SAMPLE_DISCOVERY));
            var param = new FactoryParameterV0_2();
            param.ServerUrl = "http://elephant.lon:9996/";
            
            IServiceFactory factory = ServiceFactory.CreateServiceFactory (ms, DiscoveryVersion.Version_0_2, param);
            Assert.IsNotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV0_2), factory);
        }
        
        [Test()]
        public void TestCreateServiceFactoryInvalidVersion()
        {
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V0_2SAMPLE_DISCOVERY));
            Assert.Throws<NotSupportedException>(() => ServiceFactory.CreateServiceFactory (ms, (DiscoveryVersion)56, null));
        }
        
        [Test()]
        public void TestCreateServiceFactoryV0_3()
        {
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V0_3.ServiceFactoryImplTest.BuzzV0_3_Json));
            var param = new FactoryParameterV0_3();
            IServiceFactory factory = ServiceFactory.CreateServiceFactory(ms, DiscoveryVersion.Version_0_3, param);
            Assert.NotNull(factory);
            Assert.IsInstanceOf(typeof(ServiceFactoryDiscoveryV0_3), factory);
        }
    }
}
