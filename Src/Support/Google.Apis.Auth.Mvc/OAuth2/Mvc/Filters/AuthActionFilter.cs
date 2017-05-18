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

using System.Web;
using System.Web.Mvc;

using Google.Apis.Auth.OAuth2.Responses;

namespace Google.Apis.Auth.OAuth2.Mvc.Filters
{
    /// <summary>
    /// An action filter which parses the query parameters into
    /// <see cref="Google.Apis.Auth.OAuth2.Responses.AuthorizationCodeResponseUrl"/>.
    /// </summary>
    public class AuthorizationCodeActionFilter : ActionFilterAttribute, IActionFilter
    {
        /// <summary>
        /// Parses the request into <see cref="Google.Apis.Auth.OAuth2.Responses.AuthorizationCodeResponseUrl"/>.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            (actionContext.ActionParameters["authorizationCode"] as AuthorizationCodeResponseUrl)
                .ParseRequest(actionContext.RequestContext.HttpContext.Request);

            base.OnActionExecuting(actionContext);
        }
    }

    /// <summary>Auth extensions methods.</summary>
    public static class AuthExtensions
    {
        /// <summary>Parses the HTTP request query parameters into the Authorization code response.</summary>
        internal static void ParseRequest(this AuthorizationCodeResponseUrl authorizationCode, HttpRequestBase request)
        {
            var queryDic = HttpUtility.ParseQueryString(request.Url.Query);
            authorizationCode.Code = queryDic["code"];
            authorizationCode.Error = queryDic["error"];
            authorizationCode.ErrorDescription = queryDic["error_description"];
            authorizationCode.ErrorUri = queryDic["error_uri"];
            authorizationCode.State = queryDic["state"];
        }
    }
}
