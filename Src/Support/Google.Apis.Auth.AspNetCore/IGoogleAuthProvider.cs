/*
Copyright 2018 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore
{
    /// <summary>
    /// Provides access to Google auth credentials and scopes.
    /// </summary>
    public interface IGoogleAuthProvider
    {
        /// <summary>
        /// Get a <see cref="GoogleCredential"/> for the current user.
        /// This is a short-term non-refreshable credential; do not store it for later use.
        /// </summary>
        /// <param name="accessTokenRefreshWindow">
        /// Optional. The duration that must be remaining on the oauth access token.
        /// If not specified then will use the default of 5 minutes.
        /// </param>
        /// <param name="cancellationToken">Optional. Token to allow cancellation.</param>
        /// <returns></returns>
        Task<GoogleCredential> GetCredentialAsync(TimeSpan? accessTokenRefreshWindow = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the currently authorized Google scopes.
        /// </summary>
        /// <returns>A list of all currently authorized Google scopes.</returns>
        Task<IReadOnlyList<string>> GetCurrentScopesAsync();
    }
}
