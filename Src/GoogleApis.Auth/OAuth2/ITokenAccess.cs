/*
Copyright 2015 Google Inc

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

using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Allows direct retrieval of access tokens to authenticate requests.
    /// This is necessary for workflows where you don't want to use 
    /// <see cref="T:Google.Apis.Services.BaseClientService"/> to access the API.
    /// (e.g. gRPC that implemenents the entire HTTP2 stack internally).
    /// </summary>
    public interface ITokenAccess
    {
        /// <summary>
        /// Gets an access token to authorize a request.
        /// Implementations should handle automatic refreshes of the token
        /// if they are supported.
        /// The <paramref name="authUri"/> might be required by some credential types
        /// (e.g. the JWT access token) while other credential types
        /// migth just ignore it.
        /// </summary>
        /// <param name="authUri">The URI the returned token will grant access to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The access token.</returns>
        Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
