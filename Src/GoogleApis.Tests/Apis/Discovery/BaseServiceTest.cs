// /*
// Copyright 2011 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */
using System;
using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Testing;
using Google.Apis.Util;


namespace Google.Apis.Tests.Apis.Discovery
{
    [TestFixture()]
    public class BaseServiceTest
    {
        private class ConcreateClass : BaseService
        {
            public ConcreateClass(string version, string name, JsonDictionary js): base(version, name, js)
            {
                ;
            }
            
            public override Uri BaseUri {
                get {throw new NotImplementedException ();}
            }

            public override DiscoveryVersion DiscoveryVersion {
                get {throw new NotImplementedException ();}
            }
        }
        
        
        [Test()]
        public void TestNoThrowOnFieldsMissing()
        {
            var dict = new JsonDictionary();
            var impl = new ConcreateClass("V1","NameTest", dict);
            
            Assert.AreEqual("V1", impl.Version);
            Assert.IsNull(impl.Id);
            Assert.IsNotNull(impl.Labels);
            MoreAsserts.IsEmpty(impl.Labels);
            Assert.AreEqual("NameTest", impl.Name);
            Assert.IsNull(impl.Protocol);
        }
        
        [Test()]
        public void TestSimpleGetters()
        {
            var dict = new JsonDictionary();
            dict.Add("description", "Test Description");
            dict.Add("documentationLink", "https://ww.google.com/");
            dict.Add("features", new ArrayList(){"feature1", "feature2"});
            dict.Add("labels", new ArrayList(){"label1", "label2"});
            dict.Add("id", "TestId");
            
            IService impl = new ConcreateClass("V1", "NameTest", dict);
            Assert.AreEqual("Test Description", impl.Description);
            Assert.AreEqual("https://ww.google.com/", impl.DocumentationLink);
            MoreAsserts.ContentsEqualAndInOrder(new List<string>(){"feature1", "feature2"}, impl.Features);
            MoreAsserts.ContentsEqualAndInOrder(new List<string>(){"label1", "label2"}, impl.Labels);
            Assert.AreEqual("TestId", impl.Id);
        }
    }
}

