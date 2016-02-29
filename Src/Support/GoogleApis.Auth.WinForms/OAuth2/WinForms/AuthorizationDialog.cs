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
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2.WinForms
{
    public partial class AuthorizationDialog : Form
    {
        /// <summary>
        /// The response from the authorization service when the user clicks Accept or Deny.
        /// </summary>
        /// <remarks>Will be null if the user has not clicked Accept or Deny.</remarks>
        public AuthorizationCodeResponseUrl ResponseUrl { get; protected set; }

        /// <summary>Constructs a new authentication broker dialog and navigates to
        /// the authorization page. From there, the user has control to choose Accept or Deny
        /// via the dialog's embedded web browser.</summary>
        public AuthorizationDialog(Uri authUri)
        {
            InitializeComponent();
            // Set the browser to the initial uri.
            authWebBrowser.Navigate(authUri);
            // Need to track when the results has been received.
            // Installed applications use an out-of-band redirect URI.
            // When the user clicks Accept or Deny, the redirected response will
            // be in the title of the web page.
            authWebBrowser.DocumentTitleChanged += authWebBrowser_TitleChanged;
        }

        private void authWebBrowser_TitleChanged(object sender, EventArgs e)
        {
            // The result always comes back 
            var browser = (WebBrowser)sender;
            if (browser.Url.AbsolutePath == new Uri( GoogleAuthConsts.ApprovalUrl).AbsolutePath)
            {
                // Per API documentation, the reponse is after the first space in the title.
                var query = browser.DocumentTitle.Substring(browser.DocumentTitle.IndexOf(" ") + 1);
                ResponseUrl = new AuthorizationCodeResponseUrl(query);
                // Dialog is no longer neeed.
                this.Close();
            }
            else
                System.Diagnostics.Trace.TraceInformation(browser.Url.AbsolutePath);
        }
    }
}
