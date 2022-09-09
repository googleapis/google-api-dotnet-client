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
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// File-sourced credentials as described in the
    /// "Determining the subject token in file-sourced credentials" section of
    /// https://google.aip.dev/auth/4117.
    /// </summary>
    public sealed class FileSourcedExternalAccountCredential : ExternalAccountCredential, IGoogleCredential
    {
        new internal class Initializer : ExternalAccountCredential.Initializer
        {
            /// <summary>
            /// The file from which to obtain the subject token.
            /// </summary>
            internal string SubjectTokenFilePath { get; }

            /// <summary>
            /// If set, the subject token file content will be parsed as JSON and the
            /// value in the field with name <see cref="SubjectTokenJsonFieldName"/>
            /// will be returned as the subject token.
            /// </summary>
            internal string SubjectTokenJsonFieldName { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType, string subjectTokenFilePath)
                : base(tokenUrl, audience, subjectTokenType) => SubjectTokenFilePath = subjectTokenFilePath;

            internal Initializer(Initializer other) : base(other)
            {
                SubjectTokenFilePath = other.SubjectTokenFilePath;
                SubjectTokenJsonFieldName = other.SubjectTokenJsonFieldName;
            }

            internal Initializer(FileSourcedExternalAccountCredential other) : base(other)
            {
                SubjectTokenFilePath = other.SubjectTokenFilePath;
                SubjectTokenJsonFieldName = other.SubjectTokenJsonFieldName;
            }
        }

        /// <summary>
        /// The file path from which to obtain the subject token.
        /// </summary>
        public string SubjectTokenFilePath { get; }

        /// <summary>
        /// If set, the subject token file content will be parsed as JSON and the
        /// value in the field with name <see cref="SubjectTokenJsonFieldName"/>
        /// will be returned as the subject token.
        /// </summary>
        public string SubjectTokenJsonFieldName { get; }

        internal FileSourcedExternalAccountCredential(Initializer initializer) : base(initializer)
        {
            SubjectTokenFilePath = initializer.SubjectTokenFilePath;
            SubjectTokenJsonFieldName = initializer.SubjectTokenJsonFieldName;
        }

        /// <inheritdoc/>
        private protected override GoogleCredential WithoutImpersonationConfigurationImpl() =>
            ServiceAccountImpersonationUrl is null
            ? new GoogleCredential(this)
            : new GoogleCredential(new FileSourcedExternalAccountCredential(new Initializer(this)
            {
                ServiceAccountImpersonationUrl = null
            }));

        /// <inheritdoc/>
        protected override async Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken)
        {
            var fileContent = await ReadSubjectTokenFileContentAsync().ConfigureAwait(false);
            string subjectToken;

            if (string.IsNullOrEmpty(SubjectTokenJsonFieldName))
            {
                subjectToken = fileContent;
            }
            else
            {
                var jsonResponse = NewtonsoftJsonSerializer.Instance.Deserialize<Dictionary<string, string>>(fileContent);

                subjectToken = jsonResponse[SubjectTokenJsonFieldName];
            }

            return subjectToken;

            async Task<string> ReadSubjectTokenFileContentAsync()
            {
                using var reader = File.OpenText(SubjectTokenFilePath);
                return await reader.ReadToEndAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        string IGoogleCredential.QuotaProject => QuotaProject;

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => SupportsExplicitScopes;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new FileSourcedExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new FileSourcedExternalAccountCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            WithUserForDomainWideDelegation(user);

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new FileSourcedExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });
    }
}
