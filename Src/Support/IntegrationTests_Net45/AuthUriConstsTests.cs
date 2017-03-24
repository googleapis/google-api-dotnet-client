using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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

            Assert.That(GoogleAuthConsts.AuthorizationUrl, Is.EqualTo(wellKnown["authorization_endpoint"].ToString()));
            Assert.That(GoogleAuthConsts.TokenUrl, Is.EqualTo(wellKnown["token_endpoint"].ToString()));
            Assert.That(GoogleAuthConsts.RevokeTokenUrl, Is.EqualTo(wellKnown["revocation_endpoint"].ToString()));
        }
    }
}
