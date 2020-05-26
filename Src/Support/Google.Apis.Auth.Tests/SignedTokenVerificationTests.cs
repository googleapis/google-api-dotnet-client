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
using Google.Apis.Tests.Mocks;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests
{
    public class SignedTokenVerificationTests
    {
        [Fact]
        public async Task CertificateCache_Caches()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);

            // The fake only fakes the fetching of the certificates from the web.
            // The rest of the code can't be mocked and that's what we are testing here.
            var certCache = new FakeCertificateCache(clock);

            var firstCall = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);
            // Move the clock a little, but not enough to invalidate the cache, which lasts for 1 hour.
            clock.UtcNow = clock.UtcNow.AddMinutes(30);
            var secondCallCached = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);

            Assert.NotNull(firstCall);
            Assert.Same(firstCall, secondCallCached);
        }

        [Fact]
        public async Task CertificateCache_Refreshes()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            // The fake only fakes the fetching of the certificates from the web.
            // The rest of the code can't be mocked and that's what we are testing here.
            var certCache = new FakeCertificateCache(clock);

            var firstCall = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);
            // Move the clock so the cache expires
            clock.UtcNow = clock.UtcNow.AddMinutes(61);
            var secondCall = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);

            Assert.NotNull(firstCall);
            Assert.NotNull(secondCall);
            Assert.NotSame(firstCall, secondCall);
        }

        [Fact]
        public async Task CertificateCache_ForceRefresh()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            // The fake only fakes the fetching of the certificates from the web.
            // The rest of the code can't be mocked and that's what we are testing here.
            var certCache = new FakeCertificateCache(clock);

            var firstCall = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), false, default);
            // Move the clock some so that the cache doesn't expire.
            clock.UtcNow = clock.UtcNow.AddMinutes(30);
            var secondCall = await certCache.GetCertificatesAsync(GoogleAuthConsts.JsonWebKeySetUrl, json => RSA.Create(), true, default);

            Assert.NotNull(firstCall);
            Assert.NotNull(secondCall);
            // Still they are different because we forced refreshed the cache.
            Assert.NotSame(firstCall, secondCall);
        }
    }
}
