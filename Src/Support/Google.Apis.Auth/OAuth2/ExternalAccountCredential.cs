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

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Exception thrown when the subject token cannot be obtained for a given
    /// external account credential.
    /// </summary>
    public class SubjectTokenException : Exception
    {
        internal SubjectTokenException(ExternalAccountCredential credential, Exception innerException) : base(
            $"An error occurred while attempting to obtain the subject token for {credential.ThrowIfNull(nameof(credential)).GetType().Name}",
            innerException)
        { }
    }

    /// <summary>
    /// Base class for external account credentials.
    /// </summary>
    public abstract class ExternalAccountCredential : ServiceCredential
    {
        private const string GrantType = "urn:ietf:params:oauth:grant-type:token-exchange";
        private const string RequestedTokenType = "urn:ietf:params:oauth:token-type:access_token";

        /// <summary>
        /// Initializer for <see cref="ExternalAccountCredential"/>.
        /// </summary>
        new internal abstract class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// The STS audience which contains the resource name for the
            /// workload identity pool or the workforce pool
            /// and the provider identifier in that pool.
            /// </summary>
            internal string Audience { get; }

            /// <summary>
            /// The STS subject token type based on the OAuth 2.0 token exchange spec.
            /// </summary>
            internal string SubjectTokenType { get; }

            /// <summary>
            /// This is the URL for the service account impersonation request.
            /// If this is not set, the STS-returned access token
            /// should be directly used without impersonation.
            /// </summary>
            internal string ServiceAccountImpersonationUrl { get; set; }

            /// <summary>
            /// The GCP project number to be used for Workforce Identity Pools
            /// external credentials.
            /// </summary>
            /// <remarks>
            /// If this external account credential represents a Workforce Identity Pool
            /// enabled identity and this values is not specified, then an API key needs to be
            /// used alongside this credential to call Google APIs.
            /// </remarks>
            public string WorkforcePoolUserProject { get; set; }

            /// <summary>
            /// The Client ID.
            /// </summary>
            /// <remarks>
            /// Client ID and client secret are currently only required if the token info endpoint
            /// needs to be called with the generated GCP access token.
            /// When provided, STS will be called with additional basic authentication using
            /// ClientId as username and ClientSecret as password.
            /// </remarks>
            internal string ClientId { get; set; }

            /// <summary>
            /// The client secret.
            /// </summary>
            /// <remarks>
            /// Client ID and client secret are currently only required if the token info endpoint
            /// needs to be called with the generated GCP access token.
            /// When provided, STS will be called with additional basic authentication using
            /// ClientId as username and ClientSecret as password.
            /// </remarks>
            internal string ClientSecret { get; set; }

            internal Initializer(string tokenUrl, string audience, string subjectTokenType) : base(tokenUrl)
            {
                Audience = audience;
                SubjectTokenType = subjectTokenType;
            }

            internal Initializer(Initializer other) : base(other)
            {
                Audience = other.Audience;
                SubjectTokenType = other.SubjectTokenType;
                ServiceAccountImpersonationUrl = other.ServiceAccountImpersonationUrl;
                WorkforcePoolUserProject = other.WorkforcePoolUserProject;
                ClientId = other.ClientId;
                ClientSecret = other.ClientSecret;
            }

            internal Initializer(ExternalAccountCredential other) : base(other)
            {
                Audience = other.Audience;
                SubjectTokenType = other.SubjectTokenType;
                ServiceAccountImpersonationUrl= other.ServiceAccountImpersonationUrl;
                WorkforcePoolUserProject= other.WorkforcePoolUserProject;
                ClientId = other.ClientId;
                ClientSecret = other.ClientSecret;
            }
        }

        /// <summary>
        /// The STS audience which contains the resource name for the
        /// workload identity pool or the workforce pool
        /// and the provider identifier in that pool.
        /// </summary>
        public string Audience { get; }

        /// <summary>
        /// The STS subject token type based on the OAuth 2.0 token exchange spec.
        /// </summary>
        public string SubjectTokenType { get; }

        /// <summary>
        /// This is the URL for the service account impersonation request.
        /// If this is not set, the STS-returned access token
        /// should be directly used without impersonation.
        /// </summary>
        public string ServiceAccountImpersonationUrl { get; }

        /// <summary>
        /// The GCP project number to be used for Workforce Pools
        /// external credentials.
        /// </summary>
        /// <remarks>
        /// If this external account credential represents a Workforce Pool
        /// enabled identity and this values is not specified, then an API key needs to be
        /// used alongside this credential to call Google APIs.
        /// </remarks>
        public string WorkforcePoolUserProject { get; }


        /// <summary>
        /// The Client ID.
        /// </summary>
        /// <remarks>
        /// Client ID and Client secret are currently only required if the token info endpoint
        /// needs to be called with the generated GCP access token.
        /// When provided, STS will be called with additional basic authentication using
        /// ClientId as username and ClientSecret as password.
        /// </remarks>
        public string ClientId { get; }

        /// <summary>
        /// The client secret.
        /// </summary>
        /// <remarks>
        /// Client ID and Client secret are currently only required if the token info endpoint
        /// needs to be called with the generated GCP access token.
        /// When provided, STS will be called with additional basic authentication using
        /// ClientId as username and ClientSecret as password.
        /// </remarks>
        public string ClientSecret { get; }

        /// <summary>
        /// Returns true if this credential allows explicit scopes to be set
        /// via this library.
        /// Returns false otherwise.
        /// </summary>
        private protected bool SupportsExplicitScopes => true;

        /// <summary>
        /// If <see cref="ServiceAccountImpersonationUrl"/> is set, returns a <see cref="GoogleCredential"/> based on this
        /// one, but with <see cref="ServiceAccountImpersonationUrl"/> set to null. Otherwise returns a <see cref="GoogleCredential"/>
        /// based on this one.
        /// </summary>
        internal Lazy<GoogleCredential> WithoutImpersonationConfiguration { get; }

        /// <summary>
        /// If <see cref="ServiceAccountImpersonationUrl"/> is set, returns an <see cref="ImpersonatedCredential"/>
        /// whose source credential is <see cref="WithoutImpersonationConfiguration"/>.
        /// Otherwise returns null.
        /// </summary>
        internal Lazy<ImpersonatedCredential> ImplicitlyImpersonated { get; }

        internal ExternalAccountCredential(Initializer initializer) : base(initializer)
        {
            Audience = initializer.Audience;
            SubjectTokenType = initializer.SubjectTokenType;
            ServiceAccountImpersonationUrl = initializer.ServiceAccountImpersonationUrl;
            WorkforcePoolUserProject = initializer.WorkforcePoolUserProject;
            ClientId = initializer.ClientId;
            ClientSecret = initializer.ClientSecret;
            WithoutImpersonationConfiguration = new Lazy<GoogleCredential>(WithoutImpersonationConfigurationImpl, LazyThreadSafetyMode.ExecutionAndPublication);
            ImplicitlyImpersonated = new Lazy<ImpersonatedCredential>(ImplicitlyImpersonatedImpl, LazyThreadSafetyMode.ExecutionAndPublication);
        }

        /// <summary>
        /// If <see cref="ServiceAccountImpersonationUrl"/> is set, returns a <see cref="GoogleCredential"/> based on this
        /// one, but with <see cref="ServiceAccountImpersonationUrl"/> set to null. Otherwise returns a <see cref="GoogleCredential"/>
        /// based on this one.
        /// </summary>
        private protected abstract GoogleCredential WithoutImpersonationConfigurationImpl();

        /// <summary>
        /// If <see cref="ServiceAccountImpersonationUrl"/> is set, returns an <see cref="ImpersonatedCredential"/>
        /// whose source credential is <see cref="WithoutImpersonationConfiguration"/>.
        /// Otherwise returns null.
        /// </summary>
        private protected ImpersonatedCredential ImplicitlyImpersonatedImpl()
        {
            if (ServiceAccountImpersonationUrl is null)
            {
                return null;
            }

            var initializer = new ImpersonatedCredential.Initializer(
                ServiceAccountImpersonationUrl, ExtractTargetPrincipal(ServiceAccountImpersonationUrl))
            {
                // We copy this credential settings to the impersonated one.
                AccessMethod = AccessMethod,
                Clock = Clock,
                DefaultExponentialBackOffPolicy = DefaultExponentialBackOffPolicy,
                HttpClientFactory = HttpClientFactory,
                QuotaProject = QuotaProject,
                Scopes = Scopes
            };
            foreach (var httpInitializer in HttpClientInitializers)
            {
                initializer.HttpClientInitializers.Add(httpInitializer);
            }


            return ImpersonatedCredential.Create(WithoutImpersonationConfiguration.Value, initializer);

            // Tries to extract the target principal ID from the impersonation URL which is possible if the URL looks like
            // https://host/segment-1/.../segment-n/target-principal-ID:generateAccessToken.
            // It's OK if we can't though as for fetching the impersonated access token we have the impersonation URL as a whole.
            // It's just a nice to have, as we may get extra operations, that we don't use now, but might use in the future.
            // Regardless we don't expose the resulting impersonated credential so users won't be affected by any of this.
            static string ExtractTargetPrincipal(string url)
            {
                int start = url.LastIndexOf("/") + 1;
                if (start == 0 || start >= url.Length)
                {
                    return null;
                }
                int afterEnd = url.IndexOf($":{GoogleAuthConsts.IamAccessTokenVerb}");
                if (afterEnd == -1 || afterEnd <= start)
                {
                    return null;
                }
                return url.Substring(start, afterEnd - start);
            }
        }

        /// <summary>
        /// Gets the subject token to be exchanged for the access token.
        /// </summary>
        protected abstract Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken);

        private async Task<string> GetSubjectTokenAsync(CancellationToken taskCancellationTokne)
        {
            try
            {
                return await GetSubjectTokenAsyncImpl(taskCancellationTokne).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new SubjectTokenException(this, ex);
            }
        }

        private protected async Task<TokenResponse> RequestStsAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            StsTokenRequest request = new StsTokenRequestBuilder
            {
                Audience = Audience,
                GrantType = GrantType,
                RequestedTokenType = RequestedTokenType,
                Scopes = Scopes,
                SubjectToken = await GetSubjectTokenAsync(taskCancellationToken).ConfigureAwait(false),
                SubjectTokenType = SubjectTokenType,
                WorkforcePoolUserProject = WorkforcePoolUserProject,
                ClientId = ClientId,
                ClientSecret = ClientSecret,
            }.Build();

            return await request
                .ExecuteAsync(HttpClient, TokenServerUrl, Clock, Logger, taskCancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var impersonated = ImplicitlyImpersonated.Value;

            if (impersonated is null)
            {
                Token = await RequestStsAccessTokenAsync(taskCancellationToken).ConfigureAwait(false);
                return true;
            }

            if (await impersonated.RequestAccessTokenAsync(taskCancellationToken).ConfigureAwait(false))
            {
                Token = impersonated.Token;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Throws <see cref="InvalidOperationException"/> as <see cref="ExternalAccountCredential"/> does not
        /// support domain wide delegation.
        /// </summary>
        private protected IGoogleCredential WithUserForDomainWideDelegation(string user) =>
            throw new InvalidOperationException($"{nameof(ExternalAccountCredential)} does not support Domain-Wide Delegation");
    }
}
