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

using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Services;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Client service request represents a specific service request with the given response type. The request supports
    /// both sync and async execution to get the response type and also sync and async methods to return only the 
    /// stream.
    /// </summary>
    public interface IClientServiceRequest<TResponse>
    {
        /// <summary> Gets the service which is related to this request.</summary>
        IClientService Service { get; }

        /// <summary> Gets the name of the method to which this request belongs.</summary>
        string MethodName { get; }

        /// <summary> Gets the rest path of this request.</summary>
        string RestPath { get; }

        /// <summary> Gets the Http method of this request.</summary>
        string HttpMethod { get; }

        /// <summary> Gets the parameters information for this specific request.</summary>
        IDictionary<string, IParameter> RequestParameters { get; }

        /// <summary> Executes the request asynchronously and returns the result stream.</summary>
        Task<Stream> ExecuteAsStreamAsync();

        /// <summary> Executes the request asynchronously and returns the result stream.</summary>
        /// <param name="cencellationToken">A cancellation token for cancelling the request in the middle of the 
        /// execution. operation.</param>
        Task<Stream> ExecuteAsStreamAsync(CancellationToken cencellationToken);

        /// <summary> Executes the request and returns the result stream.</summary>
        Stream ExecuteAsStream();

        /// <summary> Executes the request asynchronously and returns the result object.</summary>
        Task<TResponse> ExecuteAsync();

        /// <summary> Executes the request asynchronously and returns the result object.</summary>
        /// <param name="cencellationToken">A cancellation token for cancelling the request in the middle of execution.
        /// </param>
        Task<TResponse> ExecuteAsync(CancellationToken cencellationToken);

        /// <summary> Executes the request and returns the result object.</summary>
        TResponse Execute();
    }
}
