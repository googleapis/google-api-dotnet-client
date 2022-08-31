/*
Copyright 2015 Google Inc

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

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Holder for credential parameters read from JSON credential file.
    /// Fields are union of parameters for all supported credential types.
    /// </summary>
    public class JsonCredentialParameters
    {
        /// <summary>
        /// UserCredential is created by the GCloud SDK tool when the user runs
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        public const string AuthorizedUserCredentialType = "authorized_user";

        /// <summary>
        /// ServiceAccountCredential is downloaded by the user from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>.
        /// </summary>
        public const string ServiceAccountCredentialType = "service_account";

        /// <summary>
        /// See https://cloud.google.com/iam/docs/workload-identity-federation on how
        /// to create external account credentials.
        /// </summary>
        public const string ExternalAccountCredentialType = "external_account";

        /// <summary>Type of the credential.</summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Project ID associated with this credential.
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// Project ID associated with this credential for the purposes
        /// of quota calculations and billing.
        /// </summary>
        [JsonProperty("quota_project_id")]
        public string QuotaProject { get; set; }

        /// <summary>
        /// Client Id associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>
        /// or with an external account credential.
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>
        /// or with an external account credential.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Client Email associated with ServiceAccountCredential obtained from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>
        /// </summary>
        [JsonProperty("client_email")]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Private Key associated with ServiceAccountCredential obtained from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>.
        /// </summary>
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Private Key ID associated with ServiceAccountCredential obtained from
        /// <a href="https://console.developers.google.com">Google Developers Console</a>.
        /// </summary>
        [JsonProperty("private_key_id")]
        public string PrivateKeyId { get; set; }

        /// <summary>
        /// Refresh Token associated with UserCredential created by
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>.
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The STS audience associated with an external account credential.
        /// </summary>
        [JsonProperty("audience")]
        public string Audience { get; set; }

        /// <summary>
        /// The STS subject token type associated with an external account credential.
        /// </summary>
        [JsonProperty("subject_token_type")]
        public string SubjectTokenType { get; set; }

        /// <summary>
        /// The STS token exchange endpoint associated with an external account credential.
        /// </summary>
        [JsonProperty("token_url")]
        public string TokenUrl { get; set; }

        /// <summary>
        /// This is the URL for the service account impersonation request
        /// associated with an external account credential.
        /// If this is not set, the STS returned access token
        /// should be directly used without impersonation.
        /// </summary>
        [JsonProperty("service_account_impersonation_url")]
        public string ServiceAccountImpersonationUrl { get; set; }

        /// <summary>
        /// The GCP project number to be used for Workforce Pools
        /// external credentials.
        /// </summary>
        /// <remarks>
        /// If this external account credential represents a Workforce Pool
        /// enabled identity and this values is not specified, then an API key needs to be
        /// used alongside this credential to call Google APIs.
        /// </remarks>
        [JsonProperty("workforce_pool_user_project")]
        public string WorkforcePoolUserProject { get; set; }

        /// <summary>
        /// The credential source associated with an external account credential.
        /// </summary>
        [JsonProperty("credential_source")]
        public CredentialSource CredentialSourceConfig { get; set; }

        /// <summary>
        /// Holder for the credential source parameters associated to an external account credentials.
        /// </summary>
        public class CredentialSource
        {
            /// <summary>
            /// The environment identifier for AWS external accounts.
            /// </summary>
            [JsonProperty("environment_id")]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// For URL-sourced credentials this is the URL from which to obtain the subject token from.
            /// For AWS credentials this is the URL from which to obtain the IAM role associated to the instance.
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// For URL-sourced credentilas this are headers to be included on the request to obtain the subject token.
            /// </summary>
            [JsonProperty("headers")]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// For file-sourced credentials this is the path to the file containing the subject token.
            /// </summary>
            [JsonProperty("file")]
            public string File { get; set; }

            /// <summary>
            /// For URL and file sourced credentials, indicates the format in which the subject token will be returned.
            /// </summary>
            [JsonProperty("format")]
            public SubjectTokenFormat Format { get; set; }

            /// <summary>
            /// Holder for the subject token format.
            /// </summary>
            public class SubjectTokenFormat
            {
                /// <summary>
                /// For URL and file sourced credentials, indicates the format in which the subject token is returned.
                /// Supported values are <code>text</code> and <code>json</code>.
                /// Defaults to <code>text</code>.
                /// </summary>
                [JsonProperty("type")]
                public string Type { get; set; }

                /// <summary>
                /// For URL and file sourced credentials, if the subject token is returned within a JSON, this indicates the
                /// field in which it can be found.
                /// </summary>
                [JsonProperty("subject_token_field_name")]
                public string SubjectTokenFieldName { get; set; }
            }
        }
    }
}
