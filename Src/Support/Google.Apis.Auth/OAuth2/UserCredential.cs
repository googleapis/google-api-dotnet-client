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

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 credential for accessing protected resources using an access token, as well as optionally refreshing 
    /// the access token when it expires using a refresh token.
    /// </summary>
    public class UserCredential : IGoogleCredential, IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler
    {
        /// <summary>Logger for this class.</summary>
        protected static readonly ILogger Logger = ApplicationContext.Logger.ForType<UserCredential>();

        /// <summary>Gets or sets the token response which contains the access token.</summary>
        public TokenResponse Token
        {
            get => _refreshManager.Token;
            set => _refreshManager.Token = value;
        }

        /// <summary>Gets the authorization code flow.</summary>
        public IAuthorizationCodeFlow Flow { get; }

        /// <summary>Gets the user identity.</summary>
        public string UserId { get; }

        /// <inheritdoc/>
        public string QuotaProject { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => false;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => false;

        private readonly TokenRefreshManager _refreshManager;

        /// <summary>Constructs a new credential instance.</summary>
        /// <param name="flow">Authorization code flow.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">An initial token for the user.</param>
        public UserCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token)
            : this(flow, userId, token, null)
        { }

        /// <summary>Constructs a new credential instance.</summary>
        /// <param name="flow">Authorization code flow.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">An initial token for the user.</param>
        /// <param name="quotaProjectId">The ID of the project associated 
        /// to this credential for the purposes of quota calculation and billing. Can be null.</param>
        public UserCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token, string quotaProjectId)
        {
            Flow = flow;
            UserId = userId;
            _refreshManager = new TokenRefreshManager(RefreshTokenAsync, flow.Clock, Logger);
            Token = token;
            QuotaProject = quotaProjectId;
        }

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new UserCredential(Flow, UserId, Token, quotaProject);

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) => this;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(UserCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            Flow is IHttpAuthorizationFlow httpFlow
            ? new UserCredential(httpFlow.WithHttpClientFactory(httpClientFactory), UserId, Token, QuotaProject)
            : throw new InvalidOperationException($"{Flow.GetType().FullName} does not support an HTTP client factory to be set");

        #region IHttpExecuteInterceptor

        /// <summary>
        /// Default implementation is to try to refresh the access token if there is no access token or if we are 1 
        /// minute away from expiration. If token server is unavailable, it will try to use the access token even if 
        /// has expired. If successful, it will call <see cref="IAccessMethod.Intercept"/>.
        /// </summary>
        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken)
        {
            var accessToken = await GetAccessTokenWithHeadersForRequestAsync(request.RequestUri.AbsoluteUri, taskCancellationToken).ConfigureAwait(false);
            Flow.AccessMethod.Intercept(request, accessToken.AccessToken);
            accessToken.AddHeaders(request);
        }

        #endregion

        #region IHttpUnsuccessfulResponseHandler

        /// <inheritdoc/>
        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // TODO(peleyal): check WWW-Authenticate header.
            if (args.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return !Object.Equals(Token.AccessToken, Flow.AccessMethod.GetAccessToken(args.Request))
                    || await RefreshTokenAsync(args.CancellationToken).ConfigureAwait(false);
            }

            return false;
        }

        #endregion

        #region IConfigurableHttpClientInitializer

        /// <inheritdoc/>
        public void Initialize(ConfigurableHttpClient httpClient) =>
            httpClient.MessageHandler.Credential = this;

        #endregion

        #region ITokenAccess implementation
        /// <inheritdoc />
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

        /// <summary>
        /// Refreshes the token by calling to
        /// <see cref="Google.Apis.Auth.OAuth2.Flows.IAuthorizationCodeFlow.RefreshTokenAsync"/>.
        /// Then it updates the <see cref="TokenResponse"/> with the new token instance.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation.</param>
        /// <returns><c>true</c> if the token was refreshed.</returns>
        public async Task<bool> RefreshTokenAsync(CancellationToken taskCancellationToken)
        {
            if (Token.RefreshToken == null)
            {
                Logger.Warning("Refresh token is null, can't refresh the token!");
                return false;
            }

            // It's possible that two concurrent calls will be made to refresh the token, in that case the last one 
            // will win.
            var newToken = await Flow.RefreshTokenAsync(UserId, Token.RefreshToken, taskCancellationToken)
                .ConfigureAwait(false);

            Logger.Info("Access token was refreshed successfully");

            if (newToken.RefreshToken == null)
            {
                newToken.RefreshToken = Token.RefreshToken;
            }

            Token = newToken;
            return true;
        }

        /// <summary>
        /// Asynchronously revokes the token by calling
        /// <see cref="Google.Apis.Auth.OAuth2.Flows.IAuthorizationCodeFlow.RevokeTokenAsync"/>.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation.</param>
        /// <returns><c>true</c> if the token was revoked successfully.</returns>
        public async Task<bool> RevokeTokenAsync(CancellationToken taskCancellationToken)
        {
            if (Token == null)
            {
                Logger.Warning("Token is already null, no need to revoke it.");
                return false;
            }

            await Flow.RevokeTokenAsync(UserId, Token.AccessToken, taskCancellationToken).ConfigureAwait(false);
            Logger.Info("Access token was revoked successfully");
            // We don't set the token to null, cause we want that the next request (without reauthorizing) will fail).
            return true;
        }
    }
}
