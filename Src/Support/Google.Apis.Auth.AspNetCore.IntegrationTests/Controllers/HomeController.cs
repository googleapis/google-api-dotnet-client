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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    }
}