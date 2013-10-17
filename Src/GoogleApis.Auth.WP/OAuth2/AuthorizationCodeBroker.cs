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
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver for WP that opens an embedded Google account form to enter the user's
    /// credentials and accepts the application access to its token.
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
            // TODO(peleyal): try to avoid await to await.
            return await (await Deployment.Current.Dispatcher.InvokeAsync(new Func<Task<AuthorizationCodeResponseUrl>>(
                () => ReceivedCodeCoreAsync(url, taskCancellationToken))));
        }

        #endregion

        /// <summary>
        /// The core logic for retrieving the authorization code. It MUST be called from the UI thread.
        /// </summary>
        /// <param name="url">The authorization code request URL.</param>
        /// <param name="taskCancellationToken">Cancellation token.</param>
        /// <returns>The authorization code response.</returns>
        private async Task<AuthorizationCodeResponseUrl> ReceivedCodeCoreAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            // Get the current window.
            PhoneApplicationFrame rootFrame = Application.Current.RootVisual as PhoneApplicationFrame;
            PhoneApplicationPage rootPage = rootFrame.Content as PhoneApplicationPage;
            UIElement currentLayout = rootPage.Content;

            // Create the web authentication user control and add it to the current window.
            var webAuthControl = new WebAuthenticationBrokerUserControl();
            var oauthLayout = new Grid
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            rootPage.Content = oauthLayout;
            oauthLayout.Children.Add(webAuthControl);

            try
            {
                return await webAuthControl.Launch(url.Build());
            }
            finally
            {
                // Change back to the old layout.
                webAuthControl.Visibility = Visibility.Collapsed;
                oauthLayout.Children.Remove(webAuthControl);
                rootPage.Content = currentLayout;
            }
        }
    }
}
