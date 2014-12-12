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

using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// This type of Google OAuth 2.0 credential enables access to protected resources using an access token when
    /// interacting server to server. For example, a service account credential could be used to access Google Cloud
    /// Storage from a web application without a user's involvement.
    /// <para>
    /// See also: <see cref="Google.Apis.Auth.OAuth2.ServiceAccountCredential"/>.
    /// <code>ServiceAccountCredential</code> inherits from this class in order to support Service Account. More
    /// details available at: https://developers.google.com/accounts/docs/OAuth2ServiceAccount.
    /// <see cref="Google.Apis.Auth.OAuth2.ComputeCredential"/> is another example for a class that inherits from this
    /// class in order to support Compute credentials. For more information about Compute authentication, see:
    /// https://cloud.google.com/compute/docs/authentication.
    /// </para>
    /// </summary>
    public abstract class ServiceCredential : IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler,
        IConfigurableHttpClientInitializer
    {
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

            /// <summary>Constructs a new initializer using the given token server URL.</summary>
            public Initializer(string tokenServerUrl)
            {
                TokenServerUrl = tokenServerUrl;

                AccessMethod = new BearerToken.AuthorizationHeaderAccessMethod();
                Clock = SystemClock.Default;
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503;
            }
        }

        #region Readonly fields

        private readonly string tokenServerUrl;
        private readonly IClock clock;
        private readonly IAccessMethod accessMethod;
        private readonly ConfigurableHttpClient httpClient;

        #endregion

        /// <summary>Gets the token server URL.</summary>
        public string TokenServerUrl { get { return tokenServerUrl; } }

        /// <summary>Gets the clock used to refresh the token if it expires.</summary>
        public IClock Clock { get { return clock; } }

        /// <summary>Gets the method for presenting the access token to the resource server.</summary>
        public IAccessMethod AccessMethod { get { return accessMethod; } }

        /// <summary>Gets the HTTP client used to make authentication requests to the server.</summary>
        public ConfigurableHttpClient HttpClient { get { return httpClient; } }

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
            protected set
            {
                lock (lockObject)
                {
                    token = value;
                }
            }
        }

        /// <summary>Constructs a new service account credential using the given initializer.</summary>
        public ServiceCredential(Initializer initializer)
        {
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
        }

        #region IConfigurableHttpClientInitializer

        public void Initialize(ConfigurableHttpClient httpClient)
        {
            httpClient.MessageHandler.ExecuteInterceptors.Add(this);
            httpClient.MessageHandler.UnsuccessfulResponseHandlers.Add(this);
        }

        #endregion

        #region IHttpExecuteInterceptor implementation

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

        #endregion

        #region IHttpUnsuccessfulResponseHandler

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

        #endregion

        /// <summary>Requests a new token.</summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if a new token was received successfully.</returns>
        public abstract Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken);
    }
}
