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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>OAuth 2.0 verification code receiver.</summary>
    public interface ICodeReceiver
    {
        /// <summary>Gets the redirected URI.</summary>
        string RedirectUri { get; }

        /// <summary>Receives the authorization code.</summary>
        /// <param name="url">The authorization code request URL</param>
        /// <param name="taskCancellationToken">Cancellation token</param>
        /// <returns>The authorization code response</returns>
        Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken);
    }
}