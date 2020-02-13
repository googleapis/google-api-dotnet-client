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

using Google.Apis.Http;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
    // TODO: Consider making public so that implementons of ICredential other than us
    // can benefit.
    /// <summary>
    /// Wrapper used by credentials when included at the service level so that they are 
    /// overwritten by any specific call credential.
    /// </summary>
    /// <remarks>
    /// Credentials are included at the service level through the
    /// <see cref="IConfigurableHttpClientInitializer.Initialize(ConfigurableHttpClient)"/> method.
    /// For a credential to be able to be overwritten by a call credential, instead of directly adding
    /// its handlers and interceptors to the <see cref="ConfigurableHttpClient"/> it needs to wrap itself
    /// in an <see cref="OverridableCredential"/> and have the overridable credential initialize the
    /// <see cref="ConfigurableHttpClient"/>. The overridable credential will add the same handlers and interceptors
    /// as the original credential would but wrapping them in some code that stops them from executing if other credentials
    /// are present on the request.
    /// </remarks>
    internal class OverridableCredential : ICredential, IHttpExecuteInterceptor, IHttpUnsuccessfulResponseHandler
    {
        private readonly ICredential _underlyingCredential;

        internal OverridableCredential(ICredential underlyingCredential) =>
            _underlyingCredential = underlyingCredential.ThrowIfNull(nameof(underlyingCredential));

        internal static void WrapInitialize(ICredential credential, ConfigurableHttpClient httpClient)
        {
            OverridableCredential cred = new OverridableCredential(credential);
            cred.Initialize(httpClient);
        }

        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            _underlyingCredential.GetAccessTokenForRequestAsync(authUri, cancellationToken);


        public void Initialize(ConfigurableHttpClient httpClient)
        {

            if (_underlyingCredential is IHttpExecuteInterceptor)
            {
                httpClient.MessageHandler.AddExecuteInterceptor(this);
            }
            if (_underlyingCredential is IHttpUnsuccessfulResponseHandler)
            {
                httpClient.MessageHandler.AddUnsuccessfulResponseHandler(this);
            }
        }

        public async Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Only intercept service level if there's no call level credential.
            if (!HasPerCallCredentials(request))
            {
                await (_underlyingCredential as IHttpExecuteInterceptor)
                    .InterceptAsync(request, cancellationToken)
                    .ConfigureAwait(false);
            }
        }

        public async Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
        {
            // Even though the call level credential might only be an interceptor and not
            // a response handler we cannot execute the service level response handler
            // associated to another (the service level) credential.
            if (!HasPerCallCredentials(args.Request))
            {
                return await (_underlyingCredential as IHttpUnsuccessfulResponseHandler)
                    .HandleResponseAsync(args)
                    .ConfigureAwait(false);
            }

            return false;
        }

        private bool HasPerCallCredentials(HttpRequestMessage request)
        {
            if (request.Properties.TryGetValue(ConfigurableMessageHandler.ExecuteInterceptorKey, out var interceptors) &&
                interceptors is IList<IHttpExecuteInterceptor> perCallInterceptors &&
                perCallInterceptors.Any(i => i is ICredential))
            {
                return true;
            }

            // Very unlikely but technically possible 
            // that a credential is not an interceptor but only a response handler.
            if (request.Properties.TryGetValue(ConfigurableMessageHandler.UnsuccessfulResponseHandlerKey, out var handlers) &&
                handlers is IList<IHttpUnsuccessfulResponseHandler> perCallHandlers &&
                perCallHandlers.Any(i => i is ICredential))
            {
                return true;
            }

            return false;
        }
    }
}
