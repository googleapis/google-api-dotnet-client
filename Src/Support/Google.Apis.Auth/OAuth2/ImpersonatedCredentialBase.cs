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
using Google.Apis.Util;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Basic impersonated credential which obtains impersonated access tokens.
    /// </summary>
    public abstract class ImpersonatedCredentialBase : ServiceCredential
    {
        internal static readonly string[] ImpersonationScopes = new string[] { GoogleAuthConsts.IamScope };

        /// <summary>An initializer class for the impersonated credential. </summary>
        new public abstract class Initializer : ServiceCredential.Initializer
        {
            /// <summary>
            /// Gets or sets for how long the delegated credential should be valid, in seconds.
            /// Defaults to 1 hour or 3600 seconds which is also the default maximum lifetime.
            /// To extend the maximum lifetime for these tokens to 12 hours (43,200 seconds),
            /// add the service account to an organization policy that includes the
            /// constraints/iam.allowServiceAccountCredentialLifetimeExtension list constraint.
            /// </summary>
            public TimeSpan Lifetime { get; set; }

            /// <summary>
            /// Gets or sets the source credential used to acquire the impersonated credentials.
            /// </summary>
            internal ICredential SourceCredential => HttpClientInitializers.OfType<ICredential>().SingleOrDefault();

            /// <summary>
            /// Sets the source credential to a credential scoped for impersonation created from <paramref name="credential"/>.
            /// </summary>
            internal virtual void SetSourceCredentialFrom(ICredential credential)
            {
                // We scope the new credential for impersonation, as it needs some IAM specific scopes.
                // We don't care about the scopes that it previously had as the impersonated credential
                // will be scoped itself.
                var newCredential = ValidateAndScopeForImpersonation(credential);

                // Now, after validating the new credential, we can remove the old one,
                // even if the new credential is null, as that would indicate "no source credential".
                HttpClientInitializers.Remove(SourceCredential);

                // Now we can finally set the new IAM scoped credential.
                if (newCredential is object)
                {
                    HttpClientInitializers.Add(newCredential);
                }
            }

            /// <summary>Constructs a new initializer.</summary>
            internal Initializer(string tokenServerUrl)
                : base(tokenServerUrl.ThrowIfNull(nameof(tokenServerUrl))) =>
                Lifetime = TimeSpan.FromHours(1);

            internal Initializer(ImpersonatedCredentialBase other) : base(other) =>
                Lifetime = other.Lifetime;

            internal Initializer(Initializer other) : base(other) =>
                Lifetime = other.Lifetime;

            /// <summary>
            /// Validates <paramref name="credential"/> as a valid source credential and
            /// returns a new credential, based on <paramref name="credential"/> but scoped for
            /// impersonation.
            /// </summary>
            /// <param name="credential">The credential to validate and build a scoped one from.
            /// May be null, in which case this method will return null.
            /// this</param>
            private protected abstract ICredential ValidateAndScopeForImpersonation(ICredential credential);
        }

        /// <summary>
        /// Gets for how long the delegated credential should be valid, in seconds.
        /// Defaults to 1 hour or 3600 seconds which is also the default maximum lifetime.
        /// To extend the maximum lifetime for these tokens to 12 hours (43,200 seconds),
        /// add the service account to an organization policy that includes the
        /// constraints/iam.allowServiceAccountCredentialLifetimeExtension list constraint.
        /// </summary>
        public TimeSpan Lifetime { get; }

        /// <summary>
        /// Gets the source credential used to acquire the impersonated credentials.
        /// </summary>
        internal ICredential SourceCredential => HttpClientInitializers.OfType<IGoogleCredential>().Single();

        private protected ImpersonatedCredentialBase(Initializer initializer) : base(initializer)
        {
            if (initializer.SourceCredential is null)
            {
                throw new ArgumentException(nameof(initializer.SourceCredential));
            }
            if (initializer.Lifetime < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(initializer.Lifetime), $"Must be greater or equal to {nameof(TimeSpan.Zero)}");
            }
            Lifetime = initializer.Lifetime;
        }

        /// <inheritdoc/>
        public override async Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
        {
            var request = CreateImpersonationAccessTokenRequest();

            Token = await request.ExecuteAsync(HttpClient, TokenServerUrl, Clock, Logger, taskCancellationToken)
                .ConfigureAwait(false);

            return true;
        }

        /// <summary>
        /// Creates the request for obtaining the impersonated access token.
        /// Derived classes should override this if they need to add more information to the request.
        /// </summary>
        internal virtual ImpersonationAccessTokenRequest CreateImpersonationAccessTokenRequest() =>
            new ImpersonationAccessTokenRequest
            {
                Scopes = Scopes,
                Lifetime = $"{(int)Lifetime.TotalSeconds}s"
            };
    }
}
