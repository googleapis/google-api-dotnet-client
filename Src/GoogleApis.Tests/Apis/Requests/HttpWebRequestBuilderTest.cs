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
using Google.Apis.Util;
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
            };

            builder.AddParameter(RequestParameterType.Query, "testQueryParam", "testValue");

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
            };
            builder.AddParameter(RequestParameterType.Query, "testQueryParamA", "testValueA");
            builder.AddParameter(RequestParameterType.Query, "testQueryParamB", "testValueB");

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
            };

            builder.AddParameter(RequestParameterType.Query, "test Query Param", "test %va/ue");

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
            };

            builder.AddParameter(RequestParameterType.Path, "id", "value");
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
            };

            builder.AddParameter(RequestParameterType.Path, "id", " %va/ue");
            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/test/%20%25va%2Fue"));
        }

        /// <summary>
        /// Verify that repeatable query parameters are supported
        /// </summary>
        /// <remarks>
        /// See Issue #211: http://code.google.com/p/google-api-dotnet-client/issues/detail?id=211
        /// </remarks>
        [Test]
        public void TestMultipleQueryParameters()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = UriFactory.Create("http://www.example.com/"),
            };

            builder.AddParameter(RequestParameterType.Query, "q", "value1");
            builder.AddParameter(RequestParameterType.Query, "q", "value2");

            var wr = builder.GetWebRequest();

            Assert.That(wr.Method, Is.EqualTo("GET"));
            Assert.That(wr.RequestUri.AbsoluteUri, Is.EqualTo("http://www.example.com/?q=value1&q=value2"));
        }

        /// <summary>
        /// Verify that repeated path parameters are not supported
        /// </summary>
        /// <remarks>
        /// See Issue #211: http://code.google.com/p/google-api-dotnet-client/issues/detail?id=211
        /// </remarks>
        [Test]
        public void TestMultiplePathParameters()
        {
            var builder = new HttpWebRequestBuilder();

            builder.AddParameter(RequestParameterType.Path, "q", "value1");
            Assert.Throws<ArgumentException>(() =>
            {
                builder.AddParameter(RequestParameterType.Path, "q", "value2");
            });
        }

        /// <summary>
        /// Verify that null and empty path parameters are not allowed.
        /// </summary>
        [Test]
        public void TestNullPathParameters()
        {
            var builder = new HttpWebRequestBuilder();

            Assert.Throws<ArgumentException>(
                () => builder.AddParameter(RequestParameterType.Path, "q", null));
            Assert.Throws<ArgumentException>(
                () => builder.AddParameter(RequestParameterType.Path, "q", String.Empty));
        }

        /// <summary>
        /// Verify that empty query parameters are not ignored.
        /// </summary>
        [Test]
        public void TestNullQueryParameters()
        {
            var builder = new HttpWebRequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com"),
                Path = "",
            };

            builder.AddParameter(RequestParameterType.Query, "q", null);
            builder.AddParameter(RequestParameterType.Query, "p", String.Empty);

            Assert.That(builder.BuildUri().AbsoluteUri, Is.EqualTo("http://www.example.com/"));
        }
    }
}
