using Google.Apis.Auth.OAuth2.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.WebUtilities;

namespace Google.Apis.Auth.OAuth2.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// An action filter which parses the query parameters into
    /// <see cref="AuthorizationCodeResponseUrl"/>.
    /// </summary>
    public class AuthorizationCodeActionFilter : ActionFilterAttribute
    {
        /// <summary>
        /// Parses the request into <see cref="AuthorizationCodeResponseUrl"/>.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            (actionContext.ActionArguments["authorizationCode"] as AuthorizationCodeResponseUrl)
                .ParseRequest(actionContext.HttpContext.Request);

            base.OnActionExecuting(actionContext);
        }
    }

    /// <summary>Auth extensions methods.</summary>
    public static class AuthExtensions
    {
        /// <summary>Parses the HTTP request query parameters into the Authorization code response.</summary>
        internal static void ParseRequest(this AuthorizationCodeResponseUrl authorizationCode, HttpRequest request)
        {
            var queryDic = QueryHelpers.ParseQuery(request.QueryString.ToString());
            authorizationCode.Code = queryDic["code"];
            authorizationCode.State = queryDic["state"];

            // if there is no error these are not present in the query string, check first
            if (queryDic.ContainsKey("error")) authorizationCode.Error = queryDic["error"];
            if (queryDic.ContainsKey("error_description")) authorizationCode.ErrorDescription = queryDic["error_description"];
            if (queryDic.ContainsKey("error_uri")) authorizationCode.ErrorUri = queryDic["error_uri"];
        }
    }
}
