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
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

#if ASPNETCORE3
namespace Google.Apis.Auth.AspNetCore3
#else
namespace Google.Apis.Auth.AspNetCore
#endif
{
    internal class GoogleOpenIdConnectHandler : OpenIdConnectHandler
    {
        public GoogleOpenIdConnectHandler(
            IOptionsMonitor<OpenIdConnectOptions> options, ILoggerFactory logger, HtmlEncoder htmlEncoder, UrlEncoder encoder, ISystemClock clock)
            :base(options, logger, htmlEncoder, encoder, clock)
        { }

        protected override Task HandleForbiddenAsync(AuthenticationProperties properties) =>
            Context.Items.TryGetValue(Consts.HttpContextAdditionalScopeName, out object scopes) &&
                !string.IsNullOrEmpty(scopes as string) ?
            HandleChallengeAsync(properties) :
            base.HandleForbiddenAsync(properties);

        internal static async Task OnRedirectToIdentityProviderHandler(RedirectContext ctx, string authenticationScheme, Func<RedirectContext, Task> userHandler)
        {
            // Force asking for user consent. This is required to get a refresh-token.
            ctx.ProtocolMessage.Prompt = "consent";
            // Offline access required to get a refresh-token.
            ctx.ProtocolMessage.SetParameter("access_type", "offline");
            // Determine if user is already authenticated.
            var auth = await ctx.HttpContext.AuthenticateAsync(authenticationScheme);
            var authed = auth.Succeeded && !auth.None;
            // Handle scopes, with incremental auth if required.
            if (ctx.HttpContext.Items.TryGetValue(Consts.HttpContextAdditionalScopeName, out var scope0) &&
                scope0 is string incrementalScope)
            {
                if (authed)
                {
                    // If user is already authenticated, use incremental auth.
                    ctx.ProtocolMessage.SetParameter("include_granted_scopes", "true");
                    ctx.ProtocolMessage.Scope = incrementalScope;
                    Claim googleId = ctx.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                    if (googleId != null)
                    {
                        // Use the Google ID; "sub" in the JWT; to aid login.
                        ctx.ProtocolMessage.LoginHint = googleId.Value;
                    }
                }
                else
                {
                    // If user is not authenticated, use standard (non-incremental) auth.
                    ctx.ProtocolMessage.Scope += $" {incrementalScope}";
                }
            }
            if (authed && auth.Properties.Items.TryGetValue(Consts.ScopeName, out var existingScope))
            {
                // Pass-through the scopes that are already authorized.
                // This is required because all properties are wiped and re-created from this
                // auth process. To keep a property requires setting it here;
                // scopes are the only property we need to keep.
                ctx.Properties.Items[Consts.ScopeName] = existingScope;
            }
            // Call user event; called last to allow user to overwrite any values written above.
            await userHandler(ctx);
        }

        internal static async Task OnTokenResponseReceivedHandler(TokenResponseReceivedContext ctx, Func<TokenResponseReceivedContext, Task> userHandler)
        {
            // Call user event; called first to allow user to alter values before they are read below.
            await userHandler(ctx);
            // Merge existing scopes and newly acquired scopes.
            var scope = ctx.Properties.Items.TryGetValue(Consts.ScopeName, out var scope0) ? scope0 : "";
            var scopes = scope.Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
            var newScopes = (ctx.ProtocolMessage.Scope ?? "").Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
            var mergedScopes = scopes.Concat(newScopes).Distinct();
            ctx.Properties.Items[Consts.ScopeName] = string.Join(" ", mergedScopes);
        }
    }
}
