/*
Copyright 2022 Google LLC

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

using Google.Apis.Json;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    public partial class AwsExternalAccountCredential
    {
        /// <summary>
        /// Represents AWS security credentials which are used to sign
        /// the subject token.
        /// </summary>
        private sealed class AwsSecurityCredentials
        {
            private const string AccessKeyIdEnvVar = "AWS_ACCESS_KEY_ID";
            private const string SecretAccessKeyEnvVar = "AWS_SECRET_ACCESS_KEY";
            private const string TokenEnvVar = "AWS_SESSION_TOKEN";

            /// <summary>
            /// The access key ID. Won't be null or empty.
            /// </summary>
            internal string AccessKeyId { get; }

            /// <summary>
            /// The secret access key. Won't be null or empty.
            /// </summary>
            internal string SecretAccessKey { get; }

            /// <summary>
            /// The credential token. May be null but won't be empty.
            /// </summary>
            internal string Token { get; }

            private AwsSecurityCredentials(string accessKeyId, string secretAccessKey, string token)
            {
                AccessKeyId = accessKeyId;
                SecretAccessKey = secretAccessKey;
                Token = token;
            }

            /// <summary>
            /// Fetches the AWS security credentials as per https://google.aip.dev/auth/4117#determining-the-subject-token-in-aws.
            /// </summary>
            internal static async Task<AwsSecurityCredentials> FetchAsync(AwsMetadataServerClient metadataClient, string credentialUrl) =>
                MaybeFromEnvVars()
                ?? await MaybeFromMetadataAsync(metadataClient, credentialUrl).ConfigureAwait(false)
                ?? throw new InvalidOperationException($"Couldn't determine the AWS security credentials. " +
                    $"At least one of the following environment variables was not set: {AccessKeyIdEnvVar}, {SecretAccessKeyEnvVar}. " +
                    $"And the {nameof(SecurityCredentialsUrl)} was not specified in the credential configuration " +
                    "or no security credentials could be obtained from it.");

            /// <summary>
            /// Attempts to fetch the security credentials from environment variables.
            /// Returns null if the environment variables are not set.
            /// </summary>
            internal static AwsSecurityCredentials MaybeFromEnvVars()
            {
                if (GetNonEmptyEnvVarValue(AccessKeyIdEnvVar) is string accessKeyId
                    && GetNonEmptyEnvVarValue(SecretAccessKeyEnvVar) is string secretAccessKey)
                {
                    return new AwsSecurityCredentials(accessKeyId, secretAccessKey, GetNonEmptyEnvVarValue(TokenEnvVar));
                }

                return null;
            }

            /// <summary>
            /// Attempts to fetch the security credentials from the metadata server.
            /// Returns null if the credential URL is null or empty.
            /// </summary>
            internal static async Task<AwsSecurityCredentials> MaybeFromMetadataAsync(AwsMetadataServerClient metadataClient, string credentialUrl)
            {
                // https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html#instance-metadata-security-credentials
                if (!string.IsNullOrEmpty(credentialUrl)
                    // Build the actual credential endpoint.
                    && await BuildSecurityCredentialsEndpointAsync().ConfigureAwait(false) is string credentialEndpoint
                    // Fetch the credential JSON
                    && await metadataClient.FetchMetadataAsync(credentialEndpoint).ConfigureAwait(false) is string credentialJson
                    && credentialJson != "")
                {
                    // Deserialize the credentials
                    var deserializedCredentials = NewtonsoftJsonSerializer.Instance.Deserialize<AwsSecurityCredentialsResponse>(credentialJson);

                    if (deserializedCredentials.IsSuccess
                        && !string.IsNullOrEmpty(deserializedCredentials.AccessKeyId)
                        && !string.IsNullOrEmpty(deserializedCredentials.SecretAccessKey))
                    {
                        return new AwsSecurityCredentials(
                            deserializedCredentials.AccessKeyId, deserializedCredentials.SecretAccessKey,
                            deserializedCredentials.Token == "" ? null : deserializedCredentials.Token);
                    }

                    throw new InvalidOperationException(
                        $"The request to the metadata server security credentials endpoint {credentialEndpoint} was not successful. " +
                        $"The response was {credentialJson}");
                }

                return null;

                async Task<string> BuildSecurityCredentialsEndpointAsync()
                {
                    // https://github.com/aws/aws-sdk-java/blob/ccfd63c097874e3a1e9ffda7bf171769b6bd3b21/aws-java-sdk-core/src/main/java/com/amazonaws/auth/InstanceMetadataServiceCredentialsFetcher.java#L55
                    // Fetch the list of roles attached to the instance from the credential URL as given.
                    // Each role will be on a different line, and we keep the first one only.
                    if (await metadataClient.FetchMetadataAsync(credentialUrl).ConfigureAwait(false) is string metadataRoleList)
                    {
                        // Let's use StringReader so that we don't have to worry about which end of line charater(s) to use.
                        using var reader = new StringReader(metadataRoleList);
                        if (await reader.ReadLineAsync().ConfigureAwait(false) is string role && role != "")
                        {
                            // Attach the role to the given credential URL to fetch the actual credentials.
                            return credentialUrl.EndsWith("/") ? $"{credentialUrl}{role}" : $"{credentialUrl}/{role}";
                        }
                    }

                    return null;
                }
            }
            /// <summary>
            /// Partial representation of a metadata server security credentials response as defined by
            /// https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html#instance-metadata-security-credentials
            /// </summary>
            private struct AwsSecurityCredentialsResponse
            {
                internal const string SuccessStatusCode = "Success";

                [JsonIgnore]
                public bool IsSuccess => Code?.Equals(SuccessStatusCode, StringComparison.OrdinalIgnoreCase) == true;

                [JsonProperty("Code")]
                public string Code { get; set; }
                
                [JsonProperty("AccessKeyId")]
                public string AccessKeyId { get; set; }
                
                [JsonProperty("SecretAccessKey")]
                public string SecretAccessKey { get; set; }
                
                [JsonProperty("Token")]
                public string Token { get; set; }
            }
        }
    }
}
