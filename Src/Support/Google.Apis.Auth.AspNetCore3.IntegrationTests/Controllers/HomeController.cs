/*
Copyright 2020 Google Inc

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

using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore3.IntegrationTests.Controllers
{
    public class HomeController : Controller
    {
        // No authorization required. User doesn't need to login to see this.
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            // Must not redirect after sign-out; otherwise user is not signed-out.
            // https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio#scaffold-register-login-and-logout
            return View();
        }

        // Authentication required, but no specific scopes
        [Authorize]
        public async Task<IActionResult> ScopeListing([FromServices] IGoogleAuthProvider auth)
        {
            return View(await auth.GetCurrentScopesAsync());
        }

        // Test showing use of incremental auth.
        // This attribute states that the listed scope(s) must be authorized in the handler.
        [GoogleScopedAuthorize(StorageService.ScopeConstants.CloudPlatformReadOnly)]
        public async Task<IActionResult> StorageBucketListing([FromServices] IGoogleAuthProvider auth, [FromServices] ClientInfo clientInfo)
        {
            var cred = await auth.GetCredentialAsync();
            var service = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });
            var buckets = await service.Buckets.List(clientInfo.ProjectId).ExecuteAsync();
            var bucketNames = buckets.Items.Select(x => x.Name).ToList();
            return View(bucketNames);
        }

        // Test showing use of incremental auth.
        // The call to auth.RequireScopesAsync(...) ensures the correct authorization is available.
        [Authorize]
        public async Task<IActionResult> Translate([FromServices] IGoogleAuthProvider auth, [FromServices] ClientInfo clientInfo)
        {
            // Programmatic auth check.
            if (await auth.RequireScopesAsync(TranslateService.Scope.CloudTranslation) is IActionResult authResult)
            {
                // If the required scopes are not authorized, then a non-null IActionResult will be returned,
                // which must be returned from the action.
                return authResult;
            }
            // The required scopes have now been authorized.
            var cred = await auth.GetCredentialAsync();
            var service = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });
            var translateRequest = service.Translations.Translate(new TranslateTextRequest
            {
                Format = "text",
                Q = new List<string> { "The cold weather will soon be over" },
                Source = "en",
                Target = "fr",
            });
            var response = await translateRequest.ExecuteAsync();
            return View((object)response.Translations.Single().TranslatedText);
        }

        [Authorize]
        public async Task<IActionResult> ShowTokens()
        {
            var auth = await HttpContext.AuthenticateAsync();
            var idToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.IdToken);
            string idTokenValid, idTokenIssued, idTokenExpires;
            try
            {
                var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);
                idTokenValid = "true";
                idTokenIssued = new DateTime(1970, 1, 1).AddSeconds(payload.IssuedAtTimeSeconds.Value).ToString();
                idTokenExpires = new DateTime(1970, 1, 1).AddSeconds(payload.ExpirationTimeSeconds.Value).ToString();
            }
            catch (Exception e)
            {
                idTokenValid = $"false: {e.Message}";
                idTokenIssued = "invalid";
                idTokenExpires = "invalid";
            }
            var accessToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var accessTokenExpiresAt = auth.Properties.GetTokenValue("expires_at");
            var cookieIssuedUtc = auth.Properties.IssuedUtc?.ToString() ?? "<missing>";
            var cookieExpiresUtc = auth.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            return View(new []
            {
                $"Id Token: '{idToken}'",
                $"Id Token valid: {idTokenValid}",
                $"Id Token Issued UTC: '{idTokenIssued}'",
                $"Id Token Expires UTC: '{idTokenExpires}'",
                $"Access Token: '{accessToken}'",
                $"Refresh Token: '{refreshToken}'",
                $"Access token expires at: '{accessTokenExpiresAt}'",
                $"Cookie Issued UTC: '{cookieIssuedUtc}'",
                $"Cookie Expires UTC: '{cookieExpiresUtc}'",
            });
        }

        public class ForceTokenRefreshModel
        {
            public IReadOnlyList<string> Results;
            public string AccessToken;
        }

        [Authorize]
        public async Task<IActionResult> ForceTokenRefresh([FromServices] IGoogleAuthProvider auth)
        {
            var authResult0 = await HttpContext.AuthenticateAsync();
            var accessToken0 = authResult0.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken0 = authResult0.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var issuedUtc0 = authResult0.Properties.IssuedUtc?.ToString() ?? "<missing>";
            var expiresUtc0 = authResult0.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            // Force token refresh by specifying a too-long refresh window.
            var cred = await auth.GetCredentialAsync(TimeSpan.FromHours(24));

            var authResult1 = await HttpContext.AuthenticateAsync();
            var accessToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var issuedUtc1 = authResult1.Properties.IssuedUtc?.ToString() ?? "<missing>";
            var expiresUtc1 = authResult1.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            var credAccessToken = await cred.UnderlyingCredential.GetAccessTokenForRequestAsync();

            var accessTokenChanged = accessToken0 != accessToken1;
            var credHasCorrectAccessToken = credAccessToken == accessToken1;

            var pass = accessTokenChanged && credHasCorrectAccessToken;

            var model = new ForceTokenRefreshModel
            {
                Results = new[]
                {
                    $"Before Access Token: '{accessToken0}'",
                    $"Before Refresh Token: '{refreshToken0}'",
                    $"Before Issued UTC: '{issuedUtc0}'",
                    $"Before Expires UTC: '{expiresUtc0}'",
                    $"After Access Token: '{accessToken1}'",
                    $"After Refresh Token: '{refreshToken1}'",
                    $"After Issued UTC: '{issuedUtc1}'",
                    $"After Expires UTC: '{expiresUtc1}'",
                    $"Access token changed: {accessTokenChanged}",
                    $"Credential has correct access token: {credHasCorrectAccessToken}",
                    $"Pass: {pass}"
                },
                AccessToken = accessToken1
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ForceTokenRefreshCheckPersisted([FromServices] IGoogleAuthProvider auth, [FromForm] string expectedAccessToken)
        {
            // Check that the refreshed access token is correctly persisted across requests.
            var cred = await auth.GetCredentialAsync();
            var credAccessToken = await cred.UnderlyingCredential.GetAccessTokenForRequestAsync();
            var pass = credAccessToken == expectedAccessToken;
            return View(new[]
            {
                $"Expected access token: '{expectedAccessToken}'",
                $"Credential access token: '{credAccessToken}'",
                $"Pass: {pass}"
            });
        }
    }
}
