/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Net;
using Google.Apis.Util;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// Represents an authenticator which uses a delegate to modify the WebRequests.
    /// </summary>
    public class DelegateAuthenticator : IAuthenticator
    {
        /// <summary>
        /// The delegate which is used to modify the webrequest.
        /// </summary>
        private readonly RequestModifier modifyRequestDelegate;

        /// <summary>
        /// Delegate used to modify a request for authentication.
        /// </summary>
        /// <param name="webRequest">The request needing authentication.</param>
        public delegate void RequestModifier(HttpWebRequest webRequest);
        
        /// <summary>
        /// Creates a new DelegateAuthenticator.
        /// </summary>
        /// <param name="modifyRequest">Delegate used to modify the webrequest.</param>
        public DelegateAuthenticator(RequestModifier modifyRequest)
        {
            modifyRequest.ThrowIfNull("modifyRequest");
            modifyRequestDelegate = modifyRequest;
        }

        /// <summary>
        /// Apply authentication to the request. Calls the RequestModifier delegate
        /// modify the request by adding authentication information.
        /// </summary>
        /// <param name="webRequest">The request needing authentication.</param>
        public virtual void ApplyAuthenticationToRequest(HttpWebRequest request)
        {
            modifyRequestDelegate(request);
        }
    }
}
