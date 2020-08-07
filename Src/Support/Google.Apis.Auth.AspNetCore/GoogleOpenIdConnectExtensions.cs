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
using Microsoft.AspNetCore.Http;
#endif
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;

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
#if ASPNETCORE3
            builder.Services.AddHttpContextAccessor();
#else
            builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
#endif
            // Service to provide user access to the Google auth information.
            builder.Services.AddSingleton<IGoogleAuthProvider, GoogleAuthProvider>();

            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<OpenIdConnectOptions>, OpenIdConnectPostConfigureOptions>());
            return builder.AddRemoteScheme<OpenIdConnectOptions, GoogleOpenIdConnectHandler>(authenticationScheme, displayName, options =>
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
                        await GoogleOpenIdConnectHandler.OnRedirectToIdentityProviderHandler(ctx, authenticationScheme, userEvents.OnRedirectToIdentityProvider),
                    OnTokenResponseReceived = async ctx =>
                        await GoogleOpenIdConnectHandler.OnTokenResponseReceivedHandler(ctx, userEvents.OnTokenResponseReceived),
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
