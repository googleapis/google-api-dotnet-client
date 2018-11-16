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

using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore
{
    internal class GoogleAuthProvider : IGoogleAuthProvider
    {
        private static TimeSpan s_accessTokenRefreshWindow = TimeSpan.FromMinutes(5);

        public GoogleAuthProvider(IHttpContextAccessor httpContextAccessor, GoogleAuthenticationSchemeProvider schemeProvider, ISystemClock clock, IOptionsMonitor<OpenIdConnectOptions> options)
        {
            _httpContextAccessor = httpContextAccessor;
            _scheme = schemeProvider.Scheme;
            _clock = clock;
            _options = options;
        }

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _scheme;
        private readonly ISystemClock _clock;
        private readonly IOptionsMonitor<OpenIdConnectOptions> _options;

        public async Task<GoogleCredential> GetCredentialAsync(TimeSpan? accessTokenRefreshWindow = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var auth = await httpContext.AuthenticateAsync(_scheme);
            if (!auth.Succeeded || auth.None)
            {
                throw new InvalidOperationException("Cannot get credential when not authenticated.");
            }
            var accessToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var expiresUtc = auth.Properties.ExpiresUtc;
            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(refreshToken) || expiresUtc == null)
            {
                throw new InvalidOperationException("Invalid auth. access_token, refresh_token, and expires_utc must all be present.");
            }
            if (expiresUtc.Value - (accessTokenRefreshWindow ?? s_accessTokenRefreshWindow) < _clock.UtcNow)
            {
                // Refresh required. This has to be done inline here (it can't be done in the background)
                // because the request auth properties need to be updated with the result.
                var options = _options.Get(_scheme);
                var oidcConfig = await options.ConfigurationManager.GetConfigurationAsync(cancellationToken);
                var refreshContent = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "client_id", options.ClientId },
                    { "client_secret", options.ClientSecret },
                    { "grant_type", "refresh_token" },
                    { "refresh_token", auth.Properties.GetTokenValue("refresh_token") }
                });
                try
                {
                    var refreshResponse = await options.Backchannel.PostAsync(oidcConfig.TokenEndpoint, refreshContent, cancellationToken);
                    var payload = JObject.Parse(await refreshResponse.Content.ReadAsStringAsync());
                    var refreshedAccessToken = payload.Value<string>("access_token");
                    var refreshedRefreshToken = payload.Value<string>("refresh_token");
                    var refreshedExpiresIn = payload.Value<string>("expires_in");
                    auth.Properties.UpdateTokenValue(OpenIdConnectParameterNames.AccessToken, refreshedAccessToken);
                    if (!string.IsNullOrEmpty(refreshedRefreshToken))
                    {
                        auth.Properties.UpdateTokenValue(OpenIdConnectParameterNames.RefreshToken, refreshedRefreshToken);
                    }
                    auth.Properties.IssuedUtc = _clock.UtcNow;
                    if (int.TryParse(refreshedExpiresIn, out int expiresInSeconds))
                    {
                        auth.Properties.ExpiresUtc = _clock.UtcNow + TimeSpan.FromSeconds(expiresInSeconds);
                    }
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException("Failed to refresh access_token.", e);
                }
                // Sign-in, to store the refreshed auth tokens (often stored into a cookie).
                await httpContext.SignInAsync(options.SignInScheme, auth.Principal, auth.Properties);
            }
            // Return a short-term, non-refreshable credential.
            return GoogleCredential.FromAccessToken(accessToken);
        }

        public async Task<IReadOnlyList<string>> GetCurrentScopesAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var auth = await httpContext.AuthenticateAsync(_scheme);
            if (!auth.Succeeded || auth.None)
            {
                throw new InvalidOperationException("Cannot get scopes when not authenticated.");
            }
            auth.Properties.Items.TryGetValue(Consts.ScopeName, out var scope);
            return (scope ?? "").Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
