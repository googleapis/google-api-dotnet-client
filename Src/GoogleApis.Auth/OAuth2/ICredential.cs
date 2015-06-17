/*
Copyright 2015 Google Inc

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
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Credential for authorizing calls using OAuth 2.0.
    /// </summary>
    public interface ICredential : IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler,
        IConfigurableHttpClientInitializer
    {
        #region IHttpExecuteInterceptor

        /// <summary>
        /// Default implementation is to try to refresh the access token if there is no access token or if we are 1 
        /// minute away from expiration. If token server is unavailable, it will try to use the access token even if 
        /// has expired. If successful, it will call <see cref="IAccessMethod.Intercept"/>.
        /// </summary>
        Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken);

        #endregion

        #region IHttpUnsuccessfulResponseHandler

        Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args);

        #endregion

        #region IConfigurableHttpClientInitializer

        void Initialize(ConfigurableHttpClient httpClient);

        #endregion

        TokenResponse Token { get; }
    }
}
