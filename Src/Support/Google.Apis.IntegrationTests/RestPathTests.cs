/*
Copyright 2026 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google;
using Google.Apis.BigtableAdmin.v2;
using Google.Apis.BigtableAdmin.v2.Data;
using Google.Apis.Services;
using IntegrationTests.Utils;
using Xunit;

namespace IntegrationTests
{
    public class RestPathTests
    {
        [Fact]
        public void ColonCorrectness()
        {
            // Test uses dummy (non-existent) project, which will cause an error.
            // This is fine, as the test is checking that the request URI is correctly formed,
            // not that the call itself works.
            // The check on the returned error ensures that the URI is correct.
            // The "GetIamPolicy" method contains a ':' in the request path, which is what this test is testing.
            var client = new BigtableAdminService(new BaseClientService.Initializer
            {
                HttpClientInitializer = Helper.GetServiceCredential()
                    .CreateScoped(BigtableAdminService.Scope.CloudPlatform),
                ApplicationName = "IntegrationTest",
            });
            var request = client.Projects.Instances.GetIamPolicy(
                new GetIamPolicyRequest
                {
                    Options = new GetPolicyOptions { RequestedPolicyVersion = 3 }
                },
                $"projects/{Helper.GetProjectId()}/instances/fake-instance");
            var ex = Assert.Throws<GoogleApiException>(() => request.Execute());
            Assert.Contains("HttpStatusCode is NotFound.", ex.Message);
        }
    }
}
