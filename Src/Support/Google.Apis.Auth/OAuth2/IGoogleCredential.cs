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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents a Google credential. Defines functionality that
    /// credential types that can be used as an underlying credential in <see cref="GoogleCredential"/>
    /// should implement in contrast to <see cref="ICredential"/> that defines public functionality.
    /// </summary>
    internal interface IGoogleCredential : ICredential, ITokenAccessWithHeaders, IHttpExecuteInterceptor
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
        /// Returns true if this credential allows explicit scopes to be set
        /// via this library.
        /// Returns false otherwise.
        /// </summary>
        bool SupportsExplicitScopes { get; }

        /// <summary>
        /// Returns the universe domain this credential belongs to.
        /// </summary>
        /// <remarks>
        /// For most credential types, this operation is synchronous and will always
        /// return a completed task.
        /// For <see cref="ComputeCredential"/>, the universe domain is obtained from the
        /// metadata server, which requires an HTTP call. This value is obtained only once,
        /// the first time it is requested for any instance of <see cref="ComputeCredential"/>.
        /// Once the universe has been fetched this method will always return a completed task.
        /// The task's result will never be null.
        /// Note that each <paramref name="cancellationToken"/> will only apply to the call
        /// that provided it and not to subsequent calls. For instance, even if the first call
        /// to <see cref="GetUniverseDomainAsync(CancellationToken)"/> is cancelled, subsequent
        /// calls may still succeed.
        /// </remarks>
        Task<string> GetUniverseDomainAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Returns the universe domain this credential belongs to.
        /// </summary>
        /// <remarks>
        /// Because <see cref="GetUniverseDomainAsync"/> is truly async only once, at most, in the lifetime
        /// of an application, this method exists for convenience.
        /// It can always be safely used for all credential types except for <see cref="ComputeCredential"/>.
        /// For <see cref="ComputeCredential"/>, the universe domain is obtained from the
        /// metadata server, which requires an HTTP call. This value is obtained only once,
        /// the first time it is requested for any instance of <see cref="ComputeCredential"/>.
        /// That first time, this method may block while waiting for the HTTP call to complete.
        /// After that, this method will always be safe to use.
        /// Will never return null.
        /// </remarks>
        string GetUniverseDomain();

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

        /// <summary>
        /// If the credential supports custom universe domains this method will create a copy of the
        /// credential with the specified universe domain set.
        /// Otherwise, it throws <see cref="InvalidOperationException"/>.
        /// </summary>
        /// <param name="universeDomain">The universe domain to use for the credential.
        /// May be null, in which case the default universe domain will be used.</param>
        IGoogleCredential WithUniverseDomain(string universeDomain);
    }
}
