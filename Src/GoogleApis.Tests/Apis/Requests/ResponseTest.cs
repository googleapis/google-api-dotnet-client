/*
Copyright 2011 Google Inc

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
using System.Net;
using Google.Apis.Requests;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>
    /// Tests for the Response class.
    /// </summary>
    [TestFixture]
    public class ResponseTest
    {
        private class MockWebresponse : WebResponse
        {
            public override Stream GetResponseStream()
            {
                return new MemoryStream();
            }

            public override WebHeaderCollection Headers
            {
                get
                {
                    var headers = new WebHeaderCollection();
                    headers.Add(HttpResponseHeader.ETag, "12345");
                    return headers;
                }
            }
        }

        /// <summary>
        /// Tests the validation of the constructor taking a Webresponse.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            // Test parameter validation.
            Assert.Throws<ArgumentNullException>(() => new Response(null));
            Assert.DoesNotThrow(() => new Response(new MockWebresponse()));
        }

        /// <summary>
        /// Tests the behavior of the properties on a Response.
        /// </summary>
        [Test]
        public void SimplePropertiesTest()
        {
            var response = new Response(new MockWebresponse());
            Assert.AreEqual(response.ETag, "12345");
            Assert.AreEqual(response.Stream, response.Stream); // Test that the stream is cached.
            Assert.IsNotNull(response.Stream);
        }
    }
}
