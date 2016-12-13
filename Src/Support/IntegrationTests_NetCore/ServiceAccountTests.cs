/*
Copyright 2016 Google Inc

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
using NUnit.Framework;
using System;
using System.IO;

namespace IntegrationTests
{
    [TestFixture]
    public class ServiceAccountTests
    {
        [Test]
        public void ServiceCredential()
        {
            // This is testing that a service-credential successfully authenticates to a Cloud Service.
            // If authentication fails, an exception will be thrown, failing the test.

            const string ProjectEnvironmentVariable = "TEST_PROJECT";
            const string ServiceAccountFilenameVariable = "TEST_SERVICE_CREDENTIAL_FILENAME";

            string projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            string serviceAccountFilename = Environment.GetEnvironmentVariable(ServiceAccountFilenameVariable);

            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException($"Please set the {ProjectEnvironmentVariable} environment variable before running tests.");
            }
            if (string.IsNullOrEmpty(serviceAccountFilename))
            {
                throw new InvalidOperationException($"Please set the {ServiceAccountFilenameVariable} environment variable before running tests.");
            }

            GoogleCredential credential;
            using (var serviceAccountStream = File.OpenRead(serviceAccountFilename))
            {
                credential = GoogleCredential.FromStream(serviceAccountStream);
            }
            credential = credential.CreateScoped(StorageService.Scope.DevstorageFullControl);
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            // Following line will throw is authentication fails.
            Buckets buckets = client.Buckets.List(projectId).Execute();

            // A final sanity-check.
            Assert.NotNull(buckets.Items);
        }
    }
}
