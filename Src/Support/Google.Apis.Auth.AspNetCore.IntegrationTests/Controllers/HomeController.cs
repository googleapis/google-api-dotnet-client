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

using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Apis.Auth.AspNetCore.IntegrationTests.Controllers
{
    public class HomeController : Controller
    {
        // Authentication required, but no specific scopes
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ScopeListing([FromServices] IGoogleAuthProvider auth)
        {
            return View(await auth.GetCurrentScopesAsync());
        }

        [GoogleScopedAuthorize("https://www.googleapis.com/auth/cloud-platform.read-only")]
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

        [Authorize]
        public async Task<IActionResult> ShowTokens()
        {
            var auth = await HttpContext.AuthenticateAsync();
            var accessToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken = auth.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var issuedUtc = auth.Properties.IssuedUtc?.ToString() ?? "<missing>";
            var expiresUtc = auth.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            return View(new[]
            {
                $"Access Token: '{accessToken}'",
                $"Refresh Token: '{refreshToken}'",
                $"Issued UTC: '{issuedUtc}'",
                $"Expires UTC: '{expiresUtc}'",
            });
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
            await auth.GetCredentialAsync(TimeSpan.FromHours(24));

            var authResult1 = await HttpContext.AuthenticateAsync();
            var accessToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.AccessToken);
            var refreshToken1 = authResult1.Properties.GetTokenValue(OpenIdConnectParameterNames.RefreshToken);
            var issuedUtc1 = authResult1.Properties.IssuedUtc?.ToString() ?? "<missing>";
            var expiresUtc1 = authResult1.Properties.ExpiresUtc?.ToString() ?? "<missing>";

            return View(new[]
            {
                $"Before Access Token: '{accessToken0}'",
                $"Before Refresh Token: '{refreshToken0}'",
                $"Before Issued UTC: '{issuedUtc0}'",
                $"Before Expires UTC: '{expiresUtc0}'",
                $"After Access Token: '{accessToken1}'",
                $"After Refresh Token: '{refreshToken1}'",
                $"After Issued UTC: '{issuedUtc1}'",
                $"After Expires UTC: '{expiresUtc1}'",
            });
        }
    }
}