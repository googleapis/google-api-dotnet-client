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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// URL-sourced credentials as described in the
    /// "Determining the subject token in Microsoft Azure and URL-sourced credentials" section of
    /// https://google.aip.dev/auth/4117.
    /// </summary>
    public sealed class UrlSourcedExternalAccountCredential : ExternalAccountCredential, IGoogleCredential
    {
        new internal class Initializer : ExternalAccountCredential.Initializer
        {
            /// <summary>
            /// The URL from which to obtain the subject token.
            /// </summary>
            internal string SubjectTokenUrl { get; }

            /// <summary>
            /// Headers to include in the request for the subject token.
            /// May be null or empty.
            /// </summary>
            internal IDictionary<string, string> Headers { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            /// <summary>
            /// If set, the subject token response will be parsed as JSON and the
            /// value in the field with name <see cref="SubjectTokenJsonFieldName"/>
            /// will be returned as the subject token.
            /// </summary>
            internal string SubjectTokenJsonFieldName { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType, string subjectTokenUrl)
                : base(tokenUrl, audience, subjectTokenType) => SubjectTokenUrl = subjectTokenUrl;

            internal Initializer(Initializer other) : base(other)
            {
                SubjectTokenUrl = other.SubjectTokenUrl;
                Headers = other.Headers is null ? null : new Dictionary<string, string>(other.Headers, StringComparer.OrdinalIgnoreCase);
                SubjectTokenJsonFieldName = other.SubjectTokenJsonFieldName;
            }

            internal Initializer(UrlSourcedExternalAccountCredential other) : base(other)
            {
                SubjectTokenUrl = other.SubjectTokenUrl;
                Headers = other.Headers is null ? null : new Dictionary<string, string>(other.Headers.ToDictionary(pair => pair.Key, pair => pair.Value, StringComparer.OrdinalIgnoreCase));
                SubjectTokenJsonFieldName = other.SubjectTokenJsonFieldName;
            }
        }

        /// <summary>
        /// The URL from which to obtain the subject token.
        /// </summary>
        public string SubjectTokenUrl { get; }

        /// <summary>
        /// Headers to include in the request for the subject token.
        /// May be empty. Will not be null.
        /// </summary>
        public IReadOnlyDictionary<string, string> Headers { get; }

        /// <summary>
        /// If set, the subject token response will be parsed as JSON and the
        /// value in the field with name <see cref="SubjectTokenJsonFieldName"/>
        /// will be returned as the subject token.
        /// </summary>
        public string SubjectTokenJsonFieldName { get; }

        internal UrlSourcedExternalAccountCredential(Initializer initializer) : base(initializer)
        {
            SubjectTokenUrl = initializer.SubjectTokenUrl;
            Headers = initializer.Headers is null
                ? new ReadOnlyDictionary<string, string>(new Dictionary<string, string>())
                : new ReadOnlyDictionary<string, string>(initializer.Headers);
            SubjectTokenJsonFieldName = initializer.SubjectTokenJsonFieldName;
        }

        /// <inheritdoc/>
        private protected override GoogleCredential WithoutImpersonationConfigurationImpl() =>
            ServiceAccountImpersonationUrl is null
            ? new GoogleCredential(this)
            : new GoogleCredential(new UrlSourcedExternalAccountCredential(new Initializer(this)
            {
                ServiceAccountImpersonationUrl = null
            }));

        /// <inheritdoc/>
        protected async override Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, SubjectTokenUrl);
            foreach (var headerPair in Headers)
            {
                httpRequest.Headers.Add(headerPair.Key, headerPair.Value);
            }

            var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (string.IsNullOrEmpty(SubjectTokenJsonFieldName))
            {
                return responseText;
            }

            var jsonResponse = NewtonsoftJsonSerializer.Instance.Deserialize<Dictionary<string, string>>(responseText);

            return jsonResponse[SubjectTokenJsonFieldName];
        }

        /// <inheritdoc/>
        string IGoogleCredential.QuotaProject => QuotaProject;

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => SupportsExplicitScopes;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            WithUserForDomainWideDelegation(user);

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });
    }
}
