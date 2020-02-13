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

using Google.Apis.Http;
using Google.Apis.Requests;
using Google.Apis.Util;
using System;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>
    /// Extension methods for requests.
    /// </summary>
    public static class RequestExtensions
    {
        /// <summary>
        /// Add a credential that is used for this request only.
        /// This will override all other existing credentials, including service level ones.
        /// </summary>
        /// <typeparam name="T">The request type.</typeparam>
        /// <param name="request">The request which requires a credential. Must not be null.</param>
        /// <param name="credential">The credential to use for this request only. Must not be null.</param>
        /// <returns>The same request object as <paramref name="request"/> with all pre-existing credentials removed
        /// and <paramref name="credential"/> added.</returns>
        public static T AddCredential<T>(this T request, ICredential credential) where T : ClientServiceRequest
        {
            request.ThrowIfNull(nameof(request));
            credential.ThrowIfNull(nameof(credential));
            // Get underlying credential if passed credential is a GoogleCredential.
            if (credential is GoogleCredential googleCredential)
            {
                credential = googleCredential.UnderlyingCredential;
            }
            // Add the required execute interceptor to this request.
            var httpExecuteInterceptor = credential as IHttpExecuteInterceptor;
            if (httpExecuteInterceptor == null)
            {
                throw new ArgumentException("Credential must implement IHttpExecuteInterceptor.", nameof(credential));
            }
            // Now we are ready to add the new credential.
            // Let's remove old ones first.
            request.RemoveCredentials();

            request.AddExecuteInterceptor(httpExecuteInterceptor);
            // Add the optional unsuccessful interceptor to this request.
            if (credential is IHttpUnsuccessfulResponseHandler httpUnsuccessfulResponseHandler)
            {
                request.AddUnsuccessfulResponseHandler(httpUnsuccessfulResponseHandler);
            }
            // Return the request.
            return request;
        }

        /// <summary>
        /// Removes all existing credentials from the given request.
        /// This method is useful when credentials need to be overwritten.
        /// </summary>
        /// <typeparam name="T">The type of the request to remove credentials from.</typeparam>
        /// <param name="request">The request to remove credentials from.</param>
        /// <returns>The same request object as <paramref name="request"/> with all credentials removed.</returns>
        internal static T RemoveCredentials<T>(this T request) where T : ClientServiceRequest
        {
            request.ThrowIfNull(nameof(request));
            request.RemoveExecuteInterceptors<ICredential>();
            request.RemoveUnsuccessfulResponseHandlers<ICredential>();

            return request;
        }
    }
}
