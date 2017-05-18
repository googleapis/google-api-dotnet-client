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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Services;

namespace Google.Apis.Requests
{
    /// <summary>A client service request which supports both sync and async execution to get the stream.</summary>
    public interface IClientServiceRequest
    {
        /// <summary>Gets the name of the method to which this request belongs.</summary>
        string MethodName { get; }

        /// <summary>Gets the rest path of this request.</summary>
        string RestPath { get; }

        /// <summary>Gets the HTTP method of this request.</summary>
        string HttpMethod { get; }

        /// <summary>Gets the parameters information for this specific request.</summary>
        IDictionary<string, IParameter> RequestParameters { get; }

        /// <summary>Gets the service which is related to this request.</summary>
        IClientService Service { get; }

        /// <summary>Creates a HTTP request message with all path and query parameters, ETag, etc.</summary>
        /// <param name="overrideGZipEnabled">
        /// If <c>null</c> use the service default GZip behavior. Otherwise indicates if GZip is enabled or disabled.
        /// </param>
        HttpRequestMessage CreateRequest(Nullable<bool> overrideGZipEnabled = null);

        /// <summary>Executes the request asynchronously and returns the result stream.</summary>
        Task<Stream> ExecuteAsStreamAsync();

        /// <summary>Executes the request asynchronously and returns the result stream.</summary>
        /// <param name="cancellationToken">A cancellation token to cancel operation.</param>
        Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken);

        /// <summary>Executes the request and returns the result stream.</summary>
        Stream ExecuteAsStream();
    }

    /// <summary>
    /// A client service request which inherits from <see cref="IClientServiceRequest"/> and represents a specific 
    /// service request with the given response type. It supports both sync and async execution to get the response.
    /// </summary>
    public interface IClientServiceRequest<TResponse> : IClientServiceRequest
    {
        /// <summary>Executes the request asynchronously and returns the result object.</summary>
        Task<TResponse> ExecuteAsync();

        /// <summary>Executes the request asynchronously and returns the result object.</summary>
        /// <param name="cancellationToken">A cancellation token to cancel operation.</param>
        Task<TResponse> ExecuteAsync(CancellationToken cancellationToken);

        /// <summary>Executes the request and returns the result object.</summary>
        TResponse Execute();
    }
}
