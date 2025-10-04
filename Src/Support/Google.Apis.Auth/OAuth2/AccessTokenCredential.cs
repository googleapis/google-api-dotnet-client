﻿/*
Copyright 2021 Google LLC

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
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents a credential that simply wraps an access token.
    /// The origin of said access token is not relevant, but that means
    /// that the credential cannot refresh the access token when it has expired.
    /// </summary>
    internal class AccessTokenCredential : IGoogleCredential, IHttpExecuteInterceptor
    {
        private readonly string _accessToken;
        private readonly IAccessMethod _accessMethod;
        private readonly string _universeDomain;

        /// <inheritdoc/>
        public string QuotaProject { get; }

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => false;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => false;

        public AccessTokenCredential(
            string accessToken, IAccessMethod accessMethod, string quotaProject = null, string universeDomain = null)
        {
            _accessToken = accessToken;
            _accessMethod = accessMethod;
            QuotaProject = quotaProject;
            _universeDomain = universeDomain ?? GoogleAuthConsts.DefaultUniverseDomain;
        }

        /// <inheritdoc/>
        public GoogleCredential ToGoogleCredential() => new GoogleCredential(this);

        /// <inheritdoc/>
        Task<string> IGoogleCredential.GetUniverseDomainAsync(CancellationToken _) => Task.FromResult(_universeDomain);

        /// <inheritdoc/>
        string IGoogleCredential.GetUniverseDomain() => _universeDomain;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
            new AccessTokenCredential(_accessToken, _accessMethod, quotaProject, _universeDomain);

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) => this;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(AccessTokenCredential)} does not support Domain-Wide Delegation");

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) => this;

        /// <inheritdoc/>
        IGoogleCredential IGoogleCredential.WithUniverseDomain(string universeDomain) =>
            new AccessTokenCredential(_accessToken, _accessMethod, QuotaProject, universeDomain);

        public void Initialize(ConfigurableHttpClient httpClient) =>
            httpClient.MessageHandler.Credential = this;

        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            Task.FromResult(_accessToken);

        /// <inheritdoc />
        public Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            Task.FromResult(new AccessTokenWithHeaders.Builder { QuotaProject = QuotaProject }.Build(_accessToken));

        // Only method in IHttpExecuteInterceptor
        public Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken)
        {
            var accessToken = new AccessTokenWithHeaders.Builder { QuotaProject = QuotaProject }.Build(_accessToken);
            _accessMethod.Intercept(request, accessToken.AccessToken);
            accessToken.AddHeaders(request);

            return Task.FromResult(true);
        }
    }
}
