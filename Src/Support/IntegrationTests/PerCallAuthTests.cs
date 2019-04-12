/*
Copyright 2019 Google Inc

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
using Google.Apis.Http;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using IntegrationTests.Utils;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class PerCallAuthTests
    {
        [Fact]
        public void ServiceAccountPerCallCredential()
        {
            // No auth in the client.
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest"
            });
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            // Create a request with a per-call credential.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).AddCredential(credential).Execute();
            // Check the response is sane.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public void OverrideServiceCredentialWithPerCallCredential()
        {
            // Broken credential in the client.
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                ApplicationName = "IntegrationTest",
                HttpClientInitializer = GoogleCredential.FromAccessToken("BROKEN_ACCESS_TOKEN")
            });
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            // Create a request with a per-call credential.; this overrides the service-level credential.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).AddCredential(credential).Execute();
            // Check the response is sane.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public void NullParameters()
        {
            StorageService client = new StorageService();
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl);
            Assert.Throws<ArgumentNullException>(() => ((ClientServiceRequest)null).AddCredential(credential));
            var request = client.Buckets.List(Helper.GetProjectId());
            Assert.Throws<ArgumentNullException>(() => request.AddCredential(null));
        }

        private class CredentialNoInterceptors : ICredential
        {
            public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
                throw new NotImplementedException();
            public void Initialize(ConfigurableHttpClient httpClient) => throw new NotImplementedException();
        }

        [Fact]
        public void InvalidCredential()
        {
            StorageService client = new StorageService();
            var credential = new CredentialNoInterceptors();
            var request = client.Buckets.List(Helper.GetProjectId());
            // Provided credential doesn't implement the required execute interceptor.
            Assert.Throws<ArgumentException>(() => request.AddCredential(credential));
        }
    }
}
