/*
Copyright 2019 Google Inc

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

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Represents an access token that can be used to authorize a request.
    /// The token might be accompanied by extra information that should be sent
    /// in the form of headers.
    /// </summary>
    public sealed class AccessTokenWithHeaders
    {
        private const string QuotaProjectHeaderName = "x-goog-user-project";
        private static readonly IReadOnlyDictionary<string, IReadOnlyList<string>> s_emptyHeaders = 
            new ReadOnlyDictionary<string, IReadOnlyList<string>>(new Dictionary<string, IReadOnlyList<string>>());

        /// <summary>
        /// Constructs an <see cref="AccessTokenWithHeaders"/> based on a given token and headers.
        /// </summary>
        /// <param name="token">The token to build this instance for. May be null.</param>
        /// <param name="headers">The collection of headers that may accompany the token. May be null.</param>
        public AccessTokenWithHeaders(string token, IReadOnlyDictionary<string, IReadOnlyList<string>> headers)
        {
            AccessToken = token;
            Headers = headers ?? s_emptyHeaders;
        }

        internal AccessTokenWithHeaders(string token, string quotaProject = null)
            : this (token,
                  quotaProject == null ?
                  null :
                  new ReadOnlyDictionary<string, IReadOnlyList<string>>(
                    new Dictionary<string, IReadOnlyList<string>>
                    {
                        {
                            QuotaProjectHeaderName,
                            new List<string> { quotaProject }.AsReadOnly()
                        }
                    }))
        { }

        /// <summary>
        /// An access token that can be used to authorize a request.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Extra headers, if any, that should be included in the request.
        /// </summary>
        public IReadOnlyDictionary<string, IReadOnlyList<string>> Headers { get; }
    }
}
