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
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util;

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
    /// </summary>
    public class ServiceAccountCredential : ServiceCredential
    {
        /// <summary>An initializer class for the service account credential. </summary>
        public class Initializer : ServiceCredential.Initializer
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
            public RSACryptoServiceProvider Key { get; set; }

            /// <summary>Constructs a new initializer using the given id.</summary>
            public Initializer(string id)
                : this(id, GoogleAuthConsts.TokenUrl) { }

            /// <summary>Constructs a new initializer using the given id and the token server URL.</summary>
            public Initializer(string id, string tokenServerUrl) : base(tokenServerUrl)
            {
                Id = id;
                Scopes = new List<string>();
            }

            /// <summary>Extracts a <see cref="Key"/> from the given certificate.</summary>
            public Initializer FromCertificate(X509Certificate2 certificate)
            {
                // Workaround to correctly cast the private key as a RSACryptoServiceProvider type 24.
                RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)certificate.PrivateKey;
                byte[] privateKeyBlob = rsa.ExportCspBlob(true);
                Key = new RSACryptoServiceProvider();
                Key.ImportCspBlob(privateKeyBlob);
                return this;
            }
        }

        #region Readonly fields

        private readonly string id;
        private readonly string user;
        private readonly IEnumerable<string> scopes;
        private readonly RSACryptoServiceProvider key;

        #endregion

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
        public RSACryptoServiceProvider Key { get { return key; } }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        /// <param name="initializer"></param>
        public ServiceAccountCredential(Initializer initializer) : base(initializer)
        {
            id = initializer.Id.ThrowIfNullOrEmpty("initializer.Id");
            user = initializer.User;
            scopes = initializer.Scopes;
            key = initializer.Key.ThrowIfNull("initializer.Key");
        }

        #region ServiceCredential overrides

        /// <summary>
        /// Requests a new token as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#makingrequest.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            string serializedHeader = CreateSerializedHeader();
            string serializedPayload = GetSerializedPayload();

            StringBuilder assertion = new StringBuilder();
            assertion.Append(UrlSafeBase64Encode(serializedHeader))
                .Append(".")
                .Append(UrlSafeBase64Encode(serializedPayload));

            // Sign the header and the payload.
            var signature = UrlSafeBase64Encode(key.SignData(Encoding.ASCII.GetBytes(assertion.ToString()), "SHA256"));
            assertion.Append(".").Append(signature);

            // Create the request.
            var request = new GoogleAssertionTokenRequest()
            {
                Assertion = assertion.ToString()
            };

            Logger.Debug("Request a new access token. Assertion data is: " + request.Assertion);

            var newToken = await request.ExecuteAsync(HttpClient, TokenServerUrl, taskCancellationToken, Clock)
                .ConfigureAwait(false);
            Token = newToken;
            return true;
        }

        #endregion

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
        /// Creates a serialized claim set as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#formingclaimset.
        /// </summary>
        private string GetSerializedPayload()
        {
            var issued = (int)(Clock.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            var payload = new GoogleJsonWebSignature.Payload()
            {
                Issuer = Id,
                Audience = TokenServerUrl,
                IssuedAtTimeSeconds = issued,
                ExpirationTimeSeconds = issued + 3600,
                Subject = User,
                Scope = String.Join(" ", Scopes)
            };

            return NewtonsoftJsonSerializer.Instance.Serialize(payload);
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
            return Convert.ToBase64String(bytes).Replace("=", String.Empty).Replace('+', '-').Replace('/', '_');
        }
    }
}
