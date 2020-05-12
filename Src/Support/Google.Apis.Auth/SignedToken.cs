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

using Google.Apis.Json;
using Google.Apis.Util;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Google.Apis.Auth
{
    // Note: The code here would have probably made more sense in JsonWebSignatura
    // and GoogleJsonWebSignature, but those classes are effectively static classes,
    // they only define specific payload and header types and have a few static helper
    // methods, but yet, they are not marked as static, or sealed, and are public.
    // And although the payload and header classes defined in GoogleJsonWebSignature do
    // inherit from the ones defined in JsonWebSignature, GoogleJsonWebSignature itseld does not
    // inherit from JsonWebSignature, which would be desirable for verification.
    /// <summary>
    /// Represents a signed token, could be a <see cref="JsonWebSignature"/> or
    /// a <see cref="GoogleJsonWebSignature"/> but this not only holds the payload
    /// and headers, but also the signature itself. It's meant to help with signed
    /// token verification and with obtaining token information.
    /// </summary>
    internal class SignedToken<TJwsHeader, TJwsPayload>
        where TJwsHeader : JsonWebSignature.Header
        where TJwsPayload : JsonWebSignature.Payload
    {
        private readonly Lazy<byte[]> _sha256;

        internal string EncodedHeader { get; }
        internal string EncodedPayload { get; }
        internal TJwsHeader Header { get; }
        internal TJwsPayload Payload { get; }
        internal byte[] Signature { get; }
        internal byte[] Sha256Hash => _sha256.Value;

        private SignedToken(string encodedHeader, string encodedPayload, TJwsHeader header, TJwsPayload payload, byte[] signature)
        {
            EncodedHeader = encodedHeader.ThrowIfNullOrEmpty(nameof(encodedHeader));
            EncodedPayload = encodedPayload.ThrowIfNullOrEmpty(nameof(encodedPayload));
            Header = header.ThrowIfNull(nameof(header));
            Payload = payload.ThrowIfNull(nameof(payload));
            Signature = signature;
            _sha256 = new Lazy<byte[]>(InitSha256);
        }

        internal static SignedToken<TJwsHeader, TJwsPayload> FromSignedToken(string signedToken)
        {
            // The first one throws ArgumentNullException and the second one ArgumenException.
            // Just calling ThrowIfNullOrEmpty would then be breaking, and there's actually a test
            // that breaks.
            signedToken.ThrowIfNull(nameof(signedToken));
            signedToken.ThrowIfNullOrEmpty(nameof(signedToken));

            var parts = signedToken.Split('.');
            if (parts.Length != 3)
            {
                throw new InvalidJwtException($"JWT must consist of Header, Payload, and Signature");
            }

            var encodedHeader = parts[0];
            var encodedPayload = parts[1];

            // Decode the three parts of the JWT: header.payload.signature
            var headerValue = NewtonsoftJsonSerializer.Instance.Deserialize<TJwsHeader>(TokenEncodingHelpers.Base64UrlToString(encodedHeader));
            var payloadValue = NewtonsoftJsonSerializer.Instance.Deserialize<TJwsPayload>(TokenEncodingHelpers.Base64UrlToString(encodedPayload));
            var signature = TokenEncodingHelpers.Base64UrlDecode(parts[2]);

            return new SignedToken<TJwsHeader, TJwsPayload>(encodedHeader, encodedPayload, headerValue, payloadValue, signature);
        }

        private byte[] InitSha256()
        {
            using var hashAlg = SHA256.Create();
            return hashAlg.ComputeHash(Encoding.ASCII.GetBytes($"{EncodedHeader}.{EncodedPayload}"));
        }
    }
}
