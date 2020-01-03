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

#if ASPNETCORE3
using Google.Apis.Auth.AspNetCore3;
#else
using Google.Apis.Auth.AspNetCore;
#endif
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;
using System.Security.Claims;

// Microsoft recommend that all service Add methods go in this namespace.
// See https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to support Google OpenIdConnect authentication.
    /// </summary>
    public static class GoogleOpenIdConnectExtensions
    {
        /// <summary>
        /// Add Google OpenIdConnect authentication.
        /// </summary>
        /// <param name="builder">The current <see cref="AuthenticationBuilder"/>.</param>
        /// <returns>The current <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGoogleOpenIdConnect(this AuthenticationBuilder builder) =>
            AddGoogleOpenIdConnect(builder, _ => { });

        /// <summary>
        /// Add Google OpenIdConnect authentication.
        /// </summary>
        /// <param name="builder">The current <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="configureOptions">Function allowing option customization.</param>
        /// <returns>The current <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGoogleOpenIdConnect(this AuthenticationBuilder builder,
            Action<OpenIdConnectOptions> configureOptions) =>
                AddGoogleOpenIdConnect(builder, GoogleOpenIdConnectDefaults.AuthenticationScheme, configureOptions);

        /// <summary>
        /// Add Google OpenIdConnect authentication.
        /// </summary>
        /// <param name="builder">The current <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="authenticationScheme">The name of this authentication scheme.</param>
        /// <param name="configureOptions">Function allowing option customization.</param>
        /// <returns>The current <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGoogleOpenIdConnect(this AuthenticationBuilder builder,
            string authenticationScheme, Action<OpenIdConnectOptions> configureOptions) =>
                AddGoogleOpenIdConnect(builder, authenticationScheme, GoogleOpenIdConnectDefaults.DisplayName, configureOptions);

        /// <summary>
        /// Add Google OpenIdConnect authentication.
        /// </summary>
        /// <param name="builder">The current <see cref="AuthenticationBuilder"/>.</param>
        /// <param name="authenticationScheme">The name of this authentication scheme.</param>
        /// <param name="displayName">The display name of this authentication scheme.</param>
        /// <param name="configureOptions">Function allowing option customization.</param>
        /// <returns>The current <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddGoogleOpenIdConnect(this AuthenticationBuilder builder,
            string authenticationScheme, string displayName, Action<OpenIdConnectOptions> configureOptions)
        {
            // Service to provide the authentication scheme name.
            builder.Services.AddSingleton(new GoogleAuthenticationSchemeProvider(authenticationScheme));
            // Services to facilitate the GoogleScopedAuthorize attribute.
            builder.Services.AddTransient<IAuthorizationPolicyProvider, GoogleScopedPolicyProvider>();
            builder.Services.AddScoped<IAuthorizationHandler, GoogleScopedAuthorizationHandler>();
            // Required to provide access to HttpContext in GoogleAuthProvider.
            builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Service to provide user access to the Google auth information.
            builder.Services.AddSingleton<IGoogleAuthProvider, GoogleAuthProvider>();
            return builder.AddOpenIdConnect(authenticationScheme, displayName, options =>
            {
                // Google's OpenID authority URL.
                options.Authority = "https://accounts.google.com";
                // Response-type of "code" gets just an authorization-code from the authorization endpoint,
                // then both an access-token and an id-token (JWT) from the token endpoint.
                // An id-token is returned from the token endpoint because Google is an openid-connect
                // provider (not just an oauth2 provider), and the "openid" scope is set below.
                // Useful reference for openid-connect flows:
                // https://medium.com/@darutk/diagrams-of-all-the-openid-connect-flows-6968e3990660
                options.ResponseType = "code";
                // Scopes to announce this is an OpenID auth, and get simple profile information.
                options.Scope.Clear();
                options.Scope.Add("openid");
                options.Scope.Add("email");
                options.Scope.Add("profile");
                // Save the id-token, access-token, refresh-token, and expiry in the auth properties.
                options.SaveTokens = true;
                options.GetClaimsFromUserInfoEndpoint = false;
                // Call user configuration.
                configureOptions(options);
                // Add event handlers.
                var userEvents = options.Events;
                options.Events = new OpenIdConnectEvents
                {
                    OnRedirectToIdentityProvider = async ctx =>
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
                        await userEvents.OnRedirectToIdentityProvider(ctx);
                    },
                    OnTokenResponseReceived = async ctx =>
                    {
                        // Call user event; called first to allow user to alter values before they are read below.
                        await userEvents.OnTokenResponseReceived(ctx);
                        // Merge existing scopes and newly acquired scopes.
                        var scope = ctx.Properties.Items.TryGetValue(Consts.ScopeName, out var scope0) ? scope0 : "";
                        var scopes = scope.Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
                        var newScopes = (ctx.ProtocolMessage.Scope ?? "").Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
                        var mergedScopes = scopes.Concat(newScopes).Distinct();
                        ctx.Properties.Items[Consts.ScopeName] = string.Join(" ", mergedScopes);
                    },
                    // Forward all other events.
                    OnAuthenticationFailed = userEvents.OnAuthenticationFailed,
                    OnAuthorizationCodeReceived = userEvents.OnAuthorizationCodeReceived,
                    OnMessageReceived = userEvents.OnMessageReceived,
                    OnRedirectToIdentityProviderForSignOut = userEvents.OnRedirectToIdentityProviderForSignOut,
                    OnRemoteFailure = userEvents.OnRemoteFailure,
                    OnRemoteSignOut = userEvents.OnRemoteSignOut,
                    OnTicketReceived = userEvents.OnTicketReceived,
                    OnTokenValidated = userEvents.OnTokenValidated,
                    OnUserInformationReceived = userEvents.OnUserInformationReceived,
                };
            });
        }
    }
}
