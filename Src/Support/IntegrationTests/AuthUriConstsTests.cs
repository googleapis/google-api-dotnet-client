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
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class AuthUriConstsTests
    {
        [Fact]
        public async Task VerifyGoogleAuthConsts()
        {
            // Check that the URLs listed in GoogleConsts.cs match the canonical source:
            // at: https://accounts.google.com/.well-known/openid-configuration

            const string wellKnownUrl = "https://accounts.google.com/.well-known/openid-configuration";
            string wellKnownJson;
            using (var client = new HttpClient())
            {
                wellKnownJson = await client.GetStringAsync(wellKnownUrl);
            }
            var wellKnown = JObject.Parse(wellKnownJson);

            Assert.Equal(wellKnown["authorization_endpoint"].ToString(), GoogleAuthConsts.OidcAuthorizationUrl);
            Assert.Equal(wellKnown["token_endpoint"].ToString(), GoogleAuthConsts.OidcTokenUrl);
            Assert.Equal(wellKnown["revocation_endpoint"].ToString(), GoogleAuthConsts.RevokeTokenUrl);
            Assert.Equal(wellKnown["jwks_uri"].ToString(), GoogleAuthConsts.JsonWebKeySetUrl);
        }
    }
}
