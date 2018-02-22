using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore
{
    public class GoogleCredentialProvider : IGoogleCredentialProvider
    {
        public GoogleCredentialProvider(IServiceProvider services, string authenticationScheme)
        {
            _services = services;
            _authenticationScheme = authenticationScheme;
        }

        private readonly IServiceProvider _services;
        private readonly string _authenticationScheme;

        public async Task<GoogleCredential> GetAsync(CancellationToken cancellationToken)
        {
            // TODO: Should failures throw an exception? Or return null (as currently coded)?
            var httpContext = _services.GetRequiredService<IHttpContextAccessor>().HttpContext;
            var auth = await httpContext.AuthenticateAsync(_authenticationScheme);
            if (!auth.Succeeded || auth.None)
            {
                // Auth failed, cannot provide a credential.
                // TODO: Logging
                return null;
            }
            var optionsMonitor = _services.GetRequiredService<IOptionsMonitor<OpenIdConnectOptions>>();
            var clock = _services.GetRequiredService<ISystemClock>();
            var authProperties = auth.Properties;
            var options = optionsMonitor.Get(OpenIdConnectDefaults.AuthenticationScheme);
            var configManager = options?.ConfigurationManager;
            if (configManager == null)
            {
                // Something wrong with auth config, cannot provide a credential.
                // TODO: Logging
                return null;
            }
            var oidcConfig = await configManager.GetConfigurationAsync(cancellationToken);
            if ((authProperties.ExpiresUtc ?? DateTimeOffset.MinValue) < clock.UtcNow)
            {
                // Acces-token has expired. Refresh it using the refresh token.
                var refreshData = new Dictionary<string, string>
                {
                    { "client_id", options.ClientId },
                    { "client_secret", options.ClientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", authProperties.GetTokenValue("refresh_token") }
                };
                var content = new FormUrlEncodedContent(refreshData);
                try
                {
                    var refreshResponse = await options.Backchannel.PostAsync(
                        oidcConfig.TokenEndpoint, content, cancellationToken);
                    refreshResponse.EnsureSuccessStatusCode();
                    var payload = JObject.Parse(await refreshResponse.Content.ReadAsStringAsync());
                    var accessToken = payload.Value<string>("access_token");
                    var refreshToken = payload.Value<string>("refresh_token");
                    var expiresIn = payload.Value<string>("expires_in");
                    authProperties.UpdateTokenValue("access_token", accessToken);
                    if (!string.IsNullOrEmpty(refreshToken))
                    {
                        authProperties.UpdateTokenValue("refresh_token", refreshToken);
                    }
                    authProperties.IssuedUtc = clock.UtcNow;
                    if (int.TryParse(expiresIn, out int seconds))
                    {
                        authProperties.ExpiresUtc = clock.UtcNow + TimeSpan.FromSeconds(seconds);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Unable to refresh Google access token.", e);
                }
            }
            // Sign in
            await httpContext.SignInAsync(httpContext.User, authProperties);
            // Return credential. This returned credential must not be cached or persisted
            // by user code, because its auth token cannot refresh itself.
            return GoogleCredential.FromAccessToken(authProperties.GetTokenValue("access_token"));
        }
    }
}
