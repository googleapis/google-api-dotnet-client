/*
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
    public class GoogleCredential : ICredential, ITokenAccessWithHeaders, IOidcTokenProvider
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
        public static GoogleCredential FromStream(Stream stream) => defaultCredentialProvider.CreateDefaultCredentialFromStream(stream);

        /// <summary>
        /// Loads credential from stream containing JSON credential data.
        /// <para>
        /// The stream can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
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
        public static GoogleCredential FromJson(string json) => defaultCredentialProvider.CreateDefaultCredentialFromJson(json);

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
            return new GoogleCredential(new AccessTokenCredential(accessToken, accessMethod));
        }

        internal class AccessTokenCredential : IGoogleCredential, IHttpExecuteInterceptor
        {
            private readonly string _accessToken;
            private readonly IAccessMethod _accessMethod;

            /// <inheritdoc/>
            public string QuotaProject { get; }

            public AccessTokenCredential(string accessToken, IAccessMethod accessMethod, string quotaProject = null)
            {
                _accessToken = accessToken;
                _accessMethod = accessMethod;
                QuotaProject = quotaProject;
            }

            /// <inheritdoc/>
            IGoogleCredential IGoogleCredential.WithQuotaProject(string quotaProject) =>
                new AccessTokenCredential(_accessToken, _accessMethod, quotaProject);

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
        /// <para>Returns <c>true</c> only if this credential type has no scopes by default and requires
        /// a call to <see cref="CreateScoped(IEnumerable{string})"/> before use.</para>
        ///
        /// <para>Credentials need to have scopes in them before they can be used to access Google services.
        /// Some Credential types have scopes built-in, and some don't. This property indicates whether
        /// the Credential type has scopes built-in.</para>
        /// 
        /// <list type="number">
        /// <item>
        /// <description>
        /// <see cref="ComputeCredential"/> has scopes built-in. Nothing additional is required.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <see cref="UserCredential"/> has scopes built-in, as they were obtained during the consent
        /// screen. Nothing additional is required.</description>
        /// </item>
        /// <item>
        /// <description>
        /// <see cref="ServiceAccountCredential"/> does not have scopes built-in by default. Caller should
        /// invoke <see cref="CreateScoped(IEnumerable{string})"/> to add scopes to the credential.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public virtual bool IsCreateScopedRequired => false;

        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        public string QuotaProject => credential.QuotaProject;

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        public virtual GoogleCredential CreateScoped(IEnumerable<string> scopes) => this;

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        public GoogleCredential CreateScoped(params string[] scopes) => CreateScoped((IEnumerable<string>)scopes);

        /// <summary>
        /// If the credential supports setting the user, creates a copy with the specified user.
        /// Otherwise, it throws <see cref="InvalidOperationException"/>.
        /// Only Service Credentials support this operation.
        /// </summary>
        /// <param name="user">The user to set in the returned credential.</param>
        /// <returns>This credential with the user set to <paramref name="user"/>.</returns>
        /// <exception cref="InvalidOperationException">When the credential type doesn't support setting the user.</exception>
        public virtual GoogleCredential CreateWithUser(string user) => throw new InvalidOperationException();

        /// <summary>
        /// Creates a copy of this credential with the specified quota project.
        /// </summary>
        /// <param name="quotaProject">The quota project to use for the copy. May be null.</param>
        /// <returns>A copy of this credential with <see cref="QuotaProject"/> set to <paramref name="quotaProject"/>.</returns>
        public virtual GoogleCredential CreateWithQuotaProject(string quotaProject) =>
            new GoogleCredential(credential.WithQuotaProject(quotaProject));

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
                $"{nameof(UnderlyingCredential)} is not an OIDC token provider. Only {nameof(ServiceAccountCredential)}, {nameof(ComputeCredential)} are supported OIDC token providers.");

        /// <summary>
        /// Gets the underlying credential instance being wrapped.
        /// </summary>
        public ICredential UnderlyingCredential => credential;

        /// <summary>Creates a <c>GoogleCredential</c> wrapping a <see cref="ImpersonatedCredential"/>.</summary>
        /// <param name="TargetPrincipal">The service account to impersonate.</param>
        /// <param name="Delegates">The chained list of delegates.</param>
        /// <param name="Scopes">The scopes to request during the authorization grant.</param>
        /// <param name="LifetimeInSeconds">
        /// The number of seconds the delegated credential should be valid.
        /// By default this value should be at most 3600. However, you can follow
        /// https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth
        /// to set up the service account and extend the maximum lifetime to 43200 (12 hours).
        /// If the given lifetime is 0, default value 3600 will be used instead when creating the credentials.
        /// </param>
        public GoogleCredential Impersonate(string TargetPrincipal, IEnumerable<string> Delegates = null, 
                IEnumerable<string> Scopes = null, int LifetimeInSeconds = 3600) 
        {
            var initializer = new ImpersonatedCredential.Initializer(this, TargetPrincipal, Delegates, Scopes, LifetimeInSeconds);
            var impersonatedCredential = new ImpersonatedCredential(initializer);
            return new ImpersonatedGoogleCredential(impersonatedCredential);
        }

        /// <summary>
        /// Wraps <c>ImpersonatedCredential</c> as <c>GoogleCredential</c>.
        /// We need this subclass because wrapping <c>ImpersonatedCredential</c> (unlike other wrapped credential
        /// types) requires special handling for <c>CreateScoped</c> member.
        /// </summary>
        internal class ImpersonatedGoogleCredential : GoogleCredential {
            public ImpersonatedGoogleCredential(ImpersonatedCredential credential)
                : base(credential) { }

            public override GoogleCredential CreateScoped(IEnumerable<string> scopes)
            {
                var impersonatedCredential = credential as ImpersonatedCredential;
                var initializer = new ImpersonatedCredential.Initializer(impersonatedCredential)
                {
                    Scopes = scopes
                };
                return new ImpersonatedGoogleCredential(new ImpersonatedCredential(initializer));
            }
        }

        /// <summary>Creates a <c>GoogleCredential</c> wrapping a <see cref="ServiceAccountCredential"/>.</summary>
        public static GoogleCredential FromServiceAccountCredential(ServiceAccountCredential credential)
        {
            return new ServiceAccountGoogleCredential(credential);
        }

        /// <summary>
        /// Wraps <c>ServiceAccountCredential</c> as <c>GoogleCredential</c>.
        /// We need this subclass because wrapping <c>ServiceAccountCredential</c> (unlike other wrapped credential
        /// types) requires special handling for <c>IsCreateScopedRequired</c> and <c>CreateScoped</c> members.
        /// </summary>
        internal class ServiceAccountGoogleCredential : GoogleCredential
        {
            public ServiceAccountGoogleCredential(ServiceAccountCredential credential)
                : base(credential) { }

            public override bool IsCreateScopedRequired => !(credential as ServiceAccountCredential).HasScopes;

            public override GoogleCredential CreateScoped(IEnumerable<string> scopes)
            {
                var serviceAccountCredential = credential as ServiceAccountCredential;
                var initializer = new ServiceAccountCredential.Initializer(serviceAccountCredential)
                {
                    Scopes = scopes
                };
                return new ServiceAccountGoogleCredential(new ServiceAccountCredential(initializer));
            }

            public override GoogleCredential CreateWithUser(string user)
            {
                var serviceAccountCredential = credential as ServiceAccountCredential;
                var initializer = new ServiceAccountCredential.Initializer(serviceAccountCredential)
                {
                    User = user
                };
                return new ServiceAccountGoogleCredential(new ServiceAccountCredential(initializer));
            }

            public override GoogleCredential CreateWithQuotaProject(string quotaProject) =>
                new ServiceAccountGoogleCredential(credential.WithQuotaProject(quotaProject) as ServiceAccountCredential);
        }
    }
}
