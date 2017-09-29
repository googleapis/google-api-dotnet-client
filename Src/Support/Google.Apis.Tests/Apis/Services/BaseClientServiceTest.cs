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

using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Services
{
    /// <summary>Test for the BaseClientService class.</summary>
    public class BaseClientServiceTest
    {
        /// <summary>A Json schema for testing serialization/deserialization.</summary>
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

        /// <summary>Validates the deserialization result.</summary>
        private void CheckDeserializationResult(MockJsonSchema result)
        {
            Assert.NotNull(result);
            Assert.Equal("urlshortener#url", result.Kind);
            Assert.Equal("http://google.com/", result.LongURL);
            Assert.Null(result.Status);
        }

        /// <summary>Creates a client service for the given features.</summary>
        private IClientService CreateClientService(Features? features = null)
        {
            var client = new MockClientService();
            if (features.HasValue)
            {
                client.SetFeatures(new[] { Utilities.GetEnumStringValue(features.Value) });
            }

            return client;
        }

        /// <summary>This tests deserialization with data wrapping.</summary>
        [Fact]
        public void TestDeserialization_WithDataWrapping()
        {
            const string Response =
                @"{ ""data"" : 
                     {
                        ""kind"": ""urlshortener#url"",
                        ""longUrl"": ""http://google.com/"",
                     } 
                  }";

            var client = CreateClientService(Features.LegacyDataResponse);

            // Check that the default serializer is set.
            Assert.IsType<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly.
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResult(client.DeserializeResponse<MockJsonSchema>(response).Result);
        }


        /// <summary>This tests Deserialization without data wrapping.</summary>
        [Fact]
        public void TestDeserialization_WithoutDataWrapping()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            // by default the request provider doesn't contain the LegacyDataResponse
            var client = CreateClientService();

            // Check that the default serializer is set
            Assert.IsType<NewtonsoftJsonSerializer>(client.Serializer);

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResult(
                client.DeserializeResponse<MockJsonSchema>(response).Result);
        }

        /// <summary>Tests serialization with data wrapping.</summary>
        [Fact]
        public void TestSerialization_WithDataWrapping()
        {
            // Requets should not be wrapped
            const string Response =
                "{\"kind\":\"urlshortener#url\",\"longUrl\":\"http://google.com/\"}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientService(Features.LegacyDataResponse);

            // Check if a response is serialized correctly
            string result = client.SerializeObject(schema);
            Assert.Equal(Response, result);
        }

        /// <summary>Tests serialization without data wrapping.</summary>
        [Fact]
        public void TestSerialization_WithoutDataWrapping()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockJsonSchema schema = new MockJsonSchema();
            schema.Kind = "urlshortener#url";
            schema.LongURL = "http://google.com/";

            var client = CreateClientService();

            // Check if a response is serialized correctly.
            string result = client.SerializeObject(schema);
            Assert.Equal(Response, result);
        }

        /// <summary>
        /// Confirms that the serializer won't do anything if a string is the requested response type.
        /// </summary>
        [Fact]
        public void TestDeserializationString()
        {
            const string Response = @"{""kind"":""urlshortener#url"",""longUrl"":""http://google.com/""}";

            MockClientService client = new MockClientService();

            // Check that the response is decoded correctly
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(Response));
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            string result = client.DeserializeResponse<string>(response).Result;
            Assert.Equal(Response, result);
        }

        /// <summary>Tests deserialization for server error response.</summary>
        [Theory, CombinatorialData]
        public void TestErrorDeserialization(
          [CombinatorialValues(Features.LegacyDataResponse, null)] Features? features)
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

            var client = CreateClientService(features);

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(ErrorResponse)))
            {
                var response = new HttpResponseMessage { Content = new StreamContent(stream) };
                RequestError error = client.DeserializeError(response).Result;
                Assert.Equal(400, error.Code);
                Assert.Equal("Required", error.Message);
                Assert.Equal(1, error.Errors.Count);
            }
        }

        /// <summary>
        /// A mock authentication message handler which returns an unauthorized response in the first call, and a 
        /// successful response in the second.
        /// </summary>
        class MockAuthenticationMessageHandler : CountableMessageHandler
        {
            internal static string FirstToken = "invalid";
            internal static string SecondToken = "valid";

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                switch (Calls)
                {
                    case 1:
                        Assert.Equal(1, request.Headers.GetValues("Authorization").Count());
                        Assert.Equal(FirstToken, request.Headers.GetValues("Authorization").First());
                        tcs.SetResult(new HttpResponseMessage
                            {
                                StatusCode = System.Net.HttpStatusCode.Unauthorized
                            });
                        break;
                    case 2:
                        Assert.Equal(1, request.Headers.GetValues("Authorization").Count());
                        Assert.Equal(SecondToken, request.Headers.GetValues("Authorization").First());
                        tcs.SetResult(new HttpResponseMessage());
                        break;
                    default:
                        throw new Exception("There should be only two calls");
                }

                return tcs.Task;
            }
        }

        /// <summary>
        /// Tests the default values of <seealso cref="Google.Apis.Services.BaseClientService"/>
        /// </summary>
        [Fact]
        public void Constructor_DefaultValues()
        {
            var service = new MockClientService(new BaseClientService.Initializer());
            Assert.NotNull(service.HttpClient);
            Assert.Null(service.HttpClientInitializer);
            Assert.True(service.GZipEnabled);

            // Disable "<member> is obsolete" warning for these uses.
            // MessageHandler no longer provides a supported way for clients to query the list of handlers,
            // but we rely on the obsolete property as an implementation detail here.
            #pragma warning disable 618
            // Back-off handler for unsuccessful response (503) is added by default.
            Assert.Equal(1, service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Count);
            Assert.IsAssignableFrom<BackOffHandler>(service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.FirstOrDefault());

            // An execute interceptors is expected (for handling GET requests with URLs that are too long)
            Assert.Equal(1, service.HttpClient.MessageHandler.ExecuteInterceptors.Count);
            Assert.IsType<MaxUrlLengthInterceptor>(service.HttpClient.MessageHandler.ExecuteInterceptors.FirstOrDefault());
            #pragma warning restore 618
        }

        private const uint DefaultMaxUrlLength = BaseClientService.DefaultMaxUrlLength;

        /// <summary>
        /// Verifies that URLs over 2K characters on GET requests are correctly translated to a POST request.
        /// </summary>
        [Fact]
        public void TestGetWithUrlTooLongByDefault()
        {
            // Build a query string such that the whole URI adds up to 2049 characters
            var query = "q=" + new String('x', 1020) + "&x=" + new String('y', 1000);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var messageHandler = new MockMessageHandler();
            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(messageHandler)
                }))
            {
                service.HttpClient.SendAsync(request);
                // Confirm the test URI is one character too long.
                Assert.Equal(DefaultMaxUrlLength + 1, (uint)requestUri.Length);
                // Confirm the request was modified correctly:
                Assert.Equal(HttpMethod.Post, request.Method);
                Assert.Equal("GET", request.Headers.GetValues("X-HTTP-Method-Override").Single());
                Assert.Equal(new MediaTypeHeaderValue("application/x-www-form-urlencoded"), request.Content.Headers.ContentType);
                Assert.Equal(new Uri(uri), request.RequestUri);
                Assert.Equal(query, messageHandler.RequestContent);
            }
        }

        /// <summary>
        /// Verifies that URLs of great lengths on GET requests are NOT translated to a POST request when the user
        /// sets the <c>maxUrlLength = 0</c>.
        /// </summary>
        [Fact]
        public void TestGetWithUrlMaxLengthDisabled()
        {
            var query = "q=" + new String('x', 5000) + "&x=" + new String('y', 6000);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var messageHandler = new MockMessageHandler();
            var initializer = (new BaseClientService.Initializer
            {
                HttpClientFactory = new MockHttpClientFactory(messageHandler),
                MaxUrlLength = 0
            });

            using (var service = new MockClientService(initializer))
            {
                service.HttpClient.SendAsync(request);
                // Confirm the request was not modified.
                Assert.Equal(requestUri.Length, request.RequestUri.ToString().Length);
                Assert.Equal(HttpMethod.Get, request.Method);
                Assert.False(request.Headers.Contains("X-HTTP-Method-Override"));
                Assert.Null(request.Content);
                Assert.Equal(new Uri(requestUri), request.RequestUri);
            }
        }

        [Fact]
        public void ValidApplicationName()
        {
            // Assert no exception thrown
            new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = "AppName"
            });
        }

        [Fact]
        public void NullApplicationName()
        {
            // Assert no exception thrown
            new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = null
            });
        }

        [Fact]
        public void InvalidApplicationName()
        {
            // Assert no exception thrown
            Assert.Throws<ArgumentException>(() => new MockClientService(new BaseClientService.Initializer
            {
                ApplicationName = "App=Name"
            }));
        }
    }
}
