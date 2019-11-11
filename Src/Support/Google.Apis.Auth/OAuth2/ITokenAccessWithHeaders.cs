/*
Copyright 2019 Google Inc

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

using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Allows direct retrieval of access tokens to authenticate requests.
    /// The access tokens obtained can be accompanied by extra information 
    /// that either describes the access token or is associated with it.
    /// This information should acompany the token as headers when the token
    /// is used to access a resource.
    /// </summary>
    public interface ITokenAccessWithHeaders : ITokenAccess
    {
        /// <summary>
        /// Gets an access token to authorize a request.
        /// The token might be accompanied by extra information that should be sent
        /// in the form of headers.
        /// Implementations should handle automatic refreshes of the token
        /// if they are supported.
        /// The <paramref name="authUri"/> might be required by some credential types
        /// (e.g. the JWT access token) while other credential types
        /// migth just ignore it.
        /// </summary>
        /// <param name="authUri">The URI the returned token will grant access to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The access token with headers if any.</returns>
        Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
