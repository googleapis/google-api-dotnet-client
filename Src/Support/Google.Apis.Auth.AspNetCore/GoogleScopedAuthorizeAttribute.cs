/*
Copyright 2018 Google Inc

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

using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;

namespace Google.Apis.Auth.AspNetCore
{
    /// <summary>
    /// Specifies that the class or method that this attribute is applied to requires the specified authorization,
    /// which can include the incremental addition of Google scopes.
    /// </summary>
    public class GoogleScopedAuthorizeAttribute : AuthorizeAttribute
    {
        private const string PolicyPrefix = "GoogleScoped: ";

        internal static IReadOnlyList<string> ParsePolicy(string policy)
        {
            if (!policy.StartsWith(PolicyPrefix))
            {
                return null;
            }
            return policy.Substring(PolicyPrefix.Length)
                .Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Construct an instance of <see cref="GoogleScopedAuthorizeAttribute"/>.
        /// </summary>
        /// <param name="scopes">
        /// The Google auth scopes required by the class or method to which this attribute is applied.
        /// </param>
        public GoogleScopedAuthorizeAttribute(params string[] scopes) => Scopes = scopes;

        /// <summary>
        /// Get or set the Google auth scopes required by the class or method to which this attribute is applied.
        /// </summary>
        public IReadOnlyList<string> Scopes
        {
            get => ParsePolicy(Policy);
            set => Policy = $"{PolicyPrefix}{string.Join(" ", value)}";
        }
    }
}
