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

using System.Collections.Generic;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Represents one method as defined by the Google Api Discovery Document.
    /// This will usally be found within a resource. There may well be differnt implementations
    /// of this interface for different versions of discovery.
    /// </summary>
    /// <see cref="IResource"/>
    public interface IMethod
    {
        /// <summary>
        /// Name of this method
        /// </summary>
        string Name { get; }

        /// <summary>
        /// A description of this method
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The rest path to this method
        /// </summary>
        string RestPath { get; }

        /// <summary>
        /// The name of the RPC
        /// </summary>
        string RpcName { get; }

        /// <summary>
        /// The http method required by this method
        /// </summary>
        string HttpMethod { get; }

        /// <summary>
        /// The response type of the request
        /// </summary>
        string ResponseType { get; }

        /// <summary>
        /// The type of the request required by this method
        /// </summary>
        string RequestType { get; }

        /// <summary>
        /// Whether this request has a body attached to it.
        /// </summary>
        bool HasBody { get; }

        /// <summary>
        /// Media upload information (if this is a media upload method).
        /// </summary>
        MediaUpload MediaUpload { get; }

        /// <summary>
        /// A set of parameters passed with the request
        /// </summary>
        Dictionary<string, IParameter> Parameters { get; }

        /// <summary>
        /// The order in which parameters should be passed in a request.
        /// </summary>
        IEnumerable<string> ParameterOrder { get; }
    }
}