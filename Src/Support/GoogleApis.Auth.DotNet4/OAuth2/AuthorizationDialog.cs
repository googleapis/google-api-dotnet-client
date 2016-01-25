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

namespace Google.Apis.Auth.OAuth2
{
    public partial class AuthorizationDialog : Form
    {
        private AuthorizationCodeResponseUrl responseUrl;

        public AuthorizationCodeResponseUrl ResponseUrl
        {
            get
            {
                return responseUrl;
            }
        }

        /// <summary>Constructs a new authentication broker dialog.</summary>
        public AuthorizationDialog(Uri authUri)
        {
            InitializeComponent();
            // Set the browser to the initial uri.
            authWebBrowser.Navigate(authUri);
            // Need to track when the results has been received.
            authWebBrowser.DocumentCompleted += authWebBrowser_DocumentCompleted;
        }

        private void authWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // The code or the error should be received by localhost.
            if (e.Url.Host == "localhost")
            {
                var query = e.Url.Query.Substring(1);
                responseUrl = new AuthorizationCodeResponseUrl(query);
                // Dialog is no longer neeed.
                this.Close();
            }
        }
    }
}
