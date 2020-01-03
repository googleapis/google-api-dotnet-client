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
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

#if ASPNETCORE3
namespace Google.Apis.Auth.AspNetCore3
#else
namespace Google.Apis.Auth.AspNetCore
#endif
{
    /// <summary>
    /// Construct GoogleScoped policies on the fly.
    /// </summary>
    internal class GoogleScopedPolicyProvider : IAuthorizationPolicyProvider
    {
        public GoogleScopedPolicyProvider(GoogleAuthenticationSchemeProvider scheme, IOptions<AuthorizationOptions> options)
        {
            _scheme = scheme.Scheme;
            _default = new DefaultAuthorizationPolicyProvider(options);
        }

        private readonly string _scheme;
        private readonly IAuthorizationPolicyProvider _default;

        public Task<AuthorizationPolicy> GetDefaultPolicyAsync() => _default.GetDefaultPolicyAsync();

#if ASPNETCORE3
        public Task<AuthorizationPolicy> GetFallbackPolicyAsync() => _default.GetFallbackPolicyAsync();
#endif

        public Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            var scopes = GoogleScopedAuthorizeAttribute.ParsePolicy(policyName);
            if (scopes != null)
            {
                // A GoogleScoped policy.
                var policy = new AuthorizationPolicyBuilder(_scheme);
                policy.RequireAuthenticatedUser();
                policy.AddRequirements(new GoogleScopedRequirement(_scheme, scopes));
                return Task.FromResult(policy.Build());
            }
            else
            {
                // Not a GoogleScoped policy, use default behaviour.
                return _default.GetPolicyAsync(policyName);
            }
        }
    }
}
