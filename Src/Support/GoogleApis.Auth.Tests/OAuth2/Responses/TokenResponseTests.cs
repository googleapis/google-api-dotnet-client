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

using Google.Apis.Tests;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace Google.Apis.Auth.OAuth2.Responses
{
    /// <summary>
    /// Tests for <seealso cref="Google.Apis.Auth.OAuth2.Responses.TokenResponse"/>.
    /// </summary>
    [TestFixture]
    public class TokenResponseTests
    {
        [Test]
        public void TestConstructor()
        {
            var response = new TokenResponse();
            Assert.Null(response.AccessToken);
            Assert.Null(response.ExpiresInSeconds);
            Assert.Null(response.RefreshToken);
            Assert.Null(response.Scope);
            Assert.AreEqual(DateTime.MinValue, response.IssuedUtc);
        }

        [Test]
        public void TestSerializer()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'access_token': '123',
                 'expires_in': 1000,
                 'refresh_token': '456',
                 'scope': '789'
                }");
            Assert.That(tokenResponse.AccessToken, Is.EqualTo("123"));
            Assert.That(tokenResponse.RefreshToken, Is.EqualTo("456"));
            Assert.That(tokenResponse.Scope, Is.EqualTo("789"));
            Assert.That(tokenResponse.ExpiresInSeconds, Is.EqualTo(1000));
        }

        [Test]
        public void IsExpired()
        {
            var issued = DateTime.UtcNow;
            var newNow = DateTime.UtcNow.AddSeconds(100);

            var mockClock = new MockClock
            {
                UtcNow = newNow
            };

            // Issued not set.
            var response = new TokenResponse();
            Assert.True(response.IsExpired(mockClock));

            // ExpiresInSeconds is not set.
            response = new TokenResponse() { IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 1, IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100, IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100 + 5 * 60 - 2, IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100 + 5 * 60 - 1, IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100 + 5 * 60, IssuedUtc = issued };
            Assert.True(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100 + 5 * 60 + 1, IssuedUtc = issued };
            Assert.False(response.IsExpired(mockClock));

            response = new TokenResponse() { AccessToken = "a", ExpiresInSeconds = 100 + 5 * 60 + 2, IssuedUtc = issued };
            Assert.False(response.IsExpired(mockClock));
        }

        [Test]
        public void DeserializeFromJustIssued()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'Issued': '2016-12-14T09:00:00+05'
                }");
            // The Issued value will depend on the local time zone; it may not be +5. But the UTC value
            // should be correct... unless it can't be due to a time zone transition, but there's
            // not a lot we can do about that.
            Assert.AreEqual(new DateTime(2016, 12, 14, 4, 0, 0, DateTimeKind.Utc), tokenResponse.IssuedUtc);
        }

        [Test]
        public void DeserializeFromDifferentIssuedAndIssuedUtc()
        {
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(
                @"{
                 'Issued': '2016-06-14T09:00:00+05',
                 'IssuedUtc': '2016-12-25T08:00:00Z'
                }");
            // Issued will be set first, then IssuedUtc - there's only one underlying field, so IssuedUtc wins.
            // That's the desirable behavior, as it's system-independent
            Assert.AreEqual(new DateTime(2016, 12, 25, 8, 0, 0, DateTimeKind.Utc), tokenResponse.IssuedUtc);
            // The Issued value will depend on the system local time zone, but it should be within this 3 day window.
            // Importantly, it's *not* June 14th - that value in the JSON is effectively irrelevant.
            // (It would be very odd for them to be out of sync anyway, admittedly.)
#pragma warning disable CS0618
            Assert.Greater(tokenResponse.Issued, new DateTime(2016, 12, 24, 0, 0, 0, DateTimeKind.Local));
            Assert.Less(tokenResponse.Issued, new DateTime(2016, 12, 27, 0, 0, 0, DateTimeKind.Local));
#pragma warning restore CS0618
        }
    }
}
