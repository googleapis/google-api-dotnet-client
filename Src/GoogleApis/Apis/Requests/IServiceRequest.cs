/*
Copyright 2011 Google Inc

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
using System.Runtime.InteropServices;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents a basic, non generic request to a service.
    /// </summary>
    /// <remarks>
    /// Should execute the request (specified by the instance of this class) once a "Fetch" method is called.
    /// </remarks>
    interface IServiceRequest
    {
        /// <summary>
        /// Executes the request synchronously and returns the unparsed response stream.
        /// </summary>
        Stream FetchAsStream();

        /// <summary>
        /// Executes the request asynchronously without parsing the response, 
        /// and optionally calls the specified method once finished.
        /// </summary>
        void FetchAsyncAsStream([Optional] ExecuteRequestDelegate<Stream> methodToCall);
    }

    /// <summary>
    /// Represents a request with a specified return type.
    /// </summary>
    /// <remarks>
    /// Should execute the request (specified by the instance of this class) once a "Fetch" method is called.
    /// </remarks>
    /// <typeparam name="TResponse">Type of the response returned when executing this request.</typeparam>
    interface IServiceRequest<TResponse> : IServiceRequest
    {
        /// <summary>
        /// Executes the request synchronously and returns the result.
        /// </summary>
        TResponse Fetch();

        /// <summary>
        /// Executes the request asynchronously and optionally calls the specified method once finished.
        /// </summary>
        void FetchAsync([Optional] ExecuteRequestDelegate<TResponse> methodToCall);
    }

    /// <summary>
    /// Delegate for executing an asynchronous request.
    /// </summary>
    public delegate void ExecuteRequestDelegate<T>(LazyResult<T> response);
}
