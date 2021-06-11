// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2.Flows
{
    /// <summary>
    /// Authorization flow that performs HTTP operations, for instance,
    /// for obtaining or refreshing tokens.
    /// </summary>
    internal interface IHttpAuthorizationFlow : IAuthorizationCodeFlow
    {
        /// <summary>
        /// Return a new instance of the same type as this but that uses the
        /// given HTTP client factory.
        /// </summary>
        /// <param name="httpClientFactory">The http client factory to be used by the new instance.
        /// May be null, in which case the default <see cref="HttpClientFactory"/> will be used.</param>
        /// <returns>A new instance with the same type as this but that will use <paramref name="httpClientFactory"/>
        /// to obtain an <see cref="ConfigurableHttpClient"/> to be used for token related operations.</returns>
        IHttpAuthorizationFlow WithHttpClientFactory(IHttpClientFactory httpClientFactory);
    }
}
