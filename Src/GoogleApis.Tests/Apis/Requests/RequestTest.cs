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
using Google.Apis.Discovery;
using Google.Apis.Testing;

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

        [Test()]
        public void BuildRequestUrlWithNullOptionalParameters()
        {
            var parameterDefinitions = new Dictionary<string, IParameter>();
            parameterDefinitions.Add("required", new MockParameter(){
                  Name = "required",
                  Required = true,
                  ParameterType = "query"});
            parameterDefinitions.Add("optionalWithValue", new MockParameter(){
                  Name = "optionalWithValue",
                  Required = false,
                  ParameterType = "query"});
            parameterDefinitions.Add("optionalWithNull", new MockParameter(){
                  Name = "optionalWithNull",
                  Required = false,
                  ParameterType = "query"});
            parameterDefinitions.Add("optionalWithEmpty", new MockParameter(){
                  Name = "optionalWithEmpty",
                  Required = false,
                  ParameterType = "query"});
            parameterDefinitions.Add("optionalNotPressent", new MockParameter(){
                  Name = "optionalNotPressent",
                  Required = false,
                  ParameterType = "query"});
            var parameterValues = new SortedDictionary<string, string>();
            parameterValues.Add("required", "a");
            parameterValues.Add("optionalWithValue", "b");
            parameterValues.Add("optionalWithNull", null);
            parameterValues.Add("optionalWithEmpty", "");

            var service = new MockService();
            var request = Request.CreateRequest(service, new MockMethod(){
                HttpMethod = "GET",
                Name = "TestMethod",
                RestPath = "https://test.google.com",
                Parameters = parameterDefinitions});

            request.WithParameters(parameterValues);
            var url = request.BuildRequestUrl();

            Assert.AreEqual("https://test.google.com/?alt=json&optionalWithValue=b&required=a", url.AbsoluteUri);
        }

        [Test()]
        public void BuildRequestUrlWithDefaultedParameters()
        {
            var parameterDefinitions = new Dictionary<string, IParameter>();
            parameterDefinitions.Add("required", new MockParameter()
            {
                Name = "required",
                Required = true,
                ParameterType = "query"
            });
            parameterDefinitions.Add("optionalWithValue", new MockParameter()
            {
                Name = "optionalWithValue",
                Required = false,
                ParameterType = "query",
                DefaultValue = "DoesNotDisplay"
            });
            parameterDefinitions.Add("optionalWithNull", new MockParameter()
            {
                Name = "optionalWithNull",
                Required = false,
                ParameterType = "query",
                DefaultValue = "c"
            });
            parameterDefinitions.Add("optionalWithEmpty", new MockParameter()
            {
                Name = "optionalWithEmpty",
                Required = false,
                ParameterType = "query",
                DefaultValue = "d"
            });
            parameterDefinitions.Add("optionalNotPressent", new MockParameter()
            {
                Name = "optionalNotPressent",
                Required = false,
                ParameterType = "query",
                DefaultValue = "DoesNotDisplay"
            });
            var parameterValues = new SortedDictionary<string, string>();
            parameterValues.Add("required", "a");
            parameterValues.Add("optionalWithValue", "b");
            parameterValues.Add("optionalWithNull", null);
            parameterValues.Add("optionalWithEmpty", "");

            var service = new MockService();
            var request = Request.CreateRequest(service, new MockMethod()
            {
                HttpMethod = "GET",
                Name = "TestMethod",
                RestPath = "https://test.google.com",
                Parameters = parameterDefinitions
            });

            request.WithParameters(parameterValues);
            var url = request.BuildRequestUrl();

            Assert.AreEqual("https://test.google.com/?alt=json&optionalWithEmpty=d&" +
                "optionalWithNull=c&optionalWithValue=b&required=a",
                url.AbsoluteUri);
        }
        
        [Test]
        public void WithParametersDictStringObject()
        {
            var dict = new Dictionary<string,object>();
            dict.Add("a", "a");
            dict.Add("null", null);
            dict.Add("1",1);
            dict.Add("100",100L);
            dict.Add("True",true);
            dict.Add("False",false);
            var request = new Request();
            request.WithParameters(dict);
            Assert.AreEqual(dict.Count, request.Parameters.Count);
            Assert.AreEqual("a", request.Parameters["a"]);
            Assert.IsNull(request.Parameters["null"]); 
            Assert.AreEqual("1", request.Parameters["1"]);
            Assert.AreEqual("100", request.Parameters["100"]);
            Assert.AreEqual("True", request.Parameters["True"]);
            Assert.AreEqual("False", request.Parameters["False"]);
        }
    }
}
