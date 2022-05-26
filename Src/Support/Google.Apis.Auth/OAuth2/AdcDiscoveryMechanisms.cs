/*
Copyright 2020 Google LLC

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

using System;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Discovery mechanisms for Application Default Credentials. This is used
    /// by various methods in <see cref="GoogleCredential"/>.
    /// </summary>
    [Flags]
    public enum AdcDiscoveryMechanisms
    {
        /// <summary>
        /// The empty set of mechanisms.
        /// </summary>
        None = 0,

        /// <summary>
        /// The GOOGLE_APPLICATION_CREDENTIALS environment variable is consulted.
        /// If the environment variable exists, the value is expected to be the path
        /// to a file containing credentials, typically a service account JSON key file.
        /// </summary>
        FileEnvironmentVariable = 1,

        /// <summary>
        /// An attempt is made to find a well-known file within the local gcloud SDK installation,
        /// indicating the results of a "gcloud auth login" command.
        /// </summary>
        GCloudAuthLoginFile = 2,

        /// <summary>
        /// An attempt is made to detect the presence of a metadata server using
        /// information in the BIOS.
        /// TODO: more details, including environment variables.
        /// </summary>
        MetadataServerBios = 4,

        /// <summary>
        /// An attempt is made to ping a metadata server.
        /// TODO: more details, including environment variables.
        /// </summary>
        MetadataServerPing = 8,

        /// <summary>
        /// A Mutual TLS certificate is obtained where possible.
        /// TODO: far more details.
        /// </summary>
        MutualTlsCertificate = 16,
    }
}