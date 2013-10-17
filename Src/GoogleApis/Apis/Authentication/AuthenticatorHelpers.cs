/*
Copyright 2013 Google Inc

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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Http;
using Google.Apis.Testing;

namespace Google.Apis.Authentication
{
    // TODO(peleyal): this class should be removed when implementing our OAuth2 library. Our future credential
    // object will implement both IHttpExecuteInterceptor and IHttpUnsuccessfulResponseHandler
    [VisibleForTestOnly]
    [Obsolete("AuthenticatorInterceptor is not supported any more and it's going to be removed in 1.7.0-beta. " +
            "Consider using UserCredential or ServiceAccountCredential from the new Google.Apis.Auth NuGet package " +
            "which supports .NET 4, .NET for Windows, Store apps, Windows Phone 7.5 and 8 and Portable Class " +
            "Libraries as well")]
    internal class AuthenticatorInterceptor : IHttpExecuteInterceptor
    {
        private IAuthenticator Authenticator { get; set; }

        /// <summary> Constructs a new Authenticator interceptor. </summary>
        public AuthenticatorInterceptor(IAuthenticator authenticator)
        {
            Authenticator = authenticator;
        }

        public Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // we create a regular WebHttpRequest because our Authenticator (and DotNetOpenAuth) implementation
            // works with it only. 
            // We are going to create our own OAuth2 implementation and as a result this hack will be removed!
            var authorization = HttpRequestHeader.Authorization.ToString();
            var request2 = WebRequest.Create("http://www.hack.com") as HttpWebRequest;
            Authenticator.ApplyAuthenticationToRequest(request2);
            if (request2.Headers[authorization] != null)
            {
                request.Headers.Remove(authorization);
                request.Headers.Add(authorization, request2.Headers[authorization]);
            }

            return TaskEx.Delay(0);
        }
    }

    // TODO(peleyal): this class should be removed when implementing our OAuth2 library. Our future credential
    // object will implement both IHttpExecuteInterceptor and IHttpUnsuccessfulResponseHandler
    [Obsolete("AuthenticatorMessageHandlerInitializer is not supported any more and it's going to be removed in " +
            "1.7.0-beta. " +
            "Consider using UserCredential or ServiceAccountCredential from the new Google.Apis.Auth NuGet package " +
            "which supports .NET 4, .NET for Windows, Store apps, Windows Phone 7.5 and 8 and Portable Class " +
            "Libraries as well")]
    internal class AuthenticatorMessageHandlerInitializer : IConfigurableHttpClientInitializer
    {
        private IAuthenticator Authenticator { get; set; }

        /// <summary> Constructs a new Authenticator message handler initializer. </summary>
        public AuthenticatorMessageHandlerInitializer(IAuthenticator authenticator)
        {
            Authenticator = authenticator;
        }

        public void Initialize(ConfigurableHttpClient httpClient)
        {
            httpClient.MessageHandler.ExecuteInterceptors.Add(new AuthenticatorInterceptor(Authenticator));
            var unsuccessfulHandler = Authenticator as IHttpUnsuccessfulResponseHandler;
            if (unsuccessfulHandler != null)
            {
                httpClient.MessageHandler.UnsuccessfulResponseHandlers.Add(unsuccessfulHandler);
            }
        }
    }
}
