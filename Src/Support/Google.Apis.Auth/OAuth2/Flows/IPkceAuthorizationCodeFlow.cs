/*
Copyright 2023 Google Inc

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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Authorization flow that supports Proof Key for Code Exchange (PKCE)
    /// as described in https://www.rfc-editor.org/rfc/rfc7636.
    /// </summary>
    /// <remarks>
    /// If you are writing your own authorization flow to be used with <see cref="AuthorizationCodeInstalledApp"/>
    /// make sure you implement this interface if you need to support PKCE.
    /// See https://developers.google.com/identity/protocols/oauth2/native-app for how Google supports PKCE.
    /// </remarks>
    public interface IPkceAuthorizationCodeFlow : IAuthorizationCodeFlow
    {
        /// <summary>
        /// Creates an authorization code request with the specified redirect URI.
        /// </summary>
        /// <param name="redirectUri">
        /// The redirect URI for the authorization code request.
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier associated to the code challenge that should be included
        /// in the returned <see cref="AuthorizationCodeRequestUrl"/>. Note this is an <code>out</code> parameter.
        /// </param>
        /// <returns>An <see cref="AuthorizationCodeRequestUrl"/> subclass instance that includes the code challenge
        /// and code challenge method associated with <paramref name="codeVerifier"/>.</returns>
        AuthorizationCodeRequestUrl CreateAuthorizationCodeRequest(string redirectUri, out string codeVerifier);

        /// <summary>Asynchronously exchanges an authorization code for an access token.</summary>
        /// <param name="userId">User identifier.</param>
        /// <param name="code">Authorization code received from the authorization server.</param>
        /// <param name="codeVerifier">
        /// The PKCE code verifier to include in the exchange request.
        /// When called by the authentication library, this will be the same value specified by the
        /// <code>codeVerifier</code> out parameter in an earlier call to CreateAuthorizationCodeRequest.
        /// </param>
        /// <param name="redirectUri">Redirect URI which is used in the token request.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>Token response which contains the access token.</returns>
        Task<TokenResponse> ExchangeCodeForTokenAsync(string userId, string code, string codeVerifier, string redirectUri, CancellationToken taskCancellationToken);
    }
}
