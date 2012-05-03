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
using System.IO;
using System.Collections.Generic;
using Google.Apis.Authentication;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Implementors will be able to make a request to a service.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Specifies the RPC name to use.
        /// </summary>
        /// <param name="rpcName"></param>
        /// <returns></returns>
        IRequest On(string rpcName);

        /// <summary>
        /// Specifies the return type of this method.
        /// </summary>
        IRequest Returning(ReturnType returnType);

        /// <summary>
        /// Specifies the parameter set of this method.
        /// </summary>
        IRequest WithParameters(IDictionary<string, object> parameters);

        /// <summary>
        /// Specifies the parameter set of this method.
        /// </summary>
        IRequest WithParameters(IEnumerable<KeyValuePair<string, string>> parameters);

        /// <summary>
        /// Specifies the parameter query string of this method.
        /// </summary>
        IRequest WithParameters(string parameters);

        /// <summary>
        /// Specifies the partial field mask of this method. 
        /// The response of this request will only contain the fields specified in this mask.
        /// </summary>
        /// <param name="mask">Selector specifying which fields to include in a partial response.</param>
        IRequest WithFields(string mask);

        /// <summary>
        /// IP address of the site where the request originates. Use this if you want to enforce per-user limits.
        /// </summary>
        IRequest WithUserIp(string userIp);

        /// <summary>
        /// Adds a body to this request (POST, PUT, ..).
        /// </summary>
        /// <remarks>The body will be encoded in UTF-8.</remarks>
        IRequest WithBody(string body);

        /// <summary>
        /// Changes the request to use the specified authenticator.
        /// </summary>
        IRequest WithAuthentication(IAuthenticator authenticator);

        /// <summary>
        /// Adds the API/developer key to this request.
        /// </summary>
        IRequest WithKey(string key);

        /// <summary>
        /// Adds an ETag to this request.
        /// </summary>
        IRequest WithETag(string etag);

        /// <summary>
        /// Sets the ETag-behavior of this request.
        /// </summary>
        IRequest WithETagAction(ETagAction action);

        /// <summary>
        /// Executes the request asynchronously, and calls the specified delegate once done.
        /// </summary>
        /// <param name="responseHandler">The method to call once a response has been received.</param>
        void ExecuteRequestAsync(Action<IAsyncRequestResult> responseHandler);

        /// <summary>
        /// Executes the request and returns the response.
        /// </summary>
        IResponse ExecuteRequest();
    }

    /// <summary>
    /// Represents the result of a asynchronous Request.
    /// </summary>
    public interface IAsyncRequestResult
    {
        /// <summary>
        /// Retrieves the response to this request.
        /// </summary>
        /// <exception cref="GoogleApiRequestException">Thrown if the request failed</exception>
        IResponse GetResponse();
    }

}