/*
Copyright 2013 Google Inc

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

using System.IO;
using System.Text;

using Newtonsoft.Json;
using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Util;
using Google.Apis.Services;

namespace Google.Apis.Tests.Apis.Services
{
    /// <summary> Test for the BaseClientService class. </summary>
    [TestFixture]
    public class BaseClientServiceTest
    {
        /// <summary> A Json schema for testing serialization/deserialization. </summary>
        internal class MockJsonSchema : IDirectResponseSchema
        {
            [JsonProperty("kind")]
            public string Kind { get; set; }

            [JsonProperty("longUrl")]
            public string LongURL { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            public RequestError Error { get; set; }

            public string ETag { get; set; }
        }

        private void CheckDeserializationResults(MockJsonSchema result)
        {
            Assert.NotNull(result);
            Assert.That(result.Kind, Is.EqualTo("urlshortener#url"));
            Assert.That(result.LongURL, Is.EqualTo("http://google.com/"));
            Assert.That(result.Status, Is.Null);
        }

        private IClientService CreateClientServiceV_03()
        {
            return CreateClientService(DiscoveryVersion.Version_0_3);
        }

        private IClientService CreateClientServiceV_1()
        {
            return CreateClientService(DiscoveryVersion.Version_1_0);
        }

        private IClientService CreateClientService(DiscoveryVersion version)
        {
            var client = new MockClientService();
            if (version == DiscoveryVersion.Version_0_3)
                client.SetFeatures(new[] { Features.LegacyDataResponse.GetStringValue() });
            return client;
        }

        /// <summary> This tests the v0.3 Deserialization of the BaseService. </summary>
        [Test]
        public void TestDeserializationV0_3()
        {
            const string ResponseV0_3 =
                @"{ ""data"" : 
                     {
                        ""kind"": ""urlshortener#url"",
                        ""longUrl"": ""http://google.com/"",
                     } 
                  }";

            var client = CreateClientServiceV_03();

            // Check that the default serializer is set.
            Assert.IsInstanceOf<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly.
            var stream = new MemoryStream(Encoding.Default.GetBytes(ResponseV0_3));
            var response = new MockResponse() { Stream = stream };
            CheckDeserializationResults(client.DeserializeResponse<MockJsonSchema>(response));
        }


        /// <summary> This tests the v1 Deserialization of the BaseService. </summary>
        [Test]
        public void TestDeserializationV1()
        {
            const string ResponseV1 = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            // by default the request provider doesn't contain the LegacyDataResponse
            var client = CreateClientServiceV_1();

            // Check that the default serializer is set
            Assert.IsInstanceOf<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.Default.GetBytes(ResponseV1));
            CheckDeserializationResults(
                client.DeserializeResponse<MockJsonSchema>(new MockResponse() { Stream = stream }));
        }

        /// <summary> Tests if serialization works. </summary>
        [Test]
        public void TestSerializationV0_3()
        {
            const string ResponseV0_3 =
                "{\"data\":{\"kind\":\"urlshortener#url\",\"longUrl\":\"http://google.com/\"}}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientServiceV_03();

            // Check if a response is serialized correctly
            string result = client.SerializeObject(schema);
            Assert.AreEqual(ResponseV0_3, result);
        }

        /// <summary> Tests if serialization works. </summary>
        [Test]
        public void TestSerializationV1()
        {
            const string ResponseV1 = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientServiceV_1();

            // Check if a response is serialized correctly
            string result = client.SerializeObject(schema);
            Assert.AreEqual(ResponseV1, result);
        }

        /// <summary>
        /// Confirms that the serializer won't do anything if a string is the requested response type.
        /// </summary>
        [Test]
        public void TestDeserializationString()
        {
            const string ResponseV1 = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockClientService client = new MockClientService();

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.Default.GetBytes(ResponseV1));
            string result = client.DeserializeResponse<string>(new MockResponse() { Stream = stream });
            Assert.AreEqual(ResponseV1, result);
        }

        /// <summary> Tests the deserialization for server error responses. </summary>
        [Test]
        public void TestErrorDeserialization(
          [Values(DiscoveryVersion.Version_0_3, DiscoveryVersion.Version_1_0)] DiscoveryVersion version)
        {
            const string ErrorResponse =
                @"{
                    ""error"": {
                        ""errors"": [
                            {
                                ""domain"": ""global"",
                                ""reason"": ""required"",
                                ""message"": ""Required"",
                                ""locationType"": ""parameter"",
                                ""location"": ""resource.longUrl""
                            }
                        ],
                        ""code"": 400,
                        ""message"": ""Required""
                    }
                }";

            var client = CreateClientService(version);

            using (var stream = new MemoryStream(Encoding.Default.GetBytes(ErrorResponse)))
            {
                RequestError error = client.DeserializeError(new MockResponse() { Stream = stream });
                Assert.AreEqual(400, error.Code);
                Assert.AreEqual("Required", error.Message);
                Assert.AreEqual(1, error.Errors.Count);
            }
        }
    }
}
