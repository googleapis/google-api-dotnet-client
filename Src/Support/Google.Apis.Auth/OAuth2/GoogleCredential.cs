﻿/*
Copyright 2015 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Http;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Credential for authorizing calls using OAuth 2.0.
    /// It is a convenience wrapper that allows handling of different types of 
    /// credentials (like <see cref="ServiceAccountCredential"/>, <see cref="ComputeCredential"/>
    /// or <see cref="UserCredential"/>) in a unified way.
    /// <para>
    /// See <see cref="GetApplicationDefaultAsync(CancellationToken)"/> for the credential retrieval logic.
    /// </para>
    /// </summary>
    public class GoogleCredential : ICredential, ITokenAccessWithHeaders, IOidcTokenProvider, IBlobSigner, IHttpExecuteInterceptor
    {
        /// <summary>Provider implements the logic for creating the application default credential.</summary>
        private static readonly DefaultCredentialProvider defaultCredentialProvider = new DefaultCredentialProvider();

        /// <summary>The underlying credential being wrapped by this object.</summary>
        private protected readonly IGoogleCredential credential;

        /// <summary>Creates a new <c>GoogleCredential</c>.</summary>
        internal GoogleCredential(IGoogleCredential credential) => this.credential = credential;

        /// <summary>
        /// Returns the Application Default Credentials which are ambient credentials that identify and authorize
        /// the whole application. See <see cref="GetApplicationDefaultAsync(CancellationToken)"/> for more details.
        /// </summary>
        /// <returns>A task which completes with the application default credentials.</returns>
        public static Task<GoogleCredential> GetApplicationDefaultAsync() =>
            defaultCredentialProvider.GetDefaultCredentialAsync();

        /// <summary>
        /// <para>Returns the Application Default Credentials which are ambient credentials that identify and authorize
        /// the whole application.</para>
        /// <para>The ambient credentials are determined as following order:</para>
        /// <list type="number">
        /// <item>
        /// <description>
        /// The environment variable GOOGLE_APPLICATION_CREDENTIALS is checked. If this variable is specified, it
        /// should point to a file that defines the credentials. The simplest way to get a credential for this purpose
        /// is to create a service account using the
        /// <a href="https://console.developers.google.com">Google Developers Console</a> in the section APIs &amp;
        /// Auth, in the sub-section Credentials. Create a service account or choose an existing one and select
        /// Generate new JSON key. Set the environment variable to the path of the JSON file downloaded.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// If you have installed the Google Cloud SDK on your machine and have run the command
        /// <a href="https://cloud.google.com/sdk/gcloud/reference/auth/login">GCloud Auth Login</a>, your identity can
        /// be used as a proxy to test code calling APIs from that machine.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// If you are running in Google Compute Engine production, the built-in service account associated with the
        /// virtual machine instance will be used.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// If all previous steps have failed, <c>InvalidOperationException</c> is thrown.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// If the cancellation token is cancelled while the underlying operation is loading Application Default Credentials,
        /// the underlying operation will still be used for any further requests. No actual work is cancelled via this cancellation
        /// token; it just allows the returned task to transition to a cancelled state.
        /// </remarks>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A task which completes with the application default credentials.</returns>
        public static Task<GoogleCredential> GetApplicationDefaultAsync(CancellationToken cancellationToken) =>
            defaultCredentialProvider.GetDefaultCredentialAsync().WithCancellationToken(cancellationToken);

        /// <summary>
        /// <para>Synchronously returns the Application Default Credentials which are ambient credentials that identify and authorize
        /// the whole application. See <see cref="GetApplicationDefaultAsync(CancellationToken)"/> for details on application default credentials.</para>
        /// <para>This method will block until the credentials are available (or an exception is thrown).
        /// It is highly preferable to call <see cref="GetApplicationDefaultAsync(CancellationToken)"/> where possible.</para>
        /// </summary>
        /// <returns>The application default credentials.</returns>
        public static GoogleCredential GetApplicationDefault() => Task.Run(() => GetApplicationDefaultAsync()).Result;

        /// <summary>
        /// Loads credential from stream containing JSON credential data.
        /// <para>
        /// The stream can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static GoogleCredential FromStream(Stream stream) => defaultCredentialProvider.CreateDefaultCredentialFromStream(stream);

        /// <summary>
        /// Loads credential from stream containing JSON credential data.
        /// <para>
        /// The stream can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static Task<GoogleCredential> FromStreamAsync(Stream stream, CancellationToken cancellationToken) =>
            defaultCredentialProvider.CreateDefaultCredentialFromStreamAsync(stream, cancellationToken);

        /// <summary>
        /// Loads credential from the specified file containing JSON credential data.
        /// <para>
        /// The file can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        /// <param name="path">The path to the credential file.</param>
        /// <returns>The loaded credentials.</returns>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static GoogleCredential FromFile(string path)
        {
            using (var f = File.OpenRead(path))
            {
                return FromStream(f);
            }
        }

        /// <summary>
        /// Loads credential from the specified file containing JSON credential data.
        /// <para>
        /// The file can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        /// <param name="path">The path to the credential file.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>The loaded credentials.</returns>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static async Task<GoogleCredential> FromFileAsync(string path, CancellationToken cancellationToken)
        {
            using (var f = File.OpenRead(path))
            {
                return await FromStreamAsync(f, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads credential from a string containing JSON credential data.
        /// <para>
        /// The string can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static GoogleCredential FromJson(string json) => defaultCredentialProvider.CreateDefaultCredentialFromJson(json);

        /// <summary>
        /// Loads a credential from JSON credential parameters. Fields are a union of credential fields
        /// for all supported types. <see cref="JsonCredentialParameters"/> for more detailed information
        /// about supported types and corresponding fields.
        /// </summary>
        /// <remarks>
        /// Important: If you accept a credential configuration (credential JSON/File/Stream) from an external source
        /// for authentication to Google Cloud, you must validate it before providing it to any Google API or library.
        /// Providing an unvalidated credential configuration to Google APIs can compromise the security of your
        /// systems and data. For more information, refer to
        /// <see href="https://cloud.google.com/docs/authentication/external/externally-sourced-credentials">Validate credential configurations from external sources</see>.
        /// </remarks>
        public static GoogleCredential FromJsonParameters(JsonCredentialParameters credentialParameters) =>
            defaultCredentialProvider.CreateDefaultCredentialFromParameters(credentialParameters);

        /// <summary>
        /// Create a <see cref="GoogleCredential"/> directly from the provided access token.
        /// The access token will not be automatically refreshed.
        /// </summary>
        /// <param name="accessToken">The access token to use within this credential.</param>
        /// <param name="accessMethod">Optional. The <see cref="IAccessMethod"/> to use within this credential.
        /// If <c>null</c>, will default to <see cref="BearerToken.AuthorizationHeaderAccessMethod"/>.</param>
        /// <returns>A credential based on the provided access token.</returns>
        public static GoogleCredential FromAccessToken(string accessToken, IAccessMethod accessMethod = null)
        {
            accessMethod ??= new BearerToken.AuthorizationHeaderAccessMethod();
            return new GoogleCredential(new AccessTokenCredential(accessToken, accessMethod, null, null));
        }

        /// <summary>
        /// Create a <see cref="GoogleCredential"/> from a <see cref="ComputeCredential"/>.
        /// In general, do not use this method. Call <see cref="GetApplicationDefault"/> or
        /// <see cref="GetApplicationDefaultAsync(CancellationToken)"/>, which will provide the most suitable
        /// credentials for the current platform.
        /// </summary>
        /// <param name="computeCredential">Optional. The compute credential to use in the returned <see cref="GoogleCredential"/>.
        /// If <c>null</c>, then a new <see cref="ComputeCredential"/> will be instantiated, using the default
        /// <see cref="ComputeCredential.Initializer"/>.</param>
        /// <returns>A <see cref="GoogleCredential"/> with an underlying <see cref="ComputeCredential"/>.</returns>
        public static GoogleCredential FromComputeCredential(ComputeCredential computeCredential = null) =>
            new GoogleCredential(computeCredential ?? new ComputeCredential());

        /// <summary>
        /// Create a <see cref="GoogleCredential"/> from a <see cref="ProgrammaticExternalAccountCredential"/>.
        /// </summary>
        /// <param name="credential">
        /// The credential to use in the returned <see cref="GoogleCredential"/>.
        /// Must not be null.
        /// </param>
        public static GoogleCredential FromProgrammaticExternalAccountCredential(ProgrammaticExternalAccountCredential credential) =>
            new GoogleCredential(credential.ThrowIfNull(nameof(credential)));

        /// <summary>
        /// <para>
        /// Returns <c>true</c> only if this credential supports explicit scopes to be set
        /// via this library but no explicit scopes have been set.
        /// A credential with explicit scopes set
        /// may be created by calling <see cref="CreateScoped(IEnumerable{string})"/>.
        /// </para>
        /// <para>
        /// For accessing Google services, credentials need to be scoped. Credentials 
        /// have some default scoping, but this library supports explicit scopes to be set
        /// for certain credentials.
        /// </para>
        /// <list type="number">
        /// <item>
        /// <description>
        /// <see cref="ComputeCredential"/> is scoped by default but in some environments it may be scoped
        /// explicitly, for instance when running on GKE with Workload Identity or on AppEngine Flex.
        /// It's possible to create a <see cref="ComputeCredential"/> with explicit scopes set by calling
        /// <see cref="CreateScoped(IEnumerable{string})"/>. If running on an environment that does not
        /// accept explicit scoping, for instance GCE where scopes are set on the VM, explicit scopes
        /// will be ignored.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <see cref="UserCredential"/> is scoped by default, as scopes were obtained during the consent
        /// screen. It's not possible to change the default scopes of a <see cref="UserCredential"/>.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <see cref="ServiceAccountCredential"/> is not scoped by default but when used without
        /// explicit scopes to access a Google service, the service's default scopes will be assumed.
        /// It's possible to create a <see cref="ServiceAccountCredential"/> with explicit scopes set
        /// by calling <see cref="CreateScoped(IEnumerable{string})"/>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <see cref="ImpersonatedCredential"/> is not scoped by default but when used without
        /// explicit scopes to access a Google service, the service's default scopes will be assumed.
        /// Note that the scopes of an <see cref="ImpersonatedCredential.SourceCredential"/> have no
        /// bearings on the <see cref="ImpersonatedCredential"/> scopes.
        /// It's possible to create an <see cref="ImpersonatedCredential"/> with explicit scopes set
        /// by calling <see cref="CreateScoped(IEnumerable{string})"/>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public virtual bool IsCreateScopedRequired => 
            credential.SupportsExplicitScopes && !credential.HasExplicitScopes;

        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        public string QuotaProject => credential.QuotaProject;

        /// <summary>
        /// Gets the underlying credential instance being wrapped.
        /// </summary>
        public ICredential UnderlyingCredential => credential;

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
        public Task<string> GetUniverseDomainAsync(CancellationToken cancellationToken) =>
            credential.GetUniverseDomainAsync(cancellationToken);

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
        public string GetUniverseDomain() => credential.GetUniverseDomain();

        /// <summary>
        /// If this library supports setting explicit scopes on this credential,
        /// this method will creates a copy of the credential with the specified scopes.
        /// Otherwise, it returns the same instance.
        /// See <see cref="IsCreateScopedRequired"/> for more information.
        /// </summary>
        public virtual GoogleCredential CreateScoped(IEnumerable<string> scopes)
        {
            var maybeScoped = credential.MaybeWithScopes(scopes);
            return maybeScoped == credential ? this : new GoogleCredential(maybeScoped);
        }

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        public GoogleCredential CreateScoped(params string[] scopes) => CreateScoped((IEnumerable<string>)scopes);

        /// <summary>
        /// If the credential supports Domain Wide Delegation, this method creates a copy of the credential
        /// with the specified user.
        /// Otherwise, it throws <see cref="InvalidOperationException"/>.
        /// At the moment only <see cref="ServiceAccountCredential"/> supports Domain Wide Delegation.
        /// </summary>
        /// <param name="user">The user that the returned credential will be a delegate for.</param>
        /// <returns>A copy of this credential with the user set to <paramref name="user"/>.</returns>
        /// <exception cref="InvalidOperationException">When the credential type doesn't support
        /// Domain Wide Delegation.</exception>
        public virtual GoogleCredential CreateWithUser(string user) => 
            new GoogleCredential(credential.WithUserForDomainWideDelegation(user));

        /// <summary>
        /// Creates a copy of this credential with the specified quota project.
        /// </summary>
        /// <param name="quotaProject">The quota project to use for the copy. May be null.</param>
        /// <returns>A copy of this credential with <see cref="QuotaProject"/> set to <paramref name="quotaProject"/>.</returns>
        public virtual GoogleCredential CreateWithQuotaProject(string quotaProject) =>
            new GoogleCredential(credential.WithQuotaProject(quotaProject));

        /// <summary>
        /// Creates a copy of this credential with the ambient quota project as set in
        /// <see cref="GoogleAuthConsts.QuotaProjectEnvironmentVariable"/>.
        /// If <see cref="GoogleAuthConsts.QuotaProjectEnvironmentVariable"/> is not set, or if
        /// it is set to the empty value, this method returns this instance.
        /// </summary>
        /// <remarks>
        /// The ADC quota project value will be overwritten only if the environment variable is present
        /// and set to a non-empty value.
        /// If the environment variable is not present or if it is present but unset, the credential
        /// returned will maintain whatever quota project value it already had, i.e. the credential's
        /// quota project value will not be unset.
        /// </remarks>
        public GoogleCredential CreateWithEnvironmentQuotaProject() =>
            GoogleAuthConsts.EnvironmentQuotaProject is string environmentQuotaProject
            ? CreateWithQuotaProject(environmentQuotaProject)
            : this;

        /// <summary>
        /// Creates a copy of this credential with the specified HTTP client factory.
        /// </summary>
        /// <param name="factory">The HTTP client factory to be used by the new credential.
        /// May be null, in which case the default <see cref="HttpClientFactory"/> will be used.</param>
        public virtual GoogleCredential CreateWithHttpClientFactory(IHttpClientFactory factory) =>
            new GoogleCredential(credential.WithHttpClientFactory(factory));

        /// <summary>
        /// If the credential supports custom universe domains this method will create a copy of the
        /// credential with the specified universe domain set.
        /// Otherwise, it throws <see cref="InvalidOperationException"/>.
        /// </summary>
        /// <param name="universeDomain">The universe domain to use for the credential.
        /// May be null, in which case the default universe domain will be used.</param>
        public GoogleCredential CreateWithUniverseDomain(string universeDomain) =>
            new GoogleCredential(credential.WithUniverseDomain(universeDomain));

        void IConfigurableHttpClientInitializer.Initialize(ConfigurableHttpClient httpClient)
        {
            credential.Initialize(httpClient);
        }

        Task<string> ITokenAccess.GetAccessTokenForRequestAsync(string authUri, CancellationToken cancellationToken) =>
            credential.GetAccessTokenForRequestAsync(authUri, cancellationToken);

        Task<AccessTokenWithHeaders> ITokenAccessWithHeaders.GetAccessTokenWithHeadersForRequestAsync(
            string authUri, CancellationToken cancellationToken) =>
            credential.GetAccessTokenWithHeadersForRequestAsync(authUri, cancellationToken);

        /// <inheritdoc/>
        public Task<OidcToken> GetOidcTokenAsync(OidcTokenOptions options, CancellationToken cancellationToken = default) =>
            (credential is IOidcTokenProvider provider) ?
            provider.GetOidcTokenAsync(options, cancellationToken) :
            throw new InvalidOperationException(
                $"{nameof(UnderlyingCredential)} is not an OIDC token provider. Only {nameof(ServiceAccountCredential)}, {nameof(ComputeCredential)}, {nameof(ImpersonatedCredential)} are supported OIDC token providers.");

        /// <inheritdoc/>
        public async Task<string> SignBlobAsync(byte[] blob, CancellationToken cancellationToken = default) =>
            UnderlyingCredential is IBlobSigner ?
                await (UnderlyingCredential as IBlobSigner).SignBlobAsync(blob, cancellationToken).ConfigureAwait(false) :
                throw new InvalidOperationException(
                    $"{nameof(UnderlyingCredential)} is not a blob signer. Only {nameof(ServiceAccountCredential)}, {nameof(ImpersonatedCredential)}, {nameof(ComputeCredential)} are supported blob signers.");

        /// <summary>
        /// Allows this credential to impersonate the <see cref="ImpersonatedCredential.Initializer.TargetPrincipal"/>.
        /// Only <see cref="ServiceAccountCredential"/> and <see cref="UserCredential"/> support impersonation,
        /// so this method will throw <see cref="InvalidOperationException"/> if this credential's
        /// <see cref="UnderlyingCredential"/> is not of one of those supported types.
        /// </summary>
        /// <param name="initializer">Initializer containing the configuration for the impersonated credential.</param>
        /// <remarks>
        /// For impersonation, a credential needs to be scoped to https://www.googleapis.com/auth/iam. When using a
        /// <see cref="ServiceAccountCredential"/> as the source credential, this is not a problem, since the credential
        /// can be scoped on demand. When using a <see cref="UserCredential"/> the credential needs to have been obtained
        /// with the required scope, else, when attempting and impersonated request, you'll receive an authorization error.
        /// </remarks>
        public GoogleCredential Impersonate(ImpersonatedCredential.Initializer initializer) =>
            new GoogleCredential(ImpersonatedCredential.Create(this, initializer));

        /// <summary>Creates a <c>GoogleCredential</c> wrapping a <see cref="ServiceAccountCredential"/>.</summary>
        public static GoogleCredential FromServiceAccountCredential(ServiceAccountCredential credential)
        {
            return new GoogleCredential(credential);
        }

        // Proxy IHttpExecuteInterceptor's only method.
        async Task IHttpExecuteInterceptor.InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request?.TryGetOption(GoogleAuthConsts.UniverseDomainKey, out string targetUniverseDomain) == true
                // b/377378462 Temporarily avoid automatic requests to the MDS UniverseDomain endpoint.
                && UnderlyingCredential is not ComputeCredential)
            {
                string credentialUniverseDomain = await credential.GetUniverseDomainAsync(cancellationToken).ConfigureAwait(false);
                if (targetUniverseDomain != credentialUniverseDomain)
                {
                    throw new InvalidOperationException(
                        $"The service client universe domain {targetUniverseDomain} does not match the credential universe domain {credentialUniverseDomain}.");
                }
            }
            await credential.InterceptAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
