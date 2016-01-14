/*
Copyright 2014 Google Inc

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
using Windows.Security.Authentication.Web;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver for Windows Phone 8.1 application that opens a Google account form so the
    /// users can enter their credentials and accept the application access to their token.
    /// 
    /// This broker's most important method is
    /// <see cref="ReceiveCodeAsync(AuthorizationCodeRequestUrl,CancellationToken)"/>.
    /// The first time it is being called, it calls <code>WebAuthenticationBroker.AuthenticateAndContinue</code>
    /// so the users can authorize the app to access their private resources. While calling this method the app is
    /// suspended.
    /// 
    /// When the app is being activated again, the developer MUST store the auth result (which may contain the access
    /// code or an error) in the storage with the <code>SerializableWebAuthResult.Name</code> key.
    /// Then when the auth framework calls again the
    /// <see cref="ReceiveCodeAsync(AuthorizationCodeRequestUrl,CancellationToken)"/> it looks in the storage to find
    /// the auth result, and if a code was received the framework will convert it in turn to access and refresh tokens.
    /// </summary>
    public class AuthorizationCodeBroker : ICodeReceiver
    {
        #region ICodeReceiver Members

        public string RedirectUri
        {
            get { return GoogleAuthConsts.LocalhostRedirectUri; }
        }

        public async Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            TaskCompletionSource<AuthorizationCodeResponseUrl> tcs =
                new TaskCompletionSource<AuthorizationCodeResponseUrl>();
            await ReceiveCodeAsync(url, tcs);
            return tcs.Task.Result;
        }

        #endregion

        private async Task InvokeFromUIThread(Action action)
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () => action());
        }

        /// <summary>Asynchronously receives the authorization code.</summary>
        /// <param name="url">The authorization code request URL.</param>
        /// <param name="tcs">Task completion source whose result will be set to the authorization code.</param>
        private async Task ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            TaskCompletionSource<AuthorizationCodeResponseUrl> tcs)
        {
            var result = await PasswordVaultDataStore.Default.GetAsync<SerializableWebAuthResult>(
                SerializableWebAuthResult.Name);
            if (result == null)
            {
                // We should run WebAuthenticationBroker.AuthenticateAndContinue from the UI thread ONLY.
                await InvokeFromUIThread(() => WebAuthenticationBroker.AuthenticateAndContinue(url.Build(),
                    new Uri(GoogleAuthConsts.LocalhostRedirectUri), null, WebAuthenticationOptions.None));
                
                // No need to return anything, cause the application is going to be suspended now.
                return;
            }

            const string Code = "code=";
            const string Error = "error=";
            // Get the index of the error or the code.
            var index = result.ResponseData.IndexOf(Code);
            index = index != -1 ? index : result.ResponseData.IndexOf(Error);

            if (index != -1)
            {
                tcs.SetResult(new AuthorizationCodeResponseUrl(result.ResponseData.Substring(index)));
                return;
            }

            tcs.SetException(new TokenResponseException(
                new TokenErrorResponse
                {
                    Error = result.ResponseStatus.ToString(),
                    ErrorDescription = "The WebAuthenticationBroker didn't return a code or an error. Details: " +
                        result.ResponseErrorDetail,
                }));
        }
    }
}