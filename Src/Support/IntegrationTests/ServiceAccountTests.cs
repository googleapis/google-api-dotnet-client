/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using IntegrationTests.Utils;
using Xunit;

namespace IntegrationTests
{
    public class ServiceAccountTests
    {
        [Fact]
        public void ServiceCredential()
        {
            // This is testing that a service-credential successfully authenticates to a Cloud Service.
            // If authentication fails, an exception will be thrown, failing the test.

            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);

            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            // Check an access token is available.
            var ok = credential.UnderlyingCredential.GetAccessTokenForRequestAsync().Result;
            Assert.NotNull(ok);

            // Following line will throw is authentication fails.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).Execute();

            // A final sanity-check.
            Assert.NotNull(buckets.Items);
        }
    }
}
