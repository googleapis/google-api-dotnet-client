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

namespace Google.Apis.Auth.OAuth2.Requests
{
    /// <summary>
    /// Google-specific implementation of the OAuth 2.0 URL for an authorization web page to allow the end user to 
    /// authorize the application to access their protected resources and that returns an authorization code, as 
    /// specified in https://developers.google.com/accounts/docs/OAuth2WebServer.
    /// </summary>
    public class GoogleAuthorizationCodeRequestUrl : AuthorizationCodeRequestUrl
    {
        /// <summary>
        /// Gets or sets the access type. Set <c>online</c> to request on-line access or <c>offline</c> to request 
        /// off-line access or <c>null</c> for the default behavior. The default value is <c>offline</c>.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("access_type", Google.Apis.Util.RequestParameterType.Query)]
        public string AccessType { get; set; }

        /// <summary>
        /// Gets pr sets prompt for consent behavior <c>auto</c> to request auto-approval or<c>force</c> to force the 
        /// approval UI to show, or <c>null</c> for the default behavior.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("approval_prompt", Google.Apis.Util.RequestParameterType.Query)]
        public string ApprovalPrompt { get; set; }

        /// <summary>
        /// Gets or sets the login hint. Sets <c>email address</c> or sub <c>identifier</c>.
        /// When your application knows which user it is trying to authenticate, it may provide this parameter as a
        /// hint to the Authentication Server. Passing this hint will either pre-fill the email box on the sign-in form
        /// or select the proper multi-login session, thereby simplifying the login flow.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("login_hint", Google.Apis.Util.RequestParameterType.Query)]
        public string LoginHint { get; set; }

        /// <summary>
        /// Constructs a new authorization code request with the given authorization server URL. This constructor sets
        /// the <see cref="AccessType"/> to <c>offline</c>.
        /// </summary>
        public GoogleAuthorizationCodeRequestUrl(Uri authorizationServerUrl)
            : base(authorizationServerUrl)
        {
            AccessType = "offline";
        }
    }
}