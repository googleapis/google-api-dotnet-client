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

#if NETCOREAPP2_0 || NET452 || NET46 || NET461
#define ES256_SUPPORTED
#elif !NETCOREAPP1_0 && !NETCOREAPP1_1
#error Unsupported platform
#endif

using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.TokenEncodingHelpers;

namespace Google.Apis.Auth.Tests
{
    public class JsonWebSignatureTests
    {
        private SignedTokenVerificationOptions BuildOptions(
            IClock clock = null, string[] trustedIssuers = null, string[] trustedAudiences = null, TimeSpan? clockTolerance = null)
        {
            var options = new SignedTokenVerificationOptions
            {
                CertificateCache = new FakeCertificateCache(),
                Clock = clock ?? new MockClock(FakeCertificateCache.ValidJwtGoogleSigned)
            };
            foreach (var issuer in trustedIssuers ?? Enumerable.Empty<string>())
            {
                options.TrustedIssuers.Add(issuer);
            }
            foreach (var audience in trustedAudiences ?? Enumerable.Empty<string>())
            {
                options.TrustedAudiences.Add(audience);
            }
            if (clockTolerance.HasValue)
            {
                options.IssuedAtClockTolerance = clockTolerance.Value;
                options.ExpiryClockTolerance = clockTolerance.Value;
            }

            return options;
        }

        [Fact]
        public async Task NullToken() =>
            await Assert.ThrowsAsync<ArgumentNullException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(null, BuildOptions()));

        [Fact]
        public async Task EmptyToken() =>
            await Assert.ThrowsAsync<ArgumentException>(() =>
                JsonWebSignature.VerifySignedTokenAsync("", BuildOptions()));

        [Fact]
        public async Task TwoPartToken() =>
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync("header.payload", BuildOptions()));

        [Fact]
        public async Task WrongAlgorithm()
        {
            string jwt = $"{UrlSafeBase64Encode("{\"alg\":\"HS256\"}")}.{UrlSafeBase64Encode("{}")}.";
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(jwt, BuildOptions()));
            Assert.Equal("Signing algorithm must be either RS256 or ES256.", ex.Message);
        }

        [Fact]
        public async Task ValidRS256Signature() =>
            Assert.NotNull(await JsonWebSignature.VerifySignedTokenAsync(
                FakeCertificateCache.JwtGoogleSigned, BuildOptions()));

        [Fact]
        public async Task ValidRS256Signature_CustomPayload()
        {
            var payload = await JsonWebSignature.VerifySignedTokenAsync<CustomPayload>(FakeCertificateCache.JwtGoogleSigned, BuildOptions());
            Assert.NotNull(payload);
            Assert.NotNull(payload.AuthorizedParty);
            Assert.NotEmpty(payload.AuthorizedParty);
        }

        private class CustomPayload : JsonWebSignature.Payload
        {
            [JsonProperty("azp")]
            public string AuthorizedParty { get; set; }
        }

#if ES256_SUPPORTED
        [Fact]
        public async Task ValidES256Signature() =>
            Assert.NotNull(await JsonWebSignature.VerifySignedTokenAsync(
                FakeCertificateCache.Es256ForIap, BuildOptions(new MockClock(FakeCertificateCache.ValidEs256ForIap))));
#else
        [Fact]
        public async Task ValidES256Signature_Unsupported()
        {
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => JsonWebSignature.VerifySignedTokenAsync(
                FakeCertificateCache.Es256ForIap, BuildOptions(new MockClock(FakeCertificateCache.ValidEs256ForIap))));
            Assert.Equal("ES256 signed token verification is not supported in this platform.", ex.Message);
        }
#endif


        [Fact]
        public async Task InvalidRS256Signature()
        {
            // Lets just change the last character of the Google signed token to break the signature.
            // But Headers and Payload are still valid for a Google token so we guarantee that the only
            // failure comes from the signature being invalid.
            // The last character was a Q, changing for a 4. If at some point the token used in tests changes
            // and the new token ends in anything but a 4, this test will still be valid. If the new token ends in a 4
            // this test will fail and then we'll have to replace the 4 by a Q or any other character.
            var invalidToken = FakeCertificateCache.JwtGoogleSigned.Substring(0, FakeCertificateCache.JwtGoogleSigned.Length - 1) + "4";
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(invalidToken, BuildOptions()));
            Assert.Equal("JWT invalid, unable to verify signature.", ex.Message);
        }

