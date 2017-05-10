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
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>Tests for <seealso cref="Google.Apis.Requests.BatchRequest"/>.</summary>
    public class BatchRequestTest
    {
        private static string ExpectedContentMessage = NormalizeLineEndings(@"--BOUNDARY
Content-Type: application/http

POST http://sample.com/5?q=20
If-Match: ""100""
Content-Type: application/json; charset=utf-8
Content-Length:  41

{""etag_key"":""\""100\"""",""name_key"":""Name1""}

--BOUNDARY
Content-Type: application/http

POST http://sample.com/5?q=20
If-Match: ""200""
Content-Type: application/json; charset=utf-8
Content-Length:  43

{""etag_key"":""\""200\"""",""name_key"":""Name1-1""}

--BOUNDARY--
");
        /// <summary>A mock response class.</summary>
        class MockResponse : IDirectResponseSchema
        {
            [Newtonsoft.Json.JsonPropertyAttribute("etag_key")]
            public string ETag { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("id_key")]
            public Nullable<int> Id { get; set; }

            public override bool Equals(object obj)
            {
                var other = obj as MockResponse;
                return other != null && other.ETag == ETag && other.Id == Id;
            }

            public override int GetHashCode()
            {
                return (ETag ?? string.Empty).GetHashCode();
            }
        }

        /// <summary>A mock request class.</summary>
        class MockRequest : IDirectResponseSchema
        {
            [Newtonsoft.Json.JsonPropertyAttribute("etag_key")]
            public string ETag { get; set; }

            [Newtonsoft.Json.JsonPropertyAttribute("name_key")]
            public string Name { get; set; }

            public override bool Equals(object obj)
            {
                var other = obj as MockRequest;
                return (other != null && other.ETag == ETag && other.Name == Name);
            }

            public override int GetHashCode()
            {
                return (ETag ?? string.Empty).GetHashCode() ^ (Name ?? string.Empty).GetHashCode();
            }
        }

        /// <summary>A mock service request which returns <see cref="MockResponse"/>.</summary>
        class TestClientServiceRequest : ClientServiceRequest<MockResponse>
        {
            private MockRequest body;

            [RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public int Id { get { return 5; } }

            [RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public int Q { get { return 20; } }

            public TestClientServiceRequest(IClientService service, MockRequest body)
                : base(service)
            {
                this.body = body;
                InitParameters();
            }

            public override string MethodName
            {
                get { return "POST"; }
            }

            public override string RestPath
            {
                get { return "{id}"; }
            }

            public override string HttpMethod
            {
                get { return "POST"; }
            }

            protected override object GetBody()
            {
                return body;
            }

            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Parameter { Name = "id", ParameterType = "path" });
                RequestParameters.Add("q", new Parameter { Name = "q", ParameterType = "query" });
            }
        }

        /// <summary>
        /// Message handler which verifies that the input request is correct and returns a response. The response may 
        /// contain an unsuccessful response for the 2nd individual request based on the boolean flag to its 
        /// constructor.
        /// </summary>
        class BatchMessageHandler : CountableMessageHandler
        {
            private static string ResponseContent = NormalizeLineEndings(@"--BOUNDARY
Content-Type: application/http

HTTP/1.1 200 OK
ETag: ""\""10011\""""
Content-Type: application/json; charset=UTF-8
Content-Length: 505
Vary: Accept-Encoding
Vary: Referer

{
 ""etag_key"": ""\""10011\"""",
 ""id_key"": 1
}

--BOUNDARY
Content-Type: application/http

SECOND_RESPONSE

--BOUNDARY--");

            private static string SuccessfulResponse = NormalizeLineEndings(
@"HTTP/1.1 200 OK
ETag: ""234""
Content-Type: application/json; charset=UTF-8
Content-Length: 202

{
 ""id_key"": 2
}");

            private static string UnsuccessfulResponse = NormalizeLineEndings(
@"HTTP/1.1 404 Not Found
Content-Type: application/json; charset=UTF-8
Date: Thu, 14 Nov 2013 22:03:08 GMT
Expires: Thu, 14 Nov 2013 22:03:08 GMT
Cache-Control: private, max-age=0
Content-Length: 202

{
 ""error"": {
  ""errors"": [
   {
    ""domain"": ""global"",
    ""reason"": ""notFound"",
    ""message"": ""Not Found"",
   }
  ],
  ""code"": 404,
  ""message"": ""Not Found""
 }
}");
            bool successful2ndResponse;
            public BatchMessageHandler(bool successful2ndReponse = true)
            {
                this.successful2ndResponse = successful2ndReponse;
            }

            protected override Task<HttpResponseMessage> SendAsyncCore(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                // Verify Request Message
                var contentType = request.Content.Headers.ContentType;
                Assert.Equal("multipart/mixed", contentType.MediaType.ToString());
                Assert.Equal(1, contentType.Parameters.Count);
                Assert.True(contentType.Parameters.First().ToString().StartsWith("boundary="),
                    "Parameter should start with boundary=");
                var boundary = contentType.Parameters.First().ToString().Substring("boundary=".Length).
                    Replace("\"", "");
                var expectedContent = ExpectedContentMessage.Replace("BOUNDARY", boundary);
                var actualContent = request.Content.ReadAsStringAsync().Result;
                Assert.Equal(expectedContent, NormalizeLineEndings(actualContent));

                HttpResponseMessage response = new HttpResponseMessage();
                // Response contains 2 responses. The second one is successful based on the constructor's parameter.
                var content = ResponseContent.Replace("BOUNDARY", boundary).Replace("SECOND_RESPONSE",
                    successful2ndResponse ? SuccessfulResponse : UnsuccessfulResponse);
                response.Content = new StringContent(content,
                    Encoding.UTF8, "multipart/mixed");
                response.Content.Headers.ContentType.Parameters.Add(new NameValueHeaderValue("boundary", boundary));

                TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
                tcs.SetResult(response);
                return tcs.Task;
            }
        }

        [Fact]
        public void ExecuteAsync_Test()
        {
            SubtestExecuteAsync_Test(true);
        }

        [Fact]
        public void ExecuteAsync_Error_Test()
        {
            SubtestExecuteAsync_Test(false);
        }

        /// <summary>Subtest for the execute method.</summary>
        /// <param name="successful2ndReponse">Indicates if the 2nd individual response is unsuccessful.</param>
        void SubtestExecuteAsync_Test(bool successful2ndReponse)
        {
            var handler = new BatchMessageHandler(successful2ndReponse);
            var initializer = new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(handler)
            };

            using (var service = new MockClientService(initializer, "http://sample.com"))
            {
                var responses = new List<Tuple<MockResponse, RequestError, HttpResponseMessage>>();
                var batch = new BatchRequest(service);
                var request1 = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"100\"",
                        Name = "Name1"
                    });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"200\"",
                        Name = "Name1-1"
                    });
                // Adding the content, error and message into the responses list to verify the results later on
                batch.Queue<MockResponse>(request1, (content, error, index, message) =>
                    {
                        responses.Add(new Tuple<MockResponse, RequestError, HttpResponseMessage>(
                            content, error, message));
                    });
                batch.Queue<MockResponse>(request2, (content, error, index, message) =>
                    {
                        responses.Add(new Tuple<MockResponse, RequestError, HttpResponseMessage>(
                                                    content, error, message));
                    });
                batch.ExecuteAsync().Wait();

                Assert.Equal(2, responses.Count);
                var tuple = responses[0];
                Assert.Null(tuple.Item2); // no error
                var response = tuple.Item1; // response
                Assert.Equal(@"""10011""", response.ETag);
                Assert.Equal(1, response.Id);
                var httpMessage = tuple.Item3; // HTTP message
                Assert.Equal("application/json", httpMessage.Content.Headers.ContentType.MediaType);
                Assert.Equal(505, httpMessage.Content.Headers.ContentLength);
                Assert.True(httpMessage.Headers.Vary.Contains("Accept-Encoding"));
                Assert.True(httpMessage.Headers.Vary.Contains("Referer"));

                tuple = responses[1];
                if (successful2ndReponse)
                {
                    Assert.Null(tuple.Item2); // no error
                    response = tuple.Item1; // response
                    Assert.Equal(@"""234""", response.ETag);
                    Assert.Equal(2, response.Id);
                }
                else
                {
                    Assert.Null(tuple.Item1); // no response
                    RequestError reqError = tuple.Item2; // error
                    Assert.Equal(1, reqError.Errors.Count);
                    Assert.Equal(404, reqError.Code);
                    Assert.Equal("Not Found", reqError.Message);
                }
                httpMessage = tuple.Item3; // HTTP message
                Assert.Equal("application/json", httpMessage.Content.Headers.ContentType.MediaType);
                Assert.Equal(202, httpMessage.Content.Headers.ContentLength);
            }
        }

        [Fact]
        public void ExecuteAsync_NoCallback_Test()
        {
            var handler = new BatchMessageHandler(true);
            var initializer = new BaseClientService.Initializer()
            {
                HttpClientFactory = new MockHttpClientFactory(handler)
            };

            using (var service = new MockClientService(initializer, "http://sample.com"))
            {
                var responses = new List<Tuple<MockResponse, RequestError, HttpResponseMessage>>();
                var batch = new BatchRequest(service);
                var request1 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"200\"",
                    Name = "Name1-1"
                });
                batch.Queue<MockResponse>(request1, null);
                batch.Queue<MockResponse>(request2, null);
                batch.ExecuteAsync().Wait();
            }
        }

        [Fact]
        public void CreateOuterRequestContent_Test()
        {
            using (var service = new MockClientService("http://sample.com"))
            {
                var request1 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"100\"",
                    Name = "Name1"
                });
                var request2 = new TestClientServiceRequest(service, new MockRequest
                {
                    ETag = "\"200\"",
                    Name = "Name1-1"
                });

                var content = BatchRequest.CreateOuterRequestContent(new[] { request1, request2 }).Result;
                var requestStr = content.ReadAsStringAsync().Result;

                // Read the boundary.
                string boundary = null;
                using (var reader = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(requestStr))))
                {
                    var line = reader.ReadLine();
                    boundary = line.Substring(2);
                }

                Assert.Equal(ExpectedContentMessage.Replace("BOUNDARY", boundary), NormalizeLineEndings(requestStr));
            }
        }

        [Fact]
        public void CreateIndividualRequest_Test()
        {
            var expectedMessage = NormalizeLineEndings(@"POST http://sample.com/5?q=20
If-Match: ""123""
Content-Type: application/json; charset=utf-8
Content-Length:  40

{""etag_key"":""\""123\"""",""name_key"":""Name""}
");
            using (var service = new MockClientService("http://sample.com"))
            {
                var request = new TestClientServiceRequest(service, new MockRequest
                    {
                        ETag = "\"123\"",
                        Name = "Name"
                    });
                var content = BatchRequest.CreateIndividualRequest(request).Result;
                var requestStr = content.ReadAsStringAsync().Result;
                Assert.Equal(expectedMessage, NormalizeLineEndings(requestStr));
            }
        }

        [Fact]
        public void CreateRequestContentString_Test()
        {
            var expectedMessage = NormalizeLineEndings(@"GET http://test.com:2020/
Accept-Encoding: gzip
Content-Type: application/json
Content-Length:  11

hello world
");
            var request = new HttpRequestMessage(HttpMethod.Get, "http://test.com:2020");
            request.Content = new StringContent("hello world");
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var requestStr = BatchRequest.CreateRequestContentString(request).Result;
            Assert.Equal(expectedMessage, NormalizeLineEndings(requestStr));
        }

        [Fact]
        public void BatchUrl()
        {
            using (var service = new MockClientService("http://sample.com", "http://batch.sample.com"))
            {
                var batch = new BatchRequest(service);
                Assert.Equal("http://batch.sample.com", batch.BatchUrl);
            }
            using (var service = new MockClientService("http://sample.com", null))
            {
                var batch = new BatchRequest(service);
                Assert.Equal("https://www.googleapis.com/batch", batch.BatchUrl);
            }
        }

        // Line endings in HttpContent are different between mono & .NET.
        private static string NormalizeLineEndings(string s) {
            return Regex.Replace(s, @"\r\n|\n", "\r\n");
        }
    }
}
