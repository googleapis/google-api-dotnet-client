/*
Copyright 2020 Google Inc

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

using Google.Apis.Util;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Options used to create an <see cref="OidcToken"/>.
    /// </summary>
    public class OidcTokenOptions
    {
        /// <summary>
        /// The target audience the generated token should be valid for.
        /// Must not be null.
        /// </summary>
        public string TargetAudience { get; }

        /// <summary>
        /// The token format of the expected OIDC token when obtained from the
        /// GCE metadata server.
        /// This value will be ignored when the token provider is other then the GCE
        /// metadata server.
        /// <see cref="OidcTokenFormat"/> for the meaning of each value.
        /// Defaults to <see cref="OidcTokenFormat.Full"/>.
        /// </summary>
        public OidcTokenFormat TokenFormat { get; }

        private OidcTokenOptions(string targetAudience, OidcTokenFormat tokenFormat)
        {
            TargetAudience = targetAudience.ThrowIfNull(nameof(targetAudience));
            TokenFormat = Utilities.CheckEnumValue(tokenFormat, nameof(tokenFormat));
        }

        /// <summary>
        /// Builds new <see cref="OidcTokenOptions"/> from the given target audience.
        /// </summary>
        /// <param name="targetAudience">The target audience to build these options from. Must no be null.</param>
        /// <returns>A new set of options that can be used with a <see cref="IOidcTokenProvider"/> to obtain an <see cref="OidcToken"/>.</returns>
        public static OidcTokenOptions FromTargetAudience(string targetAudience) =>
            new OidcTokenOptions(targetAudience, OidcTokenFormat.Full);

        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the target audience.
        /// </summary>
        /// <param name="targetAudience">The new target audience. Must not be null.</param>
        /// <returns>A new set of options with the given target audience.</returns>
        public OidcTokenOptions WithTargetAudience(string targetAudience) =>
            new OidcTokenOptions(targetAudience, TokenFormat);

        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the token format.
        /// </summary>
        /// <param name="tokenFormat">The new token format.</param>
        /// <returns>A new set of options with the given token format.</returns>
        public OidcTokenOptions WithTokenFormat(OidcTokenFormat tokenFormat) =>
            new OidcTokenOptions(TargetAudience, tokenFormat);
    }
}