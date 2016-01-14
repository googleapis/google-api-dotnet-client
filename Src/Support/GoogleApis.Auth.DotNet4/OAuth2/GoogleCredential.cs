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

using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Credential for authorizing calls using OAuth 2.0.
    /// It is a convenience wrapper that allows handling of different types of 
    /// credentials (like <see cref="ServiceAccountCredential"/>, <see cref="ComputeCredential"/>
    /// or <see cref="UserCredential"/>) in a unified way.
    /// <para>
    /// See <see cref="GetApplicationDefaultAsync"/> for the credential retrieval logic.
    /// </para>
    /// </summary>
    public class GoogleCredential : IConfigurableHttpClientInitializer, ITokenAccess
    {
        /// <summary>Provider implements the logic for creating the application default credential.</summary>
        private static DefaultCredentialProvider defaultCredentialProvider = new DefaultCredentialProvider();

        /// <summary>The underlying credential being wrapped by this object.</summary>
        protected readonly ICredential credential;

        /// <summary>Creates a new <c>GoogleCredential</c>.</summary>
        internal GoogleCredential(ICredential credential)
        {
            this.credential = credential;
        }

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
        public static Task<GoogleCredential> GetApplicationDefaultAsync()
        {
            return defaultCredentialProvider.GetDefaultCredentialAsync();
        }

        /// <summary>
        /// Loads credential from stream containing JSON credential data.
        /// <para>
        /// The stream can contain a Service Account key file in JSON format from the Google Developers
        /// Console or a stored user credential using the format supported by the Cloud SDK.
        /// </para>
        /// </summary>
        public static GoogleCredential FromStream(Stream stream)
        {
            return defaultCredentialProvider.CreateDefaultCredentialFromStream(stream);
        }

        /// <summary>
        /// <para>Returns <c>true</c> only if this credential type has no scopes by default and requires
        /// a call to <see cref="o:CreateScoped"/> before use.</para>
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
        /// invoke <see cref="o:CreateScoped"/> to add scopes to the credential.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public virtual bool IsCreateScopedRequired
        {
            get { return false; }
        }

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        public virtual GoogleCredential CreateScoped(IEnumerable<string> scopes)
        {
            return this;
        }

        /// <summary>
        /// If the credential supports scopes, creates a copy with the specified scopes. Otherwise, it returns the same
        /// instance.
        /// </summary>
        public GoogleCredential CreateScoped(params string[] scopes)
        {
            return CreateScoped((IEnumerable<string>) scopes);
        }

        #region IConfigurableHttpClientInitializer

        void IConfigurableHttpClientInitializer.Initialize(ConfigurableHttpClient httpClient)
        {
            credential.Initialize(httpClient);
        }

        #endregion

        #region ITokenAccess

        Task<string> ITokenAccess.GetAccessTokenForRequestAsync(string authUri, CancellationToken cancellationToken)
        {
            return credential.GetAccessTokenForRequestAsync(authUri, cancellationToken);
        }

        #endregion

        /// <summary>Provides access to the underlying credential object</summary>
        internal ICredential UnderlyingCredential { get { return credential; } }

        #region Factory methods

        /// <summary>Creates a <c>GoogleCredential</c> wrapping a <see cref="ServiceAccountCredential"/>.</summary>
        internal static GoogleCredential FromCredential(ServiceAccountCredential credential)
        {
            return new ServiceAccountGoogleCredential(credential);
        }

        #endregion

        /// <summary>
        /// Wraps <c>ServiceAccountCredential</c> as <c>GoogleCredential</c>.
        /// We need this subclass because wrapping <c>ServiceAccountCredential</c> (unlike other wrapped credential
        /// types) requires special handling for <c>IsCreateScopedRequired</c> and <c>CreateScoped</c> members.
        /// </summary>
        internal class ServiceAccountGoogleCredential : GoogleCredential
        {
            public ServiceAccountGoogleCredential(ServiceAccountCredential credential)
                : base(credential) { }

            #region GoogleCredential overrides

            public override bool IsCreateScopedRequired
            {
                get { return !(credential as ServiceAccountCredential).HasScopes; }
            }

            public override GoogleCredential CreateScoped(IEnumerable<string> scopes)
            {
                var serviceAccountCredential = credential as ServiceAccountCredential;
                var initializer = new ServiceAccountCredential.Initializer(serviceAccountCredential.Id)
                {
                    User = serviceAccountCredential.User,
                    Key = serviceAccountCredential.Key,
                    Scopes = scopes
                };
                return new ServiceAccountGoogleCredential(new ServiceAccountCredential(initializer));
            }

            #endregion
        }
    }
}
