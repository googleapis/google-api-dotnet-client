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
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Util;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>OAuth 2.0 authorization code flow that manages and persists end-user credentials.</summary>
    public interface IAuthorizationCodeFlow : IDisposable
    {
        /// <summary>Gets the method for presenting the access token to the resource server.</summary>
        IAccessMethod AccessMethod { get; }

        /// <summary>Gets the clock.</summary>
        IClock Clock { get; }

        /// <summary>Gets the data store used to store the credentials.</summary>
        IDataStore DataStore { get; }

        /// <summary>
        /// Asynchronously loads the user's token using the flow's
        /// <see cref="Google.Apis.Util.Store.IDataStore"/>.
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation</param>
        /// <returns>Token response</returns>
        Task<TokenResponse> LoadTokenAsync(string userId, CancellationToken taskCancellationToken);

        /// <summary>
        /// Asynchronously deletes the user's token using the flow's
        /// <see cref="Google.Apis.Util.Store.IDataStore"/>.
        /// </summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        Task DeleteTokenAsync(string userId, CancellationToken taskCancellationToken);

        /// <summary>Creates an authorization code request with the specified redirect URI.</summary>
        AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri);

        /// <summary>Asynchronously exchanges code with a token.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="code">Authorization code received from the authorization server.</param>
        /// <param name="redirectUri">Redirect URI which is used in the token request.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>Token response which contains the access token.</returns>
        Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string redirectUri,
            CancellationToken taskCancellationToken);

        /// <summary>Asynchronously refreshes an access token using a refresh token.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="refreshToken">Refresh token which is used to get a new access token.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>Token response which contains the access token and the input refresh token.</returns>
        Task<TokenResponse> RefreshTokenAsync(string userId, string refreshToken,
            CancellationToken taskCancellationToken);

        /// <summary>
        /// Asynchronously revokes the specified token. This method disconnects the user's account from the OAuth 2.0
        /// application. It should be called upon removing the user account from the site.</summary>
        /// <remarks>
        /// If revoking the token succeeds, the user's credential is removed from the data store and the user MUST
        /// authorize the application again before the application can access the user's private resources.
        /// </remarks>
        /// <param name="userId">User identifier.</param>
        /// <param name="token">Access token to be revoked.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns><c>true</c> if the token was revoked successfully.</returns>        
        Task RevokeTokenAsync(string userId, string token, CancellationToken taskCancellationToken);

        /// <summary>
        /// Indicates if a new token needs to be retrieved and stored regardless of normal circumstances.
        /// </summary>
        bool ShouldForceTokenRetrieval();
    }
}
