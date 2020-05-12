/*
Copyright 2020 Google Inc

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

using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using IntegrationTests.IntegrationTests.Utils;
using IntegrationTests.Utils;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class OidcTests
    {
        [Fact]
        public async Task OidcTokenProvider_ServiceAccountCredential()
        {
            GoogleCredential credential = Helper.GetServiceCredential();

            OidcToken token = await credential.GetOidcTokenAsync(
                OidcTokenOptions.FromTargetAudience("https://this.is.a.test"));

            // Check an access token (really id_token) is available.
            Assert.NotNull(await token.GetAccessTokenAsync());
            // If IdToken is set and AccessToken is not, AccessToken is set to
            // IdToken, so we can always check here that AccessToken is not null.
            Assert.NotNull(token.TokenResponse.AccessToken);
            // The enpoint does not send an expiry, bu we set it to the id_token
            // expiry.
            Assert.NotNull(token.TokenResponse.ExpiresInSeconds);

            var verificationOptions = new SignedTokenVerificationOptions();
            verificationOptions.TrustedAudiences.Add("https://this.is.a.test");

            var payload = await JsonWebSignature.VerifySignedTokenAsync(await token.GetAccessTokenAsync());
            Assert.NotNull(payload);
            Assert.Contains("https://this.is.a.test", payload.AudienceAsList);
        }

        [OnGceFact]
        public async Task OidcTokenProvider_ComputeCredential()
        {
            // This test only executes on GCE so we are certain to have a ComputeCredential.
            GoogleCredential credential = GoogleCredential.FromComputeCredential();

            OidcToken token = await credential.GetOidcTokenAsync(
                OidcTokenOptions.FromTargetAudience("https://this.is.a.test"));

            // Check an access token (really id_token) is available.
            Assert.NotNull(await token.GetAccessTokenAsync());
            // If IdToken is set and AccessToken is not, AccessToken is set to
            // IdToken, so we can always check here that AccessToken is not null.
            Assert.NotNull(token.TokenResponse.AccessToken);
            // The enpoint does not send an expiry, bu we set it to the id_token
            // expiry.
            Assert.NotNull(token.TokenResponse.ExpiresInSeconds);

            var verificationOptions = new SignedTokenVerificationOptions();
            verificationOptions.TrustedAudiences.Add("https://this.is.a.test");

            var payload = await JsonWebSignature.VerifySignedTokenAsync(await token.GetAccessTokenAsync());
            Assert.NotNull(payload);
            Assert.Contains("https://this.is.a.test", payload.AudienceAsList);
        }
    }
}
