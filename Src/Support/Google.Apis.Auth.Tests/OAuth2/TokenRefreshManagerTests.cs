/*
Copyright 2018 Google LLC

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
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class TokenRefreshManagerTests
    {
        public int TokenResponseMan { get; private set; }

        [Theory, CombinatorialData]
        public async Task SingleTokenConcurrentRefresh(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where all refreshes return the same token.
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshFnCount = 0;
            TaskCompletionSource<int> delayTask = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await delayTask.Task;
                trm.Token = new TokenResponse
                {
                    AccessToken = "AccessToken1",
                    ExpiresInSeconds = TokenResponse.TokenRefreshTimeWindowSeconds * 2 + 1,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return true;
            }, clock, logger);

            for (int iteration = 0; iteration < 3; iteration++)
            {
                delayTask = new TaskCompletionSource<int>();
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                delayTask.SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                foreach (var token in tokens)
                {
                    Assert.Equal("AccessToken1", token);
                }

                clock.UtcNow += TimeSpan.FromMinutes(1);
            }
            Assert.Equal(1, refreshFnCount);
        }

        [Theory, CombinatorialData]
        public async Task MultipleHardExpiredTokensConcurrentRefreshes(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where the sequential refreshes are after the previous token has completely expired.
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshFnCount = 0;
            TaskCompletionSource<int> delayTask = null;
            string accessToken = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await delayTask.Task;
                trm.Token = new TokenResponse
                {
                    AccessToken = Interlocked.Exchange(ref accessToken, accessToken),
                    ExpiresInSeconds = TokenResponse.TokenRefreshTimeWindowSeconds + 1,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return true;
            }, clock, logger);

            for (int iteration = 0; iteration < 5; iteration++)
            {
                delayTask = new TaskCompletionSource<int>();
                Interlocked.Exchange(ref accessToken, $"AccessToken{iteration}");
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                delayTask.SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                foreach (var token in tokens)
                {
                    Assert.Equal(accessToken, token);
                }

                clock.UtcNow += TimeSpan.FromHours(24);
            }
            Assert.Equal(5, Interlocked.Add(ref refreshFnCount, 0));
        }

        [Theory, CombinatorialData]
        public async Task MultipleSoftExpiredTokensConcurrentRefreshes(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount,
            [CombinatorialValues(3, 5, 10)] int refreshIterations)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where the sequential refreshes are after the previous token has completely expired.
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            TaskCompletionSource<int> delayTask = null;
            string accessToken = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await delayTask.Task;
                trm.Token = new TokenResponse
                {
                    AccessToken = Interlocked.Exchange(ref accessToken, accessToken),
                    ExpiresInSeconds = TokenResponse.TokenRefreshTimeWindowSeconds + 1,
                    IssuedUtc = clock.UtcNow
                };
                return true;
            }, clock, logger);

            for (int iteration = 0; iteration < refreshIterations; iteration++)
            {
                delayTask = new TaskCompletionSource<int>();
                Interlocked.Exchange(ref accessToken, $"AccessToken{iteration}");
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                delayTask.SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                // It's non-deterministic if the refresh will return the previous or just-retrieved token
                var expectedAccessTokenA = $"AccessToken{iteration}";
                var expectedAccessTokenB = $"AccessToken{iteration - 1}";
                foreach (var token in tokens)
                {
                    Assert.True(token == expectedAccessTokenA || token == expectedAccessTokenB);
                }

                clock.UtcNow += TimeSpan.FromSeconds(TokenResponse.TokenRefreshTimeWindowSeconds - TokenResponse.TokenHardExpiryTimeWindowSeconds);
            }
        }

        [Fact]
        public async Task ExpiredToken()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshFnCount = 0;
            string accessToken = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                trm.Token = new TokenResponse
                {
                    AccessToken = accessToken,
                    ExpiresInSeconds = 60 * 60,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return Task.FromResult(true);
            }, clock, logger);

            accessToken = "AccessToken1";
            var accessToken1 = await trm.GetAccessTokenForRequestAsync(CancellationToken.None);
            clock.UtcNow += TimeSpan.FromHours(24);
            accessToken = "AccessToken2";
            var accessToken2 = await trm.GetAccessTokenForRequestAsync(CancellationToken.None);

            Assert.Equal(2, Interlocked.Add(ref refreshFnCount, 0));
            Assert.Equal("AccessToken1", accessToken1);
            Assert.Equal("AccessToken2", accessToken2);
        }

        [Fact]
        public async Task CancelDuringRefresh()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshCalled = 0;
            int refreshCompleted = 0;
            var refreshCts = new CancellationTokenSource();
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCalled);
                await Task.Delay(TimeSpan.FromSeconds(60), refreshCts.Token);
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return false;
            }, clock, logger);

            var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(10));
            await Assert.ThrowsAsync<TaskCanceledException>(() => trm.GetAccessTokenForRequestAsync(cts.Token));
            refreshCts.Cancel();
            
            // Non-deterministic if the refresh function gets called by the time this test ends.
            // And it's either be called never, or retried n times by the token refresh manager.
            Assert.InRange(Interlocked.Add(ref refreshCalled, 0), 0, TokenRefreshManager.RefreshTimeouts.Length);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesTimeout_Sync()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                Assert.True(ct.CanBeCanceled);
                new CancellationToken(true).ThrowIfCancellationRequested();
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return Task.FromResult(false);
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("timeout, timeout, timeout", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesTimeout_Async()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                Assert.True(ct.CanBeCanceled);
                var token = new CancellationTokenSource(TimeSpan.FromMilliseconds(10)).Token;
                await Task.Delay(TimeSpan.FromSeconds(10), token);
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return false;
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("timeout, timeout, timeout", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesError_Sync()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                return Task.FromResult(false);
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("refresh error, refresh error, refresh error", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesError_Async()
        {
            var clock = new MockClock { UtcNow = new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc) };
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                await Task.Yield();
                return false;
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("refresh error, refresh error, refresh error", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }
    }
}
