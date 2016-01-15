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
        TaskCompletionSource<AuthorizationCodeResponseUrl> tcsAuthorizationCodeResponse;

        public AuthorizationDialog()
        {
            InitializeComponent();
            authWebBrowser.Navigating += authWebBrowser_Navigating;
            this.FormClosing += AuthorizationDialog_FormClosing;
        }

        void AuthorizationDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the task was not completed, it should be marked as canceled.
            if (tcsAuthorizationCodeResponse != null && tcsAuthorizationCodeResponse.Task.Result == null)
            {
                tcsAuthorizationCodeResponse.SetCanceled();
            }
                   
        }


        void authWebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // The code or the error should be received by localhost.
            if (e.Url.Host == "localhost")
            {
                var query = e.Url.Query.Substring(1);
                tcsAuthorizationCodeResponse.SetResult(new AuthorizationCodeResponseUrl(query));
                // Dialog is no longer neeed.
                this.Close();
            }
        }

        /// <summary>The window launcher that starts browse the browser controller to the given URI.</summary>
        /// <param name="uri">The authorization code request URI</param>
        /// <returns>The authorization code response</returns>
        public Task<AuthorizationCodeResponseUrl> Launch(Uri uri)
        {
            tcsAuthorizationCodeResponse = new TaskCompletionSource<AuthorizationCodeResponseUrl>();
            authWebBrowser.Navigate(uri);
            this.Show();
            return tcsAuthorizationCodeResponse.Task;
        }
    }
}
