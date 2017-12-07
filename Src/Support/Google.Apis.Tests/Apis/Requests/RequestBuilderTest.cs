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

using Google.Apis.Requests;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>Tests the functionality of <see cref="Google.Apis.Requests.RequestBuilder" />.</summary>
    public class RequestBuilderTest
    {
        /// <summary>Verifies that a basic request is created with "GET" as default HTTP method.</summary>
        [Fact]
        public void TestBasicWebRequest()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/")
                };

            var request = builder.CreateRequest();
            Assert.Equal(HttpMethod.Get, request.Method);
            Assert.Equal(new Uri("http://www.example.com/"), request.RequestUri);
        }

        /// <summary>Verifies that a basic request is created with "POST" method.</summary>
        [Fact]
        public void TestPostWebRequest()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Method = "POST"
                };

            var request = builder.CreateRequest();
            Assert.Equal(HttpMethod.Post, request.Method);
            Assert.Equal(new Uri("http://www.example.com/"), request.RequestUri);
        }

        /// <summary>Verifies that the path is correctly appended to the base URI.</summary>
        [Theory]
        [InlineData("http://www.example.com/", "test/path", "http://www.example.com/test/path")]
        [InlineData("http://www.example.com/", "test/a:path", "http://www.example.com/test/a:path")]
        [InlineData("http://www.example.com/", "a:test/path", "http://www.example.com/a:test/path")]
        [InlineData("http://www.example.com/", "a:test", "http://www.example.com/a:test")]
        [InlineData("http://www.example.com/z", "test/path", "http://www.example.com/test/path")]
        [InlineData("http://www.example.com/z", "test/a:path", "http://www.example.com/test/a:path")]
        [InlineData("http://www.example.com/z", "a:test/path", "http://www.example.com/a:test/path")]
        [InlineData("http://www.example.com/z", "a:test", "http://www.example.com/a:test")]
        [InlineData("http://www.example.com/z/", "test/path", "http://www.example.com/z/test/path")]
        [InlineData("http://www.example.com/z/", "test/a:path", "http://www.example.com/z/test/a:path")]
        [InlineData("http://www.example.com/z/", "a:test/path", "http://www.example.com/z/a:test/path")]
        [InlineData("http://www.example.com/z/", "a:test", "http://www.example.com/z/a:test")]
        [InlineData("http://www.example.com/z", "/test/path", "http://www.example.com/test/path")]
        [InlineData("http://www.example.com/z", "/test/a:path", "http://www.example.com/test/a:path")]
        [InlineData("http://www.example.com/z", "/a:test/path", "http://www.example.com/a:test/path")]
        [InlineData("http://www.example.com/z", "/a:test", "http://www.example.com/a:test")]
        [InlineData("http://www.example.com/z/", "/test/path", "http://www.example.com/test/path")]
        [InlineData("http://www.example.com/z/", "/test/a:path", "http://www.example.com/test/a:path")]
        [InlineData("http://www.example.com/z/", "/a:test/path", "http://www.example.com/a:test/path")]
        [InlineData("http://www.example.com/z/", "/a:test", "http://www.example.com/a:test")]
        [InlineData("http://www.example.com/z", "?abc", "http://www.example.com/z?abc")]
        [InlineData("http://www.example.com/z", "#abc", "http://www.example.com/z#abc")]
        [InlineData("http://www.example.com/z/", "?abc", "http://www.example.com/z/?abc")]
        [InlineData("http://www.example.com/z/", "#abc", "http://www.example.com/z/#abc")]
        public void TestBasePlusPath(string baseUri, string path, string expectedRequestUri)
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri(baseUri),
                    Path = path,
                    Method = "PUT"
                };

            var request = builder.CreateRequest();
            Assert.Equal(HttpMethod.Put, request.Method);
            // Verify both the URI and the string representation.
            // Required because URI equality hides some special character processing.
            Assert.Equal(new Uri(expectedRequestUri), request.RequestUri);
            Assert.Equal(new Uri(expectedRequestUri).AbsoluteUri, request.RequestUri.AbsoluteUri);
        }

        /// <summary>Verifies that a single query parameter is correctly encoded in the request URI.</summary>
        [Fact]
        public void TestSingleQueryParameter()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                };

            builder.AddParameter(RequestParameterType.Query, "testQueryParam", "testValue");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/?testQueryParam=testValue"), request.RequestUri);
        }

        /// <summary>Verifies that multiple query parameters are correctly encoded in the request URI.</summary>
        [Fact]
        public void TestMultipleQueryParameter()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com/"),
            };
            builder.AddParameter(RequestParameterType.Query, "testQueryParamA", "testValueA");
            builder.AddParameter(RequestParameterType.Query, "testQueryParamB", "testValueB");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/?testQueryParamA=testValueA&testQueryParamB=testValueB"), request.RequestUri);
        }

        /// <summary>Verifies that query parameters are URL encoded.</summary>
        [Fact]
        public void TestQueryParameterWithUrlEncode()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                };

            builder.AddParameter(RequestParameterType.Query, "test Query Param", "test %va/ue");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/?test%20Query%20Param=test%20%25va%2Fue"), request.RequestUri);
        }

        /// <summary>Verifies that repeatable query parameters are supported.</summary>
        /// <remarks>
        /// See Issue #211: http://code.google.com/p/google-api-dotnet-client/issues/detail?id=211
        /// </remarks>
        [Fact]
        public void TestMultipleQueryParameters()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com/"),
            };

            builder.AddParameter(RequestParameterType.Query, "q", "value1");
            builder.AddParameter(RequestParameterType.Query, "q", "value2");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/?q=value1&q=value2"), request.RequestUri);
        }

        /// <summary>Verifies that empty query parameters are not ignored.</summary>
        [Fact]
        public void TestNullQueryParameters()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com"),
                Path = "",
            };

            builder.AddParameter(RequestParameterType.Query, "q", null);
            builder.AddParameter(RequestParameterType.Query, "p", String.Empty);

            Assert.Equal("http://www.example.com/?p", builder.BuildUri().AbsoluteUri);
        }

        /// <summary>Verifies that path parameters are properly inserted into the URI.</summary>
        [Fact]
        public void TestPathParameter()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Path = "test/{id}/foo/bar",
                };

            builder.AddParameter(RequestParameterType.Path, "id", "value");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/test/value/foo/bar"), request.RequestUri);
        }

        /// <summary>A test for invalid path parameters.</summary>
        [Fact]
        public void TestInvalidPathParameters()
        {
            // A path parameter is missing.
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com/"),
                Path = "test/{id}/foo/bar",
            };
            Assert.Throws<ArgumentException>(() =>
                {
                    builder.CreateRequest();
                });

            // Invalid number after ':' in path parameter.
            builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com/"),
                Path = "test/{id:SHOULD_BE_NUMBER}/foo/bar",
            };
            builder.AddParameter(RequestParameterType.Path, "id", "hello");
            Assert.Throws<ArgumentException>(() =>
            {
                builder.CreateRequest();
            });
        }

        /// <summary>Verifies that path parameters are URL encoded.</summary>
        [Fact]
        public void TestPathParameterWithUrlEncode()
        {
            var builder = new RequestBuilder()
                {
                    BaseUri = new Uri("http://www.example.com/"),
                    Path = "test/{id}",
                };

            builder.AddParameter(RequestParameterType.Path, "id", " %va/ue");

            var request = builder.CreateRequest();
            Assert.Equal(new Uri("http://www.example.com/test/%20%25va%2Fue"), request.RequestUri);
        }

        /// <summary>Tests a path parameter which contains '?' with query parameter.</summary>
        [Fact]
        public void TestQueryAndPathParameters()
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.test.com"),
                Path = "colors{?list}"
            };

            builder.AddParameter(RequestParameterType.Path, "list", "red");
            builder.AddParameter(RequestParameterType.Path, "list", "yellow");
            builder.AddParameter(RequestParameterType.Query, "on", "1");

            Assert.Equal("http://www.test.com/colors?list=red,yellow&on=1", builder.BuildUri().AbsoluteUri);
        }


        /// <summary>See Level 1 Examples on http://tools.ietf.org/html/rfc6570#section-1.2 (URI Template).</summary>
        [Fact]
        public void TestPathParameters_Level1()
        {
            IDictionary<string, IEnumerable<string>> vars = new Dictionary<string, IEnumerable<string>>();
            vars["var"] = new List<string> { "value" };
            vars["hello"] = new List<string> { "Hello World!" };

            SubtestPathParameters(vars, "{var}", "value");
            SubtestPathParameters(vars, "{hello}", "Hello%20World%21");
        }

        /// <summary>See Level 2 Examples on http://tools.ietf.org/html/rfc6570#section-1.2 (URI Template).</summary>
        [Fact]
        public void TestPathParameters_Level2()
        {
            IDictionary<string, IEnumerable<string>> vars = new Dictionary<string, IEnumerable<string>>();
            vars["var"] = new List<string> { "value" };
            vars["hello"] = new List<string> { "Hello World!" };
            vars["path"] = new List<string> { "/foo/bar" };

            SubtestPathParameters(vars, "{+var}", "value");
            SubtestPathParameters(vars, "{+hello}", "Hello%20World!");
            SubtestPathParameters(vars, "{+path}/here", "foo/bar/here");
            SubtestPathParameters(vars, "here?ref={+path}", "here?ref=/foo/bar");
        }

        /// <summary>See Level 3 Examples on http://tools.ietf.org/html/rfc6570#section-1.2 (URI Template).</summary>
        [Fact]
        public void TestPathParameters_Level3()
        {
            IDictionary<string, IEnumerable<string>> vars = new Dictionary<string, IEnumerable<string>>();
            vars["var"] = new List<string> { "value" };
            vars["hello"] = new List<string> { "Hello World!" };
            vars["empty"] = new List<string> { "" };

            vars["path"] = new List<string> { "/foo/bar" };
            vars["x"] = new List<string> { "1024" };
            vars["y"] = new List<string> { "768" };

            SubtestPathParameters(vars, "map?{x,y}", "map?1024,768");
            SubtestPathParameters(vars, "{x,hello,y}", "1024,Hello%20World%21,768");
            SubtestPathParameters(vars, "{+x,hello,y}", "1024,Hello%20World!,768");
            SubtestPathParameters(vars, "{+path,x}/here", "foo/bar,1024/here");
            SubtestPathParameters(vars, "{#x,hello,y}", "#1024,Hello%20World!,768");
            SubtestPathParameters(vars, "{#path,x}/here", "#/foo/bar,1024/here");
            SubtestPathParameters(vars, "X{.var}", "X.value");
            SubtestPathParameters(vars, "X{.x,y}", "X.1024.768");
            SubtestPathParameters(vars, "{/var}", "value");
            SubtestPathParameters(vars, "{/var,x}/here", "value/1024/here");
            SubtestPathParameters(vars, "{;x,y}", ";x=1024;y=768");
            SubtestPathParameters(vars, "{;x,y,empty}", ";x=1024;y=768;empty");
            SubtestPathParameters(vars, "{?x,y}", "?x=1024&y=768");
            SubtestPathParameters(vars, "{?x,y,empty}", "?x=1024&y=768&empty=");
            SubtestPathParameters(vars, "?fixed=yes{&x}", "?fixed=yes&x=1024");
            SubtestPathParameters(vars, "{&x,y,empty}", "&x=1024&y=768&empty=");
        }

        /// <summary>See Level 4 Examples on http://tools.ietf.org/html/rfc6570#section-1.4 (URI Template).</summary>
        [Fact]
        public void TestPathParameters_Level4()
        {
            IDictionary<string, IEnumerable<string>> vars = new Dictionary<string, IEnumerable<string>>();
            vars["var"] = new List<string> { "value" };
            vars["hello"] = new List<string> { "Hello World!" };
            vars["path"] = new List<string> { "/foo/bar" };
            vars["list"] = new List<string> { "red", "green", "blue" };

            SubtestPathParameters(vars, "{var:3}", "val");
            SubtestPathParameters(vars, "{var:30}", "value");
            SubtestPathParameters(vars, "{list}", "red,green,blue");
            SubtestPathParameters(vars, "{list*}", "red,green,blue");
            SubtestPathParameters(vars, "{+path:6}/here", "foo/b/here");
            SubtestPathParameters(vars, "{+list}", "red,green,blue");
            SubtestPathParameters(vars, "{+list*}", "red,green,blue");
            SubtestPathParameters(vars, "{#path:6}/here", "#/foo/b/here");
            SubtestPathParameters(vars, "{#list}", "#red,green,blue");
            SubtestPathParameters(vars, "{#list*}", "#red,green,blue");
            SubtestPathParameters(vars, "X{.var:3}", "X.val");
            SubtestPathParameters(vars, "X{.list}", "X.red,green,blue");
            SubtestPathParameters(vars, "X{.list*}", "X.red.green.blue");
            SubtestPathParameters(vars, "{/var:1,var}", "v/value");
            SubtestPathParameters(vars, "{/list}", "red,green,blue");
            SubtestPathParameters(vars, "{/list*}", "red/green/blue");
            SubtestPathParameters(vars, "{/list*,path:4}", "red/green/blue/%2Ffoo");
            SubtestPathParameters(vars, "{;hello:5}", ";hello=Hello");
            SubtestPathParameters(vars, "{;list}", ";list=red,green,blue");
            SubtestPathParameters(vars, "{;list*}", ";list=red;list=green;list=blue");
            SubtestPathParameters(vars, "{?var:3}", "?var=val");
            SubtestPathParameters(vars, "{?list}", "?list=red,green,blue");
            SubtestPathParameters(vars, "{?list*}", "?list=red&list=green&list=blue");
            SubtestPathParameters(vars, "{&var:3}", "&var=val");
            SubtestPathParameters(vars, "{&list}", "&list=red,green,blue");
            SubtestPathParameters(vars, "{&list*}", "&list=red&list=green&list=blue");
        }

        /// <summary>A subtest for path parameters.</summary>
        /// <param name="dic">Dictionary that contain all path parameters.</param>
        /// <param name="path">Path part.</param>
        /// <param name="expected">Expected part after base URI.</param>
        private void SubtestPathParameters(IDictionary<string, IEnumerable<string>> dic, string path, string expected)
        {
            var builder = new RequestBuilder()
            {
                BaseUri = new Uri("http://www.example.com"),
                Path = path,
            };

            foreach (var pair in dic)
            {
                foreach (var value in pair.Value)
                {
                    builder.AddParameter(RequestParameterType.Path, pair.Key, value);
                }
            }

            Assert.Equal("http://www.example.com/" + expected, builder.BuildUri().AbsoluteUri);
        }
    }
}
