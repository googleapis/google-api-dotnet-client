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

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Json;
using Google.Apis.Util;

#if NETSTANDARD1_3
using RsaKey = System.Security.Cryptography.RSA;
#elif NET45
using RsaKey = System.Security.Cryptography.RSACryptoServiceProvider;
#else
#error Unsupported target
#endif

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Google OAuth 2.0 credential for accessing protected resources using an access token. The Google OAuth 2.0 
    /// Authorization Server supports server-to-server interactions such as those between a web application and Google
    /// Cloud Storage. The requesting application has to prove its own identity to gain access to an API, and an 
    /// end-user doesn't have to be involved. 
    /// <para>
    /// Take a look in https://developers.google.com/accounts/docs/OAuth2ServiceAccount for more details.
    /// </para>
    /// <para>
    /// Since version 1.9.3, service account credential also supports JSON Web Token access token scenario.
    /// In this scenario, instead of sending a signed JWT claim to a token server and exchanging it for 
    /// an access token, a locally signed JWT claim bound to an appropriate URI is used as an access token
    /// directly.
    /// See <see cref="GetAccessTokenForRequestAsync"/> for explanation when JWT access token
    /// is used and when regular OAuth2 token is used.
    /// </para>
    /// </summary>
    public class ServiceAccountCredential : ServiceCredential
    {
        private const string Sha256Oid = "2.16.840.1.101.3.4.2.1";
        /// <summary>An initializer class for the service account credential. </summary>
        new public class Initializer : ServiceCredential.Initializer
        {
            /// <summary>Gets the service account ID (typically an e-mail address).</summary>
            public string Id { get; private set; }

            /// <summary>
            /// Gets or sets the email address of the user the application is trying to impersonate in the service 
            /// account flow or <c>null</c>.
            /// </summary>
            public string User { get; set; }

            /// <summary>Gets the scopes which indicate API access your application is requesting.</summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets the key which is used to sign the request, as specified in
            /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#computingsignature.
            /// </summary>
            public RsaKey Key { get; set; }

            /// <summary>Constructs a new initializer using the given id.</summary>
            public Initializer(string id)
                : this(id, GoogleAuthConsts.OidcTokenUrl) { }

            /// <summary>Constructs a new initializer using the given id and the token server URL.</summary>
            public Initializer(string id, string tokenServerUrl) : base(tokenServerUrl)
            {
                Id = id;
                Scopes = new List<string>();
            }

            /// <summary>Extracts the <see cref="Key"/> from the given PKCS8 private key.</summary>
            public Initializer FromPrivateKey(string privateKey)
            {
                RSAParameters rsaParameters = Pkcs8.DecodeRsaParameters(privateKey);
                Key = (RsaKey)RSA.Create();
                Key.ImportParameters(rsaParameters);
                return this;
            }

            /// <summary>Extracts a <see cref="Key"/> from the given certificate.</summary>
            public Initializer FromCertificate(X509Certificate2 certificate)
            {
#if NETSTANDARD1_3
                Key = certificate.GetRSAPrivateKey();
#elif NET45
                // Workaround to correctly cast the private key as a RSACryptoServiceProvider type 24.
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)certificate.PrivateKey;
                byte[] privateKeyBlob = rsa.ExportCspBlob(true);
                Key = new RSACryptoServiceProvider();
                Key.ImportCspBlob(privateKeyBlob);
#else
#error Unsupported target
#endif
                return this;
            }
        }

        /// <summary>Unix epoch as a <c>DateTime</c></summary>
        protected static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private readonly string id;
        private readonly string user;
        private readonly IEnumerable<string> scopes;
        private readonly RsaKey key;

        /// <summary>Gets the service account ID (typically an e-mail address).</summary>
        public string Id { get { return id; } }

        /// <summary>
        /// Gets the email address of the user the application is trying to impersonate in the service account flow 
        /// or <c>null</c>.
        /// </summary>
        public string User { get { return user; } }

        /// <summary>Gets the service account scopes.</summary>
        public IEnumerable<string> Scopes { get { return scopes; } }

        /// <summary>
        /// Gets the key which is used to sign the request, as specified in
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#computingsignature.
        /// </summary>
        public RsaKey Key { get { return key; } }

        /// <summary><c>true</c> if this credential has any scopes associated with it.</summary>
        internal bool HasScopes { get { return scopes != null && scopes.Any(); } }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        public ServiceAccountCredential(Initializer initializer) : base(initializer)
        {
            id = initializer.Id.ThrowIfNullOrEmpty("initializer.Id");
            user = initializer.User;
            scopes = initializer.Scopes;
            key = initializer.Key.ThrowIfNull("initializer.Key");
        }

        /// <summary>
        /// Creates a new <see cref="ServiceAccountCredential"/> instance from JSON credential data.
        /// </summary>
        /// <param name="credentialData">The stream from which to read the JSON key data for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialData"/> does not contain valid JSON service account key data.
        /// </exception>
        /// <returns>The credentials parsed from the service account key data.</returns>
        public static ServiceAccountCredential FromServiceAccountData(Stream credentialData)
        {
            var credential = GoogleCredential.FromStream(credentialData);
            var result = credential.UnderlyingCredential as ServiceAccountCredential;
            if (result == null)
            {
                throw new InvalidOperationException("JSON data does not represent a valid service account credential.");
            }
            return result;
        }

        /// <summary>
        /// Requests a new token as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#makingrequest.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            // Create the request.
            var request = new GoogleAssertionTokenRequest()
            {
                Assertion = CreateAssertionFromPayload(CreatePayload())
            };

            Logger.Debug("Request a new access token. Assertion data is: " + request.Assertion);

            var newToken = await request.ExecuteAsync(HttpClient, TokenServerUrl, taskCancellationToken, Clock)
                .ConfigureAwait(false);
            Token = newToken;
            return true;
        }

        /// <summary>
        /// Gets an access token to authorize a request.
        /// If <paramref name="authUri"/> is set and this credential has no scopes associated
        /// with it, a locally signed JWT access token for given <paramref name="authUri"/>
        /// is returned. Otherwise, an OAuth2 access token obtained from token server will be returned.
        /// A cached token is used if possible and the token is only refreshed once it's close to its expiry.
        /// </summary>
        /// <param name="authUri">The URI the returned token will grant access to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The access token.</returns>
        public override async Task<string> GetAccessTokenForRequestAsync(string authUri = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!HasScopes && authUri != null)
            {
                // TODO(jtattermusch): support caching of JWT access tokens per authUri, currently a new 
                // JWT access token is created each time, which can hurt performance.
                return CreateJwtAccessToken(authUri);
            }
            return await base.GetAccessTokenForRequestAsync(authUri, cancellationToken).ConfigureAwait(false);
        }
    
        /// <summary>
        /// Creates a JWT access token than can be used in request headers instead of an OAuth2 token.
        /// This is achieved by signing a special JWT using this service account's private key.
        /// <param name="authUri">The URI for which the access token will be valid.</param>
        /// </summary>
        private string CreateJwtAccessToken(string authUri)
        {
            var issuedDateTime = Clock.UtcNow;
            var issued = (int)(issuedDateTime - UnixEpoch).TotalSeconds;
            var payload = new JsonWebSignature.Payload()
            {
                Issuer = Id,
                Subject = Id,
                Audience = authUri,
                IssuedAtTimeSeconds = issued,
                ExpirationTimeSeconds = issued + 3600,
            };

            return CreateAssertionFromPayload(payload);
        }

        /// <summary>
        /// Signs JWT token using the private key and returns the serialized assertion.
        /// </summary>
        /// <param name="payload">the JWT payload to sign.</param>
        private string CreateAssertionFromPayload(JsonWebSignature.Payload payload)
        {
            string serializedHeader = CreateSerializedHeader();
            string serializedPayload = NewtonsoftJsonSerializer.Instance.Serialize(payload);

            var assertion = new StringBuilder();
            assertion.Append(UrlSafeBase64Encode(serializedHeader))
                .Append('.')
                .Append(UrlSafeBase64Encode(serializedPayload));
            var signature = CreateSignature(Encoding.ASCII.GetBytes(assertion.ToString()));
            assertion.Append('.') .Append(UrlSafeEncode(signature));
            return assertion.ToString();
        }

        /// <summary>
        /// Creates a base64 encoded signature for the SHA-256 hash of the specified data.
        /// </summary>
        /// <param name="data">The data to hash and sign. Must not be null.</param>
        /// <returns>The base-64 encoded signature.</returns>
        public string CreateSignature(byte[] data)
        {
            data.ThrowIfNull(nameof(data));

            using (var hashAlg = SHA256.Create())
            {
                byte[] assertionHash = hashAlg.ComputeHash(data);
#if NETSTANDARD1_3
                var sigBytes = key.SignHash(assertionHash, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
#elif NET45
                var sigBytes = key.SignHash(assertionHash, Sha256Oid);
#else
#error Unsupported target
#endif
                return Convert.ToBase64String(sigBytes);
            }
        }

        /// <summary>
        /// Creates a serialized header as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingheader.
        /// </summary>
        private static string CreateSerializedHeader()
        {
            var header = new GoogleJsonWebSignature.Header()
            {
                Algorithm = "RS256",
                Type = "JWT"
            };

            return NewtonsoftJsonSerializer.Instance.Serialize(header);
        }

        /// <summary>
        /// Creates a claim set as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingclaimset.
        /// </summary>
        private GoogleJsonWebSignature.Payload CreatePayload()
        {
            var issued = (int)(Clock.UtcNow - UnixEpoch).TotalSeconds;
            return new GoogleJsonWebSignature.Payload()
            {
                Issuer = Id,
                Audience = TokenServerUrl,
                IssuedAtTimeSeconds = issued,
                ExpirationTimeSeconds = issued + 3600,
                Subject = User,
                Scope = String.Join(" ", Scopes)
            };
        }

        /// <summary>Encodes the provided UTF8 string into an URL safe base64 string.</summary>
        /// <param name="value">Value to encode.</param>
        /// <returns>The URL safe base64 string.</returns>
        private string UrlSafeBase64Encode(string value)
        {
            return UrlSafeBase64Encode(Encoding.UTF8.GetBytes(value));
        }

        /// <summary>Encodes the byte array into an URL safe base64 string.</summary>
        /// <param name="bytes">Byte array to encode.</param>
        /// <returns>The URL safe base64 string.</returns>
        private string UrlSafeBase64Encode(byte[] bytes)
        {
            return UrlSafeEncode(Convert.ToBase64String(bytes));
        }

        /// <summary>Encodes the base64 string into an URL safe string.</summary>
        /// <param name="base64Value">The base64 string to make URL safe.</param>
        /// <returns>The URL safe base64 string.</returns>
        private string UrlSafeEncode(string base64Value)
        {
            return base64Value.Replace("=", String.Empty).Replace('+', '-').Replace('/', '_');
        }
    }
}
