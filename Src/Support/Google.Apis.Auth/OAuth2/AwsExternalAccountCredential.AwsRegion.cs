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

using Google.Apis.Util;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    public partial class AwsExternalAccountCredential
    {
        /// <summary>
        /// Helper class to obtain the AWS region.
        /// </summary>
        private sealed class AwsRegion
        {
            private static readonly string[] OrderedRegionEnvVars = new string[] { "AWS_REGION", "AWS_DEFAULT_REGION" };

            /// <summary>
            /// The region obtained from stripping the last character of the zone value
            /// return by the metadata server. For instance, if the metadata server returned
            /// zone us-east-1d, then this value will be us-east-1.
            /// Will never be null, but may be empty if the metadata server returned a single
            /// character value.
            /// </summary>
            internal string Region { get; }

            private AwsRegion(string region) => Region = region;

            /// <summary>
            /// Fetches the AWS instance region as per https://google.aip.dev/auth/4117#determining-the-subject-token-in-aws.
            /// </summary>
            internal static async Task<AwsRegion> FetchAsync(AwsMetadataServerClient metadataClient, string regionUrl) =>
                MaybeFromEnvVars()
                ?? await MaybeFromMetadataAsync(metadataClient, regionUrl).ConfigureAwait(false)
                ?? throw new InvalidOperationException($"Couldn't determine the AWS region. " +
                    $"None of the following environment variables have been set: {string.Join(",", OrderedRegionEnvVars)}. " +
                    $"And the {nameof(RegionUrl)} was not specified in the credential configuration " +
                    "or a region value couldn't be fetched from it.");

            /// <summary>
            /// Attempts to fetch the region from environment variables.
            /// Returns null if the environment variables are not set.
            /// </summary>
            internal static AwsRegion MaybeFromEnvVars()
            {
                foreach (var envVar in OrderedRegionEnvVars)
                {
                    if (GetNonEmptyEnvVarValue(envVar) is string region)
                    {
                        return new AwsRegion(region);
                    }
                }

                return null;
            }

            /// <summary>
            /// Attempts to fetch the region from the metadata server.
            /// Returns null if the region URL is null or empty.
            /// </summary>
            internal static async Task<AwsRegion> MaybeFromMetadataAsync(AwsMetadataServerClient metadataClient, string regionUrl)
            {
                if (!string.IsNullOrEmpty(regionUrl)
                    && await metadataClient.FetchMetadataAsync(regionUrl).ConfigureAwait(false) is string metadataRegion
                    && metadataRegion != "")
                {
                    // We need to remove the last character from the value obtained, which is the zone.
                    // For instance, if the value obtained is us-east-1d (zone) then the region is us-east-1.
                    return new AwsRegion(metadataRegion.Substring(0, metadataRegion.Length - 1));
                }

                return null;
            }
        }
    }
}
