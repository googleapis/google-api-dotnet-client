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

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Implementors can emit self signed JWTs as access tokens
    /// for registered andpoints.
    /// </summary>
    public interface IJwtTokenAccess : ITokenAccess
    {
        /// <summary>
        /// Registers a set of conditions under which a JWT can be emitted
        /// as an access token.
        /// </summary>
        /// <param name="options">The options to register.</param>
        /// <param name="overrideExisting">true to override any existing registration for
        /// the <see cref="JwtAsAccessTokenOptions.Endpoint"/> of <paramref name="options"/>.
        /// Else <see cref="ArgumentException"/> will be thrown of the <see cref="JwtAsAccessTokenOptions.Endpoint"/>
        /// of <paramref name="options"/> has already been registered.</param>
        void RegisterForJwtEmission(JwtAsAccessTokenOptions options, bool overrideExisting);
        // TODO: We probably want this inmutable.
    }
}
