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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Mvc.Filters;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Web;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2.Mvc.Controllers
{
    /// <summary>
    /// Auth callback to process the authorization code or error response from the authorization redirect page.
    /// </summary>
    [AuthorizationCodeActionFilter]
    public abstract class AuthCallbackController : Controller
    {
        /// <summary>Logger for this class.</summary>
        protected static readonly ILogger Logger = ApplicationContext.Logger.ForType<AuthCallbackController>();

        /// <summary>Gets the authorization code flow.</summary>
        protected IAuthorizationCodeFlow Flow { get { return FlowData.Flow; } }

        /// <summary>
        /// Gets the user identifier. Potential logic is to use session variables to retrieve that information.
        /// </summary>
        protected string UserId { get { return FlowData.GetUserId(this); } }

        #region Abstract and Virtual Members

        /// <summary>Gets the flow data which contains </summary>
        protected abstract FlowMetadata FlowData { get; }

        /// <summary>
        /// A callback which gets the error when this controller didn't receive an authorization code. The default 
        /// implementation throws a <see cref="Google.Apis.Auth.OAuth2.Responses.TokenResponseException"/>.
        /// </summary>
        protected virtual ActionResult OnTokenError(TokenErrorResponse errorResponse)
        {
            throw new TokenResponseException(errorResponse);
        }

        /// <summary>
        /// The authorization callback which receives an authorization code which contains an error or a code.
        /// If a code is available the method exchange the coed with an access token and redirect back to the original
        /// page which initialized the auth process (using the state parameter).
        /// <para>
        /// The current timeout is set to 10 seconds. You can change the default behavior by setting 
        /// <see cref="System.Web.Mvc.AsyncTimeoutAttribute"/> with a different value on your controller.
        /// </para>
        /// </summary>
        /// <param name="authorizationCode">Authorization code response which contains the code or an error.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>
        /// Redirect action to the state parameter or <see cref="OnTokenError"/> in case of an error.
        /// </returns>
        [AsyncTimeout(10000)]
        public async virtual Task<ActionResult> IndexAsync(AuthorizationCodeResponseUrl authorizationCode,
            CancellationToken taskCancellationToken)
        {
            if (string.IsNullOrEmpty(authorizationCode.Code))
            {
                var errorResponse = new TokenErrorResponse(authorizationCode);
                Logger.Info("Received an error. The response is: {0}", errorResponse);

                return OnTokenError(errorResponse);
            }

            Logger.Debug("Received \"{0}\" code", authorizationCode.Code);

            var returnUrl = Request.Url.ToString();
            returnUrl = returnUrl.Substring(0, returnUrl.IndexOf("?"));

            var token = await Flow.ExchangeCodeForTokenAsync(UserId, authorizationCode.Code, returnUrl,
                taskCancellationToken).ConfigureAwait(false);

            // Extract the right state.
            var oauthState = await AuthWebUtility.ExtracRedirectFromState(Flow.DataStore, UserId,
                authorizationCode.State).ConfigureAwait(false);

            return new RedirectResult(oauthState);
        }

        #endregion
    }
}
