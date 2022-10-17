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

using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// AWS credentials as described in
    /// https://google.aip.dev/auth/4117#determining-the-subject-token-in-aws.
    /// </summary>
    public sealed partial class AwsExternalAccountCredential : ExternalAccountCredential, IGoogleCredential
    {
        internal const string SupportedVersion = "aws1";
        private const string RegionalCredentialVerificationUrlRegionPlaceholder = "{region}";

        new internal class Initializer : ExternalAccountCredential.Initializer
        {
            /// <summary>
            /// Metadata server URL used to obtained the region that should be included as part of
            /// the subject token.
            /// </summary>
            internal string RegionUrl { get; set; }

            /// <summary>
            /// STS server will use this URL to validate the subject token included
            /// on the STS request. This URL will be included as part of the subject token.
            /// </summary>
            internal string RegionalCredentialVerificationUrl { get; }

            /// <summary>
            /// Metadata server URL from which to obtain the security credentials that will
            /// be used to sign the subject token.
            /// </summary>
            internal string SecurityCredentialsUrl { get; set; }

            /// <summary>
            /// If present, a session token fetched from this URL should be used when making
            /// requests to the metadata server.
            /// </summary>
            internal string ImdsV2SessionTokenUrl { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType, string regionalCredentialVerificationUrl)
                : base(tokenUrl, audience, subjectTokenType) =>
                RegionalCredentialVerificationUrl = regionalCredentialVerificationUrl.ThrowIfNull(nameof(regionalCredentialVerificationUrl));


            internal Initializer(Initializer other) : base(other)
            {
                RegionUrl = other.RegionUrl;
                RegionalCredentialVerificationUrl = other.RegionalCredentialVerificationUrl;
                SecurityCredentialsUrl = other.SecurityCredentialsUrl;
                ImdsV2SessionTokenUrl = other.ImdsV2SessionTokenUrl;
            }

            internal Initializer(AwsExternalAccountCredential other) : base(other)
            {
                RegionUrl = other.RegionUrl;
                RegionalCredentialVerificationUrl = other.RegionalCredentialVerificationUrl;
                SecurityCredentialsUrl = other.SecurityCredentialsUrl;
                ImdsV2SessionTokenUrl = other.ImdsV2SessionTokenUrl;
            }
        }

        /// <summary>
        /// Metadata server URL used to obtained the region that should be included as part of
        /// the subject token.
        /// </summary>
        internal string RegionUrl { get; }

        /// <summary>
        /// STS server will use this URL to validate the subject token included
        /// on the STS request. This URL will be included as part of the subject token.
        /// </summary>
        internal string RegionalCredentialVerificationUrl { get; }

        /// <summary>
        /// Metadata server URL from which to obtain the security credentials that will
        /// be used to sign the subject token.
        /// </summary>
        internal string SecurityCredentialsUrl { get; }

        /// <summary>
        /// If present, a session token fetched from this URL should be used when making
        /// requests to the metadata server.
        /// </summary>
        internal string ImdsV2SessionTokenUrl { get; }

        internal AwsExternalAccountCredential(Initializer initializer) : base(initializer)
        {
            AwsMetadataServerClient.ValidateMetadataServerUrlIfAny(initializer.ImdsV2SessionTokenUrl, "IMDS V2 Session Token");
            AwsMetadataServerClient.ValidateMetadataServerUrlIfAny(initializer.RegionUrl, "Region");
            AwsMetadataServerClient.ValidateMetadataServerUrlIfAny(initializer.SecurityCredentialsUrl, "Security Credentials");

            RegionUrl = initializer.RegionUrl;
            RegionalCredentialVerificationUrl = initializer.RegionalCredentialVerificationUrl;
            SecurityCredentialsUrl = initializer.SecurityCredentialsUrl;
            ImdsV2SessionTokenUrl = initializer.ImdsV2SessionTokenUrl;
        }

        /// <inheritdoc/>
        private protected override GoogleCredential WithoutImpersonationConfigurationImpl() =>
            ServiceAccountImpersonationUrl is null
            ? new GoogleCredential(this)
            : new GoogleCredential(new AwsExternalAccountCredential(new Initializer(this)
            {
                ServiceAccountImpersonationUrl = null
            }));

        /// <inheritdoc/>
        protected async override Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken)
        {
            // We might not need to use the metadata server at all,
            // but initializing this client here triggers no requests, etc.
            // and makes the code cleaner.
            var metadataClient = new AwsMetadataServerClient(ImdsV2SessionTokenUrl, HttpClient, taskCancellationToken);

            var awsRegion = await AwsRegion.FetchAsync(metadataClient, RegionUrl).ConfigureAwait(false);
            var awsSecurityCredentials = await AwsSecurityCredentials.FetchAsync(metadataClient, SecurityCredentialsUrl).ConfigureAwait(false);
            var regionalizedVerificationUrl = RegionalCredentialVerificationUrl.Replace(RegionalCredentialVerificationUrlRegionPlaceholder, awsRegion.Region);

            var subjectToken = AwsSignedSubjectToken.Create(awsSecurityCredentials, awsRegion, new Uri(regionalizedVerificationUrl), Audience, Clock);

            return Uri.EscapeDataString(NewtonsoftJsonSerializer.Instance.Serialize(subjectToken));
        }

        /// <inheritdoc/>
        string IGoogleCredential.QuotaProject => QuotaProject;

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => SupportsExplicitScopes;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new AwsExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new AwsExternalAccountCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            WithUserForDomainWideDelegation(user);

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new AwsExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

        /// <summary>
        /// Returns the value of the given environment variable. Returns null if the
        /// variable is unset or if it's set to the empty string.
        /// </summary>
        private static string GetNonEmptyEnvVarValue(string envVar)
        {
            if (Environment.GetEnvironmentVariable(envVar) is string value && value != "")
            {
                return value;
            }
            return null;
        }
    }
}
