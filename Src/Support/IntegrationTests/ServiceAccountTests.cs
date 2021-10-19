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

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.BigtableAdmin.v2;
using Google.Apis.BigtableAdmin.v2.Data;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using IntegrationTests.Utils;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
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

            // Following line will throw if authentication fails.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).Execute();

            // A final sanity-check.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public void ServiceCredential_UserDisableJwt()
        {
            // This is testing that a service-credential successfully authenticates to a Cloud Service.
            // If authentication fails, an exception will be thrown, failing the test.

            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl).CreateWithUser("User");
            ServiceAccountCredential serviceCredential = (ServiceAccountCredential)credential.UnderlyingCredential;

            credential = GoogleCredential.FromServiceAccountCredential(serviceCredential.WithUseJwtAccessWithScopes(true));

            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            // Check an access token is available.
            var ok = credential.UnderlyingCredential.GetAccessTokenForRequestAsync().Result;
            Assert.NotNull(ok);

            // Following line will throw if authentication fails.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).Execute();

            // A final sanity-check.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public async Task JwtAccessToken_Http()
        {
            // See: https://developers.google.com/identity/protocols/oauth2/service-account#jwt-auth

            ServiceAccountCredential credential = Helper.GetServiceCredential().CreateScoped().UnderlyingCredential as ServiceAccountCredential;
            string token = await credential.GetAccessTokenForRequestAsync("https://bigtableadmin.googleapis.com/");

            using HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.RequestUri = new Uri($"https://bigtableadmin.googleapis.com/v2/projects/{Helper.GetProjectId()}/instances");

            HttpResponseMessage response = await client.SendAsync(request);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData(true, null)]
        [InlineData(false, null)]
        [InlineData(true, new[] { "https://www.googleapis.com/auth/bigtable.admin" })]
        public void JwtAccessToken_RestClient(bool useJwtAccessWithScopes, string[] scopes)
        {
            // See: https://developers.google.com/identity/protocols/oauth2/service-account#jwt-auth

            GoogleCredential credential = useJwtAccessWithScopes 
                ? Helper.GetServiceCredentialWithJwtFlag().CreateScoped(scopes) 
                : Helper.GetServiceCredential().CreateScoped(scopes);

            BigtableAdminService service = new BigtableAdminService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential
            });
            
            ListInstancesResponse response = service.Projects.Instances.List($"projects/{Helper.GetProjectId()}").Execute();

            Assert.NotNull(response);
        }

        [Fact]
        public void JwtAccessToken_WrongScope_RestClient()
        {
            // See: https://developers.google.com/identity/protocols/oauth2/service-account#jwt-auth

            GoogleCredential credential = Helper.GetServiceCredentialWithJwtFlag().CreateScoped(new[] { "https://www.googleapis.com/auth/admob.readonly" });

            BigtableAdminService service = new BigtableAdminService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential
            });

            string expectedError = "Request had invalid authentication credentials.";

            var exception = Assert.Throws<GoogleApiException>(() =>
                service.Projects.Instances.List($"projects/{Helper.GetProjectId()}").Execute());
            Assert.Contains(expectedError, exception.Message);
        }
    }
}
