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

using Google.Apis.Requests;

namespace Google.Apis.Tests.Apis.Requests
{
    [TestFixture()]
    public class RequestTest
    {
        private const string SimpleDeveloperKey = "ABC123";
        private const string ComplexDeveloperKey = "?&^%  ABC123";
        [Test()]
        public void ConstructorTest ()
        {
            var request = new Request();
            Assert.IsNotNull(request.Authenticator);
            Assert.IsNotNullOrEmpty(request.AppName);
        }
        
        [Test()]
        public void WithDeveloperKeyAssignTest()
        {
            var request = Request.CreateRequest(new MockService(),new MockMethod(){
                HttpMethod = "GET", Name = "TestMethod", 
                RestPath = "https://test.google.com"});
            request.WithDeveloperKey(SimpleDeveloperKey);
            Assert.AreEqual(SimpleDeveloperKey, request.DeveloperKey);
        }
        
        [Test()]
        public void BuildRequestUrlWithDeveloperKeysTest()
        {
            var service = new MockService();
            var request = Request.CreateRequest(service,new MockMethod(){
                HttpMethod = "GET", Name = "TestMethod", 
                RestPath = "https://test.google.com"});
            request.
                WithDeveloperKey(SimpleDeveloperKey).
                WithParameters(new Dictionary<string, string>());
            var url = request.BuildRequestUrl();
            
            Assert.AreEqual("https://test.google.com/?alt=json" + "&key=" + SimpleDeveloperKey, url.ToString());
            
        }
        
        [Test()]
        public void BuildRequestUrlWithDeveloperKeysTest_RequiresEscape()
        {
            var service = new MockService();
            var request = Request.CreateRequest(service,new MockMethod(){
                HttpMethod = "GET", Name = "TestMethod", 
                RestPath = "https://test.google.com"});
            request.
                WithDeveloperKey(ComplexDeveloperKey).
                WithParameters(new Dictionary<string, string>());
            var url = request.BuildRequestUrl();
            
            Assert.AreEqual("https://test.google.com/?alt=json" + "&key=%3F%26%5E%25%20%20ABC123", url.AbsoluteUri);
            
        }
    }
}
