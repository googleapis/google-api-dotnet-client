/*
Copyright 2018 Google Inc

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
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Translate.v2;
using Google.Apis.Util.Store;
using IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class IncrementalAuthTests
    {
        [Fact]
        public async Task IncrementalAuth()
        {
            var dataStore = new NullDataStore();
            // Initially only ask for email
            UserCredential cred1 = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                Helper.GetClientSecretStream(), new string[] { "email" }, "user", CancellationToken.None, dataStore);
            // Check that we don't have permission to access storage
            var storageClient1 = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GoogleCredential.FromAccessToken(cred1.Token.AccessToken),
                ApplicationName = "test"
            });
            var ex = await Assert.ThrowsAsync<GoogleApiException>(() => storageClient1.Buckets.List(Helper.GetProjectId()).ExecuteAsync());
            Assert.Contains("insufficientPermissions", ex.Message);

            // Incrementally ask for storage read-only access.
            var flowInit2 = new GoogleAuthorizationCodeFlow.Initializer
            {
                IncludeGrantedScopes = true,
                ClientSecretsStream = Helper.GetClientSecretStream(),
                LoginHint = cred1.UserId
            };
            UserCredential cred2 = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                flowInit2, new string[] { StorageService.Scope.DevstorageReadOnly },
                "user", CancellationToken.None, dataStore);
            // Check that we can read from storage.
            var storageClient2 = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GoogleCredential.FromAccessToken(cred2.Token.AccessToken),
                ApplicationName = "test",
            });
            var buckets2 = await storageClient2.Buckets.List(Helper.GetProjectId()).ExecuteAsync();
            Assert.NotNull(buckets2.Items);

            // Incrementally ask for translate access
            var flowInit3 = new GoogleAuthorizationCodeFlow.Initializer
            {
                IncludeGrantedScopes = true,
                ClientSecretsStream = Helper.GetClientSecretStream(),
                LoginHint = cred2.UserId
            };
            UserCredential cred3 = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                flowInit3, new string[] { TranslateService.Scope.CloudTranslation },
                "user", CancellationToken.None, dataStore);
            // Check that we can still read from storage
            var storageClient3 = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GoogleCredential.FromAccessToken(cred3.Token.AccessToken),
                ApplicationName = "test",
            });
            var buckets3 = await storageClient3.Buckets.List(Helper.GetProjectId()).ExecuteAsync();
            Assert.NotNull(buckets3.Items);
        }
    }
}
