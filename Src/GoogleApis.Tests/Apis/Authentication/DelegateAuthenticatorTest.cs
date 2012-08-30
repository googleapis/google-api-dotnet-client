/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Net;
using Google.Apis.Authentication;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Authentication
{
    /// <summary>
    /// Tests for the DelegateAuthenticator class.
    /// </summary>
    [TestFixture]
    public class DelegateAuthenticatorTest
    {
        /// <summary>
        /// Tests the constructor of this class.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.Throws<ArgumentNullException>(() => new DelegateAuthenticator(null));
            Assert.DoesNotThrow(() => new DelegateAuthenticator((request) => { }));
        }

        /// <summary>
        /// Tests the authenticator when doing simple modifications.
        /// </summary>
        [Test]
        public void SimpleModificationTest()
        {
            var auth = new DelegateAuthenticator((request) => request.Timeout = 1234);
            HttpWebRequest result = new HttpRequestFactory().Create(new Uri("http://example.com/"), "GET");
            auth.ApplyAuthenticationToRequest(result);

            // Verify the results.
            Assert.AreEqual("http://example.com/", result.RequestUri.ToString());
            Assert.AreEqual("GET", result.Method);
            Assert.AreEqual(1234, result.Timeout);
        }

        /// <summary>
        /// Tests the authenticator when doing simple modifications.
        /// </summary>
        [Test]
        public void SimpleModificationWithPreviousAuthenticatorTest()
        {
            var firstAuth = new DelegateAuthenticator(request => request.Method = "POST");
            var auth = new DelegateAuthenticator(request => request.Timeout = 1234);
            HttpWebRequest result = (new HttpRequestFactory()).Create(new Uri("http://example.com/"), "GET");

            firstAuth.ApplyAuthenticationToRequest(result);
            auth.ApplyAuthenticationToRequest(result);

            // Verify the results.
            Assert.AreEqual("http://example.com/", result.RequestUri.ToString());
            Assert.AreEqual("POST", result.Method);
            Assert.AreEqual(1234, result.Timeout);
        }
    }
}