#if ES256_SUPPORTED
        [Fact]
        public async Task InvalidES256Signature()
        {
            // Lets just change the last character of the signed token to break the signature.
            // But Headers and Payload are still valid so we guarantee that the only
            // failure comes from the signature being invalid.
            // The last character was an A, changing for a 4. If at some point the token used in tests changes
            // and the new token ends in anything but a 4, this test will still be valid. If the new token ends in a 4
            // this test will fail and then we'll have to replace the 4 by an A or any other character.
            var invalidToken = FakeCertificateCache.Es256ForIap.Substring(0, FakeCertificateCache.Es256ForIap.Length - 1) + "4";
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(invalidToken, BuildOptions(new MockClock(FakeCertificateCache.ValidEs256ForIap))));
            Assert.Equal("JWT invalid, unable to verify signature.", ex.Message);
        }
#else
        [Fact]
        public async Task InvalidES256Signature_Unsupported()
        {
            // Lets just change the last character of the signed token to break the signature.
            // But Headers and Payload are still valid so we guarantee that the only
            // failure comes from the signature being invalid.
            // The last character was an A, changing for a 4. If at some point the token used in tests changes
            // and the new token ends in anything but a 4, this test will still be valid. If the new token ends in a 4
            // this test will fail and then we'll have to replace the 4 by an A or any other character.
            var invalidToken = FakeCertificateCache.Es256ForIap.Substring(0, FakeCertificateCache.Es256ForIap.Length - 1) + "4";
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(invalidToken, BuildOptions(new MockClock(FakeCertificateCache.ValidEs256ForIap))));
            Assert.Equal("ES256 signed token verification is not supported in this platform.", ex.Message);
        }
#endif

        [Fact]
        public async Task InvalidIssuer()
        {
            var options = BuildOptions(trustedIssuers: new string[] { "issuer1", "issuer2" });
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, options));
            Assert.Equal("JWT issuer incorrect. Must be one of: 'issuer1', 'issuer2'", ex.Message);
        }

        [Fact]
        public async Task InvalidAudience()
        {
            var options = BuildOptions(trustedAudiences: new string[] { "audience1", "audience2" });
            var ex = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, options));
            Assert.Equal("JWT contains untrusted 'aud' claim.", ex.Message);
        }

        [Fact]
        public async Task ValidAudience()
        {
            var options = BuildOptions(trustedAudiences: new string[] { "233772281425-ab2mcbiqmv8kh0mdnqsrkrod97qk37h0.apps.googleusercontent.com" });
            var payload = await JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, options);
            Assert.NotNull(payload);
        }

        [Fact]
        public async Task Validate_Signature_Time()
        {
            var clockInvalid1 = new MockClock(FakeCertificateCache.BeforeValidJwtGoogleSigned);
            var clockValid1 = new MockClock(FakeCertificateCache.ValidJwtGoogleSigned);
            var clockInvalid2 = new MockClock(FakeCertificateCache.AfterValidJwtGoogleSigned);

            // Test with no tolerance
            Assert.NotNull(await JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockValid1)));

            var ex1 = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid1)));
            Assert.Equal("JWT is not yet valid.", ex1.Message);

            var ex2 = await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid2)));
            Assert.Equal("JWT has expired.", ex2.Message);

            // Test with tolerance
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid1, clockTolerance: TimeSpan.FromSeconds(109))));
            Assert.NotNull(await JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid1, clockTolerance: TimeSpan.FromSeconds(111))));
            Assert.NotNull(await JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid2, clockTolerance: TimeSpan.FromSeconds(11))));
            await Assert.ThrowsAsync<InvalidJwtException>(() =>
                JsonWebSignature.VerifySignedTokenAsync(FakeCertificateCache.JwtGoogleSigned, BuildOptions(clockInvalid2, clockTolerance: TimeSpan.FromSeconds(9))));
        }
    }
}
