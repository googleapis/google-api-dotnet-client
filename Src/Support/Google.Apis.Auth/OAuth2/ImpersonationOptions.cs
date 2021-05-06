/*
Copyright 2021 Google Inc

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

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Options used to create an <see cref="ImpersonatedCredential"/>.
    /// </summary>
    public class ImpersonationOptions
    {
        /// <summary>
        /// Gets the service account to impersonate.
        /// </summary>
        public string TargetPrincipal { get; }

        /// <summary>
        /// Gets the chained list of delegate service accounts.
        /// </summary>
        public IEnumerable<string> DelegateAccounts { get; }

        /// <summary>
        /// Gets the scopes to request during the authorization grant.
        /// </summary>
        public IEnumerable<string> Scopes { get; }

        /// <summary>
        /// Gets how long the delegated credential should be valid.
        /// </summary>
        public TimeSpan Lifetime { get; }

        /// <summary>Constructs a new instace.</summary>
        /// <param name="targetPrincipal">The service account to impersonate. Must not be null.</param>
        /// <param name="lifetime">
        /// The amount of time  the delegated credential should remain valid after emission.
        /// By default this value should be at most 3600 seconds or 1 hour. However, you can follow
        /// https://cloud.google.com/iam/docs/creating-short-lived-service-account-credentials#sa-credentials-oauth
        /// to set up the service account and extend the maximum lifetime to 43200 seconds or 12 hours).
        /// Defaults to 1 hour.
        /// </param>
        /// <param name="delegateAccounts">The chained list of delegate service accounts.</param>
        /// <param name="scopes">The scopes to request during the authorization grant.</param>
        public ImpersonationOptions(string targetPrincipal, TimeSpan? lifetime, IEnumerable<string> delegateAccounts, IEnumerable<string> scopes)
        {
            TargetPrincipal = targetPrincipal.ThrowIfNullOrEmpty(nameof(targetPrincipal));
            DelegateAccounts = delegateAccounts;
            Scopes = scopes;
            Lifetime = lifetime ?? new TimeSpan(1, 0, 0);
            if (Lifetime > new TimeSpan(12, 0, 0))
            {
                throw new ArgumentOutOfRangeException("lifetime", "Lifetime must be less than or equal to 43200 seconds or 12 hours.");
            }
        }

        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the target principal.
        /// </summary>
        /// <param name="targetPrincipal">The new target principal.</param>
        /// <returns>A new set of options with the given target principal.</returns>
        public ImpersonationOptions WithTargetPrincipal(string targetPrincipal) =>
            new ImpersonationOptions(targetPrincipal, Lifetime, DelegateAccounts, Scopes);
        
        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the life time.
        /// </summary>
        /// <param name="lifetime">The new life time.</param>
        /// <returns>A new set of options with the given life time.</returns>
        public ImpersonationOptions WithLifetime(TimeSpan lifetime) =>
            new ImpersonationOptions(TargetPrincipal, lifetime, DelegateAccounts, Scopes);
        
        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the delegate service accounts.
        /// </summary>
        /// <param name="delegateAccounts">The new delegate service accounts.</param>
        /// <returns>A new set of options with the given delegate service accounts.</returns>
        public ImpersonationOptions WithDelegateAccounts(IEnumerable<string> delegateAccounts) =>
            new ImpersonationOptions(TargetPrincipal, Lifetime, delegateAccounts, Scopes);
        
        /// <summary>
        /// Builds a new set of options with the same options as this one, except for the scopes.
        /// </summary>
        /// <param name="scopes">The new scopes.</param>
        /// <returns>A new set of options with the given scopes.</returns>
        public ImpersonationOptions WithScopes(IEnumerable<string> scopes) =>
            new ImpersonationOptions(TargetPrincipal, Lifetime, DelegateAccounts, scopes);
    }
}
