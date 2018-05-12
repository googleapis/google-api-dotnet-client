using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.AspNetCore.Mvc.Filters;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Web;
using Google.Apis.Logging;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Google.Apis.Auth.OAuth2.AspNetCore.Mvc.Controllers
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
        /// </summary>
        /// <param name="authorizationCode">Authorization code response which contains the code or an error.</param>
        /// <param name="taskCancellationToken">Cancellation token to cancel operation.</param>
        /// <returns>
        /// Redirect action to the state parameter or <see cref="OnTokenError"/> in case of an error.
        /// </returns>
        public virtual async Task<ActionResult> IndexAsync(AuthorizationCodeResponseUrl authorizationCode,
            CancellationToken taskCancellationToken)
        {
            if (string.IsNullOrEmpty(authorizationCode.Code))
            {
                var errorResponse = new TokenErrorResponse(authorizationCode);
                Logger.Info("Received an error. The response is: {0}", errorResponse);

                return OnTokenError(errorResponse);
            }

            Logger.Debug("Received \"{0}\" code", authorizationCode.Code);

            var returnUrl = Request.GetDisplayUrl();
            returnUrl = returnUrl.Substring(0, returnUrl.IndexOf("?", StringComparison.Ordinal));

            await Flow.ExchangeCodeForTokenAsync(UserId, authorizationCode.Code, returnUrl,
                taskCancellationToken).ConfigureAwait(false);

            // Extract the right state.
            var oauthState = await AuthWebUtility.ExtracRedirectFromState(Flow.DataStore, UserId,
                authorizationCode.State).ConfigureAwait(false);

            return new RedirectResult(oauthState);
        }

        #endregion
    }
}
