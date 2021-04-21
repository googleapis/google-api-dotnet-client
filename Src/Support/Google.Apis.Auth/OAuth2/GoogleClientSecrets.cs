/*
Copyright 2013 Google Inc

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

using Google.Apis.Json;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// OAuth 2.0 client secrets model as specified in https://cloud.google.com/console/.
    /// </summary>
    public sealed class GoogleClientSecrets
    {
        /// <summary>Gets or sets the details for installed applications.</summary>
        [Newtonsoft.Json.JsonProperty("installed")]
        private ClientSecrets Installed { get; set; }

        /// <summary>Gets or sets the details for web applications.</summary>
        [Newtonsoft.Json.JsonProperty("web")]
        private ClientSecrets Web { get; set; }

        /// <summary>Gets the client secrets which contains the client identifier and client secret. </summary>
        public ClientSecrets Secrets
        {
            get
            {
                if (Installed == null && Web == null)
                {
                    throw new InvalidOperationException(
                        "At least one client secrets (Installed or Web) should be set");
                }
                return Installed ?? Web;
            }
        }

        /// <summary>Loads the Google client secret from the input stream.</summary>
        /// <remarks>This method has been made obsolete in favour of <see cref="FromStream(Stream)"/>
        /// which only differs in name.</remarks>
        [Obsolete("Please use GoogleClientSecrets.FromStream which is an equivalent alternative.")]
        public static GoogleClientSecrets Load(Stream stream) =>
            FromStream(stream);

        /// <summary>Loads the Google client secret from the input stream.</summary>
        public static GoogleClientSecrets FromStream(Stream stream) =>
            NewtonsoftJsonSerializer.Instance.Deserialize<GoogleClientSecrets>(stream);

        /// <summary>Asynchronously loads the Google client secret from the input stream.</summary>
        public static Task<GoogleClientSecrets> FromStreamAsync(Stream stream, CancellationToken cancellationToken = default) =>
            NewtonsoftJsonSerializer.Instance.DeserializeAsync<GoogleClientSecrets>(stream, cancellationToken);

        /// <summary>Loads the Google client secret from a JSON file.</summary>
        public static GoogleClientSecrets FromFile(string clientSecretsFilePath)
        {
            using var stream = new FileStream(clientSecretsFilePath, FileMode.Open, FileAccess.Read);
            return FromStream(stream);
        }

        /// <summary>Asynchronously loads the Google client secret from a JSON file.</summary>
        public static async Task<GoogleClientSecrets> FromFileAsync(string clientSecretsFilePath, CancellationToken cancellationToken = default)
        {
            using var stream = new FileStream(clientSecretsFilePath, FileMode.Open, FileAccess.Read);
            return await FromStreamAsync(stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
