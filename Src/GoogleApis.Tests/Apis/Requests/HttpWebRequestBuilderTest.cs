/*
Copyright 2012 Google Inc

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
using System.Linq;
using System.Text;
using NUnit.Framework;
using Google.Apis.Requests;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests covering the functionality of the HttpWebRequestBuilder class.
    /// </summary>
    [TestFixture]
    class HttpWebRequestBuilderTest
    {
        /// <summary>
        /// Verify that a basic request is created with "GET" as default http method.
        /// </summary>
        [Test]
        public void TestBasicWebRequest()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/")
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/"));
        }

        /// <summary>
        /// Verify that the POST http method is translated the HttpWebRequest.
        /// </summary>
        [Test]
        public void TestPostWebRequest()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                Method = "POST"
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("POST"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/"));
        }

        /// <summary>
        /// Verify that the path is correctly appended to the baseUri.
        /// </summary>
        [Test]
        public void TestBasePlusPathMath()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                Path = "test/path",
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri,
                Is.EqualTo("http://www.example.com/test/path"));
        }

        /// <summary>
        /// Verify that a single query parameter is correctly encoded in the request URI.
        /// </summary>
        [Test]
        public void TestSingleQueryParameter()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                QueryParameters = { { "testQueryParam", "testValue" } }
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, 
                Is.EqualTo("http://www.example.com/?testQueryParam=testValue"));
        }

        /// <summary>
        /// Verify that multiple query parameters are correctly encoded in the request URI.
        /// </summary>
        [Test]
        public void TestMultipleQueryParameter()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                QueryParameters = {
                    { "testQueryParamA", "testValueA" },
                    { "testQueryParamB", "testValueB" },}
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo(
                "http://www.example.com/?testQueryParamA=testValueA&testQueryParamB=testValueB"));
        }

        /// <summary>
        /// Verify that query parameters are URL encoded.
        /// </summary>
        [Test]
        public void TestQueryParameterWithUrlEncode()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                QueryParameters = { { "test Query Param", "test %va/ue" }, }
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, 
                Is.EqualTo("http://www.example.com/?test%20Query%20Param=test%20%25va%2Fue"));
        }

        /// <summary>
        /// Verify that path parameters are properly inserted into the URI.
        /// </summary>
        [Test]
        public void TestPathParameter()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                Path = "test/{id}/foo/bar",
                PathParameters = { { "id", "value" }, },
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/test/value/foo/bar"));
        }

        /// <summary>
        /// Verify that path parameters are url encoded
        /// </summary>
        [Test]
        public void TestPathParameterWithUrlEncode()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
                Path = "test/{id}",
                PathParameters = { { "id", " %va/ue" }, },
            };

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/test/%20%25va%2Fue"));
        }
    }
}
