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
using System;
using System.Linq;
using System.Threading.Tasks;

#if ASPNETCORE3
namespace Google.Apis.Auth.AspNetCore3
#else
namespace Google.Apis.Auth.AspNetCore
#endif
{
    internal class GoogleScopedAuthorizationHandler : AuthorizationHandler<GoogleScopedRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GoogleScopedAuthorizationHandler(IHttpContextAccessor httpContextAccessor) =>
            _httpContextAccessor = httpContextAccessor;

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, GoogleScopedRequirement requirement)
        {
            var httpContext = _httpContextAccessor.HttpContext;

            // Ask the auth storage provider, usually cookies, for the users signed-in data; if the user is signed in.
            AuthenticateResult auth = await httpContext.AuthenticateAsync(requirement.Scheme);
            var authed = auth.Succeeded && !auth.None;
            
            // Determine if any scopes still require authorization.
            var existingScope = authed && auth.Properties.Items.TryGetValue(Consts.ScopeName, out var existingScope0) ? existingScope0 : "";
            var existingScopes = existingScope.Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
            var additionalScopes = requirement.Scopes.Except(existingScopes).ToList();
            if (!authed || additionalScopes.Any())
            {
                // Add the missing scopes to the HttpContext.
                // Since we don't succeed here, authorization will fail with Forbidden. On Forbid,
                // we used these to determine whether we need to do incrementatl auth and Challenge
                // or really Forbid.
                httpContext.Items[Consts.HttpContextAdditionalScopeName] = string.Join(" ", additionalScopes);
            }
            else
            {
                context.Succeed(requirement);
            }
        }
    }
}
