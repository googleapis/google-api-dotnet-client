using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Apis.Auth.AspNetCore
{
    public static class GoogleOidcExtensions
    {
        public static AuthenticationBuilder AddGoogleOidc(this AuthenticationBuilder builder,
            string authenticationScheme, string displayName, Action<OpenIdConnectOptions> configureOptions)
        {
            builder.AddOpenIdConnect(authenticationScheme, displayName, options =>
            {
                // Run user-provided options configuration.
                configureOptions(options);
                // Response-code to get an id-token with profile information,
                // and a code to use to get an access-token and refresh-token.
                options.ResponseType = "id_token code";
                // Scopes to announce this is an OpenID auth, and get simple profile information.
                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.Scope.Add("openid");
                // OpenID authority URL.
                options.Authority = "https://accounts.google.com";
                // Save the id-token, access-token and refresh-token in the auth properties.
                options.SaveTokens = true;
                var userEvents = options.Events;
                options.Events = new OpenIdConnectEvents
                {
                    OnRedirectToIdentityProvider = async context =>
                    {
                        // Run existing user-provided event.
                        await userEvents.OnRedirectToIdentityProvider(context);
                        // Force asking for user consent.
                        // This is required to get a refresh-token.
                        context.ProtocolMessage.Prompt = "consent";
                        // Also required to get a refresh-token.
                        context.ProtocolMessage.SetParameter("access_type", "offline");
                    },
                    // Forward all other events
                    OnAuthenticationFailed = userEvents.OnAuthenticationFailed,
                    OnAuthorizationCodeReceived = userEvents.OnAuthorizationCodeReceived,
                    OnMessageReceived = userEvents.OnMessageReceived,
                    OnRedirectToIdentityProviderForSignOut = userEvents.OnRedirectToIdentityProviderForSignOut,
                    OnRemoteFailure = userEvents.OnRemoteFailure,
                    OnRemoteSignOut = userEvents.OnRemoteSignOut,
                    OnTicketReceived = userEvents.OnTicketReceived,
                    OnTokenResponseReceived = userEvents.OnTokenResponseReceived,
                    OnTokenValidated = userEvents.OnTokenValidated,
                    OnUserInformationReceived = userEvents.OnUserInformationReceived,
                };
            });
            builder.Services.AddTransient<IGoogleCredentialProvider>(
                services => new GoogleCredentialProvider(services));
            return builder;
        }

    }
}
