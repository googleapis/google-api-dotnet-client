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

using System;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Service account credential that also supports JSON Web Token access token scenario.
    /// In this scenario, instead of sending a JWT to a token server and exchanging it for 
    /// an access token, a slightly different JWT containing the request URI is constructed
    /// and used as an access token.
    /// See <see cref="GetAccessTokenForRequestAsync"/> for explanation when JWT access token
    /// is used and when regular OAuth2 token is used.
    /// <seealso cref="ServiceAccountCredential"/>
    /// </summary>
    public class JwtServiceAccountCredential : ServiceAccountCredential
    {
        /// <summary>Default lifetime of 1 hour</summary>
        private const int DefaultExpiresInSeconds = 3600;

        /// <summary>Constructs a new JWT service account credential using the given initializer.</summary>
        public JwtServiceAccountCredential(ServiceAccountCredential.Initializer initializer)
            : base(initializer)
        {
        }

        /// <summary>
        /// Gets an access token to authorize a request.
        /// If <paramref name="authUri"/> is set and this credential has no scopes associated
        /// with it, a JWT access token for given <paramref name="authUri"/> is returned.
        /// Otherwise, the access token will be obtained in exactly the same way as in
        /// <see cref="ServiceAccountCredential"/>
        /// </summary>
        /// <param name="authUri">The URI the returned token will grant access to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The access token.</returns>
        public override async Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (!HasScopes && authUri != null)
            {
                // TODO(jtattermusch): support caching of JWT access tokens per authUri, currently a new 
                // JWT access token is created each time, which can hurt performance.
                return CreateJwtAccessToken(authUri).AccessToken;
            }
            return await base.GetAccessTokenForRequestAsync(authUri, cancellationToken);
        }

        /// <summary>
        /// Creates a JWT access token than can be used in request headers instead of an OAuth2 token.
        /// This is achieved by signing a special JWT using this service account's private key.
        /// <param name="authUri">The URI for which the access token will be valid.</param>
        /// </summary>
        private JwtAccessToken CreateJwtAccessToken(string authUri)
        {
            var issuedDateTime = Clock.UtcNow;
            var issued = (int)(issuedDateTime - UnixEpoch).TotalSeconds;
            var payload = new JsonWebSignature.Payload()
            {
                Issuer = Id,
                Subject = Id,
                Audience = authUri,
                IssuedAtTimeSeconds = issued,
                ExpirationTimeSeconds = issued + DefaultExpiresInSeconds,
            };

            return new JwtAccessToken
            {
                Issued = issuedDateTime,
                ExpiresInSeconds = DefaultExpiresInSeconds,
                AccessToken = CreateAssertionFromPayload(payload)
            };
        }

        /// <summary>JWT access token.</summary>
        internal class JwtAccessToken
        {
            /// <summary>The date and time that this token was issued.</summary>
            public DateTime Issued { get; set; }

            /// <summary>Gets or sets the lifetime in seconds of the access token.</summary>
            public long ExpiresInSeconds { get; set; }

            /// <summary>Gets or sets the access token.</summary>
            public string AccessToken { get; set; }

            /// <summary>
            /// Returns <c>true</c> if the token is expired or it's going to be expired in the next minute.
            /// </summary>
            public bool IsExpired(IClock clock)
            {
                if (AccessToken == null)
                {
                    return true;
                }

                return Issued.AddSeconds(ExpiresInSeconds - 60) <= clock.Now;
            }
        }
    }
}
