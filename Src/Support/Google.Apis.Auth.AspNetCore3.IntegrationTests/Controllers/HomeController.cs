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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
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
        /// <summary>
        /// Public home page.
        /// No authorization required. User doesn't need to login to see this.
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Login action.
        /// No authentication specific code. Just adding the <see cref="AuthorizeAttribute"/>
        /// will trigger authentication if necessary.
        /// </summary>
        [Authorize]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Logout action.
        /// Does nothing if the user is not logged in.
        /// </summary>
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return View();
        }

        /// <summary>
        /// Shows the current scopes associated to the authenticated account.
        /// Specifying the <see cref="AuthorizeAttribute"/> will guarantee that the code
        /// executes only if the user is authenticated. No specific scopes are required.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        [Authorize]
        public async Task<IActionResult> ScopeListing([FromServices] IGoogleAuthProvider auth)
        {
            IReadOnlyList<string> currentScopes = await auth.GetCurrentScopesAsync();
            return View(currentScopes);
        }

        /// <summary>
        /// Lists the authenticated user's Google Drive files.
        /// Specifying the <see cref="GoogleScopedAuthorizeAttribute"> will guarantee that the code
        /// executes only if the user is authenticated and has granted the scope specified in the attribute
        /// to this application.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        [GoogleScopedAuthorize(DriveService.ScopeConstants.DriveReadonly)]
        public async Task<IActionResult> DriveFileList([FromServices] IGoogleAuthProvider auth)
        {
            GoogleCredential cred = await auth.GetCredentialAsync();
            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });
            var files = await service.Files.List().ExecuteAsync();
            var fileNames = files.Files.Select(x => x.Name).ToList();
            return View(fileNames);
        }

        /// <summary>
        /// Lists the authenticated user's Calendars.
        /// Specifying the <see cref="AuthorizeAttribute"/> will guarantee that the code executes only if the
        /// user is authenticated.
        /// No scopes are required via attributes.
        /// Instead, scope are required via code using <see cref="IGoogleAuthProvider.RequireScopesAsync(string[])"/>.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        [Authorize]
        public async Task<IActionResult> CalendarList([FromServices] IGoogleAuthProvider auth)
        {
            // Check if the required scopes have been granted. 
            if (await auth.RequireScopesAsync(CalendarService.ScopeConstants.CalendarReadonly) is IActionResult authResult)
            {
                // If the required scopes are not granted, then a non-null IActionResult will be returned,
                // which must be returned from the action. This triggers incremental authorization.
                // Once the user has granted the scope, an automatic redirect to this action will be issued.
                return authResult;
            }
            // The required scopes have now been granted.
            GoogleCredential cred = await auth.GetCredentialAsync();
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = cred
            });
            var calendars = await service.CalendarList.List().ExecuteAsync();
            var calendarIds = calendars.Items.Select(calendar => calendar.Id).ToList();
            return View(calendarIds);
        }

        /// <summary>
        /// Fetches and shows the Google OAuth2 tokens that are currently active for the logged in user.
        /// Specifying the <see cref="AuthorizeAttribute"/> will guarantee that the code executes only if the
        /// user is authenticated. Once the user is authenticated the tokens are stored locally, in a cookie,
        /// and we can inspect them.
        /// </summary>
        [Authorize]
        public async Task<IActionResult> ShowTokens()
        {
            // The user is already authenticated, so this call won't trigger authentication.
            // But it allows us to access the AuthenticateResult object that we can inspect
            // to obtain token related values.
            AuthenticateResult auth = await HttpContext.AuthenticateAsync();
            string idToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.IdToken);
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
            string accessToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            string refreshToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            string accessTokenExpiresAt = auth.Properties.GetTokenValue("expires_at");
            string cookieIssuedUtc = auth.Properties.IssuedUtc?.ToString() ?? "<missing>";
            string cookieExpiresUtc = auth.Properties.ExpiresUtc?.ToString() ?? "<missing>";

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

        /// <summary>
        /// Forces the refresh of the OAuth access token.
        /// Specifying the <see cref="AuthorizeAttribute"/> will guarantee that the code executes only if the
        /// user is authenticated.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        [Authorize]
        public async Task<IActionResult> ForceTokenRefresh([FromServices] IGoogleAuthProvider auth)
        {
            // Obtain OAuth related values before the refresh.
            AuthenticateResult authResult0 = await HttpContext.AuthenticateAsync();
            string accessToken0 = authResult0.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            string refreshToken0 = authResult0.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            string issuedUtc0 = authResult0.Properties.IssuedUtc?.ToString() ?? "<missing>";
            string expiresUtc0 = authResult0.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            // Force token refresh by specifying a too-long refresh window.
            GoogleCredential cred = await auth.GetCredentialAsync(TimeSpan.FromHours(24));

            // Obtain OAuth related values after the refresh.
            AuthenticateResult authResult1 = await HttpContext.AuthenticateAsync();
            string accessToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            string refreshToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            string issuedUtc1 = authResult1.Properties.IssuedUtc?.ToString() ?? "<missing>";
            string expiresUtc1 = authResult1.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            // As demonstration compare the old values with the new ones and check that everything is
            // as it should be.
            string credAccessToken = await cred.UnderlyingCredential.GetAccessTokenForRequestAsync();

            bool accessTokenChanged = accessToken0 != accessToken1;
            bool credHasCorrectAccessToken = credAccessToken == accessToken1;

            bool pass = accessTokenChanged && credHasCorrectAccessToken;

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

        /// <summary>
        /// Checks that the access token is the expected one.
        /// Specifying the <see cref="AuthorizeAttribute"/> will guarantee that the code executes only if the
        /// user is authenticated.
        /// This method is used from the Force Refresh sample to show that the refreshed token is persisted.
        /// </summary>
        /// <param name="auth">The Google authorization provider.
        /// This can also be injected on the controller constructor.</param>
        /// <param name="expectedAccessToken">The expected token.</param>
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
