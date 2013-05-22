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
using System.Net.Http;

using NUnit.Framework;

using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary> Tests the functionality of <see cref="Google.Apis.Requests.RequestBuilder" />. </summary>
    [TestFixture]
    class RequestBuilderTest
    {
        /// <summary> Verifies that a basic request is created with "GET" as default http method. </summary>
        [Test]
        public void TestBasicWebRequest()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/")
                };

            var request = builder.CreateRequest();
            Assert.That(request.Method, Is.EqualTo(HttpMethod.Get));
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/")));
        }

        /// <summary> Verifies that a basic request is created with "POST" method. </summary>
        [Test]
        public void TestPostWebRequest()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Method = "POST"
                };

            var request = builder.CreateRequest();
            Assert.That(request.Method, Is.EqualTo(HttpMethod.Post));
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/")));
        }

        /// <summary> Verifies that the path is correctly appended to the baseUri. </summary>
        [Test]
        public void TestBasePlusPathMath()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Path = "test/path",
                    Method = "PUT"
                };

            var request = builder.CreateRequest();
            Assert.That(request.Method, Is.EqualTo(HttpMethod.Put));
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/test/path")));
        }

        /// <summary>
        /// Verifies that a single query parameter is correctly encoded in the request Uri.
        /// </summary>
        [Test]
        public void TestSingleQueryParameter()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                };

            builder.AddParameter(RequestParameterType.Query, "testQueryParam", "testValue");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/?testQueryParam=testValue")));
        }

        /// <summary> Verifies that multiple query parameters are correctly encoded in the request Uri. </summary>
        [Test]
        public void TestMultipleQueryParameter()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com/"),
            };
            builder.AddParameter(RequestParameterType.Query, "testQueryParamA", "testValueA");
            builder.AddParameter(RequestParameterType.Query, "testQueryParamB", "testValueB");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(
                new Uri("http://www.example.com/?testQueryParamA=testValueA&testQueryParamB=testValueB")));
        }

        /// <summary> Verifies that query parameters are Url encoded. </summary>
        [Test]
        public void TestQueryParameterWithUrlEncode()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                };

            builder.AddParameter(RequestParameterType.Query, "test Query Param", "test %va/ue");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(
                new Uri("http://www.example.com/?test%20Query%20Param=test%20%25va%2Fue")));
        }

        /// <summary> Verifies that path parameters are properly inserted into the Uri. </summary>
        [Test]
        public void TestPathParameter()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Path = "test/{id}/foo/bar",
                };

            builder.AddParameter(RequestParameterType.Path, "id", "value");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/test/value/foo/bar")));
        }

        /// <summary> Verifies that path parameters are Url encoded. </summary>
        [Test]
        public void TestPathParameterWithUrlEncode()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Path = "test/{id}",
                };

            builder.AddParameter(RequestParameterType.Path, "id", " %va/ue");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/test/%20%25va%2Fue")));
        }

        /// <summary> Verifies that repeatable query parameters are supported. </summary>
        /// <remarks>
        /// See Issue #211: http://code.google.com/p/google-api-dotnet-client/issues/detail?id=211
        /// </remarks>
        [Test]
        public void TestMultipleQueryParameters()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                };

            builder.AddParameter(RequestParameterType.Query, "q", "value1");
            builder.AddParameter(RequestParameterType.Query, "q", "value2");

            var request = builder.CreateRequest();
            Assert.That(request.RequestUri, Is.EqualTo(new Uri("http://www.example.com/?q=value1&q=value2")));
        }

        /// <summary> Verifies that repeated path parameters are not supported. </summary>
        /// <remarks>
        /// See Issue #211: http://code.google.com/p/google-api-dotnet-client/issues/detail?id=211
        /// </remarks>
        [Test]
        public void TestMultiplePathParameters()
        {
            var builder = new RequestBuilder();

            builder.AddParameter(RequestParameterType.Path, "q", "value1");
            Assert.Throws<ArgumentException>(() =>
                {
                    builder.AddParameter(RequestParameterType.Path, "q", "value2");
                });
        }

        /// <summary> Verifies that <c>null</c> and empty path parameters are not allowed. </summary>
        [Test]
        public void TestNullPathParameters()
        {
            var builder = new RequestBuilder();

            Assert.Throws<ArgumentException>(
                () => builder.AddParameter(RequestParameterType.Path, "q", null));
            Assert.Throws<ArgumentException>(
                () => builder.AddParameter(RequestParameterType.Path, "q", String.Empty));
        }

        /// <summary> Verifies that empty query parameters are not ignored. </summary>
        [Test]
        public void TestNullQueryParameters()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com"),
                    Path = "",
                };

            builder.AddParameter(RequestParameterType.Query, "q", null);
            builder.AddParameter(RequestParameterType.Query, "p", String.Empty);

            Assert.That(builder.BuildUri().AbsoluteUri, Is.EqualTo("http://www.example.com/?p"));
        }
    }
}
