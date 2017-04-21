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

using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Flows;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Authorization code flow for an installed application that persists end-user credentials.
    /// </summary>
    public interface IAuthorizationCodeInstalledApp
    {
        /// <summary>Gets the authorization code flow.</summary>
        IAuthorizationCodeFlow Flow { get; }

        /// <summary>Gets the code receiver.</summary>
        ICodeReceiver CodeReceiver { get; }

        /// <summary>Asynchronously authorizes the installed application to access user's protected data.</summary>
        /// <param name="userId">User identifier</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation</param>
        /// <returns>The user's credential</returns>
        Task<UserCredential> AuthorizeAsync(string userId, CancellationToken taskCancellationToken);
    }
}
