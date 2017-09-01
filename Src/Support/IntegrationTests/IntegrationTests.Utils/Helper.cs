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
using System;
using System.IO;
using System.Text;

namespace IntegrationTests.Utils
{
    internal static class Helper
    {
        const string ProjectEnvironmentVariable = "TEST_PROJECT";
        const string ServiceAccountFilenameVariable = "TEST_SERVICE_CREDENTIAL_FILENAME";
        const string ClientSecretFilenameVariable = "TEST_CLIENT_SECRET_FILENAME";

        private static readonly Lazy<string> s_projectId = new Lazy<string>(() =>
        {
            string projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException($"Please set the {ProjectEnvironmentVariable} environment variable before running tests.");
            }
            return projectId;
        });

        private static readonly Lazy<GoogleCredential> s_serviceCredential = new Lazy<GoogleCredential>(() =>
        {
            string serviceAccountFilename = Environment.GetEnvironmentVariable(ServiceAccountFilenameVariable);
            if (string.IsNullOrEmpty(serviceAccountFilename))
            {
                throw new InvalidOperationException($"Please set the {ServiceAccountFilenameVariable} environment variable before running tests.");
            }
            using (var serviceAccountStream = File.OpenRead(serviceAccountFilename))
            {
                return GoogleCredential.FromStream(serviceAccountStream);
            }
        });

        private static readonly Lazy<byte[]> s_clientSecret = new Lazy<byte[]>(() =>
        {
            string clientSecretFilename = Environment.GetEnvironmentVariable(ClientSecretFilenameVariable);
            if (string.IsNullOrEmpty(clientSecretFilename))
            {
                throw new InvalidOperationException($"Please set the {ClientSecretFilenameVariable} environment variable before running tests.");
            }
            return File.ReadAllBytes(clientSecretFilename);
        });

        public static string GetProjectId() => s_projectId.Value;

        public static GoogleCredential GetServiceCredential() => s_serviceCredential.Value;

        public static string GetClientSecret() => Encoding.UTF8.GetString(s_clientSecret.Value);

        public static MemoryStream GetClientSecretStream() => new MemoryStream(s_clientSecret.Value);
    }
}
