/*
Copyright 2018 Google LLC.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;
using IntegrationTests.Utils;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class RevocationTests
    {
        [Fact]
        public async Task RevokeFakeToken_BadRequest()
        {
            // Tests that the correct 400 response is received from the server, given an invalid token.
            // Validates the revoke URL and verb are correct.
            using (var f = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecretsStream = Helper.GetClientSecretStream()
            }))
            {
                var ex = await Assert.ThrowsAsync<TokenResponseException>(
                    () => f.RevokeTokenAsync("fake-user", "fake-token", default));
                Assert.Equal(HttpStatusCode.BadRequest, ex.StatusCode);
                Assert.Equal("invalid_token", ex.Error.Error);
            }
        }

        [Fact]
        public async Task RevokeRealToken()
        {
            UserCredential cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                Helper.GetClientSecretStream(), new string[] { "email" },
                "user", default, new NullDataStore());
            Assert.NotNull(cred);
            var accessToken = await cred.GetAccessTokenForRequestAsync();
            using (var f = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecretsStream = Helper.GetClientSecretStream()
            }))
            {
                // Succeeds if no exception is thrown.
                await f.RevokeTokenAsync("a-user", accessToken, default);
                // Cannot verify revocation, as it takes in indeterminate duration to propagate.
            }
        }
    }
}
