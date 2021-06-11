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

using Google.Apis.Http;
using System;
using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents a Google credential. Defines functionality that
    /// credential types that can be used as an underlying credential in <see cref="GoogleCredential"/>
    /// should implement in contrast to <see cref="ICredential"/> that defines public functionality.
    /// </summary>
    internal interface IGoogleCredential : ICredential, ITokenAccessWithHeaders
    {
        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        string QuotaProject { get; }

        /// <summary>
        /// Returns a new instance of the same type as this but with the
        /// given quota project value.
        /// </summary>
        /// <param name="quotaProject">The quota project value for the new instance.</param>
        /// <returns>A new instance with the same type as this but with <see cref="QuotaProject"/>
        /// set to <paramref name="quotaProject"/>.</returns>
        IGoogleCredential WithQuotaProject(string quotaProject);

        /// <summary>
        /// Returns true if this credential scopes have been explicitly set via this library.
        /// Returns false otherwise.
        /// </summary>
        bool HasExplicitScopes { get; }

        /// <summary>
        /// Returns true if this credential accepts explicit scopes to be set
        /// via this library.
        /// Returns false otherwise.
        /// </summary>
        bool SupportsExplicitScopes { get; }

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        IGoogleCredential MaybeWithScopes(IEnumerable<string> scopes);

        /// <summary>
        /// If the credential supports domain wide delegation this method will create a copy of the
        /// credential with the specified user set.
        /// Otherwise, it throws <see cref="InvalidOperationException"/>.
        /// </summary>
        // TODO: Consider adding a IDomainWideDelegate interface. It's maybe of public interest to
        // work only with credentials that support domain wide delegation. This interface would
        // behave similar to IOIdcTokenProvider and IBlogSigner.
        IGoogleCredential WithUserForDomainWideDelegation(string user);

        /// <summary>
        /// Return a new instance of the same type as this but that uses the
        /// given HTTP client factory.
        /// </summary>
        /// <param name="httpClientFactory">The http client factory to be used by the new instance.
        /// May be null in which case the default <see cref="HttpClientFactory"/> will be used.</param>
        /// <returns>A new instance with the same type as this but that will use <paramref name="httpClientFactory"/>
        /// to obtain an <see cref="ConfigurableHttpClient"/> to be used for token and other operations.</returns>
        IGoogleCredential WithHttpClientFactory(IHttpClientFactory httpClientFactory);
    }
}
