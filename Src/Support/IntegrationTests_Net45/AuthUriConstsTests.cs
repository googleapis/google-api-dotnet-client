/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Net;
using System.Text;

namespace IntegrationTests_Net45
{
    [TestFixture]
    public class AuthUriConstsTests
    {
        [Test]
        public void VerifyGoogleAuthConsts()
        {
            // Check that the URLs listed in GoogleConsts.cs match the canonical source:
            // at: https://accounts.google.com/.well-known/openid-configuration

            const string wellKnownUrl = "https://accounts.google.com/.well-known/openid-configuration";
            byte[] wellKnownBytes;
            using (var client = new WebClient())
            {
                wellKnownBytes = client.DownloadData(wellKnownUrl);
            }
            var wellKnown = JObject.Parse(Encoding.ASCII.GetString(wellKnownBytes));

            Assert.That(GoogleAuthConsts.OidcAuthorizationUrl, Is.EqualTo(wellKnown["authorization_endpoint"].ToString()));
            Assert.That(GoogleAuthConsts.OidcTokenUrl, Is.EqualTo(wellKnown["token_endpoint"].ToString()));
            Assert.That(GoogleAuthConsts.RevokeTokenUrl, Is.EqualTo(wellKnown["revocation_endpoint"].ToString()));
        }
    }
}
