/*
Copyright 2020 Google Inc

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
using Google.Apis.Util;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents an OIDC Token.
    /// </summary>
    public sealed class OidcToken
    {
        private readonly TokenRefreshManager _refreshManager;

        /// <summary>
        /// The <see cref="TokenResponse"/> this OIDC token is built from.
        /// </summary>
        internal TokenResponse TokenResponse { get => _refreshManager.Token; }

        internal OidcToken(TokenRefreshManager refreshManager) =>
            _refreshManager = refreshManager.ThrowIfNull(nameof(refreshManager));

        /// <summary>
        /// Gets the access token that should be included in headers when performing
        /// requests with this <see cref="OidcToken"/>.
        /// This method will refresh the access token if the current one has expired.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to use for cancelling the operation.</param>
        /// <returns>The valid access token associated to this <see cref="OidcToken"/>.</returns>
        public Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default) =>
            _refreshManager.GetAccessTokenForRequestAsync(cancellationToken);
    }
}