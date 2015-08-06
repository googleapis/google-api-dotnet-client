/*
Copyright 2013 Google Inc

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
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Service account credential that also supports JSON Web Token access token scenario.
    /// In this scenario, instead of sending a JWT to a token server and exchanging it for 
    /// an access token, a slightly different JWT containing the request URI is constructed
    /// and used as an access token.
    /// <seealso cref="ServiceAccountCredential"/>
    /// </para>
    /// </summary>
    public class JwtServiceAccountCredential : ServiceAccountCredential
    {
        /// <summary>An initializer class for the JWT service account credential. </summary>
        public class Initializer : ServiceAccountCredential.Initializer
        {
            /// <summary>Constructs a new initializer using the given id.</summary>
            public Initializer(string id) : base(id) { }
        }

        /// <summary>Constructs a new JWT service account credential using the given initializer.</summary>
        public JwtServiceAccountCredential(Initializer initializer) : base(initializer)
        {
        }

        /// <summary>
        /// Creates a JWT access token than can be used in request headers instead of an OAuth2 token.
        /// This is achieved by signing a special JWT using this service account's private key.
        /// <param name="authUri">The URI for which the access token will be valid.</param>
        /// </summary>
        private string CreateJwtAccessToken(string authUri)
        {
            var issued = (int)(Clock.UtcNow - UnixEpoch).TotalSeconds;
            var payload = new JsonWebSignature.Payload()
            {
                Issuer = Id,
                Subject = Id,
                Audience = authUri,
                IssuedAtTimeSeconds = issued,
                ExpirationTimeSeconds = issued + 3600,
            };
            return CreateAssertionFromPayload(payload);
        }
    }
}
