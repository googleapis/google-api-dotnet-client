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
using System.Collections.Generic;

#if ASPNETCORE3
namespace Google.Apis.Auth.AspNetCore3
#else
namespace Google.Apis.Auth.AspNetCore
#endif
{
    internal class GoogleScopedRequirement : IAuthorizationRequirement
    {
        public GoogleScopedRequirement(string scheme, IReadOnlyList<string> scopes)
        {
            Scheme = scheme;
            Scopes = scopes;
        }

        public string Scheme { get; }
        public IReadOnlyList<string> Scopes { get; }
    }
}
