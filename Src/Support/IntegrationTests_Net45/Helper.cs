using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests
{
    static class Helper
    {
        const string ProjectEnvironmentVariable = "TEST_PROJECT";
        const string ServiceAccountFilenameVariable = "TEST_SERVICE_CREDENTIAL_FILENAME";
        const string ClientSecretFilenameVariable = "TEST_CLIENT_SECRET_FILENAME";

        private static Lazy<string> s_projectId = new Lazy<string>(() =>
        {
            string projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException($"Please set the {ProjectEnvironmentVariable} environment variable before running tests.");
            }
            return projectId;
        });

        private static Lazy<GoogleCredential> s_serviceCredential = new Lazy<GoogleCredential>(() =>
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

        private static Lazy<byte[]> s_clientSecretStream = new Lazy<byte[]>(() =>
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

        public static MemoryStream GetClientSecretStream() => new MemoryStream(s_clientSecretStream.Value);
    }
}
