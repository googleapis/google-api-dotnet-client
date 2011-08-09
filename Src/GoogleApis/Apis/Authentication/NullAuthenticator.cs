/*
Copyright 2010 Google Inc

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
using System.Net;

namespace Google.Apis.Authentication
{
    /// <summary>
    /// A placeholder Authenticator which adds no authentication to the request. 
    /// </summary>
    public class NullAuthenticator : IAuthenticator
    {
        /// <summary>
        /// Returns the default instance of the NullAuthenticator.
        /// </summary>
        public static readonly NullAuthenticator Instance = new NullAuthenticator();

        private readonly NullAuthenticatorImpl impl;

        public NullAuthenticator()
        {
            impl = new NullAuthenticatorImpl();
        }

        #region IAuthenticator Members

        public HttpWebRequest CreateHttpWebRequest(string httpMethod, Uri targetUri)
        {
            return impl.CreateHttpWebRequest(httpMethod, targetUri);
        }

        #endregion

        #region Nested type: NullAuthenticatorImpl

        /// <summary>
        /// We use this to hide the fact that NullAuthenticator uses Authenticator behind the scenes
        /// This is particularly useful as we are setting the application name to null. 
        /// </summary>
        private class NullAuthenticatorImpl : Authenticator
        {
        }

        #endregion
    }
}