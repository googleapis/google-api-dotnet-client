using Google.Apis.Auth.OAuth2.Flows;
using Microsoft.AspNetCore.Mvc;

namespace Google.Apis.Auth.OAuth2.AspNetCore.Mvc
{
    /// <summary>
    /// Flow metadata abstract class which contains the reference to the
    /// <see cref="IAuthorizationCodeFlow"/> and
    /// method to get the user identifier.
    /// </summary>
    public abstract class FlowMetadata
    {
        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        /// <param name="controller">The controller</param>
        /// <returns>User identifier</returns>
        public abstract string GetUserId(Controller controller);

        /// <summary>Gets the authorization code flow.</summary>
        public abstract IAuthorizationCodeFlow Flow { get; }

        /// <summary>
        /// Gets the authorization application's call back. That relative URL will handle the authorization code 
        /// response.
        /// </summary>
        public virtual string AuthCallback
        {
            get { return @"/AuthCallback"; }
        }
    }
}
