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
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Util.Store;
using IntegrationTests.Utils;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class GoogleWebAuthorizationBrokerTests
    {
        [Fact]
        public async Task AuthClientSecretAndAccessTokenCredential()
        {
            // Warning: This test is interactive!
            // It will bring up a browser window that must be responded to before the test can complete.

            // Test the initial authorization.
            // NullDataStore is used to ensure the AuthorizationUrl is definitely used.
            // "email" scope requested first to test for second scope being passed correctly to auth URL.
            UserCredential cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                Helper.GetClientSecretStream(), new string[] { "email", StorageService.Scope.CloudPlatformReadOnly },
                "user", CancellationToken.None, new NullDataStore());
            Assert.NotNull(cred);

            // Test access token can be retrieved.
            string token = await cred.GetAccessTokenForRequestAsync();
            Assert.NotNull(token);

            // Test token refresh succeeds.
            bool refreshed = await cred.RefreshTokenAsync(CancellationToken.None);
            Assert.True(refreshed);

            // Test a credential created from the AccessToken succeeds.
            var accessTokenCred = GoogleCredential.FromAccessToken(cred.Token.AccessToken);
            Assert.False(accessTokenCred.IsCreateScopedRequired);
            var storageClient = new StorageService(new Google.Apis.Services.BaseClientService.Initializer
            {
                HttpClientInitializer = accessTokenCred,
                ApplicationName = "test"
            });
            // Following line will throw is authentication fails.
            Buckets buckets = storageClient.Buckets.List(Helper.GetProjectId()).Execute();
            // A final sanity-check.
            Assert.NotNull(buckets.Items);
        }

        [Fact]
        public async Task Cancellation()
        {
            // Warning: This test is pseudo-interactive!
            // It will bring up a browser window, but the test will complete without any interaction.

            // Test the initial authorization.
            // NullDataStore is used to ensure browser will definitely be shown.
            // Tests that the local listener will be cancelled properly.
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(1));

            await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
            {
                await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    Helper.GetClientSecretStream(), new string[] { StorageService.Scope.CloudPlatformReadOnly },
                    "user", cts.Token, new NullDataStore());
            });
        }
    }
}
