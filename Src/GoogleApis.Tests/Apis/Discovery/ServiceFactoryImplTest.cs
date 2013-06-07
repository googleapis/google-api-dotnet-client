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
    /// <summary>
    /// Test case for ServiceFactoryImpl.cs
    /// </summary>
    [TestFixture]
    public class ServiceFactoryImplTest
    {
        internal const string BadDiscoveryv1_0_No_Name =
            @"{
                'version': 'v1',
                'description': 'desc',
                'rootUrl': 'https://www.example.com/',
                'basePath': '/something/v1/',                    
                'resources': {
                    'mgmt': {
                        'resources': {
                            'adunits': {'foo':'bar' }
                        }
                    }
                }
            }";
        internal const string BadDiscoveryv1_0_No_RootUrl =
            @"{
                'name': 'NAME',
                'version': 'v1',
                'description': 'desc',
                'basePath': '/basePath/v1/',
                'resources': {
                    'mgmt': {
                        'resources': {
                            'adunits': {'foo':'bar' }
                        }
                    }
                }
            }";
        internal const string BadDiscoveryv1_0_No_BasePath =
            @"{
                'name': 'NAME',
                'version': 'v1',
                'description': 'desc',
                'rootUrl': 'https://www.example.com/',
                'resources': {
                    'mgmt': {
                        'resources': {
                            'adunits': {'foo':'bar' }
                        }
                    }
                }
            }";
        internal const string ValidDiscoveryv1_0 =
            @"{
                ""name"": ""NAME"",
                ""version"": ""v1"",
                ""description"": ""desc"",
                ""rootUrl"": ""https://www.example.com/"",
                ""basePath"": ""/something/v1/"",
                ""resources"": {
                    ""mgmt"": {
                        ""resources"": {
                            ""adunits"": {""foo"":""bar"" }
                        }
                    }
                }
            }";

        /// <summary> Tests that the v1.0 constructor will fail when provided with invalid arguments. </summary>
        [Test]
        public void ServiceFactoryDiscoveryV1_0_ConstructorFailTest()
        {
            Assert.Throws<ArgumentNullException>(() => new FactoryParameters((string)null));
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);

            // discovery doc is null
            Assert.Throws(typeof(ArgumentNullException), () => factory.CreateService(null, null));

            // name is missing the discovery doc
            var json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv1_0_No_Name);
            Assert.Throws(typeof(ArgumentException), () => factory.CreateService(json, null));

            // basePath is missing in the dicsvoery doc, and there is no use in FactoryParameters
            json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv1_0_No_BasePath);
            Assert.Throws(typeof(ArgumentException), () => factory.CreateService(json, null));

            // rootUrl is missing in the dicsvoery doc, and there is no use in FactoryParameters
            json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv1_0_No_RootUrl);
            Assert.Throws(typeof(ArgumentException), () => factory.CreateService(json, null));
        }

        /// <summary> Tests that the v1.0 constructor will work when provided with valid arguments. </summary>
        [Test]
        public void ServiceFactoryDiscoveryV1_0_ConstructorSuccessTest()
        {
            var json = (JsonDictionary)JsonReader.Parse(ValidDiscoveryv1_0);
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);

            var service = factory.CreateService(json, null);
            Assert.IsInstanceOf(typeof(ServiceV1_0), service);
            Assert.AreEqual("NAME", service.Name);

            // other constructor success tests appear in ServiceFactoryDiscoveryV10_BaseUri test
        }

        /// <summary> Tests that BaseUri property is set with the expected value. </summary>
        [Test]
        public void ServiceFactoryDiscoveryV1_0_BaseUri()
        {
            var param = new FactoryParameters("http://server/path/");
            var factory = ServiceFactory.Get(DiscoveryVersion.Version_1_0);

            // discovery doc contains both baseUrl and rootUrl, create service with FactoryParameters.
            // BaseUri is equal to factory parameters URI
            var json = (JsonDictionary)JsonReader.Parse(ValidDiscoveryv1_0);
            var service = factory.CreateService(json, param);
            Assert.AreEqual("http://server/path/", service.BaseUri.ToString());

            // discovery doc contains both baseUrl and rootUrl, create service without FactoryParameters.
            // BaseUri is equal to the rootUrl + basePath from discovery doc
            service = factory.CreateService(json, null);
            Assert.AreEqual("https://www.example.com/something/v1/", service.BaseUri.ToString());

            // discovery doc contains basePath but not rootUrl, create service with FactoryParameters.
            // BaseUri is equal to factory parameters URI
            json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv1_0_No_RootUrl);
            service = factory.CreateService(json, param);
            Assert.AreEqual("http://server/path/", service.BaseUri.ToString());

            // discovery doc contains rootUrl but not BasePath, create service with FactoryParameters.
            // BaseUri is equal to factory parameters URI
            json = (JsonDictionary)JsonReader.Parse(BadDiscoveryv1_0_No_BasePath);
            service = factory.CreateService(json, param);
            Assert.AreEqual("http://server/path/", service.BaseUri.ToString());
        }
    }
}