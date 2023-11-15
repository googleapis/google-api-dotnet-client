/*
Copyright 2017 Google Inc

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

using Google.Apis.Json;
using Newtonsoft.Json;
using System;
using Xunit;

namespace Google.Apis.Tests.Json
{
    public class NewtonsoftJsonSerializerTest
    {
        [Fact]
        public void CreateDefaultSettings_Independent()
        {
            var settings1 = NewtonsoftJsonSerializer.CreateDefaultSettings();
            var settings2 = NewtonsoftJsonSerializer.CreateDefaultSettings();

            settings1.DateParseHandling = DateParseHandling.DateTimeOffset;
            settings2.DateParseHandling = DateParseHandling.None;
            // Not affected by changing settings2
            Assert.Equal(DateParseHandling.DateTimeOffset, settings1.DateParseHandling);
        }

        [Fact]
        public void InstanceIsCached()
        {
            var instance1 = NewtonsoftJsonSerializer.Instance;
            var instance2 = NewtonsoftJsonSerializer.Instance;
            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void DefaultInstanceParsesDates()
        {
            string text = "\"2017-05-03T16:38:00Z\"";
            object value = NewtonsoftJsonSerializer.Instance.Deserialize<object>(text);
            Assert.IsType<DateTime>(value);
        }

        [Fact]
        public void CustomInstanceAvoidingDateParsing()
        {
            string text = "\"2017-05-03T16:38:00Z\"";
            var settings = NewtonsoftJsonSerializer.CreateDefaultSettings();
            settings.DateParseHandling = DateParseHandling.None;
            var instance = new NewtonsoftJsonSerializer(settings);
            object value = instance.Deserialize<object>(text);

            // No magic parsing to DateTime...
            Assert.IsType<string>(value);
        }

        /// <summary>
        /// Regression test for https://github.com/googleapis/google-api-dotnet-client/issues/2609.
        /// <see cref="TypeWithOverridableField"/> mimics Google.Apis.Auth.OAuth2.Responses.
        /// </summary>
        [Fact]
        public void DefaultInstance_DefaultValueHandling_IsNotCustom()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                // If this settings have effect on the default serializer instance, then
                // TypeWithOverridableField.FieldOverride will be set to null which means
                // that Field will also be set to null regardles of it's value on the JSON text.
                DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
            };

            var text = @"{""field"":""field_value""}";
            var value = NewtonsoftJsonSerializer.Instance.Deserialize<TypeWithOverridableField>(text);
            Assert.Equal("field_value", value.Field);
        }

        public class TypeWithOverridableField
        {
            [JsonProperty("field")]
            public string Field { get; set; }

            [JsonProperty("field_override")]
#pragma warning disable IDE0051 // Remove unused private members. See the test comment.
            private string FieldOverride { set => Field = value; }
#pragma warning restore IDE0051 // Remove unused private members
        }

        [Fact]
        public void DefaultInstanceSerializesTwoETags()
        {
            var data = new DataWithTwoEtags
            {
                AField = "a value",
                ETag = "lowercase",
                ETag__ = "no-lowercase"
            };
            var expectedText = "{\"a_field\":\"a value\",\"etag\":\"lowercase\",\"ETag\":\"no-lowercase\"}";
            var text = NewtonsoftJsonSerializer.Instance.Serialize(data);

            Assert.Equal(expectedText, text);
        }

        [Fact]
        public void DefaultInstanceDeserializesTwoETags()
        {
            var text = "{\"a_field\":\"a value\",\"etag\":\"lowercase\",\"ETag\":\"no-lowercase\"}";

            var data = NewtonsoftJsonSerializer.Instance.Deserialize<DataWithTwoEtags>(text);

            Assert.Equal("a value", data.AField);
            Assert.Equal("lowercase", data.ETag);
            Assert.Equal("no-lowercase", data.ETag__);
        }

        public class DataWithTwoEtags
        {
            [JsonProperty("a_field")]
            public string AField { get; set; }

            [JsonProperty("etag")]
            public string ETag { get; set; }

            [JsonProperty("ETag")]
            public string ETag__ { get; set; }
        }
    }
}
