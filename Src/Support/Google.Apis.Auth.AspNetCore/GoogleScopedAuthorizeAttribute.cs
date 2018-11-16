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
    public class GoogleScopedAuthorizeAttribute : AuthorizeAttribute
    {
        private const string PolicyPrefix = "GoogleScoped: ";

        internal static IReadOnlyList<string> ParsePolicy(string policy)
        {
            if (!policy.StartsWith(PolicyPrefix))
            {
                return null;
            }
            return policy.Substring(PolicyPrefix.Length).Split(Consts.ScopeSplitter, StringSplitOptions.RemoveEmptyEntries);
        }

        public GoogleScopedAuthorizeAttribute(params string[] scopes) => Scopes = scopes;

        public IReadOnlyList<string> Scopes
        {
            get => ParsePolicy(Policy);
            set => Policy = $"{PolicyPrefix}{string.Join(" ", value)}";
        }
    }
}
