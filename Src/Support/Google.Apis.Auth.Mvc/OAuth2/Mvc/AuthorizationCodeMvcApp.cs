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
using System.Web.Mvc;

using Google.Apis.Auth.OAuth2.Web;

namespace Google.Apis.Auth.OAuth2.Mvc
{
    /// <summary>
    /// Thread-safe OAuth 2.0 authorization code flow for a MVC web application that persists end-user credentials.
    /// </summary>
    public class AuthorizationCodeMvcApp : AuthorizationCodeWebApp
    {
        // TODO(peleyal): we should also follow the MVC framework Authorize attribute

        private readonly Controller controller;
        private readonly FlowMetadata flowData;

        /// <summary>Gets the controller which is the owner of this authorization code MVC app instance.</summary>
        public Controller Controller { get { return controller; } }

        /// <summary>Gets the <see cref="Google.Apis.Auth.OAuth2.Mvc.FlowMetadata"/> object.</summary>
        public FlowMetadata FlowData { get { return flowData; } }

        /// <summary>Constructs a new authorization code MVC app using the given controller and flow data.</summary>
        public AuthorizationCodeMvcApp(Controller controller, FlowMetadata flowData)
            : base(
            flowData.Flow,
            new Uri(controller.Request.Url.GetLeftPart(UriPartial.Authority) + flowData.AuthCallback).ToString(),
            controller.Request.Url.ToString())
        {
            this.controller = controller;
            this.flowData = flowData;
        }

        /// <summary>
        /// Asynchronously authorizes the installed application to access user's protected data. It gets the user 
        /// identifier by calling to <see cref="Google.Apis.Auth.OAuth2.Mvc.FlowMetadata.GetUserId"/> and then calls to
        /// <see cref="Google.Apis.Auth.OAuth2.Web.AuthorizationCodeWebApp.AuthorizeAsync"/>.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation</param>
        /// <returns>
        /// Auth result object which contains the user's credential or redirect URI for the authorization server
        /// </returns>
        public Task<AuthResult> AuthorizeAsync(CancellationToken taskCancellationToken)
        {
            return base.AuthorizeAsync(FlowData.GetUserId(Controller), taskCancellationToken);
        }
    }
}
