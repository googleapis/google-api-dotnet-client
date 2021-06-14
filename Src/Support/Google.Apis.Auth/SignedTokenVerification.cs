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

#if NETSTANDARD2_0 || NET45 || NET461
#define ES256_SUPPORTED
#elif !NETSTANDARD1_3
#error Unsupported Platform
#endif

using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Auth.JsonWebSignature;

namespace Google.Apis.Auth
{
    internal static class SignedTokenVerification
    {
#if NET45 || NET461
        // See http://oid-info.com/get/2.16.840.1.101.3.4.2.1
        private const string Sha256Oid = "2.16.840.1.101.3.4.2.1";
        // In net45 We don't have the handy ECParameters class so we need to pass the X and Y
        // in the expected format.
        // See here for the format of the key: https://docs.microsoft.com/en-us/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_ecckey_blob
        // And here for the correct prefix for ECDsa: https://stackoverflow.com/a/44527439/1122643
        private static readonly byte[] s_cngBlobPrefix = { 0x45, 0x43, 0x53, 0x31, 0x20, 0, 0, 0 };
#endif

        private static readonly CertificateCache s_certificateCache = new CertificateCache();

        internal async static Task VerifySignedTokenAsync<TJswHeader, TJswPayload>(
            SignedToken<TJswHeader, TJswPayload> signedToken, SignedTokenVerificationOptions options, CancellationToken cancellationToken)
            where TJswHeader : Header
            where TJswPayload : Payload
        {
            signedToken.ThrowIfNull(nameof(signedToken));
            options = options == null ? new SignedTokenVerificationOptions() : new SignedTokenVerificationOptions(options);
            options.CertificateCache ??= s_certificateCache;

            // Start the signature validation task...
            Task signatureVerificationTask = signedToken.Header.Algorithm switch
            {
                "RS256" => VerifyRS256TokenAsync(signedToken, options, cancellationToken),
#if ES256_SUPPORTED
                "ES256" => VerifyES256TokenAsync(signedToken, options, cancellationToken),
#else
                "ES256" => throw new InvalidOperationException("ES256 signed token verification is not supported in this platform."),
#endif
                _ => throw new InvalidJwtException("Signing algorithm must be either RS256 or ES256.")
            };

            // ... let's validate everything else while we wait for signature validation...

            // The signed token issuer should be one of the trusted issuers.
            if (options.TrustedIssuers.Count > 0 && !options.TrustedIssuers.Contains(signedToken.Payload.Issuer))
            {
                var validList = string.Join(", ", options.TrustedIssuers.Select(x => $"'{x}'"));
                throw new InvalidJwtException($"JWT issuer incorrect. Must be one of: {validList}");
            }
            // All audiences on the signed token should be trusted audiences.
            if (options.TrustedAudiences.Count > 0 && signedToken.Payload.AudienceAsList.Except(options.TrustedAudiences).Any())
            {
                throw new InvalidJwtException("JWT contains untrusted 'aud' claim.");
            }
            // Issued at and expiration are present. Save them for time related validity checks.
            DateTimeOffset issuedAt = signedToken.Payload.IssuedAt ?? throw new InvalidJwtException("JWT must contain 'iat' and 'exp' claims");
            DateTimeOffset expiresAt = signedToken.Payload.ExpiresAt ?? throw new InvalidJwtException("JWT must contain 'iat' and 'exp' claims");

            // Check that the token was issued in the past.
            var utcNow = options.Clock.UtcNow;
            if (utcNow + options.IssuedAtClockTolerance < issuedAt)
            {
                throw new InvalidJwtException("JWT is not yet valid.");
            }
            // Check that the token is not yet expired.
            if (utcNow - options.ExpiryClockTolerance > expiresAt)
            {
                throw new InvalidJwtException("JWT has expired.");
            }

            // ... and finally let's wait for signature validation to be done.
            await signatureVerificationTask.ConfigureAwait(false);
        }

