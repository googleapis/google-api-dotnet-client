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

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using NUnit.Framework;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Testing;
using Google.Apis.Util;

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
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResults(client.DeserializeResponse<MockJsonSchema>(response).Result);
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
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            CheckDeserializationResults(
                client.DeserializeResponse<MockJsonSchema>(response).Result);
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
            var response = new HttpResponseMessage { Content = new StreamContent(stream) };
            string result = client.DeserializeResponse<string>(response).Result;
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
                var response = new HttpResponseMessage { Content = new StreamContent(stream) };
                RequestError error = client.DeserializeError(response).Result;
                Assert.AreEqual(400, error.Code);
                Assert.AreEqual("Required", error.Message);
                Assert.AreEqual(1, error.Errors.Count);
            }
        }

        #region Authentication

        /// <summary> 
        /// Mock authentication message handler which returns unauthorized response in the first call, and in the 
        /// second call it returns a successful response.
        /// </summary>
        class MockAuthenticationMessageHandler : CountableMessageHandler
        {
            internal static string FirstToken = "invalid";
            internal static string SecondToken = "valid";

            protected override async Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                switch (Calls)
                {
                    case 1:
                        Assert.That(request.Headers.GetValues("Authorization").Count(), Is.EqualTo(1));
                        Assert.That(request.Headers.GetValues("Authorization").First(), Is.EqualTo(FirstToken));
                        return new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
                    case 2:
                        Assert.That(request.Headers.GetValues("Authorization").Count(), Is.EqualTo(1));
                        Assert.That(request.Headers.GetValues("Authorization").First(), Is.EqualTo(SecondToken));
                        return new HttpResponseMessage();
                    default:
                        throw new Exception("There should be only two calls");
                }
            }
        }

        /// <summary> Mock Authenticator which adds Authorization header to a request on the second call. </summary>
        class Authenticator : IAuthenticator
        {
            public int ApplyCalls { get; set; }

            public void ApplyAuthenticationToRequest(System.Net.HttpWebRequest request)
            {
                ApplyCalls++;
                switch (ApplyCalls)
                {
                    case 1:
                        request.Headers["Authorization"] = MockAuthenticationMessageHandler.FirstToken;
                        break;
                    case 2:
                        request.Headers["Authorization"] = MockAuthenticationMessageHandler.SecondToken;
                        break;
                    default:
                        throw new Exception("There should be only two calls");
                }
            }
        }

        /// <summary> Mock Authenticator which handles unsuccessful response by "refreshing" the token. </summary>
        class AuthenticatorUnsuccessfulHandler : Authenticator, IHttpUnsuccessfulResponseHandler
        {
            public int HandleCalls { get; set; }

            public bool HandleResponse(HandleUnsuccessfulResponseArgs args)
            {
                HandleCalls++;
                // Mock a refresh token process here... (second apply will attach SecondToken authorization)
                return true;
            }
        }

        /// <summary> 
        /// Tests that authenticator helpers invokes both apply authentication and handle response methods on the 
        /// authentication instance.
        /// </summary>
        [Test]
        public void Test_Authentication_UnsuccessfulHandler()
        {
            var handler = new MockAuthenticationMessageHandler();
            var authenticator = new AuthenticatorUnsuccessfulHandler();
            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(handler),
                    Authenticator = authenticator
                }))
            {
                var response = service.HttpClient.SendAsync(
                    new HttpRequestMessage(HttpMethod.Get, "https://test")).Result;
                // the authenticator handles unsuccessful response handler by "refreshing" the token, so the request
                // will success
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
                Assert.That(handler.Calls, Is.EqualTo(2));
                Assert.That(authenticator.ApplyCalls, Is.EqualTo(2));
                Assert.That(authenticator.HandleCalls, Is.EqualTo(1));
            }
        }

        /// <summary> 
        /// Tests an authenticator which doesn't implement unsuccessful response handler, and as a result the request
        /// fails (when the token is invalid).
        /// </summary>
        [Test]
        public void Test_Authentication()
        {
            var handler = new MockAuthenticationMessageHandler();
            var authenticator = new Authenticator();
            using (var service = new MockClientService(new BaseClientService.Initializer()
                {
                    HttpClientFactory = new MockHttpClientFactory(handler),
                    Authenticator = authenticator
                }))
            {
                var response = service.HttpClient.SendAsync(
                    new HttpRequestMessage(HttpMethod.Get, "https://test")).Result;
                // the authenticator doesn't implement unsuccessful response handler, so the request fails
                Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized));
                Assert.That(handler.Calls, Is.EqualTo(1));
                Assert.That(authenticator.ApplyCalls, Is.EqualTo(1));
            }
        }

        #endregion

        #region Constructor

        [Test]
        public void Constructor_DefaultValues()
        {
            var service = new MockClientService(new BaseClientService.Initializer());
            Assert.NotNull(service.HttpClient);
            Assert.Null(service.HttpClientInitializer);
            Assert.That(service.Authenticator, Is.EqualTo(NullAuthenticator.Instance));
            Assert.True(service.GZipEnabled);

            // back-off handlers are added by default
            Assert.That(service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers.Count, Is.EqualTo(1));
            Assert.That(service.HttpClient.MessageHandler.UnsuccessfulResponseHandlers[0],
                Is.InstanceOf<BackOffHandler>());
            Assert.That(service.HttpClient.MessageHandler.ExceptionHandlers.Count, Is.EqualTo(1));
            Assert.That(service.HttpClient.MessageHandler.ExceptionHandlers[0],
                Is.InstanceOf<BackOffHandler>());

            // one execute interceptor (for adding the "Authenticate" header
            Assert.That(service.HttpClient.MessageHandler.ExecuteInterceptors.Count, Is.EqualTo(1));
            Assert.That(service.HttpClient.MessageHandler.ExecuteInterceptors[0],
                Is.InstanceOf<AuthenticatorInterceptor>());
        }

        #endregion
    }
}
