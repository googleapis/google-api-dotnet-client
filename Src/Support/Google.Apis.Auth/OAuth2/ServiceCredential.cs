/*
Copyright 2014 Google Inc

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

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// This type of Google OAuth 2.0 credential enables access to protected resources using an access token when
    /// interacting server to server. For example, a service account credential could be used to access Google Cloud
    /// Storage from a web application without a user's involvement.
    /// <para>
    /// <code>ServiceAccountCredential</code> inherits from this class in order to support Service Account. More
    /// details available at: https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// <see cref="Google.Apis.Auth.OAuth2.ComputeCredential"/> is another example for a class that inherits from this
    /// class in order to support Compute credentials. For more information about Compute authentication, see:
    /// https://cloud.google.com/compute/docs/authentication.
    /// </para>
    /// </summary>
    public abstract class ServiceCredential : ICredential, ITokenAccessWithHeaders,
        IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler
    {
        /// <summary>Logger for this class</summary>
        protected static readonly ILogger Logger = ApplicationContext.Logger.ForType<ServiceCredential>();

        /// <summary>An initializer class for the service credential. </summary>
        public class Initializer
        {
            /// <summary>Gets the token server URL.</summary>
            public string TokenServerUrl { get; private set; }

            /// <summary>
            /// Gets or sets the clock used to refresh the token when it expires. The default value is
            /// <see cref="Google.Apis.Util.SystemClock.Default"/>.
            /// </summary>
            public IClock Clock { get; set; }

            /// <summary>
            /// Gets or sets the method for presenting the access token to the resource server.
            /// The default value is <see cref="BearerToken.AuthorizationHeaderAccessMethod"/>.
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
            /// configure the <see cref="Google.Apis.Http.ConfigurableMessageHandler"/> in an
            /// <see cref="Google.Apis.Http.IConfigurableHttpClientInitializer"/> to set a specific back-off
            /// implementation (using <see cref="Google.Apis.Http.BackOffHandler"/>).
            /// </summary>
            public ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; set; }

            /// <summary>
            /// The ID of the project associated to this credential for the purposes of
            /// quota calculation and billing. May be null.
            /// </summary>
            public string QuotaProject { get; set; }

            /// <summary>
            /// Initializers to be sent to the <see cref="HttpClientFactory"/> to be set
            /// on the <see cref="HttpClient"/> that will be used by the credential to perform
            /// token operations.
            /// </summary>
            internal IList<IConfigurableHttpClientInitializer> HttpClientInitializers { get; }

            /// <summary>Constructs a new initializer using the given token server URL.</summary>
            public Initializer(string tokenServerUrl)
            {
                TokenServerUrl = tokenServerUrl;

                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                Clock = SystemClock.Default;
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503;

                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>();
            }

            internal Initializer(ServiceCredential other)
            {
                TokenServerUrl = other.TokenServerUrl;
                Clock = other.Clock;
                AccessMethod = other.AccessMethod;
                HttpClientFactory = other.HttpClientFactory;
                DefaultExponentialBackOffPolicy = other.DefaultExponentialBackOffPolicy;
                QuotaProject = other.QuotaProject;
                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(other.HttpClientInitializers);
            }

            internal Initializer(Initializer other)
            {
                TokenServerUrl = other.TokenServerUrl;
                Clock = other.Clock;
                AccessMethod = other.AccessMethod;
                HttpClientFactory = other.HttpClientFactory;
                DefaultExponentialBackOffPolicy = other.DefaultExponentialBackOffPolicy;
                QuotaProject = other.QuotaProject;
                HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(other.HttpClientInitializers);
            }
        }

        /// <summary>Gets the token server URL.</summary>
        public string TokenServerUrl { get; }

        /// <summary>Gets the clock used to refresh the token if it expires.</summary>
        public IClock Clock { get; }

        /// <summary>Gets the method for presenting the access token to the resource server.</summary>
        public IAccessMethod AccessMethod { get; }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get; }

        internal IHttpClientFactory HttpClientFactory { get; }

        /// <summary>
        /// Initializers to be sent to the <see cref="HttpClientFactory"/> to be set
        /// on the <see cref="HttpClient"/> that will be used by the credential to perform
        /// token operations.
        /// </summary>
        internal IEnumerable<IConfigurableHttpClientInitializer> HttpClientInitializers { get; }

        internal ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; }

        private readonly TokenRefreshManager _refreshManager;

        /// <summary>Gets the token response which contains the access token.</summary>
        public TokenResponse Token
        {
            get => _refreshManager.Token;
            set => _refreshManager.Token = value;
        }

        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        public string QuotaProject { get; }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        public ServiceCredential(Initializer initializer)
        {
            TokenServerUrl = initializer.TokenServerUrl;
            AccessMethod = initializer.AccessMethod.ThrowIfNull("initializer.AccessMethod");
            Clock = initializer.Clock.ThrowIfNull("initializer.Clock");

            // Set the HTTP client.
            var httpArgs = new CreateHttpClientArgs();

            // Add exponential back-off initializer if necessary.
            DefaultExponentialBackOffPolicy = initializer.DefaultExponentialBackOffPolicy;
            if (DefaultExponentialBackOffPolicy != ExponentialBackOffPolicy.None)
            {
                httpArgs.Initializers.Add(
                    new ExponentialBackOffInitializer(DefaultExponentialBackOffPolicy,
                        () => new BackOffHandler(new ExponentialBackOff())));
            }

            // Add other initializers
            HttpClientInitializers = new List<IConfigurableHttpClientInitializer>(initializer.HttpClientInitializers).AsReadOnly();
            foreach(var httpClientInitializer in HttpClientInitializers)
            {
                httpArgs.Initializers.Add(httpClientInitializer);
            }

            HttpClientFactory = initializer.HttpClientFactory ?? new HttpClientFactory();
            HttpClient = HttpClientFactory.CreateHttpClient(httpArgs);
            _refreshManager = new TokenRefreshManager(RequestAccessTokenAsync, Clock, Logger);

            QuotaProject = initializer.QuotaProject;
        }

        #region IConfigurableHttpClientInitializer

        /// <inheritdoc/>
        public void Initialize(ConfigurableHttpClient httpClient) =>
            httpClient.MessageHandler.Credential = this;

        #endregion

        #region IHttpExecuteInterceptor implementation

        /// <inheritdoc/>
        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var audience = new UriBuilder(request.RequestUri) { Query = string.Empty, Path = string.Empty }.Uri.ToString();
            var accessToken = await GetAccessTokenWithHeadersForRequestAsync(audience, cancellationToken).ConfigureAwait(false);
            AccessMethod.Intercept(request, accessToken.AccessToken);
            accessToken.AddHeaders(request);
        }

        #endregion

        #region IHttpUnsuccessfulResponseHandler

        /// <summary>
        /// Decorates unsuccessful responses, returns true if the response gets modified.
        /// See IHttpUnsuccessfulResponseHandler for more information. 
        /// </summary>
        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // If the response was unauthorized, request a new access token so that the original
            // request can be retried.
            // TODO(peleyal): check WWW-Authenticate header.
            if (args.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                bool tokensEqual = false;
                if (Token != null)
                {
                    tokensEqual = Object.Equals(
                        Token.AccessToken, AccessMethod.GetAccessToken(args.Request));
                }
                return !tokensEqual
                    || await RequestAccessTokenAsync(args.CancellationToken).ConfigureAwait(false);
            }

            return false;
        }

        #endregion

        #region ITokenAccess implementation

        /// <summary>
        /// Gets an access token to authorize a request. If the existing token expires soon, try to refresh it first.
        /// <seealso cref="ITokenAccess.GetAccessTokenForRequestAsync"/>
        /// </summary>
        public virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null,
            CancellationToken cancellationToken = default(CancellationToken)) =>
            _refreshManager.GetAccessTokenForRequestAsync(cancellationToken);

        #endregion

        #region ITokenAccessWithHeaders implementation
        /// <inheritdoc />
        public async Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = default)
        {
            string token = await GetAccessTokenForRequestAsync(authUri, cancellationToken).ConfigureAwait(false);
            return new AccessTokenWithHeaders.Builder { QuotaProject = QuotaProject }.Build(token);
        }
        #endregion

        /// <summary>Requests a new token.</summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public abstract Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken);
    }
}
