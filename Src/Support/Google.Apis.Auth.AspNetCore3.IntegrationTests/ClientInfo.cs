/*
Copyright 2020 Google Inc

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

using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Google.Apis.Auth.AspNetCore3.IntegrationTests
{
    /// <summary>
    /// OAuth 2.0 client ID used by this application loaded from a client ID json file.
    /// Set the TEST_WEB_CLIENT_SECRET_FILENAME environment variable to point to the client ID json file.
    /// </summary>
    public class ClientInfo
    {
        private const string ClientSecretFilenameVariable = "TEST_WEB_CLIENT_SECRET_FILENAME";

        public static ClientInfo Load()
        {
            string clientSecretFilename = Environment.GetEnvironmentVariable(ClientSecretFilenameVariable);
            if (string.IsNullOrEmpty(clientSecretFilename))
            {
                throw new InvalidOperationException($"Please set the {ClientSecretFilenameVariable} environment variable before running tests.");
            }

            var secrets = JObject.Parse(File.ReadAllText(clientSecretFilename))["web"];

            // Check that this is a "web" client ID, not any other type of client ID like "installed app".
            // The "web" element should have been present in the json so secrets value shouldn't be null.
            if (secrets is null)
            {
                throw new InvalidOperationException(
                    $"The type of the OAuth2 client ID specified in {ClientSecretFilenameVariable} should be Web Application. You can read more about setting up OAuth2 client IDs here: https://support.google.com/cloud/answer/6158849?hl=en");
            }
            var projectId = secrets["project_id"].Value<string>();
            var clientId = secrets["client_id"].Value<string>();
            var clientSecret = secrets["client_secret"].Value<string>();

            return new ClientInfo(projectId, clientId, clientSecret);
        }

        private ClientInfo(string projectId, string clientId, string clientSecret)
        {
            ProjectId = projectId;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public string ProjectId { get; }
        public string ClientId { get; }
        public string ClientSecret { get; }
    }
}
