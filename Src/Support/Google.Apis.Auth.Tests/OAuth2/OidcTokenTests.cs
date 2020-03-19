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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class OidcTokenTests
    {
        [Fact]
        public async Task FetchesAccessToken()
        {
            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) };

            TokenRefreshManager refreshManager = null;
            refreshManager = new TokenRefreshManager(RefreshTokenAsync, clock, new NullLogger());
            OidcToken token = new OidcToken(refreshManager);

            Assert.Equal("very_fake_access_token", await token.GetAccessTokenAsync(default));

            Task<bool> RefreshTokenAsync(CancellationToken cancellationToken)
            {
                TokenResponse tokenResponse = new TokenResponse
                {
                    AccessToken = "very_fake_access_token",
                    ExpiresInSeconds = (long)TimeSpan.FromHours(1).TotalSeconds,
                    IssuedUtc = clock.UtcNow
                };
                refreshManager.Token = tokenResponse;
                return Task.FromResult(true);
            }
        }

        [Fact]
        public async Task RefreshesAccessToken()
        {
            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) };

            TokenRefreshManager refreshManager = null;
            bool firstToken = true;
            refreshManager = new TokenRefreshManager(RefreshTokenAsync, clock, new NullLogger());
            OidcToken token = new OidcToken(refreshManager);

            Assert.Equal("very_fake_first_token", await token.GetAccessTokenAsync(default));
            // Move the clock over 1 hour so that the first token expires.
            clock.UtcNow = clock.UtcNow.AddHours(2);
            Assert.Equal("very_fake_second_token", await token.GetAccessTokenAsync(default));

            Task<bool> RefreshTokenAsync(CancellationToken cancellationToken)
            {
                string tokenData = firstToken ? "very_fake_first_token" : "very_fake_second_token";
                firstToken = false;

                TokenResponse tokenResponse = new TokenResponse
                {
                    AccessToken = tokenData,
                    ExpiresInSeconds = (long)TimeSpan.FromHours(1).TotalSeconds,
                    IssuedUtc = clock.UtcNow
                };
                refreshManager.Token = tokenResponse;
                return Task.FromResult(true);
            }
        }

        [Fact]
        public async Task FetchTokenFails()
        {
            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) };

            TokenRefreshManager refreshManager = new TokenRefreshManager(ct => Task.FromResult(false), clock, new NullLogger());
            OidcToken token = new OidcToken(refreshManager);

            await Assert.ThrowsAsync<InvalidOperationException>(() => token.GetAccessTokenAsync(default));
        }

        [Fact]
        public async Task RefreshTokenFails()
        {
            MockClock clock = new MockClock { UtcNow = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) };

            TokenRefreshManager refreshManager = null;
            bool firstToken = true;
            refreshManager = new TokenRefreshManager(RefreshTokenAsync, clock, new NullLogger());
            OidcToken token = new OidcToken(refreshManager);

            Assert.Equal("very_fake_first_token", await token.GetAccessTokenAsync(default));
            // Move the clock over 1 hour so that the first token expires.
            clock.UtcNow = clock.UtcNow.AddHours(2);
            await Assert.ThrowsAsync<InvalidOperationException>(() => token.GetAccessTokenAsync(default));

            Task<bool> RefreshTokenAsync(CancellationToken cancellationToken)
            {
                if (firstToken)
                {
                    firstToken = false;
                    TokenResponse tokenResponse = new TokenResponse
                    {
                        AccessToken = "very_fake_first_token",
                        ExpiresInSeconds = (long)TimeSpan.FromHours(1).TotalSeconds,
                        IssuedUtc = clock.UtcNow
                    };
                    refreshManager.Token = tokenResponse;
                    return Task.FromResult(true);
                }
                return Task.FromResult(false);
            }
        }
    }
}
