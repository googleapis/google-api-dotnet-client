/*
Copyright 2010 Google Inc

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
using NUnit.Framework;
using Google.Apis.Authentication;

namespace Google.Apis.Tests.Authentication
{
    /// <summary>
    /// Tests the "NullAuthenticator" class
    /// </summary>
    [TestFixture]
    public class NullAuthenticatorTest
    {
        /// <summary>
        /// Tests if the null authenticator can create a simple http web request
        /// </summary>
        [Test]
        public void SimpleCallTest()
        {
            var auth = new NullAuthenticator();
            var webRequest = new HttpRequestFactory().Create(new Uri("https://www.google.com"), "GET");
            auth.ApplyAuthenticationToRequest(webRequest);

            Assert.IsNotNull(webRequest);
            Assert.That(webRequest.RequestUri, Is.EqualTo(new Uri("https://www.google.com")));
            Assert.That(webRequest.Method, Is.EqualTo("GET"));
        }
    }
}