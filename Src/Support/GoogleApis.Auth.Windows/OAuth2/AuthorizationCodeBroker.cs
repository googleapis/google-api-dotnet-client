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
using Windows.Security.Authentication.Web;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver for Windows 8 application that opens an embedded Google account form to 
    /// enter the user's credentials and accepts the application access to its token.
    /// </summary>
    public class AuthorizationCodeBroker : ICodeReceiver
    {
        #region ICodeReceiver Members

        public string RedirectUri
        {
            get { return GoogleAuthConsts.InstalledAppRedirectUri; }
        }

        public async Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            TaskCompletionSource<AuthorizationCodeResponseUrl> tcs =
                new TaskCompletionSource<AuthorizationCodeResponseUrl>();

            // We should run WebAuthenticationBroker from the UI thread.
            await InvokeFromUIThread(async () => await ReceiveCodeAsync(url, tcs));
            return tcs.Task.Result;
        }

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
            const string Code = "code=";
            const string Error = "error=";
            try
            {
                WebAuthenticationResult result = await WebAuthenticationBroker.AuthenticateAsync
                    (WebAuthenticationOptions.UseTitle, url.Build(), new Uri(GoogleAuthConsts.ApprovalUrl));

                if (!string.IsNullOrEmpty(result.ResponseData))
                {
                    // Get the index of the error or the code.
                    var index = result.ResponseData.IndexOf(Code);
                    index = index != -1 ? index : result.ResponseData.IndexOf(Error);

                    if (index != -1)
                    {
                        tcs.SetResult(new AuthorizationCodeResponseUrl(result.ResponseData.Substring(index)));
                        return;
                    }
                }

                tcs.SetException(new TokenResponseException(
                    new TokenErrorResponse
                    {
                        Error = result.ResponseStatus.ToString(),
                        ErrorDescription = "The WebAuthenticationBroker didn't return a code or an error. Details:" +
                            result.ResponseErrorDetail,
                    }));
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }
        }

        #endregion
    }
}