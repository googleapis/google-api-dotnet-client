/*
Copyright 2020 Google LLC

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

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents a Google credential. Defines functionality that
    /// credential types that can be used as an underlying credential in <see cref="GoogleCredential"/>
    /// should implement in contrast to <see cref="ICredential"/> that defines public functionality.
    /// </summary>
    internal interface IGoogleCredential : ICredential, ITokenAccessWithHeaders
    {
        /// <summary>
        /// The ID of the project associated to this credential for the purposes of
        /// quota calculation and billing. May be null.
        /// </summary>
        string QuotaProject { get; }

        /// <summary>
        /// Returns a new instance of the same type as this but with the
        /// given quota project value.
        /// </summary>
        /// <param name="quotaProject">The quota project value for the new instance.</param>
        /// <returns>A new instance with the same type as this but with <see cref="QuotaProject"/>
        /// set to <paramref name="quotaProject"/>.</returns>
        IGoogleCredential WithQuotaProject(string quotaProject);
    }
}
