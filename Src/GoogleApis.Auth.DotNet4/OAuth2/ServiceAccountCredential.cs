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
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
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
    public class ServiceAccountCredential : IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler,
        IConfigurableHttpClientInitializer
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<ServiceAccountCredential>();

        /// <summary>An initializer class for the service account credential. </summary>
        public class Initializer
        {
            /// <summary>Gets the service account ID (typically an e-mail address).</summary>
            public string Id { get; private set; }

            /// <summary>Gets the token server URL.</summary>
            public string TokenServerUrl { get; private set; }

            /// <summary>
            /// Gets or sets the email address of the user the application is trying to impersonate in the service 
            /// account flow or <c>null</c>.
            /// </summary>
            public string User { get; set; }

            /// <summary>Gets the scopes which indicate API access your application is requesting.</summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets the clock. The clock is used to determine if the token has expired, if so we will try to
            /// refresh it. The default value is <seealso cref="SystemClock.Default"/>.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>
            /// Gets or sets the key which is used to sign the request, as specified in
            /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#computingsignature.
            /// </summary>
            public RSACryptoServiceProvider Key { get; set; }

            /// <summary>
            /// Gets or sets the method for presenting the access token to the resource server.
            /// The default value is <seealso cref="BearerToken.AuthorizationHeaderAccessMethod"/>.
            /// </summary>
            public IAccessMethod AccessMethod { get; set; }

            /// <summary>
            /// Gets or sets the factory for creating a <see cref="System.Net.Http.HttpClient"/> instance.
            /// </summary>
            public IHttpClientFactory HttpClientFactory { get; set; }

            /// <summary>
            /// Get or sets the exponential back-off policy. Default value is  <c>UnsuccessfulResponse503</c>, which 
            /// means that exponential back-off is used on 503 abnormal HTTP responses.
            /// If the value is set to <c>None</c>, no exponential back-off policy is used, and it's up to the user to
            /// configure the <seealso cref="Google.Apis.Http.ConfigurableMessageHandler"/> in an
            /// <seealso cref="Google.Apis.Http.IConfigurableHttpClientInitializer"/> to set a specific back-off
            /// implementation (using <seealso cref="Google.Apis.Http.BackOffHandler"/>).
            /// </summary>
            public ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; set; }

            /// <summary>Constructs a new initializer using the given id.</summary>
            public Initializer(string id)
                : this(id, GoogleAuthConsts.TokenUrl) { }

            /// <summary>Constructs a new initializer using the given id and the token server URL.</summary>
            public Initializer(string id, string tokenServerUrl)
            {
                Id = id;
                TokenServerUrl = tokenServerUrl;

                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                Clock = SystemClock.Default;
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503;
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
        private readonly string tokenServerUrl;
        private readonly string user;
        private readonly IEnumerable<string> scopes;
        private readonly IClock clock;
        private readonly IAccessMethod accessMethod;
        private readonly ConfigurableHttpClient httpClient;
        private readonly RSACryptoServiceProvider key;

        #endregion

        /// <summary>Gets the service account ID (typically an e-mail address).</summary>
        public string Id { get { return id; } }

        /// <summary>Gets the token server URL.</summary>
        public string TokenServerUrl { get { return tokenServerUrl; } }

        /// <summary>
        /// Gets the email address of the user the application is trying to impersonate in the service account flow 
        /// or <c>null</c>.
        /// </summary>
        public string User { get { return user; } }

        /// <summary>Gets the service account scopes.</summary>
        public IEnumerable<string> Scopes { get { return scopes; } }

        /// <summary>
        /// Gets the clock. The clock is used to determine if the token has expired, if so we will try to refresh it. 
        /// </summary>
        public IClock Clock { get { return clock; } }

        /// <summary>Gets the method for presenting the access token to the resource server.</summary>
        public IAccessMethod AccessMethod { get { return accessMethod; } }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get { return httpClient; } }

        /// <summary>
        /// Gets the key which is used to sign the request, as specified in
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#computingsignature.
        /// </summary>
        public RSACryptoServiceProvider Key { get { return key; } }

        private TokenResponse token;
        private object lockObject = new object();

        /// <summary>Gets the token response which contains the access token.</summary>
        public TokenResponse Token
        {
            get
            {
                lock (lockObject)
                {
                    return token;
                }
            }
            private set
            {
                lock (lockObject)
                {
                    token = value;
                }
            }
        }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        /// <param name="initializer"></param>
        public ServiceAccountCredential(Initializer initializer)
        {
            id = initializer.Id.ThrowIfNullOrEmpty("initializer.Id");
            user = initializer.User;
            scopes = initializer.Scopes;
            tokenServerUrl = initializer.TokenServerUrl;
            accessMethod = initializer.AccessMethod.ThrowIfNull("initializer.AccessMethod");
            clock = initializer.Clock.ThrowIfNull("initializer.Clock");

            // Set the HTTP client.
            var httpArgs = new CreateHttpClientArgs();

            // Add exponential back-off initializer if necessary.
            if (initializer.DefaultExponentialBackOffPolicy != ExponentialBackOffPolicy.None)
            {
                httpArgs.Initializers.Add(
                    new ExponentialBackOffInitializer(initializer.DefaultExponentialBackOffPolicy,
                        () => new BackOffHandler(new ExponentialBackOff())));
            }
            httpClient = (initializer.HttpClientFactory ?? new HttpClientFactory()).CreateHttpClient(httpArgs);
            key = initializer.Key.ThrowIfNull("initializer.Key");
        }

        public void Initialize(ConfigurableHttpClient httpClient)
        {
            httpClient.MessageHandler.ExecuteInterceptors.Add(this);
            httpClient.MessageHandler.UnsuccessfulResponseHandlers.Add(this);
        }

        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (Token == null || Token.IsExpired(Clock))
            {
                Logger.Debug("Token has expired, trying to get a new one.");
                if (!await RequestAccessTokenAsync(cancellationToken).ConfigureAwait(false))
                {
                    throw new InvalidOperationException("The access token has expired but we can't refresh it");
                }
                Logger.Info("New access token was received successfully");
            }

            AccessMethod.Intercept(request, Token.AccessToken);
        }

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // TODO(peleyal): check WWW-Authenticate header.
            if (args.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return !Object.Equals(Token.AccessToken, AccessMethod.GetAccessToken(args.Request))
                    || await RequestAccessTokenAsync(args.CancellationToken).ConfigureAwait(false);
            }

            return false;
        }

        /// <summary>
        /// Requests a new token as specified in 
        /// https://developers.google.com/accounts/docs/OAuth2ServiceAccount#makingrequest.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
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

            var newToken = await request.ExecuteAsync(httpClient, tokenServerUrl, taskCancellationToken, Clock)
                .ConfigureAwait(false);
            Token = newToken;
            return true;
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
