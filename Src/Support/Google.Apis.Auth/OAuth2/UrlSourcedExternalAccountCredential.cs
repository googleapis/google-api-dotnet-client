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
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    internal class UrlSourcedExternalAccountCredential : DirectUseExternalAccountCredential
    {
        new internal class Initializer : DirectUseExternalAccountCredential.Initializer
        {
            /// <summary>
            /// The URL from which to obtain the subject token.
            /// </summary>
            public string SubjectTokenUrl { get; }

            /// <summary>
            /// Headers to include in the request for the subject token.
            /// May be null or empty.
            /// </summary>
            public IDictionary<string, string> Headers { get; set; }

            /// <summary>
            /// If set, the subject token response will be parsed as JSON and the
            /// value in the field with name <see cref="SubjectTokenJsonFieldName"/>
            /// will be returned as the subject token.
            /// </summary>
            public string SubjectTokenJsonFieldName { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType, string subjectTokenUrl)
                : base(tokenUrl, audience, subjectTokenType) => SubjectTokenUrl = subjectTokenUrl;

            internal Initializer(Initializer other) : base(other)
            {
                SubjectTokenUrl = other.SubjectTokenUrl;
                Headers = other.Headers is null ? null : new Dictionary<string, string>(other.Headers);
                SubjectTokenJsonFieldName = other.SubjectTokenJsonFieldName;
            }

            internal Initializer(UrlSourcedExternalAccountCredential other) : base(other)
            {
                SubjectTokenUrl = other.SubjectTokenUrl;
                Headers = other.Headers is null ? null : new Dictionary<string, string>(other.Headers.ToDictionary(pair => pair.Key, pair => pair.Value));
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
        public override IGoogleCredential MaybeWithScopes(IEnumerable<string> scopes) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { Scopes = scopes });

        /// <inheritdoc/>
        public override IGoogleCredential WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

        /// <inheritdoc/>
        public override IGoogleCredential WithQuotaProject(string quotaProject) =>
            new UrlSourcedExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

        /// <inheritdoc/>
        protected async override Task<string> GetSubjectTokenAsync(CancellationToken taskCancellationToken)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, SubjectTokenUrl);
            foreach (var headerPair in Headers)
            {
                httpRequest.Headers.Add(headerPair.Key, headerPair.Value);
            }

            var response = await HttpClient.SendAsync(httpRequest, taskCancellationToken).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (string.IsNullOrEmpty(SubjectTokenJsonFieldName))
            {
                return responseText;
            }

            return NewtonsoftJsonSerializer.Instance.Deserialize<Dictionary<string, string>>(responseText)[SubjectTokenJsonFieldName];
        }
    }
}
