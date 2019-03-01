/*
Copyright 2018 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore
{
    internal class GoogleScopedAuthorizationHandler : AuthorizationHandler<GoogleScopedRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, GoogleScopedRequirement requirement)
        {
            // Check this is an MVC application, and retrieve the MVC filter context.
            var resource = context.Resource as AuthorizationFilterContext;
            if (resource == null)
            {
                // Not an MVC application, nothing we can do.
                return;
            }
            var httpContext = resource.HttpContext;
            // Ask the auth storage provider, usually cookies, for the users signed-in data; if the user is signed in.
            AuthenticateResult auth = await httpContext.AuthenticateAsync(requirement.Scheme);
            var authed = auth.Succeeded && !auth.None;
            // Mark this requirement as succeeded; this is true whether we need to auth or not.
            context.Succeed(requirement);
            // Determine if any scopes still require authorization.
            var existingScope = authed && auth.Properties.Items.TryGetValue(Consts.ScopeName, out var existingScope0) ? existingScope0 : "";
            var existingScopes = existingScope.Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
            var additionalScopes = requirement.Scopes.Except(existingScopes).ToList();
            if (additionalScopes.Any() || !authed)
            {
                resource.Result = CreateChallenge(resource.HttpContext, additionalScopes, requirement.Scheme);
            }
        }

        internal static IActionResult CreateChallenge(HttpContext httpContext, IEnumerable<string> additionalScopes, string scheme)
        {
            // Store the additional scopes required in the HttpContext.
            httpContext.Items[Consts.HttpContextAdditionalScopeName] = string.Join(" ", additionalScopes);
            // Return challenge, to [re]authenticate.
            return new ChallengeResult(scheme);
        }
    }
}
