/*
Copyright 2025 Google LLC

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
using Google.Apis.Util;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2;

/// <summary>
/// External account credentials that rely on user-provided code to obtain the third-party token.
/// </summary>
public sealed class ProgrammaticExternalAccountCredential : ExternalAccountCredential, IGoogleCredential
{
    /// <summary>
    /// Subject token provider which is passed to a <see cref="ProgrammaticExternalAccountCredential"/> as the means
    /// to obtain the third-party or external credentials token to include on the STS token exchange request.
    /// </summary>
    public interface ISubjectTokenProvider
    {
        /// <summary>
        /// Obtains the subject token for the third-party credentials that will be inclded on the STS token exchange request.
        /// The returned value will be included on the STS token exchange request as is.
        /// This method will only be called when no Google access token has been obtained or it has (or is about to) expired,
        /// </summary>
        /// <param name="caller">
        /// The credential calling this subject token provider. This may be useful to use state stored in the credential for
        /// obtaining the subject token, but should be ignored otherwise. Will not be null.
        /// </param>
        /// <param name="taskCancellationToken">
        /// The cancellation token for the operation.
        /// </param>
        Task<string> GetSubjectTokenAsync(ProgrammaticExternalAccountCredential caller, CancellationToken taskCancellationToken);
    }

    /// <summary>
    /// Initializer for <see cref="ProgrammaticExternalAccountCredential"/>.
    /// </summary>
    new public class Initializer : ExternalAccountCredential.Initializer
    {
        /// <summary>
        /// Builds an initializer for <see cref="ProgrammaticExternalAccountCredential"/>.
        /// </summary>
        /// <param name="tokenUrl">
        /// The STS token exchange endpoint. Must not be null or empty.
        /// </param>
        /// <param name="audience">
        /// The STS audience which contains the resource name for the workload identity pool and the provider identifier in that pool.
        /// Must not be null or empty.
        /// </param>
        /// <param name="subjectTokenType">
        /// The STS subject token type based on the <see href="https://datatracker.ietf.org/doc/html/rfc8693#section-3">OAuth 2.0 token exchange specification</see>.
        /// Must not be null or empty.
        /// </param>
        /// <param name="subjectTokenProvider">
        /// The provider of the third-party token that's included on the STS token exchange request.
        /// Must not be null.
        /// </param>
        public Initializer(string tokenUrl, string audience, string subjectTokenType, ISubjectTokenProvider subjectTokenProvider) : base(
            tokenUrl.ThrowIfNullOrEmpty(nameof(tokenUrl)),
            audience.ThrowIfNullOrEmpty(nameof(audience)),
            subjectTokenType.ThrowIfNullOrEmpty(nameof(subjectTokenType))) =>
            SubjectTokenProvider = subjectTokenProvider.ThrowIfNull(nameof(subjectTokenProvider));

        /// <summary>
        /// Builds and initializer for <see cref="ProgrammaticExternalAccountCredential"/> from the given initializer.
        /// </summary>
        public Initializer(Initializer other)
            : base(other.ThrowIfNull(nameof(other))) =>
            SubjectTokenProvider = other.SubjectTokenProvider;

        /// <summary>
        /// Builds and initializer for <see cref="ProgrammaticExternalAccountCredential"/> from the given credential.
        /// </summary>
        public Initializer(ProgrammaticExternalAccountCredential credential)
            : base(credential.ThrowIfNull(nameof(credential))) =>
            SubjectTokenProvider = credential.SubjectTokenProvider;

        /// <summary>
        /// The provider of the third-party token that's included on the STS token exchange request.
        /// Will not be null.
        /// </summary>
        public ISubjectTokenProvider SubjectTokenProvider { get; }
    }

    /// <summary>
    /// The provider of the third-party token that's included on the STS token exchange request.
    /// Will not be null.
    /// </summary>
    public ISubjectTokenProvider SubjectTokenProvider { get; }

    /// <inheritdoc/>
    bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

    /// <inheritdoc/>
    bool IGoogleCredential.SupportsExplicitScopes => SupportsExplicitScopes;

    /// <summary>
    /// Builds a <see cref="ProgrammaticExternalAccountCredential"/> instace from the given initializer.
    /// </summary>
    public ProgrammaticExternalAccountCredential(Initializer initializer)
        : base(initializer.ThrowIfNull(nameof(initializer))) =>
        SubjectTokenProvider = initializer.SubjectTokenProvider;

    /// <inheritdoc/>
    protected override Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken) =>
        SubjectTokenProvider.GetSubjectTokenAsync(this, taskCancellationToken);

    /// <inheritdoc/>
    private protected override GoogleCredential WithoutImpersonationConfigurationImpl() =>
        ServiceAccountImpersonationUrl is null
        ? new GoogleCredential(this)
        : new GoogleCredential(new ProgrammaticExternalAccountCredential(new Initializer(this)
        {
            ServiceAccountImpersonationUrl = null
        }));

    /// <inheritdoc/>
    IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
        new ProgrammaticExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

    /// <inheritdoc/>
    Task<string> IGoogleCredential.GetUniverseDomainAsync(CancellationToken cancellationToken) => Task.FromResult(UniverseDomain);

    /// <inheritdoc/>
    string IGoogleCredential.GetUniverseDomain() => UniverseDomain;

    /// <inheritdoc/>
    IGoogleCredential IGoogleCredential.MaybeWithScopes(IEnumerable<string> scopes) =>
        new ProgrammaticExternalAccountCredential(new Initializer(this) { Scopes = scopes });

    /// <inheritdoc/>
    IGoogleCredential IGoogleCredential.WithUserForDomainWideDelegation(string user) => WithUserForDomainWideDelegation(user);

    /// <inheritdoc/>
    IGoogleCredential IGoogleCredential.WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
        new ProgrammaticExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

    /// <inheritdoc/>
    IGoogleCredential IGoogleCredential.WithUniverseDomain(string universeDomain) =>
        new ProgrammaticExternalAccountCredential(new Initializer(this) { UniverseDomain = universeDomain });
}
