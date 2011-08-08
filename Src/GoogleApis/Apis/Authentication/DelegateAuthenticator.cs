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
        /// The previous authenticator in the chain to call. Used to construct the HttpWebRequest.
        /// </summary>
        public IAuthenticator PreviousAuthenticator { get; set; }

        /// <summary>
        /// The delegate which is used to modify the webrequest.
        /// </summary>
        public Action<HttpWebRequest> ModifyRequestDelegate { get; private set; } 
        
        /// <summary>
        /// Creates a new DelegateAuthenticator.
        /// </summary>
        /// <param name="modifyRequest">Delegate used to modify the webrequest.</param>
        public DelegateAuthenticator(Action<HttpWebRequest> modifyRequest)
        {
            modifyRequest.ThrowIfNull("modifyRequest");
            ModifyRequestDelegate = modifyRequest;
        }

        public HttpWebRequest CreateHttpWebRequest(string httpMethod, Uri targetUri)
        {
            // If we have a previous authenticator, use this one first. Otherwise create the default Authenticator.
            HttpWebRequest request =
                (PreviousAuthenticator ?? NullAuthenticator.Instance).CreateHttpWebRequest(httpMethod, targetUri);

            ModifyRequestDelegate(request);
            return request;
        }
    }
}
