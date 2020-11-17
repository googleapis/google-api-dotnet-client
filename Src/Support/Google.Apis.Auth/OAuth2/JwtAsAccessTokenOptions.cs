/*
Copyright 2020 Google Inc

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

using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Describes the conditions under which a self signed
    /// JWT can be emitted as an access token.
    /// </summary>
    public sealed class JwtAsAccessTokenOptions
    {
        /// <summary>
        /// The endpoint for which a JWT can be emitted as an access token.
        /// Must not be null.
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The audience to use when emitting the JWT.
        /// May be null, in which case, the <see cref="Endpoint"/> will be used
        /// as audience.
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Effective audience that will be used for emitting the JWT.
        /// <see cref="Audience"/> will be used if it's not null,
        /// else <see cref="Endpoint"/> will be used.
        /// </summary>
        internal string EffectiveAudience => Audience ?? Endpoint;

        /// <summary>
        /// The scopes for which a JWT token access can be emitted as an access token.
        /// May be null or empty, in which case JWT emission will only occurred for an
        /// unscoped credential.
        /// </summary>
        public IEnumerable<string> AllowedScopes { get; set; }

        /// <summary>
        /// Checks if the given scopes are contained by <see cref="AllowedScopes"/>.
        /// </summary>
        internal bool ScopesAllowed(IEnumerable<string> scopes) => 
            !scopes?.Except(AllowedScopes ?? Enumerable.Empty<string>()).Any() ?? true;

        internal JwtAsAccessTokenOptions Copy() =>
            new JwtAsAccessTokenOptions
            {
                Endpoint = Endpoint,
                Audience = Audience,
                AllowedScopes = new List<string>(AllowedScopes)
            };

        internal JwtAsAccessTokenOptions ValidateForRegistrationAndCopy() => ThrowIfInvalid().Copy();

        private JwtAsAccessTokenOptions ThrowIfInvalid() =>
            Endpoint is null ? throw new InvalidOperationException($"{nameof(Endpoint)} cannot be null.") : this;
    }
}
