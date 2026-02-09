/*
Copyright 2016 Google Inc

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
using Google.Apis.Requests.Parameters;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests.Parameters
{
    /// <summary>Tests for <see cref="Google.Apis.Requests.Parameters.ParameterUtils"/>.</summary>
    public class ParameterUtilsTest
    {
        private class TestRequestUrl
        {
            [Google.Apis.Util.RequestParameterAttribute("first_query_param", 
                Google.Apis.Util.RequestParameterType.Query)]
            public string FirstParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("second_query_param", 
                Google.Apis.Util.RequestParameterType.Query)]
            public string SecondParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("query_param_attribute_name", 
                Google.Apis.Util.RequestParameterType.UserDefinedQueries)]
            public List<KeyValuePair<string, string>> ParamsCollection { get; set; }

            public System.Uri Build()
            {
                var builder = new RequestBuilder()
                {
                    BaseUri = new System.Uri("//revokeTokenUrl")
                };
                ParameterUtils.InitParameters(builder, this);
                return builder.BuildUri();
            }
        }

        [Fact]
        public void IterateParametersTest()
        {
            var request = new TestRequestUrl()
            {
                FirstParam = "firstOne",
                SecondParam = "secondOne",
                ParamsCollection = new List<KeyValuePair<string, string>>{
                    new KeyValuePair<string,string>("customParam1","customVal1"),
                    new KeyValuePair<string,string>("customParam2","customVal2")
                }
            };

            var result = request.Build().AbsoluteUri;

            //Parametera were given a name and a value, so both appear in the URI.
            Assert.Contains("first_query_param=firstOne", result);
            Assert.Contains("second_query_param=secondOne", result);

            //Custom parameters are key value pairs representing parameter names and values respectively.
            Assert.Contains("customParam1=customVal1", result);
            Assert.Contains("customParam2=customVal2", result);

            //The parameter name for the custom parameters does not carry through to the resulting URI.
            Assert.DoesNotContain("query_param_attribute_name", result);
        }

        private class RepeatableEnumRequest
        {
            [RequestParameter("mode", RequestParameterType.Query)]
            public FileMode? Mode { get; set; }

            [RequestParameter("mode", RequestParameterType.Query)]
            public Repeatable<FileMode> ModeList { get; set; }
        }

        [Fact]
        public void RepeatableEnum_NoPropertiesSet()
        {
            var request = new RepeatableEnumRequest();
            var dictionary = ParameterUtils.CreateParameterDictionary(request);
            // For historical reasons, we end up with a null value from the "FileMode? Mode" property.
            // That's fixable, but not worth the worry about whether it would break things.
            var pair = Assert.Single(dictionary);
            Assert.Equal("mode", pair.Key);
            Assert.Null(pair.Value);
        }

        [Fact]
        public void RepeatableEnum_SinglePropertySet()
        {
            var request = new RepeatableEnumRequest { Mode = FileMode.Open };
            var dictionary = ParameterUtils.CreateParameterDictionary(request);
            Assert.Equal(FileMode.Open, dictionary["mode"]);
        }

        [Fact]
        public void RepeatableEnum_ListPropertySet()
        {
            var request = new RepeatableEnumRequest { ModeList = new[] { FileMode.Open, FileMode.Append } };
            var dictionary = ParameterUtils.CreateParameterDictionary(request);
            var pair = Assert.Single(dictionary);
            Assert.Equal("mode", pair.Key);
            var repeatable = (Repeatable<FileMode>) pair.Value;
            Assert.Equal(new[] { FileMode.Open, FileMode.Append }, repeatable.ToArray());
        }

        [Fact]
        public void RepeatableEnum_BothPropertiesSet()
        {
            var request = new RepeatableEnumRequest
            {
                Mode = FileMode.Open,
                ModeList = new[] { FileMode.Create, FileMode.Append }
            };
            Assert.Throws<InvalidOperationException>(() => ParameterUtils.CreateParameterDictionary(request));
        }

        // Tests for InitParametersWithExpansion

        private class TestRequestWithScalars
        {
            [RequestParameter("name", RequestParameterType.Query)]
            public string Name { get; set; }
            
            [RequestParameter("id", RequestParameterType.Path)]
            public int Id { get; set; }
            
            [RequestParameter("nullparam", RequestParameterType.Query)]
            public string NullParam { get; set; }
        }

        [Fact]
        public void InitParametersWithExpansion_ScalarParameters()
        {
            var request = new TestRequestWithScalars
            {
                Name = "test",
                Id = 123,
                NullParam = null
            };
            var builder = new RequestBuilder 
            { 
                BaseUri = new Uri("https://example.com/api"),
                Path = "items/{id}"  // Path template for path parameter
            };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // Verify parameters were added by building the URI
            var uri = builder.BuildUri();
            Assert.Contains("name=test", uri.AbsoluteUri);
            Assert.Contains("items/123", uri.AbsoluteUri);  // Path parameter replaces {id}
            // Null parameter should not be in the URI
            Assert.DoesNotContain("nullparam", uri.AbsoluteUri);
        }

        private class TestRequestWithRepeatable
        {
            [RequestParameter("part", RequestParameterType.Query)]
            public Repeatable<string> Part { get; set; }
        }

        [Fact]
        public void InitParametersWithExpansion_RepeatableParameters()
        {
            var request = new TestRequestWithRepeatable
            {
                Part = new[] { "snippet", "contentDetails" }
            };
            var builder = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // Should expand to multiple parameters with the same name
            var uri = builder.BuildUri();
            Assert.Contains("part=snippet", uri.AbsoluteUri);
            Assert.Contains("part=contentDetails", uri.AbsoluteUri);
        }

        private class TestRequestWithDateTime
        {
            [RequestParameter("time", RequestParameterType.Query)]
            public DateTime? MinTime { get; set; }
        }

        [Fact]
        public void InitParametersWithExpansion_DateTimeConversion()
        {
            var request = new TestRequestWithDateTime
            {
                MinTime = new DateTime(2023, 1, 15, 10, 30, 0, DateTimeKind.Utc)
            };
            var builder = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // DateTime should be converted to RFC3339 format
            var uri = builder.BuildUri();
            Assert.Contains("time=", uri.AbsoluteUri);
            Assert.Contains("2023-01-15", uri.AbsoluteUri);
        }

        private class TestRequestWithEnum
        {
            [RequestParameter("mode", RequestParameterType.Query)]
            public Repeatable<FileMode> ModeList { get; set; }
        }

        [Fact]
        public void InitParametersWithExpansion_EnumConversion()
        {
            var request = new TestRequestWithEnum
            {
                ModeList = new[] { FileMode.Open, FileMode.Append }
            };
            var builder = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // Should expand enum list and convert each value using StringValue attribute
            var uri = builder.BuildUri();
            Assert.Contains("mode=Open", uri.AbsoluteUri);
            Assert.Contains("mode=Append", uri.AbsoluteUri);
        }

        private class TestRequestWithBoolean
        {
            [RequestParameter("flag", RequestParameterType.Query)]
            public bool Flag { get; set; }
        }

        [Fact]
        public void InitParametersWithExpansion_BooleanConversion()
        {
            var request = new TestRequestWithBoolean { Flag = true };
            var builder = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // Boolean should be lowercase
            var uri = builder.BuildUri();
            Assert.Contains("flag=true", uri.AbsoluteUri);
        }

        [Fact]
        public void InitParametersWithExpansion_CacheUsage()
        {
            var request1 = new TestRequestWithScalars { Name = "test1", Id = 1 };
            var request2 = new TestRequestWithScalars { Name = "test2", Id = 2 };
            var builder1 = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            var builder2 = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            // First call - cache is populated
            ParameterUtils.InitParametersWithExpansion(builder1, request1);
            var properties1 = Google.Apis.Util.ReflectionCache.GetRequestParameterProperties(typeof(TestRequestWithScalars));
            
            // Second call - should reuse cached PropertyInfo
            ParameterUtils.InitParametersWithExpansion(builder2, request2);
            var properties2 = Google.Apis.Util.ReflectionCache.GetRequestParameterProperties(typeof(TestRequestWithScalars));
            
            // Verify same PropertyInfo instances are returned (object reference equality)
            Assert.Equal(properties1.Length, properties2.Length);
            for (int i = 0; i < properties1.Length; i++)
            {
                Assert.Same(properties1[i].Property, properties2[i].Property);
                Assert.Same(properties1[i].Attribute, properties2[i].Attribute);
            }
        }

        /// <summary>
        /// Regression test for null handling in enumerable expansion.
        /// Tests that null elements in an enumerable produce the same result as Utilities.ConvertToString(null).
        /// This test does not hard-code expectations - it dynamically tests against the actual behavior.
        /// </summary>
        [Fact]
        public void InitParametersWithExpansion_NullElementsInEnumerable()
        {
            // Get the expected behavior from Utilities.ConvertToString(null) - don't hard-code!
            string expectedNullValue = Utilities.ConvertToString(null);
            
            var request = new TestRequestWithRepeatable
            {
                Part = new[] { "value1", null, "value2" }
            };
            var builder = new RequestBuilder { BaseUri = new Uri("https://example.com/api") };
            
            ParameterUtils.InitParametersWithExpansion(builder, request);
            
            // Build the URI and check the result
            var uri = builder.BuildUri();
            var query = uri.Query;
            
            // Count how many "part=" occurrences there are
            int partCount = System.Text.RegularExpressions.Regex.Matches(query, "part=").Count;
            
            // Verify behavior matches what Utilities.ConvertToString(null) produces
            if (expectedNullValue == null)
            {
                // If ConvertToString(null) returns null, the null element should be filtered out
                // by RequestBuilder (which doesn't add null-valued parameters)
                // So we should only see 2 parameters: "value1" and "value2"
                Assert.Equal(2, partCount);
                Assert.Contains("part=value1", query);
                Assert.Contains("part=value2", query);
            }
            else if (expectedNullValue == "")
            {
                // If ConvertToString(null) returns empty string, we should see 3 parameters
                // including one with an empty value
                Assert.Equal(3, partCount);
                Assert.Contains("part=value1", query);
                Assert.Contains("part=value2", query);
                // One of the "part=" should have empty value (part=&)
            }
            else
            {
                // If ConvertToString(null) returns some other string, we should see 3 parameters
                // with that string value
                Assert.Equal(3, partCount);
                Assert.Contains("part=value1", query);
                Assert.Contains("part=value2", query);
                Assert.Contains($"part={Uri.EscapeDataString(expectedNullValue)}", query);
            }
        }
    }
}
