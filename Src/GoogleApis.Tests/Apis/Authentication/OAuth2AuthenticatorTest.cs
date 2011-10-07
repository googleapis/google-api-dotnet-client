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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using NUnit.Framework;

using Google.Apis.Authentication;

namespace Google.Apis.Tests.Apis.Authentication
{
    [TestFixture()]
    public class OAuth2AuthenticatorTest
    {
        private OAuth2Authenticator authenticator = null;
        private string applicationName = "sampleApp"; 
        private string consumerKey = "aEGBE343QERQEWR462438"; 
        private string consumerSecret = "2435435srtwerER3AF3343adsf"; 
        private string token = "asdq1324gpoiusdasfaEREaafs"; 

        [TestFixtureSetUp()]
        public void SetUp()
        {
            authenticator = new OAuth2Authenticator(applicationName, consumerKey, consumerSecret, token);
        }

        [Test()]
        public void ConstructorTest()
        {
            Assert.NotNull(authenticator);
        }

        [Test()]
        public void TokenTest()
        {
            Assert.AreEqual(token, authenticator.Token);
        }

        [Test()]
        public void ApplyAuthenticationToRequestTest()
        {
            HttpWebRequest request = HttpWebRequest.CreateDefault(new Uri("http://www.example.com")) as HttpWebRequest;
            authenticator.ApplyAuthenticationToRequest(request);
            string expectedHeaderKey = "Authorization";
            string expectedHeaderValue = "OAuth " + token;
            Assert.IsTrue(request.Headers.AllKeys.Contains(expectedHeaderKey));
            Assert.AreEqual(expectedHeaderValue, request.Headers[expectedHeaderKey]);
        }
    }
}
