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

using Microsoft.Phone.Controls;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Web authentication broker user control for retrieving <seealso cref="AuthorizationCodeResponseUrl"/>
    /// </summary>
    internal partial class WebAuthenticationBrokerUserControl : UserControl
    {
        TaskCompletionSource<AuthorizationCodeResponseUrl> tcsAuthorizationCodeResponse;

        /// <summary>Constructs a new authentication broker user control.</summary>
        public WebAuthenticationBrokerUserControl()
        {
            InitializeComponent();
        }

        /// <summary>Displays the loading animation.</summary>
        private void StartLoading()
        {
            Loader.Visibility = Visibility.Visible;
        }

        /// <summary>Removes the loading animation.</summary>
        private void StopLoading()
        {
            Loader.Visibility = Visibility.Collapsed;
        }

        /// <summary>Callback of browser navigating.</summary>
        private void OnBrowserNavigating(object sender, NavigatingEventArgs e)
        {
            // The code or the error should be received by localhost.
            if (e.Uri.Host == "localhost")
            {
                var query = e.Uri.Query.Substring(1);
                tcsAuthorizationCodeResponse.SetResult(new AuthorizationCodeResponseUrl(query));
            }
        }

        /// <summary>Callback of browser navigation failed.</summary>
        private void OnBrowserNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (!tcsAuthorizationCodeResponse.Task.IsCompleted)
            {
                tcsAuthorizationCodeResponse.SetException(e.Exception);
            }
        }

        /// <summary>Callback of browser navigated.</summary>
        private void OnBrowserNavigated(object sender, NavigationEventArgs e)
        {
            StopLoading();
        }

        /// <summary>The window launcher that starts browse the browser controller to the given URI.</summary>
        /// <param name="uri">The authorization code request URI</param>
        /// <returns>The authorization code response</returns>
        public Task<AuthorizationCodeResponseUrl> Launch(Uri uri)
        {
            tcsAuthorizationCodeResponse = new TaskCompletionSource<AuthorizationCodeResponseUrl>();
            StartLoading();
            browser.Navigate(uri);
            return tcsAuthorizationCodeResponse.Task;
        }
    }
}
