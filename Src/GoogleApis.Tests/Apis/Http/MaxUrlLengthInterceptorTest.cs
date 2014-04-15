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

using NUnit.Framework;

using Google.Apis.Http;
using Google.Apis.Tests;

namespace Google.Apis.Tests.Apis.Http
{
    /// <summary>
    /// Tests for <seealso cref="MaxUrlLengthInterceptor"/>. 
    /// For the default case, 
    /// <seealso cref="Google.Apis.Tests.Apis.Services.BaseClientServiceTest.TestGetWithUrlTooLongByDefault"/>.
    /// </summary>
    class MaxUrlLengthInterceptorTest
    {
        private const uint DefaultMaxUrlLength = 2048;

        /// <summary>
        /// Regression test to verify that URLs less than or equal to 2048 characters on GET requests are not modified.
        /// </summary>
        [Test]
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
        [Test]
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
            handler.ExecuteInterceptors.Add(new MaxUrlLengthInterceptor(DefaultMaxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                Assert.That(request.RequestUri.ToString().Length, Is.EqualTo(length));
                Assert.That(request.Method, Is.EqualTo(method));
                Assert.That(request.Headers.Contains("X-HTTP-Method-Override"), Is.False);
                Assert.That(request.Content, Is.Null);
                Assert.That(request.RequestUri, Is.EqualTo(new Uri(requestUri)));
            }
        }

        /// <summary>
        /// Reproducing bug in version 1.8.1. We were deleting by mistake the last letter in the URL. 
        /// So when we were expected to send a new POST query to the following URL
        /// http://www.googleapis.com/language/translate/v2, we actually created
        /// a new query to http://www.googleapis.com/language/translate/v (2 is missing).
        /// See https://code.google.com/p/google-api-dotnet-client/issues/detail?id=455
        /// </summary>
        [Test]
        public void TestGetPathQueryWithUrlOkayLengthByDefault()
        {
            uint maxUrlLength = 1000;
            var query = "q=" + new String('x', 1000);
            var uri = "http://www.googleapis.com/language/translate/v2";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var mockHandler = new MockMessageHandler();
            var handler = new ConfigurableMessageHandler(mockHandler);
            handler.ExecuteInterceptors.Add(new MaxUrlLengthInterceptor(maxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                // Confirm the request was modified correctly, and the uri was set correctly.
                Assert.That(request.RequestUri, Is.EqualTo(new Uri(uri)));
                Assert.That(mockHandler.RequestContent, Is.EqualTo(query));
            }
        }

        /// <summary>
        /// Verifies that URLs over user-specified max number of characters (see the value of maxUrlLength) on GET 
        /// requests are correctly translated to a POST request.
        /// </summary>
        [Test]
        public void TestGetWithUrlTooLongByUserSpecified()
        {
            uint maxUrlLength = 1000;
            var query = "q=" + new String('x', 900) + "&x=" + new String('y', 72);
            var uri = "http://www.example.com/";
            var requestUri = uri + "?" + query;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var mockHandler = new MockMessageHandler();
            var handler = new ConfigurableMessageHandler(mockHandler);
            handler.ExecuteInterceptors.Add(new MaxUrlLengthInterceptor(maxUrlLength));
            using (var httpClient = new HttpClient(handler))
            {
                httpClient.SendAsync(request);
                // Confirm the test URI is one character too long.
                Assert.That(requestUri.Length, Is.EqualTo(maxUrlLength + 1));
                // Confirm the request was modified correctly:
                Assert.That(request.Method, Is.EqualTo(HttpMethod.Post));
                Assert.That(request.Headers.GetValues("X-HTTP-Method-Override").Single(), Is.EqualTo("GET"));
                Assert.That(request.Content.Headers.ContentType,
                    Is.EqualTo(new MediaTypeHeaderValue("application/x-www-form-urlencoded")));
                Assert.That(request.RequestUri, Is.EqualTo(new Uri(uri)));
                Assert.That(mockHandler.RequestContent, Is.EqualTo(query));
            }
        }
    }
}
