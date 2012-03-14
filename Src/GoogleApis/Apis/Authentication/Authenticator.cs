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
    /// Base authentication class. Takes credentials and applicationname
    /// and is able to create a HttpWebRequest augmented with the right
    /// authentication
    /// </summary>
    /// <returns></returns>
    public abstract class Authenticator : IAuthenticator
    {
        private ICreateHttpRequest requestFactory = new HttpRequestFactory();

        /// <summary>
        /// The factory which is used for creating the final request
        /// </summary>
        public ICreateHttpRequest RequestFactory
        {
            get { return requestFactory; }
            set { requestFactory = value; }
        }

        #region IAuthenticator Members

        /// <summary>
        /// Creates a HttpWebRequest object that can be used against a given service. 
        /// for a RequestSetting object that is using client login, this might call 
        /// to get an authentication token from the service, if it is not already set.
        /// 
        /// if this uses client login, and you need to use a proxy, set the application wide
        /// proxy first using the GlobalProxySelection
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="httpMethod"></param>
        /// <param name="targetUri"></param>
        /// <returns></returns>
        public HttpWebRequest CreateHttpWebRequest(string httpMethod, Uri targetUri)
        {
            Uri uriResult = ApplyAuthenticationToUri(targetUri);

            if (requestFactory != null)
            {
                HttpWebRequest request = requestFactory.Create(uriResult);
                request.Method = httpMethod;
                ApplyAuthenticationToRequest(request);
                return request;
            }
            return null;
        }

        #endregion

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its headers according to 
        /// the authentication system used.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual void ApplyAuthenticationToRequest(HttpWebRequest request) {}

        /// <summary>
        /// Takes an existing httpwebrequest and modifies its uri according to 
        /// the authentication system used. Only overridden in 2leggedoauth case
        /// </summary>
        /// <param name="source">the original uri</param>
        /// <returns></returns>
        public virtual Uri ApplyAuthenticationToUri(Uri source)
        {
            return source;
        }
    }
}