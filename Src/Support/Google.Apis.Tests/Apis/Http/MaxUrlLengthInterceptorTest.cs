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
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Http;
using Google.Apis.Tests;
using Xunit;
using Google.Apis.Tests.Mocks;

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>
    /// Tests for <seealso cref="MaxUrlLengthInterceptor"/>. 
    /// For the default case, 
    /// <seealso cref="Google.Apis.Tests.Apis.Services.BaseClientServiceTest.TestGetWithUrlTooLongByDefault"/>.
    /// </summary>
    public class MaxUrlLengthInterceptorTest
    {
        private const uint DefaultMaxUrlLength = 2048;

        /// <summary>
        /// Regression test to verify that URLs less than or equal to 2048 characters on GET requests are not modified.
        /// </summary>
        [Fact]
        public void TestGetWithUrlOkayLengthByDefault()
        {
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength, HttpMethod.Get);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength - 1, HttpMethod.Get);
            SubtestGetWithUrlOkayLengthByDefault(100, HttpMethod.Get);
        }

        /// <summary>
        /// Regression test to verify that non-GET requests with URLs shorter or greater than 2048 characters are not
        /// modified.
        /// </summary>
        [Fact]
        public void TestNonGetWithUrlOkayLengthByDefault()
        {
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength + 1, HttpMethod.Post);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength, HttpMethod.Post);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength - 1, HttpMethod.Post);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength + 1, HttpMethod.Delete);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength, HttpMethod.Delete);
            SubtestGetWithUrlOkayLengthByDefault(DefaultMaxUrlLength - 1, HttpMethod.Delete);

        }

        /// <summary>
        /// Helper for regression tests that URLs less than or equal to 2048 characters, or requests that are not GET,
        /// are not modified. If you are testing with GET, the length should be less than 2048.
        /// </summary>
        private void SubtestGetWithUrlOkayLengthByDefault(uint length, HttpMethod method)
        {
            var requestUri = "http://www.example.com/?q=" + new String('x', (int)length - 26);
            var request = new HttpRequestMessage(method, requestUri);
            var mockHandler = new MockMessageHandler();
            var handler = new ConfigurableMessageHandler(mockHandler);
            handler.AddExecuteInterceptor(new MaxUrlLengthInterceptor(DefaultMaxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                Assert.Equal((int)length, request.RequestUri.ToString().Length);
                Assert.Equal(method, request.Method);
                Assert.False(request.Headers.Contains("X-HTTP-Method-Override"));
                Assert.Null(request.Content);
                Assert.Equal(new Uri(requestUri), request.RequestUri);
            }
        }

        /// <summary>
        /// Reproducing bug in version 1.8.1. We were deleting by mistake the last letter in the URL. 
        /// So when we were expected to send a new POST query to the following URL
        /// http://www.googleapis.com/language/translate/v2, we actually created
        /// a new query to http://www.googleapis.com/language/translate/v (2 is missing).
        /// See https://code.google.com/p/google-api-dotnet-client/issues/detail?id=455
        /// </summary>
        [Fact]
        public void TestGetPathQueryWithUrlOkayLengthByDefault()
        {
            uint maxUrlLength = 1000;
            var query = "q=" + new String('x', 1000);
            var uri = "http://www.googleapis.com/language/translate/v2";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var mockHandler = new MockMessageHandler();
            var handler = new ConfigurableMessageHandler(mockHandler);
            handler.AddExecuteInterceptor(new MaxUrlLengthInterceptor(maxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                // Confirm the request was modified correctly, and the uri was set correctly.
                Assert.Equal(new Uri(uri), request.RequestUri);
                Assert.Equal(query, mockHandler.RequestContent);
            }
        }

        /// <summary>
        /// Verifies that URLs over user-specified max number of characters (see the value of maxUrlLength) on GET 
        /// requests are correctly translated to a POST request.
        /// </summary>
        [Fact]
        public void TestGetWithUrlTooLongByUserSpecified()
        {
            uint maxUrlLength = 1000;
            var query = "q=" + new String('x', 900) + "&x=" + new String('y', 72);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var mockHandler = new MockMessageHandler();
            var handler = new ConfigurableMessageHandler(mockHandler);
            handler.AddExecuteInterceptor(new MaxUrlLengthInterceptor(maxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                // Confirm the test URI is one character too long.
                Assert.Equal((int)maxUrlLength + 1, requestUri.Length);
                // Confirm the request was modified correctly:
                Assert.Equal(HttpMethod.Post, request.Method);
                Assert.Equal("GET", request.Headers.GetValues("X-HTTP-Method-Override").Single());
                Assert.Equal(new MediaTypeHeaderValue("application/x-www-form-urlencoded"), request.Content.Headers.ContentType);
                Assert.Equal(new Uri(uri), request.RequestUri);
                Assert.Equal(query, mockHandler.RequestContent);
            }
        }
    }
}
