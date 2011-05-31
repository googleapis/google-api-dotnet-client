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
        /// Specifies the RPC name to use
        /// </summary>
        /// <param name="rpcName"></param>
        /// <returns></returns>
        IRequest On(string rpcName);

        /// <summary>
        /// Specifies the return type of this method
        /// </summary>
        IRequest Returning(ReturnType returnType);

        /// <summary>
        /// Specifies the parameter set of this method
        /// </summary>
        IRequest WithParameters(IDictionary<string, object> parameters);

        /// <summary>
        /// Specifies the parameter set of this method
        /// </summary>
        IRequest WithParameters(IDictionary<string, string> parameters);

        /// <summary>
        /// Specifies the parameter query string of this method
        /// </summary>
        IRequest WithParameters(string parameters);

        /// <summary>
        /// Adds a body to this request (POST, PUT, ..)
        /// </summary>
        IRequest WithBody(string body);

        /// <summary>
        /// Changes the request to use the specified authenticator
        /// </summary>
        IRequest WithAuthentication(IAuthenticator authenticator);

        /// <summary>
        /// Adds the developer key to this request
        /// </summary>
        IRequest WithDeveloperKey(string key);

        /// <summary>
        /// Executes the request and returns the response stream
        /// </summary>
        Stream ExecuteRequest();
    }
}