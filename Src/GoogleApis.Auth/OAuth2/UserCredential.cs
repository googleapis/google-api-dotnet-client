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
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 credential for accessing protected resources using an access token, as well as optionally refreshing 
    /// the access token when it expires using a refresh token.
    /// </summary>
    public class UserCredential : IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler,
        IConfigurableHttpClientInitializer
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<UserCredential>();

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

        private readonly IAuthorizationCodeFlow flow;
        private readonly string userId;

        /// <summary>Constructs a new credential instance.</summary>
        /// <param name="flow">Authorization code flow.</param>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">An initial token for the user.</param>
        public UserCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token)
        {
            this.flow = flow;
            this.userId = userId;
            this.token = token;
        }

        /// <summary>
        /// Default implementation is to try to refresh the access token if there is no access token or if we are 1 
        /// minute away from expiration. If token server is unavailable, it will try to use the access token even if 
        /// has expired. If successful, it will call <see cref="IAccessMethod.Intercept"/>.
        /// </summary>
        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken)
        {
            if (Token.IsExpired(flow.Clock))
            {
                Logger.Debug("Token has expired, trying to refresh it.");
                if (!await RefreshTokenAsync(taskCancellationToken).ConfigureAwait(false))
                {
                    throw new InvalidOperationException("The access token has expired but we can't refresh it");
                }
            }

            flow.AccessMethod.Intercept(request, Token.AccessToken);
        }

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
            var newToken = await flow.RefreshTokenAsync(userId, Token.RefreshToken, taskCancellationToken)
                .ConfigureAwait(false);

            Logger.Info("Access token was refreshed successfully");

            if (newToken.RefreshToken == null)
            {
                newToken.RefreshToken = Token.RefreshToken;
            }

            Token = newToken;
            return true;
        }

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // TODO(peleyal): check WWW-Authenticate header.
            if (args.Response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return !Object.Equals(Token.AccessToken, flow.AccessMethod.GetAccessToken(args.Request))
                    || await RefreshTokenAsync(args.CancellationToken).ConfigureAwait(false);
            }

            return false;
        }

        public void Initialize(ConfigurableHttpClient httpClient)
        {
            httpClient.MessageHandler.ExecuteInterceptors.Add(this);
            httpClient.MessageHandler.UnsuccessfulResponseHandlers.Add(this);
        }
    }
}
