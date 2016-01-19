using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <summary> Constructs a new authentication broker dialog. </summary>
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
