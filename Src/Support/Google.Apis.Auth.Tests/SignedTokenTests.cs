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

using Newtonsoft.Json;
using System;
using Xunit;

namespace Google.Apis.Auth.Tests
{
    public class SignedTokenTests
    {
        [Fact]
        public void FromGoogleSigned()
        {
            var signedToken = SignedToken<GoogleJsonWebSignature.Header, GoogleJsonWebSignature.Payload>.FromSignedToken(FakeCertificateCache.JwtGoogleSigned);
            // Just a small test that everything got correctly unpacked.
            Assert.Contains("google.com", signedToken.Payload.Issuer);
            // And that we have some Google specific info on the payload.
            Assert.NotNull(signedToken.Payload.HostedDomain);
        }

        [Fact]
        public void FromNonGoogleSigned()
        {
            var signedToken = SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(FakeCertificateCache.JwtNonGoogleSigned);
            // Just a small test that everything got correctly unpacked.
            Assert.DoesNotContain("google.com", signedToken.Payload.Issuer);
        }

        [Fact]
        public void FromGoogleSigned_ToJsonWebSignatureTypes()
        {
            // This works, we just don't get the specific fields that we can get with
            // GoogleJsonWebSignature.Header and GoogleJsonWebSignature.Payload.
            var signedToken = SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(FakeCertificateCache.JwtGoogleSigned);
            // Just a small test that everything got correctly unpacked.
            Assert.Contains("google.com", signedToken.Payload.Issuer);
        }

        [Fact]
        public void FromNonGoogleSigned_ToGoogleJsonWebSignatureTypes()
        {
            // This works, because JSON deserialization will just leave unassigned
            // any of the Google specific fields since they are not present on the JSON.
            // Validation of this token as a Google signed token won't work though.
            var signedToken = SignedToken<GoogleJsonWebSignature.Header, GoogleJsonWebSignature.Payload>.FromSignedToken(FakeCertificateCache.JwtNonGoogleSigned);
            // Just a small test that everything got correctly unpacked.
            Assert.DoesNotContain("google.com", signedToken.Payload.Issuer);
            // But we don't have info for any of the specific Google fields.
            Assert.Null(signedToken.Payload.Scope);
            Assert.Null(signedToken.Payload.Prn);
            Assert.Null(signedToken.Payload.HostedDomain);
            Assert.Null(signedToken.Payload.Email);
            Assert.Null(signedToken.Payload.Name);
            Assert.Null(signedToken.Payload.GivenName);
            Assert.Null(signedToken.Payload.FamilyName);
            Assert.Null(signedToken.Payload.Picture);
            Assert.Null(signedToken.Payload.Locale);
        }

        [Fact]
        public void FromSignedToken_ThrowsIfNull()
        {
            Assert.Throws<ArgumentNullException>(
                () => SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(null));
        }

        [Fact]
        public void FromSignedToken_ThrowsIfEmpty()
        {
            Assert.Throws<ArgumentException>(
                () => SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(string.Empty));
        }

        [Theory]
        [InlineData("header.payload")]
        [InlineData("header.payload.signature.somethingelse")]
        public void FromSignedToken_ThrowsIfIncorrectPartCount(string jwt)
        {
            Assert.Throws<InvalidJwtException>(
                () => SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(jwt));
        }

        [Fact]
        public void FromSignedToken_ThrowsIfNotBase64()
        {
            Assert.Throws<FormatException>(
                () => SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(
                    "not_base64_header.not_base64_serialized_payload.signature"));
        }

        [Fact]
        public void FromSignedToken_ThrowsIfNotValidJson()
        {
            Assert.Throws<JsonReaderException>(
                () => SignedToken<JsonWebSignature.Header, JsonWebSignature.Payload>.FromSignedToken(
                    "YmFzZV82NF9oZWFkZXJfbm9fanNvbg==.YmFzZV82NF9wYXlsb2FkX25vX2pzb24=.c2lnbmF0dXJl"));
        }
    }
}
