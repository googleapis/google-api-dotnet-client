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
using System;
using System.Collections.Generic;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// External account credential that impersonates a service account.
    /// </summary>
    internal class ImpersonatedExternalAccountCredential : ImpersonatedCredentialBase, IExternalAccountCredential, IGoogleCredential
    {
        new internal class Initializer : ImpersonatedCredentialBase.Initializer
        {
            /// <summary>
            /// Gets or sets the source credential used to acquire the impersonated credentials.
            /// </summary>
            internal new DirectUseExternalAccountCredential SourceCredential => base.SourceCredential as DirectUseExternalAccountCredential;

            /// <inheritdoc/>
            internal override void SetSourceCredentialFrom(ICredential credential)
            {
                base.SetSourceCredentialFrom(credential);

                // It's safe to do this as on an ImpersonatedExternalAccountCredential
                // the scopes of the impersonated token should be those of the underlying
                // DirectUseExternalAccountCredential
                Scopes = (credential as DirectUseExternalAccountCredential)?.Scopes;
            }

            /// <summary>
            /// This is the URL for the service account impersonation request.
            /// If this is not available, the STS returned access token
            /// should be directly used without impersonation.
            /// </summary>
            public string ServiceAccountImpersonationUrl => TokenServerUrl;

            /// <summary>Constructs a new initializer.</summary>
            /// <param name="serviceAccountImpersonationUrl">The URL to obtain the impersonated access token from. Must not be null.</param>
            public Initializer(string serviceAccountImpersonationUrl)
                : base(serviceAccountImpersonationUrl)
            { }

            internal Initializer(ImpersonatedExternalAccountCredential other) : base(other)
            { }

            internal Initializer(Initializer other) : base(other)
            { }

            /// <inheritdoc/>
            private protected override ICredential ValidateAndScopeForImpersonation(ICredential credential) => credential switch
            {
                null => null,
                DirectUseExternalAccountCredential externalCred => externalCred.MaybeWithScopes(ImpersonationScopes),
                _ => throw new InvalidOperationException(
                    $"Only {nameof(DirectUseExternalAccountCredential)} may be used as the source credential for {nameof(ImpersonatedExternalAccountCredential)}")
            };
        }

        internal ImpersonatedExternalAccountCredential(Initializer initializer) : base(initializer) =>
            Configuration = new ImpersonatedExternalCredentialConfiguration(this);

        /// <inheritdoc/>
        internal new DirectUseExternalAccountCredential SourceCredential => base.SourceCredential as DirectUseExternalAccountCredential;

        /// <inheritdoc/>
        bool IGoogleCredential.HasExplicitScopes => HasExplicitScopes;

        /// <inheritdoc/>
        bool IGoogleCredential.SupportsExplicitScopes => true;

        /// <inheritdoc/>
        public ExternalAccountConfiguration Configuration { get; }

        public IGoogleCredential MaybeWithScopes(IEnumerable<string> scopes) =>
            new ImpersonatedExternalAccountCredential(new Initializer(this) { Scopes = scopes });

        public IGoogleCredential WithHttpClientFactory(IHttpClientFactory httpClientFactory) =>
            new ImpersonatedExternalAccountCredential(new Initializer(this) { HttpClientFactory = httpClientFactory });

        public IGoogleCredential WithQuotaProject(string quotaProject) =>
            new ImpersonatedExternalAccountCredential(new Initializer(this) { QuotaProject = quotaProject });

        public IGoogleCredential WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(IExternalAccountCredential)} does not support Domain-Wide Delegation");

        private class ImpersonatedExternalCredentialConfiguration : ExternalAccountConfiguration
        {
            private readonly ImpersonatedExternalAccountCredential _credential;

            internal ImpersonatedExternalCredentialConfiguration(ImpersonatedExternalAccountCredential credential) =>
                _credential = credential;

            /// <inheritdoc/>
            public override string Audience => _credential.SourceCredential.Configuration.Audience;

            /// <inheritdoc/>
            public override string SubjectTokenType => _credential.SourceCredential.Configuration.SubjectTokenType;

            /// <inheritdoc/>
            public override string TokenUrl => _credential.SourceCredential.Configuration.TokenUrl;

            /// <inheritdoc/>
            public override string ServiceAccountImpersonationUrl => _credential.TokenServerUrl;

            /// <inheritdoc/>
            public override string TokenInfoUrl => _credential.SourceCredential.Configuration.TokenInfoUrl;

            /// <inheritdoc/>
            public override string QuotaProject => _credential.QuotaProject;

            /// <inheritdoc/>
            public override string ClientId => _credential.SourceCredential.Configuration.ClientId;

            /// <inheritdoc/>
            public override string ClientSecret => _credential.SourceCredential.Configuration.ClientSecret;
        }
    }
}
