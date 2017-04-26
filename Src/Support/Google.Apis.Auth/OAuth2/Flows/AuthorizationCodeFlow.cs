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
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using Google.Apis.Testing;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Thread-safe OAuth 2.0 authorization code flow that manages and persists end-user credentials.
    /// <para>
    /// This is designed to simplify the flow in which an end-user authorizes the application to access their protected
    /// data, and then the application has access to their data based on an access token and a refresh token to refresh 
    /// that access token when it expires.
    /// </para>
    /// </summary>
    public class AuthorizationCodeFlow : IAuthorizationCodeFlow
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<AuthorizationCodeFlow>();

        #region Initializer

        /// <summary>An initializer class for the authorization code flow. </summary>
        public class Initializer
        {
            /// <summary>
            /// Gets or sets the method for presenting the access token to the resource server.
            /// The default value is
            /// <see cref="Google.Apis.Auth.OAuth2.BearerToken.AuthorizationHeaderAccessMethod"/>.
            /// </summary>
            public IAccessMethod AccessMethod { get; set; }

            /// <summary>Gets the token server URL.</summary>
            public string TokenServerUrl { get; private set; }

            /// <summary>Gets or sets the authorization server URL.</summary>
            public string AuthorizationServerUrl { get; private set; }

            /// <summary>Gets or sets the client secrets which includes the client identifier and its secret.</summary>
            public ClientSecrets ClientSecrets { get; set; }

            /// <summary>
            /// Gets or sets the client secrets stream which contains the client identifier and its secret.
            /// </summary>
            /// <remarks>The AuthorizationCodeFlow constructor is responsible for disposing the stream.</remarks>
            public Stream ClientSecretsStream { get; set; }

            /// <summary>Gets or sets the data store used to store the token response.</summary>
            public IDataStore DataStore { get; set; }

            /// <summary>
            /// Gets or sets the scopes which indicate the API access your application is requesting.
            /// </summary>
            public IEnumerable<string> Scopes { get; set; }

            /// <summary>
            /// Gets or sets the factory for creating <see cref="System.Net.Http.HttpClient"/> instance.
            /// </summary>
            public IHttpClientFactory HttpClientFactory { get; set; }

            /// <summary>
            /// Get or sets the exponential back-off policy. Default value is  <c>UnsuccessfulResponse503</c>, which 
            /// means that exponential back-off is used on 503 abnormal HTTP responses.
            /// If the value is set to <c>None</c>, no exponential back-off policy is used, and it's up to user to
            /// configure the <see cref="Google.Apis.Http.ConfigurableMessageHandler"/> in an
            /// <see cref="Google.Apis.Http.IConfigurableHttpClientInitializer"/> to set a specific back-off
            /// implementation (using <see cref="Google.Apis.Http.BackOffHandler"/>).
            /// </summary>
            public ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; set; }

            /// <summary>
            /// Gets or sets the clock. The clock is used to determine if the token has expired, if so we will try to
            /// refresh it. The default value is <see cref="Google.Apis.Util.SystemClock.Default"/>.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="authorizationServerUrl">Authorization server URL</param>
            /// <param name="tokenServerUrl">Token server URL</param>
            public Initializer(string authorizationServerUrl, string tokenServerUrl)
            {
                AuthorizationServerUrl = authorizationServerUrl;
                TokenServerUrl = tokenServerUrl;

                Scopes = new List<string>();
                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503;
                Clock = SystemClock.Default;
            }
        }

        #endregion

        #region Readonly fields

        private readonly IAccessMethod accessMethod;
        private readonly string tokenServerUrl;
        private readonly string authorizationServerUrl;
        private readonly ClientSecrets clientSecrets;
        private readonly IDataStore dataStore;
        private readonly IEnumerable<string> scopes;
        private readonly ConfigurableHttpClient httpClient;
        private readonly IClock clock;

        #endregion

        /// <summary>Gets the token server URL.</summary>
        public string TokenServerUrl { get { return tokenServerUrl; } }

        /// <summary>Gets the authorization code server URL.</summary>
        public string AuthorizationServerUrl { get { return authorizationServerUrl; } }

        /// <summary>Gets the client secrets which includes the client identifier and its secret.</summary>
        public ClientSecrets ClientSecrets { get { return clientSecrets; } }

        /// <summary>Gets the data store used to store the credentials.</summary>
        public IDataStore DataStore { get { return dataStore; } }

        /// <summary>Gets the scopes which indicate the API access your application is requesting.</summary>
        public IEnumerable<string> Scopes { get { return scopes; } }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get { return httpClient; } }

        /// <summary>Constructs a new flow using the initializer's properties.</summary>
        public AuthorizationCodeFlow(Initializer initializer)
        {
            clientSecrets = initializer.ClientSecrets;
            if (clientSecrets == null)
            {
                if (initializer.ClientSecretsStream == null)
                {
                    throw new ArgumentException("You MUST set ClientSecret or ClientSecretStream on the initializer");
                }

                using (initializer.ClientSecretsStream)
                {
                    clientSecrets = GoogleClientSecrets.Load(initializer.ClientSecretsStream).Secrets;
                }
            }
            else if (initializer.ClientSecretsStream != null)
            {
                throw new ArgumentException(
                    "You CAN'T set both ClientSecrets AND ClientSecretStream on the initializer");
            }

            accessMethod = initializer.AccessMethod.ThrowIfNull("Initializer.AccessMethod");
            clock = initializer.Clock.ThrowIfNull("Initializer.Clock");
            tokenServerUrl = initializer.TokenServerUrl.ThrowIfNullOrEmpty("Initializer.TokenServerUrl");
            authorizationServerUrl = initializer.AuthorizationServerUrl.ThrowIfNullOrEmpty
                ("Initializer.AuthorizationServerUrl");

            dataStore = initializer.DataStore;
            if (dataStore == null)
            {
                Logger.Warning("Datastore is null, as a result the user's credential will not be stored");
            }
            scopes = initializer.Scopes;

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
        }

        #region IAuthorizationCodeFlow overrides

        public IAccessMethod AccessMethod { get { return accessMethod; } }

        public IClock Clock { get { return clock; } }

        public async Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore == null)
            {
                return null;
            }
            return await DataStore.GetAsync<TokenResponse>(userId).ConfigureAwait(false);
        }

        public async Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore != null)
            {
                await DataStore.DeleteAsync<TokenResponse>(userId).ConfigureAwait(false);
            }
        }

        public virtual AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri)
        {
            return new AuthorizationCodeRequestUrl(new Uri(AuthorizationServerUrl))
            {
                ClientId = ClientSecrets.ClientId,
                Scope = string.Join(" ", Scopes),
                RedirectUri = redirectUri
            };
        }

        public async Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri,
            CancellationToken taskCancellationToken)
        {
            var authorizationCodeTokenReq = new AuthorizationCodeTokenRequest
            {
                Scope = string.Join(" ", Scopes),
                RedirectUri = redirectUri,
                Code = code,
            };

            var token = await FetchTokenAsync(userId, authorizationCodeTokenReq, taskCancellationToken)
                .ConfigureAwait(false);
            await StoreTokenAsync(userId, token, taskCancellationToken).ConfigureAwait(false);
            return token;
        }

        public async Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken,
            CancellationToken taskCancellationToken)
        {
            var refreshTokenReq = new RefreshTokenRequest
            {
                RefreshToken = refreshToken,
            };
            var token = await FetchTokenAsync(userId, refreshTokenReq, taskCancellationToken).ConfigureAwait(false);

            // The new token may not contain a refresh token, so set it with the given refresh token.
            if (token.RefreshToken == null)
            {
                token.RefreshToken = refreshToken;
            }

            await StoreTokenAsync(userId, token, taskCancellationToken).ConfigureAwait(false);
            return token;
        }

        public virtual Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken)
        {
            throw new NotImplementedException("The OAuth 2.0 protocol does not support token revocation.");
        }

        public virtual bool ShouldForceTokenRetrieval() { return false; }

        #endregion

        /// <summary>Stores the token in the <see cref="DataStore"/>.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">Token to store.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        private async Task StoreTokenAsync(string userId, TokenResponse token, CancellationToken taskCancellationToken)
        {
            taskCancellationToken.ThrowIfCancellationRequested();
            if (DataStore != null)
            {
                await DataStore.StoreAsync<TokenResponse>(userId, token).ConfigureAwait(false);
            }
        }

        /// <summary>Retrieve a new token from the server using the specified request.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="request">Token request.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>Token response with the new access token.</returns>
        [VisibleForTestOnly]
        public async Task<TokenResponse> FetchTokenAsync(string userId, TokenRequest request,
            CancellationToken taskCancellationToken)
        {
            // Add client id and client secret to requests.
            request.ClientId = ClientSecrets.ClientId;
            request.ClientSecret = ClientSecrets.ClientSecret;

            TokenResponseException tokenException = null;
            try
            {
                var tokenResponse = await request.ExecuteAsync
                    (httpClient, TokenServerUrl, taskCancellationToken, Clock).ConfigureAwait(false);
                return tokenResponse;
            }
            catch (TokenResponseException ex)
            {
                // In case there is an exception during getting the token, we delete any user's token information from 
                // the data store.
                tokenException = ex;
            }
            await DeleteTokenAsync(userId, taskCancellationToken).ConfigureAwait(false);
            throw tokenException;
        }

        public void Dispose()
        {
            if (HttpClient != null)
            {
                HttpClient.Dispose();
            }
        }
    }
}
