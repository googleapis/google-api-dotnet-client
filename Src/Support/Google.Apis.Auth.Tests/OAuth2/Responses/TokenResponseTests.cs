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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2.Responses
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Responses.TokenResponse"/>.
    /// </summary>
    public class TokenResponseTests
    {
        [Fact]
        public void TestConstructor()
        {
            var response = new TokenResponse();
            Assert.Null(response.AccessToken);
            Assert.Null(response.IdToken);
            Assert.Null(response.ExpiresInSeconds);
            Assert.Null(response.RefreshToken);
            Assert.Null(response.Scope);
            Assert.Equal(DateTime.MinValue, response.IssuedUtc);
        }

        [Fact]
        public void TestSerializer()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'access_token': '123',
                 'id_token': '321',
                 'expires_in': 1000,
                 'refresh_token': '456',
                 'scope': '789'
                }");
            Assert.Equal("123", tokenResponse.AccessToken);
            Assert.Equal("321", tokenResponse.IdToken);
            Assert.Equal("456", tokenResponse.RefreshToken);
            Assert.Equal("789", tokenResponse.Scope);
            Assert.Equal(1000, tokenResponse.ExpiresInSeconds);
        }

        // Test data for testing TokenResponse expiry.
        // Although we could use InlineData for some of these, we would
        // have to have a separate test for the newly construted test case.
        public static IEnumerable<object[]> ExpiresData
        {
            get
            {
                // IsExpired will be true 6 minutes before actual expiry.
                // IsEffectivelyExpired will be true 5 minutes before actual expiry.

                DateTime issued = DateTime.UtcNow;
                // Now is ten minutes after issuance.
                DateTime now = DateTime.UtcNow.AddSeconds(60 * 10);
                // If it expires 20 minutes after issuance,
                // it's not expired now.
                long isNotExpiredSeconds = 60 * 20;
                // If it expires 16 minutes after issuance,
                // it's soft expired now, but not hard expired.
                long isSoftExpiredSeconds = 60 * 16;
                // If it expires 15 minutes after issuance,
                // it's expired now.
                long isHardExpiredSeconds = 60 * 15;

                // As newly constructed.
                yield return new object[] { now, DateTime.MinValue.ToUniversalTime(), null, null, null, true, true };
                // Expiry not set.
                yield return new object[] { now, issued, null, "access", "id", true, true };
                // Neither AccessToken nor IdToken set.
                yield return new object[] { now, issued, isNotExpiredSeconds, null, null, true, true };
                // AccessToken set.
                yield return new object[] { now, issued, isNotExpiredSeconds, "access", null, false, false };
                // IdToken set.
                yield return new object[] { now, issued, isNotExpiredSeconds, null, "id", false, false };
                // Both AccessToken and IdToken set.
                yield return new object[] { now, issued, isNotExpiredSeconds, "access", "id", false, false };
                // Soft expired.
                yield return new object[] { now, issued, isSoftExpiredSeconds, "access", "id", true, false };
                // Soft expired boundary.
                yield return new object[] { now, issued, isSoftExpiredSeconds + 1, "access", "id", false, false };
                // Hard expired.
                yield return new object[] { now, issued, isHardExpiredSeconds, "access", "id", true, true };
                // Hard expired boundary.
                yield return new object[] { now, issued, isHardExpiredSeconds + 1, "access", "id", true, false };
            }
        }

        [Theory]
        [MemberData(nameof(ExpiresData))]
        public void Expiry(
            DateTime now, DateTime issuedAt, long? expiresInSeconds,
            string accessToken, string idToken,
            bool expectedExpired, bool expectedEffectiveExpires)
        {
            var clock = new MockClock { UtcNow = now };
            var token = new TokenResponse
            {
                IssuedUtc = issuedAt,
                ExpiresInSeconds = expiresInSeconds,
                AccessToken = accessToken,
                IdToken = idToken
            };
            Assert.Equal(expectedExpired, token.IsExpired(clock));
            Assert.Equal(expectedEffectiveExpires, token.IsEffectivelyExpired(clock));
        }

        [Fact]
        public async Task FromResponse_TokenResponse()
        {
            TokenResponse sentToken = new TokenResponse
            {
                IdToken = "IdToken",
                AccessToken = "AccessToken",
                RefreshToken = "RefreshToken",
                Scope = "Scope",
                TokenType = "TokenType",
                ExpiresInSeconds = 100,
                // It really doesn't matter, we always set it to now when the token is received
                // because that's the recommendation.
                IssuedUtc = new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Utc),
            };
            var serializedToken = NewtonsoftJsonSerializer.Instance.Serialize(sentToken);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(serializedToken)
            };

            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 02, 02, 2, 20, 20, DateTimeKind.Utc) };
            TokenResponse token = await TokenResponse.FromHttpResponseAsync(response, clock, new NullLogger());

            Assert.Equal("IdToken", token.IdToken);
            Assert.Equal("AccessToken", token.AccessToken);
            Assert.Equal("RefreshToken", token.RefreshToken);
            Assert.Equal("Scope", token.Scope);
            Assert.Equal("TokenType", token.TokenType);
            Assert.Equal(100, token.ExpiresInSeconds);
            // The date should be our mock now, not the one set on the sent token.
            Assert.Equal(new DateTime(2020, 02, 02, 2, 20, 20, DateTimeKind.Utc), token.IssuedUtc);
        }

        [Fact]
        public async Task FromResponse_RawIdToken()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(OidcComputeSuccessMessageHandler.FirstCallToken),
                RequestMessage = new HttpRequestMessage(HttpMethod.Get, GoogleAuthConsts.ComputeOidcTokenUrl)
            };

            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 02, 02, 2, 20, 20, DateTimeKind.Utc) };
            TokenResponse token = await TokenResponse.FromHttpResponseAsync(response, clock, new NullLogger());

            Assert.Equal(OidcComputeSuccessMessageHandler.FirstCallToken, token.IdToken);
            Assert.Equal(OidcComputeSuccessMessageHandler.FirstCallToken, token.AccessToken);
            Assert.Null(token.RefreshToken);
            Assert.Null(token.Scope);
            Assert.Null(token.TokenType);
            Assert.NotNull(token.ExpiresInSeconds);
            // The date should be our mock now, not the one set on the sent token.
            Assert.Equal(new DateTime(2020, 02, 02, 2, 20, 20, DateTimeKind.Utc), token.IssuedUtc);
        }

        public static IEnumerable<object[]> AccessAndIdTokenData
        {
            get
            {
                // None are set.
                yield return new object[] { null, null, null, null };
                // Both are set, none is overriden.
                yield return new object[] 
                { 
                    OidcTokenResponseSuccessMessageHandler.FirstCallToken,
                    "AccessToken",
                    OidcTokenResponseSuccessMessageHandler.FirstCallToken,
                    "AccessToken" };
                // Only AccessToken is set, IdToken is not overriden.
                yield return new object[] { null, "AccessToken", null, "AccessToken" };
                // Only IdToken is set, AccessToken is overriden.
                yield return new object[] 
                {
                    OidcTokenResponseSuccessMessageHandler.FirstCallToken,
                    null,
                    OidcTokenResponseSuccessMessageHandler.FirstCallToken,
                    OidcTokenResponseSuccessMessageHandler.FirstCallToken 
                };
            }
        }

        [Theory]
        [MemberData(nameof(AccessAndIdTokenData))]
        public async Task FromResponse_AccessAndIdTokens(string idToken, string accessToken, string expectedIdToken, string expectedAccessToken)
        {
            TokenResponse sentToken = new TokenResponse
            {
                IdToken = idToken,
                AccessToken = accessToken,
            };
            var serializedToken = NewtonsoftJsonSerializer.Instance.Serialize(sentToken);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(serializedToken)
            };

            var clock = new MockClock { UtcNow = new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc) };
            TokenResponse token = await TokenResponse.FromHttpResponseAsync(response, clock, new NullLogger());

            Assert.Equal(expectedIdToken, token.IdToken);
            Assert.Equal(expectedAccessToken, token.AccessToken);
        }

        [Fact]
        public async Task FromResponse_Expiry()
        {
            // For OIDC token endpoint, we only get and IdToken.
            // We get the expiry from there.
            TokenResponse sentToken = new TokenResponse
            {
                IdToken = OidcTokenResponseSuccessMessageHandler.FirstCallToken
            };
            var serializedToken = NewtonsoftJsonSerializer.Instance.Serialize(sentToken);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(serializedToken)
            };

            var clock = new MockClock { UtcNow = new DateTime(2020, 5, 13, 15, 0, 0, 0, DateTimeKind.Utc) };
            TokenResponse token = await TokenResponse.FromHttpResponseAsync(response, clock, new NullLogger());

            Assert.Equal(OidcTokenResponseSuccessMessageHandler.FirstCallToken, token.IdToken);
            Assert.NotNull(token.ExpiresInSeconds);
        }

        [Fact]
        public void DeserializeFromJustIssued()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'Issued': '2016-12-14T09:00:00+05'
                }");
            // The Issued value will depend on the local time zone; it may not be +5. But the UTC value
            // should be correct... unless it can't be due to a time zone transition, but there's
            // not a lot we can do about that.
            Assert.Equal(new DateTime(2016, 12, 14, 4, 0, 0, DateTimeKind.Utc), tokenResponse.IssuedUtc);
        }

        [Fact]
        public void DeserializeFromDifferentIssuedAndIssuedUtc()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'Issued': '2016-06-14T09:00:00+05',
                 'IssuedUtc': '2016-12-25T08:00:00Z'
                }");
            // Issued will be set first, then IssuedUtc - there's only one underlying field, so IssuedUtc wins.
            // That's the desirable behavior, as it's system-independent
            Assert.Equal(new DateTime(2016, 12, 25, 8, 0, 0, DateTimeKind.Utc), tokenResponse.IssuedUtc);
            // The Issued value will depend on the system local time zone, but it should be within this 3 day window.
            // Importantly, it's *not* June 14th - that value in the JSON is effectively irrelevant.
            // (It would be very odd for them to be out of sync anyway, admittedly.)
#pragma warning disable CS0618
            Assert.True(tokenResponse.Issued > new DateTime(2016, 12, 24, 0, 0, 0, DateTimeKind.Local));
            Assert.True(tokenResponse.Issued < new DateTime(2016, 12, 27, 0, 0, 0, DateTimeKind.Local));
#pragma warning restore CS0618
        }
    }
}
