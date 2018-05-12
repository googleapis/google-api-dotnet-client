using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.Web;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Google.Apis.Auth.OAuth2.AspNetCore.Mvc
{
    /// <summary>
    /// Thread-safe OAuth 2.0 authorization code flow for a MVC web application that persists end-user credentials.
    /// </summary>
    public class AuthorizationCodeMvcApp : AuthorizationCodeWebApp
    {
        /// <summary>Gets the controller which is the owner of this authorization code MVC app instance.</summary>
        public Controller Controller { get; }

        /// <summary>Gets the <see cref="FlowMetadata"/> object.</summary>
        public FlowMetadata FlowData { get; }

        /// <summary>Constructs a new authorization code MVC app using the given controller and flow data.</summary>
        public AuthorizationCodeMvcApp(Controller controller, FlowMetadata flowData)
            : base(
            flowData.Flow,
            new Uri($"{controller.Request.Scheme}://{controller.Request.Host}{flowData.AuthCallback}").ToString(),
            controller.Request.GetDisplayUrl())
        {
            Controller = controller;
            FlowData = flowData;
        }

        /// <summary>
        /// Asynchronously authorizes the installed application to access user's protected data. It gets the user 
        /// identifier by calling to <see cref="FlowMetadata.GetUserId"/> and then calls to
        /// <see cref="AuthorizationCodeWebApp.AuthorizeAsync"/>.
        /// </summary>
        /// <param name="taskCancellationToken">Cancellation token to cancel an operation</param>
        /// <returns>
        /// Auth result object which contains the user's credential or redirect URI for the authorization server
        /// </returns>
        public async Task<AuthResult> AuthorizeAsync(CancellationToken taskCancellationToken)
        {
            return await base.AuthorizeAsync(FlowData.GetUserId(Controller), taskCancellationToken);
        }
    }
}