        private async static Task VerifyRS256TokenAsync<TJswHeader, TJswPayload>(
            SignedToken<TJswHeader, TJswPayload> signedToken, SignedTokenVerificationOptions options, CancellationToken cancellationToken)
            where TJswHeader : Header
            where TJswPayload : Payload
        {
            var certificates = await GetCertificatesAsync(
                options, GoogleAuthConsts.JsonWebKeySetUrl, FromKeyToRsa, cancellationToken).ConfigureAwait(false);

            foreach (RSA certificate in certificates)
            {
#if NET45
                if (((RSACryptoServiceProvider)certificate).VerifyHash(signedToken.Sha256Hash, Sha256Oid, signedToken.Signature))
#elif NETSTANDARD1_3 || NETSTANDARD2_0 || NET461
                if (certificate.VerifyHash(signedToken.Sha256Hash, signedToken.Signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1))
#else
#error Unsupported platform
#endif
                {
                    return;
                }
            }
            throw new InvalidJwtException("JWT invalid, unable to verify signature.");

            static RSA FromKeyToRsa(JToken key)
            {
                var rsa = RSA.Create();
                rsa.ImportParameters(new RSAParameters
                {
                    Modulus = TokenEncodingHelpers.Base64UrlDecode((string)key["n"]),
                    Exponent = TokenEncodingHelpers.Base64UrlDecode((string)key["e"]),
                });
                return rsa;
            }
        }

#if ES256_SUPPORTED
        private async static Task VerifyES256TokenAsync<TJswHeader, TJswPayload>(
            SignedToken<TJswHeader, TJswPayload> signedToken, SignedTokenVerificationOptions options, CancellationToken cancellationToken)
            where TJswHeader : Header
            where TJswPayload : Payload
        {
            var certificates = await GetCertificatesAsync(
                options, GoogleAuthConsts.IapKeySetUrl, FromKeyToECDsa, cancellationToken).ConfigureAwait(false);

            foreach (ECDsa certificate in certificates)
            {
                if (certificate.VerifyHash(signedToken.Sha256Hash, signedToken.Signature))
                {
                    return;
                }
            }
            throw new InvalidJwtException("JWT invalid, unable to verify signature.");

            static ECDsa FromKeyToECDsa(JToken key)
            {
                if ((string)key["kty"] != "EC" && (string)key["crv"] != "P-256")
                {
                    throw new ArgumentException(
                        $"For ES256 verification only certificates with kty='EC' and crv='P-256' are supported. Encountered: kty={(string)key["kty"]} and crv={(string)key["crv"]}.");
                }
                byte[] x = TokenEncodingHelpers.Base64UrlDecode((string)key["x"]);
                byte[] y = TokenEncodingHelpers.Base64UrlDecode((string)key["y"]);
                return BuildEcdsa(x, y);
            }
#if NETSTANDARD2_0
            static ECDsa BuildEcdsa(byte[] x, byte[] y)
            {
                var ecdsa = ECDsa.Create();
                ecdsa.ImportParameters(new ECParameters
                {
                    // Curve used in ES256
                    Curve = ECCurve.NamedCurves.nistP256,
                    Q = new ECPoint { X = x, Y = y }
                });
                return ecdsa;
            }
#elif NET45 || NET461
            static ECDsa BuildEcdsa(byte[] x, byte[] y)
            {
                // In net45 We don't have the handy ECParameters class so we need to pass the X and Y
                // in the expected format.
                // See here for the format of the key: https://docs.microsoft.com/en-us/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_ecckey_blob
                // And here for the correct prefix for ECDsa: https://stackoverflow.com/a/44527439/1122643
                byte[] publicKey = new byte[s_cngBlobPrefix.Length + 64];
                Buffer.BlockCopy(s_cngBlobPrefix, 0, publicKey, 0, s_cngBlobPrefix.Length);
                Buffer.BlockCopy(x, 0, publicKey, s_cngBlobPrefix.Length, x.Length);
                Buffer.BlockCopy(y, 0, publicKey, s_cngBlobPrefix.Length + x.Length, y.Length);
                return new ECDsaCng(CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob));
            }
#endif
        }
#endif

