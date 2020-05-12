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
using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.SignedTokenVerification;
using static Google.Apis.Auth.TokenEncodingHelpers;

namespace Google.Apis.Auth.Tests
{
    public class GoogleJsonWebSignatureTests
    {
        private GoogleJsonWebSignature.ValidationSettings MakeSettings(
            IClock clock,
            string aud = null,
            string hd = null,
            double clockToleranceSeconds = 0.0,
            CertificateCacheBase certificateCache = null) =>
            new GoogleJsonWebSignature.ValidationSettings
            {
                Clock = clock,
                Audience = aud == null ? null : new[] { aud },
                HostedDomain = hd,
                IssuedAtClockTolerance = TimeSpan.FromSeconds(clockToleranceSeconds),
                ExpirationTimeClockTolerance = TimeSpan.FromSeconds(clockToleranceSeconds),
                CertificateCache = certificateCache ?? new FakeCertificateCache()
            };

        [Fact]
        public void ValidationSettingsToSignedTokenVerificationOptions()
        {
            MockClock clock = new MockClock();
            FakeCertificateCache cache = new FakeCertificateCache();
            var options = new GoogleJsonWebSignature.ValidationSettings
            {
                Clock = clock,
                Audience = new[] { "audience" },
                HostedDomain = "hosted_domain",
                IssuedAtClockTolerance = TimeSpan.FromSeconds(5),
                ExpirationTimeClockTolerance = TimeSpan.FromSeconds(10),
                CertificateCache = cache,
                ForceGoogleCertRefresh = true
            }.ToVerificationOptions();

            Assert.Same(clock, options.Clock);
            Assert.Single(options.TrustedAudiences, "audience");
            Assert.Equal(TimeSpan.FromSeconds(5), options.IssuedAtClockTolerance);
            Assert.Equal(TimeSpan.FromSeconds(10), options.ExpiryClockTolerance);
            Assert.Same(cache, options.CertificateCache);
            Assert.True(options.ForceCertificateRefresh);
            Assert.Equal(GoogleAuthConsts.JsonWebKeySetUrl, options.CertificatesUrl);
            Assert.Equal(GoogleJsonWebSignature.ValidJwtIssuers.Count(), options.TrustedIssuers.Count);
        }

        [Fact]
        public async Task Validate_BadJwt()
        {
            // The date is irrelevant here since we are not passing any actual valid token for verification.
            // In any case we are using a fixed date (any fixed date would do) so that the test always runs the same.
            var settings = MakeSettings(new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned});
            // Null JWT
            await Assert.ThrowsAsync<ArgumentNullException>(() => GoogleJsonWebSignature.ValidateInternalAsync(null, settings));
            // Empty JWT
            await Assert.ThrowsAsync<ArgumentException>(() => GoogleJsonWebSignature.ValidateInternalAsync("", settings));
            // Too long JWT
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(new string('a', GoogleJsonWebSignature.MaxJwtLength + 1), settings));
            // JWT with incorrect top-level structure; missing signature
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync("header.payload", settings));
        }

        [Fact]
        public async Task WrongAlgorithm()
        {
            var settings = MakeSettings(new MockClock() { UtcNow = DateTime.UtcNow });
            string jwt = $"{UrlSafeBase64Encode("{\"alg\":\"HS256\"}")}.{UrlSafeBase64Encode("{}")}.";
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(jwt, settings));
            Assert.Equal("JWT algorithm must be 'RS256'", ex.Message);
        }

        [Fact]
        public async Task ValidateInternalAsync_Valid()
        {
            var clockValid = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned };
            Assert.NotNull(await GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockValid)));
        }

        [Fact]
        public async Task ValidateInternalAsync_Invalid()
        {
            var clockValid = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned };
            // Lets just change the last character of the Google signed token to break the signature.
            // But Headers and Payload are still valid for a Google token so we guarantee that the only
            // failure comes from the signature being invalid.
            // The last character was a Q, changing for a 4. If at some point the token used in tests changes
            // and the new token ends in anything but a 4, this test will still be valid. If the new token ends in a 4
            // this test will fail and then we'll have to replace the 4 by a Q or any other character.
            var invalidToken = FakeCertificateCache.JwtGoogleSigned.Substring(0, FakeCertificateCache.JwtGoogleSigned.Length - 1) + "4";
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(invalidToken, MakeSettings(clockValid)));
            Assert.Equal("JWT invalid, unable to verify signature.", ex.Message);
        }

        [Fact]
        public async Task Invalid_Iss()
        {
            var clock = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtNonGoogleSigned };
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtNonGoogleSigned, MakeSettings(clock)));
            Assert.Equal("JWT issuer incorrect. Must be one of: 'https://accounts.google.com', 'accounts.google.com'", ex.Message);
        }

        [Fact]
        public async Task Invalid_Aud()
        {
            var clock = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned };
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clock, "bad_aud")));
            Assert.Equal("JWT contains untrusted 'aud' claim.", ex.Message);
        }

        [Fact]
        public async Task Validate_Signature_Time()
        {
            var clockInvalid1 = new MockClock() { UtcNow = FakeCertificateCache.BeforeValidJwtGoogleSigned };
            var clockValid1 = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned };
            var clockInvalid2 = new MockClock() { UtcNow = FakeCertificateCache.AfterValidJwtGoogleSigned };

            // Test with no tolerance
            Assert.NotNull(await GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockValid1)));

            var ex1 = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid1)));
            Assert.Equal("JWT is not yet valid.", ex1.Message);

            var ex2 = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid2)));
            Assert.Equal("JWT has expired.", ex2.Message);

            // Test with tolerance
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid1, clockToleranceSeconds: 109)));
            Assert.NotNull(await GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid1, clockToleranceSeconds: 111)));
            Assert.NotNull(await GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid2, clockToleranceSeconds: 11)));
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clockInvalid2, clockToleranceSeconds: 9)));
        }

        [Fact]
        public async Task Invalid_HostedDomain()
        {
            var clock = new MockClock() { UtcNow = FakeCertificateCache.ValidJwtGoogleSigned };
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                GoogleJsonWebSignature.ValidateInternalAsync(FakeCertificateCache.JwtGoogleSigned, MakeSettings(clock, hd: "hd")));
            Assert.Equal("JWT contains invalid 'hd' claim.", ex.Message);
        }
    }
}
