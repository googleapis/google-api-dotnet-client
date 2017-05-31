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
using Google.Apis.Json;
using Google.Apis.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth
{
    /// <summary>
    /// Google JSON Web Signature as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// </summary>
    public class GoogleJsonWebSignature
    {

        internal const int MaxJwtLength = 10000;
        internal readonly static TimeSpan CertCacheRefreshInterval = TimeSpan.FromHours(1);

        // See http://oid-info.com/get/2.16.840.1.101.3.4.2.1
        private const string Sha256Oid = "2.16.840.1.101.3.4.2.1";

        private const string SupportedJwtAlgorithm = "RS256";

        private static readonly IEnumerable<string> ValidJwtIssuers = new[]
        {
            "https://accounts.google.com",
            "accounts.google.com"
        };

        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Validates a Google-issued Json Web Token (JWT).
        /// With throw a <see cref="InvalidJwtException"/> if the passed value is not valid JWT signed by Google.
        /// </summary>
        /// <remarks>
        /// <para>Follows the procedure to
        /// <see href="https://developers.google.com/identity/protocols/OpenIDConnect#validatinganidtoken">validate a JWT ID token</see>.
        /// </para>
        /// <para>Google certificates are cached, and refreshed once per hour. This can be overridden by setting
        /// <paramref name="forceGoogleCertRefresh"/> to true.</para>
        /// </remarks>
        /// <param name="jwt">The JWT to validate.</param>
        /// <param name="clock">Optional. The <see cref="IClock"/> to use for JWT expiration verification. Defaults to the system clock.</param>
        /// <param name="forceGoogleCertRefresh">Optional. If true forces new certificates to be downloaded from Google. Defaults to false.</param>
        /// <returns>The JWT payload, if the JWT is valid. Throws an <see cref="InvalidJwtException"/> otherwise.</returns>
        /// <exception cref="InvalidJwtException">Thrown when passed a JWT that is not a valid JWT signed by Google.</exception>
        public static Task<Payload> ValidateAsync(string jwt, IClock clock = null, bool forceGoogleCertRefresh = false) =>
            ValidateInternalAsync(jwt, clock ?? SystemClock.Default, forceGoogleCertRefresh, null);

        // internal for testing
        internal static async Task<Payload> ValidateInternalAsync(string jwt, IClock clock, bool forceGoogleCertRefresh, string certsJson)
        {
            // Check arguments
            jwt.ThrowIfNull(nameof(jwt));
            jwt.ThrowIfNullOrEmpty(nameof(jwt));
            if (jwt.Length > MaxJwtLength)
            {
                throw new InvalidJwtException($"JWT exceeds maximum allowed length of {MaxJwtLength}");
            }
            var parts = jwt.Split('.');
            if (parts.Length != 3)
            {
                throw new InvalidJwtException($"JWT must consist of Header, Payload, and Signature");
            }
            
            // Decode the three parts of the JWT: header.payload.signature
            Header header = NewtonsoftJsonSerializer.Instance.Deserialize<Header>(Base64UrlToString(parts[0]));
            Payload payload = NewtonsoftJsonSerializer.Instance.Deserialize<Payload>(Base64UrlToString(parts[1]));
            byte[] signature = Base64UrlDecode(parts[2]);

            // Verify algorithm in JWT
            if (header.Algorithm != SupportedJwtAlgorithm)
            {
                throw new InvalidJwtException($"JWT algorithm must be '{SupportedJwtAlgorithm}'");
            }

            // Verify signature
            byte[] hash;
            using (var hashAlg = SHA256.Create())
            {
                hash = hashAlg.ComputeHash(Encoding.ASCII.GetBytes($"{parts[0]}.{parts[1]}"));
            }
            bool verifiedOk = false;
            foreach (var googleCert in await GetGoogleCertsAsync(clock, forceGoogleCertRefresh, certsJson))
            {
#if NET45
                verifiedOk = ((RSACryptoServiceProvider)googleCert).VerifyHash(hash, Sha256Oid, signature);
#elif NETSTANDARD1_3
                verifiedOk = googleCert.VerifyHash(hash, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
#else
#error Unsupported platform
#endif
                if (verifiedOk)
                {
                    break;
                }
            }
            if (!verifiedOk)
            {
                throw new InvalidJwtException("JWT invalid: unable to verify signature.");
            }

            // Verify iss, iat and exp claims
            if (!ValidJwtIssuers.Contains(payload.Issuer))
            {
                var validList = string.Join(", ", ValidJwtIssuers.Select(x => $"'{x}'"));
                throw new InvalidJwtException($"JWT issuer incorrect. Must be one of: {validList}");
            }
            if (payload.IssuedAtTimeSeconds == null || payload.ExpirationTimeSeconds == null)
            {
                throw new InvalidJwtException("JWT must contain 'iat' and 'exp' claims");
            }
            var nowSeconds = (clock.UtcNow - UnixEpoch).TotalSeconds;
            if (nowSeconds < payload.IssuedAtTimeSeconds.Value)
            {
                throw new InvalidJwtException("JWT is not yet valid.");
            }
            if (nowSeconds > payload.ExpirationTimeSeconds.Value)
            {
                throw new InvalidJwtException("JWT has expired.");
            }

            // All verification passed, return payload.
            return payload;
        }

        private static string Base64UrlToString(string base64Url) => Encoding.UTF8.GetString(Base64UrlDecode(base64Url));

        private static byte[] Base64UrlDecode(string base64Url)
        {
            var base64 = base64Url.Replace('-', '+').Replace('_', '/');
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        private static SemaphoreSlim _certCacheLock = new SemaphoreSlim(1);
        private static DateTime _certCacheDownloadTime;
        private static List<RSA> _certCache;

        // internal for testing
        internal static async Task<List<RSA>> GetGoogleCertsAsync(IClock clock, bool forceGoogleCertRefresh, string certsJson)
        {
            var now = clock.UtcNow;
            await _certCacheLock.WaitAsync();
            try
            {
                if (forceGoogleCertRefresh || _certCache == null || (_certCacheDownloadTime + CertCacheRefreshInterval) < now)
                {
                    using (var httpClient = new HttpClient())
                    {
                        // certsJson used for unit tests
                        if (certsJson == null)
                        {
                            certsJson = await httpClient.GetStringAsync(GoogleAuthConsts.JsonWebKeySetUrl);
                        }
                    }
                    _certCache = GetGoogleCertsFromJson(certsJson);
                    _certCacheDownloadTime = now;
                }
                return _certCache;
            }
            finally
            {
                _certCacheLock.Release();
            }
        }

        private static List<RSA> GetGoogleCertsFromJson(string json) =>
            JToken.Parse(json)["keys"].AsEnumerable().Select(key =>
                {
                    var rsa = RSA.Create();
                    rsa.ImportParameters(new RSAParameters
                    {
                        Modulus = Base64UrlDecode((string)key["n"]),
                        Exponent = Base64UrlDecode((string)key["e"]),
                    });
                    return rsa;
                })
                .ToList();

        /// <summary>
        /// The header as specified in https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader.
        /// </summary>
        public class Header : JsonWebSignature.Header
        {
        }

        /// <summary>
        /// The payload as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingclaimset.
        /// </summary>
        public class Payload : JsonWebSignature.Payload
        {
            /// <summary>
            /// a space-delimited list of the permissions the application requests or <c>null</c>.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("scope")]
            public string Scope { get; set; }

            /// <summary>
            /// The email address of the user for which the application is requesting delegated access.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("prn")]
            public string Prn { get; set; }
        }
    }
}