        private static async Task<IEnumerable<AsymmetricAlgorithm>> GetCertificatesAsync(
            SignedTokenVerificationOptions options,
            string defaultCertificateLocation,
            Func<JToken, AsymmetricAlgorithm> certificateFactory,
            CancellationToken cancellationToken) =>
            await options.CertificateCache.GetCertificatesAsync(
                options.CertificatesUrl ?? defaultCertificateLocation,
                certificateFactory,
                options.ForceCertificateRefresh,
                cancellationToken).ConfigureAwait(false);

        // Abstract base class for testing purposes.
        internal abstract class CertificateCacheBase
        {
            internal static readonly TimeSpan DefaultCacheValidity = TimeSpan.FromHours(1);

            private readonly IDictionary<string, CachedCertificates> _cache = new Dictionary<string, CachedCertificates>();
            private readonly SemaphoreSlim _cacheLock = new SemaphoreSlim(1);
            // For testing purposes only.
            // Note that this won't match the clock sent in for each verification request.
            // The cache is global and the clock is specified on a per verification request basis,
            // and changing that would be breaking.
            // Therefor, in production code, we always use the system clock for calculating certificate
            // caching expiry because we cannot get the certificates at a specific point in time,
            // but just at the real now.
            // That is, certificate validity is relative to real time and not to faked time.
            // This clock is just for use in unit testing and have a deterministic way of making the
            // cache invalid.
            private readonly IClock _clock;

            // For testing purposes.
            // See the note on CacheExpired to know why we don't have a clock here.
            protected CertificateCacheBase(IClock clock) =>
                _clock = clock ?? SystemClock.Default;

            public async Task<IEnumerable<AsymmetricAlgorithm>> GetCertificatesAsync(string certificatesLocation, Func<JToken, AsymmetricAlgorithm> certificateFactory, bool forceCertificateRefresh, CancellationToken cancellationToken)
            {
                certificatesLocation.ThrowIfNullOrEmpty(nameof(certificatesLocation));
                certificateFactory.ThrowIfNull(nameof(certificateFactory));

                await _cacheLock.WaitAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    if (forceCertificateRefresh ||
                        !_cache.TryGetValue(certificatesLocation, out CachedCertificates cachedCerts) ||
                        cachedCerts.Expired(_clock.UtcNow))
                    {
                        string certificatesJson = await FetchCertificatesAsync(certificatesLocation).ConfigureAwait(false);
                        cachedCerts = new CachedCertificates(
                            JToken.Parse(certificatesJson)["keys"]
                            .AsEnumerable()
                            .Select(key => certificateFactory(key)).ToList(),
                            _clock.UtcNow);
                        _cache[certificatesLocation] = cachedCerts;
                    }
                    return cachedCerts.Certificates;
                }
                finally
                {
                    _cacheLock.Release();
                }
            }

            // Abstract for testing purposes.
            protected abstract Task<string> FetchCertificatesAsync(string certificatesLocation);

            internal struct CachedCertificates
            {
                private readonly DateTimeOffset _cachedSince;
                public IEnumerable<AsymmetricAlgorithm> Certificates { get; }

                public CachedCertificates(IEnumerable<AsymmetricAlgorithm> certificates, DateTimeOffset cachedSince)
                {
                    _cachedSince = cachedSince;
                    Certificates = certificates;
                }

                public bool Expired(DateTimeOffset now) => _cachedSince + DefaultCacheValidity <= now;
            }
        }

        internal sealed class CertificateCache : CertificateCacheBase
        {
            public CertificateCache() : base(SystemClock.Default)
            { }

            protected override async Task<string> FetchCertificatesAsync(string certificatesLocation)
            {
                using var httpClient = new HttpClient();
                return await httpClient.GetStringAsync(certificatesLocation).ConfigureAwait(false);
            }
        }
    }
}
