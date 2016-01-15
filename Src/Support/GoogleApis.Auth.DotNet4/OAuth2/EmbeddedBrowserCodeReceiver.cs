/*
Copyright 2016 Google Inc

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
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 verification code receiver for Windows Phone that opens an embedded Google account form to enter the
    /// user's credentials and accepts the application access to its token.
    /// </summary>
    public class EmbeddedBrowserCodeReceiver : ICodeReceiver
    {
        #region ICodeReceiver Members

        public string RedirectUri
        {
            get { return GoogleAuthConsts.LocalhostRedirectUri; }
        }

        public async Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            // Create the web authentication user control and add it to the current window.
            var webAuthDialog = new AuthorizationDialog();
            try
            {
                return await webAuthDialog.Launch(url.Build());
            }
            finally
            {
                // TODO: Is any cleanup needed? Dialog should be able to close itself.
            }
        }

        #endregion
    }
}